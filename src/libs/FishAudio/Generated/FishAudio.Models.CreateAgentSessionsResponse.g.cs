
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Wire twin of @fishaudio/agent-protocol `SessionToken` (session.ts); keep in sync.
    /// </summary>
    public sealed partial class CreateAgentSessionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"livekit"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public string Transport { get; set; } = "livekit";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LivekitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionsResponse" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="expiresAt"></param>
        /// <param name="maxDurationSeconds"></param>
        /// <param name="livekitUrl"></param>
        /// <param name="token"></param>
        /// <param name="transport"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentSessionsResponse(
            string sessionId,
            string expiresAt,
            int maxDurationSeconds,
            string livekitUrl,
            string token,
            string transport = "livekit")
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.MaxDurationSeconds = maxDurationSeconds;
            this.Transport = transport;
            this.LivekitUrl = livekitUrl ?? throw new global::System.ArgumentNullException(nameof(livekitUrl));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionsResponse" /> class.
        /// </summary>
        public CreateAgentSessionsResponse()
        {
        }

    }
}