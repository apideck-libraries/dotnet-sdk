/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.72.0
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
    /// TaxRatesFilter
    /// </summary>
    [DataContract(Name = "TaxRatesFilter")]
    public partial class TaxRatesFilter : IEquatable<TaxRatesFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRatesFilter" /> class.
        /// </summary>
        /// <param name="assets">Boolean to describe if tax rate can be used for asset accounts.</param>
        /// <param name="equity">Boolean to describe if tax rate can be used for equity accounts.</param>
        /// <param name="expenses">Boolean to describe if tax rate can be used for expense accounts.</param>
        /// <param name="liabilities">Boolean to describe if tax rate can be used for liability accounts.</param>
        /// <param name="revenue">Boolean to describe if tax rate can be used for revenue accounts.</param>
        public TaxRatesFilter(bool assets = default(bool), bool equity = default(bool), bool expenses = default(bool), bool liabilities = default(bool), bool revenue = default(bool))
        {
            this.Assets = assets;
            this.Equity = equity;
            this.Expenses = expenses;
            this.Liabilities = liabilities;
            this.Revenue = revenue;
        }

        /// <summary>
        /// Boolean to describe if tax rate can be used for asset accounts
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for asset accounts</value>
        [DataMember(Name = "assets", EmitDefaultValue = true)]
        public bool Assets { get; set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for equity accounts
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for equity accounts</value>
        [DataMember(Name = "equity", EmitDefaultValue = true)]
        public bool Equity { get; set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for expense accounts
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for expense accounts</value>
        [DataMember(Name = "expenses", EmitDefaultValue = true)]
        public bool Expenses { get; set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for liability accounts
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for liability accounts</value>
        [DataMember(Name = "liabilities", EmitDefaultValue = true)]
        public bool Liabilities { get; set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for revenue accounts
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for revenue accounts</value>
        [DataMember(Name = "revenue", EmitDefaultValue = true)]
        public bool Revenue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxRatesFilter {\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Equity: ").Append(Equity).Append("\n");
            sb.Append("  Expenses: ").Append(Expenses).Append("\n");
            sb.Append("  Liabilities: ").Append(Liabilities).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
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
            return this.Equals(input as TaxRatesFilter);
        }

        /// <summary>
        /// Returns true if TaxRatesFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRatesFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRatesFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Assets == input.Assets ||
                    this.Assets.Equals(input.Assets)
                ) && 
                (
                    this.Equity == input.Equity ||
                    this.Equity.Equals(input.Equity)
                ) && 
                (
                    this.Expenses == input.Expenses ||
                    this.Expenses.Equals(input.Expenses)
                ) && 
                (
                    this.Liabilities == input.Liabilities ||
                    this.Liabilities.Equals(input.Liabilities)
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    this.Revenue.Equals(input.Revenue)
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
                hashCode = (hashCode * 59) + this.Assets.GetHashCode();
                hashCode = (hashCode * 59) + this.Equity.GetHashCode();
                hashCode = (hashCode * 59) + this.Expenses.GetHashCode();
                hashCode = (hashCode * 59) + this.Liabilities.GetHashCode();
                hashCode = (hashCode * 59) + this.Revenue.GetHashCode();
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
