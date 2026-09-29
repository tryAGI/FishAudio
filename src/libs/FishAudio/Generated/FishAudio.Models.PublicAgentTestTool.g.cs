
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestTool
    {
        /// <summary>
        /// The id to reference in tests. Webhook and client tools use their tool id, integration tools use &lt;provider_key&gt;:&lt;tool_name&gt;.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentTestToolType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The integration provider, integration tools only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_key")]
        public string? ProviderKey { get; set; }

        /// <summary>
        /// An integration tool that changes data. It cannot run for real in a test.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writes")]
        public bool? Writes { get; set; }

        /// <summary>
        /// The tool answers from its own mock when a simulation mocks every tool and the test has no entry for it.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_own_mock")]
        public bool? HasOwnMock { get; set; }

        /// <summary>
        /// False for a client tool that does not wait for an answer, which cannot be mocked.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        public bool? ExpectsResponse { get; set; }

        /// <summary>
        /// False for client tools, which need a client and never run on phone calls.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_on_phone")]
        public bool? AvailableOnPhone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestTool" /> class.
        /// </summary>
        /// <param name="id">
        /// The id to reference in tests. Webhook and client tools use their tool id, integration tools use &lt;provider_key&gt;:&lt;tool_name&gt;.
        /// </param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="providerKey">
        /// The integration provider, integration tools only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="writes">
        /// An integration tool that changes data. It cannot run for real in a test.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hasOwnMock">
        /// The tool answers from its own mock when a simulation mocks every tool and the test has no entry for it.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expectsResponse">
        /// False for a client tool that does not wait for an answer, which cannot be mocked.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="availableOnPhone">
        /// False for client tools, which need a client and never run on phone calls.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestTool(
            string id,
            string name,
            global::FishAudio.PublicAgentTestToolType type,
            string? description,
            string? providerKey,
            bool? writes,
            bool? hasOwnMock,
            bool? expectsResponse,
            bool? availableOnPhone)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.ProviderKey = providerKey;
            this.Writes = writes;
            this.HasOwnMock = hasOwnMock;
            this.ExpectsResponse = expectsResponse;
            this.AvailableOnPhone = availableOnPhone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestTool" /> class.
        /// </summary>
        public PublicAgentTestTool()
        {
        }

    }
}