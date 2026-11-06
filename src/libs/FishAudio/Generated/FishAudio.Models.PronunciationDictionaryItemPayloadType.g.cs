
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Replacement mode: `phoneme` (default, and also the meaning of an omitted or null value) speaks the value as a phonetic form; `alias` substitutes the literal text. Other values return 422.<br/>
    /// Default Value: phoneme
    /// </summary>
    public enum PronunciationDictionaryItemPayloadType
    {
        /// <summary>
        /// `phoneme` (default, and also the meaning of an omitted or null value) speaks the value as a phonetic form; `alias` substitutes the literal text. Other values return 422.
        /// </summary>
        Alias,
        /// <summary>
        /// `phoneme` (default, and also the meaning of an omitted or null value) speaks the value as a phonetic form; `alias` substitutes the literal text. Other values return 422.
        /// </summary>
        Phoneme,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictionaryItemPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryItemPayloadType value)
        {
            return value switch
            {
                PronunciationDictionaryItemPayloadType.Alias => "alias",
                PronunciationDictionaryItemPayloadType.Phoneme => "phoneme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryItemPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "alias" => PronunciationDictionaryItemPayloadType.Alias,
                "phoneme" => PronunciationDictionaryItemPayloadType.Phoneme,
                _ => null,
            };
        }
    }
}