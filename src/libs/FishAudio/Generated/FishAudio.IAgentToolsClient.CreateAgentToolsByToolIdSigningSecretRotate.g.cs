#nullable enable

namespace FishAudio
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Rotate Tool Signing Secret<br/>
        /// Turn on request signing for a webhook tool, or replace its secret. The<br/>
        /// response returns the new secret once. The replaced secret keeps signing<br/>
        /// next to the new one for `previous_secret_expires_in_seconds` (default 24<br/>
        /// hours), so you can deploy the new secret without dropping a request.<br/>
        /// Returns 409 while a previous secret is still active: revoke it first.<br/>
        /// The change reaches every agent using the tool at its next session,<br/>
        /// published versions included.<br/>
        /// Signed requests carry `X-Fish-Webhook-Signature: t=&lt;unix&gt;,v1=&lt;hex&gt;`, the<br/>
        /// same header and scheme as post-call webhooks. Each `v1` is the hex<br/>
        /// HMAC-SHA256 of `{t}.{body}` with one secret, where `body` is the exact<br/>
        /// request body (empty for GET). Check every `v1` entry: during a rotation<br/>
        /// window there are two, the new secret's first. Reject a request whose `t`<br/>
        /// is more than 5 minutes off your clock.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentToolsSigningSecretRotateResponse> CreateAgentToolsByToolIdSigningSecretRotateAsync(
            string toolId,

            global::FishAudio.AgentWebhookToolSigningSecretRotatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate Tool Signing Secret<br/>
        /// Turn on request signing for a webhook tool, or replace its secret. The<br/>
        /// response returns the new secret once. The replaced secret keeps signing<br/>
        /// next to the new one for `previous_secret_expires_in_seconds` (default 24<br/>
        /// hours), so you can deploy the new secret without dropping a request.<br/>
        /// Returns 409 while a previous secret is still active: revoke it first.<br/>
        /// The change reaches every agent using the tool at its next session,<br/>
        /// published versions included.<br/>
        /// Signed requests carry `X-Fish-Webhook-Signature: t=&lt;unix&gt;,v1=&lt;hex&gt;`, the<br/>
        /// same header and scheme as post-call webhooks. Each `v1` is the hex<br/>
        /// HMAC-SHA256 of `{t}.{body}` with one secret, where `body` is the exact<br/>
        /// request body (empty for GET). Check every `v1` entry: during a rotation<br/>
        /// window there are two, the new secret's first. Reject a request whose `t`<br/>
        /// is more than 5 minutes off your clock.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentToolsSigningSecretRotateResponse>> CreateAgentToolsByToolIdSigningSecretRotateAsResponseAsync(
            string toolId,

            global::FishAudio.AgentWebhookToolSigningSecretRotatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate Tool Signing Secret<br/>
        /// Turn on request signing for a webhook tool, or replace its secret. The<br/>
        /// response returns the new secret once. The replaced secret keeps signing<br/>
        /// next to the new one for `previous_secret_expires_in_seconds` (default 24<br/>
        /// hours), so you can deploy the new secret without dropping a request.<br/>
        /// Returns 409 while a previous secret is still active: revoke it first.<br/>
        /// The change reaches every agent using the tool at its next session,<br/>
        /// published versions included.<br/>
        /// Signed requests carry `X-Fish-Webhook-Signature: t=&lt;unix&gt;,v1=&lt;hex&gt;`, the<br/>
        /// same header and scheme as post-call webhooks. Each `v1` is the hex<br/>
        /// HMAC-SHA256 of `{t}.{body}` with one secret, where `body` is the exact<br/>
        /// request body (empty for GET). Check every `v1` entry: during a rotation<br/>
        /// window there are two, the new secret's first. Reject a request whose `t`<br/>
        /// is more than 5 minutes off your clock.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="secret">
        /// The new signing secret. Omit it to have one generated (`whsec_` plus 256 random bits), which is the recommended way.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="previousSecretExpiresInSeconds">
        /// How long the replaced secret keeps signing next to the new one, as a second `v1`. Default 24 hours, at most 7 days. 0 switches at once. Ignored when signing was off.<br/>
        /// Default Value: 86400
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentToolsSigningSecretRotateResponse> CreateAgentToolsByToolIdSigningSecretRotateAsync(
            string toolId,
            string? secret = default,
            int? previousSecretExpiresInSeconds = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}