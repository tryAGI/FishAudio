
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// A canned result for one library tool, optionally gated on the call arguments.
    /// </summary>
    public sealed partial class AgentTestToolMock
    {
        /// <summary>
        /// Tool the runner should (or should not) observe on the next turn. A<br/>
        /// webhook or client tool is referenced by its library id, an integration<br/>
        /// tool by "&lt;provider_key&gt;:&lt;tool_name&gt;" (for example<br/>
        /// "google_calendar:create_event").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentTestReferencedTool Tool { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::FishAudio.JsonValue? Result { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        public global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>? When { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestToolMock" /> class.
        /// </summary>
        /// <param name="tool">
        /// Tool the runner should (or should not) observe on the next turn. A<br/>
        /// webhook or client tool is referenced by its library id, an integration<br/>
        /// tool by "&lt;provider_key&gt;:&lt;tool_name&gt;" (for example<br/>
        /// "google_calendar:create_event").
        /// </param>
        /// <param name="result">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="when">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="error">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestToolMock(
            global::FishAudio.AgentTestReferencedTool tool,
            global::FishAudio.JsonValue? result,
            int? status,
            global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>? when,
            bool? error)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Result = result;
            this.Status = status;
            this.When = when;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestToolMock" /> class.
        /// </summary>
        public AgentTestToolMock()
        {
        }

    }
}