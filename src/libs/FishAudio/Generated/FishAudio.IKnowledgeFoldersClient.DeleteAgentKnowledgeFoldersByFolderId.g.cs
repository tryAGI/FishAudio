#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeFoldersClient
    {
        /// <summary>
        /// Delete Knowledge Folder<br/>
        /// Delete a folder, empty or not. The knowledge sources inside it are not<br/>
        /// deleted: they are taken out of the folder (`folder_id` becomes null).
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentKnowledgeFoldersByFolderIdAsync(
            string folderId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Knowledge Folder<br/>
        /// Delete a folder, empty or not. The knowledge sources inside it are not<br/>
        /// deleted: they are taken out of the folder (`folder_id` becomes null).
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> DeleteAgentKnowledgeFoldersByFolderIdAsResponseAsync(
            string folderId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}