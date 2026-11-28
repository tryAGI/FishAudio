#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class ModelEditModelByIdCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"",
    };

    private static Option<byte[]?> CoverImage { get; } = new(
        name: @"--cover-image")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PatchModelRequestVisibility?> Visibility { get; } = new(
        name: @"--visibility")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"",
    };
    private static readonly PatchModelRequestOptionSet PatchModelRequestOptionSetOptions = PatchModelRequestOptionSet.Create();
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
        var command = new Command(commandName ?? @"edit-model-by-id", @"Update Model");
                        command.Arguments.Add(Id);
                        command.Options.Add(CoverImage);
                        command.Options.Add(Visibility);
                        command.Options.Add(Tags);                        command.Options.Add(PatchModelRequestOptionSetOptions.Title);
                        command.Options.Add(PatchModelRequestOptionSetOptions.DescriptionOption);
                        command.Options.Add(PatchModelRequestOptionSetOptions.CoverImagename);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PatchModelRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var coverImage = CliRuntime.WasSpecified(parseResult, CoverImage) ? parseResult.GetValue(CoverImage) : (__requestBase is { } __CoverImageBaseValue ? __CoverImageBaseValue.CoverImage : default);
                        var visibility = CliRuntime.WasSpecified(parseResult, Visibility) ? parseResult.GetValue(Visibility) : (__requestBase is { } __VisibilityBaseValue ? __VisibilityBaseValue.Visibility : default);
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : (__requestBase is { } __TagsBaseValue ? __TagsBaseValue.Tags : default);                        var title = CliRuntime.WasSpecified(parseResult, PatchModelRequestOptionSetOptions.Title) ? parseResult.GetValue(PatchModelRequestOptionSetOptions.Title) : (__requestBase is { } __TitleBaseValue ? __TitleBaseValue.Title : default);
                        var description = CliRuntime.WasSpecified(parseResult, PatchModelRequestOptionSetOptions.DescriptionOption) ? parseResult.GetValue(PatchModelRequestOptionSetOptions.DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var coverImagename = CliRuntime.WasSpecified(parseResult, PatchModelRequestOptionSetOptions.CoverImagename) ? parseResult.GetValue(PatchModelRequestOptionSetOptions.CoverImagename) : (__requestBase is { } __CoverImagenameBaseValue ? __CoverImagenameBaseValue.CoverImagename : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Model.EditModelByIdAsync(
                                    id: id,
                                    coverImage: coverImage,
                                    visibility: visibility,
                                    tags: tags,
                                    title: title,
                                    description: description,
                                    coverImagename: coverImagename,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}