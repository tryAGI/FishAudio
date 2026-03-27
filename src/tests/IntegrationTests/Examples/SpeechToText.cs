/* order: 50, title: Speech to Text, slug: speech-to-text */

using Microsoft.Extensions.AI;

namespace FishAudio.IntegrationTests;

public partial class Tests
{
    //// FishAudio implements `ISpeechToTextClient` from Microsoft.Extensions.AI,
    //// enabling speech-to-text transcription with any MEAI-compatible pipeline.

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
