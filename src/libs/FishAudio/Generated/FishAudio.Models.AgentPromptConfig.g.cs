
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPromptConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Default Value: prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentPromptConfigFirstMessageModeJsonConverter))]
        public global::FishAudio.AgentPromptConfigFirstMessageMode? FirstMessageMode { get; set; }

        /// <summary>
        /// Default Value: Hi! Thanks for calling — how can I help you today?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Default Value: Greet the caller warmly, mention you can help with orders and callbacks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_prompt")]
        public string? FirstMessagePrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPromptConfig" /> class.
        /// </summary>
        /// <param name="systemPrompt"></param>
        /// <param name="firstMessageMode">
        /// Default Value: prompt
        /// </param>
        /// <param name="firstMessage">
        /// Default Value: Hi! Thanks for calling — how can I help you today?
        /// </param>
        /// <param name="firstMessagePrompt">
        /// Default Value: Greet the caller warmly, mention you can help with orders and callbacks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPromptConfig(
            string? systemPrompt,
            global::FishAudio.AgentPromptConfigFirstMessageMode? firstMessageMode,
            string? firstMessage,
            string? firstMessagePrompt)
        {
            this.SystemPrompt = systemPrompt;
            this.FirstMessageMode = firstMessageMode;
            this.FirstMessage = firstMessage;
            this.FirstMessagePrompt = firstMessagePrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPromptConfig" /> class.
        /// </summary>
        public AgentPromptConfig()
        {
        }

    }
}