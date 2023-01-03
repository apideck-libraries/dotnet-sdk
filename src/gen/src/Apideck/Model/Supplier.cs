/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.85.1
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
    /// Supplier
    /// </summary>
    [DataContract(Name = "Supplier")]
    public partial class Supplier : IEquatable<Supplier>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Customer status
        /// </summary>
        /// <value>Customer status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2,

            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 3,

            /// <summary>
            /// Enum GdprErasureRequest for value: gdpr-erasure-request
            /// </summary>
            [EnumMember(Value = "gdpr-erasure-request")]
            GdprErasureRequest = 4,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 5

        }


        /// <summary>
        /// Customer status
        /// </summary>
        /// <value>Customer status</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Supplier" /> class.
        /// </summary>
        /// <param name="companyName">companyName.</param>
        /// <param name="displayName">Display name of supplier..</param>
        /// <param name="title">title.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="suffix">suffix.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="notes">notes.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="emails">emails.</param>
        /// <param name="websites">websites.</param>
        /// <param name="bankAccounts">bankAccounts.</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="taxNumber">taxNumber.</param>
        /// <param name="currency">currency.</param>
        /// <param name="account">account.</param>
        /// <param name="status">Customer status.</param>
        /// <param name="rowVersion">rowVersion.</param>
        public Supplier(string companyName = default(string), string displayName = default(string), string title = default(string), string firstName = default(string), string middleName = default(string), string lastName = default(string), string suffix = default(string), List<Address> addresses = default(List<Address>), string notes = default(string), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<Email> emails = default(List<Email>), List<Website> websites = default(List<Website>), List<BankAccount> bankAccounts = default(List<BankAccount>), LinkedTaxRate taxRate = default(LinkedTaxRate), string taxNumber = default(string), Currency? currency = default(Currency?), LinkedLedgerAccount account = default(LinkedLedgerAccount), StatusEnum? status = default(StatusEnum?), string rowVersion = default(string))
        {
            this.CompanyName = companyName;
            this.DisplayName = displayName;
            this.Title = title;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Suffix = suffix;
            this.Addresses = addresses;
            this.Notes = notes;
            this.PhoneNumbers = phoneNumbers;
            this.Emails = emails;
            this.Websites = websites;
            this.BankAccounts = bankAccounts;
            this.TaxRate = taxRate;
            this.TaxNumber = taxNumber;
            this.Currency = currency;
            this.Account = account;
            this.Status = status;
            this.RowVersion = rowVersion;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The third-party API ID of original entity
        /// </summary>
        /// <value>The third-party API ID of original entity</value>
        [DataMember(Name = "downstream_id", EmitDefaultValue = true)]
        public string DownstreamId { get; private set; }

        /// <summary>
        /// Returns false as DownstreamId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDownstreamId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "company_name", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Display name of supplier.
        /// </summary>
        /// <value>Display name of supplier.</value>
        [DataMember(Name = "display_name", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middle_name", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Suffix
        /// </summary>
        [DataMember(Name = "suffix", EmitDefaultValue = true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name = "phone_numbers", EmitDefaultValue = false)]
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name = "emails", EmitDefaultValue = false)]
        public List<Email> Emails { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        public List<Website> Websites { get; set; }

        /// <summary>
        /// Gets or Sets BankAccounts
        /// </summary>
        [DataMember(Name = "bank_accounts", EmitDefaultValue = false)]
        public List<BankAccount> BankAccounts { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public LinkedTaxRate TaxRate { get; set; }

        /// <summary>
        /// Gets or Sets TaxNumber
        /// </summary>
        [DataMember(Name = "tax_number", EmitDefaultValue = true)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public LinkedLedgerAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updated_by", EmitDefaultValue = true)]
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// Returns false as UpdatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = true)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RowVersion
        /// </summary>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Supplier {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  BankAccounts: ").Append(BankAccounts).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
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
            return this.Equals(input as Supplier);
        }

        /// <summary>
        /// Returns true if Supplier instances are equal
        /// </summary>
        /// <param name="input">Instance of Supplier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Supplier input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DownstreamId == input.DownstreamId ||
                    (this.DownstreamId != null &&
                    this.DownstreamId.Equals(input.DownstreamId))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Websites == input.Websites ||
                    this.Websites != null &&
                    input.Websites != null &&
                    this.Websites.SequenceEqual(input.Websites)
                ) && 
                (
                    this.BankAccounts == input.BankAccounts ||
                    this.BankAccounts != null &&
                    input.BankAccounts != null &&
                    this.BankAccounts.SequenceEqual(input.BankAccounts)
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Suffix != null)
                {
                    hashCode = (hashCode * 59) + this.Suffix.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.PhoneNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumbers.GetHashCode();
                }
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                if (this.Websites != null)
                {
                    hashCode = (hashCode * 59) + this.Websites.GetHashCode();
                }
                if (this.BankAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccounts.GetHashCode();
                }
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                }
                if (this.TaxNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TaxNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
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
