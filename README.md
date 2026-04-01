<div class="docs-hero">
  <h1>FishAudio</h1>
  <p class="docs-hero-lead">.NET SDK for Fish Audio generation APIs with generated REST coverage and Microsoft.Extensions.AI tool adapters.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/FishAudio/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/FishAudio"></a>
    <a href="https://github.com/tryAGI/FishAudio/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/FishAudio/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/FishAudio/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/FishAudio"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated API coverage</h3>
    <p>Built from the <a href="https://docs.fish.audio/api-reference/openapi.json">Fish Audio OpenAPI definition</a> so the SDK stays aligned with the published API.</p>
  </div>
  <div class="docs-feature-card">
    <h3>MEAI tools</h3>
    <p>Expose common operations as <code>AIFunction</code> tools for use with any compatible <code>IChatClient</code>.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Generated with AutoSDK and shaped for trimming, NativeAOT awareness, nullability, and current .NET conventions.</p>
  </div>
</div>

## Usage

### Installation
```bash
dotnet add package FishAudio
```

### Client
```csharp
using FishAudio;

using var client = new FishAudioClient(apiKey);
```

## MEAI Tools
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

<div class="docs-callout">
  <strong>Guides first.</strong> See the authentication and MEAI guides in the docs nav for provider-specific setup before running examples.
</div>

<!-- EXAMPLES:START -->
### Generate
Basic example showing how to create a client and make a request.

```csharp
using var client = new FishAudioClient(apiKey);
```
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/FishAudio/issues">tryAGI/FishAudio</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/FishAudio/discussions">GitHub Discussions</a> for feedback and design discussion.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader SDK discussion.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
