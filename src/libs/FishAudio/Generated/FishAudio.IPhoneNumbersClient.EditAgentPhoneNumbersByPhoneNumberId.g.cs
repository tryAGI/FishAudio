#nullable enable

namespace FishAudio
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Update Phone Number<br/>
        /// Change the label and/or repoint the number at another agent — the<br/>
        /// deployment-pipeline move (rebind from the staging agent to the production<br/>
        /// one). Send `agent_id: null` to unbind; unbound numbers ring busy. The<br/>
        /// agent must live in the number's workspace. Rebinding is a routing-table<br/>
        /// update resolved on the next inbound call; nothing about the number itself<br/>
        /// is reprovisioned.<br/>
        /// Managed `twilio` numbers also accept `transfer_caller_id`, which picks<br/>
        /// the number a transfer target sees (cold and warm alike), and<br/>
        /// `retry_caller_id_sync` to re-apply it after a failed synchronization. Read<br/>
        /// `caller_id_sync_status` on the response. Imported `sip` numbers return 409<br/>
        /// for either field because their carrier owns the setting.<br/>
        /// Every field here is a number setting, not agent config: changes apply<br/>
        /// from the next call without publishing, and publishing or rolling back the<br/>
        /// agent never changes them. Cold-transfer caller ID applies once<br/>
        /// `caller_id_sync_status` is `synced`.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentPhoneNumbersResponse> EditAgentPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,

            global::FishAudio.PublicPhoneNumberUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Change the label and/or repoint the number at another agent — the<br/>
        /// deployment-pipeline move (rebind from the staging agent to the production<br/>
        /// one). Send `agent_id: null` to unbind; unbound numbers ring busy. The<br/>
        /// agent must live in the number's workspace. Rebinding is a routing-table<br/>
        /// update resolved on the next inbound call; nothing about the number itself<br/>
        /// is reprovisioned.<br/>
        /// Managed `twilio` numbers also accept `transfer_caller_id`, which picks<br/>
        /// the number a transfer target sees (cold and warm alike), and<br/>
        /// `retry_caller_id_sync` to re-apply it after a failed synchronization. Read<br/>
        /// `caller_id_sync_status` on the response. Imported `sip` numbers return 409<br/>
        /// for either field because their carrier owns the setting.<br/>
        /// Every field here is a number setting, not agent config: changes apply<br/>
        /// from the next call without publishing, and publishing or rolling back the<br/>
        /// agent never changes them. Cold-transfer caller ID applies once<br/>
        /// `caller_id_sync_status` is `synced`.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchAgentPhoneNumbersResponse>> EditAgentPhoneNumbersByPhoneNumberIdAsResponseAsync(
            string phoneNumberId,

            global::FishAudio.PublicPhoneNumberUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Change the label and/or repoint the number at another agent — the<br/>
        /// deployment-pipeline move (rebind from the staging agent to the production<br/>
        /// one). Send `agent_id: null` to unbind; unbound numbers ring busy. The<br/>
        /// agent must live in the number's workspace. Rebinding is a routing-table<br/>
        /// update resolved on the next inbound call; nothing about the number itself<br/>
        /// is reprovisioned.<br/>
        /// Managed `twilio` numbers also accept `transfer_caller_id`, which picks<br/>
        /// the number a transfer target sees (cold and warm alike), and<br/>
        /// `retry_caller_id_sync` to re-apply it after a failed synchronization. Read<br/>
        /// `caller_id_sync_status` on the response. Imported `sip` numbers return 409<br/>
        /// for either field because their carrier owns the setting.<br/>
        /// Every field here is a number setting, not agent config: changes apply<br/>
        /// from the next call without publishing, and publishing or rolling back the<br/>
        /// agent never changes them. Cold-transfer caller ID applies once<br/>
        /// `caller_id_sync_status` is `synced`.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="label">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="agentId">
        /// Agent that answers this number's inbound calls. Explicit null unbinds; omit the field to keep the current binding.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transferCallerId">
        /// Managed `twilio` numbers only: the caller ID a transfer target sees, `agent_number` (this number) or `original_caller` (the caller's own number). Applies to cold and warm transfers. It is a number setting, not agent config: no publish is needed and agent rollbacks leave it alone. Warm transfers follow it from the next call, cold transfers once `caller_id_sync_status` is `synced`. The deprecated boolean `cold_transfer_use_original_caller` is still accepted in its place.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="retryCallerIdSync">
        /// Re-apply the current caller ID policy after a failed synchronization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentPhoneNumbersResponse> EditAgentPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,
            string? label = default,
            string? agentId = default,
            global::FishAudio.PublicPhoneNumberUpdatePayloadTransferCallerId? transferCallerId = default,
            bool? retryCallerIdSync = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}