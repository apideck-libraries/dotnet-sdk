/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.1
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
    /// Log
    /// </summary>
    [DataContract(Name = "Log")]
    public partial class Log : IEquatable<Log>, IValidatableObject
    {
        /// <summary>
        /// Which Unified Api request was made to.
        /// </summary>
        /// <value>Which Unified Api request was made to.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnifiedApiEnum
        {
            /// <summary>
            /// Enum Crm for value: crm
            /// </summary>
            [EnumMember(Value = "crm")]
            Crm = 1,

            /// <summary>
            /// Enum Lead for value: lead
            /// </summary>
            [EnumMember(Value = "lead")]
            Lead = 2,

            /// <summary>
            /// Enum Proxy for value: proxy
            /// </summary>
            [EnumMember(Value = "proxy")]
            Proxy = 3,

            /// <summary>
            /// Enum Vault for value: vault
            /// </summary>
            [EnumMember(Value = "vault")]
            Vault = 4,

            /// <summary>
            /// Enum Accounting for value: accounting
            /// </summary>
            [EnumMember(Value = "accounting")]
            Accounting = 5,

            /// <summary>
            /// Enum Hris for value: hris
            /// </summary>
            [EnumMember(Value = "hris")]
            Hris = 6,

            /// <summary>
            /// Enum Ats for value: ats
            /// </summary>
            [EnumMember(Value = "ats")]
            Ats = 7,

            /// <summary>
            /// Enum Ecommerce for value: ecommerce
            /// </summary>
            [EnumMember(Value = "ecommerce")]
            Ecommerce = 8,

            /// <summary>
            /// Enum IssueTracking for value: issue-tracking
            /// </summary>
            [EnumMember(Value = "issue-tracking")]
            IssueTracking = 9,

            /// <summary>
            /// Enum Pos for value: pos
            /// </summary>
            [EnumMember(Value = "pos")]
            Pos = 10,

            /// <summary>
            /// Enum FileStorage for value: file-storage
            /// </summary>
            [EnumMember(Value = "file-storage")]
            FileStorage = 11,

            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 12

        }


        /// <summary>
        /// Which Unified Api request was made to.
        /// </summary>
        /// <value>Which Unified Api request was made to.</value>
        [DataMember(Name = "unified_api", IsRequired = true, EmitDefaultValue = false)]
        public UnifiedApiEnum UnifiedApi { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Log() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        /// <param name="apiStyle">Indicates if the request was made via REST or Graphql endpoint. (required).</param>
        /// <param name="baseUrl">The Apideck base URL the request was made to. (required).</param>
        /// <param name="childRequest">Indicates whether or not this is a child or parent request. (required).</param>
        /// <param name="consumerId">The consumer Id associated with the request. (required).</param>
        /// <param name="duration">The entire execution time in milliseconds it took to call the Apideck service provider. (required).</param>
        /// <param name="errorMessage">If error occurred, this is brief explanation.</param>
        /// <param name="execution">The entire execution time in milliseconds it took to make the request. (required).</param>
        /// <param name="hasChildren">When request is a parent request, this indicates if there are child requests associated. (required).</param>
        /// <param name="httpMethod">HTTP Method of request. (required).</param>
        /// <param name="id">UUID acting as Request Identifier. (required).</param>
        /// <param name="latency">Latency added by making this request via Unified Api. (required).</param>
        /// <param name="operation">operation (required).</param>
        /// <param name="parentId">When request is a child request, this UUID indicates it&#39;s parent request. (required).</param>
        /// <param name="path">The path component of the URI the request was made to. (required).</param>
        /// <param name="sandbox">Indicates whether the request was made using Apidecks sandbox credentials or not. (required).</param>
        /// <param name="service">service (required).</param>
        /// <param name="sourceIp">The IP address of the source of the request..</param>
        /// <param name="statusCode">HTTP Status code that was returned. (required).</param>
        /// <param name="success">Whether or not the request was successful. (required).</param>
        /// <param name="timestamp">ISO Date and time when the request was made. (required).</param>
        /// <param name="unifiedApi">Which Unified Api request was made to. (required).</param>
        public Log(string apiStyle = default(string), string baseUrl = default(string), bool childRequest = default(bool), string consumerId = default(string), decimal duration = default(decimal), string errorMessage = default(string), int execution = default(int), bool hasChildren = default(bool), string httpMethod = default(string), string id = default(string), decimal latency = default(decimal), LogOperation operation = default(LogOperation), string parentId = default(string), string path = default(string), bool sandbox = default(bool), LogService service = default(LogService), string sourceIp = default(string), int statusCode = default(int), bool success = default(bool), string timestamp = default(string), UnifiedApiEnum unifiedApi = default(UnifiedApiEnum))
        {
            // to ensure "apiStyle" is required (not null)
            if (apiStyle == null) {
                throw new ArgumentNullException("apiStyle is a required property for Log and cannot be null");
            }
            this.ApiStyle = apiStyle;
            // to ensure "baseUrl" is required (not null)
            if (baseUrl == null) {
                throw new ArgumentNullException("baseUrl is a required property for Log and cannot be null");
            }
            this.BaseUrl = baseUrl;
            this.ChildRequest = childRequest;
            // to ensure "consumerId" is required (not null)
            if (consumerId == null) {
                throw new ArgumentNullException("consumerId is a required property for Log and cannot be null");
            }
            this.ConsumerId = consumerId;
            this.Duration = duration;
            this.Execution = execution;
            this.HasChildren = hasChildren;
            // to ensure "httpMethod" is required (not null)
            if (httpMethod == null) {
                throw new ArgumentNullException("httpMethod is a required property for Log and cannot be null");
            }
            this.HttpMethod = httpMethod;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for Log and cannot be null");
            }
            this.Id = id;
            this.Latency = latency;
            // to ensure "operation" is required (not null)
            if (operation == null) {
                throw new ArgumentNullException("operation is a required property for Log and cannot be null");
            }
            this.Operation = operation;
            // to ensure "parentId" is required (not null)
            if (parentId == null) {
                throw new ArgumentNullException("parentId is a required property for Log and cannot be null");
            }
            this.ParentId = parentId;
            // to ensure "path" is required (not null)
            if (path == null) {
                throw new ArgumentNullException("path is a required property for Log and cannot be null");
            }
            this.Path = path;
            this.Sandbox = sandbox;
            // to ensure "service" is required (not null)
            if (service == null) {
                throw new ArgumentNullException("service is a required property for Log and cannot be null");
            }
            this.Service = service;
            this.StatusCode = statusCode;
            this.Success = success;
            // to ensure "timestamp" is required (not null)
            if (timestamp == null) {
                throw new ArgumentNullException("timestamp is a required property for Log and cannot be null");
            }
            this.Timestamp = timestamp;
            this.UnifiedApi = unifiedApi;
            this.ErrorMessage = errorMessage;
            this.SourceIp = sourceIp;
        }

        /// <summary>
        /// Indicates if the request was made via REST or Graphql endpoint.
        /// </summary>
        /// <value>Indicates if the request was made via REST or Graphql endpoint.</value>
        [DataMember(Name = "api_style", IsRequired = true, EmitDefaultValue = false)]
        public string ApiStyle { get; set; }

        /// <summary>
        /// The Apideck base URL the request was made to.
        /// </summary>
        /// <value>The Apideck base URL the request was made to.</value>
        [DataMember(Name = "base_url", IsRequired = true, EmitDefaultValue = false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Indicates whether or not this is a child or parent request.
        /// </summary>
        /// <value>Indicates whether or not this is a child or parent request.</value>
        [DataMember(Name = "child_request", IsRequired = true, EmitDefaultValue = true)]
        public bool ChildRequest { get; set; }

        /// <summary>
        /// The consumer Id associated with the request.
        /// </summary>
        /// <value>The consumer Id associated with the request.</value>
        [DataMember(Name = "consumer_id", IsRequired = true, EmitDefaultValue = false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// The entire execution time in milliseconds it took to call the Apideck service provider.
        /// </summary>
        /// <value>The entire execution time in milliseconds it took to call the Apideck service provider.</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = false)]
        public decimal Duration { get; set; }

        /// <summary>
        /// If error occurred, this is brief explanation
        /// </summary>
        /// <value>If error occurred, this is brief explanation</value>
        [DataMember(Name = "error_message", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The entire execution time in milliseconds it took to make the request.
        /// </summary>
        /// <value>The entire execution time in milliseconds it took to make the request.</value>
        [DataMember(Name = "execution", IsRequired = true, EmitDefaultValue = false)]
        public int Execution { get; set; }

        /// <summary>
        /// When request is a parent request, this indicates if there are child requests associated.
        /// </summary>
        /// <value>When request is a parent request, this indicates if there are child requests associated.</value>
        [DataMember(Name = "has_children", IsRequired = true, EmitDefaultValue = true)]
        public bool HasChildren { get; set; }

        /// <summary>
        /// HTTP Method of request.
        /// </summary>
        /// <value>HTTP Method of request.</value>
        [DataMember(Name = "http_method", IsRequired = true, EmitDefaultValue = false)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// UUID acting as Request Identifier.
        /// </summary>
        /// <value>UUID acting as Request Identifier.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Latency added by making this request via Unified Api.
        /// </summary>
        /// <value>Latency added by making this request via Unified Api.</value>
        [DataMember(Name = "latency", IsRequired = true, EmitDefaultValue = false)]
        public decimal Latency { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", IsRequired = true, EmitDefaultValue = false)]
        public LogOperation Operation { get; set; }

        /// <summary>
        /// When request is a child request, this UUID indicates it&#39;s parent request.
        /// </summary>
        /// <value>When request is a child request, this UUID indicates it&#39;s parent request.</value>
        [DataMember(Name = "parent_id", IsRequired = true, EmitDefaultValue = true)]
        public string ParentId { get; set; }

        /// <summary>
        /// The path component of the URI the request was made to.
        /// </summary>
        /// <value>The path component of the URI the request was made to.</value>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Indicates whether the request was made using Apidecks sandbox credentials or not.
        /// </summary>
        /// <value>Indicates whether the request was made using Apidecks sandbox credentials or not.</value>
        [DataMember(Name = "sandbox", IsRequired = true, EmitDefaultValue = true)]
        public bool Sandbox { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", IsRequired = true, EmitDefaultValue = false)]
        public LogService Service { get; set; }

        /// <summary>
        /// The IP address of the source of the request.
        /// </summary>
        /// <value>The IP address of the source of the request.</value>
        [DataMember(Name = "source_ip", EmitDefaultValue = true)]
        public string SourceIp { get; set; }

        /// <summary>
        /// HTTP Status code that was returned.
        /// </summary>
        /// <value>HTTP Status code that was returned.</value>
        [DataMember(Name = "status_code", IsRequired = true, EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Whether or not the request was successful.
        /// </summary>
        /// <value>Whether or not the request was successful.</value>
        [DataMember(Name = "success", IsRequired = true, EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// ISO Date and time when the request was made.
        /// </summary>
        /// <value>ISO Date and time when the request was made.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Log {\n");
            sb.Append("  ApiStyle: ").Append(ApiStyle).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  ChildRequest: ").Append(ChildRequest).Append("\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Execution: ").Append(Execution).Append("\n");
            sb.Append("  HasChildren: ").Append(HasChildren).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Latency: ").Append(Latency).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Sandbox: ").Append(Sandbox).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  SourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
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
            return this.Equals(input as Log);
        }

        /// <summary>
        /// Returns true if Log instances are equal
        /// </summary>
        /// <param name="input">Instance of Log to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Log input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiStyle == input.ApiStyle ||
                    (this.ApiStyle != null &&
                    this.ApiStyle.Equals(input.ApiStyle))
                ) && 
                (
                    this.BaseUrl == input.BaseUrl ||
                    (this.BaseUrl != null &&
                    this.BaseUrl.Equals(input.BaseUrl))
                ) && 
                (
                    this.ChildRequest == input.ChildRequest ||
                    this.ChildRequest.Equals(input.ChildRequest)
                ) && 
                (
                    this.ConsumerId == input.ConsumerId ||
                    (this.ConsumerId != null &&
                    this.ConsumerId.Equals(input.ConsumerId))
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Execution == input.Execution ||
                    this.Execution.Equals(input.Execution)
                ) && 
                (
                    this.HasChildren == input.HasChildren ||
                    this.HasChildren.Equals(input.HasChildren)
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Latency == input.Latency ||
                    this.Latency.Equals(input.Latency)
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Sandbox == input.Sandbox ||
                    this.Sandbox.Equals(input.Sandbox)
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.SourceIp == input.SourceIp ||
                    (this.SourceIp != null &&
                    this.SourceIp.Equals(input.SourceIp))
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
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.UnifiedApi == input.UnifiedApi ||
                    this.UnifiedApi.Equals(input.UnifiedApi)
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
                if (this.ApiStyle != null)
                {
                    hashCode = (hashCode * 59) + this.ApiStyle.GetHashCode();
                }
                if (this.BaseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BaseUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChildRequest.GetHashCode();
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Execution.GetHashCode();
                hashCode = (hashCode * 59) + this.HasChildren.GetHashCode();
                if (this.HttpMethod != null)
                {
                    hashCode = (hashCode * 59) + this.HttpMethod.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Latency.GetHashCode();
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Sandbox.GetHashCode();
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.SourceIp != null)
                {
                    hashCode = (hashCode * 59) + this.SourceIp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
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
