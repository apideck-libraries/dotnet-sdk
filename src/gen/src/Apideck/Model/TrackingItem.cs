/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.3.0
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
    /// Represents the tracking information associated with an ecommerce order.
    /// </summary>
    [DataContract(Name = "TrackingItem")]
    public partial class TrackingItem : IEquatable<TrackingItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackingItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingItem" /> class.
        /// </summary>
        /// <param name="provider">The name or code of the carrier or shipping company that is handling the shipment. (required).</param>
        /// <param name="number"> The tracking number associated with the shipment, which can be used to track the progress of the delivery. (required).</param>
        /// <param name="url">The URL of the carrier&#39;s tracking page, which can be used to view detailed information about the shipment&#39;s progress..</param>
        public TrackingItem(string provider = default(string), string number = default(string), string url = default(string))
        {
            // to ensure "provider" is required (not null)
            if (provider == null) {
                throw new ArgumentNullException("provider is a required property for TrackingItem and cannot be null");
            }
            this.Provider = provider;
            // to ensure "number" is required (not null)
            if (number == null) {
                throw new ArgumentNullException("number is a required property for TrackingItem and cannot be null");
            }
            this.Number = number;
            this.Url = url;
        }

        /// <summary>
        /// The name or code of the carrier or shipping company that is handling the shipment.
        /// </summary>
        /// <value>The name or code of the carrier or shipping company that is handling the shipment.</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        ///  The tracking number associated with the shipment, which can be used to track the progress of the delivery.
        /// </summary>
        /// <value> The tracking number associated with the shipment, which can be used to track the progress of the delivery.</value>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// The URL of the carrier&#39;s tracking page, which can be used to view detailed information about the shipment&#39;s progress.
        /// </summary>
        /// <value>The URL of the carrier&#39;s tracking page, which can be used to view detailed information about the shipment&#39;s progress.</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
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
            sb.Append("class TrackingItem {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as TrackingItem);
        }

        /// <summary>
        /// Returns true if TrackingItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
