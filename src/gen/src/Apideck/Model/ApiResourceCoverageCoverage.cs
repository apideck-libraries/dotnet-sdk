/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.1
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
    /// ApiResourceCoverageCoverage
    /// </summary>
    [DataContract(Name = "ApiResourceCoverage_coverage")]
    public partial class ApiResourceCoverageCoverage : IEquatable<ApiResourceCoverageCoverage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResourceCoverageCoverage" /> class.
        /// </summary>
        /// <param name="downstreamId">ID of the resource in the Connector&#39;s API (downstream).</param>
        /// <param name="downstreamName">Name of the resource in the Connector&#39;s API (downstream).</param>
        /// <param name="paginationSupported">Indicates if pagination (cursor and limit parameters) is supported on the list endpoint of the resource..</param>
        /// <param name="supportedOperations">List of supported operations on the resource..</param>
        /// <param name="supportedFilters">Supported filters on the list endpoint of the resource..</param>
        /// <param name="supportedSortBy">Supported sorting properties on the list endpoint of the resource..</param>
        /// <param name="supportedFields">Supported fields..</param>
        public ApiResourceCoverageCoverage(string downstreamId = default(string), string downstreamName = default(string), bool paginationSupported = default(bool), List<string> supportedOperations = default(List<string>), List<string> supportedFilters = default(List<string>), List<string> supportedSortBy = default(List<string>), List<ApiResourceCoverageSupportedFields> supportedFields = default(List<ApiResourceCoverageSupportedFields>))
        {
            this.DownstreamId = downstreamId;
            this.DownstreamName = downstreamName;
            this.PaginationSupported = paginationSupported;
            this.SupportedOperations = supportedOperations;
            this.SupportedFilters = supportedFilters;
            this.SupportedSortBy = supportedSortBy;
            this.SupportedFields = supportedFields;
        }

        /// <summary>
        /// ID of the resource in the Connector&#39;s API (downstream)
        /// </summary>
        /// <value>ID of the resource in the Connector&#39;s API (downstream)</value>
        [DataMember(Name = "downstream_id", EmitDefaultValue = false)]
        public string DownstreamId { get; set; }

        /// <summary>
        /// Name of the resource in the Connector&#39;s API (downstream)
        /// </summary>
        /// <value>Name of the resource in the Connector&#39;s API (downstream)</value>
        [DataMember(Name = "downstream_name", EmitDefaultValue = false)]
        public string DownstreamName { get; set; }

        /// <summary>
        /// Indicates if pagination (cursor and limit parameters) is supported on the list endpoint of the resource.
        /// </summary>
        /// <value>Indicates if pagination (cursor and limit parameters) is supported on the list endpoint of the resource.</value>
        [DataMember(Name = "pagination_supported", EmitDefaultValue = true)]
        public bool PaginationSupported { get; set; }

        /// <summary>
        /// List of supported operations on the resource.
        /// </summary>
        /// <value>List of supported operations on the resource.</value>
        [DataMember(Name = "supported_operations", EmitDefaultValue = false)]
        public List<string> SupportedOperations { get; set; }

        /// <summary>
        /// Supported filters on the list endpoint of the resource.
        /// </summary>
        /// <value>Supported filters on the list endpoint of the resource.</value>
        [DataMember(Name = "supported_filters", EmitDefaultValue = false)]
        public List<string> SupportedFilters { get; set; }

        /// <summary>
        /// Supported sorting properties on the list endpoint of the resource.
        /// </summary>
        /// <value>Supported sorting properties on the list endpoint of the resource.</value>
        [DataMember(Name = "supported_sort_by", EmitDefaultValue = false)]
        public List<string> SupportedSortBy { get; set; }

        /// <summary>
        /// Supported fields.
        /// </summary>
        /// <value>Supported fields.</value>
        [DataMember(Name = "supported_fields", EmitDefaultValue = false)]
        public List<ApiResourceCoverageSupportedFields> SupportedFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiResourceCoverageCoverage {\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  DownstreamName: ").Append(DownstreamName).Append("\n");
            sb.Append("  PaginationSupported: ").Append(PaginationSupported).Append("\n");
            sb.Append("  SupportedOperations: ").Append(SupportedOperations).Append("\n");
            sb.Append("  SupportedFilters: ").Append(SupportedFilters).Append("\n");
            sb.Append("  SupportedSortBy: ").Append(SupportedSortBy).Append("\n");
            sb.Append("  SupportedFields: ").Append(SupportedFields).Append("\n");
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
            return this.Equals(input as ApiResourceCoverageCoverage);
        }

        /// <summary>
        /// Returns true if ApiResourceCoverageCoverage instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResourceCoverageCoverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResourceCoverageCoverage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DownstreamId == input.DownstreamId ||
                    (this.DownstreamId != null &&
                    this.DownstreamId.Equals(input.DownstreamId))
                ) && 
                (
                    this.DownstreamName == input.DownstreamName ||
                    (this.DownstreamName != null &&
                    this.DownstreamName.Equals(input.DownstreamName))
                ) && 
                (
                    this.PaginationSupported == input.PaginationSupported ||
                    this.PaginationSupported.Equals(input.PaginationSupported)
                ) && 
                (
                    this.SupportedOperations == input.SupportedOperations ||
                    this.SupportedOperations != null &&
                    input.SupportedOperations != null &&
                    this.SupportedOperations.SequenceEqual(input.SupportedOperations)
                ) && 
                (
                    this.SupportedFilters == input.SupportedFilters ||
                    this.SupportedFilters != null &&
                    input.SupportedFilters != null &&
                    this.SupportedFilters.SequenceEqual(input.SupportedFilters)
                ) && 
                (
                    this.SupportedSortBy == input.SupportedSortBy ||
                    this.SupportedSortBy != null &&
                    input.SupportedSortBy != null &&
                    this.SupportedSortBy.SequenceEqual(input.SupportedSortBy)
                ) && 
                (
                    this.SupportedFields == input.SupportedFields ||
                    this.SupportedFields != null &&
                    input.SupportedFields != null &&
                    this.SupportedFields.SequenceEqual(input.SupportedFields)
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
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                if (this.DownstreamName != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaginationSupported.GetHashCode();
                if (this.SupportedOperations != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedOperations.GetHashCode();
                }
                if (this.SupportedFilters != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedFilters.GetHashCode();
                }
                if (this.SupportedSortBy != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedSortBy.GetHashCode();
                }
                if (this.SupportedFields != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedFields.GetHashCode();
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
