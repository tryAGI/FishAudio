#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeSourcesClient
    {
        /// <summary>
        /// Create Knowledge Source<br/>
        /// Upload a plain-text or Markdown file (UTF-8, up to 1 MB) as a knowledge<br/>
        /// source. Send `multipart/form-data` with the file in `source`; `name`<br/>
        /// defaults to the file name. Attach it to agents via the agent config's<br/>
        /// `knowledge_base.knowledge_source_ids`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentKnowledgeSourcesResponse> CreateAgentKnowledgeSourcesAsync(

            global::FishAudio.CreateAgentKnowledgeSourcesRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Knowledge Source<br/>
        /// Upload a plain-text or Markdown file (UTF-8, up to 1 MB) as a knowledge<br/>
        /// source. Send `multipart/form-data` with the file in `source`; `name`<br/>
        /// defaults to the file name. Attach it to agents via the agent config's<br/>
        /// `knowledge_base.knowledge_source_ids`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentKnowledgeSourcesResponse>> CreateAgentKnowledgeSourcesAsResponseAsync(

            global::FishAudio.CreateAgentKnowledgeSourcesRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Knowledge Source<br/>
        /// Upload a plain-text or Markdown file (UTF-8, up to 1 MB) as a knowledge<br/>
        /// source. Send `multipart/form-data` with the file in `source`; `name`<br/>
        /// defaults to the file name. Attach it to agents via the agent config's<br/>
        /// `knowledge_base.knowledge_source_ids`.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="sourcename"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentKnowledgeSourcesResponse> CreateAgentKnowledgeSourcesAsync(
            byte[] source,
            string sourcename,
            string? name = default,
            string? description = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Knowledge Source<br/>
        /// Upload a plain-text or Markdown file (UTF-8, up to 1 MB) as a knowledge<br/>
        /// source. Send `multipart/form-data` with the file in `source`; `name`<br/>
        /// defaults to the file name. Attach it to agents via the agent config's<br/>
        /// `knowledge_base.knowledge_source_ids`.
        /// </summary>
        /// <param name="source">
        /// The stream to send as the multipart 'source' file part.
        /// </param>
        /// <param name="sourcename"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentKnowledgeSourcesResponse> CreateAgentKnowledgeSourcesAsync(
            global::System.IO.Stream source,
            string sourcename,
            string? name = default,
            string? description = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Knowledge Source<br/>
        /// Upload a plain-text or Markdown file (UTF-8, up to 1 MB) as a knowledge<br/>
        /// source. Send `multipart/form-data` with the file in `source`; `name`<br/>
        /// defaults to the file name. Attach it to agents via the agent config's<br/>
        /// `knowledge_base.knowledge_source_ids`.
        /// </summary>
        /// <param name="source">
        /// The stream to send as the multipart 'source' file part.
        /// </param>
        /// <param name="sourcename"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentKnowledgeSourcesResponse>> CreateAgentKnowledgeSourcesAsResponseAsync(
            global::System.IO.Stream source,
            string sourcename,
            string? name = default,
            string? description = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}