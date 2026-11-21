
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Silence follow-ups. The defaults are the legacy values, what the<br/>
    /// runtime did before the object existed, so a stored config without it<br/>
    /// keeps that behavior. New agents are created with NEW_AGENT_REENGAGE. The<br/>
    /// default factories keep the legacy values out of the public schema.
    /// </summary>
    public sealed partial class AgentReengageConfig
    {
        /// <summary>
        /// Whether the agent follows up when the caller stays silent (default false). `steps` sets when and what it says. Turning this off keeps the steps.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The follow-ups the agent makes while the caller stays silent, in order, 1 to 10 steps. Used only while `enabled` is true. A new agent starts with two steps, after 8 and 10 seconds. When the caller speaks, the sequence starts over from the first step. Agents created before these settings existed keep their earlier behavior until changed: follow-ups after 5 and 10 seconds, then a hangup 10 seconds later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentReengageStep>? Steps { get; set; }

        /// <summary>
        /// What happens when the last follow-up goes unanswered. `wait` (what a new agent starts with): the agent stays quiet until hangup_after_seconds ends the call. `hangup`: the agent hangs up after `exhausted_after_seconds` more seconds of silence. hangup_farewell_mode applies to either hangup. Agents created before this setting existed are on `hangup` until changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhausted_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentReengageConfigExhaustedActionJsonConverter))]
        public global::FishAudio.AgentReengageConfigExhaustedAction? ExhaustedAction { get; set; }

        /// <summary>
        /// Seconds of silence after the last follow-up before the agent hangs up, 3 to 600 seconds (default 10). Used only when `exhausted_action` is `hangup`.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhausted_after_seconds")]
        public int? ExhaustedAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReengageConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the agent follows up when the caller stays silent (default false). `steps` sets when and what it says. Turning this off keeps the steps.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="steps">
        /// The follow-ups the agent makes while the caller stays silent, in order, 1 to 10 steps. Used only while `enabled` is true. A new agent starts with two steps, after 8 and 10 seconds. When the caller speaks, the sequence starts over from the first step. Agents created before these settings existed keep their earlier behavior until changed: follow-ups after 5 and 10 seconds, then a hangup 10 seconds later.
        /// </param>
        /// <param name="exhaustedAction">
        /// What happens when the last follow-up goes unanswered. `wait` (what a new agent starts with): the agent stays quiet until hangup_after_seconds ends the call. `hangup`: the agent hangs up after `exhausted_after_seconds` more seconds of silence. hangup_farewell_mode applies to either hangup. Agents created before this setting existed are on `hangup` until changed.
        /// </param>
        /// <param name="exhaustedAfterSeconds">
        /// Seconds of silence after the last follow-up before the agent hangs up, 3 to 600 seconds (default 10). Used only when `exhausted_action` is `hangup`.<br/>
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentReengageConfig(
            bool? enabled,
            global::System.Collections.Generic.IList<global::FishAudio.AgentReengageStep>? steps,
            global::FishAudio.AgentReengageConfigExhaustedAction? exhaustedAction,
            int? exhaustedAfterSeconds)
        {
            this.Enabled = enabled;
            this.Steps = steps;
            this.ExhaustedAction = exhaustedAction;
            this.ExhaustedAfterSeconds = exhaustedAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReengageConfig" /> class.
        /// </summary>
        public AgentReengageConfig()
        {
        }

    }
}