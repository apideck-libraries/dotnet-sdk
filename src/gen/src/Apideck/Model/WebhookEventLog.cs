/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.8.1
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
    /// WebhookEventLog
    /// </summary>
    [DataContract(Name = "WebhookEventLog")]
    public partial class WebhookEventLog : IEquatable<WebhookEventLog>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets UnifiedApi
        /// </summary>
        [DataMember(Name = "unified_api", EmitDefaultValue = false)]
        public UnifiedApiId? UnifiedApi { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventLog" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="statusCode">HTTP Status code that was returned..</param>
        /// <param name="success">Whether or not the request was successful..</param>
        /// <param name="applicationId">ID of your Apideck Application.</param>
        /// <param name="consumerId">Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID..</param>
        /// <param name="unifiedApi">unifiedApi.</param>
        /// <param name="service">service.</param>
        /// <param name="endpoint">The URL of the webhook endpoint..</param>
        /// <param name="eventType">Name of source event that webhook is subscribed to..</param>
        /// <param name="executionAttempt">Number of attempts webhook endpoint was called before a success was returned or eventually failed.</param>
        /// <param name="httpMethod">HTTP Method of request to endpoint..</param>
        /// <param name="timestamp">ISO Date and time when the request was made..</param>
        /// <param name="entityType">Name of the Entity described by the attributes delivered within payload.</param>
        /// <param name="requestBody">The JSON stringified payload that was delivered to the webhook endpoint..</param>
        /// <param name="responseBody">The JSON stringified response that was returned from the webhook endpoint..</param>
        /// <param name="retryScheduled">If the request has not hit the max retry limit and will be retried..</param>
        /// <param name="attempts">record of each attempt to call webhook endpoint.</param>
        public WebhookEventLog(string id = default(string), int statusCode = default(int), bool success = default(bool), string applicationId = default(string), string consumerId = default(string), UnifiedApiId? unifiedApi = default(UnifiedApiId?), WebhookEventLogService service = default(WebhookEventLogService), string endpoint = default(string), string eventType = default(string), decimal executionAttempt = default(decimal), string httpMethod = default(string), string timestamp = default(string), string entityType = default(string), string requestBody = default(string), string responseBody = default(string), bool retryScheduled = default(bool), List<WebhookEventLogAttempts> attempts = default(List<WebhookEventLogAttempts>))
        {
            this.Id = id;
            this.StatusCode = statusCode;
            this.Success = success;
            this.ApplicationId = applicationId;
            this.ConsumerId = consumerId;
            this.UnifiedApi = unifiedApi;
            this.Service = service;
            this.Endpoint = endpoint;
            this.EventType = eventType;
            this.ExecutionAttempt = executionAttempt;
            this.HttpMethod = httpMethod;
            this.Timestamp = timestamp;
            this.EntityType = entityType;
            this.RequestBody = requestBody;
            this.ResponseBody = responseBody;
            this.RetryScheduled = retryScheduled;
            this.Attempts = attempts;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

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
        /// ID of your Apideck Application
        /// </summary>
        /// <value>ID of your Apideck Application</value>
        [DataMember(Name = "application_id", EmitDefaultValue = false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID.
        /// </summary>
        /// <value>Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID.</value>
        [DataMember(Name = "consumer_id", EmitDefaultValue = false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = false)]
        public WebhookEventLogService Service { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        /// <value>The URL of the webhook endpoint.</value>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Name of source event that webhook is subscribed to.
        /// </summary>
        /// <value>Name of source event that webhook is subscribed to.</value>
        [DataMember(Name = "event_type", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// Number of attempts webhook endpoint was called before a success was returned or eventually failed
        /// </summary>
        /// <value>Number of attempts webhook endpoint was called before a success was returned or eventually failed</value>
        [DataMember(Name = "execution_attempt", EmitDefaultValue = false)]
        public decimal ExecutionAttempt { get; set; }

        /// <summary>
        /// HTTP Method of request to endpoint.
        /// </summary>
        /// <value>HTTP Method of request to endpoint.</value>
        [DataMember(Name = "http_method", EmitDefaultValue = false)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// ISO Date and time when the request was made.
        /// </summary>
        /// <value>ISO Date and time when the request was made.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Name of the Entity described by the attributes delivered within payload
        /// </summary>
        /// <value>Name of the Entity described by the attributes delivered within payload</value>
        [DataMember(Name = "entity_type", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// The JSON stringified payload that was delivered to the webhook endpoint.
        /// </summary>
        /// <value>The JSON stringified payload that was delivered to the webhook endpoint.</value>
        [DataMember(Name = "request_body", EmitDefaultValue = false)]
        public string RequestBody { get; set; }

        /// <summary>
        /// The JSON stringified response that was returned from the webhook endpoint.
        /// </summary>
        /// <value>The JSON stringified response that was returned from the webhook endpoint.</value>
        [DataMember(Name = "response_body", EmitDefaultValue = false)]
        public string ResponseBody { get; set; }

        /// <summary>
        /// If the request has not hit the max retry limit and will be retried.
        /// </summary>
        /// <value>If the request has not hit the max retry limit and will be retried.</value>
        [DataMember(Name = "retry_scheduled", EmitDefaultValue = true)]
        public bool RetryScheduled { get; set; }

        /// <summary>
        /// record of each attempt to call webhook endpoint
        /// </summary>
        /// <value>record of each attempt to call webhook endpoint</value>
        [DataMember(Name = "attempts", EmitDefaultValue = false)]
        public List<WebhookEventLogAttempts> Attempts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookEventLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  ExecutionAttempt: ").Append(ExecutionAttempt).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  ResponseBody: ").Append(ResponseBody).Append("\n");
            sb.Append("  RetryScheduled: ").Append(RetryScheduled).Append("\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
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
            return this.Equals(input as WebhookEventLog);
        }

        /// <summary>
        /// Returns true if WebhookEventLog instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEventLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventLog input)
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
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
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
                    this.UnifiedApi == input.UnifiedApi ||
                    this.UnifiedApi.Equals(input.UnifiedApi)
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.ExecutionAttempt == input.ExecutionAttempt ||
                    this.ExecutionAttempt.Equals(input.ExecutionAttempt)
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.RequestBody == input.RequestBody ||
                    (this.RequestBody != null &&
                    this.RequestBody.Equals(input.RequestBody))
                ) && 
                (
                    this.ResponseBody == input.ResponseBody ||
                    (this.ResponseBody != null &&
                    this.ResponseBody.Equals(input.ResponseBody))
                ) && 
                (
                    this.RetryScheduled == input.RetryScheduled ||
                    this.RetryScheduled.Equals(input.RetryScheduled)
                ) && 
                (
                    this.Attempts == input.Attempts ||
                    this.Attempts != null &&
                    input.Attempts != null &&
                    this.Attempts.SequenceEqual(input.Attempts)
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
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExecutionAttempt.GetHashCode();
                if (this.HttpMethod != null)
                {
                    hashCode = (hashCode * 59) + this.HttpMethod.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                }
                if (this.RequestBody != null)
                {
                    hashCode = (hashCode * 59) + this.RequestBody.GetHashCode();
                }
                if (this.ResponseBody != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseBody.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RetryScheduled.GetHashCode();
                if (this.Attempts != null)
                {
                    hashCode = (hashCode * 59) + this.Attempts.GetHashCode();
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
            // Endpoint (string) pattern
            Regex regexEndpoint = new Regex(@"^(https?):\/\/", RegexOptions.CultureInvariant);
            if (false == regexEndpoint.Match(this.Endpoint).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Endpoint, must match a pattern of " + regexEndpoint, new [] { "Endpoint" });
            }

            yield break;
        }
    }

}
