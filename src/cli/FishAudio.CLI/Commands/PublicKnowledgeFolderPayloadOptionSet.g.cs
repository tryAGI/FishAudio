#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record PublicKnowledgeFolderPayloadOptionSet(
    Option<string> NameOption)
{
    public static PublicKnowledgeFolderPayloadOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PublicKnowledgeFolderPayloadOptionSet(
                        NameOption: new Option<string>($"--{normalizedPrefix}name")
                {
                    Description = @"1-120 characters after leading and trailing whitespace is removed (a blank name is rejected). Unique within the workspace, case-sensitive.",
                    Required = true,
                }
        );
    }
}