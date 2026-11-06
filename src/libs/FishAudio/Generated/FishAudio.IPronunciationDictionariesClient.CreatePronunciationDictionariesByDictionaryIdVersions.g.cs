#nullable enable

namespace FishAudio
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Publish a version<br/>
        /// Publish an immutable snapshot of rules. Send the version you believe is current as `expected_latest_version_id`; a stale value returns 409. Keys are unique within a version (duplicates return 422). Alias rules never shorten billing.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreatePronunciationDictionariesVersionsResponse> CreatePronunciationDictionariesByDictionaryIdVersionsAsync(
            string dictionaryId,

            global::FishAudio.PronunciationDictionaryVersionCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish a version<br/>
        /// Publish an immutable snapshot of rules. Send the version you believe is current as `expected_latest_version_id`; a stale value returns 409. Keys are unique within a version (duplicates return 422). Alias rules never shorten billing.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreatePronunciationDictionariesVersionsResponse>> CreatePronunciationDictionariesByDictionaryIdVersionsAsResponseAsync(
            string dictionaryId,

            global::FishAudio.PronunciationDictionaryVersionCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish a version<br/>
        /// Publish an immutable snapshot of rules. Send the version you believe is current as `expected_latest_version_id`; a stale value returns 409. Keys are unique within a version (duplicates return 422). Alias rules never shorten billing.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="expectedLatestVersionId">
        /// Optimistic-concurrency guard: the latest version ID the caller believes is current, or null for the first publish. A mismatch returns 409.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Optional version note (up to 1024 characters).
        /// </param>
        /// <param name="items">
        /// Complete ordered rule list for the new version (up to 5000 rules). Keys must be unique within the version; order is the engine's application order.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreatePronunciationDictionariesVersionsResponse> CreatePronunciationDictionariesByDictionaryIdVersionsAsync(
            string dictionaryId,
            string? expectedLatestVersionId = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryItemPayload>? items = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}