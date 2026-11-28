#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeFoldersClient
    {
        /// <summary>
        /// Create Knowledge Folder<br/>
        /// Create a folder in the API key owner's default workspace. Returns 409 if<br/>
        /// that workspace already has a folder with the same name (compared exactly,<br/>
        /// case-sensitive). Put knowledge sources in it by passing `folder_id` when<br/>
        /// you create or update them.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentKnowledgeFoldersResponse> CreateAgentKnowledgeFoldersAsync(

            global::FishAudio.PublicKnowledgeFolderPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Knowledge Folder<br/>
        /// Create a folder in the API key owner's default workspace. Returns 409 if<br/>
        /// that workspace already has a folder with the same name (compared exactly,<br/>
        /// case-sensitive). Put knowledge sources in it by passing `folder_id` when<br/>
        /// you create or update them.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentKnowledgeFoldersResponse>> CreateAgentKnowledgeFoldersAsResponseAsync(

            global::FishAudio.PublicKnowledgeFolderPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Knowledge Folder<br/>
        /// Create a folder in the API key owner's default workspace. Returns 409 if<br/>
        /// that workspace already has a folder with the same name (compared exactly,<br/>
        /// case-sensitive). Put knowledge sources in it by passing `folder_id` when<br/>
        /// you create or update them.
        /// </summary>
        /// <param name="name">
        /// 1-120 characters after leading and trailing whitespace is removed (a blank name is rejected). Unique within the workspace, case-sensitive.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentKnowledgeFoldersResponse> CreateAgentKnowledgeFoldersAsync(
            string name,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}