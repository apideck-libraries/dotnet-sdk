/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.3.6
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
    /// BalanceSheetAssets
    /// </summary>
    [DataContract(Name = "BalanceSheet_assets")]
    public partial class BalanceSheetAssets : IEquatable<BalanceSheetAssets>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheetAssets" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceSheetAssets() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheetAssets" /> class.
        /// </summary>
        /// <param name="total">Total assets (required).</param>
        /// <param name="currentAssets">currentAssets (required).</param>
        /// <param name="fixedAssets">fixedAssets (required).</param>
        public BalanceSheetAssets(decimal total = default(decimal), BalanceSheetAssetsCurrentAssets currentAssets = default(BalanceSheetAssetsCurrentAssets), BalanceSheetAssetsFixedAssets fixedAssets = default(BalanceSheetAssetsFixedAssets))
        {
            this.Total = total;
            // to ensure "currentAssets" is required (not null)
            if (currentAssets == null) {
                throw new ArgumentNullException("currentAssets is a required property for BalanceSheetAssets and cannot be null");
            }
            this.CurrentAssets = currentAssets;
            // to ensure "fixedAssets" is required (not null)
            if (fixedAssets == null) {
                throw new ArgumentNullException("fixedAssets is a required property for BalanceSheetAssets and cannot be null");
            }
            this.FixedAssets = fixedAssets;
        }

        /// <summary>
        /// Total assets
        /// </summary>
        /// <value>Total assets</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAssets
        /// </summary>
        [DataMember(Name = "current_assets", IsRequired = true, EmitDefaultValue = false)]
        public BalanceSheetAssetsCurrentAssets CurrentAssets { get; set; }

        /// <summary>
        /// Gets or Sets FixedAssets
        /// </summary>
        [DataMember(Name = "fixed_assets", IsRequired = true, EmitDefaultValue = false)]
        public BalanceSheetAssetsFixedAssets FixedAssets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceSheetAssets {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  CurrentAssets: ").Append(CurrentAssets).Append("\n");
            sb.Append("  FixedAssets: ").Append(FixedAssets).Append("\n");
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
            return this.Equals(input as BalanceSheetAssets);
        }

        /// <summary>
        /// Returns true if BalanceSheetAssets instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceSheetAssets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceSheetAssets input)
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
                    this.CurrentAssets == input.CurrentAssets ||
                    (this.CurrentAssets != null &&
                    this.CurrentAssets.Equals(input.CurrentAssets))
                ) && 
                (
                    this.FixedAssets == input.FixedAssets ||
                    (this.FixedAssets != null &&
                    this.FixedAssets.Equals(input.FixedAssets))
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
                if (this.CurrentAssets != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAssets.GetHashCode();
                }
                if (this.FixedAssets != null)
                {
                    hashCode = (hashCode * 59) + this.FixedAssets.GetHashCode();
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
