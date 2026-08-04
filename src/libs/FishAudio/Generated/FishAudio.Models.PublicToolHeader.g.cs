
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicToolHeader
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicToolHeaderKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicToolHeaderKind Kind { get; set; }

        /// <summary>
        /// Header value; null for credential kinds (authorization_bearer / authorization_basic), which are write-only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Whether a credential value is stored; the value itself is never returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_secret")]
        public bool? HasSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicToolHeader" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="value">
        /// Header value; null for credential kinds (authorization_bearer / authorization_basic), which are write-only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hasSecret">
        /// Whether a credential value is stored; the value itself is never returned.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicToolHeader(
            string name,
            global::FishAudio.PublicToolHeaderKind kind,
            string? value,
            bool? hasSecret)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.Value = value;
            this.HasSecret = hasSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicToolHeader" /> class.
        /// </summary>
        public PublicToolHeader()
        {
        }

    }
}