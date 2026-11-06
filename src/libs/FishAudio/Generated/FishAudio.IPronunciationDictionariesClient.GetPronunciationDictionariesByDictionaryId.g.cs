#nullable enable

namespace FishAudio
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Get a pronunciation dictionary<br/>
        /// Get one dictionary owned by the caller's team.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetPronunciationDictionariesResponse7> GetPronunciationDictionariesByDictionaryIdAsync(
            string dictionaryId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a pronunciation dictionary<br/>
        /// Get one dictionary owned by the caller's team.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetPronunciationDictionariesResponse7>> GetPronunciationDictionariesByDictionaryIdAsResponseAsync(
            string dictionaryId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}