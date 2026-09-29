
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// How one tool argument is compared: exact string equality, a regular<br/>
    /// expression searched in the value, or mere presence. Regexes are<br/>
    /// JavaScript without flags, mock conditions run in the runtime as written<br/>
    /// and assertions are translated to Python for scoring.
    /// </summary>
    public sealed partial class AgentTestParamMatcher
    {
        /// <summary>
        /// Default Value: exact
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTestParamMatcherTypeJsonConverter))]
        public global::FishAudio.AgentTestParamMatcherType? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestParamMatcher" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: exact
        /// </param>
        /// <param name="value">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestParamMatcher(
            global::FishAudio.AgentTestParamMatcherType? type,
            string? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestParamMatcher" /> class.
        /// </summary>
        public AgentTestParamMatcher()
        {
        }

    }
}