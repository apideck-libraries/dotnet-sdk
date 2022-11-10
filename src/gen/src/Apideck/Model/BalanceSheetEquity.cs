/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.83.0
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
    /// BalanceSheetEquity
    /// </summary>
    [DataContract(Name = "BalanceSheet_equity")]
    public partial class BalanceSheetEquity : IEquatable<BalanceSheetEquity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheetEquity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceSheetEquity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheetEquity" /> class.
        /// </summary>
        /// <param name="total">Total equity (required).</param>
        /// <param name="items">items (required).</param>
        public BalanceSheetEquity(decimal total = default(decimal), List<BalanceSheetEquityItems> items = default(List<BalanceSheetEquityItems>))
        {
            this.Total = total;
            // to ensure "items" is required (not null)
            if (items == null) {
                throw new ArgumentNullException("items is a required property for BalanceSheetEquity and cannot be null");
            }
            this.Items = items;
        }

        /// <summary>
        /// Total equity
        /// </summary>
        /// <value>Total equity</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = false)]
        public List<BalanceSheetEquityItems> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceSheetEquity {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as BalanceSheetEquity);
        }

        /// <summary>
        /// Returns true if BalanceSheetEquity instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceSheetEquity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceSheetEquity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
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
