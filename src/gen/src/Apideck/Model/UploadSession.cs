/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.48.0
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
    /// UploadSession
    /// </summary>
    [DataContract(Name = "UploadSession")]
    public partial class UploadSession : IEquatable<UploadSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UploadSession()
        {
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
        /// Indicates if the upload session was completed successfully.
        /// </summary>
        /// <value>Indicates if the upload session was completed successfully.</value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; private set; }

        /// <summary>
        /// Returns false as Success should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSuccess()
        {
            return false;
        }
        /// <summary>
        /// Size in bytes of each part of the file that you will upload. Uploaded parts need to be this size for the upload to be successful.
        /// </summary>
        /// <value>Size in bytes of each part of the file that you will upload. Uploaded parts need to be this size for the upload to be successful.</value>
        [DataMember(Name = "part_size", EmitDefaultValue = false)]
        public decimal PartSize { get; private set; }

        /// <summary>
        /// Returns false as PartSize should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePartSize()
        {
            return false;
        }
        /// <summary>
        /// Indicates if parts of the file can uploaded in parallel.
        /// </summary>
        /// <value>Indicates if parts of the file can uploaded in parallel.</value>
        [DataMember(Name = "parallel_upload_supported", EmitDefaultValue = true)]
        public bool ParallelUploadSupported { get; private set; }

        /// <summary>
        /// Returns false as ParallelUploadSupported should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParallelUploadSupported()
        {
            return false;
        }
        /// <summary>
        /// The range of bytes that was successfully uploaded.
        /// </summary>
        /// <value>The range of bytes that was successfully uploaded.</value>
        [DataMember(Name = "uploaded_byte_range", EmitDefaultValue = false)]
        public string UploadedByteRange { get; private set; }

        /// <summary>
        /// Returns false as UploadedByteRange should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUploadedByteRange()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; private set; }

        /// <summary>
        /// Returns false as ExpiresAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpiresAt()
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
            sb.Append("class UploadSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  PartSize: ").Append(PartSize).Append("\n");
            sb.Append("  ParallelUploadSupported: ").Append(ParallelUploadSupported).Append("\n");
            sb.Append("  UploadedByteRange: ").Append(UploadedByteRange).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
            return this.Equals(input as UploadSession);
        }

        /// <summary>
        /// Returns true if UploadSession instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadSession input)
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
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.PartSize == input.PartSize ||
                    this.PartSize.Equals(input.PartSize)
                ) && 
                (
                    this.ParallelUploadSupported == input.ParallelUploadSupported ||
                    this.ParallelUploadSupported.Equals(input.ParallelUploadSupported)
                ) && 
                (
                    this.UploadedByteRange == input.UploadedByteRange ||
                    (this.UploadedByteRange != null &&
                    this.UploadedByteRange.Equals(input.UploadedByteRange))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
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
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
                hashCode = (hashCode * 59) + this.PartSize.GetHashCode();
                hashCode = (hashCode * 59) + this.ParallelUploadSupported.GetHashCode();
                if (this.UploadedByteRange != null)
                {
                    hashCode = (hashCode * 59) + this.UploadedByteRange.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
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
