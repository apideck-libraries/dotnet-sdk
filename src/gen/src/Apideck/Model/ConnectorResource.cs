/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.2
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
    /// ConnectorResource
    /// </summary>
    [DataContract(Name = "ConnectorResource")]
    public partial class ConnectorResource : IEquatable<ConnectorResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ResourceStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorResource" /> class.
        /// </summary>
        /// <param name="id">ID of the resource, typically a lowercased version of name..</param>
        /// <param name="name">Name of the resource (plural).</param>
        /// <param name="downstreamId">ID of the resource in the Connector&#39;s API (downstream).</param>
        /// <param name="downstreamName">Name of the resource in the Connector&#39;s API (downstream).</param>
        /// <param name="status">status.</param>
        /// <param name="paginationSupported">Indicates if pagination (cursor and limit parameters) is supported on the list endpoint of the resource..</param>
        /// <param name="pagination">pagination.</param>
        /// <param name="customFieldsSupported">Indicates if custom fields are supported on this resource..</param>
        /// <param name="supportedOperations">List of supported operations on the resource..</param>
        /// <param name="downstreamUnsupportedOperations">List of operations that are not supported on the downstream..</param>
        /// <param name="supportedFilters">Supported filters on the list endpoint of the resource..</param>
        /// <param name="supportedSortBy">Supported sorting properties on the list endpoint of the resource..</param>
        /// <param name="supportedFields">Supported fields on the detail endpoint..</param>
        /// <param name="supportedListFields">Supported fields on the list endpoint..</param>
        public ConnectorResource(string id = default(string), string name = default(string), string downstreamId = default(string), string downstreamName = default(string), ResourceStatus? status = default(ResourceStatus?), bool paginationSupported = default(bool), PaginationCoverage pagination = default(PaginationCoverage), bool customFieldsSupported = default(bool), List<string> supportedOperations = default(List<string>), List<string> downstreamUnsupportedOperations = default(List<string>), List<string> supportedFilters = default(List<string>), List<string> supportedSortBy = default(List<string>), List<SupportedProperty> supportedFields = default(List<SupportedProperty>), List<SupportedProperty> supportedListFields = default(List<SupportedProperty>))
        {
            this.Id = id;
            this.Name = name;
            this.DownstreamId = downstreamId;
            this.DownstreamName = downstreamName;
            this.Status = status;
            this.PaginationSupported = paginationSupported;
            this.Pagination = pagination;
            this.CustomFieldsSupported = customFieldsSupported;
            this.SupportedOperations = supportedOperations;
            this.DownstreamUnsupportedOperations = downstreamUnsupportedOperations;
            this.SupportedFilters = supportedFilters;
            this.SupportedSortBy = supportedSortBy;
            this.SupportedFields = supportedFields;
            this.SupportedListFields = supportedListFields;
        }

        /// <summary>
        /// ID of the resource, typically a lowercased version of name.
        /// </summary>
        /// <value>ID of the resource, typically a lowercased version of name.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the resource (plural)
        /// </summary>
        /// <value>Name of the resource (plural)</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

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
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationCoverage Pagination { get; set; }

        /// <summary>
        /// Indicates if custom fields are supported on this resource.
        /// </summary>
        /// <value>Indicates if custom fields are supported on this resource.</value>
        [DataMember(Name = "custom_fields_supported", EmitDefaultValue = true)]
        public bool CustomFieldsSupported { get; set; }

        /// <summary>
        /// List of supported operations on the resource.
        /// </summary>
        /// <value>List of supported operations on the resource.</value>
        [DataMember(Name = "supported_operations", EmitDefaultValue = false)]
        public List<string> SupportedOperations { get; set; }

        /// <summary>
        /// List of operations that are not supported on the downstream.
        /// </summary>
        /// <value>List of operations that are not supported on the downstream.</value>
        [DataMember(Name = "downstream_unsupported_operations", EmitDefaultValue = false)]
        public List<string> DownstreamUnsupportedOperations { get; set; }

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
        /// Supported fields on the detail endpoint.
        /// </summary>
        /// <value>Supported fields on the detail endpoint.</value>
        [DataMember(Name = "supported_fields", EmitDefaultValue = false)]
        public List<SupportedProperty> SupportedFields { get; set; }

        /// <summary>
        /// Supported fields on the list endpoint.
        /// </summary>
        /// <value>Supported fields on the list endpoint.</value>
        [DataMember(Name = "supported_list_fields", EmitDefaultValue = false)]
        public List<SupportedProperty> SupportedListFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  DownstreamName: ").Append(DownstreamName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaginationSupported: ").Append(PaginationSupported).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  CustomFieldsSupported: ").Append(CustomFieldsSupported).Append("\n");
            sb.Append("  SupportedOperations: ").Append(SupportedOperations).Append("\n");
            sb.Append("  DownstreamUnsupportedOperations: ").Append(DownstreamUnsupportedOperations).Append("\n");
            sb.Append("  SupportedFilters: ").Append(SupportedFilters).Append("\n");
            sb.Append("  SupportedSortBy: ").Append(SupportedSortBy).Append("\n");
            sb.Append("  SupportedFields: ").Append(SupportedFields).Append("\n");
            sb.Append("  SupportedListFields: ").Append(SupportedListFields).Append("\n");
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
            return this.Equals(input as ConnectorResource);
        }

        /// <summary>
        /// Returns true if ConnectorResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorResource input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PaginationSupported == input.PaginationSupported ||
                    this.PaginationSupported.Equals(input.PaginationSupported)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.CustomFieldsSupported == input.CustomFieldsSupported ||
                    this.CustomFieldsSupported.Equals(input.CustomFieldsSupported)
                ) && 
                (
                    this.SupportedOperations == input.SupportedOperations ||
                    this.SupportedOperations != null &&
                    input.SupportedOperations != null &&
                    this.SupportedOperations.SequenceEqual(input.SupportedOperations)
                ) && 
                (
                    this.DownstreamUnsupportedOperations == input.DownstreamUnsupportedOperations ||
                    this.DownstreamUnsupportedOperations != null &&
                    input.DownstreamUnsupportedOperations != null &&
                    this.DownstreamUnsupportedOperations.SequenceEqual(input.DownstreamUnsupportedOperations)
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
                ) && 
                (
                    this.SupportedListFields == input.SupportedListFields ||
                    this.SupportedListFields != null &&
                    input.SupportedListFields != null &&
                    this.SupportedListFields.SequenceEqual(input.SupportedListFields)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                if (this.DownstreamName != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.PaginationSupported.GetHashCode();
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CustomFieldsSupported.GetHashCode();
                if (this.SupportedOperations != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedOperations.GetHashCode();
                }
                if (this.DownstreamUnsupportedOperations != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamUnsupportedOperations.GetHashCode();
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
                if (this.SupportedListFields != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedListFields.GetHashCode();
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
