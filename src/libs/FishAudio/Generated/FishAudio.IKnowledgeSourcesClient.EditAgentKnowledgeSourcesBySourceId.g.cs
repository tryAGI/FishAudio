#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeSourcesClient
    {
        /// <summary>
        /// Update Knowledge Source<br/>
        /// Rename the source and/or replace its content by uploading a new file in<br/>
        /// `source` (multipart). Replacing content increments `revision_number` while<br/>
        /// the id stays stable, and every attached agent's draft picks it up<br/>
        /// immediately; published versions pin the revision they were published with,<br/>
        /// so republish each affected agent to put the new content live — that<br/>
        /// two-step (sync content, republish) is the nightly content-sync recipe.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentKnowledgeSourcesResponse> EditAgentKnowledgeSourcesBySourceIdAsync(
            string sourceId,

            global::FishAudio.PatchAgentKnowledgeSourcesRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Knowledge Source<br/>
        /// Rename the source and/or replace its content by uploading a new file in<br/>
        /// `source` (multipart). Replacing content increments `revision_number` while<br/>
        /// the id stays stable, and every attached agent's draft picks it up<br/>
        /// immediately; published versions pin the revision they were published with,<br/>
        /// so republish each affected agent to put the new content live — that<br/>
        /// two-step (sync content, republish) is the nightly content-sync recipe.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchAgentKnowledgeSourcesResponse>> EditAgentKnowledgeSourcesBySourceIdAsResponseAsync(
            string sourceId,

            global::FishAudio.PatchAgentKnowledgeSourcesRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Knowledge Source<br/>
        /// Rename the source and/or replace its content by uploading a new file in<br/>
        /// `source` (multipart). Replacing content increments `revision_number` while<br/>
        /// the id stays stable, and every attached agent's draft picks it up<br/>
        /// immediately; published versions pin the revision they were published with,<br/>
        /// so republish each affected agent to put the new content live — that<br/>
        /// two-step (sync content, republish) is the nightly content-sync recipe.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="source">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sourcename">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentKnowledgeSourcesResponse> EditAgentKnowledgeSourcesBySourceIdAsync(
            string sourceId,
            byte[]? source = default,
            string? sourcename = default,
            string? name = default,
            string? description = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}