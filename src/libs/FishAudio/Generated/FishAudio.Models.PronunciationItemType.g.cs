
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// How `value` replaces `key`. `phoneme` (default) speaks the value as a phonetic form. `alias` substitutes the literal text, which then goes through the same text normalization as the rest of the request. Omitted or `null` means `phoneme`, so existing dictionaries and clients keep their behaviour. Any other value is rejected. Usage is billed on the text actually synthesized, with alias replacements counted: an alias that expands a key is billed for the longer text, one that shortens it is billed for the shorter text; phoneme rules never change billing.<br/>
    /// Default Value: phoneme
    /// </summary>
    public enum PronunciationItemType
    {
        /// <summary>
        /// an alias that expands a key is billed for the longer text, one that shortens it is billed for the shorter text; phoneme rules never change billing.
        /// </summary>
        Alias,
        /// <summary>
        /// an alias that expands a key is billed for the longer text, one that shortens it is billed for the shorter text; phoneme rules never change billing.
        /// </summary>
        Phoneme,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationItemType value)
        {
            return value switch
            {
                PronunciationItemType.Alias => "alias",
                PronunciationItemType.Phoneme => "phoneme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationItemType? ToEnum(string value)
        {
            return value switch
            {
                "alias" => PronunciationItemType.Alias,
                "phoneme" => PronunciationItemType.Phoneme,
                _ => null,
            };
        }
    }
}