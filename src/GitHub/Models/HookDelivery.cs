// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Delivery made by a webhook.
    /// </summary>
    public class HookDelivery : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The type of activity for the event that triggered the delivery.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Action { get; set; }
#nullable restore
#else
        public string Action { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Time when the delivery was delivered.</summary>
        public DateTimeOffset? DeliveredAt { get; set; }
        /// <summary>Time spent delivering.</summary>
        public double? Duration { get; set; }
        /// <summary>The event that triggered the delivery.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Guid { get; set; }
#nullable restore
#else
        public string Guid { get; set; }
#endif
        /// <summary>Unique identifier of the delivery.</summary>
        public int? Id { get; set; }
        /// <summary>The id of the GitHub App installation associated with this event.</summary>
        public int? InstallationId { get; set; }
        /// <summary>Whether the delivery is a redelivery.</summary>
        public bool? Redelivery { get; set; }
        /// <summary>The id of the repository associated with this event.</summary>
        public int? RepositoryId { get; set; }
        /// <summary>The request property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HookDelivery_request? Request { get; set; }
#nullable restore
#else
        public HookDelivery_request Request { get; set; }
#endif
        /// <summary>The response property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HookDelivery_response? Response { get; set; }
#nullable restore
#else
        public HookDelivery_response Response { get; set; }
#endif
        /// <summary>Description of the status of the attempted delivery</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>Status code received when delivery was made.</summary>
        public int? StatusCode { get; set; }
        /// <summary>The URL target of the delivery.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="HookDelivery"/> and sets the default values.
        /// </summary>
        public HookDelivery()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HookDelivery"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HookDelivery CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HookDelivery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"action", n => { Action = n.GetStringValue(); } },
                {"delivered_at", n => { DeliveredAt = n.GetDateTimeOffsetValue(); } },
                {"duration", n => { Duration = n.GetDoubleValue(); } },
                {"event", n => { Event = n.GetStringValue(); } },
                {"guid", n => { Guid = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"installation_id", n => { InstallationId = n.GetIntValue(); } },
                {"redelivery", n => { Redelivery = n.GetBoolValue(); } },
                {"repository_id", n => { RepositoryId = n.GetIntValue(); } },
                {"request", n => { Request = n.GetObjectValue<HookDelivery_request>(HookDelivery_request.CreateFromDiscriminatorValue); } },
                {"response", n => { Response = n.GetObjectValue<HookDelivery_response>(HookDelivery_response.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"status_code", n => { StatusCode = n.GetIntValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("action", Action);
            writer.WriteDateTimeOffsetValue("delivered_at", DeliveredAt);
            writer.WriteDoubleValue("duration", Duration);
            writer.WriteStringValue("event", Event);
            writer.WriteStringValue("guid", Guid);
            writer.WriteIntValue("id", Id);
            writer.WriteIntValue("installation_id", InstallationId);
            writer.WriteBoolValue("redelivery", Redelivery);
            writer.WriteIntValue("repository_id", RepositoryId);
            writer.WriteObjectValue<HookDelivery_request>("request", Request);
            writer.WriteObjectValue<HookDelivery_response>("response", Response);
            writer.WriteStringValue("status", Status);
            writer.WriteIntValue("status_code", StatusCode);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
