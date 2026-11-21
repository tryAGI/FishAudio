#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record PatchModelRequestOptionSet(
    Option<string?> Title,
                     Option<string?> DescriptionOption,
                     Option<string?> CoverImagename)
{
    public static PatchModelRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PatchModelRequestOptionSet(
                        Title: new Option<string?>($"--{normalizedPrefix}title")
                {
                    Description = @"",
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"",
                },
                CoverImagename: new Option<string?>($"--{normalizedPrefix}cover-imagename")
                {
                    Description = @"",
                }
        );
    }
}