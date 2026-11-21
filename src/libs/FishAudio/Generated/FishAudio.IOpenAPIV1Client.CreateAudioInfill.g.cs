#nullable enable

namespace FishAudio
{
    public partial interface IOpenAPIV1Client
    {
        /// <summary>
        /// Audio Infill<br/>
        /// Regenerate part of a recording with drama-3 and get the whole take back.<br/>
        /// Use it to apply a script change to existing audio without re-recording it:<br/>
        /// send the take, the full revised `transcript` and the range to replace.<br/>
        /// drama-3 regenerates that range in the speaker's voice, taken from the audio<br/>
        /// around it, and returns the take with the new span in place.<br/>
        /// A request takes one of two shapes. Mixing them is a 400.<br/>
        /// ## Edit a take<br/>
        /// Send `audio` with where the span to replace starts and ends. Frames<br/>
        /// `[prefix_frames, suffix_frames)` are regenerated; the audio before and after<br/>
        /// them is kept.<br/>
        /// - Give each position in frames (`prefix_frames`, `suffix_frames`) or in<br/>
        ///   seconds (`prefix_seconds`, `suffix_seconds`). Each side takes one of the<br/>
        ///   two; both for the same side is a 400, and so is a side left out.<br/>
        /// - Positions are absolute, counted from the start of the take, at 44100 /<br/>
        ///   2048 (about 21.53) frames per second. Seconds are rounded to the nearest<br/>
        ///   frame: `frames = round(seconds × 44100 / 2048)`.<br/>
        /// - `prefix_frames` equal to `suffix_frames` inserts new speech at that point.<br/>
        /// - Some original audio has to stay: `prefix_frames` 0 together with<br/>
        ///   `suffix_frames` at the end of the take is a 400. For the best results keep<br/>
        ///   at least 0.75 s on each side and replace at least 0.2 s.<br/>
        /// ## Join two clips<br/>
        /// Send `prefix_audio` and, optionally, `suffix_audio`. drama-3 generates the<br/>
        /// speech between them; with `prefix_audio` alone it continues the clip. No<br/>
        /// positions are needed. `suffix_audio` without `prefix_audio` is a 400.<br/>
        /// ## Length of the new span<br/>
        /// The model decides how long the regenerated span is, up to 1024 frames<br/>
        /// (about 47 s). There is no way to request an exact length yet, so the span<br/>
        /// can come out shorter or longer than the speech it replaces.<br/>
        /// ## Response<br/>
        /// The whole take as one audio file in `format`. The kept parts are<br/>
        /// re-synthesized together with the new span rather than copied byte for byte.<br/>
        /// Send `Accept: text/event-stream` to receive server-sent events instead:<br/>
        /// `start` (with `middle_start_seconds`), then `audio.delta` events whose<br/>
        /// base64 `audio` fields concatenate into the same file, then `done` (with<br/>
        /// `output_frames`, `middle_end_seconds` and `total_seconds`), then `[DONE]`.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/audio/infill \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'model: drama-3' \<br/>
        ///   --form 'audio=@take.wav' \<br/>
        ///   --form-string 'transcript=Next, load the wafer into chamber B and run the standard CVD recipe.' \<br/>
        ///   --form 'prefix_frames=45' \<br/>
        ///   --form 'suffix_frames=62' \<br/>
        ///   --form 'format=mp3' \<br/>
        ///   --output edited.mp3
        /// </remarks>
        global::System.Threading.Tasks.Task CreateAudioInfillAsync(

            global::FishAudio.CreateAudioInfillRequest request,
            string model = "drama-3",
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Infill<br/>
        /// Regenerate part of a recording with drama-3 and get the whole take back.<br/>
        /// Use it to apply a script change to existing audio without re-recording it:<br/>
        /// send the take, the full revised `transcript` and the range to replace.<br/>
        /// drama-3 regenerates that range in the speaker's voice, taken from the audio<br/>
        /// around it, and returns the take with the new span in place.<br/>
        /// A request takes one of two shapes. Mixing them is a 400.<br/>
        /// ## Edit a take<br/>
        /// Send `audio` with where the span to replace starts and ends. Frames<br/>
        /// `[prefix_frames, suffix_frames)` are regenerated; the audio before and after<br/>
        /// them is kept.<br/>
        /// - Give each position in frames (`prefix_frames`, `suffix_frames`) or in<br/>
        ///   seconds (`prefix_seconds`, `suffix_seconds`). Each side takes one of the<br/>
        ///   two; both for the same side is a 400, and so is a side left out.<br/>
        /// - Positions are absolute, counted from the start of the take, at 44100 /<br/>
        ///   2048 (about 21.53) frames per second. Seconds are rounded to the nearest<br/>
        ///   frame: `frames = round(seconds × 44100 / 2048)`.<br/>
        /// - `prefix_frames` equal to `suffix_frames` inserts new speech at that point.<br/>
        /// - Some original audio has to stay: `prefix_frames` 0 together with<br/>
        ///   `suffix_frames` at the end of the take is a 400. For the best results keep<br/>
        ///   at least 0.75 s on each side and replace at least 0.2 s.<br/>
        /// ## Join two clips<br/>
        /// Send `prefix_audio` and, optionally, `suffix_audio`. drama-3 generates the<br/>
        /// speech between them; with `prefix_audio` alone it continues the clip. No<br/>
        /// positions are needed. `suffix_audio` without `prefix_audio` is a 400.<br/>
        /// ## Length of the new span<br/>
        /// The model decides how long the regenerated span is, up to 1024 frames<br/>
        /// (about 47 s). There is no way to request an exact length yet, so the span<br/>
        /// can come out shorter or longer than the speech it replaces.<br/>
        /// ## Response<br/>
        /// The whole take as one audio file in `format`. The kept parts are<br/>
        /// re-synthesized together with the new span rather than copied byte for byte.<br/>
        /// Send `Accept: text/event-stream` to receive server-sent events instead:<br/>
        /// `start` (with `middle_start_seconds`), then `audio.delta` events whose<br/>
        /// base64 `audio` fields concatenate into the same file, then `done` (with<br/>
        /// `output_frames`, `middle_end_seconds` and `total_seconds`), then `[DONE]`.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/audio/infill \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'model: drama-3' \<br/>
        ///   --form 'audio=@take.wav' \<br/>
        ///   --form-string 'transcript=Next, load the wafer into chamber B and run the standard CVD recipe.' \<br/>
        ///   --form 'prefix_frames=45' \<br/>
        ///   --form 'suffix_frames=62' \<br/>
        ///   --form 'format=mp3' \<br/>
        ///   --output edited.mp3
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> CreateAudioInfillAsResponseAsync(

            global::FishAudio.CreateAudioInfillRequest request,
            string model = "drama-3",
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Infill<br/>
        /// Regenerate part of a recording with drama-3 and get the whole take back.<br/>
        /// Use it to apply a script change to existing audio without re-recording it:<br/>
        /// send the take, the full revised `transcript` and the range to replace.<br/>
        /// drama-3 regenerates that range in the speaker's voice, taken from the audio<br/>
        /// around it, and returns the take with the new span in place.<br/>
        /// A request takes one of two shapes. Mixing them is a 400.<br/>
        /// ## Edit a take<br/>
        /// Send `audio` with where the span to replace starts and ends. Frames<br/>
        /// `[prefix_frames, suffix_frames)` are regenerated; the audio before and after<br/>
        /// them is kept.<br/>
        /// - Give each position in frames (`prefix_frames`, `suffix_frames`) or in<br/>
        ///   seconds (`prefix_seconds`, `suffix_seconds`). Each side takes one of the<br/>
        ///   two; both for the same side is a 400, and so is a side left out.<br/>
        /// - Positions are absolute, counted from the start of the take, at 44100 /<br/>
        ///   2048 (about 21.53) frames per second. Seconds are rounded to the nearest<br/>
        ///   frame: `frames = round(seconds × 44100 / 2048)`.<br/>
        /// - `prefix_frames` equal to `suffix_frames` inserts new speech at that point.<br/>
        /// - Some original audio has to stay: `prefix_frames` 0 together with<br/>
        ///   `suffix_frames` at the end of the take is a 400. For the best results keep<br/>
        ///   at least 0.75 s on each side and replace at least 0.2 s.<br/>
        /// ## Join two clips<br/>
        /// Send `prefix_audio` and, optionally, `suffix_audio`. drama-3 generates the<br/>
        /// speech between them; with `prefix_audio` alone it continues the clip. No<br/>
        /// positions are needed. `suffix_audio` without `prefix_audio` is a 400.<br/>
        /// ## Length of the new span<br/>
        /// The model decides how long the regenerated span is, up to 1024 frames<br/>
        /// (about 47 s). There is no way to request an exact length yet, so the span<br/>
        /// can come out shorter or longer than the speech it replaces.<br/>
        /// ## Response<br/>
        /// The whole take as one audio file in `format`. The kept parts are<br/>
        /// re-synthesized together with the new span rather than copied byte for byte.<br/>
        /// Send `Accept: text/event-stream` to receive server-sent events instead:<br/>
        /// `start` (with `middle_start_seconds`), then `audio.delta` events whose<br/>
        /// base64 `audio` fields concatenate into the same file, then `done` (with<br/>
        /// `output_frames`, `middle_end_seconds` and `total_seconds`), then `[DONE]`.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="transcript">
        /// The full text of the result: the kept audio before the change, the new span and the kept audio after it, with the edit already applied. Sent to the model as written, without text normalization.
        /// </param>
        /// <param name="audio">
        /// Edit a take: the whole recording to edit. Requires the start of the span (`prefix_frames` or `prefix_seconds`) and its end (`suffix_frames` or `suffix_seconds`). Do not combine with `prefix_audio` / `suffix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="audioname">
        /// Edit a take: the whole recording to edit. Requires the start of the span (`prefix_frames` or `prefix_seconds`) and its end (`suffix_frames` or `suffix_seconds`). Do not combine with `prefix_audio` / `suffix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prefixFrames">
        /// Edit a take: the frame where the regenerated span starts. Everything before it is kept. A whole number of frames at 44100 / 2048 (about 21.53) frames per second; 0 keeps nothing before the span. Give this or `prefix_seconds`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prefixSeconds">
        /// Edit a take: `prefix_frames` given in seconds from the start of the take, rounded to the nearest frame. Give this or `prefix_frames`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="suffixFrames">
        /// Edit a take: the frame where the regenerated span ends and the kept audio resumes. Equal to `prefix_frames` inserts new speech at that point; the take's length keeps nothing after the span. Give this or `suffix_seconds`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="suffixSeconds">
        /// Edit a take: `suffix_frames` given in seconds from the start of the take, rounded to the nearest frame. Give this or `suffix_frames`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prefixAudio">
        /// Join two clips: the clip before the generated speech. Alone, the model continues it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prefixAudioname">
        /// Join two clips: the clip before the generated speech. Alone, the model continues it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="suffixAudio">
        /// Join two clips: the clip after the generated speech. Requires `prefix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="suffixAudioname">
        /// Join two clips: the clip after the generated speech. Requires `prefix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAudioInfillAsync(
            string transcript,
            string model = "drama-3",
            byte[]? audio = default,
            string? audioname = default,
            int? prefixFrames = default,
            double? prefixSeconds = default,
            int? suffixFrames = default,
            double? suffixSeconds = default,
            byte[]? prefixAudio = default,
            string? prefixAudioname = default,
            byte[]? suffixAudio = default,
            string? suffixAudioname = default,
            global::FishAudio.CreateAudioInfillRequestFormat? format = default,
            int? sampleRate = default,
            int? mp3Bitrate = default,
            int? opusBitrate = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}