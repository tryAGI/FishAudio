
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAnalysisDataField
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentAnalysisDataFieldTypeJsonConverter))]
        public global::FishAudio.AgentAnalysisDataFieldType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum_options")]
        public global::System.Collections.Generic.IList<string>? EnumOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisDataField" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="description"></param>
        /// <param name="enumOptions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAnalysisDataField(
            string name,
            global::FishAudio.AgentAnalysisDataFieldType? type,
            string? description,
            global::System.Collections.Generic.IList<string>? enumOptions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.EnumOptions = enumOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisDataField" /> class.
        /// </summary>
        public AgentAnalysisDataField()
        {
        }

    }
}