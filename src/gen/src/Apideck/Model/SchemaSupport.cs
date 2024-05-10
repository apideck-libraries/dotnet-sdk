/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.4.2
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
    /// When a connector has schema_support, a call can be made to retrieve a json schema that describes a downstream resource.
    /// </summary>
    [DataContract(Name = "SchemaSupport")]
    public partial class SchemaSupport : IEquatable<SchemaSupport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaSupport" /> class.
        /// </summary>
        /// <param name="supported">Can a resource schema be retrieved for this connector?.</param>
        public SchemaSupport(bool supported = default(bool))
        {
            this.Supported = supported;
        }

        /// <summary>
        /// Can a resource schema be retrieved for this connector?
        /// </summary>
        /// <value>Can a resource schema be retrieved for this connector?</value>
        [DataMember(Name = "supported", EmitDefaultValue = true)]
        public bool Supported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SchemaSupport {\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
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
            return this.Equals(input as SchemaSupport);
        }

        /// <summary>
        /// Returns true if SchemaSupport instances are equal
        /// </summary>
        /// <param name="input">Instance of SchemaSupport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaSupport input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Supported == input.Supported ||
                    this.Supported.Equals(input.Supported)
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
                hashCode = (hashCode * 59) + this.Supported.GetHashCode();
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
