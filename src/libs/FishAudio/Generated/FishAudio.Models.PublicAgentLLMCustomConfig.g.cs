
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentLLMCustomConfig
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
        /// Sent to your endpoint as the Authorization bearer token; write-only, reads return null. Required when introducing `custom`; omit to keep the stored key when updating.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Extra headers sent on every request to your endpoint, such as `x-vercel-protection-bypass`; write-only, reads return null. Omit to keep the stored headers, `{}` clears them.<br/>
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
        /// Initializes a new instance of the <see cref="PublicAgentLLMCustomConfig" /> class.
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="model"></param>
        /// <param name="apiKey">
        /// Sent to your endpoint as the Authorization bearer token; write-only, reads return null. Required when introducing `custom`; omit to keep the stored key when updating.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="headers">
        /// Extra headers sent on every request to your endpoint, such as `x-vercel-protection-bypass`; write-only, reads return null. Omit to keep the stored headers, `{}` clears them.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentLLMCustomConfig(
            string baseUrl,
            string model,
            string? apiKey,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ApiKey = apiKey;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentLLMCustomConfig" /> class.
        /// </summary>
        public PublicAgentLLMCustomConfig()
        {
        }

    }
}