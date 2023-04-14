/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.4
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
    /// LinkedConnectorResource
    /// </summary>
    [DataContract(Name = "LinkedConnectorResource")]
    public partial class LinkedConnectorResource : IEquatable<LinkedConnectorResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ResourceStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedConnectorResource" /> class.
        /// </summary>
        /// <param name="id">ID of the resource, typically a lowercased version of name..</param>
        /// <param name="name">Name of the resource (plural).</param>
        /// <param name="status">status.</param>
        /// <param name="downstreamId">ID of the resource in the Connector&#39;s API (downstream).</param>
        /// <param name="downstreamName">Name of the resource in the Connector&#39;s API (downstream).</param>
        public LinkedConnectorResource(string id = default(string), string name = default(string), ResourceStatus? status = default(ResourceStatus?), string downstreamId = default(string), string downstreamName = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.DownstreamId = downstreamId;
            this.DownstreamName = downstreamName;
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
        /// ID of the resource in the Connector&#39;s API (downstream)
        /// </summary>
        /// <value>ID of the resource in the Connector&#39;s API (downstream)</value>
        [DataMember(Name = "downstream_id", EmitDefaultValue = false)]
        public string DownstreamId { get; set; }

        /// <summary>
        /// Name of the resource in the Connector&#39;s API (downstream)
        /// </summary>
        /// <value>Name of the resource in the Connector&#39;s API (downstream)</value>
        [DataMember(Name = "downstream_name", EmitDefaultValue = false)]
        public string DownstreamName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkedConnectorResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  DownstreamName: ").Append(DownstreamName).Append("\n");
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
            return this.Equals(input as LinkedConnectorResource);
        }

        /// <summary>
        /// Returns true if LinkedConnectorResource instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedConnectorResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedConnectorResource input)
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
                    this.DownstreamId == input.DownstreamId ||
                    (this.DownstreamId != null &&
                    this.DownstreamId.Equals(input.DownstreamId))
                ) && 
                (
                    this.DownstreamName == input.DownstreamName ||
                    (this.DownstreamName != null &&
                    this.DownstreamName.Equals(input.DownstreamName))
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
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                if (this.DownstreamName != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamName.GetHashCode();
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
