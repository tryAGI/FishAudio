#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentToolsCreateAgentToolsByToolIdSigningSecretRotateCommandApiCommand
{
    private static Argument<string> ToolId { get; } = new(
        name: @"tool-id")
    {
        Description = @"",
    };

    private static Option<string?> Secret { get; } = new(
        name: @"--secret")
    {
        Description = @"The new signing secret. Omit it to have one generated (`whsec_` plus 256 random bits), which is the recommended way.",
    };

    private static Option<int?> PreviousSecretExpiresInSeconds { get; } = new(
        name: @"--previous-secret-expires-in-seconds")
    {
        Description = @"How long the replaced secret keeps signing next to the new one, as a second `v1`. Default 24 hours, at most 7 days. 0 switches at once. Ignored when signing was off.",
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateAgentToolsSigningSecretRotateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateAgentToolsSigningSecretRotateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-agent-tools-by-tool-id-signing-secret-rotate", @"Rotate Tool Signing Secret
Turn on request signing for a webhook tool, or replace its secret. The
response returns the new secret once. The replaced secret keeps signing
next to the new one for `previous_secret_expires_in_seconds` (default 24
hours), so you can deploy the new secret without dropping a request.
Returns 409 while a previous secret is still active: revoke it first.
The change reaches every agent using the tool at its next session,
published versions included.

Signed requests carry `X-Fish-Webhook-Signature: t=&lt;unix&gt;,v1=&lt;hex&gt;`, the
same header and scheme as post-call webhooks. Each `v1` is the hex
HMAC-SHA256 of `{t}.{body}` with one secret, where `body` is the exact
request body (empty for GET). Check every `v1` entry: during a rotation
window there are two, the new secret's first. Reject a request whose `t`
is more than 5 minutes off your clock.");
                        command.Arguments.Add(ToolId);
                        command.Options.Add(Secret);
                        command.Options.Add(PreviousSecretExpiresInSeconds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.AgentWebhookToolSigningSecretRotatePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var toolId = parseResult.GetRequiredValue(ToolId);
                        var secret = CliRuntime.WasSpecified(parseResult, Secret) ? parseResult.GetValue(Secret) : (__requestBase is { } __SecretBaseValue ? __SecretBaseValue.Secret : default);
                        var previousSecretExpiresInSeconds = CliRuntime.WasSpecified(parseResult, PreviousSecretExpiresInSeconds) ? parseResult.GetValue(PreviousSecretExpiresInSeconds) : (__requestBase is { } __PreviousSecretExpiresInSecondsBaseValue ? __PreviousSecretExpiresInSecondsBaseValue.PreviousSecretExpiresInSeconds : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentTools.CreateAgentToolsByToolIdSigningSecretRotateAsync(
                                    toolId: toolId,
                                    secret: secret,
                                    previousSecretExpiresInSeconds: previousSecretExpiresInSeconds,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::FishAudio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}