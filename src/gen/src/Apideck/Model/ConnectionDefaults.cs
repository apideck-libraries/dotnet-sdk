/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.51.0
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
    /// ConnectionDefaults
    /// </summary>
    [DataContract(Name = "Connection_defaults")]
    public partial class ConnectionDefaults : IEquatable<ConnectionDefaults>, IValidatableObject
    {
        /// <summary>
        /// Defines Target
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetEnum
        {
            /// <summary>
            /// Enum CustomFields for value: custom_fields
            /// </summary>
            [EnumMember(Value = "custom_fields")]
            CustomFields = 1,

            /// <summary>
            /// Enum Resource for value: resource
            /// </summary>
            [EnumMember(Value = "resource")]
            Resource = 2

        }


        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public TargetEnum? Target { get; set; }

        /// <summary>
        /// Returns false as Target should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTarget()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionDefaults" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="options">options.</param>
        /// <param name="value">value.</param>
        public ConnectionDefaults(string id = default(string), List<FormFieldOption> options = default(List<FormFieldOption>), object value = default(object))
        {
            this.Id = id;
            this.Options = options;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<FormFieldOption> Options { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectionDefaults {\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ConnectionDefaults);
        }

        /// <summary>
        /// Returns true if ConnectionDefaults instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionDefaults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionDefaults input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Target == input.Target ||
                    this.Target.Equals(input.Target)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = (hashCode * 59) + this.Target.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
