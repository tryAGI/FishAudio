
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// all: every tool answers from a mock, except real_tools, which run for<br/>
    /// real. selected: only the listed tools do, the rest follow fallback.<br/>
    /// none: every tool hits its real endpoint.
    /// </summary>
    public sealed partial class AgentTestToolMocks
    {
        /// <summary>
        /// Default Value: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTestToolMocksStrategyJsonConverter))]
        public global::FishAudio.AgentTestToolMocksStrategy? Strategy { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTestToolMocksFallbackJsonConverter))]
        public global::FishAudio.AgentTestToolMocksFallback? Fallback { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolMock>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("real_tools")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>? RealTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestToolMocks" /> class.
        /// </summary>
        /// <param name="strategy">
        /// Default Value: all
        /// </param>
        /// <param name="fallback">
        /// Default Value: error
        /// </param>
        /// <param name="tools"></param>
        /// <param name="realTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestToolMocks(
            global::FishAudio.AgentTestToolMocksStrategy? strategy,
            global::FishAudio.AgentTestToolMocksFallback? fallback,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolMock>? tools,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>? realTools)
        {
            this.Strategy = strategy;
            this.Fallback = fallback;
            this.Tools = tools;
            this.RealTools = realTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestToolMocks" /> class.
        /// </summary>
        public AgentTestToolMocks()
        {
        }

    }
}