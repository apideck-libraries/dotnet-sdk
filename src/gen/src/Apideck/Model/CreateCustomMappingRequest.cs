/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.5.0
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
    /// CreateCustomMappingRequest
    /// </summary>
    [DataContract(Name = "CreateCustomMappingRequest")]
    public partial class CreateCustomMappingRequest : IEquatable<CreateCustomMappingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomMappingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCustomMappingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomMappingRequest" /> class.
        /// </summary>
        /// <param name="value">Target Field Mapping value (required).</param>
        public CreateCustomMappingRequest(string value = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null) {
                throw new ArgumentNullException("value is a required property for CreateCustomMappingRequest and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Target Field Mapping value
        /// </summary>
        /// <value>Target Field Mapping value</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCustomMappingRequest {\n");
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
            return this.Equals(input as CreateCustomMappingRequest);
        }

        /// <summary>
        /// Returns true if CreateCustomMappingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCustomMappingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomMappingRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
