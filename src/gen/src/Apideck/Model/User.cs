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
    /// User
    /// </summary>
    [DataContract(Name = "User")]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="parentId">The parent user id.</param>
        /// <param name="username">The username of the user.</param>
        /// <param name="firstName">The first name of the person..</param>
        /// <param name="lastName">The last name of the person..</param>
        /// <param name="title">The job title of the person..</param>
        /// <param name="division">The division the person is currently in. Usually a collection of departments or teams or regions..</param>
        /// <param name="department">The department the person is currently in. [Deprecated](https://developers.apideck.com/changelog) in favor of the dedicated department_id and department_name field..</param>
        /// <param name="companyName">The name of the company..</param>
        /// <param name="employeeNumber">An Employee Number, Employee ID or Employee Code, is a unique number that has been assigned to each individual staff member within a company..</param>
        /// <param name="description">A description of the object..</param>
        /// <param name="image">The URL of the user&#39;s avatar.</param>
        /// <param name="language">language code according to ISO 639-1. For the United States - EN.</param>
        /// <param name="status">The status of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="emails">emails (required).</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public User(string parentId = default(string), string username = default(string), string firstName = default(string), string lastName = default(string), string title = default(string), string division = default(string), string department = default(string), string companyName = default(string), string employeeNumber = default(string), string description = default(string), string image = default(string), string language = default(string), string status = default(string), string password = default(string), List<Address> addresses = default(List<Address>), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<Email> emails = default(List<Email>), List<Object> passThrough = default(List<Object>))
        {
            // to ensure "emails" is required (not null)
            if (emails == null) {
                throw new ArgumentNullException("emails is a required property for User and cannot be null");
            }
            this.Emails = emails;
            this.ParentId = parentId;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
            this.Division = division;
            this.Department = department;
            this.CompanyName = companyName;
            this.EmployeeNumber = employeeNumber;
            this.Description = description;
            this.Image = image;
            this.Language = language;
            this.Status = status;
            this.Password = password;
            this.Addresses = addresses;
            this.PhoneNumbers = phoneNumbers;
            this.PassThrough = passThrough;
        }

        /// <summary>
        /// The unique identifier for the user
        /// </summary>
        /// <value>The unique identifier for the user</value>
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
        /// The parent user id
        /// </summary>
        /// <value>The parent user id</value>
        [DataMember(Name = "parent_id", EmitDefaultValue = true)]
        public string ParentId { get; set; }

        /// <summary>
        /// The username of the user
        /// </summary>
        /// <value>The username of the user</value>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// The first name of the person.
        /// </summary>
        /// <value>The first name of the person.</value>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        /// <value>The last name of the person.</value>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The job title of the person.
        /// </summary>
        /// <value>The job title of the person.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The division the person is currently in. Usually a collection of departments or teams or regions.
        /// </summary>
        /// <value>The division the person is currently in. Usually a collection of departments or teams or regions.</value>
        [DataMember(Name = "division", EmitDefaultValue = true)]
        public string Division { get; set; }

        /// <summary>
        /// The department the person is currently in. [Deprecated](https://developers.apideck.com/changelog) in favor of the dedicated department_id and department_name field.
        /// </summary>
        /// <value>The department the person is currently in. [Deprecated](https://developers.apideck.com/changelog) in favor of the dedicated department_id and department_name field.</value>
        [DataMember(Name = "department", EmitDefaultValue = true)]
        [Obsolete]
        public string Department { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        [DataMember(Name = "company_name", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// An Employee Number, Employee ID or Employee Code, is a unique number that has been assigned to each individual staff member within a company.
        /// </summary>
        /// <value>An Employee Number, Employee ID or Employee Code, is a unique number that has been assigned to each individual staff member within a company.</value>
        [DataMember(Name = "employee_number", EmitDefaultValue = true)]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// A description of the object.
        /// </summary>
        /// <value>A description of the object.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The URL of the user&#39;s avatar
        /// </summary>
        /// <value>The URL of the user&#39;s avatar</value>
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        /// <value>language code according to ISO 639-1. For the United States - EN</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// The status of the user
        /// </summary>
        /// <value>The status of the user</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The password of the user
        /// </summary>
        /// <value>The password of the user</value>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

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
        [DataMember(Name = "emails", IsRequired = true, EmitDefaultValue = false)]
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
        /// The date and time when the user was last updated.
        /// </summary>
        /// <value>The date and time when the user was last updated.</value>
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
        /// The date and time when the user was created.
        /// </summary>
        /// <value>The date and time when the user was created.</value>
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
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        /// <value>The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.</value>
        [DataMember(Name = "pass_through", EmitDefaultValue = false)]
        public List<Object> PassThrough { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  EmployeeNumber: ").Append(EmployeeNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  PassThrough: ").Append(PassThrough).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
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
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Division == input.Division ||
                    (this.Division != null &&
                    this.Division.Equals(input.Division))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.EmployeeNumber == input.EmployeeNumber ||
                    (this.EmployeeNumber != null &&
                    this.EmployeeNumber.Equals(input.EmployeeNumber))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                    this.PassThrough == input.PassThrough ||
                    this.PassThrough != null &&
                    input.PassThrough != null &&
                    this.PassThrough.SequenceEqual(input.PassThrough)
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
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Division != null)
                {
                    hashCode = (hashCode * 59) + this.Division.GetHashCode();
                }
                if (this.Department != null)
                {
                    hashCode = (hashCode * 59) + this.Department.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.EmployeeNumber != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeNumber.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.PassThrough != null)
                {
                    hashCode = (hashCode * 59) + this.PassThrough.GetHashCode();
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
