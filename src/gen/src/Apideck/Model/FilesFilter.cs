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
    /// FilesFilter
    /// </summary>
    [DataContract(Name = "FilesFilter")]
    public partial class FilesFilter : IEquatable<FilesFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFilter" /> class.
        /// </summary>
        /// <param name="driveId">ID of the drive to filter on.</param>
        /// <param name="folderId">ID of the folder to filter on. The root folder has an alias \&quot;root\&quot;.</param>
        /// <param name="shared">Only return files and folders that are shared.</param>
        public FilesFilter(string driveId = default(string), string folderId = default(string), bool shared = default(bool))
        {
            this.DriveId = driveId;
            this.FolderId = folderId;
            this.Shared = shared;
        }

        /// <summary>
        /// ID of the drive to filter on
        /// </summary>
        /// <value>ID of the drive to filter on</value>
        [DataMember(Name = "drive_id", EmitDefaultValue = false)]
        public string DriveId { get; set; }

        /// <summary>
        /// ID of the folder to filter on. The root folder has an alias \&quot;root\&quot;
        /// </summary>
        /// <value>ID of the folder to filter on. The root folder has an alias \&quot;root\&quot;</value>
        [DataMember(Name = "folder_id", EmitDefaultValue = false)]
        public string FolderId { get; set; }

        /// <summary>
        /// Only return files and folders that are shared
        /// </summary>
        /// <value>Only return files and folders that are shared</value>
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilesFilter {\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
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
            return this.Equals(input as FilesFilter);
        }

        /// <summary>
        /// Returns true if FilesFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of FilesFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilesFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DriveId == input.DriveId ||
                    (this.DriveId != null &&
                    this.DriveId.Equals(input.DriveId))
                ) && 
                (
                    this.FolderId == input.FolderId ||
                    (this.FolderId != null &&
                    this.FolderId.Equals(input.FolderId))
                ) && 
                (
                    this.Shared == input.Shared ||
                    this.Shared.Equals(input.Shared)
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
                if (this.DriveId != null)
                {
                    hashCode = (hashCode * 59) + this.DriveId.GetHashCode();
                }
                if (this.FolderId != null)
                {
                    hashCode = (hashCode * 59) + this.FolderId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Shared.GetHashCode();
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
