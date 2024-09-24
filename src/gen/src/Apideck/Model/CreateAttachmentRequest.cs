/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.5
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
    /// CreateAttachmentRequest
    /// </summary>
    [DataContract(Name = "CreateAttachmentRequest")]
    public partial class CreateAttachmentRequest : IEquatable<CreateAttachmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAttachmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAttachmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAttachmentRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the file (required).</param>
        /// <param name="description">Optional description of the file..</param>
        /// <param name="parentFolderId">The folder id where this attachment belong to.</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public CreateAttachmentRequest(string name = default(string), string description = default(string), string parentFolderId = default(string), List<Object> passThrough = default(List<Object>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for CreateAttachmentRequest and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.ParentFolderId = parentFolderId;
            this.PassThrough = passThrough;
        }

        /// <summary>
        /// The name of the file
        /// </summary>
        /// <value>The name of the file</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the file.
        /// </summary>
        /// <value>Optional description of the file.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The folder id where this attachment belong to
        /// </summary>
        /// <value>The folder id where this attachment belong to</value>
        [DataMember(Name = "parent_folder_id", EmitDefaultValue = false)]
        public string ParentFolderId { get; set; }

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
            sb.Append("class CreateAttachmentRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
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
            return this.Equals(input as CreateAttachmentRequest);
        }

        /// <summary>
        /// Returns true if CreateAttachmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAttachmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAttachmentRequest input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ParentFolderId == input.ParentFolderId ||
                    (this.ParentFolderId != null &&
                    this.ParentFolderId.Equals(input.ParentFolderId))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ParentFolderId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentFolderId.GetHashCode();
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
