
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentKeypadInputPatch
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default Value: #
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentKeypadInputPatchTerminatorJsonConverter))]
        public global::FishAudio.AgentKeypadInputPatchTerminator? Terminator { get; set; }

        /// <summary>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inter_digit_timeout_seconds")]
        public int? InterDigitTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKeypadInputPatch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="terminator">
        /// Default Value: #
        /// </param>
        /// <param name="interDigitTimeoutSeconds">
        /// Default Value: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKeypadInputPatch(
            bool? enabled,
            global::FishAudio.AgentKeypadInputPatchTerminator? terminator,
            int? interDigitTimeoutSeconds)
        {
            this.Enabled = enabled;
            this.Terminator = terminator;
            this.InterDigitTimeoutSeconds = interDigitTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKeypadInputPatch" /> class.
        /// </summary>
        public AgentKeypadInputPatch()
        {
        }

    }
}