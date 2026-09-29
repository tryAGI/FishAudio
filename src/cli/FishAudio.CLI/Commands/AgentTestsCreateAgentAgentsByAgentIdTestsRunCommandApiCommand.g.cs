#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentTestsCreateAgentAgentsByAgentIdTestsRunCommandApiCommand
{
    private static Argument<string> AgentId { get; } = new(
        name: @"agent-id")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> TestIds { get; } = new(
        name: @"--test-ids")
    {
        Description = @"Attached tests to run. Omit to run every test attached to the agent.",
    };

    private static Option<int?> RepeatCount { get; } = new(
        name: @"--repeat-count")
    {
        Description = @"Run every selected test this many times in this batch, in place of each test's own repeat count.",
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateAgentAgentsTestsRunResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateAgentAgentsTestsRunResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-agent-agents-by-agent-id-tests-run", @"Run Tests
Start a batch that runs the agent's attached tests against its current
draft, one run per test and repeat. A simulation test repeats
`simulation.repeat_count` times, and a `repeat_count` in the body repeats
every selected test that many times instead. A batch starts at most 1000
runs. Runs are queued and finish in the background, simulations take
minutes. Poll `GET /v1/agent/agents/{agent_id}/test-batches/{batch_id}`
until `completed` is true, then gate on `pass_rate`, which leaves out
`error` runs.");
                        command.Arguments.Add(AgentId);
                        command.Options.Add(TestIds);
                        command.Options.Add(RepeatCount);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.CreateAgentAgentsTestsRunRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var testIds = CliRuntime.WasSpecified(parseResult, TestIds) ? parseResult.GetValue(TestIds) : (__requestBase is { } __TestIdsBaseValue ? __TestIdsBaseValue.TestIds : default);
                        var repeatCount = CliRuntime.WasSpecified(parseResult, RepeatCount) ? parseResult.GetValue(RepeatCount) : (__requestBase is { } __RepeatCountBaseValue ? __RepeatCountBaseValue.RepeatCount : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentTests.CreateAgentAgentsByAgentIdTestsRunAsync(
                                    agentId: agentId,
                                    testIds: testIds,
                                    repeatCount: repeatCount,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"Runs",
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