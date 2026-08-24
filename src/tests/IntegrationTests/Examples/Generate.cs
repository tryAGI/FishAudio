/*
order: 10
title: Latest Text to Speech
slug: latest-text-to-speech

Select a voice model and synthesize audio with Fish Audio S2.1 Pro.
*/

using Microsoft.Extensions.AI;

namespace FishAudio.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(60_000)]
    public async Task Example_LatestTextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        var models = await client.Model.GetModelAsync(pageSize: 1);
        var voice = models.Items.FirstOrDefault();
        if (voice is null)
        {
            throw new AssertInconclusiveException("No Fish Audio voice model is available to this account.");
        }

        ITextToSpeechClient speech = client;
        var response = await speech.GetAudioAsync(
            "Hello from the latest Fish Audio speech model.",
            new TextToSpeechOptions
            {
                ModelId = FishAudioModels.S21ProFree,
                VoiceId = voice.Id,
                AudioFormat = "mp3",
            });

        response.Contents.OfType<DataContent>().Single().Data.ToArray().Should().NotBeEmpty();
    }
}
