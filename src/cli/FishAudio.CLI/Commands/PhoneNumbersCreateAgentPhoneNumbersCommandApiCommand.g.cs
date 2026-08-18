#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PhoneNumbersCreateAgentPhoneNumbersCommandApiCommand
{
    private static Option<string> Provider { get; } = new(
        name: @"--provider")
    {
        Description = @"Inventory to buy from. Only the managed `twilio` inventory is purchasable (supports call transfer). The field discriminates so importing your own numbers can share this endpoint later.",
        DefaultValueFactory = _ => "twilio",
    };

    private static Option<string> PhoneNumber { get; } = new(
        name: @"--phone-number")
    {
        Description = @"E.164 number from `GET /v1/agent/available-phone-numbers`, e.g. +14155550123.",
        Required = true,
    };

    private static Option<string?> Label { get; } = new(
        name: @"--label")
    {
        Description = @"",
    };

    private static Option<string?> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"Bind an agent to answer inbound calls right away.",
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateAgentPhoneNumbersResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateAgentPhoneNumbersResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-agent-phone-numbers", @"Purchase Phone Number
Buy a number from the inventory. The number lands in your default
workspace, and any `agent_id` you bind must live there too. Billing is the
monthly price charged in daily slices: the first day is charged before
anything is bought (402 costs you nothing), and the daily run advances it
from there. 409 means the number is already on the platform; 502 means the
provider refused the purchase; the number stays visible with status
`error` and is safe to release.");
                        command.Options.Add(Provider);
                        command.Options.Add(PhoneNumber);
                        command.Options.Add(Label);
                        command.Options.Add(AgentId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PublicPhoneNumberPurchasePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var provider = parseResult.GetRequiredValue(Provider);
                        var phoneNumber = parseResult.GetRequiredValue(PhoneNumber);
                        var label = CliRuntime.WasSpecified(parseResult, Label) ? parseResult.GetValue(Label) : (__requestBase is { } __LabelBaseValue ? __LabelBaseValue.Label : default);
                        var agentId = CliRuntime.WasSpecified(parseResult, AgentId) ? parseResult.GetValue(AgentId) : (__requestBase is { } __AgentIdBaseValue ? __AgentIdBaseValue.AgentId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PhoneNumbers.CreateAgentPhoneNumbersAsync(
                                    provider: provider,
                                    phoneNumber: phoneNumber,
                                    label: label,
                                    agentId: agentId,
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