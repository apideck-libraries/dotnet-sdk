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
    /// An object representing a discount applied to an ecommerce order or product.
    /// </summary>
    [DataContract(Name = "EcommerceDiscount")]
    public partial class EcommerceDiscount : IEquatable<EcommerceDiscount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceDiscount" /> class.
        /// </summary>
        /// <param name="code">The code used to apply the discount..</param>
        /// <param name="amount">The fixed amount of the discount..</param>
        /// <param name="percentage">The percentage of the discount..</param>
        public EcommerceDiscount(string code = default(string), string amount = default(string), string percentage = default(string))
        {
            this.Code = code;
            this.Amount = amount;
            this.Percentage = percentage;
        }

        /// <summary>
        /// The code used to apply the discount.
        /// </summary>
        /// <value>The code used to apply the discount.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The fixed amount of the discount.
        /// </summary>
        /// <value>The fixed amount of the discount.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// The percentage of the discount.
        /// </summary>
        /// <value>The percentage of the discount.</value>
        [DataMember(Name = "percentage", EmitDefaultValue = true)]
        public string Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcommerceDiscount {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(input as EcommerceDiscount);
        }

        /// <summary>
        /// Returns true if EcommerceDiscount instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceDiscount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    (this.Percentage != null &&
                    this.Percentage.Equals(input.Percentage))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Percentage != null)
                {
                    hashCode = (hashCode * 59) + this.Percentage.GetHashCode();
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
