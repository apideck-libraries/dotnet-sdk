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
    /// UnifiedFile
    /// </summary>
    [DataContract(Name = "UnifiedFile")]
    public partial class UnifiedFile : IEquatable<UnifiedFile>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public FileType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedFile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnifiedFile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedFile" /> class.
        /// </summary>
        /// <param name="name">The name of the file (required).</param>
        /// <param name="description">Optional description of the file.</param>
        /// <param name="type">type (required).</param>
        /// <param name="path">The full path of the file or folder (includes the file name).</param>
        /// <param name="mimeType">The MIME type of the file..</param>
        /// <param name="downloadable">Whether the current user can download this file.</param>
        /// <param name="size">The size of the file in bytes.</param>
        /// <param name="owner">owner.</param>
        /// <param name="parentFolders">The parent folders of the file, starting from the root.</param>
        /// <param name="parentFoldersComplete">Whether the list of parent folders is complete. Some connectors only return the direct parent of a file.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="exportable">Whether the current file is exportable to other file formats. This property is relevant for proprietary file formats such as Google Docs or Dropbox Paper..</param>
        /// <param name="exportFormats">The available file formats when exporting this file..</param>
        public UnifiedFile(string name = default(string), string description = default(string), FileType type = default(FileType), string path = default(string), string mimeType = default(string), bool downloadable = default(bool), int? size = default(int?), Owner owner = default(Owner), List<LinkedFolder> parentFolders = default(List<LinkedFolder>), bool parentFoldersComplete = default(bool), UnifiedFilePermissions permissions = default(UnifiedFilePermissions), bool exportable = default(bool), List<string> exportFormats = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for UnifiedFile and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Path = path;
            this.MimeType = mimeType;
            this.Downloadable = downloadable;
            this.Size = size;
            this.Owner = owner;
            this.ParentFolders = parentFolders;
            this.ParentFoldersComplete = parentFoldersComplete;
            this.Permissions = permissions;
            this.Exportable = exportable;
            this.ExportFormats = exportFormats;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The third-party API ID of original entity
        /// </summary>
        /// <value>The third-party API ID of original entity</value>
        [DataMember(Name = "downstream_id", EmitDefaultValue = true)]
        public string DownstreamId { get; private set; }

        /// <summary>
        /// Returns false as DownstreamId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDownstreamId()
        {
            return false;
        }
        /// <summary>
        /// The name of the file
        /// </summary>
        /// <value>The name of the file</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the file
        /// </summary>
        /// <value>Optional description of the file</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The full path of the file or folder (includes the file name)
        /// </summary>
        /// <value>The full path of the file or folder (includes the file name)</value>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// The MIME type of the file.
        /// </summary>
        /// <value>The MIME type of the file.</value>
        [DataMember(Name = "mime_type", EmitDefaultValue = true)]
        public string MimeType { get; set; }

        /// <summary>
        /// Whether the current user can download this file
        /// </summary>
        /// <value>Whether the current user can download this file</value>
        [DataMember(Name = "downloadable", EmitDefaultValue = true)]
        public bool Downloadable { get; set; }

        /// <summary>
        /// The size of the file in bytes
        /// </summary>
        /// <value>The size of the file in bytes</value>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public Owner Owner { get; set; }

        /// <summary>
        /// The parent folders of the file, starting from the root
        /// </summary>
        /// <value>The parent folders of the file, starting from the root</value>
        [DataMember(Name = "parent_folders", EmitDefaultValue = false)]
        public List<LinkedFolder> ParentFolders { get; set; }

        /// <summary>
        /// Whether the list of parent folders is complete. Some connectors only return the direct parent of a file
        /// </summary>
        /// <value>Whether the list of parent folders is complete. Some connectors only return the direct parent of a file</value>
        [DataMember(Name = "parent_folders_complete", EmitDefaultValue = true)]
        public bool ParentFoldersComplete { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public UnifiedFilePermissions Permissions { get; set; }

        /// <summary>
        /// Whether the current file is exportable to other file formats. This property is relevant for proprietary file formats such as Google Docs or Dropbox Paper.
        /// </summary>
        /// <value>Whether the current file is exportable to other file formats. This property is relevant for proprietary file formats such as Google Docs or Dropbox Paper.</value>
        [DataMember(Name = "exportable", EmitDefaultValue = true)]
        public bool Exportable { get; set; }

        /// <summary>
        /// The available file formats when exporting this file.
        /// </summary>
        /// <value>The available file formats when exporting this file.</value>
        [DataMember(Name = "export_formats", EmitDefaultValue = true)]
        public List<string> ExportFormats { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; private set; }

        /// <summary>
        /// Returns false as CustomMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomMappings()
        {
            return false;
        }
        /// <summary>
        /// The user who last updated the object.
        /// </summary>
        /// <value>The user who last updated the object.</value>
        [DataMember(Name = "updated_by", EmitDefaultValue = true)]
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// Returns false as UpdatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedBy()
        {
            return false;
        }
        /// <summary>
        /// The user who created the object.
        /// </summary>
        /// <value>The user who created the object.</value>
        [DataMember(Name = "created_by", EmitDefaultValue = true)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnifiedFile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Downloadable: ").Append(Downloadable).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  ParentFolders: ").Append(ParentFolders).Append("\n");
            sb.Append("  ParentFoldersComplete: ").Append(ParentFoldersComplete).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Exportable: ").Append(Exportable).Append("\n");
            sb.Append("  ExportFormats: ").Append(ExportFormats).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as UnifiedFile);
        }

        /// <summary>
        /// Returns true if UnifiedFile instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedFile input)
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
                    this.DownstreamId == input.DownstreamId ||
                    (this.DownstreamId != null &&
                    this.DownstreamId.Equals(input.DownstreamId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Downloadable == input.Downloadable ||
                    this.Downloadable.Equals(input.Downloadable)
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.ParentFolders == input.ParentFolders ||
                    this.ParentFolders != null &&
                    input.ParentFolders != null &&
                    this.ParentFolders.SequenceEqual(input.ParentFolders)
                ) && 
                (
                    this.ParentFoldersComplete == input.ParentFoldersComplete ||
                    this.ParentFoldersComplete.Equals(input.ParentFoldersComplete)
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.Exportable == input.Exportable ||
                    this.Exportable.Equals(input.Exportable)
                ) && 
                (
                    this.ExportFormats == input.ExportFormats ||
                    this.ExportFormats != null &&
                    input.ExportFormats != null &&
                    this.ExportFormats.SequenceEqual(input.ExportFormats)
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.MimeType != null)
                {
                    hashCode = (hashCode * 59) + this.MimeType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Downloadable.GetHashCode();
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
                }
                if (this.ParentFolders != null)
                {
                    hashCode = (hashCode * 59) + this.ParentFolders.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ParentFoldersComplete.GetHashCode();
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Exportable.GetHashCode();
                if (this.ExportFormats != null)
                {
                    hashCode = (hashCode * 59) + this.ExportFormats.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
