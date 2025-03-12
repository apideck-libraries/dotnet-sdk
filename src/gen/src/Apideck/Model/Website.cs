/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.12.3
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
    /// Website
    /// </summary>
    [DataContract(Name = "Website")]
    public partial class Website : IEquatable<Website>, IValidatableObject
    {
        /// <summary>
        /// The type of website
        /// </summary>
        /// <value>The type of website</value>
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
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 5

        }


        /// <summary>
        /// The type of website
        /// </summary>
        /// <value>The type of website</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Website" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Website() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Website" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the website.</param>
        /// <param name="url">The website URL (required).</param>
        /// <param name="type">The type of website.</param>
        public Website(string id = default(string), string url = default(string), TypeEnum? type = default(TypeEnum?))
        {
            // to ensure "url" is required (not null)
            if (url == null) {
                throw new ArgumentNullException("url is a required property for Website and cannot be null");
            }
            this.Url = url;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Unique identifier for the website
        /// </summary>
        /// <value>Unique identifier for the website</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The website URL
        /// </summary>
        /// <value>The website URL</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Website {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as Website);
        }

        /// <summary>
        /// Returns true if Website instances are equal
        /// </summary>
        /// <param name="input">Instance of Website to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Website input)
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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            yield break;
        }
    }

}
