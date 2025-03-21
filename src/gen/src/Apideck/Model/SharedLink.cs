/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.13.0
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
    /// SharedLink
    /// </summary>
    [DataContract(Name = "SharedLink")]
    public partial class SharedLink : IEquatable<SharedLink>, IValidatableObject
    {
        /// <summary>
        /// The scope of the shared link.
        /// </summary>
        /// <value>The scope of the shared link.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 1,

            /// <summary>
            /// Enum Company for value: company
            /// </summary>
            [EnumMember(Value = "company")]
            Company = 2

        }


        /// <summary>
        /// The scope of the shared link.
        /// </summary>
        /// <value>The scope of the shared link.</value>
        [DataMember(Name = "scope", EmitDefaultValue = true)]
        public ScopeEnum? Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SharedLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedLink" /> class.
        /// </summary>
        /// <param name="downloadUrl">The URL that can be used to download the file..</param>
        /// <param name="targetId">The ID of the file or folder to link. (required).</param>
        /// <param name="target">target.</param>
        /// <param name="scope">The scope of the shared link..</param>
        /// <param name="password">Optional password for the shared link..</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public SharedLink(string downloadUrl = default(string), string targetId = default(string), SharedLinkTarget target = default(SharedLinkTarget), ScopeEnum? scope = default(ScopeEnum?), string password = default(string), List<Object> passThrough = default(List<Object>))
        {
            // to ensure "targetId" is required (not null)
            if (targetId == null) {
                throw new ArgumentNullException("targetId is a required property for SharedLink and cannot be null");
            }
            this.TargetId = targetId;
            this.DownloadUrl = downloadUrl;
            this.Target = target;
            this.Scope = scope;
            this.Password = password;
            this.PassThrough = passThrough;
        }

        /// <summary>
        /// The URL that can be used to view the file.
        /// </summary>
        /// <value>The URL that can be used to view the file.</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; private set; }

        /// <summary>
        /// Returns false as Url should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUrl()
        {
            return false;
        }
        /// <summary>
        /// The URL that can be used to download the file.
        /// </summary>
        /// <value>The URL that can be used to download the file.</value>
        [DataMember(Name = "download_url", EmitDefaultValue = true)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// The ID of the file or folder to link.
        /// </summary>
        /// <value>The ID of the file or folder to link.</value>
        [DataMember(Name = "target_id", IsRequired = true, EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public SharedLinkTarget Target { get; set; }

        /// <summary>
        /// Indicated if the shared link is password protected.
        /// </summary>
        /// <value>Indicated if the shared link is password protected.</value>
        [DataMember(Name = "password_protected", EmitDefaultValue = true)]
        public bool? PasswordProtected { get; private set; }

        /// <summary>
        /// Returns false as PasswordProtected should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePasswordProtected()
        {
            return false;
        }
        /// <summary>
        /// Optional password for the shared link.
        /// </summary>
        /// <value>Optional password for the shared link.</value>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expires_at", EmitDefaultValue = true)]
        public DateTime? ExpiresAt { get; private set; }

        /// <summary>
        /// Returns false as ExpiresAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpiresAt()
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
            sb.Append("class SharedLink {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  PasswordProtected: ").Append(PasswordProtected).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as SharedLink);
        }

        /// <summary>
        /// Returns true if SharedLink instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedLink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.DownloadUrl == input.DownloadUrl ||
                    (this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(input.DownloadUrl))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
                ) && 
                (
                    this.PasswordProtected == input.PasswordProtected ||
                    (this.PasswordProtected != null &&
                    this.PasswordProtected.Equals(input.PasswordProtected))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.DownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DownloadUrl.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.Target != null)
                {
                    hashCode = (hashCode * 59) + this.Target.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                if (this.PasswordProtected != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordProtected.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
