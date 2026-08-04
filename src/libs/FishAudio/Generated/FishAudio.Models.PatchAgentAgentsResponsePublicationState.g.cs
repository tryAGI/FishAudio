
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `live` once at least one version is published; `draft` agents cannot take sessions yet.
    /// </summary>
    public enum PatchAgentAgentsResponsePublicationState
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchAgentAgentsResponsePublicationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentAgentsResponsePublicationState value)
        {
            return value switch
            {
                PatchAgentAgentsResponsePublicationState.Draft => "draft",
                PatchAgentAgentsResponsePublicationState.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentAgentsResponsePublicationState? ToEnum(string value)
        {
            return value switch
            {
                "draft" => PatchAgentAgentsResponsePublicationState.Draft,
                "live" => PatchAgentAgentsResponsePublicationState.Live,
                _ => null,
            };
        }
    }
}