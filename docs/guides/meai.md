# Microsoft.Extensions.AI Integration

FishAudio provides `AIFunction` tools compatible with
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI),
allowing any `IChatClient` to perform text-to-speech synthesis, list voice models,
and retrieve voice model details via Fish Audio.

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
