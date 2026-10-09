
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Defaults for `{{name}}` placeholders and what a placeholder without a value does.
    /// </summary>
    public sealed partial class AgentVariablesConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public object? Defaults { get; set; }

        /// <summary>
        /// Default Value: keep
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_missing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentVariablesConfigOnMissingJsonConverter))]
        public global::FishAudio.AgentVariablesConfigOnMissing? OnMissing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVariablesConfig" /> class.
        /// </summary>
        /// <param name="defaults"></param>
        /// <param name="onMissing">
        /// Default Value: keep
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVariablesConfig(
            object? defaults,
            global::FishAudio.AgentVariablesConfigOnMissing? onMissing)
        {
            this.Defaults = defaults;
            this.OnMissing = onMissing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVariablesConfig" /> class.
        /// </summary>
        public AgentVariablesConfig()
        {
        }

    }
}