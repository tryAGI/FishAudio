
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `live` once at least one version is published; `draft` agents cannot take sessions yet.
    /// </summary>
    public enum PublicAgentEntityPublicationState
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
    public static class PublicAgentEntityPublicationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentEntityPublicationState value)
        {
            return value switch
            {
                PublicAgentEntityPublicationState.Draft => "draft",
                PublicAgentEntityPublicationState.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentEntityPublicationState? ToEnum(string value)
        {
            return value switch
            {
                "draft" => PublicAgentEntityPublicationState.Draft,
                "live" => PublicAgentEntityPublicationState.Live,
                _ => null,
            };
        }
    }
}