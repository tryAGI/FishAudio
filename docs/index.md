# FishAudio

[![Nuget package](https://img.shields.io/nuget/vpre/FishAudio)](https://www.nuget.org/packages/FishAudio/)
[![dotnet](https://github.com/tryAGI/FishAudio/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/FishAudio/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/FishAudio)](https://github.com/tryAGI/FishAudio/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features
- Fully generated C# SDK based on [official Fish Audio OpenAPI specification](https://docs.fish.audio/api-reference/openapi.json) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Microsoft.Extensions.AI `AIFunction` tools for use with any `IChatClient`

### Usage
```csharp
using FishAudio;

using var client = new FishAudioClient(apiKey);
```

### MEAI Tools
```csharp
using FishAudio;
using Microsoft.Extensions.AI;

var fishAudio = new FishAudioClient(apiKey);
var tools = new[]
{
    fishAudio.AsTextToSpeechTool(referenceId: "your-voice-model-id"),
    fishAudio.AsListModelsTool(),
    fishAudio.AsGetModelTool(),
};
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/FishAudio/issues
Priority place for ideas and general questions: https://github.com/tryAGI/FishAudio/discussions
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
