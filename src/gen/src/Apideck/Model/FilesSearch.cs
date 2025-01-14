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
    /// FilesSearch
    /// </summary>
    [DataContract(Name = "FilesSearch")]
    public partial class FilesSearch : IEquatable<FilesSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSearch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilesSearch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSearch" /> class.
        /// </summary>
        /// <param name="query">The query to search for. May match across multiple fields. (required).</param>
        /// <param name="driveId">ID of the drive to filter on.</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public FilesSearch(string query = default(string), string driveId = default(string), List<Object> passThrough = default(List<Object>))
        {
            // to ensure "query" is required (not null)
            if (query == null) {
                throw new ArgumentNullException("query is a required property for FilesSearch and cannot be null");
            }
            this.Query = query;
            this.DriveId = driveId;
            this.PassThrough = passThrough;
        }

        /// <summary>
        /// The query to search for. May match across multiple fields.
        /// </summary>
        /// <value>The query to search for. May match across multiple fields.</value>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// ID of the drive to filter on
        /// </summary>
        /// <value>ID of the drive to filter on</value>
        [DataMember(Name = "drive_id", EmitDefaultValue = false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        /// <value>The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.</value>
        [DataMember(Name = "pass_through", EmitDefaultValue = false)]
        public List<Object> PassThrough { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilesSearch {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  PassThrough: ").Append(PassThrough).Append("\n");
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
            return this.Equals(input as FilesSearch);
        }

        /// <summary>
        /// Returns true if FilesSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of FilesSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilesSearch input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.DriveId == input.DriveId ||
                    (this.DriveId != null &&
                    this.DriveId.Equals(input.DriveId))
                ) && 
                (
                    this.PassThrough == input.PassThrough ||
                    this.PassThrough != null &&
                    input.PassThrough != null &&
                    this.PassThrough.SequenceEqual(input.PassThrough)
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
                if (this.Query != null)
                {
                    hashCode = (hashCode * 59) + this.Query.GetHashCode();
                }
                if (this.DriveId != null)
                {
                    hashCode = (hashCode * 59) + this.DriveId.GetHashCode();
                }
                if (this.PassThrough != null)
                {
                    hashCode = (hashCode * 59) + this.PassThrough.GetHashCode();
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
