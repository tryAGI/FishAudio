
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Change relative to the base version: `added` only in target, `removed` only in base, `changed` with different content, `moved` with identical content but a different position, `unchanged`.
    /// </summary>
    public enum PronunciationDictionaryV1CompareRowStatus
    {
        /// <summary>
        /// `added` only in target, `removed` only in base, `changed` with different content, `moved` with identical content but a different position, `unchanged`.
        /// </summary>
        Added,
        /// <summary>
        /// `added` only in target, `removed` only in base, `changed` with different content, `moved` with identical content but a different position, `unchanged`.
        /// </summary>
        Changed,
        /// <summary>
        /// `added` only in target, `removed` only in base, `changed` with different content, `moved` with identical content but a different position, `unchanged`.
        /// </summary>
        Moved,
        /// <summary>
        /// `added` only in target, `removed` only in base, `changed` with different content, `moved` with identical content but a different position, `unchanged`.
        /// </summary>
        Removed,
        /// <summary>
        /// `added` only in target, `removed` only in base, `changed` with different content, `moved` with identical content but a different position, `unchanged`.
        /// </summary>
        Unchanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictionaryV1CompareRowStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryV1CompareRowStatus value)
        {
            return value switch
            {
                PronunciationDictionaryV1CompareRowStatus.Added => "added",
                PronunciationDictionaryV1CompareRowStatus.Changed => "changed",
                PronunciationDictionaryV1CompareRowStatus.Moved => "moved",
                PronunciationDictionaryV1CompareRowStatus.Removed => "removed",
                PronunciationDictionaryV1CompareRowStatus.Unchanged => "unchanged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryV1CompareRowStatus? ToEnum(string value)
        {
            return value switch
            {
                "added" => PronunciationDictionaryV1CompareRowStatus.Added,
                "changed" => PronunciationDictionaryV1CompareRowStatus.Changed,
                "moved" => PronunciationDictionaryV1CompareRowStatus.Moved,
                "removed" => PronunciationDictionaryV1CompareRowStatus.Removed,
                "unchanged" => PronunciationDictionaryV1CompareRowStatus.Unchanged,
                _ => null,
            };
        }
    }
}