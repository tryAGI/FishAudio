
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Replacement type in the target version.<br/>
    /// Default Value: phoneme
    /// </summary>
    public enum PronunciationDictionaryV1CompareRowType
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
    public static class PronunciationDictionaryV1CompareRowTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryV1CompareRowType value)
        {
            return value switch
            {
                PronunciationDictionaryV1CompareRowType.Alias => "alias",
                PronunciationDictionaryV1CompareRowType.Phoneme => "phoneme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryV1CompareRowType? ToEnum(string value)
        {
            return value switch
            {
                "alias" => PronunciationDictionaryV1CompareRowType.Alias,
                "phoneme" => PronunciationDictionaryV1CompareRowType.Phoneme,
                _ => null,
            };
        }
    }
}