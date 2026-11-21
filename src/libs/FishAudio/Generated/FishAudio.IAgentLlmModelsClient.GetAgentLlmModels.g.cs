#nullable enable

namespace FishAudio
{
    public partial interface IAgentLlmModelsClient
    {
        /// <summary>
        /// List LLM Models<br/>
        /// List the LLMs your team can set as `llm.model` on an agent's config, each<br/>
        /// with its token rates. The rates are set by the LLM providers and change<br/>
        /// when a provider changes its pricing. The response carries the rates in<br/>
        /// force now.
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
        /// with its token rates. The rates are set by the LLM providers and change<br/>
        /// when a provider changes its pricing. The response carries the rates in<br/>
        /// force now.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentLlmModelsResponse>> GetAgentLlmModelsAsResponseAsync(
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}