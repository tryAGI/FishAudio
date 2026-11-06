#nullable enable

namespace FishAudio
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Get a version<br/>
        /// Get a published version with its ordered rules. Requires auth and is scoped to the caller's team.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetPronunciationDictionariesVersionsResponse8> GetPronunciationDictionariesByDictionaryIdVersionsByVersionIdAsync(
            string dictionaryId,
            string versionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a version<br/>
        /// Get a published version with its ordered rules. Requires auth and is scoped to the caller's team.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetPronunciationDictionariesVersionsResponse8>> GetPronunciationDictionariesByDictionaryIdVersionsByVersionIdAsResponseAsync(
            string dictionaryId,
            string versionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}