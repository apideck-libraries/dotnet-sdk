/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.85.1
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
    /// CreateFileRequest
    /// </summary>
    [DataContract(Name = "CreateFileRequest")]
    public partial class CreateFileRequest : IEquatable<CreateFileRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFileRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the file. (required).</param>
        /// <param name="parentFolderId">The parent folder to create the new file within. (required).</param>
        /// <param name="driveId">ID of the drive to upload to..</param>
        /// <param name="description">Optional description of the file..</param>
        public CreateFileRequest(string name = default(string), string parentFolderId = default(string), string driveId = default(string), string description = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for CreateFileRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "parentFolderId" is required (not null)
            if (parentFolderId == null) {
                throw new ArgumentNullException("parentFolderId is a required property for CreateFileRequest and cannot be null");
            }
            this.ParentFolderId = parentFolderId;
            this.DriveId = driveId;
            this.Description = description;
        }

        /// <summary>
        /// The name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The parent folder to create the new file within.
        /// </summary>
        /// <value>The parent folder to create the new file within.</value>
        [DataMember(Name = "parent_folder_id", IsRequired = true, EmitDefaultValue = false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// ID of the drive to upload to.
        /// </summary>
        /// <value>ID of the drive to upload to.</value>
        [DataMember(Name = "drive_id", EmitDefaultValue = false)]
        public string DriveId { get; set; }

        /// <summary>
        /// Optional description of the file.
        /// </summary>
        /// <value>Optional description of the file.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFileRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CreateFileRequest);
        }

        /// <summary>
        /// Returns true if CreateFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFileRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentFolderId == input.ParentFolderId ||
                    (this.ParentFolderId != null &&
                    this.ParentFolderId.Equals(input.ParentFolderId))
                ) && 
                (
                    this.DriveId == input.DriveId ||
                    (this.DriveId != null &&
                    this.DriveId.Equals(input.DriveId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ParentFolderId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentFolderId.GetHashCode();
                }
                if (this.DriveId != null)
                {
                    hashCode = (hashCode * 59) + this.DriveId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
