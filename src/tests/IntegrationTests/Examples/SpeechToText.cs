/* order: 50, title: Speech to Text, slug: speech-to-text */

using Microsoft.Extensions.AI;

namespace FishAudio.IntegrationTests;

public partial class Tests
{
    //// FishAudio implements `ISpeechToTextClient` from Microsoft.Extensions.AI,
    //// enabling speech-to-text transcription with any MEAI-compatible pipeline.

    //// Select the new ASR model with `SpeechToTextOptions.ModelId = "transcribe-1-pro"`.
    //// The annotated transcript retains speaker markers and cues such as `[laughter]`.
    //// For speaker controls, return a `CreateAsrRequest` from `RawRepresentationFactory`
    //// with `Diarize`, `NumSpeakers` (or `MinSpeakers`/`MaxSpeakers`), and `TagAudioEvents`.
    //// Read typed `SpeakerTurns` and `RequestId` from the response's `CreateAsrResponse`
    //// raw representation. The adapter requests timestamps unless explicitly disabled.
    //// Direct API callers can use `client.OpenAPIV1.CreateAsrAsync(request,
    //// model: CreateAsrModel.Transcribe1Pro)`. The model travels in the HTTP header.
    //// Existing callers default to `transcribe-1`; unknown model IDs are rejected locally.
    //// For long recordings, configure your HTTP client timeout (for example 15 minutes).

    [TestMethod]
    public async Task Meai_GetServiceMetadata()
    {
        using var client = GetAuthenticatedClient();

        //// The client can be used as an ISpeechToTextClient:
        ISpeechToTextClient sttClient = client;

        var metadata = sttClient.GetService<SpeechToTextClientMetadata>();
        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("fish-audio");
    }

    [TestMethod]
    public async Task Meai_GetSelfService()
    {
        using var client = GetAuthenticatedClient();

        //// You can retrieve the underlying FishAudioClient from the interface:
        ISpeechToTextClient sttClient = client;

        var self = sttClient.GetService<FishAudioClient>();
        self.Should().BeSameAs(client);
    }
}
