
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTurnDetector
    {
        /// <summary>
        /// The model that judges the end of the caller's turn. `fish` is Fish Audio's turn detection model. It waits for the end of the caller's thought, so a caller who pauses between two sentences or between groups of digits is less often answered in the middle. `legacy` is the earlier model. It answers sooner after a sentence that sounds complete. The default is `fish`. An account whose agents ran the earlier model before this setting existed has `legacy` as its default, so they behave as they did. An agent that never set the model reads the default, and a new agent is created with it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::FishAudio.AgentTurnDetectorModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnDetector" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that judges the end of the caller's turn. `fish` is Fish Audio's turn detection model. It waits for the end of the caller's thought, so a caller who pauses between two sentences or between groups of digits is less often answered in the middle. `legacy` is the earlier model. It answers sooner after a sentence that sounds complete. The default is `fish`. An account whose agents ran the earlier model before this setting existed has `legacy` as its default, so they behave as they did. An agent that never set the model reads the default, and a new agent is created with it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTurnDetector(
            global::FishAudio.AgentTurnDetectorModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnDetector" /> class.
        /// </summary>
        public AgentTurnDetector()
        {
        }

    }
}