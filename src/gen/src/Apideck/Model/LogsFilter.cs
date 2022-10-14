/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.70.1
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
    /// LogsFilter
    /// </summary>
    [DataContract(Name = "LogsFilter")]
    public partial class LogsFilter : IEquatable<LogsFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogsFilter" /> class.
        /// </summary>
        /// <param name="connectorId">connectorId.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="excludeUnifiedApis">excludeUnifiedApis.</param>
        public LogsFilter(string connectorId = default(string), decimal? statusCode = default(decimal?), string excludeUnifiedApis = default(string))
        {
            this.ConnectorId = connectorId;
            this.StatusCode = statusCode;
            this.ExcludeUnifiedApis = excludeUnifiedApis;
        }

        /// <summary>
        /// Gets or Sets ConnectorId
        /// </summary>
        [DataMember(Name = "connector_id", EmitDefaultValue = true)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "status_code", EmitDefaultValue = true)]
        public decimal? StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeUnifiedApis
        /// </summary>
        [DataMember(Name = "exclude_unified_apis", EmitDefaultValue = true)]
        public string ExcludeUnifiedApis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogsFilter {\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ExcludeUnifiedApis: ").Append(ExcludeUnifiedApis).Append("\n");
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
            return this.Equals(input as LogsFilter);
        }

        /// <summary>
        /// Returns true if LogsFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of LogsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogsFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConnectorId == input.ConnectorId ||
                    (this.ConnectorId != null &&
                    this.ConnectorId.Equals(input.ConnectorId))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.ExcludeUnifiedApis == input.ExcludeUnifiedApis ||
                    (this.ExcludeUnifiedApis != null &&
                    this.ExcludeUnifiedApis.Equals(input.ExcludeUnifiedApis))
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
                if (this.ConnectorId != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectorId.GetHashCode();
                }
                if (this.StatusCode != null)
                {
                    hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                }
                if (this.ExcludeUnifiedApis != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeUnifiedApis.GetHashCode();
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
