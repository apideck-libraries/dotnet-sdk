/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.91.0
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
    /// ApiResource
    /// </summary>
    [DataContract(Name = "ApiResource")]
    public partial class ApiResource : IEquatable<ApiResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ResourceStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResource" /> class.
        /// </summary>
        /// <param name="id">ID of the resource, typically a lowercased version of name..</param>
        /// <param name="name">Name of the resource (plural).</param>
        /// <param name="status">status.</param>
        /// <param name="linkedResources">List of linked resources..</param>
        /// <param name="schema">JSON Schema of the resource in our Unified API.</param>
        public ApiResource(string id = default(string), string name = default(string), ResourceStatus? status = default(ResourceStatus?), List<ApiResourceLinkedResources> linkedResources = default(List<ApiResourceLinkedResources>), Object schema = default(Object))
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.LinkedResources = linkedResources;
            this.Schema = schema;
        }

        /// <summary>
        /// ID of the resource, typically a lowercased version of name.
        /// </summary>
        /// <value>ID of the resource, typically a lowercased version of name.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the resource (plural)
        /// </summary>
        /// <value>Name of the resource (plural)</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// List of linked resources.
        /// </summary>
        /// <value>List of linked resources.</value>
        [DataMember(Name = "linked_resources", EmitDefaultValue = false)]
        public List<ApiResourceLinkedResources> LinkedResources { get; set; }

        /// <summary>
        /// JSON Schema of the resource in our Unified API
        /// </summary>
        /// <value>JSON Schema of the resource in our Unified API</value>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public Object Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LinkedResources: ").Append(LinkedResources).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
            return this.Equals(input as ApiResource);
        }

        /// <summary>
        /// Returns true if ApiResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResource input)
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
                    this.LinkedResources == input.LinkedResources ||
                    this.LinkedResources != null &&
                    input.LinkedResources != null &&
                    this.LinkedResources.SequenceEqual(input.LinkedResources)
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
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
                if (this.LinkedResources != null)
                {
                    hashCode = (hashCode * 59) + this.LinkedResources.GetHashCode();
                }
                if (this.Schema != null)
                {
                    hashCode = (hashCode * 59) + this.Schema.GetHashCode();
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
