/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.13.0
 * Contact: support@apideck.com
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
    /// CompanyInfo
    /// </summary>
    [DataContract(Name = "CompanyInfo")]
    public partial class CompanyInfo : IEquatable<CompanyInfo>, IValidatableObject
    {
        /// <summary>
        /// Based on the status some functionality is enabled or disabled.
        /// </summary>
        /// <value>Based on the status some functionality is enabled or disabled.</value>
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
            Inactive = 2

        }


        /// <summary>
        /// Based on the status some functionality is enabled or disabled.
        /// </summary>
        /// <value>Based on the status some functionality is enabled or disabled.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// The start month of fiscal year.
        /// </summary>
        /// <value>The start month of fiscal year.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FiscalYearStartMonthEnum
        {
            /// <summary>
            /// Enum January for value: January
            /// </summary>
            [EnumMember(Value = "January")]
            January = 1,

            /// <summary>
            /// Enum February for value: February
            /// </summary>
            [EnumMember(Value = "February")]
            February = 2,

            /// <summary>
            /// Enum March for value: March
            /// </summary>
            [EnumMember(Value = "March")]
            March = 3,

            /// <summary>
            /// Enum April for value: April
            /// </summary>
            [EnumMember(Value = "April")]
            April = 4,

            /// <summary>
            /// Enum May for value: May
            /// </summary>
            [EnumMember(Value = "May")]
            May = 5,

            /// <summary>
            /// Enum June for value: June
            /// </summary>
            [EnumMember(Value = "June")]
            June = 6,

            /// <summary>
            /// Enum July for value: July
            /// </summary>
            [EnumMember(Value = "July")]
            July = 7,

            /// <summary>
            /// Enum August for value: August
            /// </summary>
            [EnumMember(Value = "August")]
            August = 8,

            /// <summary>
            /// Enum September for value: September
            /// </summary>
            [EnumMember(Value = "September")]
            September = 9,

            /// <summary>
            /// Enum October for value: October
            /// </summary>
            [EnumMember(Value = "October")]
            October = 10,

            /// <summary>
            /// Enum November for value: November
            /// </summary>
            [EnumMember(Value = "November")]
            November = 11,

            /// <summary>
            /// Enum December for value: December
            /// </summary>
            [EnumMember(Value = "December")]
            December = 12

        }


        /// <summary>
        /// The start month of fiscal year.
        /// </summary>
        /// <value>The start month of fiscal year.</value>
        [DataMember(Name = "fiscal_year_start_month", EmitDefaultValue = false)]
        public FiscalYearStartMonthEnum? FiscalYearStartMonth { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyInfo" /> class.
        /// </summary>
        /// <param name="companyName">The name of the company..</param>
        /// <param name="status">Based on the status some functionality is enabled or disabled..</param>
        /// <param name="legalName">The legal name of the company.</param>
        /// <param name="country">country code according to ISO 3166-1 alpha-2..</param>
        /// <param name="salesTaxNumber">salesTaxNumber.</param>
        /// <param name="automatedSalesTax">Whether sales tax is calculated automatically for the company.</param>
        /// <param name="salesTaxEnabled">Whether sales tax is enabled for the company.</param>
        /// <param name="defaultSalesTax">defaultSalesTax.</param>
        /// <param name="currency">currency.</param>
        /// <param name="language">language code according to ISO 639-1. For the United States - EN.</param>
        /// <param name="fiscalYearStartMonth">The start month of fiscal year..</param>
        /// <param name="companyStartDate">Date when company file was created.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="emails">emails.</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        public CompanyInfo(string companyName = default(string), StatusEnum? status = default(StatusEnum?), string legalName = default(string), string country = default(string), string salesTaxNumber = default(string), bool automatedSalesTax = default(bool), bool salesTaxEnabled = default(bool), TaxRate defaultSalesTax = default(TaxRate), Currency? currency = default(Currency?), string language = default(string), FiscalYearStartMonthEnum? fiscalYearStartMonth = default(FiscalYearStartMonthEnum?), DateTime companyStartDate = default(DateTime), List<Address> addresses = default(List<Address>), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<Email> emails = default(List<Email>), string rowVersion = default(string))
        {
            this.CompanyName = companyName;
            this.Status = status;
            this.LegalName = legalName;
            this.Country = country;
            this.SalesTaxNumber = salesTaxNumber;
            this.AutomatedSalesTax = automatedSalesTax;
            this.SalesTaxEnabled = salesTaxEnabled;
            this.DefaultSalesTax = defaultSalesTax;
            this.Currency = currency;
            this.Language = language;
            this.FiscalYearStartMonth = fiscalYearStartMonth;
            this.CompanyStartDate = companyStartDate;
            this.Addresses = addresses;
            this.PhoneNumbers = phoneNumbers;
            this.Emails = emails;
            this.RowVersion = rowVersion;
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
        /// The name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        [DataMember(Name = "company_name", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The legal name of the company
        /// </summary>
        /// <value>The legal name of the company</value>
        [DataMember(Name = "legal_name", EmitDefaultValue = false)]
        public string LegalName { get; set; }

        /// <summary>
        /// country code according to ISO 3166-1 alpha-2.
        /// </summary>
        /// <value>country code according to ISO 3166-1 alpha-2.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets SalesTaxNumber
        /// </summary>
        [DataMember(Name = "sales_tax_number", EmitDefaultValue = true)]
        public string SalesTaxNumber { get; set; }

        /// <summary>
        /// Whether sales tax is calculated automatically for the company
        /// </summary>
        /// <value>Whether sales tax is calculated automatically for the company</value>
        [DataMember(Name = "automated_sales_tax", EmitDefaultValue = true)]
        public bool AutomatedSalesTax { get; set; }

        /// <summary>
        /// Whether sales tax is enabled for the company
        /// </summary>
        /// <value>Whether sales tax is enabled for the company</value>
        [DataMember(Name = "sales_tax_enabled", EmitDefaultValue = true)]
        public bool SalesTaxEnabled { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSalesTax
        /// </summary>
        [DataMember(Name = "default_sales_tax", EmitDefaultValue = false)]
        public TaxRate DefaultSalesTax { get; set; }

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        /// <value>language code according to ISO 639-1. For the United States - EN</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Date when company file was created
        /// </summary>
        /// <value>Date when company file was created</value>
        [DataMember(Name = "company_start_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CompanyStartDate { get; set; }

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
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        /// <value>A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.</value>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

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
            sb.Append("class CompanyInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  SalesTaxNumber: ").Append(SalesTaxNumber).Append("\n");
            sb.Append("  AutomatedSalesTax: ").Append(AutomatedSalesTax).Append("\n");
            sb.Append("  SalesTaxEnabled: ").Append(SalesTaxEnabled).Append("\n");
            sb.Append("  DefaultSalesTax: ").Append(DefaultSalesTax).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  FiscalYearStartMonth: ").Append(FiscalYearStartMonth).Append("\n");
            sb.Append("  CompanyStartDate: ").Append(CompanyStartDate).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
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
            return this.Equals(input as CompanyInfo);
        }

        /// <summary>
        /// Returns true if CompanyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyInfo input)
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
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.SalesTaxNumber == input.SalesTaxNumber ||
                    (this.SalesTaxNumber != null &&
                    this.SalesTaxNumber.Equals(input.SalesTaxNumber))
                ) && 
                (
                    this.AutomatedSalesTax == input.AutomatedSalesTax ||
                    this.AutomatedSalesTax.Equals(input.AutomatedSalesTax)
                ) && 
                (
                    this.SalesTaxEnabled == input.SalesTaxEnabled ||
                    this.SalesTaxEnabled.Equals(input.SalesTaxEnabled)
                ) && 
                (
                    this.DefaultSalesTax == input.DefaultSalesTax ||
                    (this.DefaultSalesTax != null &&
                    this.DefaultSalesTax.Equals(input.DefaultSalesTax))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.FiscalYearStartMonth == input.FiscalYearStartMonth ||
                    this.FiscalYearStartMonth.Equals(input.FiscalYearStartMonth)
                ) && 
                (
                    this.CompanyStartDate == input.CompanyStartDate ||
                    (this.CompanyStartDate != null &&
                    this.CompanyStartDate.Equals(input.CompanyStartDate))
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
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
                ) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
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
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.LegalName != null)
                {
                    hashCode = (hashCode * 59) + this.LegalName.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.SalesTaxNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SalesTaxNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutomatedSalesTax.GetHashCode();
                hashCode = (hashCode * 59) + this.SalesTaxEnabled.GetHashCode();
                if (this.DefaultSalesTax != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultSalesTax.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FiscalYearStartMonth.GetHashCode();
                if (this.CompanyStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyStartDate.GetHashCode();
                }
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
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
                }
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
            yield break;
        }
    }

}
