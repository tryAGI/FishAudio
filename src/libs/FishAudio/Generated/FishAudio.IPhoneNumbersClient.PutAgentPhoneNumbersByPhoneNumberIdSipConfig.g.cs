#nullable enable

namespace FishAudio
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Update SIP Number Config<br/>
        /// Replace the trunk configuration of an imported `sip` number in place:<br/>
        /// rotate digest credentials, change the allowed source addresses, or add,<br/>
        /// update and remove the termination host and its custom SIP headers. Send<br/>
        /// the complete desired configuration; an empty password beside a set<br/>
        /// username keeps the stored one. Trunk ids are stable across updates, so calls in flight are not<br/>
        /// affected. 409 for numbers that are not `sip` imports or not active.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse> PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync(
            string phoneNumberId,

            global::FishAudio.PublicSipNumberConfigPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update SIP Number Config<br/>
        /// Replace the trunk configuration of an imported `sip` number in place:<br/>
        /// rotate digest credentials, change the allowed source addresses, or add,<br/>
        /// update and remove the termination host and its custom SIP headers. Send<br/>
        /// the complete desired configuration; an empty password beside a set<br/>
        /// username keeps the stored one. Trunk ids are stable across updates, so calls in flight are not<br/>
        /// affected. 409 for numbers that are not `sip` imports or not active.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse>> PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsResponseAsync(
            string phoneNumberId,

            global::FishAudio.PublicSipNumberConfigPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update SIP Number Config<br/>
        /// Replace the trunk configuration of an imported `sip` number in place:<br/>
        /// rotate digest credentials, change the allowed source addresses, or add,<br/>
        /// update and remove the termination host and its custom SIP headers. Send<br/>
        /// the complete desired configuration; an empty password beside a set<br/>
        /// username keeps the stored one. Trunk ids are stable across updates, so calls in flight are not<br/>
        /// affected. 409 for numbers that are not `sip` imports or not active.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="inboundAuthUsername"></param>
        /// <param name="inboundAuthPassword"></param>
        /// <param name="inboundAllowedAddresses"></param>
        /// <param name="terminationUri"></param>
        /// <param name="terminationTransport">
        /// Default Value: auto
        /// </param>
        /// <param name="terminationAuthUsername"></param>
        /// <param name="terminationAuthPassword"></param>
        /// <param name="terminationHeaders"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse> PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync(
            string phoneNumberId,
            string? inboundAuthUsername = default,
            string? inboundAuthPassword = default,
            global::System.Collections.Generic.IList<string>? inboundAllowedAddresses = default,
            string? terminationUri = default,
            global::FishAudio.PublicSipNumberConfigPayloadTerminationTransport? terminationTransport = default,
            string? terminationAuthUsername = default,
            string? terminationAuthPassword = default,
            global::System.Collections.Generic.Dictionary<string, string>? terminationHeaders = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}