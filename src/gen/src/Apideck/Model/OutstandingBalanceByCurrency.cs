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
    /// OutstandingBalanceByCurrency
    /// </summary>
    [DataContract(Name = "OutstandingBalanceByCurrency")]
    public partial class OutstandingBalanceByCurrency : IEquatable<OutstandingBalanceByCurrency>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutstandingBalanceByCurrency" /> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="totalAmount">Total amount of the outstanding balance..</param>
        /// <param name="balancesByPeriod">balancesByPeriod.</param>
        public OutstandingBalanceByCurrency(Currency? currency = default(Currency?), decimal totalAmount = default(decimal), List<BalanceByPeriod> balancesByPeriod = default(List<BalanceByPeriod>))
        {
            this.Currency = currency;
            this.TotalAmount = totalAmount;
            this.BalancesByPeriod = balancesByPeriod;
        }

        /// <summary>
        /// Total amount of the outstanding balance.
        /// </summary>
        /// <value>Total amount of the outstanding balance.</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets BalancesByPeriod
        /// </summary>
        [DataMember(Name = "balances_by_period", EmitDefaultValue = false)]
        public List<BalanceByPeriod> BalancesByPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutstandingBalanceByCurrency {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  BalancesByPeriod: ").Append(BalancesByPeriod).Append("\n");
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
            return this.Equals(input as OutstandingBalanceByCurrency);
        }

        /// <summary>
        /// Returns true if OutstandingBalanceByCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of OutstandingBalanceByCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutstandingBalanceByCurrency input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    this.TotalAmount.Equals(input.TotalAmount)
                ) && 
                (
                    this.BalancesByPeriod == input.BalancesByPeriod ||
                    this.BalancesByPeriod != null &&
                    input.BalancesByPeriod != null &&
                    this.BalancesByPeriod.SequenceEqual(input.BalancesByPeriod)
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
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                if (this.BalancesByPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.BalancesByPeriod.GetHashCode();
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
