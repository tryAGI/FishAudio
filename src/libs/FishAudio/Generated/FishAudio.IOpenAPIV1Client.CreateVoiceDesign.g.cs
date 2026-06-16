#nullable enable

namespace FishAudio
{
    public partial interface IOpenAPIV1Client
    {
        /// <summary>
        /// Voice Design
        /// </summary>
        /// <param name="model">
        /// Default Value: voice-design-1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/voice-design \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'model: voice-design-1' \<br/>
        ///   --data '{<br/>
        ///     "instruction": "Warm, confident studio narrator with a natural tone",<br/>
        ///     "reference_text": "Welcome to Fish Audio.",<br/>
        ///     "language": "en",<br/>
        ///     "n": 2,<br/>
        ///     "speed": 1,<br/>
        ///     "num_step": 32,<br/>
        ///     "guidance_scale": 2,<br/>
        ///     "instruct_guidance_scale": 0,<br/>
        ///     "seed": 42<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateVoiceDesignResponse> CreateVoiceDesignAsync(

            global::FishAudio.VoiceDesignRequest request,
            string model = "voice-design-1",
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Voice Design
        /// </summary>
        /// <param name="model">
        /// Default Value: voice-design-1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/voice-design \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'model: voice-design-1' \<br/>
        ///   --data '{<br/>
        ///     "instruction": "Warm, confident studio narrator with a natural tone",<br/>
        ///     "reference_text": "Welcome to Fish Audio.",<br/>
        ///     "language": "en",<br/>
        ///     "n": 2,<br/>
        ///     "speed": 1,<br/>
        ///     "num_step": 32,<br/>
        ///     "guidance_scale": 2,<br/>
        ///     "instruct_guidance_scale": 0,<br/>
        ///     "seed": 42<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateVoiceDesignResponse>> CreateVoiceDesignAsResponseAsync(

            global::FishAudio.VoiceDesignRequest request,
            string model = "voice-design-1",
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Voice Design
        /// </summary>
        /// <param name="model">
        /// Default Value: voice-design-1
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateVoiceDesignResponse> CreateVoiceDesignAsync(
            string instruction,
            string model = "voice-design-1",
            string? referenceText = default,
            string? language = default,
            int? n = default,
            double? speed = default,
            int? numStep = default,
            double? guidanceScale = default,
            double? instructGuidanceScale = default,
            int? seed = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}