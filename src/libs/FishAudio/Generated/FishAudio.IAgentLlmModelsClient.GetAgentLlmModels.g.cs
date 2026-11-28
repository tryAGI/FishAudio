#nullable enable

namespace FishAudio
{
    public partial interface IAgentLlmModelsClient
    {
        /// <summary>
        /// List LLM Models<br/>
        /// List the LLMs your team can set as `llm.model` on an agent's config, each<br/>
        /// with its token rates and a reference latency. The rates are set by the LLM<br/>
        /// providers and change when a provider changes its pricing. The response<br/>
        /// carries the rates in force now.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentLlmModelsResponse> GetAgentLlmModelsAsync(
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List LLM Models<br/>
        /// List the LLMs your team can set as `llm.model` on an agent's config, each<br/>
        /// with its token rates and a reference latency. The rates are set by the LLM<br/>
        /// providers and change when a provider changes its pricing. The response<br/>
        /// carries the rates in force now.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentLlmModelsResponse>> GetAgentLlmModelsAsResponseAsync(
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}