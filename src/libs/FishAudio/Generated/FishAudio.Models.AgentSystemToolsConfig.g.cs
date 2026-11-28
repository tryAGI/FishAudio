
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSystemToolsConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call")]
        public bool? HangUpCall { get; set; }

        /// <summary>
        /// Default Value: generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call_farewell_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSystemToolsConfigHangUpCallFarewellModeJsonConverter))]
        public global::FishAudio.AgentSystemToolsConfigHangUpCallFarewellMode? HangUpCallFarewellMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call_farewell_message")]
        public string? HangUpCallFarewellMessage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call_refuse_questions")]
        public bool? HangUpCallRefuseQuestions { get; set; }

        /// <summary>
        /// Beta. Key presses on outbound phone calls, for calls that reach an automated phone menu before a person.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("press_keys")]
        public global::FishAudio.AgentPressKeysConfig? PressKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSystemToolsConfig" /> class.
        /// </summary>
        /// <param name="hangUpCall">
        /// Default Value: false
        /// </param>
        /// <param name="hangUpCallFarewellMode">
        /// Default Value: generated
        /// </param>
        /// <param name="hangUpCallFarewellMessage"></param>
        /// <param name="hangUpCallRefuseQuestions">
        /// Default Value: false
        /// </param>
        /// <param name="pressKeys">
        /// Beta. Key presses on outbound phone calls, for calls that reach an automated phone menu before a person.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSystemToolsConfig(
            bool? hangUpCall,
            global::FishAudio.AgentSystemToolsConfigHangUpCallFarewellMode? hangUpCallFarewellMode,
            string? hangUpCallFarewellMessage,
            bool? hangUpCallRefuseQuestions,
            global::FishAudio.AgentPressKeysConfig? pressKeys)
        {
            this.HangUpCall = hangUpCall;
            this.HangUpCallFarewellMode = hangUpCallFarewellMode;
            this.HangUpCallFarewellMessage = hangUpCallFarewellMessage;
            this.HangUpCallRefuseQuestions = hangUpCallRefuseQuestions;
            this.PressKeys = pressKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSystemToolsConfig" /> class.
        /// </summary>
        public AgentSystemToolsConfig()
        {
        }

    }
}