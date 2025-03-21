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
    /// BalanceByPeriod
    /// </summary>
    [DataContract(Name = "BalanceByPeriod")]
    public partial class BalanceByPeriod : IEquatable<BalanceByPeriod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceByPeriod" /> class.
        /// </summary>
        /// <param name="startDate">The starting date of the period. If not provided, it represents the oldest period, where all transactions due before the specified &#x60;end_date&#x60; are included..</param>
        /// <param name="endDate">The ending date of the period. If not provided, it represents an open-ended period starting from the &#x60;start_date&#x60;, typically capturing future-dated transactions that are not yet aged..</param>
        /// <param name="totalAmount">Total amount of the period..</param>
        /// <param name="balancesByTransaction">balancesByTransaction.</param>
        public BalanceByPeriod(DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), decimal totalAmount = default(decimal), List<BalanceByTransaction> balancesByTransaction = default(List<BalanceByTransaction>))
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TotalAmount = totalAmount;
            this.BalancesByTransaction = balancesByTransaction;
        }

        /// <summary>
        /// The starting date of the period. If not provided, it represents the oldest period, where all transactions due before the specified &#x60;end_date&#x60; are included.
        /// </summary>
        /// <value>The starting date of the period. If not provided, it represents the oldest period, where all transactions due before the specified &#x60;end_date&#x60; are included.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The ending date of the period. If not provided, it represents an open-ended period starting from the &#x60;start_date&#x60;, typically capturing future-dated transactions that are not yet aged.
        /// </summary>
        /// <value>The ending date of the period. If not provided, it represents an open-ended period starting from the &#x60;start_date&#x60;, typically capturing future-dated transactions that are not yet aged.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Total amount of the period.
        /// </summary>
        /// <value>Total amount of the period.</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets BalancesByTransaction
        /// </summary>
        [DataMember(Name = "balances_by_transaction", EmitDefaultValue = false)]
        public List<BalanceByTransaction> BalancesByTransaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceByPeriod {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  BalancesByTransaction: ").Append(BalancesByTransaction).Append("\n");
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
            return this.Equals(input as BalanceByPeriod);
        }

        /// <summary>
        /// Returns true if BalanceByPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceByPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceByPeriod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    this.TotalAmount.Equals(input.TotalAmount)
                ) && 
                (
                    this.BalancesByTransaction == input.BalancesByTransaction ||
                    this.BalancesByTransaction != null &&
                    input.BalancesByTransaction != null &&
                    this.BalancesByTransaction.SequenceEqual(input.BalancesByTransaction)
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                if (this.BalancesByTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.BalancesByTransaction.GetHashCode();
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
