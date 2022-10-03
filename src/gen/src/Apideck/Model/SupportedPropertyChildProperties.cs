/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.66.1
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
    /// SupportedPropertyChildProperties
    /// </summary>
    [DataContract(Name = "SupportedProperty_child_properties")]
    public partial class SupportedPropertyChildProperties : IEquatable<SupportedPropertyChildProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedPropertyChildProperties" /> class.
        /// </summary>
        /// <param name="unifiedProperty">unifiedProperty.</param>
        public SupportedPropertyChildProperties(SupportedProperty unifiedProperty = default(SupportedProperty))
        {
            this.UnifiedProperty = unifiedProperty;
        }

        /// <summary>
        /// Gets or Sets UnifiedProperty
        /// </summary>
        [DataMember(Name = "unified_property", EmitDefaultValue = false)]
        public SupportedProperty UnifiedProperty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportedPropertyChildProperties {\n");
            sb.Append("  UnifiedProperty: ").Append(UnifiedProperty).Append("\n");
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
            return this.Equals(input as SupportedPropertyChildProperties);
        }

        /// <summary>
        /// Returns true if SupportedPropertyChildProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportedPropertyChildProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedPropertyChildProperties input)
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