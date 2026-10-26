#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentTestsCreateAgentTestsCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PublicAgentTestCreatePayloadTestType?> TestType { get; } = new(
        name: @"--test-type")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>?> Conversation { get; } = new(
        name: @"--conversation")
    {
        Description = @"",
    };

    private static Option<string?> Expectation { get; } = new(
        name: @"--expectation")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> SuccessExamples { get; } = new(
        name: @"--success-examples")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> FailureExamples { get; } = new(
        name: @"--failure-examples")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>?> ToolParameters { get; } = new(
        name: @"--tool-parameters")
    {
        Description = @"",
    };

    private static Option<bool?> VerifyAbsence { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--verify-absence",
        description: @"");

    private static Option<object?> DynamicVariables { get; } = new(
        name: @"--dynamic-variables")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AgentIds { get; } = new(
        name: @"--agent-ids")
    {
        Description = @"Agents to attach the test to. They must all be in one workspace, and the test is created there. Without agents the test goes into the API key owner's default workspace.",
    };
    private static readonly AgentTestReferencedToolOptionSet ReferencedToolOptions = AgentTestReferencedToolOptionSet.Create(@"referenced-tool");

    private static readonly AgentTestSimulationConfigOptionSet SimulationOptions = AgentTestSimulationConfigOptionSet.Create(@"simulation");
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateAgentTestsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateAgentTestsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-agent-tests", @"Create Test
Create a test: `next_reply` judges the agent's next reply against an
expectation, `tool` checks the tool the agent calls next, and `simulation`
lets a simulated user hold a whole conversation that is scored against
success conditions. Pass `agent_ids` to attach the test right away.

The body of `GET /v1/agent/tests/{test_id}` posts back as is, so tests can
be exported and imported. Tool references use your workspace's tool ids
(list them with `GET /v1/agent/agents/{agent_id}/test-tools`), so an export
imports cleanly within the same team and needs its tool ids remapped
elsewhere.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(TestType);
                        command.Options.Add(Conversation);
                        command.Options.Add(Expectation);
                        command.Options.Add(SuccessExamples);
                        command.Options.Add(FailureExamples);
                        command.Options.Add(ToolParameters);
                        command.Options.Add(VerifyAbsence);
                        command.Options.Add(DynamicVariables);
                        command.Options.Add(AgentIds);                        command.Options.Add(ReferencedToolOptions.Id);
                        command.Options.Add(ReferencedToolOptions.NameOption);
                        command.Options.Add(ReferencedToolOptions.Type);
                        command.Options.Add(ReferencedToolOptions.DescriptionOption);                        command.Options.Add(SimulationOptions.Scenario);
                        command.Options.Add(SimulationOptions.MaxTurns);
                        command.Options.Add(SimulationOptions.SimulatedUserModel);
                        command.Options.Add(SimulationOptions.RepeatCount);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PublicAgentTestCreatePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var testType = CliRuntime.WasSpecified(parseResult, TestType) ? parseResult.GetValue(TestType) : (__requestBase is { } __TestTypeBaseValue ? __TestTypeBaseValue.TestType : default);
                        var conversation = CliRuntime.WasSpecified(parseResult, Conversation) ? parseResult.GetValue(Conversation) : (__requestBase is { } __ConversationBaseValue ? __ConversationBaseValue.Conversation : default);
                        var expectation = CliRuntime.WasSpecified(parseResult, Expectation) ? parseResult.GetValue(Expectation) : (__requestBase is { } __ExpectationBaseValue ? __ExpectationBaseValue.Expectation : default);
                        var successExamples = CliRuntime.WasSpecified(parseResult, SuccessExamples) ? parseResult.GetValue(SuccessExamples) : (__requestBase is { } __SuccessExamplesBaseValue ? __SuccessExamplesBaseValue.SuccessExamples : default);
                        var failureExamples = CliRuntime.WasSpecified(parseResult, FailureExamples) ? parseResult.GetValue(FailureExamples) : (__requestBase is { } __FailureExamplesBaseValue ? __FailureExamplesBaseValue.FailureExamples : default);
                        var toolParameters = CliRuntime.WasSpecified(parseResult, ToolParameters) ? parseResult.GetValue(ToolParameters) : (__requestBase is { } __ToolParametersBaseValue ? __ToolParametersBaseValue.ToolParameters : default);
                        var verifyAbsence = CliRuntime.WasSpecified(parseResult, VerifyAbsence) ? parseResult.GetValue(VerifyAbsence) : (__requestBase is { } __VerifyAbsenceBaseValue ? __VerifyAbsenceBaseValue.VerifyAbsence : default);
                        var dynamicVariables = CliRuntime.WasSpecified(parseResult, DynamicVariables) ? parseResult.GetValue(DynamicVariables) : (__requestBase is { } __DynamicVariablesBaseValue ? __DynamicVariablesBaseValue.DynamicVariables : default);
                        var agentIds = CliRuntime.WasSpecified(parseResult, AgentIds) ? parseResult.GetValue(AgentIds) : (__requestBase is { } __AgentIdsBaseValue ? __AgentIdsBaseValue.AgentIds : default);

                        var __ReferencedToolBase = __requestBase is { } __ReferencedToolBaseValue ? __ReferencedToolBaseValue.ReferencedTool : default;                        var referencedToolId = parseResult.GetValue(ReferencedToolOptions.Id);
                        var referencedToolNameOption = parseResult.GetValue(ReferencedToolOptions.NameOption);
                        var referencedToolType = CliRuntime.WasSpecified(parseResult, ReferencedToolOptions.Type) ? parseResult.GetValue(ReferencedToolOptions.Type) : (__ReferencedToolBase is { } __ReferencedTooltypeBaseValue ? __ReferencedTooltypeBaseValue.Type : default);
                        var referencedToolDescriptionOption = CliRuntime.WasSpecified(parseResult, ReferencedToolOptions.DescriptionOption) ? parseResult.GetValue(ReferencedToolOptions.DescriptionOption) : (__ReferencedToolBase is { } __ReferencedTooldescriptionBaseValue ? __ReferencedTooldescriptionBaseValue.Description : default);
                        var __ReferencedToolSpecified = CliRuntime.WasSpecified(parseResult, ReferencedToolOptions.Id) || CliRuntime.WasSpecified(parseResult, ReferencedToolOptions.NameOption) || CliRuntime.WasSpecified(parseResult, ReferencedToolOptions.Type) || CliRuntime.WasSpecified(parseResult, ReferencedToolOptions.DescriptionOption);
                        var referencedTool =
                            __ReferencedToolSpecified || __ReferencedToolBase is not null
                                ? new global::FishAudio.AgentTestReferencedTool
                                {
	                                Id = referencedToolId!,
                                Name = referencedToolNameOption!,
                                Type = referencedToolType,
                                Description = referencedToolDescriptionOption,

                                }
                                : __ReferencedToolBase;

                        var __SimulationBase = __requestBase is { } __SimulationBaseValue ? __SimulationBaseValue.Simulation : default;                        var simulationScenario = parseResult.GetValue(SimulationOptions.Scenario);
                        var simulationMaxTurns = CliRuntime.WasSpecified(parseResult, SimulationOptions.MaxTurns) ? parseResult.GetValue(SimulationOptions.MaxTurns) : (__SimulationBase is { } __SimulationmaxTurnsBaseValue ? __SimulationmaxTurnsBaseValue.MaxTurns : default);
                        var simulationSimulatedUserModel = CliRuntime.WasSpecified(parseResult, SimulationOptions.SimulatedUserModel) ? parseResult.GetValue(SimulationOptions.SimulatedUserModel) : (__SimulationBase is { } __SimulationsimulatedUserModelBaseValue ? __SimulationsimulatedUserModelBaseValue.SimulatedUserModel : default);
                        var simulationRepeatCount = CliRuntime.WasSpecified(parseResult, SimulationOptions.RepeatCount) ? parseResult.GetValue(SimulationOptions.RepeatCount) : (__SimulationBase is { } __SimulationrepeatCountBaseValue ? __SimulationrepeatCountBaseValue.RepeatCount : default);
                        var __SimulationSpecified = CliRuntime.WasSpecified(parseResult, SimulationOptions.Scenario) || CliRuntime.WasSpecified(parseResult, SimulationOptions.MaxTurns) || CliRuntime.WasSpecified(parseResult, SimulationOptions.SimulatedUserModel) || CliRuntime.WasSpecified(parseResult, SimulationOptions.RepeatCount);
                        var simulation =
                            __SimulationSpecified || __SimulationBase is not null
                                ? new global::FishAudio.AgentTestSimulationConfig
                                {
	                                Scenario = simulationScenario!,
                                MaxTurns = simulationMaxTurns,
                                SimulatedUserModel = simulationSimulatedUserModel,
                                RepeatCount = simulationRepeatCount,
	                                SuccessConditions = __SimulationBase is not null ? __SimulationBase.SuccessConditions : throw new CliException(@"Simulation.success_conditions is required when using simulation options. Provide it with --request-json or --request-file."),
                                }
                                : __SimulationBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentTests.CreateAgentTestsAsync(
                                    name: name,
                                    testType: testType,
                                    conversation: conversation,
                                    expectation: expectation,
                                    successExamples: successExamples,
                                    failureExamples: failureExamples,
                                    toolParameters: toolParameters,
                                    verifyAbsence: verifyAbsence,
                                    dynamicVariables: dynamicVariables,
                                    agentIds: agentIds,
                                    referencedTool: referencedTool,
                                    simulation: simulation,
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