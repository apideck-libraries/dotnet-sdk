/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.12.2
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
    /// GetResourceExampleResponse
    /// </summary>
    [DataContract(Name = "GetResourceExampleResponse")]
    public partial class GetResourceExampleResponse : IEquatable<GetResourceExampleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetResourceExampleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetResourceExampleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetResourceExampleResponse" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP Response Status Code (required).</param>
        /// <param name="status">HTTP Response Status (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="raw">Raw response from the integration when raw&#x3D;true query param is provided.</param>
        public GetResourceExampleResponse(int statusCode = default(int), string status = default(string), ResourceExample data = default(ResourceExample), Dictionary<string, Object> raw = default(Dictionary<string, Object>))
        {
            this.StatusCode = statusCode;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for GetResourceExampleResponse and cannot be null");
            }
            this.Status = status;
            // to ensure "data" is required (not null)
            if (data == null) {
                throw new ArgumentNullException("data is a required property for GetResourceExampleResponse and cannot be null");
            }
            this.Data = data;
            this.Raw = raw;
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
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public ResourceExample Data { get; set; }

        /// <summary>
        /// Raw response from the integration when raw&#x3D;true query param is provided
        /// </summary>
        /// <value>Raw response from the integration when raw&#x3D;true query param is provided</value>
        [DataMember(Name = "_raw", EmitDefaultValue = true)]
        public Dictionary<string, Object> Raw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetResourceExampleResponse {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
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
            return this.Equals(input as GetResourceExampleResponse);
        }

        /// <summary>
        /// Returns true if GetResourceExampleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetResourceExampleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetResourceExampleResponse input)
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
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Raw == input.Raw ||
                    this.Raw != null &&
                    input.Raw != null &&
                    this.Raw.SequenceEqual(input.Raw)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Raw != null)
                {
                    hashCode = (hashCode * 59) + this.Raw.GetHashCode();
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
