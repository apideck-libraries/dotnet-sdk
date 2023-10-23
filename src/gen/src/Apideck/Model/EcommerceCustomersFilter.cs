/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.9.3
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
    /// EcommerceCustomersFilter
    /// </summary>
    [DataContract(Name = "EcommerceCustomersFilter")]
    public partial class EcommerceCustomersFilter : IEquatable<EcommerceCustomersFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceCustomersFilter" /> class.
        /// </summary>
        /// <param name="email">Customer email address to filter on.</param>
        /// <param name="phoneNumber">Customer phone number to filter on.</param>
        public EcommerceCustomersFilter(string email = default(string), string phoneNumber = default(string))
        {
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Customer email address to filter on
        /// </summary>
        /// <value>Customer email address to filter on</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Customer phone number to filter on
        /// </summary>
        /// <value>Customer phone number to filter on</value>
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcommerceCustomersFilter {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as EcommerceCustomersFilter);
        }

        /// <summary>
        /// Returns true if EcommerceCustomersFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceCustomersFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceCustomersFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
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
