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
    /// Company
    /// </summary>
    [DataContract(Name = "Company")]
    public partial class Company : IEquatable<Company>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Company() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="image">image.</param>
        /// <param name="description">description.</param>
        /// <param name="vatNumber">VAT number.</param>
        /// <param name="currency">currency.</param>
        /// <param name="status">status.</param>
        /// <param name="fax">fax.</param>
        /// <param name="annualRevenue">Annual revenue.</param>
        /// <param name="numberOfEmployees">Number of employees.</param>
        /// <param name="industry">Industry.</param>
        /// <param name="ownership">Ownership.</param>
        /// <param name="salesTaxNumber">salesTaxNumber.</param>
        /// <param name="payeeNumber">payeeNumber.</param>
        /// <param name="abnOrTfn">An ABN is necessary for operating a business, while a TFN (Tax File Number) is required for any person working in Australia..</param>
        /// <param name="abnBranch">An ABN Branch (also known as a GST Branch) is used if part of your business needs to account for GST separately from its parent entity..</param>
        /// <param name="acn">The Australian Company Number (ACN) is a nine digit number with the last digit being a check digit calculated using a modified modulus 10 calculation. ASIC has adopted a convention of always printing and displaying the ACN in the format XXX XXX XXX; three blocks of three characters, each block separated by a blank..</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="bankAccounts">bankAccounts.</param>
        /// <param name="websites">websites.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="socialLinks">socialLinks.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="emails">emails.</param>
        /// <param name="rowType">rowType.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="tags">tags.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="salutation">salutation.</param>
        /// <param name="birthday">birthday.</param>
        public Company(string name = default(string), string ownerId = default(string), string image = default(string), string description = default(string), string vatNumber = default(string), Currency? currency = default(Currency?), string status = default(string), string fax = default(string), string annualRevenue = default(string), string numberOfEmployees = default(string), string industry = default(string), string ownership = default(string), string salesTaxNumber = default(string), string payeeNumber = default(string), string abnOrTfn = default(string), string abnBranch = default(string), string acn = default(string), string firstName = default(string), string lastName = default(string), List<BankAccount> bankAccounts = default(List<BankAccount>), List<Website> websites = default(List<Website>), List<Address> addresses = default(List<Address>), List<SocialLink> socialLinks = default(List<SocialLink>), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<Email> emails = default(List<Email>), CompanyRowType rowType = default(CompanyRowType), List<CustomField> customFields = default(List<CustomField>), List<string> tags = default(List<string>), bool? readOnly = default(bool?), string salutation = default(string), DateTime? birthday = default(DateTime?))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Company and cannot be null");
            }
            this.Name = name;
            this.OwnerId = ownerId;
            this.Image = image;
            this.Description = description;
            this.VatNumber = vatNumber;
            this.Currency = currency;
            this.Status = status;
            this.Fax = fax;
            this.AnnualRevenue = annualRevenue;
            this.NumberOfEmployees = numberOfEmployees;
            this.Industry = industry;
            this.Ownership = ownership;
            this.SalesTaxNumber = salesTaxNumber;
            this.PayeeNumber = payeeNumber;
            this.AbnOrTfn = abnOrTfn;
            this.AbnBranch = abnBranch;
            this.Acn = acn;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BankAccounts = bankAccounts;
            this.Websites = websites;
            this.Addresses = addresses;
            this.SocialLinks = socialLinks;
            this.PhoneNumbers = phoneNumbers;
            this.Emails = emails;
            this.RowType = rowType;
            this.CustomFields = customFields;
            this.Tags = tags;
            this.ReadOnly = readOnly;
            this.Salutation = salutation;
            this.Birthday = birthday;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets InteractionCount
        /// </summary>
        [DataMember(Name = "interaction_count", EmitDefaultValue = true)]
        public int? InteractionCount { get; private set; }

        /// <summary>
        /// Returns false as InteractionCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInteractionCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// VAT number
        /// </summary>
        /// <value>VAT number</value>
        [DataMember(Name = "vat_number", EmitDefaultValue = true)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name = "fax", EmitDefaultValue = true)]
        public string Fax { get; set; }

        /// <summary>
        /// Annual revenue
        /// </summary>
        /// <value>Annual revenue</value>
        [DataMember(Name = "annual_revenue", EmitDefaultValue = true)]
        public string AnnualRevenue { get; set; }

        /// <summary>
        /// Number of employees
        /// </summary>
        /// <value>Number of employees</value>
        [DataMember(Name = "number_of_employees", EmitDefaultValue = true)]
        public string NumberOfEmployees { get; set; }

        /// <summary>
        /// Industry
        /// </summary>
        /// <value>Industry</value>
        [DataMember(Name = "industry", EmitDefaultValue = true)]
        public string Industry { get; set; }

        /// <summary>
        /// Ownership
        /// </summary>
        /// <value>Ownership</value>
        [DataMember(Name = "ownership", EmitDefaultValue = true)]
        public string Ownership { get; set; }

        /// <summary>
        /// Gets or Sets SalesTaxNumber
        /// </summary>
        [DataMember(Name = "sales_tax_number", EmitDefaultValue = true)]
        public string SalesTaxNumber { get; set; }

        /// <summary>
        /// Gets or Sets PayeeNumber
        /// </summary>
        [DataMember(Name = "payee_number", EmitDefaultValue = true)]
        public string PayeeNumber { get; set; }

        /// <summary>
        /// An ABN is necessary for operating a business, while a TFN (Tax File Number) is required for any person working in Australia.
        /// </summary>
        /// <value>An ABN is necessary for operating a business, while a TFN (Tax File Number) is required for any person working in Australia.</value>
        [DataMember(Name = "abn_or_tfn", EmitDefaultValue = true)]
        public string AbnOrTfn { get; set; }

        /// <summary>
        /// An ABN Branch (also known as a GST Branch) is used if part of your business needs to account for GST separately from its parent entity.
        /// </summary>
        /// <value>An ABN Branch (also known as a GST Branch) is used if part of your business needs to account for GST separately from its parent entity.</value>
        [DataMember(Name = "abn_branch", EmitDefaultValue = true)]
        public string AbnBranch { get; set; }

        /// <summary>
        /// The Australian Company Number (ACN) is a nine digit number with the last digit being a check digit calculated using a modified modulus 10 calculation. ASIC has adopted a convention of always printing and displaying the ACN in the format XXX XXX XXX; three blocks of three characters, each block separated by a blank.
        /// </summary>
        /// <value>The Australian Company Number (ACN) is a nine digit number with the last digit being a check digit calculated using a modified modulus 10 calculation. ASIC has adopted a convention of always printing and displaying the ACN in the format XXX XXX XXX; three blocks of three characters, each block separated by a blank.</value>
        [DataMember(Name = "acn", EmitDefaultValue = true)]
        public string Acn { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Parent ID
        /// </summary>
        /// <value>Parent ID</value>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; private set; }

        /// <summary>
        /// Returns false as ParentId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParentId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BankAccounts
        /// </summary>
        [DataMember(Name = "bank_accounts", EmitDefaultValue = false)]
        public List<BankAccount> BankAccounts { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        public List<Website> Websites { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets SocialLinks
        /// </summary>
        [DataMember(Name = "social_links", EmitDefaultValue = false)]
        public List<SocialLink> SocialLinks { get; set; }

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
        /// Gets or Sets RowType
        /// </summary>
        [DataMember(Name = "row_type", EmitDefaultValue = false)]
        public CompanyRowType RowType { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public List<CustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name = "read_only", EmitDefaultValue = true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityAt
        /// </summary>
        [DataMember(Name = "last_activity_at", EmitDefaultValue = true)]
        public DateTime? LastActivityAt { get; private set; }

        /// <summary>
        /// Returns false as LastActivityAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastActivityAt()
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
        /// Gets or Sets Salutation
        /// </summary>
        [DataMember(Name = "salutation", EmitDefaultValue = true)]
        public string Salutation { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name = "birthday", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Birthday { get; set; }

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
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InteractionCount: ").Append(InteractionCount).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  AnnualRevenue: ").Append(AnnualRevenue).Append("\n");
            sb.Append("  NumberOfEmployees: ").Append(NumberOfEmployees).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Ownership: ").Append(Ownership).Append("\n");
            sb.Append("  SalesTaxNumber: ").Append(SalesTaxNumber).Append("\n");
            sb.Append("  PayeeNumber: ").Append(PayeeNumber).Append("\n");
            sb.Append("  AbnOrTfn: ").Append(AbnOrTfn).Append("\n");
            sb.Append("  AbnBranch: ").Append(AbnBranch).Append("\n");
            sb.Append("  Acn: ").Append(Acn).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  BankAccounts: ").Append(BankAccounts).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  SocialLinks: ").Append(SocialLinks).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  RowType: ").Append(RowType).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  LastActivityAt: ").Append(LastActivityAt).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
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
            return this.Equals(input as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="input">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InteractionCount == input.InteractionCount ||
                    (this.InteractionCount != null &&
                    this.InteractionCount.Equals(input.InteractionCount))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.AnnualRevenue == input.AnnualRevenue ||
                    (this.AnnualRevenue != null &&
                    this.AnnualRevenue.Equals(input.AnnualRevenue))
                ) && 
                (
                    this.NumberOfEmployees == input.NumberOfEmployees ||
                    (this.NumberOfEmployees != null &&
                    this.NumberOfEmployees.Equals(input.NumberOfEmployees))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Ownership == input.Ownership ||
                    (this.Ownership != null &&
                    this.Ownership.Equals(input.Ownership))
                ) && 
                (
                    this.SalesTaxNumber == input.SalesTaxNumber ||
                    (this.SalesTaxNumber != null &&
                    this.SalesTaxNumber.Equals(input.SalesTaxNumber))
                ) && 
                (
                    this.PayeeNumber == input.PayeeNumber ||
                    (this.PayeeNumber != null &&
                    this.PayeeNumber.Equals(input.PayeeNumber))
                ) && 
                (
                    this.AbnOrTfn == input.AbnOrTfn ||
                    (this.AbnOrTfn != null &&
                    this.AbnOrTfn.Equals(input.AbnOrTfn))
                ) && 
                (
                    this.AbnBranch == input.AbnBranch ||
                    (this.AbnBranch != null &&
                    this.AbnBranch.Equals(input.AbnBranch))
                ) && 
                (
                    this.Acn == input.Acn ||
                    (this.Acn != null &&
                    this.Acn.Equals(input.Acn))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.BankAccounts == input.BankAccounts ||
                    this.BankAccounts != null &&
                    input.BankAccounts != null &&
                    this.BankAccounts.SequenceEqual(input.BankAccounts)
                ) && 
                (
                    this.Websites == input.Websites ||
                    this.Websites != null &&
                    input.Websites != null &&
                    this.Websites.SequenceEqual(input.Websites)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.SocialLinks == input.SocialLinks ||
                    this.SocialLinks != null &&
                    input.SocialLinks != null &&
                    this.SocialLinks.SequenceEqual(input.SocialLinks)
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
                    this.RowType == input.RowType ||
                    (this.RowType != null &&
                    this.RowType.Equals(input.RowType))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.LastActivityAt == input.LastActivityAt ||
                    (this.LastActivityAt != null &&
                    this.LastActivityAt.Equals(input.LastActivityAt))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.InteractionCount != null)
                {
                    hashCode = (hashCode * 59) + this.InteractionCount.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.VatNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VatNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Fax != null)
                {
                    hashCode = (hashCode * 59) + this.Fax.GetHashCode();
                }
                if (this.AnnualRevenue != null)
                {
                    hashCode = (hashCode * 59) + this.AnnualRevenue.GetHashCode();
                }
                if (this.NumberOfEmployees != null)
                {
                    hashCode = (hashCode * 59) + this.NumberOfEmployees.GetHashCode();
                }
                if (this.Industry != null)
                {
                    hashCode = (hashCode * 59) + this.Industry.GetHashCode();
                }
                if (this.Ownership != null)
                {
                    hashCode = (hashCode * 59) + this.Ownership.GetHashCode();
                }
                if (this.SalesTaxNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SalesTaxNumber.GetHashCode();
                }
                if (this.PayeeNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeNumber.GetHashCode();
                }
                if (this.AbnOrTfn != null)
                {
                    hashCode = (hashCode * 59) + this.AbnOrTfn.GetHashCode();
                }
                if (this.AbnBranch != null)
                {
                    hashCode = (hashCode * 59) + this.AbnBranch.GetHashCode();
                }
                if (this.Acn != null)
                {
                    hashCode = (hashCode * 59) + this.Acn.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.BankAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccounts.GetHashCode();
                }
                if (this.Websites != null)
                {
                    hashCode = (hashCode * 59) + this.Websites.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.SocialLinks != null)
                {
                    hashCode = (hashCode * 59) + this.SocialLinks.GetHashCode();
                }
                if (this.PhoneNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumbers.GetHashCode();
                }
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                if (this.RowType != null)
                {
                    hashCode = (hashCode * 59) + this.RowType.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.ReadOnly != null)
                {
                    hashCode = (hashCode * 59) + this.ReadOnly.GetHashCode();
                }
                if (this.LastActivityAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastActivityAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.Salutation != null)
                {
                    hashCode = (hashCode * 59) + this.Salutation.GetHashCode();
                }
                if (this.Birthday != null)
                {
                    hashCode = (hashCode * 59) + this.Birthday.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
