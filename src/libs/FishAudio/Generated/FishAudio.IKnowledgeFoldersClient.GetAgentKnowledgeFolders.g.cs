#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeFoldersClient
    {
        /// <summary>
        /// List Knowledge Folders<br/>
        /// List your team's knowledge folders across all workspaces, newest first.<br/>
        /// Folder names are unique per workspace, so two workspaces can each have a<br/>
        /// "Support" folder: tell them apart by `workspace_id`. Paginate with<br/>
        /// `cursor` (follow `next_cursor` while `has_more` is true) or with `page`<br/>
        /// for offset pagination with a `total` count — the two are mutually<br/>
        /// exclusive. To list the sources in a folder, call<br/>
        /// `GET /v1/agent/knowledge-sources?folder_id=&lt;folder_id&gt;`; pass<br/>
        /// `include_total=true` there for a count.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentKnowledgeFoldersResponse> GetAgentKnowledgeFoldersAsync(
            string? cursor = default,
            int? page = default,
            bool? includeTotal = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Knowledge Folders<br/>
        /// List your team's knowledge folders across all workspaces, newest first.<br/>
        /// Folder names are unique per workspace, so two workspaces can each have a<br/>
        /// "Support" folder: tell them apart by `workspace_id`. Paginate with<br/>
        /// `cursor` (follow `next_cursor` while `has_more` is true) or with `page`<br/>
        /// for offset pagination with a `total` count — the two are mutually<br/>
        /// exclusive. To list the sources in a folder, call<br/>
        /// `GET /v1/agent/knowledge-sources?folder_id=&lt;folder_id&gt;`; pass<br/>
        /// `include_total=true` there for a count.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentKnowledgeFoldersResponse>> GetAgentKnowledgeFoldersAsResponseAsync(
            string? cursor = default,
            int? page = default,
            bool? includeTotal = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}