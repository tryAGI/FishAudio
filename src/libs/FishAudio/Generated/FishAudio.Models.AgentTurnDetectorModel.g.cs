
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTurnDetectorModel
    {
        /// <summary>
        ///
        /// </summary>
        Fish,
        /// <summary>
        ///
        /// </summary>
        Legacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTurnDetectorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTurnDetectorModel value)
        {
            return value switch
            {
                AgentTurnDetectorModel.Fish => "fish",
                AgentTurnDetectorModel.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTurnDetectorModel? ToEnum(string value)
        {
            return value switch
            {
                "fish" => AgentTurnDetectorModel.Fish,
                "legacy" => AgentTurnDetectorModel.Legacy,
                _ => null,
            };
        }
    }
}