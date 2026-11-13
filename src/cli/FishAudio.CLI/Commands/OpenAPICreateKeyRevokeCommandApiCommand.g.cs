#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPICreateKeyRevokeCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>> Credentials { get; } = new(
        name: @"--credentials")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> Source { get; } = new(
        name: @"--source")
    {
        Description = @"",
    };

    private static Option<string?> Url { get; } = new(
        name: @"--url")
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

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-key-revoke", @"Revoke publicly exposed API keys
Anyone holding an API key's plaintext can permanently revoke it here.
No authentication is required; Authorization headers are ignored.
Valid requests always return the same empty 202, whether or not any
key matched. The creator and shared team's owner receive a security
notice. Invalid bodies return 422; each IP is limited to 60 requests
per hour (429). Source and URL are logged for attribution only.");
                        command.Options.Add(Credentials);
                        command.Options.Add(Source);
                        command.Options.Add(Url);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.RevokeCredentials>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var credentials = parseResult.GetRequiredValue(Credentials);
                        var source = CliRuntime.WasSpecified(parseResult, Source) ? parseResult.GetValue(Source) : (__requestBase is { } __SourceBaseValue ? __SourceBaseValue.Source : default);
                        var url = CliRuntime.WasSpecified(parseResult, Url) ? parseResult.GetValue(Url) : (__requestBase is { } __UrlBaseValue ? __UrlBaseValue.Url : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.OpenAPI.CreateKeyRevokeAsync(
                                    credentials: credentials,
                                    source: source,
                                    url: url,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}