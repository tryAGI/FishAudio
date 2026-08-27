
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetAgentAgentsPublicationState
    {
        /// <summary>
        ///
        /// </summary>
        All,
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
    public static class GetAgentAgentsPublicationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentAgentsPublicationState value)
        {
            return value switch
            {
                GetAgentAgentsPublicationState.All => "all",
                GetAgentAgentsPublicationState.Draft => "draft",
                GetAgentAgentsPublicationState.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentAgentsPublicationState? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetAgentAgentsPublicationState.All,
                "draft" => GetAgentAgentsPublicationState.Draft,
                "live" => GetAgentAgentsPublicationState.Live,
                _ => null,
            };
        }
    }
}