
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentWebhooksPatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call")]
        public global::FishAudio.PublicPostCallWebhookPayload? PostCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentWebhooksPatch" /> class.
        /// </summary>
        /// <param name="postCall">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentWebhooksPatch(
            global::FishAudio.PublicPostCallWebhookPayload? postCall)
        {
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