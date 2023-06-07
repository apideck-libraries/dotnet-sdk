/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.7.4
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
    /// OrderPickupDetails
    /// </summary>
    [DataContract(Name = "Order_pickup_details")]
    public partial class OrderPickupDetails : IEquatable<OrderPickupDetails>, IValidatableObject
    {
        /// <summary>
        /// The schedule type of the pickup fulfillment.
        /// </summary>
        /// <value>The schedule type of the pickup fulfillment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScheduleTypeEnum
        {
            /// <summary>
            /// Enum Scheduled for value: scheduled
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled = 1

        }


        /// <summary>
        /// The schedule type of the pickup fulfillment.
        /// </summary>
        /// <value>The schedule type of the pickup fulfillment.</value>
        [DataMember(Name = "schedule_type", EmitDefaultValue = false)]
        public ScheduleTypeEnum? ScheduleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPickupDetails" /> class.
        /// </summary>
        /// <param name="autoCompleteDuration">The duration of time after which an open and accepted pickup fulfillment is automatically moved to the COMPLETED state. The duration must be in RFC 3339 format (for example, &#39;P1W3D&#39;)..</param>
        /// <param name="cancelReason">A description of why the pickup was canceled..</param>
        /// <param name="expiresAt">Indicating when this fulfillment expires if it is not accepted. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). The expiration time can only be set up to 7 days in the future. If &#x60;expires_at&#x60; is not set, this pickup fulfillment is automatically accepted when  placed..</param>
        /// <param name="scheduleType">The schedule type of the pickup fulfillment..</param>
        /// <param name="pickupAt">The timestamp that represents the start of the pickup window. Must be in RFC 3339 timestamp format, e.g.,  \&quot;2016-09-04T23:59:33.123Z\&quot;.  For fulfillments with the schedule type &#x60;ASAP&#x60;, this is automatically set to the current time plus the expected duration to prepare the fulfillment..</param>
        /// <param name="pickupWindowDuration">The window of time in which the order should be picked up after the &#x60;pickup_at&#x60; timestamp. Must be in RFC 3339 duration format, e.g., \&quot;P1W3D\&quot;. Can be used as an informational guideline for merchants..</param>
        /// <param name="prepTimeDuration">The duration of time it takes to prepare this fulfillment. The duration must be in RFC 3339 format (for example, \&quot;P1W3D\&quot;)..</param>
        /// <param name="note">A note meant to provide additional instructions about the pickup fulfillment displayed in the Square Point of Sale application and set by the API..</param>
        /// <param name="placedAt">Indicating when the fulfillment was placed. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;)..</param>
        /// <param name="rejectedAt">Indicating when the fulfillment was rejected. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;)..</param>
        /// <param name="readyAt">Indicating when the fulfillment is marked as ready for pickup. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;)..</param>
        /// <param name="expiredAt">Indicating when the fulfillment expired. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;)..</param>
        /// <param name="pickedUpAt">Indicating when the fulfillment was picked up by the recipient. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;)..</param>
        /// <param name="canceledAt">Indicating when the fulfillment was canceled. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;)..</param>
        /// <param name="isCurbsidePickup">If set to &#x60;true&#x60;, indicates that this pickup order is for curbside pickup, not in-store pickup..</param>
        /// <param name="curbsidePickupDetails">curbsidePickupDetails.</param>
        /// <param name="recipient">recipient.</param>
        public OrderPickupDetails(string autoCompleteDuration = default(string), string cancelReason = default(string), DateTime expiresAt = default(DateTime), ScheduleTypeEnum? scheduleType = default(ScheduleTypeEnum?), DateTime pickupAt = default(DateTime), string pickupWindowDuration = default(string), string prepTimeDuration = default(string), string note = default(string), DateTime placedAt = default(DateTime), DateTime rejectedAt = default(DateTime), DateTime readyAt = default(DateTime), DateTime expiredAt = default(DateTime), DateTime pickedUpAt = default(DateTime), DateTime canceledAt = default(DateTime), bool isCurbsidePickup = default(bool), OrderPickupDetailsCurbsidePickupDetails curbsidePickupDetails = default(OrderPickupDetailsCurbsidePickupDetails), OrderPickupDetailsRecipient recipient = default(OrderPickupDetailsRecipient))
        {
            this.AutoCompleteDuration = autoCompleteDuration;
            this.CancelReason = cancelReason;
            this.ExpiresAt = expiresAt;
            this.ScheduleType = scheduleType;
            this.PickupAt = pickupAt;
            this.PickupWindowDuration = pickupWindowDuration;
            this.PrepTimeDuration = prepTimeDuration;
            this.Note = note;
            this.PlacedAt = placedAt;
            this.RejectedAt = rejectedAt;
            this.ReadyAt = readyAt;
            this.ExpiredAt = expiredAt;
            this.PickedUpAt = pickedUpAt;
            this.CanceledAt = canceledAt;
            this.IsCurbsidePickup = isCurbsidePickup;
            this.CurbsidePickupDetails = curbsidePickupDetails;
            this.Recipient = recipient;
        }

        /// <summary>
        /// Gets or Sets AcceptedAt
        /// </summary>
        [DataMember(Name = "accepted_at", EmitDefaultValue = true)]
        public DateTime? AcceptedAt { get; private set; }

        /// <summary>
        /// Returns false as AcceptedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAcceptedAt()
        {
            return false;
        }
        /// <summary>
        /// The duration of time after which an open and accepted pickup fulfillment is automatically moved to the COMPLETED state. The duration must be in RFC 3339 format (for example, &#39;P1W3D&#39;).
        /// </summary>
        /// <value>The duration of time after which an open and accepted pickup fulfillment is automatically moved to the COMPLETED state. The duration must be in RFC 3339 format (for example, &#39;P1W3D&#39;).</value>
        [DataMember(Name = "auto_complete_duration", EmitDefaultValue = true)]
        public string AutoCompleteDuration { get; set; }

        /// <summary>
        /// A description of why the pickup was canceled.
        /// </summary>
        /// <value>A description of why the pickup was canceled.</value>
        [DataMember(Name = "cancel_reason", EmitDefaultValue = true)]
        public string CancelReason { get; set; }

        /// <summary>
        /// Indicating when this fulfillment expires if it is not accepted. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). The expiration time can only be set up to 7 days in the future. If &#x60;expires_at&#x60; is not set, this pickup fulfillment is automatically accepted when  placed.
        /// </summary>
        /// <value>Indicating when this fulfillment expires if it is not accepted. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). The expiration time can only be set up to 7 days in the future. If &#x60;expires_at&#x60; is not set, this pickup fulfillment is automatically accepted when  placed.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// The timestamp that represents the start of the pickup window. Must be in RFC 3339 timestamp format, e.g.,  \&quot;2016-09-04T23:59:33.123Z\&quot;.  For fulfillments with the schedule type &#x60;ASAP&#x60;, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        /// <value>The timestamp that represents the start of the pickup window. Must be in RFC 3339 timestamp format, e.g.,  \&quot;2016-09-04T23:59:33.123Z\&quot;.  For fulfillments with the schedule type &#x60;ASAP&#x60;, this is automatically set to the current time plus the expected duration to prepare the fulfillment.</value>
        [DataMember(Name = "pickup_at", EmitDefaultValue = false)]
        public DateTime PickupAt { get; set; }

        /// <summary>
        /// The window of time in which the order should be picked up after the &#x60;pickup_at&#x60; timestamp. Must be in RFC 3339 duration format, e.g., \&quot;P1W3D\&quot;. Can be used as an informational guideline for merchants.
        /// </summary>
        /// <value>The window of time in which the order should be picked up after the &#x60;pickup_at&#x60; timestamp. Must be in RFC 3339 duration format, e.g., \&quot;P1W3D\&quot;. Can be used as an informational guideline for merchants.</value>
        [DataMember(Name = "pickup_window_duration", EmitDefaultValue = false)]
        public string PickupWindowDuration { get; set; }

        /// <summary>
        /// The duration of time it takes to prepare this fulfillment. The duration must be in RFC 3339 format (for example, \&quot;P1W3D\&quot;).
        /// </summary>
        /// <value>The duration of time it takes to prepare this fulfillment. The duration must be in RFC 3339 format (for example, \&quot;P1W3D\&quot;).</value>
        [DataMember(Name = "prep_time_duration", EmitDefaultValue = false)]
        public string PrepTimeDuration { get; set; }

        /// <summary>
        /// A note meant to provide additional instructions about the pickup fulfillment displayed in the Square Point of Sale application and set by the API.
        /// </summary>
        /// <value>A note meant to provide additional instructions about the pickup fulfillment displayed in the Square Point of Sale application and set by the API.</value>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Indicating when the fulfillment was placed. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).
        /// </summary>
        /// <value>Indicating when the fulfillment was placed. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).</value>
        [DataMember(Name = "placed_at", EmitDefaultValue = false)]
        public DateTime PlacedAt { get; set; }

        /// <summary>
        /// Indicating when the fulfillment was rejected. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).
        /// </summary>
        /// <value>Indicating when the fulfillment was rejected. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).</value>
        [DataMember(Name = "rejected_at", EmitDefaultValue = false)]
        public DateTime RejectedAt { get; set; }

        /// <summary>
        /// Indicating when the fulfillment is marked as ready for pickup. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).
        /// </summary>
        /// <value>Indicating when the fulfillment is marked as ready for pickup. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).</value>
        [DataMember(Name = "ready_at", EmitDefaultValue = false)]
        public DateTime ReadyAt { get; set; }

        /// <summary>
        /// Indicating when the fulfillment expired. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).
        /// </summary>
        /// <value>Indicating when the fulfillment expired. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).</value>
        [DataMember(Name = "expired_at", EmitDefaultValue = false)]
        public DateTime ExpiredAt { get; set; }

        /// <summary>
        /// Indicating when the fulfillment was picked up by the recipient. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).
        /// </summary>
        /// <value>Indicating when the fulfillment was picked up by the recipient. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).</value>
        [DataMember(Name = "picked_up_at", EmitDefaultValue = false)]
        public DateTime PickedUpAt { get; set; }

        /// <summary>
        /// Indicating when the fulfillment was canceled. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).
        /// </summary>
        /// <value>Indicating when the fulfillment was canceled. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).</value>
        [DataMember(Name = "canceled_at", EmitDefaultValue = false)]
        public DateTime CanceledAt { get; set; }

        /// <summary>
        /// If set to &#x60;true&#x60;, indicates that this pickup order is for curbside pickup, not in-store pickup.
        /// </summary>
        /// <value>If set to &#x60;true&#x60;, indicates that this pickup order is for curbside pickup, not in-store pickup.</value>
        [DataMember(Name = "is_curbside_pickup", EmitDefaultValue = true)]
        public bool IsCurbsidePickup { get; set; }

        /// <summary>
        /// Gets or Sets CurbsidePickupDetails
        /// </summary>
        [DataMember(Name = "curbside_pickup_details", EmitDefaultValue = false)]
        public OrderPickupDetailsCurbsidePickupDetails CurbsidePickupDetails { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", EmitDefaultValue = false)]
        public OrderPickupDetailsRecipient Recipient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderPickupDetails {\n");
            sb.Append("  AcceptedAt: ").Append(AcceptedAt).Append("\n");
            sb.Append("  AutoCompleteDuration: ").Append(AutoCompleteDuration).Append("\n");
            sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  ScheduleType: ").Append(ScheduleType).Append("\n");
            sb.Append("  PickupAt: ").Append(PickupAt).Append("\n");
            sb.Append("  PickupWindowDuration: ").Append(PickupWindowDuration).Append("\n");
            sb.Append("  PrepTimeDuration: ").Append(PrepTimeDuration).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  PlacedAt: ").Append(PlacedAt).Append("\n");
            sb.Append("  RejectedAt: ").Append(RejectedAt).Append("\n");
            sb.Append("  ReadyAt: ").Append(ReadyAt).Append("\n");
            sb.Append("  ExpiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  PickedUpAt: ").Append(PickedUpAt).Append("\n");
            sb.Append("  CanceledAt: ").Append(CanceledAt).Append("\n");
            sb.Append("  IsCurbsidePickup: ").Append(IsCurbsidePickup).Append("\n");
            sb.Append("  CurbsidePickupDetails: ").Append(CurbsidePickupDetails).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
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
            return this.Equals(input as OrderPickupDetails);
        }

        /// <summary>
        /// Returns true if OrderPickupDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderPickupDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPickupDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptedAt == input.AcceptedAt ||
                    (this.AcceptedAt != null &&
                    this.AcceptedAt.Equals(input.AcceptedAt))
                ) && 
                (
                    this.AutoCompleteDuration == input.AutoCompleteDuration ||
                    (this.AutoCompleteDuration != null &&
                    this.AutoCompleteDuration.Equals(input.AutoCompleteDuration))
                ) && 
                (
                    this.CancelReason == input.CancelReason ||
                    (this.CancelReason != null &&
                    this.CancelReason.Equals(input.CancelReason))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.ScheduleType == input.ScheduleType ||
                    this.ScheduleType.Equals(input.ScheduleType)
                ) && 
                (
                    this.PickupAt == input.PickupAt ||
                    (this.PickupAt != null &&
                    this.PickupAt.Equals(input.PickupAt))
                ) && 
                (
                    this.PickupWindowDuration == input.PickupWindowDuration ||
                    (this.PickupWindowDuration != null &&
                    this.PickupWindowDuration.Equals(input.PickupWindowDuration))
                ) && 
                (
                    this.PrepTimeDuration == input.PrepTimeDuration ||
                    (this.PrepTimeDuration != null &&
                    this.PrepTimeDuration.Equals(input.PrepTimeDuration))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.PlacedAt == input.PlacedAt ||
                    (this.PlacedAt != null &&
                    this.PlacedAt.Equals(input.PlacedAt))
                ) && 
                (
                    this.RejectedAt == input.RejectedAt ||
                    (this.RejectedAt != null &&
                    this.RejectedAt.Equals(input.RejectedAt))
                ) && 
                (
                    this.ReadyAt == input.ReadyAt ||
                    (this.ReadyAt != null &&
                    this.ReadyAt.Equals(input.ReadyAt))
                ) && 
                (
                    this.ExpiredAt == input.ExpiredAt ||
                    (this.ExpiredAt != null &&
                    this.ExpiredAt.Equals(input.ExpiredAt))
                ) && 
                (
                    this.PickedUpAt == input.PickedUpAt ||
                    (this.PickedUpAt != null &&
                    this.PickedUpAt.Equals(input.PickedUpAt))
                ) && 
                (
                    this.CanceledAt == input.CanceledAt ||
                    (this.CanceledAt != null &&
                    this.CanceledAt.Equals(input.CanceledAt))
                ) && 
                (
                    this.IsCurbsidePickup == input.IsCurbsidePickup ||
                    this.IsCurbsidePickup.Equals(input.IsCurbsidePickup)
                ) && 
                (
                    this.CurbsidePickupDetails == input.CurbsidePickupDetails ||
                    (this.CurbsidePickupDetails != null &&
                    this.CurbsidePickupDetails.Equals(input.CurbsidePickupDetails))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
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
                if (this.AcceptedAt != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptedAt.GetHashCode();
                }
                if (this.AutoCompleteDuration != null)
                {
                    hashCode = (hashCode * 59) + this.AutoCompleteDuration.GetHashCode();
                }
                if (this.CancelReason != null)
                {
                    hashCode = (hashCode * 59) + this.CancelReason.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ScheduleType.GetHashCode();
                if (this.PickupAt != null)
                {
                    hashCode = (hashCode * 59) + this.PickupAt.GetHashCode();
                }
                if (this.PickupWindowDuration != null)
                {
                    hashCode = (hashCode * 59) + this.PickupWindowDuration.GetHashCode();
                }
                if (this.PrepTimeDuration != null)
                {
                    hashCode = (hashCode * 59) + this.PrepTimeDuration.GetHashCode();
                }
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                if (this.PlacedAt != null)
                {
                    hashCode = (hashCode * 59) + this.PlacedAt.GetHashCode();
                }
                if (this.RejectedAt != null)
                {
                    hashCode = (hashCode * 59) + this.RejectedAt.GetHashCode();
                }
                if (this.ReadyAt != null)
                {
                    hashCode = (hashCode * 59) + this.ReadyAt.GetHashCode();
                }
                if (this.ExpiredAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiredAt.GetHashCode();
                }
                if (this.PickedUpAt != null)
                {
                    hashCode = (hashCode * 59) + this.PickedUpAt.GetHashCode();
                }
                if (this.CanceledAt != null)
                {
                    hashCode = (hashCode * 59) + this.CanceledAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCurbsidePickup.GetHashCode();
                if (this.CurbsidePickupDetails != null)
                {
                    hashCode = (hashCode * 59) + this.CurbsidePickupDetails.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
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
            yield break;
        }
    }

}
