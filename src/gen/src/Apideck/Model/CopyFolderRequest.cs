/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.44.0
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
    /// CopyFolderRequest
    /// </summary>
    [DataContract(Name = "CopyFolderRequest")]
    public partial class CopyFolderRequest : IEquatable<CopyFolderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopyFolderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the folder..</param>
        /// <param name="parentFolderId">The parent folder to create the new file within. (required).</param>
        public CopyFolderRequest(string name = default(string), string parentFolderId = default(string))
        {
            // to ensure "parentFolderId" is required (not null)
            if (parentFolderId == null) {
                throw new ArgumentNullException("parentFolderId is a required property for CopyFolderRequest and cannot be null");
            }
            this.ParentFolderId = parentFolderId;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
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
        /// The name of the folder.
        /// </summary>
        /// <value>The name of the folder.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The parent folder to create the new file within.
        /// </summary>
        /// <value>The parent folder to create the new file within.</value>
        [DataMember(Name = "parent_folder_id", IsRequired = true, EmitDefaultValue = false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CopyFolderRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
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
            return this.Equals(input as CopyFolderRequest);
        }

        /// <summary>
        /// Returns true if CopyFolderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CopyFolderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyFolderRequest input)
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
                    this.ParentFolderId == input.ParentFolderId ||
                    (this.ParentFolderId != null &&
                    this.ParentFolderId.Equals(input.ParentFolderId))
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
                if (this.ParentFolderId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentFolderId.GetHashCode();
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
