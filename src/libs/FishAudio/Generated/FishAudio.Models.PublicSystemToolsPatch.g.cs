
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicSystemToolsPatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call")]
        public bool? HangUpCall { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call_farewell_mode")]
        public global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode? HangUpCallFarewellMode { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call_farewell_message")]
        public string? HangUpCallFarewellMessage { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call_refuse_questions")]
        public bool? HangUpCallRefuseQuestions { get; set; }

        /// <summary>
        /// Beta. Key presses on outbound phone calls, for calls that reach an automated phone menu before a person. The fields sent are written, the others stay as they are.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("press_keys")]
        public global::FishAudio.PublicPressKeysPatch? PressKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSystemToolsPatch" /> class.
        /// </summary>
        /// <param name="hangUpCall">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hangUpCallFarewellMode">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hangUpCallFarewellMessage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hangUpCallRefuseQuestions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pressKeys">
        /// Beta. Key presses on outbound phone calls, for calls that reach an automated phone menu before a person. The fields sent are written, the others stay as they are.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSystemToolsPatch(
            bool? hangUpCall,
            global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode? hangUpCallFarewellMode,
            string? hangUpCallFarewellMessage,
            bool? hangUpCallRefuseQuestions,
            global::FishAudio.PublicPressKeysPatch? pressKeys)
        {
            this.HangUpCall = hangUpCall;
            this.HangUpCallFarewellMode = hangUpCallFarewellMode;
            this.HangUpCallFarewellMessage = hangUpCallFarewellMessage;
            this.HangUpCallRefuseQuestions = hangUpCallRefuseQuestions;
            this.PressKeys = pressKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSystemToolsPatch" /> class.
        /// </summary>
        public PublicSystemToolsPatch()
        {
        }

    }
}