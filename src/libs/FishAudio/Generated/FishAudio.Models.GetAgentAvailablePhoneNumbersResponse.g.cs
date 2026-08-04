
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentAvailablePhoneNumbersResponse
    {
        /// <summary>
        /// Inventory entries forwarded from the provider (number, region, pricing).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_phone_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> AvailablePhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentAvailablePhoneNumbersResponse" /> class.
        /// </summary>
        /// <param name="availablePhoneNumbers">
        /// Inventory entries forwarded from the provider (number, region, pricing).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentAvailablePhoneNumbersResponse(
            global::System.Collections.Generic.IList<object> availablePhoneNumbers)
        {
            this.AvailablePhoneNumbers = availablePhoneNumbers ?? throw new global::System.ArgumentNullException(nameof(availablePhoneNumbers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentAvailablePhoneNumbersResponse" /> class.
        /// </summary>
        public GetAgentAvailablePhoneNumbersResponse()
        {
        }

    }
}