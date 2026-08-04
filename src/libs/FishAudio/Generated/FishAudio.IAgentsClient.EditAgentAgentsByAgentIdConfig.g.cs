#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update Draft Config<br/>
        /// Patch the draft configuration section by section; omitted sections keep<br/>
        /// their value. Changes only affect live sessions after the next publish.<br/>
        /// `prompt.system_prompt` is limited to 4000 characters (422 beyond).<br/>
        /// `voice.voice_profile_id` accepts any public voice model id.<br/>
        /// `voice.speaking_language` accepts `en`, `ja`, `zh`, `ko`, `es`, `fr`, `de`;<br/>
        /// anything else is 422. `tool_ids` and<br/>
        /// `knowledge_source_ids` replace their attachment lists wholesale and every<br/>
        /// id must resolve, else 422.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents/&lt;agent-id&gt;/config \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "prompt": {<br/>
        ///       "system_prompt": "You are the receptionist for Fish Dental."<br/>
        ///     },<br/>
        ///     "webhooks": {<br/>
        ///       "post_call": {<br/>
        ///         "url": "https://example.com/hooks/fish",<br/>
        ///         "secret": "&lt;signing-secret&gt;"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentAgentsConfigResponse> EditAgentAgentsByAgentIdConfigAsync(
            string agentId,

            global::FishAudio.PublicAgentConfigPatchPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Draft Config<br/>
        /// Patch the draft configuration section by section; omitted sections keep<br/>
        /// their value. Changes only affect live sessions after the next publish.<br/>
        /// `prompt.system_prompt` is limited to 4000 characters (422 beyond).<br/>
        /// `voice.voice_profile_id` accepts any public voice model id.<br/>
        /// `voice.speaking_language` accepts `en`, `ja`, `zh`, `ko`, `es`, `fr`, `de`;<br/>
        /// anything else is 422. `tool_ids` and<br/>
        /// `knowledge_source_ids` replace their attachment lists wholesale and every<br/>
        /// id must resolve, else 422.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents/&lt;agent-id&gt;/config \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "prompt": {<br/>
        ///       "system_prompt": "You are the receptionist for Fish Dental."<br/>
        ///     },<br/>
        ///     "webhooks": {<br/>
        ///       "post_call": {<br/>
        ///         "url": "https://example.com/hooks/fish",<br/>
        ///         "secret": "&lt;signing-secret&gt;"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchAgentAgentsConfigResponse>> EditAgentAgentsByAgentIdConfigAsResponseAsync(
            string agentId,

            global::FishAudio.PublicAgentConfigPatchPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Draft Config<br/>
        /// Patch the draft configuration section by section; omitted sections keep<br/>
        /// their value. Changes only affect live sessions after the next publish.<br/>
        /// `prompt.system_prompt` is limited to 4000 characters (422 beyond).<br/>
        /// `voice.voice_profile_id` accepts any public voice model id.<br/>
        /// `voice.speaking_language` accepts `en`, `ja`, `zh`, `ko`, `es`, `fr`, `de`;<br/>
        /// anything else is 422. `tool_ids` and<br/>
        /// `knowledge_source_ids` replace their attachment lists wholesale and every<br/>
        /// id must resolve, else 422.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="prompt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="voice">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="conversation">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tools">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="webhooks">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="knowledgeBase">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="analysis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentAgentsConfigResponse> EditAgentAgentsByAgentIdConfigAsync(
            string agentId,
            global::FishAudio.PublicAgentPromptPatch? prompt = default,
            global::FishAudio.PublicAgentVoicePatch? voice = default,
            global::FishAudio.PublicAgentConversationPatch? conversation = default,
            global::FishAudio.PublicAgentToolsPatch? tools = default,
            global::FishAudio.PublicAgentWebhooksPatch? webhooks = default,
            global::FishAudio.PublicAgentKnowledgeBasePatch? knowledgeBase = default,
            global::FishAudio.PublicAgentAnalysisPatch? analysis = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}