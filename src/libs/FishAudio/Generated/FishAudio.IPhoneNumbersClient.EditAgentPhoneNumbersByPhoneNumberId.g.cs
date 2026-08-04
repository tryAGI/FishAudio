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
        /// is reprovisioned.
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
        /// is reprovisioned.
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
        /// is reprovisioned.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="label">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="agentId">
        /// Agent that answers this number's inbound calls. Explicit null unbinds; omit the field to keep the current binding.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentPhoneNumbersResponse> EditAgentPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,
            string? label = default,
            string? agentId = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}