
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Sent to your endpoint as the Authorization bearer token; write-only, reads return null. Required when introducing `custom`; omit to keep the stored key when updating.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class PublicAgentLLMCustomConfigApiKey
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}