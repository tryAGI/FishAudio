
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: #
    /// </summary>
    public enum AgentKeypadInputTerminator
    {
        /// <summary>
        ///
        /// </summary>
        x_,
        /// <summary>
        ///
        /// </summary>
        Multiply,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentKeypadInputTerminatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentKeypadInputTerminator value)
        {
            return value switch
            {
                AgentKeypadInputTerminator.x_ => "#",
                AgentKeypadInputTerminator.Multiply => "*",
                AgentKeypadInputTerminator.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentKeypadInputTerminator? ToEnum(string value)
        {
            return value switch
            {
                "#" => AgentKeypadInputTerminator.x_,
                "*" => AgentKeypadInputTerminator.Multiply,
                "none" => AgentKeypadInputTerminator.None,
                _ => null,
            };
        }
    }
}