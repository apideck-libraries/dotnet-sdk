/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.13.0
 * Contact: support@apideck.com
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
    /// OrderFulfillments
    /// </summary>
    [DataContract(Name = "Order_fulfillments")]
    public partial class OrderFulfillments : IEquatable<OrderFulfillments>, IValidatableObject
    {
        /// <summary>
        /// The state of the fulfillment.
        /// </summary>
        /// <value>The state of the fulfillment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Proposed for value: proposed
            /// </summary>
            [EnumMember(Value = "proposed")]
            Proposed = 1,

            /// <summary>
            /// Enum Reserved for value: reserved
            /// </summary>
            [EnumMember(Value = "reserved")]
            Reserved = 2,

            /// <summary>
            /// Enum Prepared for value: prepared
            /// </summary>
            [EnumMember(Value = "prepared")]
            Prepared = 3,

            /// <summary>
            /// Enum Completed for value: completed
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed = 4,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 5,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7

        }


        /// <summary>
        /// The state of the fulfillment.
        /// </summary>
        /// <value>The state of the fulfillment.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Pickup for value: pickup
            /// </summary>
            [EnumMember(Value = "pickup")]
            Pickup = 1,

            /// <summary>
            /// Enum Shipment for value: shipment
            /// </summary>
            [EnumMember(Value = "shipment")]
            Shipment = 2

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFulfillments" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">The state of the fulfillment..</param>
        /// <param name="type">type.</param>
        /// <param name="pickupDetails">pickupDetails.</param>
        /// <param name="shipmentDetails">shipmentDetails.</param>
        public OrderFulfillments(string id = default(string), StatusEnum? status = default(StatusEnum?), TypeEnum? type = default(TypeEnum?), OrderPickupDetails pickupDetails = default(OrderPickupDetails), Object shipmentDetails = default(Object))
        {
            this.Id = id;
            this.Status = status;
            this.Type = type;
            this.PickupDetails = pickupDetails;
            this.ShipmentDetails = shipmentDetails;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PickupDetails
        /// </summary>
        [DataMember(Name = "pickup_details", EmitDefaultValue = false)]
        public OrderPickupDetails PickupDetails { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentDetails
        /// </summary>
        [DataMember(Name = "shipment_details", EmitDefaultValue = false)]
        public Object ShipmentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderFulfillments {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PickupDetails: ").Append(PickupDetails).Append("\n");
            sb.Append("  ShipmentDetails: ").Append(ShipmentDetails).Append("\n");
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
            return this.Equals(input as OrderFulfillments);
        }

        /// <summary>
        /// Returns true if OrderFulfillments instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFulfillments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFulfillments input)
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.PickupDetails == input.PickupDetails ||
                    (this.PickupDetails != null &&
                    this.PickupDetails.Equals(input.PickupDetails))
                ) && 
                (
                    this.ShipmentDetails == input.ShipmentDetails ||
                    (this.ShipmentDetails != null &&
                    this.ShipmentDetails.Equals(input.ShipmentDetails))
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.PickupDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PickupDetails.GetHashCode();
                }
                if (this.ShipmentDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ShipmentDetails.GetHashCode();
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
