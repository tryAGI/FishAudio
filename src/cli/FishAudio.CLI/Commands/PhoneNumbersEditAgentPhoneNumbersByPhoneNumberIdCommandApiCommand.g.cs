#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PhoneNumbersEditAgentPhoneNumbersByPhoneNumberIdCommandApiCommand
{
    private static Argument<string> PhoneNumberId { get; } = new(
        name: @"phone-number-id")
    {
        Description = @"",
    };

    private static Option<string?> Label { get; } = new(
        name: @"--label")
    {
        Description = @"",
    };

    private static Option<string?> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"Agent that answers this number's inbound calls. Explicit null unbinds; omit the field to keep the current binding.",
    };

    private static Option<global::FishAudio.PublicPhoneNumberUpdatePayloadTransferCallerId?> TransferCallerId { get; } = new(
        name: @"--transfer-caller-id")
    {
        Description = @"Managed `twilio` numbers only: the caller ID a transfer target sees, `agent_number` (this number) or `original_caller` (the caller's own number). Applies to cold and warm transfers. It is a number setting, not agent config: no publish is needed and agent rollbacks leave it alone. Warm transfers follow it from the next call, cold transfers once `caller_id_sync_status` is `synced`. The deprecated boolean `cold_transfer_use_original_caller` is still accepted in its place.",
    };

    private static Option<bool?> RetryCallerIdSync { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--retry-caller-id-sync",
        description: @"Re-apply the current caller ID policy after a failed synchronization.");
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.PatchAgentPhoneNumbersResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.PatchAgentPhoneNumbersResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"edit-agent-phone-numbers-by-phone-number-id", @"Update Phone Number
Change the label and/or repoint the number at another agent — the
deployment-pipeline move (rebind from the staging agent to the production
one). Send `agent_id: null` to unbind; unbound numbers ring busy. The
agent must live in the number's workspace. Rebinding is a routing-table
update resolved on the next inbound call; nothing about the number itself
is reprovisioned.

Managed `twilio` numbers also accept `transfer_caller_id`, which picks
the number a transfer target sees (cold and warm alike), and
`retry_caller_id_sync` to re-apply it after a failed synchronization. Read
`caller_id_sync_status` on the response. Imported `sip` numbers return 409
for either field because their carrier owns the setting.

Every field here is a number setting, not agent config: changes apply
from the next call without publishing, and publishing or rolling back the
agent never changes them. Cold-transfer caller ID applies once
`caller_id_sync_status` is `synced`.");
                        command.Arguments.Add(PhoneNumberId);
                        command.Options.Add(Label);
                        command.Options.Add(AgentId);
                        command.Options.Add(TransferCallerId);
                        command.Options.Add(RetryCallerIdSync);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PublicPhoneNumberUpdatePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var phoneNumberId = parseResult.GetRequiredValue(PhoneNumberId);
                        var label = CliRuntime.WasSpecified(parseResult, Label) ? parseResult.GetValue(Label) : (__requestBase is { } __LabelBaseValue ? __LabelBaseValue.Label : default);
                        var agentId = CliRuntime.WasSpecified(parseResult, AgentId) ? parseResult.GetValue(AgentId) : (__requestBase is { } __AgentIdBaseValue ? __AgentIdBaseValue.AgentId : default);
                        var transferCallerId = CliRuntime.WasSpecified(parseResult, TransferCallerId) ? parseResult.GetValue(TransferCallerId) : (__requestBase is { } __TransferCallerIdBaseValue ? __TransferCallerIdBaseValue.TransferCallerId : default);
                        var retryCallerIdSync = CliRuntime.WasSpecified(parseResult, RetryCallerIdSync) ? parseResult.GetValue(RetryCallerIdSync) : (__requestBase is { } __RetryCallerIdSyncBaseValue ? __RetryCallerIdSyncBaseValue.RetryCallerIdSync : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PhoneNumbers.EditAgentPhoneNumbersByPhoneNumberIdAsync(
                                    phoneNumberId: phoneNumberId,
                                    label: label,
                                    agentId: agentId,
                                    transferCallerId: transferCallerId,
                                    retryCallerIdSync: retryCallerIdSync,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"InboundAllowedAddresses",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::FishAudio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}