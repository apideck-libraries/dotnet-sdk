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
    /// The customer this entity is linked to.
    /// </summary>
    [DataContract(Name = "LinkedCustomer")]
    public partial class LinkedCustomer : IEquatable<LinkedCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedCustomer" /> class.
        /// </summary>
        /// <param name="id">The ID of the customer this entity is linked to..</param>
        /// <param name="displayName">The display name of the customer..</param>
        /// <param name="name">The name of the customer. Deprecated, use display_name instead..</param>
        /// <param name="email">The email address of the customer..</param>
        public LinkedCustomer(string id = default(string), string displayName = default(string), string name = default(string), string email = default(string))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// The ID of the customer this entity is linked to.
        /// </summary>
        /// <value>The ID of the customer this entity is linked to.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The display ID of the customer.
        /// </summary>
        /// <value>The display ID of the customer.</value>
        [DataMember(Name = "display_id", EmitDefaultValue = true)]
        public string DisplayId { get; private set; }

        /// <summary>
        /// Returns false as DisplayId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayId()
        {
            return false;
        }
        /// <summary>
        /// The display name of the customer.
        /// </summary>
        /// <value>The display name of the customer.</value>
        [DataMember(Name = "display_name", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the customer. Deprecated, use display_name instead.
        /// </summary>
        /// <value>The name of the customer. Deprecated, use display_name instead.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [Obsolete]
        public string Name { get; set; }

        /// <summary>
        /// The company name of the customer.
        /// </summary>
        /// <value>The company name of the customer.</value>
        [DataMember(Name = "company_name", EmitDefaultValue = true)]
        public string CompanyName { get; private set; }

        /// <summary>
        /// Returns false as CompanyName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompanyName()
        {
            return false;
        }
        /// <summary>
        /// The email address of the customer.
        /// </summary>
        /// <value>The email address of the customer.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkedCustomer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as LinkedCustomer);
        }

        /// <summary>
        /// Returns true if LinkedCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedCustomer input)
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
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.DisplayId != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayId.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
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
