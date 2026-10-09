#nullable enable

using System.Net;
using System.Text;
using Microsoft.Extensions.AI;

namespace FishAudio.IntegrationTests;

public partial class Tests
{
    private const string ProTranscript = "<|speaker:0|> [laughter] Hello! <|speaker:1|> [surprised] Hi!";
    private const string ProResponse = """
        {"text":"<|speaker:0|> [laughter] Hello! <|speaker:1|> [surprised] Hi!",
         "duration":3.5,"segments":[{"text":"Hello","start":0.2,"end":1.1}],
         "speaker_turns":[{"speaker":"speaker:0","text":"[laughter] Hello!","start":0.2,"end":1.1},
                          {"speaker":"speaker:1","text":"[surprised] Hi!","start":2.0,"end":3.0}],
         "request_id":"pro-request","language_code":"en","language":"English"}
        """;

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task SpeechToTextClient_SelectsProAndPreservesAnnotations(bool streaming)
    {
        var handler = new StaticResponseHandler(new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(ProResponse, Encoding.UTF8, "application/json"),
        });
        using var client = new FishAudioClient("test-api-key", new HttpClient(handler));
        ISpeechToTextClient stt = client;
        using var audio = new MemoryStream();
        audio.Write([1, 2, 3]);
        audio.Position = 0;
        var options = new SpeechToTextOptions
        {
            ModelId = "transcribe-1-pro",
            SpeechLanguage = "en",
            RawRepresentationFactory = _ => new CreateAsrRequest
            {
                Audio = [], Audioname = "meeting.mp3", TagAudioEvents = false,
                Diarize = "true", NumSpeakers = 2,
            },
        };

        if (streaming)
        {
            var updates = new List<SpeechToTextResponseUpdate>();
            await foreach (var update in stt.GetStreamingTextAsync(audio, options))
            {
                updates.Add(update);
            }
            string.Concat(updates.Select(update => update.Text)).Should().Be(ProTranscript);
            updates.Should().Contain(update => update.ModelId == "transcribe-1-pro");
        }
        else
        {
            var response = await stt.GetTextAsync(audio, options);
            response.Text.Should().Be(ProTranscript);
            response.ModelId.Should().Be("transcribe-1-pro");
            response.ResponseId.Should().Be("pro-request");
            response.StartTime.Should().Be(TimeSpan.FromSeconds(0.2));
            response.EndTime.Should().Be(TimeSpan.FromSeconds(1.1));
            var raw = (CreateAsrResponse)response.RawRepresentation!;
            raw.SpeakerTurns.Should().HaveCount(2);
            raw.SpeakerTurns![1].Speaker.Should().Be("speaker:1");
            raw.SpeakerTurns[1].Text.Should().Be("[surprised] Hi!");
            raw.SpeakerTurns[1].Start.Should().Be(2);
            raw.LanguageCode.Should().Be("en");
        }

        handler.LastRequest!.RequestUri!.AbsolutePath.Should().Be("/v1/asr");
        handler.LastRequest.Headers.GetValues("model").Single().Should().Be("transcribe-1-pro");
        handler.LastRequest.Headers.Authorization!.Parameter.Should().Be("test-api-key");
        handler.LastRequestBody.Should().Contain("meeting.mp3").And.Contain("\u0001\u0002\u0003");
        handler.LastRequestBody.Should().NotContain("\u0000");
        foreach (var (name, value) in new[] { ("language", "en"), ("ignore_timestamps", "false"),
                     ("tag_audio_events", "false"), ("diarize", "true"), ("num_speakers", "2") })
        {
            handler.LastRequestBody!.Replace("\"", string.Empty, StringComparison.Ordinal).Should().Contain($"name={name}\r\n\r\n{value}");
        }
    }

    [TestMethod]
    [DataRow(null)]
    [DataRow("transcribe-1")]
    public async Task SpeechToTextClient_PreservesLegacySelection(string? modelId)
    {
        var handler = new StaticResponseHandler(new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("{\"text\":\"Hello\",\"duration\":2,\"segments\":[]}", Encoding.UTF8, "application/json"),
        });
        using var client = new FishAudioClient("test-api-key", new HttpClient(handler));
        using var audio = new MemoryStream([1, 2, 3]);
        var response = await ((ISpeechToTextClient)client).GetTextAsync(audio, new SpeechToTextOptions { ModelId = modelId });
        response.ModelId.Should().Be("transcribe-1");
        response.EndTime.Should().Be(TimeSpan.FromSeconds(2));
        ((CreateAsrResponse)response.RawRepresentation!).SpeakerTurns.Should().BeNull();
        handler.LastRequest!.Headers.GetValues("model").Single().Should().Be("transcribe-1");
        handler.LastRequestBody.Should().NotContain("diarize").And.NotContain("tag_audio_events");
    }

    [TestMethod]
    public async Task SpeechToTextClient_RejectsUnknownModelBeforeSending()
    {
        using var client = new FishAudioClient("test-api-key");
        using var audio = new MemoryStream([1]);
        Func<Task> action = () => ((ISpeechToTextClient)client).GetTextAsync(audio,
            new SpeechToTextOptions { ModelId = "Transcribe-1-Pro" });
        await action.Should().ThrowAsync<ArgumentException>();
    }

    [TestMethod]
    [DataRow("false", 2, null, null)]
    [DataRow("invalid", null, null, null)]
    [DataRow("true", 0, null, null)]
    [DataRow("auto", 2, 1, null)]
    [DataRow("auto", null, 3, 2)]
    public async Task SpeechToTextClient_RejectsInvalidSpeakerOptions(string diarize, int? count, int? min, int? max)
    {
        using var client = new FishAudioClient("test-api-key");
        Func<Task> action = () => client.OpenAPIV1.CreateAsrAsync(new CreateAsrRequest
        {
            Audio = [1], Audioname = "audio.wav", Diarize = diarize,
            NumSpeakers = count, MinSpeakers = min, MaxSpeakers = max,
        }, model: CreateAsrModel.Transcribe1Pro);
        await action.Should().ThrowAsync<ArgumentException>();
    }
}
