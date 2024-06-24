/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.6.1
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
    /// IssuesFilter
    /// </summary>
    [DataContract(Name = "IssuesFilter")]
    public partial class IssuesFilter : IEquatable<IssuesFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesFilter" /> class.
        /// </summary>
        /// <param name="status">Filter by ticket status, can be &#x60;open&#x60;, &#x60;closed&#x60; or &#x60;all&#x60;. Will passthrough if none of the above match.</param>
        /// <param name="since">Only return tickets since a specific date.</param>
        /// <param name="assigneeId">Only return tickets assigned to a specific user.</param>
        public IssuesFilter(List<string> status = default(List<string>), DateTime since = default(DateTime), string assigneeId = default(string))
        {
            this.Status = status;
            this.Since = since;
            this.AssigneeId = assigneeId;
        }

        /// <summary>
        /// Filter by ticket status, can be &#x60;open&#x60;, &#x60;closed&#x60; or &#x60;all&#x60;. Will passthrough if none of the above match
        /// </summary>
        /// <value>Filter by ticket status, can be &#x60;open&#x60;, &#x60;closed&#x60; or &#x60;all&#x60;. Will passthrough if none of the above match</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// Only return tickets since a specific date
        /// </summary>
        /// <value>Only return tickets since a specific date</value>
        [DataMember(Name = "since", EmitDefaultValue = false)]
        public DateTime Since { get; set; }

        /// <summary>
        /// Only return tickets assigned to a specific user
        /// </summary>
        /// <value>Only return tickets assigned to a specific user</value>
        [DataMember(Name = "assignee_id", EmitDefaultValue = false)]
        public string AssigneeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuesFilter {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
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
            return this.Equals(input as IssuesFilter);
        }

        /// <summary>
        /// Returns true if IssuesFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuesFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuesFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
                ) && 
                (
                    this.Since == input.Since ||
                    (this.Since != null &&
                    this.Since.Equals(input.Since))
                ) && 
                (
                    this.AssigneeId == input.AssigneeId ||
                    (this.AssigneeId != null &&
                    this.AssigneeId.Equals(input.AssigneeId))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Since != null)
                {
                    hashCode = (hashCode * 59) + this.Since.GetHashCode();
                }
                if (this.AssigneeId != null)
                {
                    hashCode = (hashCode * 59) + this.AssigneeId.GetHashCode();
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
