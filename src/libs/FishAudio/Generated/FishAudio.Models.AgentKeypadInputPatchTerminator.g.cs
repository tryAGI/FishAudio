
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: #
    /// </summary>
    public enum AgentKeypadInputPatchTerminator
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
    public static class AgentKeypadInputPatchTerminatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentKeypadInputPatchTerminator value)
        {
            return value switch
            {
                AgentKeypadInputPatchTerminator.x_ => "#",
                AgentKeypadInputPatchTerminator.Multiply => "*",
                AgentKeypadInputPatchTerminator.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentKeypadInputPatchTerminator? ToEnum(string value)
        {
            return value switch
            {
                "#" => AgentKeypadInputPatchTerminator.x_,
                "*" => AgentKeypadInputPatchTerminator.Multiply,
                "none" => AgentKeypadInputPatchTerminator.None,
                _ => null,
            };
        }
    }
}