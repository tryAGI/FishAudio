#nullable enable

namespace FishAudio
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Buy a number from the inventory. The number lands in your default<br/>
        /// workspace, and any `agent_id` you bind must live there too. Billing is the<br/>
        /// monthly price charged in daily slices: the first day is charged before<br/>
        /// anything is bought (402 costs you nothing), and the daily run advances it<br/>
        /// from there. 409 means the number is already on the platform; 502 means the<br/>
        /// provider refused the purchase; the number stays visible with status<br/>
        /// `error` and is safe to release.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentPhoneNumbersResponse> CreateAgentPhoneNumbersAsync(

            global::FishAudio.PublicPhoneNumberPurchasePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Buy a number from the inventory. The number lands in your default<br/>
        /// workspace, and any `agent_id` you bind must live there too. Billing is the<br/>
        /// monthly price charged in daily slices: the first day is charged before<br/>
        /// anything is bought (402 costs you nothing), and the daily run advances it<br/>
        /// from there. 409 means the number is already on the platform; 502 means the<br/>
        /// provider refused the purchase; the number stays visible with status<br/>
        /// `error` and is safe to release.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentPhoneNumbersResponse>> CreateAgentPhoneNumbersAsResponseAsync(

            global::FishAudio.PublicPhoneNumberPurchasePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Buy a number from the inventory. The number lands in your default<br/>
        /// workspace, and any `agent_id` you bind must live there too. Billing is the<br/>
        /// monthly price charged in daily slices: the first day is charged before<br/>
        /// anything is bought (402 costs you nothing), and the daily run advances it<br/>
        /// from there. 409 means the number is already on the platform; 502 means the<br/>
        /// provider refused the purchase; the number stays visible with status<br/>
        /// `error` and is safe to release.
        /// </summary>
        /// <param name="provider">
        /// Inventory to buy from. Only the managed `twilio` inventory is purchasable (supports call transfer). The field discriminates so importing your own numbers can share this endpoint later.
        /// </param>
        /// <param name="phoneNumber">
        /// E.164 number from `GET /v1/agent/available-phone-numbers`, e.g. +14155550123.
        /// </param>
        /// <param name="label"></param>
        /// <param name="agentId">
        /// Bind an agent to answer inbound calls right away.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentPhoneNumbersResponse> CreateAgentPhoneNumbersAsync(
            string phoneNumber,
            string provider = "twilio",
            string? label = default,
            string? agentId = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}