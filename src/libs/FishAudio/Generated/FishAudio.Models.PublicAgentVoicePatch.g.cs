
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentVoicePatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_profile_id")]
        public string? VoiceProfileId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_language")]
        public global::FishAudio.PublicAgentVoicePatchSpeakingLanguage2? SpeakingLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentVoicePatch" /> class.
        /// </summary>
        /// <param name="voiceProfileId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speakingLanguage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentVoicePatch(
            string? voiceProfileId,
            global::FishAudio.PublicAgentVoicePatchSpeakingLanguage2? speakingLanguage)
        {
            this.VoiceProfileId = voiceProfileId;
            this.SpeakingLanguage = speakingLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentVoicePatch" /> class.
        /// </summary>
        public PublicAgentVoicePatch()
        {
        }

    }
}