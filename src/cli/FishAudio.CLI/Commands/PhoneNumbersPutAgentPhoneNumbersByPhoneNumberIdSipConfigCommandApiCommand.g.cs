#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PhoneNumbersPutAgentPhoneNumbersByPhoneNumberIdSipConfigCommandApiCommand
{
    private static Argument<string> PhoneNumberId { get; } = new(
        name: @"phone-number-id")
    {
        Description = @"",
    };

    private static Option<string?> InboundAuthUsername { get; } = new(
        name: @"--inbound-auth-username")
    {
        Description = @"",
    };

    private static Option<string?> InboundAuthPassword { get; } = new(
        name: @"--inbound-auth-password")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> InboundAllowedAddresses { get; } = new(
        name: @"--inbound-allowed-addresses")
    {
        Description = @"",
    };

    private static Option<string?> TerminationUri { get; } = new(
        name: @"--termination-uri")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicSipNumberConfigPayloadTerminationTransport?> TerminationTransport { get; } = new(
        name: @"--termination-transport")
    {
        Description = @"",
    };

    private static Option<string?> TerminationAuthUsername { get; } = new(
        name: @"--termination-auth-username")
    {
        Description = @"",
    };

    private static Option<string?> TerminationAuthPassword { get; } = new(
        name: @"--termination-auth-password")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> TerminationHeaders { get; } = new(
        name: @"--termination-headers")
    {
        Description = @"",
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.PutAgentPhoneNumbersSipConfigResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.PutAgentPhoneNumbersSipConfigResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"put-agent-phone-numbers-by-phone-number-id-sip-config", @"Update SIP Number Config
Replace the trunk configuration of an imported `sip` number in place:
rotate digest credentials, change the allowed source addresses, or add,
update and remove the termination host and its custom SIP headers. Send
the complete desired configuration; an empty password beside a set
username keeps the stored one. Trunk ids are stable across updates, so calls in flight are not
affected. 409 for numbers that are not `sip` imports or not active.");
                        command.Arguments.Add(PhoneNumberId);
                        command.Options.Add(InboundAuthUsername);
                        command.Options.Add(InboundAuthPassword);
                        command.Options.Add(InboundAllowedAddresses);
                        command.Options.Add(TerminationUri);
                        command.Options.Add(TerminationTransport);
                        command.Options.Add(TerminationAuthUsername);
                        command.Options.Add(TerminationAuthPassword);
                        command.Options.Add(TerminationHeaders);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PublicSipNumberConfigPayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var phoneNumberId = parseResult.GetRequiredValue(PhoneNumberId);
                        var inboundAuthUsername = CliRuntime.WasSpecified(parseResult, InboundAuthUsername) ? parseResult.GetValue(InboundAuthUsername) : (__requestBase is { } __InboundAuthUsernameBaseValue ? __InboundAuthUsernameBaseValue.InboundAuthUsername : default);
                        var inboundAuthPassword = CliRuntime.WasSpecified(parseResult, InboundAuthPassword) ? parseResult.GetValue(InboundAuthPassword) : (__requestBase is { } __InboundAuthPasswordBaseValue ? __InboundAuthPasswordBaseValue.InboundAuthPassword : default);
                        var inboundAllowedAddresses = CliRuntime.WasSpecified(parseResult, InboundAllowedAddresses) ? parseResult.GetValue(InboundAllowedAddresses) : (__requestBase is { } __InboundAllowedAddressesBaseValue ? __InboundAllowedAddressesBaseValue.InboundAllowedAddresses : default);
                        var terminationUri = CliRuntime.WasSpecified(parseResult, TerminationUri) ? parseResult.GetValue(TerminationUri) : (__requestBase is { } __TerminationUriBaseValue ? __TerminationUriBaseValue.TerminationUri : default);
                        var terminationTransport = CliRuntime.WasSpecified(parseResult, TerminationTransport) ? parseResult.GetValue(TerminationTransport) : (__requestBase is { } __TerminationTransportBaseValue ? __TerminationTransportBaseValue.TerminationTransport : default);
                        var terminationAuthUsername = CliRuntime.WasSpecified(parseResult, TerminationAuthUsername) ? parseResult.GetValue(TerminationAuthUsername) : (__requestBase is { } __TerminationAuthUsernameBaseValue ? __TerminationAuthUsernameBaseValue.TerminationAuthUsername : default);
                        var terminationAuthPassword = CliRuntime.WasSpecified(parseResult, TerminationAuthPassword) ? parseResult.GetValue(TerminationAuthPassword) : (__requestBase is { } __TerminationAuthPasswordBaseValue ? __TerminationAuthPasswordBaseValue.TerminationAuthPassword : default);
                        var terminationHeaders = CliRuntime.WasSpecified(parseResult, TerminationHeaders) ? parseResult.GetValue(TerminationHeaders) : (__requestBase is { } __TerminationHeadersBaseValue ? __TerminationHeadersBaseValue.TerminationHeaders : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PhoneNumbers.PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync(
                                    phoneNumberId: phoneNumberId,
                                    inboundAuthUsername: inboundAuthUsername,
                                    inboundAuthPassword: inboundAuthPassword,
                                    inboundAllowedAddresses: inboundAllowedAddresses,
                                    terminationUri: terminationUri,
                                    terminationTransport: terminationTransport,
                                    terminationAuthUsername: terminationAuthUsername,
                                    terminationAuthPassword: terminationAuthPassword,
                                    terminationHeaders: terminationHeaders,
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