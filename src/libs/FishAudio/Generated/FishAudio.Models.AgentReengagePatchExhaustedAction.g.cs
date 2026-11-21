
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentReengagePatchExhaustedAction
    {
        /// <summary>
        ///
        /// </summary>
        Hangup,
        /// <summary>
        ///
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentReengagePatchExhaustedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentReengagePatchExhaustedAction value)
        {
            return value switch
            {
                AgentReengagePatchExhaustedAction.Hangup => "hangup",
                AgentReengagePatchExhaustedAction.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentReengagePatchExhaustedAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => AgentReengagePatchExhaustedAction.Hangup,
                "wait" => AgentReengagePatchExhaustedAction.Wait,
                _ => null,
            };
        }
    }
}