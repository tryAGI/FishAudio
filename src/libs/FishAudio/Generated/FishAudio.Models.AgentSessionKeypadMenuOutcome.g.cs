
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionKeypadMenuOutcome
    {
        /// <summary>
        ///
        /// </summary>
        NoInput,
        /// <summary>
        ///
        /// </summary>
        NoMatch,
        /// <summary>
        ///
        /// </summary>
        Selected,
        /// <summary>
        ///
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionKeypadMenuOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionKeypadMenuOutcome value)
        {
            return value switch
            {
                AgentSessionKeypadMenuOutcome.NoInput => "no_input",
                AgentSessionKeypadMenuOutcome.NoMatch => "no_match",
                AgentSessionKeypadMenuOutcome.Selected => "selected",
                AgentSessionKeypadMenuOutcome.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionKeypadMenuOutcome? ToEnum(string value)
        {
            return value switch
            {
                "no_input" => AgentSessionKeypadMenuOutcome.NoInput,
                "no_match" => AgentSessionKeypadMenuOutcome.NoMatch,
                "selected" => AgentSessionKeypadMenuOutcome.Selected,
                "skipped" => AgentSessionKeypadMenuOutcome.Skipped,
                _ => null,
            };
        }
    }
}