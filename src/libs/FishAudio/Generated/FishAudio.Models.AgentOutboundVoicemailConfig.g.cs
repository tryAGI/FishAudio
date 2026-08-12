
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 1:1 mirror of core WorkflowOutboundVoicemail: message is verbatim text<br/>
    /// for leave_message, an LLM prompt for leave_prompt_message; supports<br/>
    /// {{dynamic_variables}}, rendered at session build.
    /// </summary>
    public sealed partial class AgentOutboundVoicemailConfig
    {
        /// <summary>
        /// Default Value: hangup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentOutboundVoicemailConfigActionJsonConverter))]
        public global::FishAudio.AgentOutboundVoicemailConfigAction? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundVoicemailConfig" /> class.
        /// </summary>
        /// <param name="action">
        /// Default Value: hangup
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOutboundVoicemailConfig(
            global::FishAudio.AgentOutboundVoicemailConfigAction? action,
            string? message)
        {
            this.Action = action;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundVoicemailConfig" /> class.
        /// </summary>
        public AgentOutboundVoicemailConfig()
        {
        }

    }
}