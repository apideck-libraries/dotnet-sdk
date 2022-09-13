/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.57.0
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
    /// Passthrough
    /// </summary>
    [DataContract(Name = "Passthrough")]
    public partial class Passthrough : Dictionary<String, Object>, IEquatable<Passthrough>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Passthrough" /> class.
        /// </summary>
        /// <param name="exampleDownstreamProperty">All passthrough query parameters are passed along to the connector as is (?pass_through[search]&#x3D;leads becomes ?search&#x3D;leads).</param>
        public Passthrough(string exampleDownstreamProperty = default(string)) : base()
        {
            this.ExampleDownstreamProperty = exampleDownstreamProperty;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// All passthrough query parameters are passed along to the connector as is (?pass_through[search]&#x3D;leads becomes ?search&#x3D;leads)
        /// </summary>
        /// <value>All passthrough query parameters are passed along to the connector as is (?pass_through[search]&#x3D;leads becomes ?search&#x3D;leads)</value>
        [DataMember(Name = "example_downstream_property", EmitDefaultValue = false)]
        public string ExampleDownstreamProperty { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Passthrough {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ExampleDownstreamProperty: ").Append(ExampleDownstreamProperty).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as Passthrough);
        }

        /// <summary>
        /// Returns true if Passthrough instances are equal
        /// </summary>
        /// <param name="input">Instance of Passthrough to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Passthrough input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ExampleDownstreamProperty == input.ExampleDownstreamProperty ||
                    (this.ExampleDownstreamProperty != null &&
                    this.ExampleDownstreamProperty.Equals(input.ExampleDownstreamProperty))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.ExampleDownstreamProperty != null)
                {
                    hashCode = (hashCode * 59) + this.ExampleDownstreamProperty.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
