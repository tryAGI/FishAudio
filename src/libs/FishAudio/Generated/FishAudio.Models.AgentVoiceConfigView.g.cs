
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Read shape of the voice section. The ASR fields that moved to the asr<br/>
    /// section stay mirrored here, deprecated, so clients written before the split<br/>
    /// keep reading them.
    /// </summary>
    public sealed partial class AgentVoiceConfigView
    {
        /// <summary>
        /// Default Value: b347db033a6549378b48d00acb0d06cd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentVoiceConfigViewSpeakingLanguageJsonConverter))]
        public global::FishAudio.AgentVoiceConfigViewSpeakingLanguage? SpeakingLanguage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressive")]
        public bool? Expressive { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceConfigView" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Default Value: b347db033a6549378b48d00acb0d06cd
        /// </param>
        /// <param name="speakingLanguage">
        /// Default Value: en
        /// </param>
        /// <param name="expressive">
        /// Default Value: false
        /// </param>
        /// <param name="speed">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVoiceConfigView(
            string? voiceId,
            global::FishAudio.AgentVoiceConfigViewSpeakingLanguage? speakingLanguage,
            bool? expressive,
            double? speed)
        {
            this.VoiceId = voiceId;
            this.SpeakingLanguage = speakingLanguage;
            this.Expressive = expressive;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceConfigView" /> class.
        /// </summary>
        public AgentVoiceConfigView()
        {
        }

    }
}