
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
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public bool? LanguageDetection { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hang_up_call")]
        public bool? HangUpCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSystemToolsConfig" /> class.
        /// </summary>
        /// <param name="languageDetection">
        /// Default Value: false
        /// </param>
        /// <param name="hangUpCall">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSystemToolsConfig(
            bool? languageDetection,
            bool? hangUpCall)
        {
            this.LanguageDetection = languageDetection;
            this.HangUpCall = hangUpCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSystemToolsConfig" /> class.
        /// </summary>
        public AgentSystemToolsConfig()
        {
        }

    }
}