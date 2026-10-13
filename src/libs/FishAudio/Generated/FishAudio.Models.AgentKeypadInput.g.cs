
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Keypad input for phone calls: digits the caller types during the<br/>
    /// conversation reach the agent as one user turn, ended by `terminator` or<br/>
    /// by a pause of `inter_digit_timeout_seconds` (`none`: the pause only).
    /// </summary>
    public sealed partial class AgentKeypadInput
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentKeypadInputTerminatorJsonConverter))]
        public global::FishAudio.AgentKeypadInputTerminator? Terminator { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentKeypadInput" /> class.
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
        public AgentKeypadInput(
            bool? enabled,
            global::FishAudio.AgentKeypadInputTerminator? terminator,
            int? interDigitTimeoutSeconds)
        {
            this.Enabled = enabled;
            this.Terminator = terminator;
            this.InterDigitTimeoutSeconds = interDigitTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKeypadInput" /> class.
        /// </summary>
        public AgentKeypadInput()
        {
        }

    }
}