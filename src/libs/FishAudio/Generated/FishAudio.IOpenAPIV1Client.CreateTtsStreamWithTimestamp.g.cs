#nullable enable

namespace FishAudio
{
    public partial interface IOpenAPIV1Client
    {
        /// <summary>
        /// Text to Speech Stream with Timestamps
        /// </summary>
        /// <param name="model">
        /// Default Value: s2-pro
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --no-buffer --request POST \<br/>
        ///   --url https://api.fish.audio/v1/tts/stream/with-timestamp \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'model: s2-pro' \<br/>
        ///   --data '{<br/>
        ///     "text": "[happy] I can’t believe it’s been this long. It feels like forever since we last really talked. I’ve missed hearing your voice, your stories, even the little things you used to say. How have you been? I’ve thought about calling you so many times, but I never knew where to start. Seeing you again now makes me realize just how much I’ve missed you. We have so much to catch up on, and I don’t even know which part of my life to tell you about first.",<br/>
        ///     "format": "opus",<br/>
        ///     "normalize": true,<br/>
        ///     "temperature": 0.9,<br/>
        ///     "chunk_length": 100,<br/>
        ///     "top_p": 0.9,<br/>
        ///     "latency": "balanced",<br/>
        ///     "sample_rate": 48000,<br/>
        ///     "reference_id": "fbe02f8306fc4d3d915e9871722a39d5"<br/>
        ///   }'
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::FishAudio.CreateTtsStreamWithTimestampResponse> CreateTtsStreamWithTimestampAsync(

            global::FishAudio.TTSStreamWithTimestampRequest request,
            global::FishAudio.CreateTtsStreamWithTimestampModel model = global::FishAudio.CreateTtsStreamWithTimestampModel.S2Pro,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to Speech Stream with Timestamps
        /// </summary>
        /// <param name="model">
        /// Default Value: s2-pro
        /// </param>
        /// <param name="text">
        /// Text to convert to speech.
        /// </param>
        /// <param name="temperature">
        /// Controls expressiveness. Higher is more varied, lower is more consistent.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="topP">
        /// Controls diversity via nucleus sampling.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="references">
        /// Inline voice references for zero-shot cloning. Requires MessagePack (not JSON). For single speaker, provide an array of ReferenceAudio objects. For multiple speakers, provide an array of arrays where each inner array contains references for one speaker. **Multi-speaker is only available with the S2-Pro model.** The speaker index corresponds to the index in reference_id array. Example for multi-speaker: [[{audio, text}], [{audio, text}, {audio, text}]] for 2 speakers where speaker 1 has 2 reference samples.
        /// </param>
        /// <param name="referenceId">
        /// Voice model ID(s) from Fish Audio library or your custom models. For single-speaker synthesis, provide a string. For multi-speaker synthesis (dialogue), provide an array of model IDs. **Multi-speaker is only available with the S2-Pro model.** When using multiple speakers, use speaker tags in your text like `&lt;|speaker:0|&gt;` and `&lt;|speaker:1|&gt;` to indicate speaker changes. Example: `&lt;|speaker:0|&gt;Hello!&lt;|speaker:1|&gt;Hi there!&lt;|speaker:0|&gt;How are you?` with `reference_id: ["speaker-a-id", "speaker-b-id"]`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prosody">
        /// Speed and volume adjustments for the output.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chunkLength">
        /// Text segment size for processing.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="normalize">
        /// Normalizes text for English and Chinese, improving stability for numbers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="format">
        /// Output audio format.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz. When null, uses the format's default (44100 Hz for most formats, 48000 Hz for opus).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mp3Bitrate">
        /// MP3 bitrate in kbps. Only applies when format is mp3.<br/>
        /// Default Value: 128
        /// </param>
        /// <param name="opusBitrate">
        /// Opus bitrate in bps. -1000 for automatic. Only applies when format is opus.<br/>
        /// Default Value: -1000
        /// </param>
        /// <param name="latency">
        /// Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.<br/>
        /// Default Value: normal
        /// </param>
        /// <param name="maxNewTokens">
        /// Maximum audio tokens to generate per text chunk.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalty for repeating audio patterns. Values above 1.0 reduce repetition.<br/>
        /// Default Value: 1.2F
        /// </param>
        /// <param name="minChunkLength">
        /// Minimum characters before splitting into a new chunk.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="conditionOnPreviousChunks">
        /// Use previous audio as context for voice consistency.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="earlyStopThreshold">
        /// Early stopping threshold for batch processing.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::FishAudio.CreateTtsStreamWithTimestampResponse> CreateTtsStreamWithTimestampAsync(
            string text,
            global::FishAudio.CreateTtsStreamWithTimestampModel model = global::FishAudio.CreateTtsStreamWithTimestampModel.S2Pro,
            double? temperature = default,
            double? topP = default,
            global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>? references = default,
            global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? referenceId = default,
            global::FishAudio.ProsodyControl? prosody = default,
            int? chunkLength = default,
            bool? normalize = default,
            global::FishAudio.TTSStreamWithTimestampRequestFormat? format = default,
            int? sampleRate = default,
            int? mp3Bitrate = default,
            int? opusBitrate = default,
            global::FishAudio.TTSStreamWithTimestampRequestLatency? latency = default,
            int? maxNewTokens = default,
            double? repetitionPenalty = default,
            int? minChunkLength = default,
            bool? conditionOnPreviousChunks = default,
            double? earlyStopThreshold = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}