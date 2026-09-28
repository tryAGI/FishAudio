
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentAsrConfig
    {
        /// <summary>
        /// Default Value: deepgram:nova-3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentAsrConfigModelJsonConverter))]
        public global::FishAudio.AgentAsrConfigModel? Model { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multilingual")]
        public bool? Multilingual { get; set; }

        /// <summary>
        /// Enforces voice.speaking_language whatever multilingual says: speech recognized as another language reaches the agent as [unintelligible speech]. Language is detected per utterance, so a short or heavily accented phrase in the speaking language can occasionally be detected as another language and replaced too. With deepgram:nova-3, speech in another language is usually not transcribed at all. Only enable it when you explicitly need to stop the agent from understanding other languages.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_language")]
        public bool? StrictLanguage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAsrConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// Default Value: deepgram:nova-3
        /// </param>
        /// <param name="multilingual">
        /// Default Value: false
        /// </param>
        /// <param name="strictLanguage">
        /// Enforces voice.speaking_language whatever multilingual says: speech recognized as another language reaches the agent as [unintelligible speech]. Language is detected per utterance, so a short or heavily accented phrase in the speaking language can occasionally be detected as another language and replaced too. With deepgram:nova-3, speech in another language is usually not transcribed at all. Only enable it when you explicitly need to stop the agent from understanding other languages.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keyterms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAsrConfig(
            global::FishAudio.AgentAsrConfigModel? model,
            bool? multilingual,
            bool? strictLanguage,
            global::System.Collections.Generic.IList<string>? keyterms)
        {
            this.Model = model;
            this.Multilingual = multilingual;
            this.StrictLanguage = strictLanguage;
            this.Keyterms = keyterms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAsrConfig" /> class.
        /// </summary>
        public AgentAsrConfig()
        {
        }

    }
}