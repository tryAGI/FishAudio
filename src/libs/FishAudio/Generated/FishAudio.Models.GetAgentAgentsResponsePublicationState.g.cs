
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `live` once at least one version is published; `draft` agents cannot take sessions yet.
    /// </summary>
    public enum GetAgentAgentsResponsePublicationState
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
    public static class GetAgentAgentsResponsePublicationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentAgentsResponsePublicationState value)
        {
            return value switch
            {
                GetAgentAgentsResponsePublicationState.Draft => "draft",
                GetAgentAgentsResponsePublicationState.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentAgentsResponsePublicationState? ToEnum(string value)
        {
            return value switch
            {
                "draft" => GetAgentAgentsResponsePublicationState.Draft,
                "live" => GetAgentAgentsResponsePublicationState.Live,
                _ => null,
            };
        }
    }
}