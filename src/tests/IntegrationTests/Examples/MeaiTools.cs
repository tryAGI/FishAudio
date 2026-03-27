/* order: 40, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace FishAudio.IntegrationTests;

public partial class Tests
{
    //// FishAudio provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// text-to-speech, voice model listing, and voice model details.

    [TestMethod]
    public async Task Meai_AsTextToSpeechTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that converts text to speech:
        var tool = client.AsTextToSpeechTool();

        tool.Name.Should().Be("FishAudioTextToSpeech");
        tool.Description.Should().Contain("Fish Audio");
    }

    [TestMethod]
    public async Task Meai_AsListModelsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists available voice models:
        var tool = client.AsListModelsTool();

        tool.Name.Should().Be("FishAudioListModels");
        tool.Description.Should().Contain("voice models");
    }

    [TestMethod]
    public async Task Meai_AsGetModelTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that gets details for a specific voice model:
        var tool = client.AsGetModelTool();

        tool.Name.Should().Be("FishAudioGetModel");
        tool.Description.Should().Contain("voice model");
    }
}
