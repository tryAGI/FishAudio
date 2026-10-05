
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicSystemToolsPatchHangUpCallFarewellMode
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
    public static class PublicSystemToolsPatchHangUpCallFarewellModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicSystemToolsPatchHangUpCallFarewellMode value)
        {
            return value switch
            {
                PublicSystemToolsPatchHangUpCallFarewellMode.Fixed => "fixed",
                PublicSystemToolsPatchHangUpCallFarewellMode.Generated => "generated",
                PublicSystemToolsPatchHangUpCallFarewellMode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicSystemToolsPatchHangUpCallFarewellMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => PublicSystemToolsPatchHangUpCallFarewellMode.Fixed,
                "generated" => PublicSystemToolsPatchHangUpCallFarewellMode.Generated,
                "off" => PublicSystemToolsPatchHangUpCallFarewellMode.Off,
                _ => null,
            };
        }
    }
}