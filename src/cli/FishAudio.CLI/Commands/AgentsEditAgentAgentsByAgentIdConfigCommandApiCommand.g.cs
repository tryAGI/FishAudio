#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentsEditAgentAgentsByAgentIdConfigCommandApiCommand
{
    private static Argument<string> AgentId { get; } = new(
        name: @"agent-id")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentPromptPatch?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentVoicePatch?> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentConversationPatch?> Conversation { get; } = new(
        name: @"--conversation")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentToolsPatch?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentWebhooksPatch?> Webhooks { get; } = new(
        name: @"--webhooks")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentKnowledgeBasePatch?> KnowledgeBase { get; } = new(
        name: @"--knowledge-base")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentAnalysisPatch?> Analysis { get; } = new(
        name: @"--analysis")
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.PatchAgentAgentsConfigResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.PatchAgentAgentsConfigResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-agent-agents-by-agent-id-config", @"Update Draft Config
Patch the draft configuration section by section; omitted sections keep
their value. Changes only affect live sessions after the next publish.
`prompt.system_prompt` is limited to 4000 characters (422 beyond).
`voice.voice_profile_id` accepts any public voice model id.
`voice.speaking_language` accepts `en`, `ja`, `zh`, `ko`, `es`, `fr`, `de`;
anything else is 422. `tool_ids` and
`knowledge_source_ids` replace their attachment lists wholesale and every
id must resolve, else 422.");
                        command.Arguments.Add(AgentId);
                        command.Options.Add(Prompt);
                        command.Options.Add(Voice);
                        command.Options.Add(Conversation);
                        command.Options.Add(Tools);
                        command.Options.Add(Webhooks);
                        command.Options.Add(KnowledgeBase);
                        command.Options.Add(Analysis);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PublicAgentConfigPatchPayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : (__requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default);
                        var conversation = CliRuntime.WasSpecified(parseResult, Conversation) ? parseResult.GetValue(Conversation) : (__requestBase is { } __ConversationBaseValue ? __ConversationBaseValue.Conversation : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var webhooks = CliRuntime.WasSpecified(parseResult, Webhooks) ? parseResult.GetValue(Webhooks) : (__requestBase is { } __WebhooksBaseValue ? __WebhooksBaseValue.Webhooks : default);
                        var knowledgeBase = CliRuntime.WasSpecified(parseResult, KnowledgeBase) ? parseResult.GetValue(KnowledgeBase) : (__requestBase is { } __KnowledgeBaseBaseValue ? __KnowledgeBaseBaseValue.KnowledgeBase : default);
                        var analysis = CliRuntime.WasSpecified(parseResult, Analysis) ? parseResult.GetValue(Analysis) : (__requestBase is { } __AnalysisBaseValue ? __AnalysisBaseValue.Analysis : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.EditAgentAgentsByAgentIdConfigAsync(
                                    agentId: agentId,
                                    prompt: prompt,
                                    voice: voice,
                                    conversation: conversation,
                                    tools: tools,
                                    webhooks: webhooks,
                                    knowledgeBase: knowledgeBase,
                                    analysis: analysis,
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