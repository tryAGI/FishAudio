
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentBackchannelPatch
    {
        /// <summary>
        /// Whether the agent backchannels. Default true. false turns them off: the agent may still add one now and then, and the first sound after the caller stops can come a little later.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// How readily the agent backchannels, a whole number from 1 (rarely) to 10 (at nearly every pause). null (default): the speech engine's own setting, 6 on live3. Send null to go back to it. Not used while enabled is false.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public int? Strength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBackchannelPatch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the agent backchannels. Default true. false turns them off: the agent may still add one now and then, and the first sound after the caller stops can come a little later.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="strength">
        /// How readily the agent backchannels, a whole number from 1 (rarely) to 10 (at nearly every pause). null (default): the speech engine's own setting, 6 on live3. Send null to go back to it. Not used while enabled is false.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBackchannelPatch(
            bool? enabled,
            int? strength)
        {
            this.Enabled = enabled;
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBackchannelPatch" /> class.
        /// </summary>
        public AgentBackchannelPatch()
        {
        }

    }
}