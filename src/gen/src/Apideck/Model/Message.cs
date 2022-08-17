/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.41.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Apideck.Client.OpenAPIDateConverter;

namespace Apideck.Model
{
    /// <summary>
    /// Message
    /// </summary>
    [DataContract(Name = "Message")]
    public partial class Message : IEquatable<Message>, IValidatableObject
    {
        /// <summary>
        /// Set to sms for SMS messages and mms for MMS messages.
        /// </summary>
        /// <value>Set to sms for SMS messages and mms for MMS messages.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 1,

            /// <summary>
            /// Enum Mms for value: mms
            /// </summary>
            [EnumMember(Value = "mms")]
            Mms = 2

        }


        /// <summary>
        /// Set to sms for SMS messages and mms for MMS messages.
        /// </summary>
        /// <value>Set to sms for SMS messages and mms for MMS messages.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The direction of the message.
        /// </summary>
        /// <value>The direction of the message.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Inbound for value: inbound
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound = 1,

            /// <summary>
            /// Enum OutboundApi for value: outbound-api
            /// </summary>
            [EnumMember(Value = "outbound-api")]
            OutboundApi = 2,

            /// <summary>
            /// Enum OutboundCall for value: outbound-call
            /// </summary>
            [EnumMember(Value = "outbound-call")]
            OutboundCall = 3,

            /// <summary>
            /// Enum OutboundReply for value: outbound-reply
            /// </summary>
            [EnumMember(Value = "outbound-reply")]
            OutboundReply = 4,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 5

        }


        /// <summary>
        /// The direction of the message.
        /// </summary>
        /// <value>The direction of the message.</value>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        /// Returns false as Direction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDirection()
        {
            return false;
        }
        /// <summary>
        /// Status of the delivery of the message.
        /// </summary>
        /// <value>Status of the delivery of the message.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Accepted for value: accepted
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted = 1,

            /// <summary>
            /// Enum Scheduled for value: scheduled
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled = 2,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 3,

            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 4,

            /// <summary>
            /// Enum Sending for value: sending
            /// </summary>
            [EnumMember(Value = "sending")]
            Sending = 5,

            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 6,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 7,

            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 8,

            /// <summary>
            /// Enum Undelivered for value: undelivered
            /// </summary>
            [EnumMember(Value = "undelivered")]
            Undelivered = 9,

            /// <summary>
            /// Enum Receiving for value: receiving
            /// </summary>
            [EnumMember(Value = "receiving")]
            Receiving = 10,

            /// <summary>
            /// Enum Received for value: received
            /// </summary>
            [EnumMember(Value = "received")]
            Received = 11,

            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 12

        }


        /// <summary>
        /// Status of the delivery of the message.
        /// </summary>
        /// <value>Status of the delivery of the message.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Message() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="from">The phone number that initiated the message. (required).</param>
        /// <param name="to">The phone number that received the message. (required).</param>
        /// <param name="subject">subject.</param>
        /// <param name="body">The message text. (required).</param>
        /// <param name="type">Set to sms for SMS messages and mms for MMS messages..</param>
        /// <param name="scheduledAt">The scheduled date and time of the message..</param>
        /// <param name="webhookUrl">Define a webhook to receive delivery notifications..</param>
        /// <param name="reference">A client reference..</param>
        /// <param name="price">price.</param>
        /// <param name="error">error.</param>
        /// <param name="messagingServiceId">The ID of the Messaging Service used with the message. In case of Plivo this links to the Powerpack ID..</param>
        public Message(string from = default(string), string to = default(string), string subject = default(string), string body = default(string), TypeEnum? type = default(TypeEnum?), DateTime scheduledAt = default(DateTime), string webhookUrl = default(string), string reference = default(string), Price price = default(Price), Error error = default(Error), string messagingServiceId = default(string))
        {
            // to ensure "from" is required (not null)
            if (from == null) {
                throw new ArgumentNullException("from is a required property for Message and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null) {
                throw new ArgumentNullException("to is a required property for Message and cannot be null");
            }
            this.To = to;
            // to ensure "body" is required (not null)
            if (body == null) {
                throw new ArgumentNullException("body is a required property for Message and cannot be null");
            }
            this.Body = body;
            this.Subject = subject;
            this.Type = type;
            this.ScheduledAt = scheduledAt;
            this.WebhookUrl = webhookUrl;
            this.Reference = reference;
            this.Price = price;
            this.Error = error;
            this.MessagingServiceId = messagingServiceId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The phone number that initiated the message.
        /// </summary>
        /// <value>The phone number that initiated the message.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// The phone number that received the message.
        /// </summary>
        /// <value>The phone number that received the message.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// The message text.
        /// </summary>
        /// <value>The message text.</value>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// The number of units that make up the complete message. Messages can be split up due to the constraints of the message size.
        /// </summary>
        /// <value>The number of units that make up the complete message. Messages can be split up due to the constraints of the message size.</value>
        [DataMember(Name = "number_of_units", EmitDefaultValue = false)]
        public int NumberOfUnits { get; private set; }

        /// <summary>
        /// Returns false as NumberOfUnits should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumberOfUnits()
        {
            return false;
        }
        /// <summary>
        /// The number of media files associated with the message.
        /// </summary>
        /// <value>The number of media files associated with the message.</value>
        [DataMember(Name = "number_of_media_files", EmitDefaultValue = false)]
        public int NumberOfMediaFiles { get; private set; }

        /// <summary>
        /// Returns false as NumberOfMediaFiles should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumberOfMediaFiles()
        {
            return false;
        }
        /// <summary>
        /// The scheduled date and time of the message.
        /// </summary>
        /// <value>The scheduled date and time of the message.</value>
        [DataMember(Name = "scheduled_at", EmitDefaultValue = false)]
        public DateTime ScheduledAt { get; set; }

        /// <summary>
        /// The date and time that the message was sent
        /// </summary>
        /// <value>The date and time that the message was sent</value>
        [DataMember(Name = "sent_at", EmitDefaultValue = false)]
        public DateTime SentAt { get; private set; }

        /// <summary>
        /// Returns false as SentAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSentAt()
        {
            return false;
        }
        /// <summary>
        /// Define a webhook to receive delivery notifications.
        /// </summary>
        /// <value>Define a webhook to receive delivery notifications.</value>
        [DataMember(Name = "webhook_url", EmitDefaultValue = false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// A client reference.
        /// </summary>
        /// <value>A client reference.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public Price Price { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public Error Error { get; set; }

        /// <summary>
        /// The ID of the Messaging Service used with the message. In case of Plivo this links to the Powerpack ID.
        /// </summary>
        /// <value>The ID of the Messaging Service used with the message. In case of Plivo this links to the Powerpack ID.</value>
        [DataMember(Name = "messaging_service_id", EmitDefaultValue = false)]
        public string MessagingServiceId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updated_by", EmitDefaultValue = true)]
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// Returns false as UpdatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = true)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  NumberOfMediaFiles: ").Append(NumberOfMediaFiles).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  SentAt: ").Append(SentAt).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  MessagingServiceId: ").Append(MessagingServiceId).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="input">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    this.NumberOfUnits.Equals(input.NumberOfUnits)
                ) && 
                (
                    this.NumberOfMediaFiles == input.NumberOfMediaFiles ||
                    this.NumberOfMediaFiles.Equals(input.NumberOfMediaFiles)
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.SentAt == input.SentAt ||
                    (this.SentAt != null &&
                    this.SentAt.Equals(input.SentAt))
                ) && 
                (
                    this.WebhookUrl == input.WebhookUrl ||
                    (this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(input.WebhookUrl))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.MessagingServiceId == input.MessagingServiceId ||
                    (this.MessagingServiceId != null &&
                    this.MessagingServiceId.Equals(input.MessagingServiceId))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfUnits.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfMediaFiles.GetHashCode();
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.ScheduledAt != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledAt.GetHashCode();
                }
                if (this.SentAt != null)
                {
                    hashCode = (hashCode * 59) + this.SentAt.GetHashCode();
                }
                if (this.WebhookUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookUrl.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.MessagingServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.MessagingServiceId.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Body (string) maxLength
            if (this.Body != null && this.Body.Length > 1600)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Body, length must be less than 1600.", new [] { "Body" });
            }

            yield break;
        }
    }

}
