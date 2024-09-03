/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.2
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
    /// ConnectionConfiguration
    /// </summary>
    [DataContract(Name = "Connection_configuration")]
    public partial class ConnectionConfiguration : IEquatable<ConnectionConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionConfiguration" /> class.
        /// </summary>
        /// <param name="resource">resource.</param>
        /// <param name="defaults">defaults.</param>
        public ConnectionConfiguration(string resource = default(string), List<ConnectionDefaults> defaults = default(List<ConnectionDefaults>))
        {
            this.Resource = resource;
            this.Defaults = defaults;
        }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or Sets Defaults
        /// </summary>
        [DataMember(Name = "defaults", EmitDefaultValue = false)]
        public List<ConnectionDefaults> Defaults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectionConfiguration {\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Defaults: ").Append(Defaults).Append("\n");
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
            return this.Equals(input as ConnectionConfiguration);
        }

        /// <summary>
        /// Returns true if ConnectionConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.Defaults == input.Defaults ||
                    this.Defaults != null &&
                    input.Defaults != null &&
                    this.Defaults.SequenceEqual(input.Defaults)
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
                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
                }
                if (this.Defaults != null)
                {
                    hashCode = (hashCode * 59) + this.Defaults.GetHashCode();
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
