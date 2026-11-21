
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum PublicSipNumberConfigPayloadTerminationTransport
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Tcp,
        /// <summary>
        ///
        /// </summary>
        Tls,
        /// <summary>
        ///
        /// </summary>
        Udp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicSipNumberConfigPayloadTerminationTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicSipNumberConfigPayloadTerminationTransport value)
        {
            return value switch
            {
                PublicSipNumberConfigPayloadTerminationTransport.Auto => "auto",
                PublicSipNumberConfigPayloadTerminationTransport.Tcp => "tcp",
                PublicSipNumberConfigPayloadTerminationTransport.Tls => "tls",
                PublicSipNumberConfigPayloadTerminationTransport.Udp => "udp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicSipNumberConfigPayloadTerminationTransport? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PublicSipNumberConfigPayloadTerminationTransport.Auto,
                "tcp" => PublicSipNumberConfigPayloadTerminationTransport.Tcp,
                "tls" => PublicSipNumberConfigPayloadTerminationTransport.Tls,
                "udp" => PublicSipNumberConfigPayloadTerminationTransport.Udp,
                _ => null,
            };
        }
    }
}