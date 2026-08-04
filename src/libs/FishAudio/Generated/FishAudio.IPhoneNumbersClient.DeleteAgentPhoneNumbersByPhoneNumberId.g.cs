#nullable enable

namespace FishAudio
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Release Phone Number<br/>
        /// Release a number back to the provider's inventory and stop its daily<br/>
        /// billing. This is irreversible: anyone — including other platforms — can<br/>
        /// buy the number afterwards, so callers who saved it may reach a stranger.<br/>
        /// The number disappears from this API immediately.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Release Phone Number<br/>
        /// Release a number back to the provider's inventory and stop its daily<br/>
        /// billing. This is irreversible: anyone — including other platforms — can<br/>
        /// buy the number afterwards, so callers who saved it may reach a stranger.<br/>
        /// The number disappears from this API immediately.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> DeleteAgentPhoneNumbersByPhoneNumberIdAsResponseAsync(
            string phoneNumberId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}