
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTurnDetectorPatchModel
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
    public static class AgentTurnDetectorPatchModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTurnDetectorPatchModel value)
        {
            return value switch
            {
                AgentTurnDetectorPatchModel.Fish => "fish",
                AgentTurnDetectorPatchModel.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTurnDetectorPatchModel? ToEnum(string value)
        {
            return value switch
            {
                "fish" => AgentTurnDetectorPatchModel.Fish,
                "legacy" => AgentTurnDetectorPatchModel.Legacy,
                _ => null,
            };
        }
    }
}