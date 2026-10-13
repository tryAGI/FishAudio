
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionKeypadMenuInput
    {
        /// <summary>
        ///
        /// </summary>
        Dtmf,
        /// <summary>
        ///
        /// </summary>
        Speech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionKeypadMenuInputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionKeypadMenuInput value)
        {
            return value switch
            {
                AgentSessionKeypadMenuInput.Dtmf => "dtmf",
                AgentSessionKeypadMenuInput.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionKeypadMenuInput? ToEnum(string value)
        {
            return value switch
            {
                "dtmf" => AgentSessionKeypadMenuInput.Dtmf,
                "speech" => AgentSessionKeypadMenuInput.Speech,
                _ => null,
            };
        }
    }
}