#nullable enable

namespace FishAudio
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Search Available Phone Numbers<br/>
        /// Search the purchasable number inventory. Buy an entry with<br/>
        /// `POST /v1/agent/phone-numbers`; availability is not a reservation, so a listed<br/>
        /// number can still be claimed by someone else first.
        /// </summary>
        /// <param name="countryCode">
        /// Default Value: US
        /// </param>
        /// <param name="areaCode">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="numberType">
        /// Default Value: local
        /// </param>
        /// <param name="provider">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentAvailablePhoneNumbersResponse> GetAgentAvailablePhoneNumbersAsync(
            string? countryCode = default,
            string? areaCode = default,
            global::FishAudio.GetAgentAvailablePhoneNumbersNumberType? numberType = default,
            string? provider = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Available Phone Numbers<br/>
        /// Search the purchasable number inventory. Buy an entry with<br/>
        /// `POST /v1/agent/phone-numbers`; availability is not a reservation, so a listed<br/>
        /// number can still be claimed by someone else first.
        /// </summary>
        /// <param name="countryCode">
        /// Default Value: US
        /// </param>
        /// <param name="areaCode">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="numberType">
        /// Default Value: local
        /// </param>
        /// <param name="provider">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentAvailablePhoneNumbersResponse>> GetAgentAvailablePhoneNumbersAsResponseAsync(
            string? countryCode = default,
            string? areaCode = default,
            global::FishAudio.GetAgentAvailablePhoneNumbersNumberType? numberType = default,
            string? provider = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}