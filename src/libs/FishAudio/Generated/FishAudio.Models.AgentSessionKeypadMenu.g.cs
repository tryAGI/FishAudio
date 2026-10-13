
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// How the keypad menu of an inbound phone call ended. `outcome` is<br/>
    /// `selected` when the caller chose an option, `no_input` or `no_match`<br/>
    /// when no attempt got a valid choice (the last one had no input, or input<br/>
    /// matching no option), and `skipped` when the menu could not run (a resumed<br/>
    /// conversation or no SIP caller). `value` is what the menu variable<br/>
    /// received: the chosen option's value, or the fallback value when the<br/>
    /// caller never made a valid choice.
    /// </summary>
    public sealed partial class AgentSessionKeypadMenu
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionKeypadMenuOutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionKeypadMenuOutcome Outcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::FishAudio.AgentSessionKeypadMenuInput? Input { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        public int? Attempts { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionKeypadMenu" /> class.
        /// </summary>
        /// <param name="outcome"></param>
        /// <param name="variable"></param>
        /// <param name="value"></param>
        /// <param name="key">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="input">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="attempts">
        /// Default Value: 0
        /// </param>
        /// <param name="completedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionKeypadMenu(
            global::FishAudio.AgentSessionKeypadMenuOutcome outcome,
            string variable,
            string value,
            string? key,
            global::FishAudio.AgentSessionKeypadMenuInput? input,
            int? attempts,
            global::System.DateTime? completedAt)
        {
            this.Outcome = outcome;
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Key = key;
            this.Input = input;
            this.Attempts = attempts;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionKeypadMenu" /> class.
        /// </summary>
        public AgentSessionKeypadMenu()
        {
        }

    }
}