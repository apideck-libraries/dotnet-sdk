/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.52.0
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
    /// CreateConnectionResponse
    /// </summary>
    [DataContract(Name = "CreateConnectionResponse")]
    public partial class CreateConnectionResponse : IEquatable<CreateConnectionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateConnectionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionResponse" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP Response Status Code (required).</param>
        /// <param name="status">HTTP Response Status (required).</param>
        /// <param name="data">data (required).</param>
        public CreateConnectionResponse(int statusCode = default(int), string status = default(string), Connection data = default(Connection))
        {
            this.StatusCode = statusCode;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for CreateConnectionResponse and cannot be null");
            }
            this.Status = status;
            // to ensure "data" is required (not null)
            if (data == null) {
                throw new ArgumentNullException("data is a required property for CreateConnectionResponse and cannot be null");
            }
            this.Data = data;
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
        public Connection Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateConnectionResponse {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as CreateConnectionResponse);
        }

        /// <summary>
        /// Returns true if CreateConnectionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConnectionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConnectionResponse input)
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
