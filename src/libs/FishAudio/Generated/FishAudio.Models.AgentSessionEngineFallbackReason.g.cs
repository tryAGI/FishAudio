
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionEngineFallbackReason
    {
        /// <summary>
        ///
        /// </summary>
        EngineUnavailable,
        /// <summary>
        ///
        /// </summary>
        InvalidConfig,
        /// <summary>
        ///
        /// </summary>
        UnsupportedLanguage,
        /// <summary>
        ///
        /// </summary>
        VoiceUnusable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionEngineFallbackReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionEngineFallbackReason value)
        {
            return value switch
            {
                AgentSessionEngineFallbackReason.EngineUnavailable => "engine_unavailable",
                AgentSessionEngineFallbackReason.InvalidConfig => "invalid_config",
                AgentSessionEngineFallbackReason.UnsupportedLanguage => "unsupported_language",
                AgentSessionEngineFallbackReason.VoiceUnusable => "voice_unusable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionEngineFallbackReason? ToEnum(string value)
        {
            return value switch
            {
                "engine_unavailable" => AgentSessionEngineFallbackReason.EngineUnavailable,
                "invalid_config" => AgentSessionEngineFallbackReason.InvalidConfig,
                "unsupported_language" => AgentSessionEngineFallbackReason.UnsupportedLanguage,
                "voice_unusable" => AgentSessionEngineFallbackReason.VoiceUnusable,
                _ => null,
            };
        }
    }
}