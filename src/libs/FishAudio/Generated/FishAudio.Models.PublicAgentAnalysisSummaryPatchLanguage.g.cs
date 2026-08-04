
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: en
    /// </summary>
    public enum PublicAgentAnalysisSummaryPatchLanguage
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
    public static class PublicAgentAnalysisSummaryPatchLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentAnalysisSummaryPatchLanguage value)
        {
            return value switch
            {
                PublicAgentAnalysisSummaryPatchLanguage.Ar => "ar",
                PublicAgentAnalysisSummaryPatchLanguage.De => "de",
                PublicAgentAnalysisSummaryPatchLanguage.En => "en",
                PublicAgentAnalysisSummaryPatchLanguage.Es => "es",
                PublicAgentAnalysisSummaryPatchLanguage.Fr => "fr",
                PublicAgentAnalysisSummaryPatchLanguage.Ja => "ja",
                PublicAgentAnalysisSummaryPatchLanguage.Ko => "ko",
                PublicAgentAnalysisSummaryPatchLanguage.Pt => "pt",
                PublicAgentAnalysisSummaryPatchLanguage.Ru => "ru",
                PublicAgentAnalysisSummaryPatchLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentAnalysisSummaryPatchLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => PublicAgentAnalysisSummaryPatchLanguage.Ar,
                "de" => PublicAgentAnalysisSummaryPatchLanguage.De,
                "en" => PublicAgentAnalysisSummaryPatchLanguage.En,
                "es" => PublicAgentAnalysisSummaryPatchLanguage.Es,
                "fr" => PublicAgentAnalysisSummaryPatchLanguage.Fr,
                "ja" => PublicAgentAnalysisSummaryPatchLanguage.Ja,
                "ko" => PublicAgentAnalysisSummaryPatchLanguage.Ko,
                "pt" => PublicAgentAnalysisSummaryPatchLanguage.Pt,
                "ru" => PublicAgentAnalysisSummaryPatchLanguage.Ru,
                "zh" => PublicAgentAnalysisSummaryPatchLanguage.Zh,
                _ => null,
            };
        }
    }
}