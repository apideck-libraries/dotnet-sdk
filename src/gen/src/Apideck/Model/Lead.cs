/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.3.3
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
    /// Lead
    /// </summary>
    [DataContract(Name = "Lead")]
    public partial class Lead : IEquatable<Lead>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Lead" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Lead() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Lead" /> class.
        /// </summary>
        /// <param name="name">Full name of the lead. (required).</param>
        /// <param name="companyName">The name of the company the lead is associated with. (required).</param>
        /// <param name="ownerId">The owner of the lead..</param>
        /// <param name="companyId">The company the lead is associated with..</param>
        /// <param name="leadId">The identifier of the lead..</param>
        /// <param name="leadSource">The source of the lead..</param>
        /// <param name="firstName">The first name of the lead..</param>
        /// <param name="lastName">The last name of the lead..</param>
        /// <param name="description">The description of the lead..</param>
        /// <param name="prefix">The prefix of the lead..</param>
        /// <param name="title">The job title of the lead..</param>
        /// <param name="language">language code according to ISO 639-1. For the United States - EN.</param>
        /// <param name="status">status.</param>
        /// <param name="monetaryAmount">The monetary amount of the lead..</param>
        /// <param name="currency">currency.</param>
        /// <param name="fax">The fax number of the lead..</param>
        /// <param name="websites">websites.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="socialLinks">socialLinks.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="emails">emails.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="tags">tags.</param>
        public Lead(string name = default(string), string companyName = default(string), string ownerId = default(string), string companyId = default(string), string leadId = default(string), string leadSource = default(string), string firstName = default(string), string lastName = default(string), string description = default(string), string prefix = default(string), string title = default(string), string language = default(string), string status = default(string), decimal? monetaryAmount = default(decimal?), Currency? currency = default(Currency?), string fax = default(string), List<Website> websites = default(List<Website>), List<Address> addresses = default(List<Address>), List<SocialLink> socialLinks = default(List<SocialLink>), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<Email> emails = default(List<Email>), List<CustomField> customFields = default(List<CustomField>), List<string> tags = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Lead and cannot be null");
            }
            this.Name = name;
            // to ensure "companyName" is required (not null)
            if (companyName == null) {
                throw new ArgumentNullException("companyName is a required property for Lead and cannot be null");
            }
            this.CompanyName = companyName;
            this.OwnerId = ownerId;
            this.CompanyId = companyId;
            this.LeadId = leadId;
            this.LeadSource = leadSource;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Description = description;
            this.Prefix = prefix;
            this.Title = title;
            this.Language = language;
            this.Status = status;
            this.MonetaryAmount = monetaryAmount;
            this.Currency = currency;
            this.Fax = fax;
            this.Websites = websites;
            this.Addresses = addresses;
            this.SocialLinks = socialLinks;
            this.PhoneNumbers = phoneNumbers;
            this.Emails = emails;
            this.CustomFields = customFields;
            this.Tags = tags;
        }

        /// <summary>
        /// Unique identifier for the contact.
        /// </summary>
        /// <value>Unique identifier for the contact.</value>
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
        /// Full name of the lead.
        /// </summary>
        /// <value>Full name of the lead.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the company the lead is associated with.
        /// </summary>
        /// <value>The name of the company the lead is associated with.</value>
        [DataMember(Name = "company_name", IsRequired = true, EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The owner of the lead.
        /// </summary>
        /// <value>The owner of the lead.</value>
        [DataMember(Name = "owner_id", EmitDefaultValue = true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The company the lead is associated with.
        /// </summary>
        /// <value>The company the lead is associated with.</value>
        [DataMember(Name = "company_id", EmitDefaultValue = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The identifier of the lead.
        /// </summary>
        /// <value>The identifier of the lead.</value>
        [DataMember(Name = "lead_id", EmitDefaultValue = true)]
        public string LeadId { get; set; }

        /// <summary>
        /// The source of the lead.
        /// </summary>
        /// <value>The source of the lead.</value>
        [DataMember(Name = "lead_source", EmitDefaultValue = true)]
        public string LeadSource { get; set; }

        /// <summary>
        /// The first name of the lead.
        /// </summary>
        /// <value>The first name of the lead.</value>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the lead.
        /// </summary>
        /// <value>The last name of the lead.</value>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The description of the lead.
        /// </summary>
        /// <value>The description of the lead.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The prefix of the lead.
        /// </summary>
        /// <value>The prefix of the lead.</value>
        [DataMember(Name = "prefix", EmitDefaultValue = true)]
        public string Prefix { get; set; }

        /// <summary>
        /// The job title of the lead.
        /// </summary>
        /// <value>The job title of the lead.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        /// <value>language code according to ISO 639-1. For the United States - EN</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The monetary amount of the lead.
        /// </summary>
        /// <value>The monetary amount of the lead.</value>
        [DataMember(Name = "monetary_amount", EmitDefaultValue = true)]
        public decimal? MonetaryAmount { get; set; }

        /// <summary>
        /// The fax number of the lead.
        /// </summary>
        /// <value>The fax number of the lead.</value>
        [DataMember(Name = "fax", EmitDefaultValue = true)]
        public string Fax { get; set; }

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
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public List<CustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

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
        /// Date updated in ISO 8601 format
        /// </summary>
        /// <value>Date updated in ISO 8601 format</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Date created in ISO 8601 format
        /// </summary>
        /// <value>Date created in ISO 8601 format</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; private set; }

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
            sb.Append("class Lead {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  LeadId: ").Append(LeadId).Append("\n");
            sb.Append("  LeadSource: ").Append(LeadSource).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MonetaryAmount: ").Append(MonetaryAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  SocialLinks: ").Append(SocialLinks).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
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
            return this.Equals(input as Lead);
        }

        /// <summary>
        /// Returns true if Lead instances are equal
        /// </summary>
        /// <param name="input">Instance of Lead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Lead input)
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
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.LeadId == input.LeadId ||
                    (this.LeadId != null &&
                    this.LeadId.Equals(input.LeadId))
                ) && 
                (
                    this.LeadSource == input.LeadSource ||
                    (this.LeadSource != null &&
                    this.LeadSource.Equals(input.LeadSource))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MonetaryAmount == input.MonetaryAmount ||
                    (this.MonetaryAmount != null &&
                    this.MonetaryAmount.Equals(input.MonetaryAmount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
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
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
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
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.LeadId != null)
                {
                    hashCode = (hashCode * 59) + this.LeadId.GetHashCode();
                }
                if (this.LeadSource != null)
                {
                    hashCode = (hashCode * 59) + this.LeadSource.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Prefix != null)
                {
                    hashCode = (hashCode * 59) + this.Prefix.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.MonetaryAmount != null)
                {
                    hashCode = (hashCode * 59) + this.MonetaryAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.Fax != null)
                {
                    hashCode = (hashCode * 59) + this.Fax.GetHashCode();
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
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
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

            // UpdatedAt (string) pattern
            Regex regexUpdatedAt = new Regex(@"^\\d{4}-\\d{2}-\\d{2}T\\d{2}:\\d{2}:\\d{2}.\\d{3}Z$", RegexOptions.CultureInvariant);
            if (false == regexUpdatedAt.Match(this.UpdatedAt).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpdatedAt, must match a pattern of " + regexUpdatedAt, new [] { "UpdatedAt" });
            }

            // CreatedAt (string) pattern
            Regex regexCreatedAt = new Regex(@"^\\d{4}-\\d{2}-\\d{2}T\\d{2}:\\d{2}:\\d{2}.\\d{3}Z$", RegexOptions.CultureInvariant);
            if (false == regexCreatedAt.Match(this.CreatedAt).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedAt, must match a pattern of " + regexCreatedAt, new [] { "CreatedAt" });
            }

            yield break;
        }
    }

}
