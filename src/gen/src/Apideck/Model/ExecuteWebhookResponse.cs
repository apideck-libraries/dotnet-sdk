/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.72.0
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
    /// ExecuteWebhookResponse
    /// </summary>
    [DataContract(Name = "ExecuteWebhookResponse")]
    public partial class ExecuteWebhookResponse : IEquatable<ExecuteWebhookResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWebhookResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecuteWebhookResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWebhookResponse" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP Response Status Code (required).</param>
        /// <param name="status">HTTP Response Status (required).</param>
        /// <param name="requestId">UUID of the request received.</param>
        /// <param name="timestamp">ISO Dtae time webhook event was received.</param>
        public ExecuteWebhookResponse(int statusCode = default(int), string status = default(string), string requestId = default(string), string timestamp = default(string))
        {
            this.StatusCode = statusCode;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for ExecuteWebhookResponse and cannot be null");
            }
            this.Status = status;
            this.RequestId = requestId;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// HTTP Response Status Code
        /// </summary>
        /// <value>HTTP Response Status Code</value>
        [DataMember(Name = "status_code", IsRequired = true, EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// HTTP Response Status
        /// </summary>
        /// <value>HTTP Response Status</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// UUID of the request received
        /// </summary>
        /// <value>UUID of the request received</value>
        [DataMember(Name = "request_id", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// ISO Dtae time webhook event was received
        /// </summary>
        /// <value>ISO Dtae time webhook event was received</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExecuteWebhookResponse {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as ExecuteWebhookResponse);
        }

        /// <summary>
        /// Returns true if ExecuteWebhookResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecuteWebhookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteWebhookResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
