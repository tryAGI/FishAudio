
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: en
    /// </summary>
    public enum AgentAnalysisSummaryConfigLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Ar,
        /// <summary>
        ///
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        En,
        /// <summary>
        ///
        /// </summary>
        Es,
        /// <summary>
        ///
        /// </summary>
        Fr,
        /// <summary>
        ///
        /// </summary>
        Ja,
        /// <summary>
        ///
        /// </summary>
        Ko,
        /// <summary>
        ///
        /// </summary>
        Pt,
        /// <summary>
        ///
        /// </summary>
        Ru,
        /// <summary>
        ///
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentAnalysisSummaryConfigLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAnalysisSummaryConfigLanguage value)
        {
            return value switch
            {
                AgentAnalysisSummaryConfigLanguage.Ar => "ar",
                AgentAnalysisSummaryConfigLanguage.De => "de",
                AgentAnalysisSummaryConfigLanguage.En => "en",
                AgentAnalysisSummaryConfigLanguage.Es => "es",
                AgentAnalysisSummaryConfigLanguage.Fr => "fr",
                AgentAnalysisSummaryConfigLanguage.Ja => "ja",
                AgentAnalysisSummaryConfigLanguage.Ko => "ko",
                AgentAnalysisSummaryConfigLanguage.Pt => "pt",
                AgentAnalysisSummaryConfigLanguage.Ru => "ru",
                AgentAnalysisSummaryConfigLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAnalysisSummaryConfigLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => AgentAnalysisSummaryConfigLanguage.Ar,
                "de" => AgentAnalysisSummaryConfigLanguage.De,
                "en" => AgentAnalysisSummaryConfigLanguage.En,
                "es" => AgentAnalysisSummaryConfigLanguage.Es,
                "fr" => AgentAnalysisSummaryConfigLanguage.Fr,
                "ja" => AgentAnalysisSummaryConfigLanguage.Ja,
                "ko" => AgentAnalysisSummaryConfigLanguage.Ko,
                "pt" => AgentAnalysisSummaryConfigLanguage.Pt,
                "ru" => AgentAnalysisSummaryConfigLanguage.Ru,
                "zh" => AgentAnalysisSummaryConfigLanguage.Zh,
                _ => null,
            };
        }
    }
}