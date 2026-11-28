
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAudioInfillRequest
    {
        /// <summary>
        /// The full text of the result: the kept audio before the change, the new span and the kept audio after it, with the edit already applied. Sent to the model as written, without text normalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Edit a take: the whole recording to edit. Requires the start of the span (`prefix_frames` or `prefix_seconds`) and its end (`suffix_frames` or `suffix_seconds`). Do not combine with `prefix_audio` / `suffix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public byte[]? Audio { get; set; }

        /// <summary>
        /// Edit a take: the whole recording to edit. Requires the start of the span (`prefix_frames` or `prefix_seconds`) and its end (`suffix_frames` or `suffix_seconds`). Do not combine with `prefix_audio` / `suffix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        public string? Audioname { get; set; }

        /// <summary>
        /// Edit a take: the frame where the regenerated span starts. Everything before it is kept. A whole number of frames at 44100 / 2048 (about 21.53) frames per second; 0 keeps nothing before the span. Give this or `prefix_seconds`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_frames")]
        public int? PrefixFrames { get; set; }

        /// <summary>
        /// Edit a take: `prefix_frames` given in seconds from the start of the take, rounded to the nearest frame. Give this or `prefix_frames`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_seconds")]
        public double? PrefixSeconds { get; set; }

        /// <summary>
        /// Edit a take: the frame where the regenerated span ends and the kept audio resumes. Equal to `prefix_frames` inserts new speech at that point; the take's length keeps nothing after the span. Give this or `suffix_seconds`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix_frames")]
        public int? SuffixFrames { get; set; }

        /// <summary>
        /// Edit a take: `suffix_frames` given in seconds from the start of the take, rounded to the nearest frame. Give this or `suffix_frames`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix_seconds")]
        public double? SuffixSeconds { get; set; }

        /// <summary>
        /// Join two clips: the clip before the generated speech. Alone, the model continues it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_audio")]
        public byte[]? PrefixAudio { get; set; }

        /// <summary>
        /// Join two clips: the clip before the generated speech. Alone, the model continues it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_audioname")]
        public string? PrefixAudioname { get; set; }

        /// <summary>
        /// Join two clips: the clip after the generated speech. Requires `prefix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix_audio")]
        public byte[]? SuffixAudio { get; set; }

        /// <summary>
        /// Join two clips: the clip after the generated speech. Requires `prefix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix_audioname")]
        public string? SuffixAudioname { get; set; }

        /// <summary>
        /// Output audio format.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.CreateAudioInfillRequestFormatJsonConverter))]
        public global::FishAudio.CreateAudioInfillRequestFormat? Format { get; set; }

        /// <summary>
        /// Audio sample rate in Hz. When null, uses the format's default (44100 Hz for most formats, 48000 Hz for opus).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// MP3 bitrate in kbps. Only applies when format is mp3.<br/>
        /// Default Value: 128
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mp3_bitrate")]
        public int? Mp3Bitrate { get; set; }

        /// <summary>
        /// Opus bitrate in bps. -1000 for automatic. Only applies when format is opus.<br/>
        /// Default Value: -1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opus_bitrate")]
        public int? OpusBitrate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioInfillRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioInfillRequest(
            string transcript,
            byte[]? audio,
            string? audioname,
            int? prefixFrames,
            double? prefixSeconds,
            int? suffixFrames,
            double? suffixSeconds,
            byte[]? prefixAudio,
            string? prefixAudioname,
            byte[]? suffixAudio,
            string? suffixAudioname,
            global::FishAudio.CreateAudioInfillRequestFormat? format,
            int? sampleRate,
            int? mp3Bitrate,
            int? opusBitrate)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Audio = audio;
            this.Audioname = audioname;
            this.PrefixFrames = prefixFrames;
            this.PrefixSeconds = prefixSeconds;
            this.SuffixFrames = suffixFrames;
            this.SuffixSeconds = suffixSeconds;
            this.PrefixAudio = prefixAudio;
            this.PrefixAudioname = prefixAudioname;
            this.SuffixAudio = suffixAudio;
            this.SuffixAudioname = suffixAudioname;
            this.Format = format;
            this.SampleRate = sampleRate;
            this.Mp3Bitrate = mp3Bitrate;
            this.OpusBitrate = opusBitrate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioInfillRequest" /> class.
        /// </summary>
        public CreateAudioInfillRequest()
        {
        }

    }
}