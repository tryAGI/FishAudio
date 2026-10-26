
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Read entity: the stored api_key never leaves the collection. The headers<br/>
    /// read back as stored, like the non-credential headers of a webhook tool.
    /// </summary>
    public sealed partial class AgentLLMCustomConfigRedacted
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public object? ApiKey { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMCustomConfigRedacted" /> class.
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="model"></param>
        /// <param name="apiKey">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="headers">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMCustomConfigRedacted(
            string baseUrl,
            string model,
            object? apiKey,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ApiKey = apiKey;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMCustomConfigRedacted" /> class.
        /// </summary>
        public AgentLLMCustomConfigRedacted()
        {
        }

    }
}