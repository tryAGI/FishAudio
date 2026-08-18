#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PhoneCallsCreateAgentPhoneCallsCommandApiCommand
{
    private static Option<string?> IdempotencyKey { get; } = new(
        name: @"--idempotency-key")
    {
        Description = @"Retry-safe replay key: the same key with the same body returns the call already placed instead of dialing again (24h window).",
    };

    private static Option<string> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> PhoneNumberId { get; } = new(
        name: @"--phone-number-id")
    {
        Description = @"The team-owned number to dial from (twilio provider only).",
        Required = true,
    };

    private static Option<string> ToNumber { get; } = new(
        name: @"--to-number")
    {
        Description = @"Destination in E.164, e.g. +14155550123.",
        Required = true,
    };

    private static Option<object?> DynamicVariables { get; } = new(
        name: @"--dynamic-variables")
    {
        Description = @"",
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };
    private static readonly AgentSessionOverridesPayloadOptionSet OverridesOptions = AgentSessionOverridesPayloadOptionSet.Create(@"overrides");
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateAgentPhoneCallsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateAgentPhoneCallsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-agent-phone-calls", @"Create Phone Call
Place an outbound call from one of your Twilio phone numbers to a US,
Canada or Japan destination. A domestic trunk 0 after +81 (e.g.
+81080...) is accepted and normalized to E.164 (+8180...). Returns
immediately with the session queued for
dialing; subscribe to the `phone_call.dial_finished` webhook or poll
`GET /v1/agent/sessions/{session_id}` for the dial outcome. Ringing is
never billed — metering starts when the callee answers.

Errors carry a machine-readable `reason` (e.g. `destination_not_allowed`,
`insufficient_credit`, `daily_limit_exceeded`,
`concurrency_limit_exceeded`).");
                        command.Options.Add(IdempotencyKey);
                        command.Options.Add(AgentId);
                        command.Options.Add(PhoneNumberId);
                        command.Options.Add(ToNumber);
                        command.Options.Add(DynamicVariables);
                        command.Options.Add(Metadata);                        command.Options.Add(OverridesOptions.FirstMessage);
                        command.Options.Add(OverridesOptions.FirstMessagePrompt);
                        command.Options.Add(OverridesOptions.SystemPrompt);
                        command.Options.Add(OverridesOptions.VoiceId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PhoneCallCreatePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var idempotencyKey = parseResult.GetValue(IdempotencyKey);
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var phoneNumberId = parseResult.GetRequiredValue(PhoneNumberId);
                        var toNumber = parseResult.GetRequiredValue(ToNumber);
                        var dynamicVariables = CliRuntime.WasSpecified(parseResult, DynamicVariables) ? parseResult.GetValue(DynamicVariables) : (__requestBase is { } __DynamicVariablesBaseValue ? __DynamicVariablesBaseValue.DynamicVariables : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);

                        var __OverridesBase = __requestBase is { } __OverridesBaseValue ? __OverridesBaseValue.Overrides : default;                        var overridesFirstMessage = CliRuntime.WasSpecified(parseResult, OverridesOptions.FirstMessage) ? parseResult.GetValue(OverridesOptions.FirstMessage) : (__OverridesBase is { } __OverridesfirstMessageBaseValue ? __OverridesfirstMessageBaseValue.FirstMessage : default);
                        var overridesFirstMessagePrompt = CliRuntime.WasSpecified(parseResult, OverridesOptions.FirstMessagePrompt) ? parseResult.GetValue(OverridesOptions.FirstMessagePrompt) : (__OverridesBase is { } __OverridesfirstMessagePromptBaseValue ? __OverridesfirstMessagePromptBaseValue.FirstMessagePrompt : default);
                        var overridesSystemPrompt = CliRuntime.WasSpecified(parseResult, OverridesOptions.SystemPrompt) ? parseResult.GetValue(OverridesOptions.SystemPrompt) : (__OverridesBase is { } __OverridessystemPromptBaseValue ? __OverridessystemPromptBaseValue.SystemPrompt : default);
                        var overridesVoiceId = CliRuntime.WasSpecified(parseResult, OverridesOptions.VoiceId) ? parseResult.GetValue(OverridesOptions.VoiceId) : (__OverridesBase is { } __OverridesvoiceIdBaseValue ? __OverridesvoiceIdBaseValue.VoiceId : default);
                        var __OverridesSpecified = CliRuntime.WasSpecified(parseResult, OverridesOptions.FirstMessage) || CliRuntime.WasSpecified(parseResult, OverridesOptions.FirstMessagePrompt) || CliRuntime.WasSpecified(parseResult, OverridesOptions.SystemPrompt) || CliRuntime.WasSpecified(parseResult, OverridesOptions.VoiceId);
                        var overrides =
                            __OverridesSpecified || __OverridesBase is not null
                                ? new global::FishAudio.AgentSessionOverridesPayload
                                {
	                                FirstMessage = overridesFirstMessage,
                                FirstMessagePrompt = overridesFirstMessagePrompt,
                                SystemPrompt = overridesSystemPrompt,
                                VoiceId = overridesVoiceId,

                                }
                                : __OverridesBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PhoneCalls.CreateAgentPhoneCallsAsync(
                                    idempotencyKey: idempotencyKey,
                                    agentId: agentId,
                                    phoneNumberId: phoneNumberId,
                                    toNumber: toNumber,
                                    dynamicVariables: dynamicVariables,
                                    metadata: metadata,
                                    overrides: overrides,
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