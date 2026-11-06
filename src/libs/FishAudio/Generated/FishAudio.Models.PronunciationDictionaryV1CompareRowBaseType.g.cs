
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PronunciationDictionaryV1CompareRowBaseType
    {
        /// <summary>
        ///
        /// </summary>
        Alias,
        /// <summary>
        ///
        /// </summary>
        Phoneme,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictionaryV1CompareRowBaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryV1CompareRowBaseType value)
        {
            return value switch
            {
                PronunciationDictionaryV1CompareRowBaseType.Alias => "alias",
                PronunciationDictionaryV1CompareRowBaseType.Phoneme => "phoneme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryV1CompareRowBaseType? ToEnum(string value)
        {
            return value switch
            {
                "alias" => PronunciationDictionaryV1CompareRowBaseType.Alias,
                "phoneme" => PronunciationDictionaryV1CompareRowBaseType.Phoneme,
                _ => null,
            };
        }
    }
}