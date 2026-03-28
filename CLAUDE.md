# CLAUDE.md -- FishAudio SDK

## Overview

Auto-generated C# SDK for [Fish Audio](https://fish.audio/) -- AI-powered text-to-speech (TTS) and automatic speech recognition (ASR) API with voice cloning, multi-speaker synthesis, and 50+ languages.
OpenAPI spec downloaded from `https://docs.fish.audio/api-reference/openapi.json`.

## Build & Test

```bash
dotnet build FishAudio.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new FishAudioClient(apiKey); // FISHAUDIO_API_KEY env var
```

## Key Files

- `src/libs/FishAudio/openapi.json` -- OpenAPI spec (downloaded from Fish Audio docs)
- `src/libs/FishAudio/generate.sh` -- Downloads spec, runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/FishAudio/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/FishAudio/Extensions/FishAudioClient.SpeechToTextClient.cs` -- MEAI `ISpeechToTextClient` implementation (file transcription with timestamps)
- `src/libs/FishAudio/Extensions/FishAudioClient.AsTool.cs` -- MEAI `AIFunction` tools (TextToSpeech, ListModels, GetModel)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- Fish Audio spec already uses `http/bearer` securitySchemes natively
- `--security-scheme Http:Header:Bearer` ensures AutoSDK generates Bearer constructors (no jq spec patching needed)
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

Fish Audio API has tagged operations generating sub-clients:
- `client.OpenAPIV1.*` -- TTS synthesis (`CreateTtsAsync`) and ASR transcription (`CreateAsrAsync`)
- `client.Model.*` -- List, get, create, update, and delete voice models
- `client.Wallet.*` -- Get credits/balance and list packages

## MEAI Integration

### ISpeechToTextClient

`FishAudioClient` implements `ISpeechToTextClient` for file-based speech recognition:
- Synchronous ASR via `/v1/asr` endpoint
- Supports language selection via `SpeechToTextOptions.SpeechLanguage`
- Returns timestamps when available (from segments or duration)
- Streaming delegates to synchronous implementation (Fish Audio ASR is not streaming)
- Supports `RawRepresentationFactory` for custom `CreateAsrRequest` configuration

### AIFunction Tools

Tools for use with any `IChatClient`:
- `AsTextToSpeechTool(referenceId, model)` -- Text-to-speech synthesis (S2-Pro model, MP3 output)
- `AsListModelsTool(pageSize)` -- List available voice models with optional title filter
- `AsGetModelTool()` -- Get details of a specific voice model by ID
