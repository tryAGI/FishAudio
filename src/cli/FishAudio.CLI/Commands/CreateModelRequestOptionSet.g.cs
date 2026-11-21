#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record CreateModelRequestOptionSet(
    Option<global::FishAudio.CreateModelRequestVisibility?> Visibility,
                     Option<string> Type,
                     Option<string> Title,
                     Option<string?> DescriptionOption,
                     Option<string?> CoverImagename,
                     Option<string> TrainMode,
                     Option<bool?> EnhanceAudioQuality,
                     Option<bool?> GenerateSample)
{
    public static CreateModelRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateModelRequestOptionSet(
                        Visibility: new Option<global::FishAudio.CreateModelRequestVisibility?>($"--{normalizedPrefix}visibility")
                {
                    Description = @"Model visibility. Public requests are downgraded to private; use the web publish flow to publish publicly. Unlist allows anyone with the link to access, while private is visible only to the creator.",
                },
                Type: new Option<string>($"--{normalizedPrefix}type")
                {
                    Description = @"Model type, tts is for text to speech",
                    DefaultValueFactory = _ => "tts",
                },
                Title: new Option<string>($"--{normalizedPrefix}title")
                {
                    Description = @"Model title or name",
                    Required = true,
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"Model description",
                },
                CoverImagename: new Option<string?>($"--{normalizedPrefix}cover-imagename")
                {
                    Description = @"Model cover image, this is required if the model is public",
                },
                TrainMode: new Option<string>($"--{normalizedPrefix}train-mode")
                {
                    Description = @"Model train mode, for TTS model, fast means model instantly available after creation",
                    DefaultValueFactory = _ => "fast",
                },
                EnhanceAudioQuality: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}enhance-audio-quality", description: @"Enhance audio quality"),
                GenerateSample: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}generate-sample", description: @"Generate default text")
        );
    }
}