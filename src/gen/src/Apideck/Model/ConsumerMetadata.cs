/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.49.0
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
    /// ConsumerMetadata
    /// </summary>
    [DataContract(Name = "ConsumerMetadata")]
    public partial class ConsumerMetadata : IEquatable<ConsumerMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumerMetadata" /> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="userName">userName.</param>
        /// <param name="email">email.</param>
        /// <param name="image">image.</param>
        public ConsumerMetadata(string accountName = default(string), string userName = default(string), string email = default(string), string image = default(string))
        {
            this.AccountName = accountName;
            this.UserName = userName;
            this.Email = email;
            this.Image = image;
        }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConsumerMetadata {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(input as ConsumerMetadata);
        }

        /// <summary>
        /// Returns true if ConsumerMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsumerMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumerMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
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
