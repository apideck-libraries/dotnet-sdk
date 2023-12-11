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
    /// CustomMapping
    /// </summary>
    [DataContract(Name = "CustomMapping")]
    public partial class CustomMapping : IEquatable<CustomMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMapping" /> class.
        /// </summary>
        /// <param name="value">Target Field Mapping value.</param>
        public CustomMapping(string value = default(string))
        {
            this.Value = value;
        }

        /// <summary>
        /// Target Field ID
        /// </summary>
        /// <value>Target Field ID</value>
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
        /// Target Field name to use as a label
        /// </summary>
        /// <value>Target Field name to use as a label</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; private set; }

        /// <summary>
        /// Returns false as Label should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLabel()
        {
            return false;
        }
        /// <summary>
        /// Target Field description
        /// </summary>
        /// <value>Target Field description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return false;
        }
        /// <summary>
        /// Target Field Mapping value
        /// </summary>
        /// <value>Target Field Mapping value</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Target Field Key
        /// </summary>
        /// <value>Target Field Key</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; private set; }

        /// <summary>
        /// Returns false as Key should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeKey()
        {
            return false;
        }
        /// <summary>
        /// Target Field Mapping is required
        /// </summary>
        /// <value>Target Field Mapping is required</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; private set; }

        /// <summary>
        /// Returns false as Required should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequired()
        {
            return false;
        }
        /// <summary>
        /// This mapping represents a finder for a custom field
        /// </summary>
        /// <value>This mapping represents a finder for a custom field</value>
        [DataMember(Name = "custom_field", EmitDefaultValue = true)]
        public bool CustomField { get; private set; }

        /// <summary>
        /// Returns false as CustomField should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomField()
        {
            return false;
        }
        /// <summary>
        /// Consumer ID
        /// </summary>
        /// <value>Consumer ID</value>
        [DataMember(Name = "consumer_id", EmitDefaultValue = true)]
        public string ConsumerId { get; private set; }

        /// <summary>
        /// Returns false as ConsumerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConsumerId()
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
            sb.Append("class CustomMapping {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
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
            return this.Equals(input as CustomMapping);
        }

        /// <summary>
        /// Returns true if CustomMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomMapping input)
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
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.CustomField == input.CustomField ||
                    this.CustomField.Equals(input.CustomField)
                ) && 
                (
                    this.ConsumerId == input.ConsumerId ||
                    (this.ConsumerId != null &&
                    this.ConsumerId.Equals(input.ConsumerId))
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                hashCode = (hashCode * 59) + this.CustomField.GetHashCode();
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
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
