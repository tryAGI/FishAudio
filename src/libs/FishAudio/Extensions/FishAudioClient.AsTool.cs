using Microsoft.Extensions.AI;

namespace FishAudio;

/// <summary>
/// Extensions for using FishAudioClient as MEAI tools with any IChatClient.
/// </summary>
public static class FishAudioToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Fish Audio text-to-speech synthesis,
    /// suitable for use as a tool with any IChatClient.
    /// Returns the audio as a base64-encoded string (not practical for large audio;
    /// consider using the TTS API directly for production use).
    /// </summary>
    /// <param name="client">The Fish Audio client to use.</param>
    /// <param name="referenceId">Optional default voice model ID to use for synthesis.</param>
    /// <param name="model">The TTS model to use (default: s2-pro).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsTextToSpeechTool(
        this FishAudioClient client,
        string? referenceId = null,
        CreateTtsModel model = CreateTtsModel.S2Pro)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, CancellationToken cancellationToken) =>
            {
                AnyOf<string, IList<string>, object>? refId = referenceId is not null
                    ? new AnyOf<string, IList<string>, object>(referenceId)
                    : (AnyOf<string, IList<string>, object>?)null;

                await client.OpenAPIV1.CreateTtsAsync(
                    text: text,
                    referenceId: refId,
                    model: model,
                    format: TTSRequestFormat.Mp3,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Audio generated successfully for text: \"{(text.Length > 100 ? text[..100] + "..." : text)}\"";
            },
            name: "FishAudioTextToSpeech",
            description: "Converts text to speech audio using Fish Audio's TTS API. Supports 50+ languages, voice cloning, and multi-speaker synthesis.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available voice models
    /// from Fish Audio, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Fish Audio client to use.</param>
    /// <param name="pageSize">Number of models to return per page (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListModelsTool(
        this FishAudioClient client,
        int pageSize = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? query, CancellationToken cancellationToken) =>
            {
                var response = await client.Model.GetModelAsync(
                    pageSize: pageSize,
                    title: query,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListModelsResponse(response);
            },
            name: "FishAudioListModels",
            description: "Lists available voice models from Fish Audio. Optionally filter by title/name. Returns model IDs, titles, descriptions, languages, and popularity metrics.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details for a specific voice model
    /// from Fish Audio, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Fish Audio client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetModelTool(
        this FishAudioClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string modelId, CancellationToken cancellationToken) =>
            {
                var response = await client.Model.GetModelByIdAsync(
                    id: modelId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatModelResponse(response);
            },
            name: "FishAudioGetModel",
            description: "Gets details for a specific Fish Audio voice model by its ID. Returns the model title, description, languages, state, tags, and sample information.");
    }

    private static string FormatListModelsResponse(GetModelResponse response)
    {
        var parts = new List<string> { $"Total models: {response.Total}" };

        foreach (var model in response.Items)
        {
            var entry = $"- [{model.Title}] (ID: {model.Id})";
            if (!string.IsNullOrWhiteSpace(model.Description))
            {
                var desc = model.Description.Length > 100
                    ? model.Description[..100] + "..."
                    : model.Description;
                entry += $": {desc}";
            }

            if (model.Languages is { Count: > 0 })
            {
                entry += $" [Languages: {string.Join(", ", model.Languages)}]";
            }

            entry += $" (Likes: {model.LikeCount}, Uses: {model.TaskCount})";
            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }

    private static string FormatModelResponse(GetModelResponse2 model)
    {
        var parts = new List<string>
        {
            $"Model: {model.Title}",
            $"ID: {model.Id}",
            $"State: {model.State}",
        };

        if (!string.IsNullOrWhiteSpace(model.Description))
        {
            parts.Add($"Description: {model.Description}");
        }

        if (model.Languages is { Count: > 0 })
        {
            parts.Add($"Languages: {string.Join(", ", model.Languages)}");
        }

        if (model.Tags is { Count: > 0 })
        {
            parts.Add($"Tags: {string.Join(", ", model.Tags)}");
        }

        parts.Add($"Likes: {model.LikeCount}, Uses: {model.TaskCount}");
        parts.Add($"Author: {model.Author.Nickname}");

        return string.Join("\n", parts);
    }
}
