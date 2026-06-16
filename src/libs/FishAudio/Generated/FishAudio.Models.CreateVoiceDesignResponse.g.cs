
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceDesignResponse
    {
        /// <summary>
        /// Generated voice candidates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate> Candidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceDesignResponse" /> class.
        /// </summary>
        /// <param name="candidates">
        /// Generated voice candidates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceDesignResponse(
            global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate> candidates)
        {
            this.Candidates = candidates ?? throw new global::System.ArgumentNullException(nameof(candidates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceDesignResponse" /> class.
        /// </summary>
        public CreateVoiceDesignResponse()
        {
        }

    }
}