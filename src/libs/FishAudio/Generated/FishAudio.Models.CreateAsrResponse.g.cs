
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAsrResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Duration of the audio in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.ASRSegment> Segments { get; set; }

        /// <summary>
        /// Detected language as an ISO 639-1 code (e.g. `en`, `ja`). Omitted if no language is detected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Detected language name (e.g. `English`). For display only; use `language_code` in code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsrResponse" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="duration">
        /// Duration of the audio in seconds
        /// </param>
        /// <param name="segments"></param>
        /// <param name="languageCode">
        /// Detected language as an ISO 639-1 code (e.g. `en`, `ja`). Omitted if no language is detected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Detected language name (e.g. `English`). For display only; use `language_code` in code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAsrResponse(
            string text,
            double duration,
            global::System.Collections.Generic.IList<global::FishAudio.ASRSegment> segments,
            string? languageCode,
            string? language)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Duration = duration;
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.LanguageCode = languageCode;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsrResponse" /> class.
        /// </summary>
        public CreateAsrResponse()
        {
        }

    }
}