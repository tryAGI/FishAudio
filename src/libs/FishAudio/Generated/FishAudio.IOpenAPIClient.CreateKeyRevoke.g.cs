#nullable enable

namespace FishAudio
{
    public partial interface IOpenAPIClient
    {
        /// <summary>
        /// Revoke publicly exposed API keys<br/>
        /// Anyone holding an API key's plaintext can permanently revoke it here.<br/>
        /// No authentication is required; Authorization headers are ignored.<br/>
        /// Valid requests always return the same empty 202, whether or not any<br/>
        /// key matched. The creator and shared team's owner receive a security<br/>
        /// notice. Invalid bodies return 422; each IP is limited to 60 requests<br/>
        /// per hour (429). Source and URL are logged for attribution only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateKeyRevokeAsync(

            global::FishAudio.RevokeCredentials request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke publicly exposed API keys<br/>
        /// Anyone holding an API key's plaintext can permanently revoke it here.<br/>
        /// No authentication is required; Authorization headers are ignored.<br/>
        /// Valid requests always return the same empty 202, whether or not any<br/>
        /// key matched. The creator and shared team's owner receive a security<br/>
        /// notice. Invalid bodies return 422; each IP is limited to 60 requests<br/>
        /// per hour (429). Source and URL are logged for attribution only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> CreateKeyRevokeAsResponseAsync(

            global::FishAudio.RevokeCredentials request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke publicly exposed API keys<br/>
        /// Anyone holding an API key's plaintext can permanently revoke it here.<br/>
        /// No authentication is required; Authorization headers are ignored.<br/>
        /// Valid requests always return the same empty 202, whether or not any<br/>
        /// key matched. The creator and shared team's owner receive a security<br/>
        /// notice. Invalid bodies return 422; each IP is limited to 60 requests<br/>
        /// per hour (429). Source and URL are logged for attribution only.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="source">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="url">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateKeyRevokeAsync(
            global::System.Collections.Generic.IList<string> credentials,
            string? source = default,
            string? url = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}