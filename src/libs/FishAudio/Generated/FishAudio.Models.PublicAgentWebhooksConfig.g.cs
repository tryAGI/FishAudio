
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentWebhooksConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call")]
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhook>? PostCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentWebhooksConfig" /> class.
        /// </summary>
        /// <param name="postCall"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentWebhooksConfig(
            global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhook>? postCall)
        {
            this.PostCall = postCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentWebhooksConfig" /> class.
        /// </summary>
        public PublicAgentWebhooksConfig()
        {
        }

    }
}