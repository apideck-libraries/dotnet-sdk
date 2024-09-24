/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.5
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
    /// Consumer
    /// </summary>
    [DataContract(Name = "Consumer")]
    public partial class Consumer : IEquatable<Consumer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Consumer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Consumer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Consumer" /> class.
        /// </summary>
        /// <param name="consumerId">Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID. (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="requestCounts">requestCounts.</param>
        public Consumer(string consumerId = default(string), ConsumerMetadata metadata = default(ConsumerMetadata), RequestCountAllocation requestCounts = default(RequestCountAllocation))
        {
            // to ensure "consumerId" is required (not null)
            if (consumerId == null) {
                throw new ArgumentNullException("consumerId is a required property for Consumer and cannot be null");
            }
            this.ConsumerId = consumerId;
            this.Metadata = metadata;
            this.RequestCounts = requestCounts;
        }

        /// <summary>
        /// Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID.
        /// </summary>
        /// <value>Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID.</value>
        [DataMember(Name = "consumer_id", IsRequired = true, EmitDefaultValue = false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// ID of your Apideck Application
        /// </summary>
        /// <value>ID of your Apideck Application</value>
        [DataMember(Name = "application_id", EmitDefaultValue = false)]
        public string ApplicationId { get; private set; }

        /// <summary>
        /// Returns false as ApplicationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApplicationId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public ConsumerMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Connections
        /// </summary>
        [DataMember(Name = "connections", EmitDefaultValue = false)]
        public List<ConsumerConnection> Connections { get; private set; }

        /// <summary>
        /// Returns false as Connections should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConnections()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services", EmitDefaultValue = false)]
        public List<string> Services { get; private set; }

        /// <summary>
        /// Returns false as Services should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeServices()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AggregatedRequestCount
        /// </summary>
        [DataMember(Name = "aggregated_request_count", EmitDefaultValue = false)]
        public decimal AggregatedRequestCount { get; private set; }

        /// <summary>
        /// Returns false as AggregatedRequestCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAggregatedRequestCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RequestCounts
        /// </summary>
        [DataMember(Name = "request_counts", EmitDefaultValue = false)]
        public RequestCountAllocation RequestCounts { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public string Modified { get; private set; }

        /// <summary>
        /// Returns false as Modified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeModified()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RequestCountUpdated
        /// </summary>
        [DataMember(Name = "request_count_updated", EmitDefaultValue = false)]
        public string RequestCountUpdated { get; private set; }

        /// <summary>
        /// Returns false as RequestCountUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequestCountUpdated()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Consumer {\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  AggregatedRequestCount: ").Append(AggregatedRequestCount).Append("\n");
            sb.Append("  RequestCounts: ").Append(RequestCounts).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  RequestCountUpdated: ").Append(RequestCountUpdated).Append("\n");
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
            return this.Equals(input as Consumer);
        }

        /// <summary>
        /// Returns true if Consumer instances are equal
        /// </summary>
        /// <param name="input">Instance of Consumer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Consumer input)
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
                    this.Connections == input.Connections ||
                    this.Connections != null &&
                    input.Connections != null &&
                    this.Connections.SequenceEqual(input.Connections)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
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
                if (this.Connections != null)
                {
                    hashCode = (hashCode * 59) + this.Connections.GetHashCode();
                }
                if (this.Services != null)
                {
                    hashCode = (hashCode * 59) + this.Services.GetHashCode();
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
