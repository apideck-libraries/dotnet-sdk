/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.9.1
 * Contact: support@apideck.com
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
    /// WebhookEventLogAttempts
    /// </summary>
    [DataContract(Name = "WebhookEventLog_attempts")]
    public partial class WebhookEventLogAttempts : IEquatable<WebhookEventLogAttempts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventLogAttempts" /> class.
        /// </summary>
        /// <param name="timestamp">ISO Date and time when the request was made..</param>
        /// <param name="executionAttempt">Number of attempts webhook endpoint was called before a success was returned or eventually failed.</param>
        /// <param name="statusCode">HTTP Status code that was returned..</param>
        /// <param name="success">Whether or not the request was successful..</param>
        public WebhookEventLogAttempts(string timestamp = default(string), decimal executionAttempt = default(decimal), int statusCode = default(int), bool success = default(bool))
        {
            this.Timestamp = timestamp;
            this.ExecutionAttempt = executionAttempt;
            this.StatusCode = statusCode;
            this.Success = success;
        }

        /// <summary>
        /// ISO Date and time when the request was made.
        /// </summary>
        /// <value>ISO Date and time when the request was made.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Number of attempts webhook endpoint was called before a success was returned or eventually failed
        /// </summary>
        /// <value>Number of attempts webhook endpoint was called before a success was returned or eventually failed</value>
        [DataMember(Name = "execution_attempt", EmitDefaultValue = false)]
        public decimal ExecutionAttempt { get; set; }

        /// <summary>
        /// HTTP Status code that was returned.
        /// </summary>
        /// <value>HTTP Status code that was returned.</value>
        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Whether or not the request was successful.
        /// </summary>
        /// <value>Whether or not the request was successful.</value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookEventLogAttempts {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ExecutionAttempt: ").Append(ExecutionAttempt).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as WebhookEventLogAttempts);
        }

        /// <summary>
        /// Returns true if WebhookEventLogAttempts instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEventLogAttempts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventLogAttempts input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.ExecutionAttempt == input.ExecutionAttempt ||
                    this.ExecutionAttempt.Equals(input.ExecutionAttempt)
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
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
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExecutionAttempt.GetHashCode();
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
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
