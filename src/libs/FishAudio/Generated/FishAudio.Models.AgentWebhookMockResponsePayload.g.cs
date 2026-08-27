
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentWebhookMockResponsePayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Default Value: application/json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWebhookMockResponsePayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="statusCode">
        /// Default Value: 200
        /// </param>
        /// <param name="contentType">
        /// Default Value: application/json
        /// </param>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentWebhookMockResponsePayload(
            string? name,
            int? statusCode,
            string? contentType,
            string? body)
        {
            this.Name = name;
            this.StatusCode = statusCode;
            this.ContentType = contentType;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWebhookMockResponsePayload" /> class.
        /// </summary>
        public AgentWebhookMockResponsePayload()
        {
        }

    }
}