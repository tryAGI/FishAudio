
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicConversationInitWebhook
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Whether a signing secret is configured; the value itself is never returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_secret")]
        public bool? HasSecret { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicConversationInitWebhook" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="hasSecret">
        /// Whether a signing secret is configured; the value itself is never returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeoutSeconds">
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicConversationInitWebhook(
            string url,
            bool? hasSecret,
            double? timeoutSeconds)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HasSecret = hasSecret;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicConversationInitWebhook" /> class.
        /// </summary>
        public PublicConversationInitWebhook()
        {
        }

    }
}