/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.6
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
    /// ApiResources
    /// </summary>
    [DataContract(Name = "Api_resources")]
    public partial class ApiResources : IEquatable<ApiResources>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ResourceStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResources" /> class.
        /// </summary>
        /// <param name="id">ID of the resource, typically a lowercased version of its name..</param>
        /// <param name="name">Name of the resource (plural).</param>
        /// <param name="status">status.</param>
        /// <param name="excludedFromCoverage">Exclude from mapping coverage.</param>
        public ApiResources(string id = default(string), string name = default(string), ResourceStatus? status = default(ResourceStatus?), bool excludedFromCoverage = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.ExcludedFromCoverage = excludedFromCoverage;
        }

        /// <summary>
        /// ID of the resource, typically a lowercased version of its name.
        /// </summary>
        /// <value>ID of the resource, typically a lowercased version of its name.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the resource (plural)
        /// </summary>
        /// <value>Name of the resource (plural)</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Exclude from mapping coverage
        /// </summary>
        /// <value>Exclude from mapping coverage</value>
        [DataMember(Name = "excluded_from_coverage", EmitDefaultValue = true)]
        public bool ExcludedFromCoverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiResources {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExcludedFromCoverage: ").Append(ExcludedFromCoverage).Append("\n");
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
            return this.Equals(input as ApiResources);
        }

        /// <summary>
        /// Returns true if ApiResources instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResources input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ExcludedFromCoverage == input.ExcludedFromCoverage ||
                    this.ExcludedFromCoverage.Equals(input.ExcludedFromCoverage)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.ExcludedFromCoverage.GetHashCode();
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
