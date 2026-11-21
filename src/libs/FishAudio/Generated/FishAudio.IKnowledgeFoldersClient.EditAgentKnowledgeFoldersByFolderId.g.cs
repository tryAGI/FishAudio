#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeFoldersClient
    {
        /// <summary>
        /// Rename Knowledge Folder<br/>
        /// Rename a folder. The name must be free within the folder's own workspace<br/>
        /// (409 otherwise); renaming a folder to its current name succeeds.
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentKnowledgeFoldersResponse> EditAgentKnowledgeFoldersByFolderIdAsync(
            string folderId,

            global::FishAudio.PublicKnowledgeFolderPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename Knowledge Folder<br/>
        /// Rename a folder. The name must be free within the folder's own workspace<br/>
        /// (409 otherwise); renaming a folder to its current name succeeds.
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchAgentKnowledgeFoldersResponse>> EditAgentKnowledgeFoldersByFolderIdAsResponseAsync(
            string folderId,

            global::FishAudio.PublicKnowledgeFolderPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename Knowledge Folder<br/>
        /// Rename a folder. The name must be free within the folder's own workspace<br/>
        /// (409 otherwise); renaming a folder to its current name succeeds.
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="name">
        /// 1-120 characters after leading and trailing whitespace is removed (a blank name is rejected). Unique within the workspace, case-sensitive.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentKnowledgeFoldersResponse> EditAgentKnowledgeFoldersByFolderIdAsync(
            string folderId,
            string name,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}