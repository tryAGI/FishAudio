#nullable enable

namespace FishAudio
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Get Phone Number<br/>
        /// Fetch one phone number, including its current agent binding and<br/>
        /// provisioning status.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentPhoneNumbersResponse6> GetAgentPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Phone Number<br/>
        /// Fetch one phone number, including its current agent binding and<br/>
        /// provisioning status.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentPhoneNumbersResponse6>> GetAgentPhoneNumbersByPhoneNumberIdAsResponseAsync(
            string phoneNumberId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}