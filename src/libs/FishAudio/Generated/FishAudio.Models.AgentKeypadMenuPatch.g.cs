
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentKeypadMenuPatch
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentKeypadMenuOptionPatch>? Options { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accept_speech")]
        public bool? AcceptSpeech { get; set; }

        /// <summary>
        /// Default Value: menu_choice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        public string? Variable { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_input_timeout_seconds")]
        public int? NoInputTimeoutSeconds { get; set; }

        /// <summary>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_attempts")]
        public int? MaxAttempts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_message")]
        public string? RetryMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_value")]
        public string? FallbackValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKeypadMenuPatch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="options">
        /// Default Value: []
        /// </param>
        /// <param name="acceptSpeech">
        /// Default Value: true
        /// </param>
        /// <param name="variable">
        /// Default Value: menu_choice
        /// </param>
        /// <param name="noInputTimeoutSeconds">
        /// Default Value: 5
        /// </param>
        /// <param name="maxAttempts">
        /// Default Value: 2
        /// </param>
        /// <param name="retryMessage"></param>
        /// <param name="fallbackValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKeypadMenuPatch(
            bool? enabled,
            string? prompt,
            global::System.Collections.Generic.IList<global::FishAudio.AgentKeypadMenuOptionPatch>? options,
            bool? acceptSpeech,
            string? variable,
            int? noInputTimeoutSeconds,
            int? maxAttempts,
            string? retryMessage,
            string? fallbackValue)
        {
            this.Enabled = enabled;
            this.Prompt = prompt;
            this.Options = options;
            this.AcceptSpeech = acceptSpeech;
            this.Variable = variable;
            this.NoInputTimeoutSeconds = noInputTimeoutSeconds;
            this.MaxAttempts = maxAttempts;
            this.RetryMessage = retryMessage;
            this.FallbackValue = fallbackValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKeypadMenuPatch" /> class.
        /// </summary>
        public AgentKeypadMenuPatch()
        {
        }

    }
}