
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum LLMMessageUsageBillingMode
    {
        /// <summary>
        ///
        /// </summary>
        Included,
        /// <summary>
        ///
        /// </summary>
        Legacy,
        /// <summary>
        ///
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMMessageUsageBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMMessageUsageBillingMode value)
        {
            return value switch
            {
                LLMMessageUsageBillingMode.Included => "included",
                LLMMessageUsageBillingMode.Legacy => "legacy",
                LLMMessageUsageBillingMode.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMMessageUsageBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "included" => LLMMessageUsageBillingMode.Included,
                "legacy" => LLMMessageUsageBillingMode.Legacy,
                "tokens" => LLMMessageUsageBillingMode.Tokens,
                _ => null,
            };
        }
    }
}