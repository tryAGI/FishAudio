# Authentication

The Fish Audio API uses Bearer token authentication.

## Getting an API Key

1. Sign up at [fish.audio](https://fish.audio/)
2. Navigate to your account settings
3. Create a new API key

## Client Initialization

```csharp
using FishAudio;

var client = new FishAudioClient(
    apiKey: Environment.GetEnvironmentVariable("FISHAUDIO_API_KEY")!);
```

## Environment Variables

For integration tests, set the following environment variable:

```bash
export FISHAUDIO_API_KEY=your-api-key-here
```
