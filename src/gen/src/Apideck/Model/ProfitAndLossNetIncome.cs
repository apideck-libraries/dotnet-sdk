/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.40.0
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
    /// ProfitAndLossNetIncome
    /// </summary>
    [DataContract(Name = "ProfitAndLoss_net_income")]
    public partial class ProfitAndLossNetIncome : IEquatable<ProfitAndLossNetIncome>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfitAndLossNetIncome" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfitAndLossNetIncome() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfitAndLossNetIncome" /> class.
        /// </summary>
        /// <param name="total">Total net income (required).</param>
        /// <param name="records">records (required).</param>
        public ProfitAndLossNetIncome(decimal? total = default(decimal?), List<object> records = default(List<object>))
        {
            // to ensure "total" is required (not null)
            if (total == null) {
                throw new ArgumentNullException("total is a required property for ProfitAndLossNetIncome and cannot be null");
            }
            this.Total = total;
            // to ensure "records" is required (not null)
            if (records == null) {
                throw new ArgumentNullException("records is a required property for ProfitAndLossNetIncome and cannot be null");
            }
            this.Records = records;
        }

        /// <summary>
        /// Total net income
        /// </summary>
        /// <value>Total net income</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", IsRequired = true, EmitDefaultValue = true)]
        public List<object> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProfitAndLossNetIncome {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(input as ProfitAndLossNetIncome);
        }

        /// <summary>
        /// Returns true if ProfitAndLossNetIncome instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfitAndLossNetIncome to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfitAndLossNetIncome input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                if (this.Total != null)
                {
                    hashCode = (hashCode * 59) + this.Total.GetHashCode();
                }
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
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
