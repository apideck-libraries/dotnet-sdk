/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.8.2
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
    /// GetModifiersResponse
    /// </summary>
    [DataContract(Name = "GetModifiersResponse")]
    public partial class GetModifiersResponse : IEquatable<GetModifiersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetModifiersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetModifiersResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetModifiersResponse" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP Response Status Code (required).</param>
        /// <param name="status">HTTP Response Status (required).</param>
        /// <param name="service">Apideck ID of service provider (required).</param>
        /// <param name="resource">Unified API resource name (required).</param>
        /// <param name="operation">Operation performed (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="meta">meta.</param>
        /// <param name="links">links.</param>
        public GetModifiersResponse(int statusCode = default(int), string status = default(string), string service = default(string), string resource = default(string), string operation = default(string), List<Modifier> data = default(List<Modifier>), Meta meta = default(Meta), Links links = default(Links))
        {
            this.StatusCode = statusCode;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for GetModifiersResponse and cannot be null");
            }
            this.Status = status;
            // to ensure "service" is required (not null)
            if (service == null) {
                throw new ArgumentNullException("service is a required property for GetModifiersResponse and cannot be null");
            }
            this.Service = service;
            // to ensure "resource" is required (not null)
            if (resource == null) {
                throw new ArgumentNullException("resource is a required property for GetModifiersResponse and cannot be null");
            }
            this.Resource = resource;
            // to ensure "operation" is required (not null)
            if (operation == null) {
                throw new ArgumentNullException("operation is a required property for GetModifiersResponse and cannot be null");
            }
            this.Operation = operation;
            // to ensure "data" is required (not null)
            if (data == null) {
                throw new ArgumentNullException("data is a required property for GetModifiersResponse and cannot be null");
            }
            this.Data = data;
            this.Meta = meta;
            this.Links = links;
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
        /// Apideck ID of service provider
        /// </summary>
        /// <value>Apideck ID of service provider</value>
        [DataMember(Name = "service", IsRequired = true, EmitDefaultValue = false)]
        public string Service { get; set; }

        /// <summary>
        /// Unified API resource name
        /// </summary>
        /// <value>Unified API resource name</value>
        [DataMember(Name = "resource", IsRequired = true, EmitDefaultValue = false)]
        public string Resource { get; set; }

        /// <summary>
        /// Operation performed
        /// </summary>
        /// <value>Operation performed</value>
        [DataMember(Name = "operation", IsRequired = true, EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public List<Modifier> Data { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public Meta Meta { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public Links Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetModifiersResponse {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as GetModifiersResponse);
        }

        /// <summary>
        /// Returns true if GetModifiersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetModifiersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetModifiersResponse input)
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
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
                }
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
