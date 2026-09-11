#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GetTtsLiveWithTimestampResponse : global::System.IEquatable<GetTtsLiveWithTimestampResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent? Event { get; }

        /// <summary>
        /// One audio chunk plus the latest word-level alignment snapshot. Concatenate every `audio` payload in arrival order to reconstruct the complete audio. `alignment` is the cumulative snapshot for `chunk_seq`: replace the stored alignment for that chunk instead of appending to it. Segment times are relative to the chunk, so the absolute time of a word is `chunk_audio_offset_sec + segment.start`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::FishAudio.TTSLiveWithTimestampAudioEvent? Audio { get; init; }
#else
        public global::FishAudio.TTSLiveWithTimestampAudioEvent? Audio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::FishAudio.TTSLiveWithTimestampAudioEvent? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveWithTimestampAudioEvent PickAudio() => IsAudio
            ? Audio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Audio' but the value was {ToString()}.");

        /// <summary>
        /// Terminal event for the session. `reason: "stop"` follows a clean `stop`; `reason: "error"` reports a server-side failure and carries `message`. No further events arrive for the session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::FishAudio.TTSLiveFinishEvent? Finish { get; init; }
#else
        public global::FishAudio.TTSLiveFinishEvent? Finish { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Finish))]
#endif
        public bool IsFinish => Finish != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFinish(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::FishAudio.TTSLiveFinishEvent? value)
        {
            value = Finish;
            return IsFinish;
        }

        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEvent PickFinish() => IsFinish
            ? Finish!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Finish' but the value was {ToString()}.");

        /// <summary>
        /// Request-level failure raised before or instead of synthesis — an invalid `start` request, a missing voice reference, or a concurrency refusal. The socket closes afterwards.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::FishAudio.TTSLiveErrorEvent? Error { get; init; }
#else
        public global::FishAudio.TTSLiveErrorEvent? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::FishAudio.TTSLiveErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveErrorEvent PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetTtsLiveWithTimestampResponse(global::FishAudio.TTSLiveWithTimestampAudioEvent value) => new GetTtsLiveWithTimestampResponse((global::FishAudio.TTSLiveWithTimestampAudioEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::FishAudio.TTSLiveWithTimestampAudioEvent?(GetTtsLiveWithTimestampResponse @this) => @this.Audio;

        /// <summary>
        ///
        /// </summary>
        public GetTtsLiveWithTimestampResponse(global::FishAudio.TTSLiveWithTimestampAudioEvent? value)
        {
            Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetTtsLiveWithTimestampResponse FromAudio(global::FishAudio.TTSLiveWithTimestampAudioEvent? value) => new GetTtsLiveWithTimestampResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetTtsLiveWithTimestampResponse(global::FishAudio.TTSLiveFinishEvent value) => new GetTtsLiveWithTimestampResponse((global::FishAudio.TTSLiveFinishEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::FishAudio.TTSLiveFinishEvent?(GetTtsLiveWithTimestampResponse @this) => @this.Finish;

        /// <summary>
        ///
        /// </summary>
        public GetTtsLiveWithTimestampResponse(global::FishAudio.TTSLiveFinishEvent? value)
        {
            Finish = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetTtsLiveWithTimestampResponse FromFinish(global::FishAudio.TTSLiveFinishEvent? value) => new GetTtsLiveWithTimestampResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetTtsLiveWithTimestampResponse(global::FishAudio.TTSLiveErrorEvent value) => new GetTtsLiveWithTimestampResponse((global::FishAudio.TTSLiveErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::FishAudio.TTSLiveErrorEvent?(GetTtsLiveWithTimestampResponse @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public GetTtsLiveWithTimestampResponse(global::FishAudio.TTSLiveErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetTtsLiveWithTimestampResponse FromError(global::FishAudio.TTSLiveErrorEvent? value) => new GetTtsLiveWithTimestampResponse(value);

        /// <summary>
        ///
        /// </summary>
        public GetTtsLiveWithTimestampResponse(
            global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent? @event,
            global::FishAudio.TTSLiveWithTimestampAudioEvent? audio,
            global::FishAudio.TTSLiveFinishEvent? finish,
            global::FishAudio.TTSLiveErrorEvent? error
            )
        {
            Event = @event;

            Audio = audio;
            Finish = finish;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            Finish as object ??
            Audio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Audio?.ToString() ??
            Finish?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAudio && !IsFinish && !IsError || !IsAudio && IsFinish && !IsError || !IsAudio && !IsFinish && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::FishAudio.TTSLiveWithTimestampAudioEvent, TResult>? audio = null,
            global::System.Func<global::FishAudio.TTSLiveFinishEvent, TResult>? finish = null,
            global::System.Func<global::FishAudio.TTSLiveErrorEvent, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsFinish && finish != null)
            {
                return finish(Finish!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::FishAudio.TTSLiveWithTimestampAudioEvent>? audio = null,

            global::System.Action<global::FishAudio.TTSLiveFinishEvent>? finish = null,

            global::System.Action<global::FishAudio.TTSLiveErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsFinish)
            {
                finish?.Invoke(Finish!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::FishAudio.TTSLiveWithTimestampAudioEvent>? audio = null,
            global::System.Action<global::FishAudio.TTSLiveFinishEvent>? finish = null,
            global::System.Action<global::FishAudio.TTSLiveErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsFinish)
            {
                finish?.Invoke(Finish!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Audio,
                typeof(global::FishAudio.TTSLiveWithTimestampAudioEvent),
                Finish,
                typeof(global::FishAudio.TTSLiveFinishEvent),
                Error,
                typeof(global::FishAudio.TTSLiveErrorEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetTtsLiveWithTimestampResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::FishAudio.TTSLiveWithTimestampAudioEvent?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::FishAudio.TTSLiveFinishEvent?>.Default.Equals(Finish, other.Finish) &&
                global::System.Collections.Generic.EqualityComparer<global::FishAudio.TTSLiveErrorEvent?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GetTtsLiveWithTimestampResponse obj1, GetTtsLiveWithTimestampResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetTtsLiveWithTimestampResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetTtsLiveWithTimestampResponse obj1, GetTtsLiveWithTimestampResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetTtsLiveWithTimestampResponse o && Equals(o);
        }
    }
}
