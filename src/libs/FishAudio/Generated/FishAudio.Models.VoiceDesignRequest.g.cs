
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Request body for synchronous voice design generation. The endpoint returns generated voice candidates with base64-encoded audio.
    /// </summary>
    public sealed partial class VoiceDesignRequest
    {
        /// <summary>
        /// Voice design prompt. Must contain 1 to 2000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Optional text used as reference content for the generated voice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_text")]
        public string? ReferenceText { get; set; }

        /// <summary>
        /// Optional BCP-47 language hint, such as `en`, `zh`, or `ja`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Number of voice candidates to generate.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Speaking speed multiplier for candidate generation.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Number of diffusion steps used by the voice-design model.<br/>
        /// Default Value: 32
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_step")]
        public int? NumStep { get; set; }

        /// <summary>
        /// Classifier-free guidance scale. Higher values follow the prompt more strongly.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Instruction guidance scale for prompt conditioning.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruct_guidance_scale")]
        public double? InstructGuidanceScale { get; set; }

        /// <summary>
        /// Optional deterministic seed for candidate generation.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignRequest" /> class.
        /// </summary>
        /// <param name="instruction">
        /// Voice design prompt. Must contain 1 to 2000 characters.
        /// </param>
        /// <param name="referenceText">
        /// Optional text used as reference content for the generated voice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Optional BCP-47 language hint, such as `en`, `zh`, or `ja`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="n">
        /// Number of voice candidates to generate.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="speed">
        /// Speaking speed multiplier for candidate generation.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="numStep">
        /// Number of diffusion steps used by the voice-design model.<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="guidanceScale">
        /// Classifier-free guidance scale. Higher values follow the prompt more strongly.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="instructGuidanceScale">
        /// Instruction guidance scale for prompt conditioning.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="seed">
        /// Optional deterministic seed for candidate generation.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignRequest(
            string instruction,
            string? referenceText,
            string? language,
            int? n,
            double? speed,
            int? numStep,
            double? guidanceScale,
            double? instructGuidanceScale,
            int? seed)
        {
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.ReferenceText = referenceText;
            this.Language = language;
            this.N = n;
            this.Speed = speed;
            this.NumStep = numStep;
            this.GuidanceScale = guidanceScale;
            this.InstructGuidanceScale = instructGuidanceScale;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignRequest" /> class.
        /// </summary>
        public VoiceDesignRequest()
        {
        }

    }
}