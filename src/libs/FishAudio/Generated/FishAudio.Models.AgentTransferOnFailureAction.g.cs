
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: return_to_agent
    /// </summary>
    public enum AgentTransferOnFailureAction
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
    public static class AgentTransferOnFailureActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferOnFailureAction value)
        {
            return value switch
            {
                AgentTransferOnFailureAction.EndCall => "end_call",
                AgentTransferOnFailureAction.ReturnToAgent => "return_to_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferOnFailureAction? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => AgentTransferOnFailureAction.EndCall,
                "return_to_agent" => AgentTransferOnFailureAction.ReturnToAgent,
                _ => null,
            };
        }
    }
}