/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.91.1
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
    /// PhoneNumber
    /// </summary>
    [DataContract(Name = "PhoneNumber")]
    public partial class PhoneNumber : IEquatable<PhoneNumber>, IValidatableObject
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
            /// Enum Home for value: home
            /// </summary>
            [EnumMember(Value = "home")]
            Home = 3,

            /// <summary>
            /// Enum Work for value: work
            /// </summary>
            [EnumMember(Value = "work")]
            Work = 4,

            /// <summary>
            /// Enum Office for value: office
            /// </summary>
            [EnumMember(Value = "office")]
            Office = 5,

            /// <summary>
            /// Enum Mobile for value: mobile
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile = 6,

            /// <summary>
            /// Enum Assistant for value: assistant
            /// </summary>
            [EnumMember(Value = "assistant")]
            Assistant = 7,

            /// <summary>
            /// Enum Fax for value: fax
            /// </summary>
            [EnumMember(Value = "fax")]
            Fax = 8,

            /// <summary>
            /// Enum DirectDialIn for value: direct-dial-in
            /// </summary>
            [EnumMember(Value = "direct-dial-in")]
            DirectDialIn = 9,

            /// <summary>
            /// Enum Personal for value: personal
            /// </summary>
            [EnumMember(Value = "personal")]
            Personal = 10,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 11

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneNumber() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="areaCode">areaCode.</param>
        /// <param name="number">number (required).</param>
        /// <param name="extension">extension.</param>
        /// <param name="type">type.</param>
        public PhoneNumber(string id = default(string), string countryCode = default(string), string areaCode = default(string), string number = default(string), string extension = default(string), TypeEnum? type = default(TypeEnum?))
        {
            // to ensure "number" is required (not null)
            if (number == null) {
                throw new ArgumentNullException("number is a required property for PhoneNumber and cannot be null");
            }
            this.Number = number;
            this.Id = id;
            this.CountryCode = countryCode;
            this.AreaCode = areaCode;
            this.Extension = extension;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "country_code", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets AreaCode
        /// </summary>
        [DataMember(Name = "area_code", EmitDefaultValue = true)]
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = true)]
        public string Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PhoneNumber {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
            return this.Equals(input as PhoneNumber);
        }

        /// <summary>
        /// Returns true if PhoneNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumber input)
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
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
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
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.AreaCode != null)
                {
                    hashCode = (hashCode * 59) + this.AreaCode.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Extension != null)
                {
                    hashCode = (hashCode * 59) + this.Extension.GetHashCode();
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
            // Number (string) minLength
            if (this.Number != null && this.Number.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be greater than 1.", new [] { "Number" });
            }

            yield break;
        }
    }

}
