namespace FishAudio.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static FishAudioClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("FISHAUDIO_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("FISHAUDIO_API_KEY environment variable is not found.");

        var client = new FishAudioClient(apiKey);
        
        return client;
    }
}
