#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeSourcesClient
    {
        /// <summary>
        /// List Knowledge Sources<br/>
        /// List your team's knowledge sources, newest first. Paginate with `cursor`<br/>
        /// (follow `next_cursor` while `has_more` is true) or with `page` for offset<br/>
        /// pagination with a `total` count — the two are mutually exclusive. Filter<br/>
        /// by folder with `folder_id=&lt;id&gt;`; with `folder_id=root` or no `folder_id`<br/>
        /// you get every source, and the ones outside any folder have a null<br/>
        /// `folder_id`.
        /// </summary>
        /// <param name="search">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="folderId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="page">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includeTotal">
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentKnowledgeSourcesResponse> GetAgentKnowledgeSourcesAsync(
            string? search = default,
            string? folderId = default,
            string? cursor = default,
            int? page = default,
            bool? includeTotal = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Knowledge Sources<br/>
        /// List your team's knowledge sources, newest first. Paginate with `cursor`<br/>
        /// (follow `next_cursor` while `has_more` is true) or with `page` for offset<br/>
        /// pagination with a `total` count — the two are mutually exclusive. Filter<br/>
        /// by folder with `folder_id=&lt;id&gt;`; with `folder_id=root` or no `folder_id`<br/>
        /// you get every source, and the ones outside any folder have a null<br/>
        /// `folder_id`.
        /// </summary>
        /// <param name="search">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="folderId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="page">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includeTotal">
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentKnowledgeSourcesResponse>> GetAgentKnowledgeSourcesAsResponseAsync(
            string? search = default,
            string? folderId = default,
            string? cursor = default,
            int? page = default,
            bool? includeTotal = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}