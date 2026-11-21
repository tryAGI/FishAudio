
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Evenly spaced follow-ups, expanded into reengage.steps on write.
    /// </summary>
    public sealed partial class AgentReengageSchedulePatch
    {
        /// <summary>
        /// Seconds of silence, counted from the end of what the agent last said, before the first follow-up, 3 to 600 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FirstSeconds { get; set; }

        /// <summary>
        /// Seconds of silence after one follow-up before the next, 3 to 600 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IntervalSeconds { get; set; }

        /// <summary>
        /// How many follow-ups, 1 to 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Texts the agent says word for word, one per follow-up in order, at most `count` items, each with the limits of a step's message. With fewer items than `count` the last one repeats. Omit it and the agent words every follow-up itself.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReengageSchedulePatch" /> class.
        /// </summary>
        /// <param name="firstSeconds">
        /// Seconds of silence, counted from the end of what the agent last said, before the first follow-up, 3 to 600 seconds.
        /// </param>
        /// <param name="intervalSeconds">
        /// Seconds of silence after one follow-up before the next, 3 to 600 seconds.
        /// </param>
        /// <param name="count">
        /// How many follow-ups, 1 to 10.
        /// </param>
        /// <param name="messages">
        /// Texts the agent says word for word, one per follow-up in order, at most `count` items, each with the limits of a step's message. With fewer items than `count` the last one repeats. Omit it and the agent words every follow-up itself.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentReengageSchedulePatch(
            int firstSeconds,
            int intervalSeconds,
            int count,
            global::System.Collections.Generic.IList<string>? messages)
        {
            this.FirstSeconds = firstSeconds;
            this.IntervalSeconds = intervalSeconds;
            this.Count = count;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReengageSchedulePatch" /> class.
        /// </summary>
        public AgentReengageSchedulePatch()
        {
        }

    }
}