
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: return_to_agent
    /// </summary>
    public enum AgentTransferOnFailurePatchAction
    {
        /// <summary>
        ///
        /// </summary>
        EndCall,
        /// <summary>
        ///
        /// </summary>
        ReturnToAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTransferOnFailurePatchActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferOnFailurePatchAction value)
        {
            return value switch
            {
                AgentTransferOnFailurePatchAction.EndCall => "end_call",
                AgentTransferOnFailurePatchAction.ReturnToAgent => "return_to_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferOnFailurePatchAction? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => AgentTransferOnFailurePatchAction.EndCall,
                "return_to_agent" => AgentTransferOnFailurePatchAction.ReturnToAgent,
                _ => null,
            };
        }
    }
}