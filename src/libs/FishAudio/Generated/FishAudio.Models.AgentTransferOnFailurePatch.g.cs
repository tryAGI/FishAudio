
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTransferOnFailurePatch
    {
        /// <summary>
        /// Default Value: return_to_agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferOnFailurePatchActionJsonConverter))]
        public global::FishAudio.AgentTransferOnFailurePatchAction? Action { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentTransferOnFailurePatch" /> class.
        /// </summary>
        /// <param name="action">
        /// Default Value: return_to_agent
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransferOnFailurePatch(
            global::FishAudio.AgentTransferOnFailurePatchAction? action,
            string? message)
        {
            this.Action = action;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferOnFailurePatch" /> class.
        /// </summary>
        public AgentTransferOnFailurePatch()
        {
        }

    }
}