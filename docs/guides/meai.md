# Microsoft.Extensions.AI Integration

FishAudio implements
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI)
interfaces for speech-to-text transcription, plus `AIFunction` tools for
text-to-speech synthesis, voice model listing, and voice model details.

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
