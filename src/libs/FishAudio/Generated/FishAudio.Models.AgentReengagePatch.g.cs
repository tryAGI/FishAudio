
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentReengagePatch
    {
        /// <summary>
        /// Whether the agent follows up when the caller stays silent (default false). `steps` sets when and what it says. Turning this off keeps the steps.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The follow-ups the agent makes while the caller stays silent, in order, 1 to 10 steps. Used only while `enabled` is true. A new agent starts with two steps, after 8 and 10 seconds. When the caller speaks, the sequence starts over from the first step. Agents created before these settings existed keep their earlier behavior until changed: follow-ups after 5 and 10 seconds, then a hangup 10 seconds later. Replaces the whole list. Cannot be sent together with `schedule`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentReengageStepPatch>? Steps { get; set; }

        /// <summary>
        /// What happens when the last follow-up goes unanswered. `wait` (what a new agent starts with): the agent stays quiet until hangup_after_seconds ends the call. `hangup`: the agent hangs up after `exhausted_after_seconds` more seconds of silence. hangup_farewell_mode applies to either hangup. Agents created before this setting existed are on `hangup` until changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhausted_action")]
        public global::FishAudio.AgentReengagePatchExhaustedAction? ExhaustedAction { get; set; }

        /// <summary>
        /// Seconds of silence after the last follow-up before the agent hangs up, 3 to 600 seconds (default 10). Used only when `exhausted_action` is `hangup`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhausted_after_seconds")]
        public int? ExhaustedAfterSeconds { get; set; }

        /// <summary>
        /// Shorthand for evenly spaced follow-ups, accepted on writes only and never returned. It replaces `steps` with `count` steps (the first after `first_seconds`, each later one after `interval_seconds`) and sets `exhausted_after_seconds` to `interval_seconds` unless the same request sets it. `exhausted_action` stays as it is. Cannot be sent together with `steps`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public global::FishAudio.AgentReengageSchedulePatch? Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReengagePatch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the agent follows up when the caller stays silent (default false). `steps` sets when and what it says. Turning this off keeps the steps.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="steps">
        /// The follow-ups the agent makes while the caller stays silent, in order, 1 to 10 steps. Used only while `enabled` is true. A new agent starts with two steps, after 8 and 10 seconds. When the caller speaks, the sequence starts over from the first step. Agents created before these settings existed keep their earlier behavior until changed: follow-ups after 5 and 10 seconds, then a hangup 10 seconds later. Replaces the whole list. Cannot be sent together with `schedule`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="exhaustedAction">
        /// What happens when the last follow-up goes unanswered. `wait` (what a new agent starts with): the agent stays quiet until hangup_after_seconds ends the call. `hangup`: the agent hangs up after `exhausted_after_seconds` more seconds of silence. hangup_farewell_mode applies to either hangup. Agents created before this setting existed are on `hangup` until changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="exhaustedAfterSeconds">
        /// Seconds of silence after the last follow-up before the agent hangs up, 3 to 600 seconds (default 10). Used only when `exhausted_action` is `hangup`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="schedule">
        /// Shorthand for evenly spaced follow-ups, accepted on writes only and never returned. It replaces `steps` with `count` steps (the first after `first_seconds`, each later one after `interval_seconds`) and sets `exhausted_after_seconds` to `interval_seconds` unless the same request sets it. `exhausted_action` stays as it is. Cannot be sent together with `steps`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentReengagePatch(
            bool? enabled,
            global::System.Collections.Generic.IList<global::FishAudio.AgentReengageStepPatch>? steps,
            global::FishAudio.AgentReengagePatchExhaustedAction? exhaustedAction,
            int? exhaustedAfterSeconds,
            global::FishAudio.AgentReengageSchedulePatch? schedule)
        {
            this.Enabled = enabled;
            this.Steps = steps;
            this.ExhaustedAction = exhaustedAction;
            this.ExhaustedAfterSeconds = exhaustedAfterSeconds;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReengagePatch" /> class.
        /// </summary>
        public AgentReengagePatch()
        {
        }

    }
}