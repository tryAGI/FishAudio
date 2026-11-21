
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// What happens when the last follow-up goes unanswered. `wait` (what a new agent starts with): the agent stays quiet until hangup_after_seconds ends the call. `hangup`: the agent hangs up after `exhausted_after_seconds` more seconds of silence. hangup_farewell_mode applies to either hangup. Agents created before this setting existed are on `hangup` until changed.
    /// </summary>
    public enum AgentReengageConfigExhaustedAction
    {
        /// <summary>
        /// the agent stays quiet until hangup_after_seconds ends the call. `hangup`: the agent hangs up after `exhausted_after_seconds` more seconds of silence. hangup_farewell_mode applies to either hangup. Agents created before this setting existed are on `hangup` until changed.
        /// </summary>
        Hangup,
        /// <summary>
        /// the agent stays quiet until hangup_after_seconds ends the call. `hangup`: the agent hangs up after `exhausted_after_seconds` more seconds of silence. hangup_farewell_mode applies to either hangup. Agents created before this setting existed are on `hangup` until changed.
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentReengageConfigExhaustedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentReengageConfigExhaustedAction value)
        {
            return value switch
            {
                AgentReengageConfigExhaustedAction.Hangup => "hangup",
                AgentReengageConfigExhaustedAction.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentReengageConfigExhaustedAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => AgentReengageConfigExhaustedAction.Hangup,
                "wait" => AgentReengageConfigExhaustedAction.Wait,
                _ => null,
            };
        }
    }
}