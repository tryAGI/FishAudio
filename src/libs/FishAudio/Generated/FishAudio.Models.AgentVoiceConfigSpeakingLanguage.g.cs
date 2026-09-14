
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: en
    /// </summary>
    public enum AgentVoiceConfigSpeakingLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Af,
        /// <summary>
        ///
        /// </summary>
        Ar,
        /// <summary>
        ///
        /// </summary>
        Bg,
        /// <summary>
        ///
        /// </summary>
        Bn,
        /// <summary>
        ///
        /// </summary>
        Ca,
        /// <summary>
        ///
        /// </summary>
        Cs,
        /// <summary>
        ///
        /// </summary>
        Da,
        /// <summary>
        ///
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        El,
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
        Et,
        /// <summary>
        ///
        /// </summary>
        Fa,
        /// <summary>
        ///
        /// </summary>
        Fi,
        /// <summary>
        ///
        /// </summary>
        Fr,
        /// <summary>
        ///
        /// </summary>
        Gu,
        /// <summary>
        ///
        /// </summary>
        He,
        /// <summary>
        ///
        /// </summary>
        Hi,
        /// <summary>
        ///
        /// </summary>
        Hr,
        /// <summary>
        ///
        /// </summary>
        Hu,
        /// <summary>
        ///
        /// </summary>
        Hy,
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        It,
        /// <summary>
        ///
        /// </summary>
        Ja,
        /// <summary>
        ///
        /// </summary>
        Ka,
        /// <summary>
        ///
        /// </summary>
        Kk,
        /// <summary>
        ///
        /// </summary>
        Kn,
        /// <summary>
        ///
        /// </summary>
        Ko,
        /// <summary>
        ///
        /// </summary>
        Lt,
        /// <summary>
        ///
        /// </summary>
        Lv,
        /// <summary>
        ///
        /// </summary>
        Mr,
        /// <summary>
        ///
        /// </summary>
        Ms,
        /// <summary>
        ///
        /// </summary>
        Ne,
        /// <summary>
        ///
        /// </summary>
        Nl,
        /// <summary>
        ///
        /// </summary>
        No,
        /// <summary>
        ///
        /// </summary>
        Pa,
        /// <summary>
        ///
        /// </summary>
        Pl,
        /// <summary>
        ///
        /// </summary>
        Pt,
        /// <summary>
        ///
        /// </summary>
        Ro,
        /// <summary>
        ///
        /// </summary>
        Ru,
        /// <summary>
        ///
        /// </summary>
        Sk,
        /// <summary>
        ///
        /// </summary>
        Sr,
        /// <summary>
        ///
        /// </summary>
        Sv,
        /// <summary>
        ///
        /// </summary>
        Ta,
        /// <summary>
        ///
        /// </summary>
        Te,
        /// <summary>
        ///
        /// </summary>
        Th,
        /// <summary>
        ///
        /// </summary>
        Tl,
        /// <summary>
        ///
        /// </summary>
        Tr,
        /// <summary>
        ///
        /// </summary>
        Uk,
        /// <summary>
        ///
        /// </summary>
        Ur,
        /// <summary>
        ///
        /// </summary>
        Vi,
        /// <summary>
        ///
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentVoiceConfigSpeakingLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentVoiceConfigSpeakingLanguage value)
        {
            return value switch
            {
                AgentVoiceConfigSpeakingLanguage.Af => "af",
                AgentVoiceConfigSpeakingLanguage.Ar => "ar",
                AgentVoiceConfigSpeakingLanguage.Bg => "bg",
                AgentVoiceConfigSpeakingLanguage.Bn => "bn",
                AgentVoiceConfigSpeakingLanguage.Ca => "ca",
                AgentVoiceConfigSpeakingLanguage.Cs => "cs",
                AgentVoiceConfigSpeakingLanguage.Da => "da",
                AgentVoiceConfigSpeakingLanguage.De => "de",
                AgentVoiceConfigSpeakingLanguage.El => "el",
                AgentVoiceConfigSpeakingLanguage.En => "en",
                AgentVoiceConfigSpeakingLanguage.Es => "es",
                AgentVoiceConfigSpeakingLanguage.Et => "et",
                AgentVoiceConfigSpeakingLanguage.Fa => "fa",
                AgentVoiceConfigSpeakingLanguage.Fi => "fi",
                AgentVoiceConfigSpeakingLanguage.Fr => "fr",
                AgentVoiceConfigSpeakingLanguage.Gu => "gu",
                AgentVoiceConfigSpeakingLanguage.He => "he",
                AgentVoiceConfigSpeakingLanguage.Hi => "hi",
                AgentVoiceConfigSpeakingLanguage.Hr => "hr",
                AgentVoiceConfigSpeakingLanguage.Hu => "hu",
                AgentVoiceConfigSpeakingLanguage.Hy => "hy",
                AgentVoiceConfigSpeakingLanguage.Id => "id",
                AgentVoiceConfigSpeakingLanguage.It => "it",
                AgentVoiceConfigSpeakingLanguage.Ja => "ja",
                AgentVoiceConfigSpeakingLanguage.Ka => "ka",
                AgentVoiceConfigSpeakingLanguage.Kk => "kk",
                AgentVoiceConfigSpeakingLanguage.Kn => "kn",
                AgentVoiceConfigSpeakingLanguage.Ko => "ko",
                AgentVoiceConfigSpeakingLanguage.Lt => "lt",
                AgentVoiceConfigSpeakingLanguage.Lv => "lv",
                AgentVoiceConfigSpeakingLanguage.Mr => "mr",
                AgentVoiceConfigSpeakingLanguage.Ms => "ms",
                AgentVoiceConfigSpeakingLanguage.Ne => "ne",
                AgentVoiceConfigSpeakingLanguage.Nl => "nl",
                AgentVoiceConfigSpeakingLanguage.No => "no",
                AgentVoiceConfigSpeakingLanguage.Pa => "pa",
                AgentVoiceConfigSpeakingLanguage.Pl => "pl",
                AgentVoiceConfigSpeakingLanguage.Pt => "pt",
                AgentVoiceConfigSpeakingLanguage.Ro => "ro",
                AgentVoiceConfigSpeakingLanguage.Ru => "ru",
                AgentVoiceConfigSpeakingLanguage.Sk => "sk",
                AgentVoiceConfigSpeakingLanguage.Sr => "sr",
                AgentVoiceConfigSpeakingLanguage.Sv => "sv",
                AgentVoiceConfigSpeakingLanguage.Ta => "ta",
                AgentVoiceConfigSpeakingLanguage.Te => "te",
                AgentVoiceConfigSpeakingLanguage.Th => "th",
                AgentVoiceConfigSpeakingLanguage.Tl => "tl",
                AgentVoiceConfigSpeakingLanguage.Tr => "tr",
                AgentVoiceConfigSpeakingLanguage.Uk => "uk",
                AgentVoiceConfigSpeakingLanguage.Ur => "ur",
                AgentVoiceConfigSpeakingLanguage.Vi => "vi",
                AgentVoiceConfigSpeakingLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentVoiceConfigSpeakingLanguage? ToEnum(string value)
        {
            return value switch
            {
                "af" => AgentVoiceConfigSpeakingLanguage.Af,
                "ar" => AgentVoiceConfigSpeakingLanguage.Ar,
                "bg" => AgentVoiceConfigSpeakingLanguage.Bg,
                "bn" => AgentVoiceConfigSpeakingLanguage.Bn,
                "ca" => AgentVoiceConfigSpeakingLanguage.Ca,
                "cs" => AgentVoiceConfigSpeakingLanguage.Cs,
                "da" => AgentVoiceConfigSpeakingLanguage.Da,
                "de" => AgentVoiceConfigSpeakingLanguage.De,
                "el" => AgentVoiceConfigSpeakingLanguage.El,
                "en" => AgentVoiceConfigSpeakingLanguage.En,
                "es" => AgentVoiceConfigSpeakingLanguage.Es,
                "et" => AgentVoiceConfigSpeakingLanguage.Et,
                "fa" => AgentVoiceConfigSpeakingLanguage.Fa,
                "fi" => AgentVoiceConfigSpeakingLanguage.Fi,
                "fr" => AgentVoiceConfigSpeakingLanguage.Fr,
                "gu" => AgentVoiceConfigSpeakingLanguage.Gu,
                "he" => AgentVoiceConfigSpeakingLanguage.He,
                "hi" => AgentVoiceConfigSpeakingLanguage.Hi,
                "hr" => AgentVoiceConfigSpeakingLanguage.Hr,
                "hu" => AgentVoiceConfigSpeakingLanguage.Hu,
                "hy" => AgentVoiceConfigSpeakingLanguage.Hy,
                "id" => AgentVoiceConfigSpeakingLanguage.Id,
                "it" => AgentVoiceConfigSpeakingLanguage.It,
                "ja" => AgentVoiceConfigSpeakingLanguage.Ja,
                "ka" => AgentVoiceConfigSpeakingLanguage.Ka,
                "kk" => AgentVoiceConfigSpeakingLanguage.Kk,
                "kn" => AgentVoiceConfigSpeakingLanguage.Kn,
                "ko" => AgentVoiceConfigSpeakingLanguage.Ko,
                "lt" => AgentVoiceConfigSpeakingLanguage.Lt,
                "lv" => AgentVoiceConfigSpeakingLanguage.Lv,
                "mr" => AgentVoiceConfigSpeakingLanguage.Mr,
                "ms" => AgentVoiceConfigSpeakingLanguage.Ms,
                "ne" => AgentVoiceConfigSpeakingLanguage.Ne,
                "nl" => AgentVoiceConfigSpeakingLanguage.Nl,
                "no" => AgentVoiceConfigSpeakingLanguage.No,
                "pa" => AgentVoiceConfigSpeakingLanguage.Pa,
                "pl" => AgentVoiceConfigSpeakingLanguage.Pl,
                "pt" => AgentVoiceConfigSpeakingLanguage.Pt,
                "ro" => AgentVoiceConfigSpeakingLanguage.Ro,
                "ru" => AgentVoiceConfigSpeakingLanguage.Ru,
                "sk" => AgentVoiceConfigSpeakingLanguage.Sk,
                "sr" => AgentVoiceConfigSpeakingLanguage.Sr,
                "sv" => AgentVoiceConfigSpeakingLanguage.Sv,
                "ta" => AgentVoiceConfigSpeakingLanguage.Ta,
                "te" => AgentVoiceConfigSpeakingLanguage.Te,
                "th" => AgentVoiceConfigSpeakingLanguage.Th,
                "tl" => AgentVoiceConfigSpeakingLanguage.Tl,
                "tr" => AgentVoiceConfigSpeakingLanguage.Tr,
                "uk" => AgentVoiceConfigSpeakingLanguage.Uk,
                "ur" => AgentVoiceConfigSpeakingLanguage.Ur,
                "vi" => AgentVoiceConfigSpeakingLanguage.Vi,
                "zh" => AgentVoiceConfigSpeakingLanguage.Zh,
                _ => null,
            };
        }
    }
}