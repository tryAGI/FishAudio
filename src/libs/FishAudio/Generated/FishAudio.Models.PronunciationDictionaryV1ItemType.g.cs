
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// How the key is replaced: `phoneme` (default) speaks the value as a phonetic form; `alias` substitutes the literal text, which is then read like the rest of the request.<br/>
    /// Default Value: phoneme
    /// </summary>
    public enum PronunciationDictionaryV1ItemType
    {
        /// <summary>
        /// `phoneme` (default) speaks the value as a phonetic form; `alias` substitutes the literal text, which is then read like the rest of the request.
        /// </summary>
        Alias,
        /// <summary>
        /// `phoneme` (default) speaks the value as a phonetic form; `alias` substitutes the literal text, which is then read like the rest of the request.
        /// </summary>
        Phoneme,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictionaryV1ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryV1ItemType value)
        {
            return value switch
            {
                PronunciationDictionaryV1ItemType.Alias => "alias",
                PronunciationDictionaryV1ItemType.Phoneme => "phoneme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryV1ItemType? ToEnum(string value)
        {
            return value switch
            {
                "alias" => PronunciationDictionaryV1ItemType.Alias,
                "phoneme" => PronunciationDictionaryV1ItemType.Phoneme,
                _ => null,
            };
        }
    }
}