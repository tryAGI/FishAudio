
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `live` once at least one version is published; `draft` agents cannot take sessions yet.
    /// </summary>
    public enum CreateAgentAgentsResponsePublicationState
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
    public static class CreateAgentAgentsResponsePublicationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentAgentsResponsePublicationState value)
        {
            return value switch
            {
                CreateAgentAgentsResponsePublicationState.Draft => "draft",
                CreateAgentAgentsResponsePublicationState.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentAgentsResponsePublicationState? ToEnum(string value)
        {
            return value switch
            {
                "draft" => CreateAgentAgentsResponsePublicationState.Draft,
                "live" => CreateAgentAgentsResponsePublicationState.Live,
                _ => null,
            };
        }
    }
}