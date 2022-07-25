/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.37.1
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
    /// ACH-specific details about &#x60;BANK_ACCOUNT&#x60; type payments with the &#x60;transfer_type&#x60; of &#x60;ACH&#x60;.
    /// </summary>
    [DataContract(Name = "Bank_account_ach_details")]
    public partial class BankAccountAchDetails : IEquatable<BankAccountAchDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAchDetails" /> class.
        /// </summary>
        /// <param name="routingNumber">The routing number for the bank account..</param>
        /// <param name="accountNumberSuffix">The last few digits of the bank account number..</param>
        /// <param name="accountType">The type of the bank account performing the transfer. The account type can be &#x60;CHECKING&#x60;, &#x60;SAVINGS&#x60;, or &#x60;UNKNOWN&#x60;..</param>
        public BankAccountAchDetails(string routingNumber = default(string), string accountNumberSuffix = default(string), string accountType = default(string))
        {
            this.RoutingNumber = routingNumber;
            this.AccountNumberSuffix = accountNumberSuffix;
            this.AccountType = accountType;
        }

        /// <summary>
        /// The routing number for the bank account.
        /// </summary>
        /// <value>The routing number for the bank account.</value>
        [DataMember(Name = "routing_number", EmitDefaultValue = false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The last few digits of the bank account number.
        /// </summary>
        /// <value>The last few digits of the bank account number.</value>
        [DataMember(Name = "account_number_suffix", EmitDefaultValue = false)]
        public string AccountNumberSuffix { get; set; }

        /// <summary>
        /// The type of the bank account performing the transfer. The account type can be &#x60;CHECKING&#x60;, &#x60;SAVINGS&#x60;, or &#x60;UNKNOWN&#x60;.
        /// </summary>
        /// <value>The type of the bank account performing the transfer. The account type can be &#x60;CHECKING&#x60;, &#x60;SAVINGS&#x60;, or &#x60;UNKNOWN&#x60;.</value>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankAccountAchDetails {\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  AccountNumberSuffix: ").Append(AccountNumberSuffix).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
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
            return this.Equals(input as BankAccountAchDetails);
        }

        /// <summary>
        /// Returns true if BankAccountAchDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountAchDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountAchDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.AccountNumberSuffix == input.AccountNumberSuffix ||
                    (this.AccountNumberSuffix != null &&
                    this.AccountNumberSuffix.Equals(input.AccountNumberSuffix))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
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
                if (this.RoutingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RoutingNumber.GetHashCode();
                }
                if (this.AccountNumberSuffix != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumberSuffix.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
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
            // RoutingNumber (string) maxLength
            if (this.RoutingNumber != null && this.RoutingNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoutingNumber, length must be less than 50.", new [] { "RoutingNumber" });
            }

            // AccountNumberSuffix (string) maxLength
            if (this.AccountNumberSuffix != null && this.AccountNumberSuffix.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumberSuffix, length must be less than 4.", new [] { "AccountNumberSuffix" });
            }

            // AccountType (string) maxLength
            if (this.AccountType != null && this.AccountType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountType, length must be less than 50.", new [] { "AccountType" });
            }

            yield break;
        }
    }

}
