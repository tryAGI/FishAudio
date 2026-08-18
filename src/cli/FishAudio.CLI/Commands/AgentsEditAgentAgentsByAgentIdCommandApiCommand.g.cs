#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentsEditAgentAgentsByAgentIdCommandApiCommand
{
    private static Argument<string> AgentId { get; } = new(
        name: @"agent-id")
    {
        Description = @"",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentUpdatePayloadStatus2?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"",
    };

    private static Option<bool?> PublicEnabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--public-enabled",
        description: @"Allow keyless session creation from the browser SDK, gated by allowed_origins.");

    private static Option<global::System.Collections.Generic.IList<string>?> AllowedOrigins { get; } = new(
        name: @"--allowed-origins")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>?> OverridesAllowed { get; } = new(
        name: @"--overrides-allowed")
    {
        Description = @"Which session-creation overrides callers may use. An empty list rejects all overrides.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.PatchAgentAgentsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.PatchAgentAgentsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-agent-agents-by-agent-id", @"Update Agent
Update agent-level fields (name, description, status, public access and
session-override policy). Omitted fields keep their value. Conversation
behavior — voice, prompt, recording and the rest — is draft configuration:
use `PATCH /v1/agent/agents/{agent_id}/config`.");
                        command.Arguments.Add(AgentId);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Status);
                        command.Options.Add(PublicEnabled);
                        command.Options.Add(AllowedOrigins);
                        command.Options.Add(OverridesAllowed);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PublicAgentUpdatePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var status = CliRuntime.WasSpecified(parseResult, Status) ? parseResult.GetValue(Status) : (__requestBase is { } __StatusBaseValue ? __StatusBaseValue.Status : default);
                        var publicEnabled = CliRuntime.WasSpecified(parseResult, PublicEnabled) ? parseResult.GetValue(PublicEnabled) : (__requestBase is { } __PublicEnabledBaseValue ? __PublicEnabledBaseValue.PublicEnabled : default);
                        var allowedOrigins = CliRuntime.WasSpecified(parseResult, AllowedOrigins) ? parseResult.GetValue(AllowedOrigins) : (__requestBase is { } __AllowedOriginsBaseValue ? __AllowedOriginsBaseValue.AllowedOrigins : default);
                        var overridesAllowed = CliRuntime.WasSpecified(parseResult, OverridesAllowed) ? parseResult.GetValue(OverridesAllowed) : (__requestBase is { } __OverridesAllowedBaseValue ? __OverridesAllowedBaseValue.OverridesAllowed : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.EditAgentAgentsByAgentIdAsync(
                                    agentId: agentId,
                                    name: name,
                                    description: description,
                                    status: status,
                                    publicEnabled: publicEnabled,
                                    allowedOrigins: allowedOrigins,
                                    overridesAllowed: overridesAllowed,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::FishAudio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}