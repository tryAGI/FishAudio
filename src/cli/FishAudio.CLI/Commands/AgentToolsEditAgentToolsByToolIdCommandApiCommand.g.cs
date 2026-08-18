#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentToolsEditAgentToolsByToolIdCommandApiCommand
{
    private static Argument<string> ToolId { get; } = new(
        name: @"tool-id")
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

    private static Option<global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>?> ArgumentsOption { get; } = new(
        name: @"--arguments")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentToolUpdatePayloadMethod2?> Method { get; } = new(
        name: @"--method")
    {
        Description = @"",
    };

    private static Option<string?> Url { get; } = new(
        name: @"--url")
    {
        Description = @"",
    };

    private static Option<string?> ContentType { get; } = new(
        name: @"--content-type")
    {
        Description = @"",
    };

    private static Option<string?> BodyTemplate { get; } = new(
        name: @"--body-template")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>?> Headers { get; } = new(
        name: @"--headers")
    {
        Description = @"",
    };

    private static Option<int?> TimeoutSeconds { get; } = new(
        name: @"--timeout-seconds")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling2?> ErrorHandling { get; } = new(
        name: @"--error-handling")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>?> MockResponses { get; } = new(
        name: @"--mock-responses")
    {
        Description = @"",
    };

    private static Option<bool?> ExpectsResponse { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--expects-response",
        description: @"");

    private static Option<global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode2?> ExecutionMode { get; } = new(
        name: @"--execution-mode")
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.PatchAgentToolsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.PatchAgentToolsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-agent-tools-by-tool-id", @"Update Tool
Patch tool fields; omitted fields keep their value (null is rejected;
send an empty string to clear a text field). `headers` replaces the header
list wholesale. Include credential values again whenever you send it,
since reads never return them. Attached agents' drafts pick up the change
immediately; published versions stay frozen until re-published.");
                        command.Arguments.Add(ToolId);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(ArgumentsOption);
                        command.Options.Add(Method);
                        command.Options.Add(Url);
                        command.Options.Add(ContentType);
                        command.Options.Add(BodyTemplate);
                        command.Options.Add(Headers);
                        command.Options.Add(TimeoutSeconds);
                        command.Options.Add(ErrorHandling);
                        command.Options.Add(MockResponses);
                        command.Options.Add(ExpectsResponse);
                        command.Options.Add(ExecutionMode);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PublicAgentToolUpdatePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var toolId = parseResult.GetRequiredValue(ToolId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var arguments = CliRuntime.WasSpecified(parseResult, ArgumentsOption) ? parseResult.GetValue(ArgumentsOption) : (__requestBase is { } __ArgumentsBaseValue ? __ArgumentsBaseValue.Arguments : default);
                        var method = CliRuntime.WasSpecified(parseResult, Method) ? parseResult.GetValue(Method) : (__requestBase is { } __MethodBaseValue ? __MethodBaseValue.Method : default);
                        var url = CliRuntime.WasSpecified(parseResult, Url) ? parseResult.GetValue(Url) : (__requestBase is { } __UrlBaseValue ? __UrlBaseValue.Url : default);
                        var contentType = CliRuntime.WasSpecified(parseResult, ContentType) ? parseResult.GetValue(ContentType) : (__requestBase is { } __ContentTypeBaseValue ? __ContentTypeBaseValue.ContentType : default);
                        var bodyTemplate = CliRuntime.WasSpecified(parseResult, BodyTemplate) ? parseResult.GetValue(BodyTemplate) : (__requestBase is { } __BodyTemplateBaseValue ? __BodyTemplateBaseValue.BodyTemplate : default);
                        var headers = CliRuntime.WasSpecified(parseResult, Headers) ? parseResult.GetValue(Headers) : (__requestBase is { } __HeadersBaseValue ? __HeadersBaseValue.Headers : default);
                        var timeoutSeconds = CliRuntime.WasSpecified(parseResult, TimeoutSeconds) ? parseResult.GetValue(TimeoutSeconds) : (__requestBase is { } __TimeoutSecondsBaseValue ? __TimeoutSecondsBaseValue.TimeoutSeconds : default);
                        var errorHandling = CliRuntime.WasSpecified(parseResult, ErrorHandling) ? parseResult.GetValue(ErrorHandling) : (__requestBase is { } __ErrorHandlingBaseValue ? __ErrorHandlingBaseValue.ErrorHandling : default);
                        var mockResponses = CliRuntime.WasSpecified(parseResult, MockResponses) ? parseResult.GetValue(MockResponses) : (__requestBase is { } __MockResponsesBaseValue ? __MockResponsesBaseValue.MockResponses : default);
                        var expectsResponse = CliRuntime.WasSpecified(parseResult, ExpectsResponse) ? parseResult.GetValue(ExpectsResponse) : (__requestBase is { } __ExpectsResponseBaseValue ? __ExpectsResponseBaseValue.ExpectsResponse : default);
                        var executionMode = CliRuntime.WasSpecified(parseResult, ExecutionMode) ? parseResult.GetValue(ExecutionMode) : (__requestBase is { } __ExecutionModeBaseValue ? __ExecutionModeBaseValue.ExecutionMode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentTools.EditAgentToolsByToolIdAsync(
                                    toolId: toolId,
                                    name: name,
                                    description: description,
                                    arguments: arguments,
                                    method: method,
                                    url: url,
                                    contentType: contentType,
                                    bodyTemplate: bodyTemplate,
                                    headers: headers,
                                    timeoutSeconds: timeoutSeconds,
                                    errorHandling: errorHandling,
                                    mockResponses: mockResponses,
                                    expectsResponse: expectsResponse,
                                    executionMode: executionMode,
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