
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferItemOutcome
    {
        /// <summary>
        ///
        /// </summary>
        CallerHangup,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        ConsultClosed,
        /// <summary>
        ///
        /// </summary>
        ConsultTimeout,
        /// <summary>
        ///
        /// </summary>
        Declined,
        /// <summary>
        ///
        /// </summary>
        DialFailed,
        /// <summary>
        ///
        /// </summary>
        Ivr,
        /// <summary>
        ///
        /// </summary>
        MergeFailed,
        /// <summary>
        ///
        /// </summary>
        Merged,
        /// <summary>
        ///
        /// </summary>
        ReferFailed,
        /// <summary>
        ///
        /// </summary>
        Referred,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
        /// <summary>
        ///
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionTransferItemOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferItemOutcome value)
        {
            return value switch
            {
                AgentSessionTransferItemOutcome.CallerHangup => "caller_hangup",
                AgentSessionTransferItemOutcome.Cancelled => "cancelled",
                AgentSessionTransferItemOutcome.ConsultClosed => "consult_closed",
                AgentSessionTransferItemOutcome.ConsultTimeout => "consult_timeout",
                AgentSessionTransferItemOutcome.Declined => "declined",
                AgentSessionTransferItemOutcome.DialFailed => "dial_failed",
                AgentSessionTransferItemOutcome.Ivr => "ivr",
                AgentSessionTransferItemOutcome.MergeFailed => "merge_failed",
                AgentSessionTransferItemOutcome.Merged => "merged",
                AgentSessionTransferItemOutcome.ReferFailed => "refer_failed",
                AgentSessionTransferItemOutcome.Referred => "referred",
                AgentSessionTransferItemOutcome.Unavailable => "unavailable",
                AgentSessionTransferItemOutcome.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferItemOutcome? ToEnum(string value)
        {
            return value switch
            {
                "caller_hangup" => AgentSessionTransferItemOutcome.CallerHangup,
                "cancelled" => AgentSessionTransferItemOutcome.Cancelled,
                "consult_closed" => AgentSessionTransferItemOutcome.ConsultClosed,
                "consult_timeout" => AgentSessionTransferItemOutcome.ConsultTimeout,
                "declined" => AgentSessionTransferItemOutcome.Declined,
                "dial_failed" => AgentSessionTransferItemOutcome.DialFailed,
                "ivr" => AgentSessionTransferItemOutcome.Ivr,
                "merge_failed" => AgentSessionTransferItemOutcome.MergeFailed,
                "merged" => AgentSessionTransferItemOutcome.Merged,
                "refer_failed" => AgentSessionTransferItemOutcome.ReferFailed,
                "referred" => AgentSessionTransferItemOutcome.Referred,
                "unavailable" => AgentSessionTransferItemOutcome.Unavailable,
                "voicemail" => AgentSessionTransferItemOutcome.Voicemail,
                _ => null,
            };
        }
    }
}