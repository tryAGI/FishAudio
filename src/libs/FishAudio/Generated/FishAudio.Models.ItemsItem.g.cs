#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ItemsItem : global::System.IEquatable<ItemsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType? Type { get; }

        /// <summary>
        /// One transcript message; system messages never surface here.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::FishAudio.AgentSessionMessageItem? Message { get; init; }
#else
        public global::FishAudio.AgentSessionMessageItem? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::FishAudio.AgentSessionMessageItem? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::FishAudio.AgentSessionMessageItem PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// Tool invocation, mirroring the realtime `tool.started` event; `call_id`<br/>
        /// matches the SDK event's callId, so live UIs and history line up.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::FishAudio.AgentSessionToolCallItem? ToolCall { get; init; }
#else
        public global::FishAudio.AgentSessionToolCallItem? ToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCall))]
#endif
        public bool IsToolCall => ToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::FishAudio.AgentSessionToolCallItem? value)
        {
            value = ToolCall;
            return IsToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::FishAudio.AgentSessionToolCallItem PickToolCall() => IsToolCall
            ? ToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCall' but the value was {ToString()}.");

        /// <summary>
        /// Tool outcome (`tool.completed`/`tool.failed` twin). A call that never<br/>
        /// resolved (session died mid-flight) has no result item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::FishAudio.AgentSessionToolResultItem? ToolResult { get; init; }
#else
        public global::FishAudio.AgentSessionToolResultItem? ToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResult))]
#endif
        public bool IsToolResult => ToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::FishAudio.AgentSessionToolResultItem? value)
        {
            value = ToolResult;
            return IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItem PickToolResult() => IsToolResult
            ? ToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolResult' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::FishAudio.AgentSessionMessageItem value) => new ItemsItem((global::FishAudio.AgentSessionMessageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::FishAudio.AgentSessionMessageItem?(ItemsItem @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::FishAudio.AgentSessionMessageItem? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem FromMessage(global::FishAudio.AgentSessionMessageItem? value) => new ItemsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::FishAudio.AgentSessionToolCallItem value) => new ItemsItem((global::FishAudio.AgentSessionToolCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::FishAudio.AgentSessionToolCallItem?(ItemsItem @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::FishAudio.AgentSessionToolCallItem? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem FromToolCall(global::FishAudio.AgentSessionToolCallItem? value) => new ItemsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::FishAudio.AgentSessionToolResultItem value) => new ItemsItem((global::FishAudio.AgentSessionToolResultItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::FishAudio.AgentSessionToolResultItem?(ItemsItem @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::FishAudio.AgentSessionToolResultItem? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem FromToolResult(global::FishAudio.AgentSessionToolResultItem? value) => new ItemsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(
            global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType? type,
            global::FishAudio.AgentSessionMessageItem? message,
            global::FishAudio.AgentSessionToolCallItem? toolCall,
            global::FishAudio.AgentSessionToolResultItem? toolResult
            )
        {
            Type = type;

            Message = message;
            ToolCall = toolCall;
            ToolResult = toolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolResult as object ??
            ToolCall as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            ToolCall?.ToString() ??
            ToolResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsToolCall && !IsToolResult || !IsMessage && IsToolCall && !IsToolResult || !IsMessage && !IsToolCall && IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::FishAudio.AgentSessionMessageItem, TResult>? message = null,
            global::System.Func<global::FishAudio.AgentSessionToolCallItem, TResult>? toolCall = null,
            global::System.Func<global::FishAudio.AgentSessionToolResultItem, TResult>? toolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsToolCall && toolCall != null)
            {
                return toolCall(ToolCall!);
            }
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::FishAudio.AgentSessionMessageItem>? message = null,

            global::System.Action<global::FishAudio.AgentSessionToolCallItem>? toolCall = null,

            global::System.Action<global::FishAudio.AgentSessionToolResultItem>? toolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::FishAudio.AgentSessionMessageItem>? message = null,
            global::System.Action<global::FishAudio.AgentSessionToolCallItem>? toolCall = null,
            global::System.Action<global::FishAudio.AgentSessionToolResultItem>? toolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::FishAudio.AgentSessionMessageItem),
                ToolCall,
                typeof(global::FishAudio.AgentSessionToolCallItem),
                ToolResult,
                typeof(global::FishAudio.AgentSessionToolResultItem),
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
        public bool Equals(ItemsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::FishAudio.AgentSessionMessageItem?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::FishAudio.AgentSessionToolCallItem?>.Default.Equals(ToolCall, other.ToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::FishAudio.AgentSessionToolResultItem?>.Default.Equals(ToolResult, other.ToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemsItem obj1, ItemsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemsItem obj1, ItemsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemsItem o && Equals(o);
        }
    }
}
