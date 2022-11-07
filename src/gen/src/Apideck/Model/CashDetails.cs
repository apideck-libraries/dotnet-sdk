/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.80.0
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
    /// Cash details for this payment
    /// </summary>
    [DataContract(Name = "Cash_details")]
    public partial class CashDetails : IEquatable<CashDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashDetails" /> class.
        /// </summary>
        /// <param name="amount">The amount of cash given by the customer..</param>
        /// <param name="chargeBackAmount">The amount of change due back to the buyer. For Square: this read-only field is calculated from the amount_money and buyer_supplied_money fields..</param>
        public CashDetails(Object amount = default(Object), Object chargeBackAmount = default(Object))
        {
            this.Amount = amount;
            this.ChargeBackAmount = chargeBackAmount;
        }

        /// <summary>
        /// The amount of cash given by the customer.
        /// </summary>
        /// <value>The amount of cash given by the customer.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public Object Amount { get; set; }

        /// <summary>
        /// The amount of change due back to the buyer. For Square: this read-only field is calculated from the amount_money and buyer_supplied_money fields.
        /// </summary>
        /// <value>The amount of change due back to the buyer. For Square: this read-only field is calculated from the amount_money and buyer_supplied_money fields.</value>
        [DataMember(Name = "charge_back_amount", EmitDefaultValue = true)]
        public Object ChargeBackAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashDetails {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ChargeBackAmount: ").Append(ChargeBackAmount).Append("\n");
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
            return this.Equals(input as CashDetails);
        }

        /// <summary>
        /// Returns true if CashDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CashDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ChargeBackAmount == input.ChargeBackAmount ||
                    (this.ChargeBackAmount != null &&
                    this.ChargeBackAmount.Equals(input.ChargeBackAmount))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ChargeBackAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeBackAmount.GetHashCode();
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
