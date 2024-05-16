/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.4.2
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
    /// BankAccount
    /// </summary>
    [DataContract(Name = "BankAccount")]
    public partial class BankAccount : IEquatable<BankAccount>, IValidatableObject
    {
        /// <summary>
        /// The type of bank account.
        /// </summary>
        /// <value>The type of bank account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: bank_account
            /// </summary>
            [EnumMember(Value = "bank_account")]
            BankAccount = 1,

            /// <summary>
            /// Enum CreditCard for value: credit_card
            /// </summary>
            [EnumMember(Value = "credit_card")]
            CreditCard = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3

        }


        /// <summary>
        /// The type of bank account.
        /// </summary>
        /// <value>The type of bank account.</value>
        [DataMember(Name = "account_type", EmitDefaultValue = true)]
        public AccountTypeEnum? AccountType { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        /// <param name="bankName">The name of the bank.</param>
        /// <param name="accountNumber">A bank account number is a number that is tied to your bank account. If you have several bank accounts, such as personal, joint, business (and so on), each account will have a different account number..</param>
        /// <param name="accountName">The name which you used in opening your bank account..</param>
        /// <param name="accountType">The type of bank account..</param>
        /// <param name="iban">The International Bank Account Number (IBAN)..</param>
        /// <param name="bic">The Bank Identifier Code (BIC)..</param>
        /// <param name="routingNumber">A routing number is a nine-digit code used to identify a financial institution in the United States..</param>
        /// <param name="bsbNumber">A BSB is a 6 digit numeric code used for identifying the branch of an Australian or New Zealand bank or financial institution..</param>
        /// <param name="branchIdentifier">A branch identifier is a unique identifier for a branch of a bank or financial institution..</param>
        /// <param name="bankCode">A bank code is a code assigned by a central bank, a bank supervisory body or a Bankers Association in a country to all its licensed member banks or financial institutions..</param>
        /// <param name="currency">currency.</param>
        public BankAccount(string bankName = default(string), string accountNumber = default(string), string accountName = default(string), AccountTypeEnum? accountType = default(AccountTypeEnum?), string iban = default(string), string bic = default(string), string routingNumber = default(string), string bsbNumber = default(string), string branchIdentifier = default(string), string bankCode = default(string), Currency? currency = default(Currency?))
        {
            this.BankName = bankName;
            this.AccountNumber = accountNumber;
            this.AccountName = accountName;
            this.AccountType = accountType;
            this.Iban = iban;
            this.Bic = bic;
            this.RoutingNumber = routingNumber;
            this.BsbNumber = bsbNumber;
            this.BranchIdentifier = branchIdentifier;
            this.BankCode = bankCode;
            this.Currency = currency;
        }

        /// <summary>
        /// The name of the bank
        /// </summary>
        /// <value>The name of the bank</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = true)]
        public string BankName { get; set; }

        /// <summary>
        /// A bank account number is a number that is tied to your bank account. If you have several bank accounts, such as personal, joint, business (and so on), each account will have a different account number.
        /// </summary>
        /// <value>A bank account number is a number that is tied to your bank account. If you have several bank accounts, such as personal, joint, business (and so on), each account will have a different account number.</value>
        [DataMember(Name = "account_number", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The name which you used in opening your bank account.
        /// </summary>
        /// <value>The name which you used in opening your bank account.</value>
        [DataMember(Name = "account_name", EmitDefaultValue = true)]
        public string AccountName { get; set; }

        /// <summary>
        /// The International Bank Account Number (IBAN).
        /// </summary>
        /// <value>The International Bank Account Number (IBAN).</value>
        [DataMember(Name = "iban", EmitDefaultValue = true)]
        public string Iban { get; set; }

        /// <summary>
        /// The Bank Identifier Code (BIC).
        /// </summary>
        /// <value>The Bank Identifier Code (BIC).</value>
        [DataMember(Name = "bic", EmitDefaultValue = true)]
        public string Bic { get; set; }

        /// <summary>
        /// A routing number is a nine-digit code used to identify a financial institution in the United States.
        /// </summary>
        /// <value>A routing number is a nine-digit code used to identify a financial institution in the United States.</value>
        [DataMember(Name = "routing_number", EmitDefaultValue = true)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// A BSB is a 6 digit numeric code used for identifying the branch of an Australian or New Zealand bank or financial institution.
        /// </summary>
        /// <value>A BSB is a 6 digit numeric code used for identifying the branch of an Australian or New Zealand bank or financial institution.</value>
        [DataMember(Name = "bsb_number", EmitDefaultValue = true)]
        public string BsbNumber { get; set; }

        /// <summary>
        /// A branch identifier is a unique identifier for a branch of a bank or financial institution.
        /// </summary>
        /// <value>A branch identifier is a unique identifier for a branch of a bank or financial institution.</value>
        [DataMember(Name = "branch_identifier", EmitDefaultValue = true)]
        public string BranchIdentifier { get; set; }

        /// <summary>
        /// A bank code is a code assigned by a central bank, a bank supervisory body or a Bankers Association in a country to all its licensed member banks or financial institutions.
        /// </summary>
        /// <value>A bank code is a code assigned by a central bank, a bank supervisory body or a Bankers Association in a country to all its licensed member banks or financial institutions.</value>
        [DataMember(Name = "bank_code", EmitDefaultValue = true)]
        public string BankCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankAccount {\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  BsbNumber: ").Append(BsbNumber).Append("\n");
            sb.Append("  BranchIdentifier: ").Append(BranchIdentifier).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.Bic == input.Bic ||
                    (this.Bic != null &&
                    this.Bic.Equals(input.Bic))
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.BsbNumber == input.BsbNumber ||
                    (this.BsbNumber != null &&
                    this.BsbNumber.Equals(input.BsbNumber))
                ) && 
                (
                    this.BranchIdentifier == input.BranchIdentifier ||
                    (this.BranchIdentifier != null &&
                    this.BranchIdentifier.Equals(input.BranchIdentifier))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
                }
                if (this.Bic != null)
                {
                    hashCode = (hashCode * 59) + this.Bic.GetHashCode();
                }
                if (this.RoutingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RoutingNumber.GetHashCode();
                }
                if (this.BsbNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BsbNumber.GetHashCode();
                }
                if (this.BranchIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.BranchIdentifier.GetHashCode();
                }
                if (this.BankCode != null)
                {
                    hashCode = (hashCode * 59) + this.BankCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
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
