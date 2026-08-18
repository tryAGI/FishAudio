
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Pre-call webhook for inbound phone calls: called while the call is being set up; the response's dynamic_variables render into the published prompt before the agent speaks. An explicit null removes it. Takes effect after the next publish.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class PublicAgentWebhooksPatchConversationInit
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}