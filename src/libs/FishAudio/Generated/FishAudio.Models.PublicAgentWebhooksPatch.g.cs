
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentWebhooksPatch
    {
        /// <summary>
        /// Pre-call webhook for inbound phone calls: called while the call is being set up; the response's dynamic_variables render into the published prompt before the agent speaks. An explicit null removes it. Takes effect after the next publish.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_init")]
        public global::FishAudio.PublicConversationInitWebhookPayload? ConversationInit { get; set; }

        /// <summary>
        /// Up to 5 endpoints, each receiving every post-call event. Replaces the configured list wholesale; a single object is still accepted and is stored as a one-element list, and null (or an empty list) clears every endpoint. URLs must be unique.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call")]
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>? PostCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentWebhooksPatch" /> class.
        /// </summary>
        /// <param name="conversationInit">
        /// Pre-call webhook for inbound phone calls: called while the call is being set up; the response's dynamic_variables render into the published prompt before the agent speaks. An explicit null removes it. Takes effect after the next publish.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="postCall">
        /// Up to 5 endpoints, each receiving every post-call event. Replaces the configured list wholesale; a single object is still accepted and is stored as a one-element list, and null (or an empty list) clears every endpoint. URLs must be unique.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentWebhooksPatch(
            global::FishAudio.PublicConversationInitWebhookPayload? conversationInit,
            global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>? postCall)
        {
            this.ConversationInit = conversationInit;
            this.PostCall = postCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentWebhooksPatch" /> class.
        /// </summary>
        public PublicAgentWebhooksPatch()
        {
        }

    }
}