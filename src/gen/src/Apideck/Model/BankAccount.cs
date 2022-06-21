/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.5
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
    /// Card details for this payment. This field is currently not available. Reach out to our team for more info.
    /// </summary>
    [DataContract(Name = "Bank_account")]
    public partial class BankAccount : IEquatable<BankAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        /// <param name="bankName">The name of the bank associated with the bank account..</param>
        /// <param name="transferType">The type of the bank transfer. The type can be &#x60;ACH&#x60; or &#x60;UNKNOWN&#x60;..</param>
        /// <param name="accountOwnershipType">The ownership type of the bank account performing the transfer. The type can be &#x60;INDIVIDUAL&#x60;, &#x60;COMPANY&#x60;, or &#x60;UNKNOWN&#x60;..</param>
        /// <param name="fingerprint">Uniquely identifies the bank account for this seller and can be used to determine if payments are from the same bank account..</param>
        /// <param name="country">country code according to ISO 3166-1 alpha-2..</param>
        /// <param name="statementDescription">The statement description as sent to the bank..</param>
        /// <param name="achDetails">achDetails.</param>
        public BankAccount(string bankName = default(string), string transferType = default(string), string accountOwnershipType = default(string), string fingerprint = default(string), string country = default(string), string statementDescription = default(string), BankAccountAchDetails achDetails = default(BankAccountAchDetails))
        {
            this.BankName = bankName;
            this.TransferType = transferType;
            this.AccountOwnershipType = accountOwnershipType;
            this.Fingerprint = fingerprint;
            this.Country = country;
            this.StatementDescription = statementDescription;
            this.AchDetails = achDetails;
        }

        /// <summary>
        /// The name of the bank associated with the bank account.
        /// </summary>
        /// <value>The name of the bank associated with the bank account.</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// The type of the bank transfer. The type can be &#x60;ACH&#x60; or &#x60;UNKNOWN&#x60;.
        /// </summary>
        /// <value>The type of the bank transfer. The type can be &#x60;ACH&#x60; or &#x60;UNKNOWN&#x60;.</value>
        [DataMember(Name = "transfer_type", EmitDefaultValue = false)]
        public string TransferType { get; set; }

        /// <summary>
        /// The ownership type of the bank account performing the transfer. The type can be &#x60;INDIVIDUAL&#x60;, &#x60;COMPANY&#x60;, or &#x60;UNKNOWN&#x60;.
        /// </summary>
        /// <value>The ownership type of the bank account performing the transfer. The type can be &#x60;INDIVIDUAL&#x60;, &#x60;COMPANY&#x60;, or &#x60;UNKNOWN&#x60;.</value>
        [DataMember(Name = "account_ownership_type", EmitDefaultValue = false)]
        public string AccountOwnershipType { get; set; }

        /// <summary>
        /// Uniquely identifies the bank account for this seller and can be used to determine if payments are from the same bank account.
        /// </summary>
        /// <value>Uniquely identifies the bank account for this seller and can be used to determine if payments are from the same bank account.</value>
        [DataMember(Name = "fingerprint", EmitDefaultValue = false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// country code according to ISO 3166-1 alpha-2.
        /// </summary>
        /// <value>country code according to ISO 3166-1 alpha-2.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The statement description as sent to the bank.
        /// </summary>
        /// <value>The statement description as sent to the bank.</value>
        [DataMember(Name = "statement_description", EmitDefaultValue = false)]
        public string StatementDescription { get; set; }

        /// <summary>
        /// Gets or Sets AchDetails
        /// </summary>
        [DataMember(Name = "ach_details", EmitDefaultValue = false)]
        public BankAccountAchDetails AchDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankAccount {\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  TransferType: ").Append(TransferType).Append("\n");
            sb.Append("  AccountOwnershipType: ").Append(AccountOwnershipType).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  StatementDescription: ").Append(StatementDescription).Append("\n");
            sb.Append("  AchDetails: ").Append(AchDetails).Append("\n");
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
            return this.Equals(input as BankAccount);
        }

        /// <summary>
        /// Returns true if BankAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.TransferType == input.TransferType ||
                    (this.TransferType != null &&
                    this.TransferType.Equals(input.TransferType))
                ) && 
                (
                    this.AccountOwnershipType == input.AccountOwnershipType ||
                    (this.AccountOwnershipType != null &&
                    this.AccountOwnershipType.Equals(input.AccountOwnershipType))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.StatementDescription == input.StatementDescription ||
                    (this.StatementDescription != null &&
                    this.StatementDescription.Equals(input.StatementDescription))
                ) && 
                (
                    this.AchDetails == input.AchDetails ||
                    (this.AchDetails != null &&
                    this.AchDetails.Equals(input.AchDetails))
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
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.TransferType != null)
                {
                    hashCode = (hashCode * 59) + this.TransferType.GetHashCode();
                }
                if (this.AccountOwnershipType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountOwnershipType.GetHashCode();
                }
                if (this.Fingerprint != null)
                {
                    hashCode = (hashCode * 59) + this.Fingerprint.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.StatementDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatementDescription.GetHashCode();
                }
                if (this.AchDetails != null)
                {
                    hashCode = (hashCode * 59) + this.AchDetails.GetHashCode();
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
            // BankName (string) maxLength
            if (this.BankName != null && this.BankName.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankName, length must be less than 100.", new [] { "BankName" });
            }

            // TransferType (string) maxLength
            if (this.TransferType != null && this.TransferType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransferType, length must be less than 50.", new [] { "TransferType" });
            }

            // AccountOwnershipType (string) maxLength
            if (this.AccountOwnershipType != null && this.AccountOwnershipType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountOwnershipType, length must be less than 50.", new [] { "AccountOwnershipType" });
            }

            // Fingerprint (string) maxLength
            if (this.Fingerprint != null && this.Fingerprint.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Fingerprint, length must be less than 255.", new [] { "Fingerprint" });
            }

            // Country (string) maxLength
            if (this.Country != null && this.Country.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 2.", new [] { "Country" });
            }

            // Country (string) minLength
            if (this.Country != null && this.Country.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be greater than 2.", new [] { "Country" });
            }

            // StatementDescription (string) maxLength
            if (this.StatementDescription != null && this.StatementDescription.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatementDescription, length must be less than 1000.", new [] { "StatementDescription" });
            }

            yield break;
        }
    }

}
