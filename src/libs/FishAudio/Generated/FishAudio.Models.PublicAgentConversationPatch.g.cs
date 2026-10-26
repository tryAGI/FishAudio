
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentConversationPatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_wait_ms")]
        public int? ResponseWaitMs { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagerness")]
        public global::FishAudio.PublicAgentConversationPatchEagerness? Eagerness { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_max_wait_ms")]
        public int? ResponseMaxWaitMs { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruptible")]
        public bool? Interruptible { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_sensitivity")]
        public global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity? InterruptionSensitivity { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_ignore_phrases")]
        public global::System.Collections.Generic.IList<string>? InterruptionIgnorePhrases { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculative_response")]
        public bool? SpeculativeResponse { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reengage_enabled")]
        public bool? ReengageEnabled { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hangup_after_seconds")]
        public int? HangupAfterSeconds { get; set; }

        /// <summary>
        /// What the agent says before a silence hangup. `off` (default) hangs up without a word, `generated` says a short goodbye, `fixed` says hangup_farewell_message. A `fixed` mode with an empty message falls back to `generated`. If the caller speaks during the goodbye, the call goes on.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hangup_farewell_mode")]
        public global::FishAudio.PublicAgentConversationPatchHangupFarewellMode? HangupFarewellMode { get; set; }

        /// <summary>
        /// The goodbye said verbatim in the `fixed` hangup_farewell_mode, at most 500 characters. `{{variable}}` placeholders are filled in for each session. "" clears it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hangup_farewell_message")]
        public string? HangupFarewellMessage { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_audio")]
        public bool? RecordAudio { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destinations")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>? TransferDestinations { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_refuse_questions")]
        public bool? TransferRefuseQuestions { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound")]
        public global::FishAudio.AgentOutboundPatch? Outbound { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keypad_menu")]
        public global::FishAudio.AgentKeypadMenuPatch? KeypadMenu { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keypad_input")]
        public global::FishAudio.AgentKeypadInputPatch? KeypadInput { get; set; }

        /// <summary>
        /// Echo guard. For the first 3 seconds after the agent first starts talking in a call, the caller cannot interrupt it and anything the caller says while the agent is talking is not heard. This stops the agent's own voice, echoing back from a speakerphone or laptop, from cutting it off. Per channel: true on, false off, null uses the default (on for web_voice and phone_inbound, off for phone_outbound). Channels you send replace the stored value, null on a channel resets it to the default, channels you leave out are kept. null resets every channel.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo_guard")]
        public global::FishAudio.AgentEchoGuardPatch? EchoGuard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentConversationPatch" /> class.
        /// </summary>
        /// <param name="maxDurationSeconds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="responseWaitMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eagerness">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="responseMaxWaitMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="interruptible">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="interruptionSensitivity">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="interruptionIgnorePhrases">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speculativeResponse">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reengageEnabled">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hangupAfterSeconds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hangupFarewellMode">
        /// What the agent says before a silence hangup. `off` (default) hangs up without a word, `generated` says a short goodbye, `fixed` says hangup_farewell_message. A `fixed` mode with an empty message falls back to `generated`. If the caller speaks during the goodbye, the call goes on.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hangupFarewellMessage">
        /// The goodbye said verbatim in the `fixed` hangup_farewell_mode, at most 500 characters. `{{variable}}` placeholders are filled in for each session. "" clears it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="recordAudio">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="timezone">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transferDestinations">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transferRefuseQuestions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="outbound">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="keypadMenu">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="keypadInput">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="echoGuard">
        /// Echo guard. For the first 3 seconds after the agent first starts talking in a call, the caller cannot interrupt it and anything the caller says while the agent is talking is not heard. This stops the agent's own voice, echoing back from a speakerphone or laptop, from cutting it off. Per channel: true on, false off, null uses the default (on for web_voice and phone_inbound, off for phone_outbound). Channels you send replace the stored value, null on a channel resets it to the default, channels you leave out are kept. null resets every channel.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentConversationPatch(
            int? maxDurationSeconds,
            int? responseWaitMs,
            global::FishAudio.PublicAgentConversationPatchEagerness? eagerness,
            int? responseMaxWaitMs,
            bool? interruptible,
            global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity? interruptionSensitivity,
            global::System.Collections.Generic.IList<string>? interruptionIgnorePhrases,
            bool? speculativeResponse,
            bool? reengageEnabled,
            int? hangupAfterSeconds,
            global::FishAudio.PublicAgentConversationPatchHangupFarewellMode? hangupFarewellMode,
            string? hangupFarewellMessage,
            bool? recordAudio,
            string? timezone,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>? transferDestinations,
            bool? transferRefuseQuestions,
            global::FishAudio.AgentOutboundPatch? outbound,
            global::FishAudio.AgentKeypadMenuPatch? keypadMenu,
            global::FishAudio.AgentKeypadInputPatch? keypadInput,
            global::FishAudio.AgentEchoGuardPatch? echoGuard)
        {
            this.MaxDurationSeconds = maxDurationSeconds;
            this.ResponseWaitMs = responseWaitMs;
            this.Eagerness = eagerness;
            this.ResponseMaxWaitMs = responseMaxWaitMs;
            this.Interruptible = interruptible;
            this.InterruptionSensitivity = interruptionSensitivity;
            this.InterruptionIgnorePhrases = interruptionIgnorePhrases;
            this.SpeculativeResponse = speculativeResponse;
            this.ReengageEnabled = reengageEnabled;
            this.HangupAfterSeconds = hangupAfterSeconds;
            this.HangupFarewellMode = hangupFarewellMode;
            this.HangupFarewellMessage = hangupFarewellMessage;
            this.RecordAudio = recordAudio;
            this.Timezone = timezone;
            this.TransferDestinations = transferDestinations;
            this.TransferRefuseQuestions = transferRefuseQuestions;
            this.Outbound = outbound;
            this.KeypadMenu = keypadMenu;
            this.KeypadInput = keypadInput;
            this.EchoGuard = echoGuard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentConversationPatch" /> class.
        /// </summary>
        public PublicAgentConversationPatch()
        {
        }

    }
}