
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Only the fields sent change.
    /// </summary>
    public sealed partial class AgentTestSettingsPatch
    {
        /// <summary>
        /// Null goes back to the platform default. Left out, unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge")]
        public global::FishAudio.AgentTestJudge? Judge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSettingsPatch" /> class.
        /// </summary>
        /// <param name="judge">
        /// Null goes back to the platform default. Left out, unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestSettingsPatch(
            global::FishAudio.AgentTestJudge? judge)
        {
            this.Judge = judge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSettingsPatch" /> class.
        /// </summary>
        public AgentTestSettingsPatch()
        {
        }

    }
}