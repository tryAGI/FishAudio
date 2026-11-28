
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentUpdatePayload
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::FishAudio.PublicAgentUpdatePayloadStatus? Status { get; set; }

        /// <summary>
        /// Allow keyless session creation from the browser SDK. Any origin can start a session unless restrict_origins is true.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_enabled")]
        public bool? PublicEnabled { get; set; }

        /// <summary>
        /// Origins that may start public sessions while restrict_origins is true. Setting this without restrict_origins on an agent that never chose it turns the restriction on.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// Limit public access to allowed_origins. With an empty list, every public request is rejected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_origins")]
        public bool? RestrictOrigins { get; set; }

        /// <summary>
        /// Which session-creation overrides callers may use. An empty list rejects all overrides.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides_allowed")]
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? OverridesAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentUpdatePayload" /> class.
        /// </summary>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="publicEnabled">
        /// Allow keyless session creation from the browser SDK. Any origin can start a session unless restrict_origins is true.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="allowedOrigins">
        /// Origins that may start public sessions while restrict_origins is true. Setting this without restrict_origins on an agent that never chose it turns the restriction on.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="restrictOrigins">
        /// Limit public access to allowed_origins. With an empty list, every public request is rejected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="overridesAllowed">
        /// Which session-creation overrides callers may use. An empty list rejects all overrides.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentUpdatePayload(
            string? name,
            string? description,
            global::FishAudio.PublicAgentUpdatePayloadStatus? status,
            bool? publicEnabled,
            global::System.Collections.Generic.IList<string>? allowedOrigins,
            bool? restrictOrigins,
            global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? overridesAllowed)
        {
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.PublicEnabled = publicEnabled;
            this.AllowedOrigins = allowedOrigins;
            this.RestrictOrigins = restrictOrigins;
            this.OverridesAllowed = overridesAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentUpdatePayload" /> class.
        /// </summary>
        public PublicAgentUpdatePayload()
        {
        }

    }
}