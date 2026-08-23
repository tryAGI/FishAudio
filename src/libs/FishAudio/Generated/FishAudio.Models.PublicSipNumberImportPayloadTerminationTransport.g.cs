
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum PublicSipNumberImportPayloadTerminationTransport
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
    public static class PublicSipNumberImportPayloadTerminationTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicSipNumberImportPayloadTerminationTransport value)
        {
            return value switch
            {
                PublicSipNumberImportPayloadTerminationTransport.Auto => "auto",
                PublicSipNumberImportPayloadTerminationTransport.Tcp => "tcp",
                PublicSipNumberImportPayloadTerminationTransport.Tls => "tls",
                PublicSipNumberImportPayloadTerminationTransport.Udp => "udp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicSipNumberImportPayloadTerminationTransport? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PublicSipNumberImportPayloadTerminationTransport.Auto,
                "tcp" => PublicSipNumberImportPayloadTerminationTransport.Tcp,
                "tls" => PublicSipNumberImportPayloadTerminationTransport.Tls,
                "udp" => PublicSipNumberImportPayloadTerminationTransport.Udp,
                _ => null,
            };
        }
    }
}