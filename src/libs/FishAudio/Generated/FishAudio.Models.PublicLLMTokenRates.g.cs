
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicLLMTokenRates
    {
        /// <summary>
        /// Input tokens neither read from nor written to the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Input tokens read from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CacheRead { get; set; }

        /// <summary>
        /// Input tokens written to the prompt cache. Null when the model has no cache write charge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_5m")]
        public string? CacheWrite5m { get; set; }

        /// <summary>
        /// Output tokens, reasoning tokens included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMTokenRates" /> class.
        /// </summary>
        /// <param name="input">
        /// Input tokens neither read from nor written to the prompt cache.
        /// </param>
        /// <param name="cacheRead">
        /// Input tokens read from the prompt cache.
        /// </param>
        /// <param name="output">
        /// Output tokens, reasoning tokens included.
        /// </param>
        /// <param name="cacheWrite5m">
        /// Input tokens written to the prompt cache. Null when the model has no cache write charge.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicLLMTokenRates(
            string input,
            string cacheRead,
            string output,
            string? cacheWrite5m)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.CacheRead = cacheRead ?? throw new global::System.ArgumentNullException(nameof(cacheRead));
            this.CacheWrite5m = cacheWrite5m;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMTokenRates" /> class.
        /// </summary>
        public PublicLLMTokenRates()
        {
        }

    }
}