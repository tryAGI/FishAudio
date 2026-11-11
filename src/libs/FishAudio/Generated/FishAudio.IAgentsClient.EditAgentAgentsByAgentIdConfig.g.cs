#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update Draft Config<br/>
        /// Patch the draft configuration section by section; omitted sections keep<br/>
        /// their value. Changes only affect live sessions after the next publish.<br/>
        /// `prompt.system_prompt` is limited to 32000 tokens (422 beyond); keeping it<br/>
        /// under 2000 tokens is recommended for latency and cost.<br/>
        /// `voice.voice_id` accepts any public voice model id.<br/>
        /// `voice.speaking_language` accepts any of the 52 supported ISO 639-1 codes<br/>
        /// (the same set the console offers, see the Voice &amp; language docs); anything else is 422. `voice.expressive` (default `true`) enables richer<br/>
        /// expressive delivery (emotion steering, laughter and sounds, pauses); off<br/>
        /// keeps the standard delivery. The `asr` section configures speech<br/>
        /// recognition. `asr.model` picks the model: `deepgram:nova-3` (default),<br/>
        /// `elevenlabs:scribe_v2_realtime`, `elevenlabs:scribe_v2_medical`, or<br/>
        /// `fish_audio:transcribe-stream-1` (Fish realtime recognition, which<br/>
        /// also decides end of turn and whether the caller is interrupting).<br/>
        /// Its former id `fish_audio:transcribe-1-pro-realtime` is still accepted<br/>
        /// and reads back as the current id.<br/>
        /// `asr.multilingual` (default `false`) lets recognition follow callers who<br/>
        /// switch language mid-call, off tells the recognizer to expect<br/>
        /// `voice.speaking_language` (models other than `deepgram:nova-3` may still<br/>
        /// transcribe clear speech in another language). `asr.strict_language`<br/>
        /// (default `false`) enforces `voice.speaking_language` whatever<br/>
        /// `asr.multilingual` says: speech recognized as another language reaches the<br/>
        /// agent as `[unintelligible speech]`. Language is detected per utterance, so<br/>
        /// a short or heavily accented phrase in the speaking language can<br/>
        /// occasionally be detected as another language and replaced too. Only<br/>
        /// enable it when you explicitly need to stop the agent from understanding<br/>
        /// other languages.<br/>
        /// `asr.keyterms` is a recognition<br/>
        /// vocabulary of up to 50 plain terms (brand names, product terms, personal<br/>
        /// names), each at most 100 characters with no commas or semicolons. `[]`<br/>
        /// clears it and 20-50 focused terms work best.<br/>
        /// `voice.background_sound` sets a looping ambience the worker mixes under<br/>
        /// the agent's voice: `preset` is `off` (default) or one of `office`,<br/>
        /// `call_center`, `restaurant`, `cafe`, `city_street`, `phone_line`, `phone_line_digital`,<br/>
        /// `custom`. `volume` (0-1, default 0.15) is the<br/>
        /// ambience's gain relative to the voice. `custom_asset_id` names a clip<br/>
        /// uploaded through `POST /v1/agent/background-sounds`; required with<br/>
        /// `preset: "custom"`, refused otherwise (422). Replaces the whole object;<br/>
        /// an explicit null resets it to off. `tool_ids` and<br/>
        /// `knowledge_source_ids` replace their attachment lists wholesale and every<br/>
        /// id must resolve, else 422. `llm.custom` points the agent at your own<br/>
        /// OpenAI-compatible endpoint; mutually exclusive with `llm.model`, cleared<br/>
        /// with an explicit null. `llm.fallback` sets what the agent tries after its<br/>
        /// model fails: `platform` (default), `manual` (`models` in order, 1 to 3)<br/>
        /// or `off`. In `manual`, each model and `primary` (the agent's own model)<br/>
        /// take optional `ttft_timeout_ms` (500-30000, default 5000 ms, i.e. 5<br/>
        /// seconds, when not set) and `total_timeout_ms` (1000-120000, at least<br/>
        /// `ttft_timeout_ms` when both are set, no limit when not set), and the<br/>
        /// first model can set<br/>
        /// `parallel.kick_in_ms` (300-10000, default 1500) to run alongside the<br/>
        /// agent's own model.<br/>
        /// The response is the draft as stored, which can differ from the request:<br/>
        /// - Every field comes back. Omitted fields keep their value or default.<br/>
        /// - `asr.keyterms` and `voice.pronunciation_dictionary_ids` are trimmed<br/>
        ///   and de-duplicated in order. `tool_ids` is de-duplicated in order.<br/>
        /// - A tool that was archived drops out of `tool_ids` at the next tools<br/>
        ///   write.<br/>
        /// - `conversation.interruption_ignore_phrases` collapses inner spaces and<br/>
        ///   drops case-insensitive duplicates.<br/>
        /// - `conversation.timezone`, transfer phone numbers and transfer text<br/>
        ///   fields are trimmed.<br/>
        /// - `conversation.eagerness` and `conversation.response_wait_ms` move<br/>
        ///   together. The wait wins when both are sent, and the tier is derived<br/>
        ///   from it.<br/>
        /// - `conversation.response_max_wait_ms: 0` reads back as `null`<br/>
        ///   (automatic).<br/>
        /// - `knowledge_base.enabled` becomes `true` when you attach sources and<br/>
        ///   omit it.<br/>
        /// - `llm.custom.base_url` drops a trailing `/` and `/chat/completions`.<br/>
        ///   `llm.custom.model` is trimmed. Setting `llm.custom` resets `llm.model`<br/>
        ///   to the platform default.<br/>
        /// - Secrets read back as `has_secret`, and `llm.custom.api_key` as `null`.<br/>
        /// - `voice.live3_voice` becomes `null` when you set `voice.voice_id`<br/>
        ///   without it: on `live3` the agent then speaks the voice you picked.<br/>
        ///   Switching `voice.engine` to `live3` sets an empty `voice.live3_voice`<br/>
        ///   to `Clara` only while `voice.voice_id` is still the default voice<br/>
        ///   and the patch sets neither.<br/>
        /// - `voice` also returns `keyterms`, `multilingual_asr` and `asr_model`<br/>
        ///   copied from `asr`. They are deprecated.<br/>
        /// - `config_hash` and `updated_at` are set by the server.<br/>
        /// Compare against this response, or against `config_hash`, rather than the<br/>
        /// request body. Publishing never rewrites these values.
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
        ///       "post_call": [<br/>
        ///         {<br/>
        ///           "url": "https://example.com/hooks/fish",<br/>
        ///           "secret": "&lt;signing-secret&gt;"<br/>
        ///         }<br/>
        ///       ]<br/>
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
        /// `prompt.system_prompt` is limited to 32000 tokens (422 beyond); keeping it<br/>
        /// under 2000 tokens is recommended for latency and cost.<br/>
        /// `voice.voice_id` accepts any public voice model id.<br/>
        /// `voice.speaking_language` accepts any of the 52 supported ISO 639-1 codes<br/>
        /// (the same set the console offers, see the Voice &amp; language docs); anything else is 422. `voice.expressive` (default `true`) enables richer<br/>
        /// expressive delivery (emotion steering, laughter and sounds, pauses); off<br/>
        /// keeps the standard delivery. The `asr` section configures speech<br/>
        /// recognition. `asr.model` picks the model: `deepgram:nova-3` (default),<br/>
        /// `elevenlabs:scribe_v2_realtime`, `elevenlabs:scribe_v2_medical`, or<br/>
        /// `fish_audio:transcribe-stream-1` (Fish realtime recognition, which<br/>
        /// also decides end of turn and whether the caller is interrupting).<br/>
        /// Its former id `fish_audio:transcribe-1-pro-realtime` is still accepted<br/>
        /// and reads back as the current id.<br/>
        /// `asr.multilingual` (default `false`) lets recognition follow callers who<br/>
        /// switch language mid-call, off tells the recognizer to expect<br/>
        /// `voice.speaking_language` (models other than `deepgram:nova-3` may still<br/>
        /// transcribe clear speech in another language). `asr.strict_language`<br/>
        /// (default `false`) enforces `voice.speaking_language` whatever<br/>
        /// `asr.multilingual` says: speech recognized as another language reaches the<br/>
        /// agent as `[unintelligible speech]`. Language is detected per utterance, so<br/>
        /// a short or heavily accented phrase in the speaking language can<br/>
        /// occasionally be detected as another language and replaced too. Only<br/>
        /// enable it when you explicitly need to stop the agent from understanding<br/>
        /// other languages.<br/>
        /// `asr.keyterms` is a recognition<br/>
        /// vocabulary of up to 50 plain terms (brand names, product terms, personal<br/>
        /// names), each at most 100 characters with no commas or semicolons. `[]`<br/>
        /// clears it and 20-50 focused terms work best.<br/>
        /// `voice.background_sound` sets a looping ambience the worker mixes under<br/>
        /// the agent's voice: `preset` is `off` (default) or one of `office`,<br/>
        /// `call_center`, `restaurant`, `cafe`, `city_street`, `phone_line`, `phone_line_digital`,<br/>
        /// `custom`. `volume` (0-1, default 0.15) is the<br/>
        /// ambience's gain relative to the voice. `custom_asset_id` names a clip<br/>
        /// uploaded through `POST /v1/agent/background-sounds`; required with<br/>
        /// `preset: "custom"`, refused otherwise (422). Replaces the whole object;<br/>
        /// an explicit null resets it to off. `tool_ids` and<br/>
        /// `knowledge_source_ids` replace their attachment lists wholesale and every<br/>
        /// id must resolve, else 422. `llm.custom` points the agent at your own<br/>
        /// OpenAI-compatible endpoint; mutually exclusive with `llm.model`, cleared<br/>
        /// with an explicit null. `llm.fallback` sets what the agent tries after its<br/>
        /// model fails: `platform` (default), `manual` (`models` in order, 1 to 3)<br/>
        /// or `off`. In `manual`, each model and `primary` (the agent's own model)<br/>
        /// take optional `ttft_timeout_ms` (500-30000, default 5000 ms, i.e. 5<br/>
        /// seconds, when not set) and `total_timeout_ms` (1000-120000, at least<br/>
        /// `ttft_timeout_ms` when both are set, no limit when not set), and the<br/>
        /// first model can set<br/>
        /// `parallel.kick_in_ms` (300-10000, default 1500) to run alongside the<br/>
        /// agent's own model.<br/>
        /// The response is the draft as stored, which can differ from the request:<br/>
        /// - Every field comes back. Omitted fields keep their value or default.<br/>
        /// - `asr.keyterms` and `voice.pronunciation_dictionary_ids` are trimmed<br/>
        ///   and de-duplicated in order. `tool_ids` is de-duplicated in order.<br/>
        /// - A tool that was archived drops out of `tool_ids` at the next tools<br/>
        ///   write.<br/>
        /// - `conversation.interruption_ignore_phrases` collapses inner spaces and<br/>
        ///   drops case-insensitive duplicates.<br/>
        /// - `conversation.timezone`, transfer phone numbers and transfer text<br/>
        ///   fields are trimmed.<br/>
        /// - `conversation.eagerness` and `conversation.response_wait_ms` move<br/>
        ///   together. The wait wins when both are sent, and the tier is derived<br/>
        ///   from it.<br/>
        /// - `conversation.response_max_wait_ms: 0` reads back as `null`<br/>
        ///   (automatic).<br/>
        /// - `knowledge_base.enabled` becomes `true` when you attach sources and<br/>
        ///   omit it.<br/>
        /// - `llm.custom.base_url` drops a trailing `/` and `/chat/completions`.<br/>
        ///   `llm.custom.model` is trimmed. Setting `llm.custom` resets `llm.model`<br/>
        ///   to the platform default.<br/>
        /// - Secrets read back as `has_secret`, and `llm.custom.api_key` as `null`.<br/>
        /// - `voice.live3_voice` becomes `null` when you set `voice.voice_id`<br/>
        ///   without it: on `live3` the agent then speaks the voice you picked.<br/>
        ///   Switching `voice.engine` to `live3` sets an empty `voice.live3_voice`<br/>
        ///   to `Clara` only while `voice.voice_id` is still the default voice<br/>
        ///   and the patch sets neither.<br/>
        /// - `voice` also returns `keyterms`, `multilingual_asr` and `asr_model`<br/>
        ///   copied from `asr`. They are deprecated.<br/>
        /// - `config_hash` and `updated_at` are set by the server.<br/>
        /// Compare against this response, or against `config_hash`, rather than the<br/>
        /// request body. Publishing never rewrites these values.
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
        ///       "post_call": [<br/>
        ///         {<br/>
        ///           "url": "https://example.com/hooks/fish",<br/>
        ///           "secret": "&lt;signing-secret&gt;"<br/>
        ///         }<br/>
        ///       ]<br/>
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
        /// `prompt.system_prompt` is limited to 32000 tokens (422 beyond); keeping it<br/>
        /// under 2000 tokens is recommended for latency and cost.<br/>
        /// `voice.voice_id` accepts any public voice model id.<br/>
        /// `voice.speaking_language` accepts any of the 52 supported ISO 639-1 codes<br/>
        /// (the same set the console offers, see the Voice &amp; language docs); anything else is 422. `voice.expressive` (default `true`) enables richer<br/>
        /// expressive delivery (emotion steering, laughter and sounds, pauses); off<br/>
        /// keeps the standard delivery. The `asr` section configures speech<br/>
        /// recognition. `asr.model` picks the model: `deepgram:nova-3` (default),<br/>
        /// `elevenlabs:scribe_v2_realtime`, `elevenlabs:scribe_v2_medical`, or<br/>
        /// `fish_audio:transcribe-stream-1` (Fish realtime recognition, which<br/>
        /// also decides end of turn and whether the caller is interrupting).<br/>
        /// Its former id `fish_audio:transcribe-1-pro-realtime` is still accepted<br/>
        /// and reads back as the current id.<br/>
        /// `asr.multilingual` (default `false`) lets recognition follow callers who<br/>
        /// switch language mid-call, off tells the recognizer to expect<br/>
        /// `voice.speaking_language` (models other than `deepgram:nova-3` may still<br/>
        /// transcribe clear speech in another language). `asr.strict_language`<br/>
        /// (default `false`) enforces `voice.speaking_language` whatever<br/>
        /// `asr.multilingual` says: speech recognized as another language reaches the<br/>
        /// agent as `[unintelligible speech]`. Language is detected per utterance, so<br/>
        /// a short or heavily accented phrase in the speaking language can<br/>
        /// occasionally be detected as another language and replaced too. Only<br/>
        /// enable it when you explicitly need to stop the agent from understanding<br/>
        /// other languages.<br/>
        /// `asr.keyterms` is a recognition<br/>
        /// vocabulary of up to 50 plain terms (brand names, product terms, personal<br/>
        /// names), each at most 100 characters with no commas or semicolons. `[]`<br/>
        /// clears it and 20-50 focused terms work best.<br/>
        /// `voice.background_sound` sets a looping ambience the worker mixes under<br/>
        /// the agent's voice: `preset` is `off` (default) or one of `office`,<br/>
        /// `call_center`, `restaurant`, `cafe`, `city_street`, `phone_line`, `phone_line_digital`,<br/>
        /// `custom`. `volume` (0-1, default 0.15) is the<br/>
        /// ambience's gain relative to the voice. `custom_asset_id` names a clip<br/>
        /// uploaded through `POST /v1/agent/background-sounds`; required with<br/>
        /// `preset: "custom"`, refused otherwise (422). Replaces the whole object;<br/>
        /// an explicit null resets it to off. `tool_ids` and<br/>
        /// `knowledge_source_ids` replace their attachment lists wholesale and every<br/>
        /// id must resolve, else 422. `llm.custom` points the agent at your own<br/>
        /// OpenAI-compatible endpoint; mutually exclusive with `llm.model`, cleared<br/>
        /// with an explicit null. `llm.fallback` sets what the agent tries after its<br/>
        /// model fails: `platform` (default), `manual` (`models` in order, 1 to 3)<br/>
        /// or `off`. In `manual`, each model and `primary` (the agent's own model)<br/>
        /// take optional `ttft_timeout_ms` (500-30000, default 5000 ms, i.e. 5<br/>
        /// seconds, when not set) and `total_timeout_ms` (1000-120000, at least<br/>
        /// `ttft_timeout_ms` when both are set, no limit when not set), and the<br/>
        /// first model can set<br/>
        /// `parallel.kick_in_ms` (300-10000, default 1500) to run alongside the<br/>
        /// agent's own model.<br/>
        /// The response is the draft as stored, which can differ from the request:<br/>
        /// - Every field comes back. Omitted fields keep their value or default.<br/>
        /// - `asr.keyterms` and `voice.pronunciation_dictionary_ids` are trimmed<br/>
        ///   and de-duplicated in order. `tool_ids` is de-duplicated in order.<br/>
        /// - A tool that was archived drops out of `tool_ids` at the next tools<br/>
        ///   write.<br/>
        /// - `conversation.interruption_ignore_phrases` collapses inner spaces and<br/>
        ///   drops case-insensitive duplicates.<br/>
        /// - `conversation.timezone`, transfer phone numbers and transfer text<br/>
        ///   fields are trimmed.<br/>
        /// - `conversation.eagerness` and `conversation.response_wait_ms` move<br/>
        ///   together. The wait wins when both are sent, and the tier is derived<br/>
        ///   from it.<br/>
        /// - `conversation.response_max_wait_ms: 0` reads back as `null`<br/>
        ///   (automatic).<br/>
        /// - `knowledge_base.enabled` becomes `true` when you attach sources and<br/>
        ///   omit it.<br/>
        /// - `llm.custom.base_url` drops a trailing `/` and `/chat/completions`.<br/>
        ///   `llm.custom.model` is trimmed. Setting `llm.custom` resets `llm.model`<br/>
        ///   to the platform default.<br/>
        /// - Secrets read back as `has_secret`, and `llm.custom.api_key` as `null`.<br/>
        /// - `voice.live3_voice` becomes `null` when you set `voice.voice_id`<br/>
        ///   without it: on `live3` the agent then speaks the voice you picked.<br/>
        ///   Switching `voice.engine` to `live3` sets an empty `voice.live3_voice`<br/>
        ///   to `Clara` only while `voice.voice_id` is still the default voice<br/>
        ///   and the patch sets neither.<br/>
        /// - `voice` also returns `keyterms`, `multilingual_asr` and `asr_model`<br/>
        ///   copied from `asr`. They are deprecated.<br/>
        /// - `config_hash` and `updated_at` are set by the server.<br/>
        /// Compare against this response, or against `config_hash`, rather than the<br/>
        /// request body. Publishing never rewrites these values.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="prompt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="voice">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="asr">
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
        /// <param name="guardrails">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="context">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="llm">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="variables">
        /// Default values for the {{placeholders}} in the configured text, used when the session supplies none (the map replaces as a whole), and on_missing for a placeholder with neither: keep leaves it as written (default), empty renders it as empty text, reject refuses the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentAgentsConfigResponse> EditAgentAgentsByAgentIdConfigAsync(
            string agentId,
            global::FishAudio.PublicAgentPromptPatch? prompt = default,
            global::FishAudio.PublicAgentVoicePatch? voice = default,
            global::FishAudio.PublicAgentAsrPatch? asr = default,
            global::FishAudio.PublicAgentConversationPatch? conversation = default,
            global::FishAudio.PublicAgentToolsPatch? tools = default,
            global::FishAudio.PublicAgentWebhooksPatch? webhooks = default,
            global::FishAudio.PublicAgentKnowledgeBasePatch? knowledgeBase = default,
            global::FishAudio.PublicAgentAnalysisPatch? analysis = default,
            global::FishAudio.PublicAgentGuardrailsPatch? guardrails = default,
            global::FishAudio.PublicAgentContextPatch? context = default,
            global::FishAudio.PublicAgentLLMPatch? llm = default,
            global::FishAudio.PublicAgentVariablesPatch? variables = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}