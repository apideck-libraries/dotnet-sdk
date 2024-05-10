/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.4.2
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
    /// CreateUploadSessionRequest
    /// </summary>
    [DataContract(Name = "CreateUploadSessionRequest")]
    public partial class CreateUploadSessionRequest : IEquatable<CreateUploadSessionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadSessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUploadSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadSessionRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the file. (required).</param>
        /// <param name="parentFolderId">The parent folder to create the new file within. This can be an ID or a path depending on the downstream folder. Please see the connector section below to see downstream specific gotchas. (required).</param>
        /// <param name="driveId">ID of the drive to upload to..</param>
        /// <param name="size">The size of the file in bytes (required).</param>
        public CreateUploadSessionRequest(string name = default(string), string parentFolderId = default(string), string driveId = default(string), int? size = default(int?))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for CreateUploadSessionRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "parentFolderId" is required (not null)
            if (parentFolderId == null) {
                throw new ArgumentNullException("parentFolderId is a required property for CreateUploadSessionRequest and cannot be null");
            }
            this.ParentFolderId = parentFolderId;
            // to ensure "size" is required (not null)
            if (size == null) {
                throw new ArgumentNullException("size is a required property for CreateUploadSessionRequest and cannot be null");
            }
            this.Size = size;
            this.DriveId = driveId;
        }

        /// <summary>
        /// The name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The parent folder to create the new file within. This can be an ID or a path depending on the downstream folder. Please see the connector section below to see downstream specific gotchas.
        /// </summary>
        /// <value>The parent folder to create the new file within. This can be an ID or a path depending on the downstream folder. Please see the connector section below to see downstream specific gotchas.</value>
        [DataMember(Name = "parent_folder_id", IsRequired = true, EmitDefaultValue = false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// ID of the drive to upload to.
        /// </summary>
        /// <value>ID of the drive to upload to.</value>
        [DataMember(Name = "drive_id", EmitDefaultValue = false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The size of the file in bytes
        /// </summary>
        /// <value>The size of the file in bytes</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = true)]
        public int? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUploadSessionRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as CreateUploadSessionRequest);
        }

        /// <summary>
        /// Returns true if CreateUploadSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUploadSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUploadSessionRequest input)
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
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
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
