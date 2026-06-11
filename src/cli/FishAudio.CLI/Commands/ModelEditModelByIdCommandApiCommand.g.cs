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

    private static Option<string?> Title { get; } = new(
        name: @"--title")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<byte[]?> CoverImage { get; } = new(
        name: @"--cover-image")
    {
        Description = @"",
    };

    private static Option<string?> CoverImagename { get; } = new(
        name: @"--cover-imagename")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.PatchModelRequestVisibility2?> Visibility { get; } = new(
        name: @"--visibility")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>?> Tags { get; } = new(
        name: @"--tags")
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

    public static Command Create()
    {
        var command = new Command(@"edit-model-by-id", @"Update Model");
                        command.Arguments.Add(Id);
                        command.Options.Add(Title);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(CoverImage);
                        command.Options.Add(CoverImagename);
                        command.Options.Add(Visibility);
                        command.Options.Add(Tags);
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
                        var title = CliRuntime.WasSpecified(parseResult, Title) ? parseResult.GetValue(Title) : __requestBase is not null ? __requestBase.Title : default;
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : __requestBase is not null ? __requestBase.Description : default;
                        var coverImage = CliRuntime.WasSpecified(parseResult, CoverImage) ? parseResult.GetValue(CoverImage) : __requestBase is not null ? __requestBase.CoverImage : default;
                        var coverImagename = CliRuntime.WasSpecified(parseResult, CoverImagename) ? parseResult.GetValue(CoverImagename) : __requestBase is not null ? __requestBase.CoverImagename : default;
                        var visibility = CliRuntime.WasSpecified(parseResult, Visibility) ? parseResult.GetValue(Visibility) : __requestBase is not null ? __requestBase.Visibility : default;
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : __requestBase is not null ? __requestBase.Tags : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Model.EditModelByIdAsync(
                                    id: id,
                                    title: title,
                                    description: description,
                                    coverImage: coverImage,
                                    coverImagename: coverImagename,
                                    visibility: visibility,
                                    tags: tags,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}