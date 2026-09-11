
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Request-level failure raised before or instead of synthesis — an invalid `start` request, a missing voice reference, or a concurrency refusal. The socket closes afterwards.
    /// </summary>
    public sealed partial class TTSLiveErrorEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "error";

        /// <summary>
        /// Failure detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Your account's concurrency ceiling. Present only when the socket was refused for exceeding it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrency")]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveErrorEvent" /> class.
        /// </summary>
        /// <param name="error">
        /// Failure detail.
        /// </param>
        /// <param name="maxConcurrency">
        /// Your account's concurrency ceiling. Present only when the socket was refused for exceeding it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSLiveErrorEvent(
            string error,
            int? maxConcurrency,
            string @event = "error")
        {
            this.Event = @event;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.MaxConcurrency = maxConcurrency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveErrorEvent" /> class.
        /// </summary>
        public TTSLiveErrorEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TTSLiveErrorEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TTSLiveErrorEvent FromError(string error)
        {
            return new TTSLiveErrorEvent
            {
                Error = error,
            };
        }

    }
}