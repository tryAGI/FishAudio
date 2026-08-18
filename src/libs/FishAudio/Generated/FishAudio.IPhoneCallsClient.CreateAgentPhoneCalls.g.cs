#nullable enable

namespace FishAudio
{
    public partial interface IPhoneCallsClient
    {
        /// <summary>
        /// Create Phone Call<br/>
        /// Place an outbound call from one of your Twilio phone numbers to a US,<br/>
        /// Canada or Japan destination. A domestic trunk 0 after +81 (e.g.<br/>
        /// +81080...) is accepted and normalized to E.164 (+8180...). Returns<br/>
        /// immediately with the session queued for<br/>
        /// dialing; subscribe to the `phone_call.dial_finished` webhook or poll<br/>
        /// `GET /v1/agent/sessions/{session_id}` for the dial outcome. Ringing is<br/>
        /// never billed — metering starts when the callee answers.<br/>
        /// Errors carry a machine-readable `reason` (e.g. `destination_not_allowed`,<br/>
        /// `insufficient_credit`, `daily_limit_exceeded`,<br/>
        /// `concurrency_limit_exceeded`).
        /// </summary>
        /// <param name="idempotencyKey">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/phone-calls \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'Idempotency-Key: &lt;unique-key&gt;' \<br/>
        ///   --data '{<br/>
        ///     "agent_id": "&lt;agent-id&gt;",<br/>
        ///     "phone_number_id": "&lt;phone-number-id&gt;",<br/>
        ///     "to_number": "+14155550123"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentPhoneCallsResponse> CreateAgentPhoneCallsAsync(

            global::FishAudio.PhoneCallCreatePayload request,
            string? idempotencyKey = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Phone Call<br/>
        /// Place an outbound call from one of your Twilio phone numbers to a US,<br/>
        /// Canada or Japan destination. A domestic trunk 0 after +81 (e.g.<br/>
        /// +81080...) is accepted and normalized to E.164 (+8180...). Returns<br/>
        /// immediately with the session queued for<br/>
        /// dialing; subscribe to the `phone_call.dial_finished` webhook or poll<br/>
        /// `GET /v1/agent/sessions/{session_id}` for the dial outcome. Ringing is<br/>
        /// never billed — metering starts when the callee answers.<br/>
        /// Errors carry a machine-readable `reason` (e.g. `destination_not_allowed`,<br/>
        /// `insufficient_credit`, `daily_limit_exceeded`,<br/>
        /// `concurrency_limit_exceeded`).
        /// </summary>
        /// <param name="idempotencyKey">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/phone-calls \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'Idempotency-Key: &lt;unique-key&gt;' \<br/>
        ///   --data '{<br/>
        ///     "agent_id": "&lt;agent-id&gt;",<br/>
        ///     "phone_number_id": "&lt;phone-number-id&gt;",<br/>
        ///     "to_number": "+14155550123"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentPhoneCallsResponse>> CreateAgentPhoneCallsAsResponseAsync(

            global::FishAudio.PhoneCallCreatePayload request,
            string? idempotencyKey = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Phone Call<br/>
        /// Place an outbound call from one of your Twilio phone numbers to a US,<br/>
        /// Canada or Japan destination. A domestic trunk 0 after +81 (e.g.<br/>
        /// +81080...) is accepted and normalized to E.164 (+8180...). Returns<br/>
        /// immediately with the session queued for<br/>
        /// dialing; subscribe to the `phone_call.dial_finished` webhook or poll<br/>
        /// `GET /v1/agent/sessions/{session_id}` for the dial outcome. Ringing is<br/>
        /// never billed — metering starts when the callee answers.<br/>
        /// Errors carry a machine-readable `reason` (e.g. `destination_not_allowed`,<br/>
        /// `insufficient_credit`, `daily_limit_exceeded`,<br/>
        /// `concurrency_limit_exceeded`).
        /// </summary>
        /// <param name="idempotencyKey">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="phoneNumberId">
        /// The team-owned number to dial from (twilio provider only).
        /// </param>
        /// <param name="toNumber">
        /// Destination in E.164, e.g. +14155550123.
        /// </param>
        /// <param name="dynamicVariables">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="overrides">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentPhoneCallsResponse> CreateAgentPhoneCallsAsync(
            string agentId,
            string phoneNumberId,
            string toNumber,
            string? idempotencyKey = default,
            object? dynamicVariables = default,
            global::FishAudio.AgentSessionOverridesPayload? overrides = default,
            object? metadata = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}