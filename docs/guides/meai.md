# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The FishAudio SDK implements `ITextToSpeechClient` and `ISpeechToTextClient`, and provides `AIFunction` tool wrappers, all compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## ITextToSpeechClient

FishAudio implements `ITextToSpeechClient` for text-to-speech synthesis using
the `/v1/tts` and `/v1/tts/stream-with-timestamps` endpoints. The default model
is `s2.1-pro-free`; pass `TextToSpeechOptions.ModelId` to select `s2.1-pro`,
`s2-pro`, `s1`, or another model string supported by Fish Audio.

```csharp
using FishAudio;
using Microsoft.Extensions.AI;

ITextToSpeechClient client = new FishAudioClient(apiKey);

var response = await client.GetAudioAsync(
    "Hello from Fish Audio.",
    new TextToSpeechOptions
    {
        VoiceId = "your-voice-model-id",
        ModelId = "s2.1-pro-free",
        AudioFormat = "mp3",
    });

var audio = response.Contents.OfType<DataContent>().Single();
await File.WriteAllBytesAsync("fish-audio.mp3", audio.Data.ToArray());
```

### Text-to-Speech Options

- **ModelId**: Sets the Fish Audio `model` header. Defaults to `s2.1-pro-free`.
- **VoiceId**: Maps to Fish Audio `reference_id` for a single voice model.
- **AudioFormat**: Supports `mp3`, `wav`, `pcm`, and `opus`.
- **Speed** and **Volume**: Map to Fish Audio `prosody.speed` and `prosody.volume`.
- **RawRepresentationFactory**: Pass a pre-configured `TTSRequest` or `TTSStreamWithTimestampRequest` for full control.

Use `AdditionalProperties` with `FishAudioTextToSpeechPropertyNames` for
provider-specific controls such as `Latency`, `SampleRate`, `Temperature`,
`ChunkLength`, and `NormalizeLoudness`.

```csharp
var response = await client.GetAudioAsync(
    "Use low latency synthesis.",
    new TextToSpeechOptions
    {
        VoiceId = "your-voice-model-id",
        ModelId = "s2.1-pro-free",
        AudioFormat = "wav",
        Speed = 1.1f,
        AdditionalProperties = new()
        {
            [FishAudioTextToSpeechPropertyNames.Latency] = "low",
            [FishAudioTextToSpeechPropertyNames.SampleRate] = 24000,
        },
    });
```

### Streaming Text-to-Speech

`GetStreamingAudioAsync` uses Fish Audio's timestamp streaming endpoint and emits
MEAI `TextToSpeechResponseUpdate` events. Audio chunks arrive as `DataContent`,
and the provider event is available in `RawRepresentation`.

```csharp
await foreach (var update in client.GetStreamingAudioAsync(
    "Stream this sentence.",
    new TextToSpeechOptions
    {
        VoiceId = "your-voice-model-id",
        ModelId = "s2.1-pro-free",
    }))
{
    foreach (var chunk in update.Contents.OfType<DataContent>())
    {
        await output.WriteAsync(chunk.Data);
    }
}
```

## ISpeechToTextClient

FishAudio implements `ISpeechToTextClient` for speech-to-text transcription
using the `/v1/asr` endpoint.

```csharp
using FishAudio;
using Microsoft.Extensions.AI;

ISpeechToTextClient client = new FishAudioClient(apiKey);

// Transcribe audio from a file
await using var audioStream = File.OpenRead("audio.wav");
var response = await client.GetTextAsync(audioStream);

Console.WriteLine(response.Text);
Console.WriteLine($"Duration: {response.EndTime}");
```

### Options

- **SpeechLanguage**: Set the transcription language (e.g., `"en"`, `"zh"`)
- **RawRepresentationFactory**: Pass a pre-configured `CreateAsrRequest` for full control

```csharp
var options = new SpeechToTextOptions
{
    SpeechLanguage = "en",
};
var response = await client.GetTextAsync(audioStream, options);
```

### Advanced Configuration with RawRepresentationFactory

Use `RawRepresentationFactory` to access Fish Audio-specific ASR features like timestamp control and language selection:

```csharp
ISpeechToTextClient client = new FishAudioClient(apiKey);

await using var audioStream = File.OpenRead("audio.wav");
var response = await client.GetTextAsync(audioStream, new SpeechToTextOptions
{
    RawRepresentationFactory = _ => new CreateAsrRequest
    {
        Audio = [],  // Will be filled from the audio stream automatically
        Audioname = "meeting.wav",
        Language = "en",
        IgnoreTimestamps = false,  // Enable segment-level timestamps
    },
});

Console.WriteLine(response.Text);
```

### Accessing the Raw Response

The full Fish Audio ASR response is available via `RawRepresentation` for segment-level timestamps and duration:

```csharp
ISpeechToTextClient client = new FishAudioClient(apiKey);

await using var audioStream = File.OpenRead("audio.wav");
var response = await client.GetTextAsync(audioStream);

// Access the provider-specific response
var raw = (CreateAsrResponse)response.RawRepresentation!;
Console.WriteLine($"Duration: {raw.Duration}s");

// Access segment-level timestamps
if (raw.Segments is { Count: > 0 })
{
    foreach (var segment in raw.Segments)
    {
        Console.WriteLine($"  [{segment.Start:F2}s - {segment.End:F2}s] {segment.Text}");
    }
}
```

### Streaming Behavior

`GetStreamingTextAsync` delegates to the non-streaming `GetTextAsync` method internally. The Fish Audio ASR API processes audio synchronously, and then the full result is converted to `SpeechToTextResponseUpdate` events using `ToSpeechToTextResponseUpdates()`.

This means you will not receive incremental transcription updates as audio is processed. The entire transcript is returned at once after processing completes. For most use cases, calling `GetTextAsync` directly is equivalent and simpler.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsTextToSpeechTool()` | `FishAudioTextToSpeech` | Converts text to speech audio using Fish Audio's TTS API. |
| `AsListModelsTool()` | `FishAudioListModels` | Lists available voice models, optionally filtered by title. |
| `AsGetModelTool()` | `FishAudioGetModel` | Gets details for a specific voice model by ID. |

## Usage

```csharp
using FishAudio;
using Microsoft.Extensions.AI;

var fishAudio = new FishAudioClient(apiKey);

// Create tools
var tools = new[]
{
    fishAudio.AsTextToSpeechTool(referenceId: "your-voice-model-id"),
    fishAudio.AsListModelsTool(pageSize: 5),
    fishAudio.AsGetModelTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "List available voice models and generate speech saying 'Hello World'",
    new ChatOptions { Tools = tools });
```

## Tool Details

### FishAudioTextToSpeech

Converts text to speech using Fish Audio's TTS API. Supports 50+ languages,
voice cloning, and multi-speaker synthesis. Accepts an optional `referenceId` parameter
to specify a default voice model, and a `model` parameter to choose between `s2-pro` (default)
and `s1`.

```csharp
var tool = fishAudio.AsTextToSpeechTool(
    referenceId: "your-voice-id",
    model: CreateTtsModel.S2Pro);
```

### FishAudioListModels

Lists available voice models from Fish Audio. Returns model IDs, titles, descriptions,
languages, and popularity metrics. Accepts a `pageSize` parameter (default: 10).

```csharp
var tool = fishAudio.AsListModelsTool(pageSize: 20);
```

### FishAudioGetModel

Gets details for a specific Fish Audio voice model by its ID. Returns the model title,
description, languages, state, tags, and sample information.

```csharp
var tool = fishAudio.AsGetModelTool();
```
