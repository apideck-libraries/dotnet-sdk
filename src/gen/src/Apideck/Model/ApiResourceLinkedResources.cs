/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.43.0
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
    /// ApiResourceLinkedResources
    /// </summary>
    [DataContract(Name = "ApiResource_linked_resources")]
    public partial class ApiResourceLinkedResources : IEquatable<ApiResourceLinkedResources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResourceLinkedResources" /> class.
        /// </summary>
        /// <param name="id">ID of the resource, typically a lowercased version of name..</param>
        /// <param name="unifiedProperty">Name of the property in our Unified API..</param>
        public ApiResourceLinkedResources(string id = default(string), string unifiedProperty = default(string))
        {
            this.Id = id;
            this.UnifiedProperty = unifiedProperty;
        }

        /// <summary>
        /// ID of the resource, typically a lowercased version of name.
        /// </summary>
        /// <value>ID of the resource, typically a lowercased version of name.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the property in our Unified API.
        /// </summary>
        /// <value>Name of the property in our Unified API.</value>
        [DataMember(Name = "unified_property", EmitDefaultValue = false)]
        public string UnifiedProperty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiResourceLinkedResources {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ApiResourceLinkedResources);
        }

        /// <summary>
        /// Returns true if ApiResourceLinkedResources instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResourceLinkedResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResourceLinkedResources input)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
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
