/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.78.0
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
    /// Email
    /// </summary>
    [DataContract(Name = "Email")]
    public partial class Email : IEquatable<Email>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Primary for value: primary
            /// </summary>
            [EnumMember(Value = "primary")]
            Primary = 1,

            /// <summary>
            /// Enum Secondary for value: secondary
            /// </summary>
            [EnumMember(Value = "secondary")]
            Secondary = 2,

            /// <summary>
            /// Enum Work for value: work
            /// </summary>
            [EnumMember(Value = "work")]
            Work = 3,

            /// <summary>
            /// Enum Personal for value: personal
            /// </summary>
            [EnumMember(Value = "personal")]
            Personal = 4,

            /// <summary>
            /// Enum Billing for value: billing
            /// </summary>
            [EnumMember(Value = "billing")]
            Billing = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Email() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="email">email (required).</param>
        /// <param name="type">type.</param>
        public Email(string id = default(string), string email = default(string), TypeEnum? type = default(TypeEnum?))
        {
            // to ensure "email" is required (not null)
            if (email == null) {
                throw new ArgumentNullException("email is a required property for Email and cannot be null");
            }
            this._Email = email;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets _Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string _Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Email {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Email: ").Append(_Email).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Email);
        }

        /// <summary>
        /// Returns true if Email instances are equal
        /// </summary>
        /// <param name="input">Instance of Email to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Email input)
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
                    this._Email == input._Email ||
                    (this._Email != null &&
                    this._Email.Equals(input._Email))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this._Email != null)
                {
                    hashCode = (hashCode * 59) + this._Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // _Email (string) minLength
            if (this._Email != null && this._Email.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Email, length must be greater than 1.", new [] { "_Email" });
            }

            yield break;
        }
    }

}
