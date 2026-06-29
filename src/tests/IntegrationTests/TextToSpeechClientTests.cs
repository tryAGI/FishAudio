#nullable enable
#pragma warning disable MEAI001

using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace FishAudio.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TextToSpeechClient_GetService_Metadata()
    {
        using var client = new FishAudioClient("test-api-key");
        ITextToSpeechClient ttsClient = client;

        var metadata = ttsClient.GetService<TextToSpeechClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("fish-audio");
        metadata.DefaultModelId.Should().Be("s2.1-pro-free");
        ttsClient.GetService<FishAudioClient>().Should().BeSameAs(client);
    }

    [TestMethod]
    public async Task TextToSpeechClient_MapsOptionsToTtsRequest()
    {
        var handler = new StaticResponseHandler(
            new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent([1, 2, 3])
                {
                    Headers =
                    {
                        ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("audio/wav"),
                    },
                },
                Headers =
                {
                    { "request-id", "fish-request-id" },
                },
            });
        using var client = new FishAudioClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(FishAudioClient.DefaultBaseUrl),
            });
        ITextToSpeechClient ttsClient = client;
        TTSRequest? capturedRequest = null;

        var response = await ttsClient.GetAudioAsync(
            "Hello from Fish Audio.",
            new TextToSpeechOptions
            {
                ModelId = "s2.1-pro-free",
                VoiceId = "voice-model-id",
                AudioFormat = "wav",
                Speed = 1.15f,
                Volume = -1.5f,
                AdditionalProperties = new()
                {
                    [FishAudioTextToSpeechPropertyNames.SampleRate] = 24000,
                    [FishAudioTextToSpeechPropertyNames.Latency] = "low",
                    [FishAudioTextToSpeechPropertyNames.Temperature] = 0.6d,
                    [FishAudioTextToSpeechPropertyNames.NormalizeLoudness] = true,
                    [FishAudioTextToSpeechPropertyNames.ChunkLength] = 200,
                },
                RawRepresentationFactory = _ =>
                {
                    capturedRequest = new TTSRequest
                    {
                        Text = string.Empty,
                    };

                    return capturedRequest;
                },
            });

        capturedRequest.Should().NotBeNull();
        capturedRequest!.Text.Should().Be("Hello from Fish Audio.");
        capturedRequest.ReferenceId!.Value.PickValue1().Should().Be("voice-model-id");
        capturedRequest.Format.Should().Be(TTSRequestFormat.Wav);
        capturedRequest.SampleRate.Should().Be(24000);
        capturedRequest.Latency.Should().Be(TTSRequestLatency.Low);
        capturedRequest.Temperature.Should().Be(0.6d);
        capturedRequest.ChunkLength.Should().Be(200);
        capturedRequest.Prosody.Should().NotBeNull();
        capturedRequest.Prosody!.Speed.Should().BeApproximately(1.15d, 0.00001d);
        capturedRequest.Prosody.Volume.Should().BeApproximately(-1.5d, 0.00001d);
        capturedRequest.Prosody.NormalizeLoudness.Should().BeTrue();

        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.AbsolutePath.Should().Be("/v1/tts");
        handler.LastRequest.Headers.Authorization!.Scheme.Should().Be("Bearer");
        handler.LastRequest.Headers.Authorization.Parameter.Should().Be("test-api-key");
        handler.LastRequest.Headers.GetValues("model").Single().Should().Be("s2.1-pro-free");

        using var document = JsonDocument.Parse(handler.LastRequestBody!);
        document.RootElement.GetProperty("text").GetString().Should().Be("Hello from Fish Audio.");
        document.RootElement.GetProperty("reference_id").GetString().Should().Be("voice-model-id");
        document.RootElement.GetProperty("format").GetString().Should().Be("wav");

        response.Contents.OfType<DataContent>().Single().Data.ToArray().Should().Equal([1, 2, 3]);
        response.ModelId.Should().Be("s2.1-pro-free");
        response.AdditionalProperties!["request_id"].Should().Be("fish-request-id");
    }

    [TestMethod]
    public async Task TextToSpeechClient_StreamsAudioChunks()
    {
        var sseBody = string.Join("\n\n",
            "data: {\"audio_base64\":\"AQID\",\"content\":\"Hello\",\"chunk_seq\":0,\"chunk_audio_offset_sec\":0}",
            "data: {\"audio_base64\":\"BAU=\",\"content\":\"World\",\"chunk_seq\":1,\"chunk_audio_offset_sec\":0.25}",
            string.Empty);
        var handler = new StaticResponseHandler(
            new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(sseBody, Encoding.UTF8, "text/event-stream"),
            });
        using var client = new FishAudioClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(FishAudioClient.DefaultBaseUrl),
            });
        ITextToSpeechClient ttsClient = client;

        var updates = new List<TextToSpeechResponseUpdate>();
        await foreach (var update in ttsClient.GetStreamingAudioAsync(
            "Streaming Fish Audio speech.",
            new TextToSpeechOptions
            {
                ModelId = "s2.1-pro-free",
                AudioFormat = "mp3",
            }))
        {
            updates.Add(update);
        }

        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.Headers.GetValues("model").Single().Should().Be("s2.1-pro-free");

        updates.First().Kind.Should().Be(TextToSpeechResponseUpdateKind.SessionOpen);
        updates.Where(static update => update.Kind == TextToSpeechResponseUpdateKind.AudioUpdating)
            .SelectMany(static update => update.Contents.OfType<DataContent>())
            .SelectMany(static content => content.Data.ToArray())
            .Should().Equal([1, 2, 3, 4, 5]);
        updates.Should().Contain(static update => update.Kind == TextToSpeechResponseUpdateKind.AudioUpdated);
        updates.Last().Kind.Should().Be(TextToSpeechResponseUpdateKind.SessionClose);
    }

    private sealed class StaticResponseHandler(HttpResponseMessage response) : HttpMessageHandler
    {
        public HttpRequestMessage? LastRequest { get; private set; }
        public string? LastRequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            LastRequest = request;
            LastRequestBody = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            response.RequestMessage = request;

            return response;
        }
    }
}
