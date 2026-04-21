
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Canonical REST API schema for Fish Audio text-to-speech, speech-to-text, wallet, and voice model operations.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IFishAudioClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::FishAudio.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Endpoints for listing, creating, updating, and deleting voice models.
        /// </summary>
        public ModelClient Model { get; }

        /// <summary>
        /// Core Fish Audio REST endpoints for text-to-speech and speech-to-text.
        /// </summary>
        public OpenAPIV1Client OpenAPIV1 { get; }

        /// <summary>
        /// Endpoints for API credit and package information.
        /// </summary>
        public WalletClient Wallet { get; }

    }
}