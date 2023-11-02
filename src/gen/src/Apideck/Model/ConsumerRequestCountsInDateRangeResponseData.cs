/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.0.1
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
    /// ConsumerRequestCountsInDateRangeResponseData
    /// </summary>
    [DataContract(Name = "ConsumerRequestCountsInDateRangeResponse_data")]
    public partial class ConsumerRequestCountsInDateRangeResponseData : IEquatable<ConsumerRequestCountsInDateRangeResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumerRequestCountsInDateRangeResponseData" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="consumerId">consumerId.</param>
        /// <param name="startDatetime">startDatetime.</param>
        /// <param name="endDatetime">endDatetime.</param>
        /// <param name="aggregatedRequestCount">aggregatedRequestCount.</param>
        /// <param name="requestCounts">requestCounts.</param>
        public ConsumerRequestCountsInDateRangeResponseData(string applicationId = default(string), string consumerId = default(string), string startDatetime = default(string), string endDatetime = default(string), decimal aggregatedRequestCount = default(decimal), RequestCountAllocation requestCounts = default(RequestCountAllocation))
        {
            this.ApplicationId = applicationId;
            this.ConsumerId = consumerId;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
            this.AggregatedRequestCount = aggregatedRequestCount;
            this.RequestCounts = requestCounts;
        }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "application_id", EmitDefaultValue = false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerId
        /// </summary>
        [DataMember(Name = "consumer_id", EmitDefaultValue = false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// Gets or Sets StartDatetime
        /// </summary>
        [DataMember(Name = "start_datetime", EmitDefaultValue = false)]
        public string StartDatetime { get; set; }

        /// <summary>
        /// Gets or Sets EndDatetime
        /// </summary>
        [DataMember(Name = "end_datetime", EmitDefaultValue = false)]
        public string EndDatetime { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConsumerRequestCountsInDateRangeResponseData {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  StartDatetime: ").Append(StartDatetime).Append("\n");
            sb.Append("  EndDatetime: ").Append(EndDatetime).Append("\n");
            sb.Append("  AggregatedRequestCount: ").Append(AggregatedRequestCount).Append("\n");
            sb.Append("  RequestCounts: ").Append(RequestCounts).Append("\n");
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
            return this.Equals(input as ConsumerRequestCountsInDateRangeResponseData);
        }

        /// <summary>
        /// Returns true if ConsumerRequestCountsInDateRangeResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsumerRequestCountsInDateRangeResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumerRequestCountsInDateRangeResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ConsumerId == input.ConsumerId ||
                    (this.ConsumerId != null &&
                    this.ConsumerId.Equals(input.ConsumerId))
                ) && 
                (
                    this.StartDatetime == input.StartDatetime ||
                    (this.StartDatetime != null &&
                    this.StartDatetime.Equals(input.StartDatetime))
                ) && 
                (
                    this.EndDatetime == input.EndDatetime ||
                    (this.EndDatetime != null &&
                    this.EndDatetime.Equals(input.EndDatetime))
                ) && 
                (
                    this.AggregatedRequestCount == input.AggregatedRequestCount ||
                    this.AggregatedRequestCount.Equals(input.AggregatedRequestCount)
                ) && 
                (
                    this.RequestCounts == input.RequestCounts ||
                    (this.RequestCounts != null &&
                    this.RequestCounts.Equals(input.RequestCounts))
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
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
                }
                if (this.StartDatetime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDatetime.GetHashCode();
                }
                if (this.EndDatetime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDatetime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AggregatedRequestCount.GetHashCode();
                if (this.RequestCounts != null)
                {
                    hashCode = (hashCode * 59) + this.RequestCounts.GetHashCode();
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
