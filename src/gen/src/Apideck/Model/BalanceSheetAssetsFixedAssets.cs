/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.71.0
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
    /// BalanceSheetAssetsFixedAssets
    /// </summary>
    [DataContract(Name = "BalanceSheet_assets_fixed_assets")]
    public partial class BalanceSheetAssetsFixedAssets : IEquatable<BalanceSheetAssetsFixedAssets>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheetAssetsFixedAssets" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceSheetAssetsFixedAssets() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheetAssetsFixedAssets" /> class.
        /// </summary>
        /// <param name="total">Total fixed assets (required).</param>
        /// <param name="accounts">accounts (required).</param>
        public BalanceSheetAssetsFixedAssets(decimal total = default(decimal), List<BalanceSheetAssetsFixedAssetsAccounts> accounts = default(List<BalanceSheetAssetsFixedAssetsAccounts>))
        {
            this.Total = total;
            // to ensure "accounts" is required (not null)
            if (accounts == null) {
                throw new ArgumentNullException("accounts is a required property for BalanceSheetAssetsFixedAssets and cannot be null");
            }
            this.Accounts = accounts;
        }

        /// <summary>
        /// Total fixed assets
        /// </summary>
        /// <value>Total fixed assets</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name = "accounts", IsRequired = true, EmitDefaultValue = false)]
        public List<BalanceSheetAssetsFixedAssetsAccounts> Accounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceSheetAssetsFixedAssets {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(input as BalanceSheetAssetsFixedAssets);
        }

        /// <summary>
        /// Returns true if BalanceSheetAssetsFixedAssets instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceSheetAssetsFixedAssets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceSheetAssetsFixedAssets input)
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
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
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
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
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
