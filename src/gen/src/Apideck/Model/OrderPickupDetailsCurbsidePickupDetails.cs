/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.5
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
    /// Specific details for curbside pickup.
    /// </summary>
    [DataContract(Name = "Order_pickup_details_curbside_pickup_details")]
    public partial class OrderPickupDetailsCurbsidePickupDetails : IEquatable<OrderPickupDetailsCurbsidePickupDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPickupDetailsCurbsidePickupDetails" /> class.
        /// </summary>
        /// <param name="curbsideDetails">Specific details for curbside pickup, such as parking number and vehicle model..</param>
        /// <param name="buyerArrivedAt">Indicating when the buyer arrived and is waiting for pickup. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;)..</param>
        public OrderPickupDetailsCurbsidePickupDetails(string curbsideDetails = default(string), DateTime buyerArrivedAt = default(DateTime))
        {
            this.CurbsideDetails = curbsideDetails;
            this.BuyerArrivedAt = buyerArrivedAt;
        }

        /// <summary>
        /// Specific details for curbside pickup, such as parking number and vehicle model.
        /// </summary>
        /// <value>Specific details for curbside pickup, such as parking number and vehicle model.</value>
        [DataMember(Name = "curbside_details", EmitDefaultValue = false)]
        public string CurbsideDetails { get; set; }

        /// <summary>
        /// Indicating when the buyer arrived and is waiting for pickup. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).
        /// </summary>
        /// <value>Indicating when the buyer arrived and is waiting for pickup. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;).</value>
        [DataMember(Name = "buyer_arrived_at", EmitDefaultValue = false)]
        public DateTime BuyerArrivedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderPickupDetailsCurbsidePickupDetails {\n");
            sb.Append("  CurbsideDetails: ").Append(CurbsideDetails).Append("\n");
            sb.Append("  BuyerArrivedAt: ").Append(BuyerArrivedAt).Append("\n");
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
            return this.Equals(input as OrderPickupDetailsCurbsidePickupDetails);
        }

        /// <summary>
        /// Returns true if OrderPickupDetailsCurbsidePickupDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderPickupDetailsCurbsidePickupDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPickupDetailsCurbsidePickupDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurbsideDetails == input.CurbsideDetails ||
                    (this.CurbsideDetails != null &&
                    this.CurbsideDetails.Equals(input.CurbsideDetails))
                ) && 
                (
                    this.BuyerArrivedAt == input.BuyerArrivedAt ||
                    (this.BuyerArrivedAt != null &&
                    this.BuyerArrivedAt.Equals(input.BuyerArrivedAt))
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
                if (this.CurbsideDetails != null)
                {
                    hashCode = (hashCode * 59) + this.CurbsideDetails.GetHashCode();
                }
                if (this.BuyerArrivedAt != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerArrivedAt.GetHashCode();
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
            // CurbsideDetails (string) maxLength
            if (this.CurbsideDetails != null && this.CurbsideDetails.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurbsideDetails, length must be less than 250.", new [] { "CurbsideDetails" });
            }

            yield break;
        }
    }

}
