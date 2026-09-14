
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionOverridesPayloadLanguage
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
    public static class AgentSessionOverridesPayloadLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionOverridesPayloadLanguage value)
        {
            return value switch
            {
                AgentSessionOverridesPayloadLanguage.Af => "af",
                AgentSessionOverridesPayloadLanguage.Ar => "ar",
                AgentSessionOverridesPayloadLanguage.Bg => "bg",
                AgentSessionOverridesPayloadLanguage.Bn => "bn",
                AgentSessionOverridesPayloadLanguage.Ca => "ca",
                AgentSessionOverridesPayloadLanguage.Cs => "cs",
                AgentSessionOverridesPayloadLanguage.Da => "da",
                AgentSessionOverridesPayloadLanguage.De => "de",
                AgentSessionOverridesPayloadLanguage.El => "el",
                AgentSessionOverridesPayloadLanguage.En => "en",
                AgentSessionOverridesPayloadLanguage.Es => "es",
                AgentSessionOverridesPayloadLanguage.Et => "et",
                AgentSessionOverridesPayloadLanguage.Fa => "fa",
                AgentSessionOverridesPayloadLanguage.Fi => "fi",
                AgentSessionOverridesPayloadLanguage.Fr => "fr",
                AgentSessionOverridesPayloadLanguage.Gu => "gu",
                AgentSessionOverridesPayloadLanguage.He => "he",
                AgentSessionOverridesPayloadLanguage.Hi => "hi",
                AgentSessionOverridesPayloadLanguage.Hr => "hr",
                AgentSessionOverridesPayloadLanguage.Hu => "hu",
                AgentSessionOverridesPayloadLanguage.Hy => "hy",
                AgentSessionOverridesPayloadLanguage.Id => "id",
                AgentSessionOverridesPayloadLanguage.It => "it",
                AgentSessionOverridesPayloadLanguage.Ja => "ja",
                AgentSessionOverridesPayloadLanguage.Ka => "ka",
                AgentSessionOverridesPayloadLanguage.Kk => "kk",
                AgentSessionOverridesPayloadLanguage.Kn => "kn",
                AgentSessionOverridesPayloadLanguage.Ko => "ko",
                AgentSessionOverridesPayloadLanguage.Lt => "lt",
                AgentSessionOverridesPayloadLanguage.Lv => "lv",
                AgentSessionOverridesPayloadLanguage.Mr => "mr",
                AgentSessionOverridesPayloadLanguage.Ms => "ms",
                AgentSessionOverridesPayloadLanguage.Ne => "ne",
                AgentSessionOverridesPayloadLanguage.Nl => "nl",
                AgentSessionOverridesPayloadLanguage.No => "no",
                AgentSessionOverridesPayloadLanguage.Pa => "pa",
                AgentSessionOverridesPayloadLanguage.Pl => "pl",
                AgentSessionOverridesPayloadLanguage.Pt => "pt",
                AgentSessionOverridesPayloadLanguage.Ro => "ro",
                AgentSessionOverridesPayloadLanguage.Ru => "ru",
                AgentSessionOverridesPayloadLanguage.Sk => "sk",
                AgentSessionOverridesPayloadLanguage.Sr => "sr",
                AgentSessionOverridesPayloadLanguage.Sv => "sv",
                AgentSessionOverridesPayloadLanguage.Ta => "ta",
                AgentSessionOverridesPayloadLanguage.Te => "te",
                AgentSessionOverridesPayloadLanguage.Th => "th",
                AgentSessionOverridesPayloadLanguage.Tl => "tl",
                AgentSessionOverridesPayloadLanguage.Tr => "tr",
                AgentSessionOverridesPayloadLanguage.Uk => "uk",
                AgentSessionOverridesPayloadLanguage.Ur => "ur",
                AgentSessionOverridesPayloadLanguage.Vi => "vi",
                AgentSessionOverridesPayloadLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionOverridesPayloadLanguage? ToEnum(string value)
        {
            return value switch
            {
                "af" => AgentSessionOverridesPayloadLanguage.Af,
                "ar" => AgentSessionOverridesPayloadLanguage.Ar,
                "bg" => AgentSessionOverridesPayloadLanguage.Bg,
                "bn" => AgentSessionOverridesPayloadLanguage.Bn,
                "ca" => AgentSessionOverridesPayloadLanguage.Ca,
                "cs" => AgentSessionOverridesPayloadLanguage.Cs,
                "da" => AgentSessionOverridesPayloadLanguage.Da,
                "de" => AgentSessionOverridesPayloadLanguage.De,
                "el" => AgentSessionOverridesPayloadLanguage.El,
                "en" => AgentSessionOverridesPayloadLanguage.En,
                "es" => AgentSessionOverridesPayloadLanguage.Es,
                "et" => AgentSessionOverridesPayloadLanguage.Et,
                "fa" => AgentSessionOverridesPayloadLanguage.Fa,
                "fi" => AgentSessionOverridesPayloadLanguage.Fi,
                "fr" => AgentSessionOverridesPayloadLanguage.Fr,
                "gu" => AgentSessionOverridesPayloadLanguage.Gu,
                "he" => AgentSessionOverridesPayloadLanguage.He,
                "hi" => AgentSessionOverridesPayloadLanguage.Hi,
                "hr" => AgentSessionOverridesPayloadLanguage.Hr,
                "hu" => AgentSessionOverridesPayloadLanguage.Hu,
                "hy" => AgentSessionOverridesPayloadLanguage.Hy,
                "id" => AgentSessionOverridesPayloadLanguage.Id,
                "it" => AgentSessionOverridesPayloadLanguage.It,
                "ja" => AgentSessionOverridesPayloadLanguage.Ja,
                "ka" => AgentSessionOverridesPayloadLanguage.Ka,
                "kk" => AgentSessionOverridesPayloadLanguage.Kk,
                "kn" => AgentSessionOverridesPayloadLanguage.Kn,
                "ko" => AgentSessionOverridesPayloadLanguage.Ko,
                "lt" => AgentSessionOverridesPayloadLanguage.Lt,
                "lv" => AgentSessionOverridesPayloadLanguage.Lv,
                "mr" => AgentSessionOverridesPayloadLanguage.Mr,
                "ms" => AgentSessionOverridesPayloadLanguage.Ms,
                "ne" => AgentSessionOverridesPayloadLanguage.Ne,
                "nl" => AgentSessionOverridesPayloadLanguage.Nl,
                "no" => AgentSessionOverridesPayloadLanguage.No,
                "pa" => AgentSessionOverridesPayloadLanguage.Pa,
                "pl" => AgentSessionOverridesPayloadLanguage.Pl,
                "pt" => AgentSessionOverridesPayloadLanguage.Pt,
                "ro" => AgentSessionOverridesPayloadLanguage.Ro,
                "ru" => AgentSessionOverridesPayloadLanguage.Ru,
                "sk" => AgentSessionOverridesPayloadLanguage.Sk,
                "sr" => AgentSessionOverridesPayloadLanguage.Sr,
                "sv" => AgentSessionOverridesPayloadLanguage.Sv,
                "ta" => AgentSessionOverridesPayloadLanguage.Ta,
                "te" => AgentSessionOverridesPayloadLanguage.Te,
                "th" => AgentSessionOverridesPayloadLanguage.Th,
                "tl" => AgentSessionOverridesPayloadLanguage.Tl,
                "tr" => AgentSessionOverridesPayloadLanguage.Tr,
                "uk" => AgentSessionOverridesPayloadLanguage.Uk,
                "ur" => AgentSessionOverridesPayloadLanguage.Ur,
                "vi" => AgentSessionOverridesPayloadLanguage.Vi,
                "zh" => AgentSessionOverridesPayloadLanguage.Zh,
                _ => null,
            };
        }
    }
}