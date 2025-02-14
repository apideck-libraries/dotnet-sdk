/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.4
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
    /// SupportedProperty
    /// </summary>
    [DataContract(Name = "SupportedProperty")]
    public partial class SupportedProperty : IEquatable<SupportedProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedProperty" /> class.
        /// </summary>
        /// <param name="unifiedProperty">Name of the property in our Unified API..</param>
        /// <param name="childProperties">List of child properties of the unified property..</param>
        public SupportedProperty(string unifiedProperty = default(string), List<SupportedProperty> childProperties = default(List<SupportedProperty>))
        {
            this.UnifiedProperty = unifiedProperty;
            this.ChildProperties = childProperties;
        }

        /// <summary>
        /// Name of the property in our Unified API.
        /// </summary>
        /// <value>Name of the property in our Unified API.</value>
        [DataMember(Name = "unified_property", EmitDefaultValue = false)]
        public string UnifiedProperty { get; set; }

        /// <summary>
        /// List of child properties of the unified property.
        /// </summary>
        /// <value>List of child properties of the unified property.</value>
        [DataMember(Name = "child_properties", EmitDefaultValue = false)]
        public List<SupportedProperty> ChildProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportedProperty {\n");
            sb.Append("  UnifiedProperty: ").Append(UnifiedProperty).Append("\n");
            sb.Append("  ChildProperties: ").Append(ChildProperties).Append("\n");
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
            return this.Equals(input as SupportedProperty);
        }

        /// <summary>
        /// Returns true if SupportedProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportedProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedProperty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnifiedProperty == input.UnifiedProperty ||
                    (this.UnifiedProperty != null &&
                    this.UnifiedProperty.Equals(input.UnifiedProperty))
                ) && 
                (
                    this.ChildProperties == input.ChildProperties ||
                    this.ChildProperties != null &&
                    input.ChildProperties != null &&
                    this.ChildProperties.SequenceEqual(input.ChildProperties)
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
                if (this.UnifiedProperty != null)
                {
                    hashCode = (hashCode * 59) + this.UnifiedProperty.GetHashCode();
                }
                if (this.ChildProperties != null)
                {
                    hashCode = (hashCode * 59) + this.ChildProperties.GetHashCode();
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
