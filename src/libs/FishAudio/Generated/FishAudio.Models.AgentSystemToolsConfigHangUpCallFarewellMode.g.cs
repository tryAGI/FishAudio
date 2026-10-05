
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: generated
    /// </summary>
    public enum AgentSystemToolsConfigHangUpCallFarewellMode
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
        /// <summary>
        ///
        /// </summary>
        Generated,
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSystemToolsConfigHangUpCallFarewellModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSystemToolsConfigHangUpCallFarewellMode value)
        {
            return value switch
            {
                AgentSystemToolsConfigHangUpCallFarewellMode.Fixed => "fixed",
                AgentSystemToolsConfigHangUpCallFarewellMode.Generated => "generated",
                AgentSystemToolsConfigHangUpCallFarewellMode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSystemToolsConfigHangUpCallFarewellMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AgentSystemToolsConfigHangUpCallFarewellMode.Fixed,
                "generated" => AgentSystemToolsConfigHangUpCallFarewellMode.Generated,
                "off" => AgentSystemToolsConfigHangUpCallFarewellMode.Off,
                _ => null,
            };
        }
    }
}