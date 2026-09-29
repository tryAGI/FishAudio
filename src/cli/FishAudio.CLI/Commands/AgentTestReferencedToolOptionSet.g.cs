#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record AgentTestReferencedToolOptionSet(
    Option<string> Id,
                     Option<string> NameOption,
                     Option<global::FishAudio.AgentTestReferencedToolType?> Type,
                     Option<string?> DescriptionOption)
{
    public static AgentTestReferencedToolOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AgentTestReferencedToolOptionSet(
                        Id: new Option<string>($"--{normalizedPrefix}id")
                {
                    Description = @"",
                    Required = true,
                },
                NameOption: new Option<string>($"--{normalizedPrefix}name")
                {
                    Description = @"",
                    Required = true,
                },
                Type: new Option<global::FishAudio.AgentTestReferencedToolType?>($"--{normalizedPrefix}type")
                {
                    Description = @"",
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"",
                }
        );
    }
}