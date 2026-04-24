#nullable enable

namespace FishAudio
{
    public partial interface IWalletClient
    {
        /// <summary>
        /// Get API Credit
        /// </summary>
        /// <param name="checkFreeCredit">
        /// Default Value: false
        /// </param>
        /// <param name="teamId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="userId">
        /// Default Value: self
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetWalletApiCreditResponse> GetWalletByUserIdApiCreditAsync(
            string? userId,
            bool? checkFreeCredit = default,
            string? teamId = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}