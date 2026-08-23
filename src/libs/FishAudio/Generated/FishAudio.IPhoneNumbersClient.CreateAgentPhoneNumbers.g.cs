#nullable enable

namespace FishAudio
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Purchase or Import Phone Number<br/>
        /// `provider` discriminates two variants. `twilio` buys a number from the<br/>
        /// managed inventory: it lands in your default workspace, any `agent_id` you<br/>
        /// bind must live there too, and billing is the monthly price charged in<br/>
        /// daily slices; the first day is charged before anything is bought (402<br/>
        /// costs you nothing) and the daily run advances it from there. `sip`<br/>
        /// imports a number you already own at your carrier: point your trunk's<br/>
        /// origination at our SIP host, provide inbound authentication (digest<br/>
        /// and/or source CIDRs) and optionally a termination host so the number can<br/>
        /// place calls; nothing is rented and there is no monthly fee. Either way,<br/>
        /// 409 means the number is already on the platform; 502 means the provider<br/>
        /// or trunk provisioning refused, and the number stays visible with status<br/>
        /// `error` and is safe to release.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentPhoneNumbersResponse> CreateAgentPhoneNumbersAsync(

            global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload> request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase or Import Phone Number<br/>
        /// `provider` discriminates two variants. `twilio` buys a number from the<br/>
        /// managed inventory: it lands in your default workspace, any `agent_id` you<br/>
        /// bind must live there too, and billing is the monthly price charged in<br/>
        /// daily slices; the first day is charged before anything is bought (402<br/>
        /// costs you nothing) and the daily run advances it from there. `sip`<br/>
        /// imports a number you already own at your carrier: point your trunk's<br/>
        /// origination at our SIP host, provide inbound authentication (digest<br/>
        /// and/or source CIDRs) and optionally a termination host so the number can<br/>
        /// place calls; nothing is rented and there is no monthly fee. Either way,<br/>
        /// 409 means the number is already on the platform; 502 means the provider<br/>
        /// or trunk provisioning refused, and the number stays visible with status<br/>
        /// `error` and is safe to release.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentPhoneNumbersResponse>> CreateAgentPhoneNumbersAsResponseAsync(

            global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload> request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase or Import Phone Number<br/>
        /// `provider` discriminates two variants. `twilio` buys a number from the<br/>
        /// managed inventory: it lands in your default workspace, any `agent_id` you<br/>
        /// bind must live there too, and billing is the monthly price charged in<br/>
        /// daily slices; the first day is charged before anything is bought (402<br/>
        /// costs you nothing) and the daily run advances it from there. `sip`<br/>
        /// imports a number you already own at your carrier: point your trunk's<br/>
        /// origination at our SIP host, provide inbound authentication (digest<br/>
        /// and/or source CIDRs) and optionally a termination host so the number can<br/>
        /// place calls; nothing is rented and there is no monthly fee. Either way,<br/>
        /// 409 means the number is already on the platform; 502 means the provider<br/>
        /// or trunk provisioning refused, and the number stays visible with status<br/>
        /// `error` and is safe to release.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentPhoneNumbersResponse> CreateAgentPhoneNumbersAsync(
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}