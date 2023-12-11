/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.1.1
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
    /// EcommerceCustomer
    /// </summary>
    [DataContract(Name = "EcommerceCustomer")]
    public partial class EcommerceCustomer : IEquatable<EcommerceCustomer>, IValidatableObject
    {
        /// <summary>
        /// The current status of the customer
        /// </summary>
        /// <value>The current status of the customer</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 2

        }


        /// <summary>
        /// The current status of the customer
        /// </summary>
        /// <value>The current status of the customer</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceCustomer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EcommerceCustomer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceCustomer" /> class.
        /// </summary>
        /// <param name="name">Full name of the customer.</param>
        /// <param name="firstName">First name of the customer.</param>
        /// <param name="lastName">Last name of the customer.</param>
        /// <param name="companyName">Company name of the customer.</param>
        /// <param name="status">The current status of the customer.</param>
        /// <param name="currency">currency.</param>
        /// <param name="emails">An array of email addresses for the customer..</param>
        /// <param name="phoneNumbers">An array of phone numbers for the customer..</param>
        /// <param name="addresses">An array of addresses for the customer..</param>
        /// <param name="orders">orders.</param>
        public EcommerceCustomer(string name = default(string), string firstName = default(string), string lastName = default(string), string companyName = default(string), StatusEnum? status = default(StatusEnum?), Currency? currency = default(Currency?), List<Email> emails = default(List<Email>), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<EcommerceCustomerAddresses> addresses = default(List<EcommerceCustomerAddresses>), List<LinkedEcommerceOrder> orders = default(List<LinkedEcommerceOrder>))
        {
            this.Name = name;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CompanyName = companyName;
            this.Status = status;
            this.Currency = currency;
            this.Emails = emails;
            this.PhoneNumbers = phoneNumbers;
            this.Addresses = addresses;
            this.Orders = orders;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
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
        /// Full name of the customer
        /// </summary>
        /// <value>Full name of the customer</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// First name of the customer
        /// </summary>
        /// <value>First name of the customer</value>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the customer
        /// </summary>
        /// <value>Last name of the customer</value>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Company name of the customer
        /// </summary>
        /// <value>Company name of the customer</value>
        [DataMember(Name = "company_name", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// An array of email addresses for the customer.
        /// </summary>
        /// <value>An array of email addresses for the customer.</value>
        [DataMember(Name = "emails", EmitDefaultValue = true)]
        public List<Email> Emails { get; set; }

        /// <summary>
        /// An array of phone numbers for the customer.
        /// </summary>
        /// <value>An array of phone numbers for the customer.</value>
        [DataMember(Name = "phone_numbers", EmitDefaultValue = true)]
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// An array of addresses for the customer.
        /// </summary>
        /// <value>An array of addresses for the customer.</value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<EcommerceCustomerAddresses> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name = "orders", EmitDefaultValue = false)]
        public List<LinkedEcommerceOrder> Orders { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcommerceCustomer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as EcommerceCustomer);
        }

        /// <summary>
        /// Returns true if EcommerceCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceCustomer input)
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
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    input.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                if (this.PhoneNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumbers.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.Orders != null)
                {
                    hashCode = (hashCode * 59) + this.Orders.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
