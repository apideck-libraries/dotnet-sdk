/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.2.2
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
    /// HrisCompany
    /// </summary>
    [DataContract(Name = "HrisCompany")]
    public partial class HrisCompany : IEquatable<HrisCompany>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
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
            /// Enum Trial for value: trial
            /// </summary>
            [EnumMember(Value = "trial")]
            Trial = 3,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HrisCompany" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HrisCompany() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HrisCompany" /> class.
        /// </summary>
        /// <param name="legalName">legalName (required).</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="subdomain">subdomain.</param>
        /// <param name="status">status.</param>
        /// <param name="companyNumber">An Company Number, Company ID or Company Code, is a unique number that has been assigned to each company..</param>
        /// <param name="currency">currency.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="emails">emails.</param>
        /// <param name="websites">websites.</param>
        /// <param name="debtorId">debtorId.</param>
        public HrisCompany(string legalName = default(string), string displayName = default(string), string subdomain = default(string), StatusEnum? status = default(StatusEnum?), string companyNumber = default(string), Currency? currency = default(Currency?), List<Address> addresses = default(List<Address>), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<Email> emails = default(List<Email>), List<Website> websites = default(List<Website>), string debtorId = default(string))
        {
            // to ensure "legalName" is required (not null)
            if (legalName == null) {
                throw new ArgumentNullException("legalName is a required property for HrisCompany and cannot be null");
            }
            this.LegalName = legalName;
            this.DisplayName = displayName;
            this.Subdomain = subdomain;
            this.Status = status;
            this.CompanyNumber = companyNumber;
            this.Currency = currency;
            this.Addresses = addresses;
            this.PhoneNumbers = phoneNumbers;
            this.Emails = emails;
            this.Websites = websites;
            this.DebtorId = debtorId;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
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
        /// Gets or Sets LegalName
        /// </summary>
        [DataMember(Name = "legal_name", IsRequired = true, EmitDefaultValue = true)]
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "display_name", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Subdomain
        /// </summary>
        [DataMember(Name = "subdomain", EmitDefaultValue = true)]
        public string Subdomain { get; set; }

        /// <summary>
        /// An Company Number, Company ID or Company Code, is a unique number that has been assigned to each company.
        /// </summary>
        /// <value>An Company Number, Company ID or Company Code, is a unique number that has been assigned to each company.</value>
        [DataMember(Name = "company_number", EmitDefaultValue = true)]
        public string CompanyNumber { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

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
        /// Gets or Sets DebtorId
        /// </summary>
        [DataMember(Name = "debtor_id", EmitDefaultValue = true)]
        public string DebtorId { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; private set; }

        /// <summary>
        /// Returns false as CustomMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomMappings()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; private set; }

        /// <summary>
        /// Returns false as Deleted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeleted()
        {
            return false;
        }
        /// <summary>
        /// The user who last updated the object.
        /// </summary>
        /// <value>The user who last updated the object.</value>
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
        /// The user who created the object.
        /// </summary>
        /// <value>The user who created the object.</value>
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
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
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
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HrisCompany {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Subdomain: ").Append(Subdomain).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CompanyNumber: ").Append(CompanyNumber).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  DebtorId: ").Append(DebtorId).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as HrisCompany);
        }

        /// <summary>
        /// Returns true if HrisCompany instances are equal
        /// </summary>
        /// <param name="input">Instance of HrisCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HrisCompany input)
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
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Subdomain == input.Subdomain ||
                    (this.Subdomain != null &&
                    this.Subdomain.Equals(input.Subdomain))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.CompanyNumber == input.CompanyNumber ||
                    (this.CompanyNumber != null &&
                    this.CompanyNumber.Equals(input.CompanyNumber))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
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
                    this.DebtorId == input.DebtorId ||
                    (this.DebtorId != null &&
                    this.DebtorId.Equals(input.DebtorId))
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
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
                if (this.LegalName != null)
                {
                    hashCode = (hashCode * 59) + this.LegalName.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Subdomain != null)
                {
                    hashCode = (hashCode * 59) + this.Subdomain.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.CompanyNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
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
                if (this.DebtorId != null)
                {
                    hashCode = (hashCode * 59) + this.DebtorId.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
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
            // LegalName (string) minLength
            if (this.LegalName != null && this.LegalName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LegalName, length must be greater than 1.", new [] { "LegalName" });
            }

            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            // Subdomain (string) minLength
            if (this.Subdomain != null && this.Subdomain.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Subdomain, length must be greater than 1.", new [] { "Subdomain" });
            }

            // DebtorId (string) minLength
            if (this.DebtorId != null && this.DebtorId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DebtorId, length must be greater than 1.", new [] { "DebtorId" });
            }

            yield break;
        }
    }

}
