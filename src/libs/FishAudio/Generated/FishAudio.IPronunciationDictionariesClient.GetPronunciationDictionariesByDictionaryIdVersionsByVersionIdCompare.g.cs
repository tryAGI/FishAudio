#nullable enable

namespace FishAudio
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Compare two versions<br/>
        /// Return a row-level diff between the target version and `base_version_id`: added, removed, changed, moved and unchanged rules.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="versionId"></param>
        /// <param name="baseVersionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse> GetPronunciationDictionariesByDictionaryIdVersionsByVersionIdCompareAsync(
            string dictionaryId,
            string versionId,
            string baseVersionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compare two versions<br/>
        /// Return a row-level diff between the target version and `base_version_id`: added, removed, changed, moved and unchanged rules.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="versionId"></param>
        /// <param name="baseVersionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse>> GetPronunciationDictionariesByDictionaryIdVersionsByVersionIdCompareAsResponseAsync(
            string dictionaryId,
            string versionId,
            string baseVersionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}