/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.37.0
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
    /// GetConsumersResponseData
    /// </summary>
    [DataContract(Name = "GetConsumersResponse_data")]
    public partial class GetConsumersResponseData : IEquatable<GetConsumersResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetConsumersResponseData" /> class.
        /// </summary>
        /// <param name="consumerId">consumerId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="aggregatedRequestCount">aggregatedRequestCount.</param>
        /// <param name="requestCounts">requestCounts.</param>
        /// <param name="created">created.</param>
        /// <param name="modified">modified.</param>
        /// <param name="requestCountUpdated">requestCountUpdated.</param>
        /// <param name="services">services.</param>
        public GetConsumersResponseData(string consumerId = default(string), string applicationId = default(string), ConsumerMetadata metadata = default(ConsumerMetadata), decimal aggregatedRequestCount = default(decimal), RequestCountAllocation requestCounts = default(RequestCountAllocation), string created = default(string), string modified = default(string), string requestCountUpdated = default(string), List<string> services = default(List<string>))
        {
            this.ConsumerId = consumerId;
            this.ApplicationId = applicationId;
            this.Metadata = metadata;
            this.AggregatedRequestCount = aggregatedRequestCount;
            this.RequestCounts = requestCounts;
            this.Created = created;
            this.Modified = modified;
            this.RequestCountUpdated = requestCountUpdated;
            this.Services = services;
        }

        /// <summary>
        /// Gets or Sets ConsumerId
        /// </summary>
        [DataMember(Name = "consumer_id", EmitDefaultValue = false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "application_id", EmitDefaultValue = false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public ConsumerMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets AggregatedRequestCount
        /// </summary>
        [DataMember(Name = "aggregated_request_count", EmitDefaultValue = false)]
        public decimal AggregatedRequestCount { get; set; }

        /// <summary>
        /// Gets or Sets RequestCounts
        /// </summary>
        [DataMember(Name = "request_counts", EmitDefaultValue = false)]
        public RequestCountAllocation RequestCounts { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public string Modified { get; set; }

        /// <summary>
        /// Gets or Sets RequestCountUpdated
        /// </summary>
        [DataMember(Name = "request_count_updated", EmitDefaultValue = false)]
        public string RequestCountUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services", EmitDefaultValue = false)]
        public List<string> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetConsumersResponseData {\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  AggregatedRequestCount: ").Append(AggregatedRequestCount).Append("\n");
            sb.Append("  RequestCounts: ").Append(RequestCounts).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  RequestCountUpdated: ").Append(RequestCountUpdated).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
            return this.Equals(input as GetConsumersResponseData);
        }

        /// <summary>
        /// Returns true if GetConsumersResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of GetConsumersResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetConsumersResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsumerId == input.ConsumerId ||
                    (this.ConsumerId != null &&
                    this.ConsumerId.Equals(input.ConsumerId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.AggregatedRequestCount == input.AggregatedRequestCount ||
                    this.AggregatedRequestCount.Equals(input.AggregatedRequestCount)
                ) && 
                (
                    this.RequestCounts == input.RequestCounts ||
                    (this.RequestCounts != null &&
                    this.RequestCounts.Equals(input.RequestCounts))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.RequestCountUpdated == input.RequestCountUpdated ||
                    (this.RequestCountUpdated != null &&
                    this.RequestCountUpdated.Equals(input.RequestCountUpdated))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
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
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
                }
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AggregatedRequestCount.GetHashCode();
                if (this.RequestCounts != null)
                {
                    hashCode = (hashCode * 59) + this.RequestCounts.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Modified != null)
                {
                    hashCode = (hashCode * 59) + this.Modified.GetHashCode();
                }
                if (this.RequestCountUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.RequestCountUpdated.GetHashCode();
                }
                if (this.Services != null)
                {
                    hashCode = (hashCode * 59) + this.Services.GetHashCode();
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
