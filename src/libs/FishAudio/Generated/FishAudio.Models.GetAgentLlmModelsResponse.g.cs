
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAgentLlmModelsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.PublicLLMModel> LlmModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentLlmModelsResponse" /> class.
        /// </summary>
        /// <param name="llmModels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentLlmModelsResponse(
            global::System.Collections.Generic.IList<global::FishAudio.PublicLLMModel> llmModels)
        {
            this.LlmModels = llmModels ?? throw new global::System.ArgumentNullException(nameof(llmModels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentLlmModelsResponse" /> class.
        /// </summary>
        public GetAgentLlmModelsResponse()
        {
        }

    }
}