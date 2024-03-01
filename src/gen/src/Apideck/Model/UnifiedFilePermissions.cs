/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.3.5
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
    /// Permissions the current user has on this file.
    /// </summary>
    [DataContract(Name = "UnifiedFile_permissions")]
    public partial class UnifiedFilePermissions : IEquatable<UnifiedFilePermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedFilePermissions" /> class.
        /// </summary>
        /// <param name="download">Whether the current user can download this file..</param>
        public UnifiedFilePermissions(bool download = default(bool))
        {
            this.Download = download;
        }

        /// <summary>
        /// Whether the current user can download this file.
        /// </summary>
        /// <value>Whether the current user can download this file.</value>
        [DataMember(Name = "download", EmitDefaultValue = true)]
        public bool Download { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnifiedFilePermissions {\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
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
            return this.Equals(input as UnifiedFilePermissions);
        }

        /// <summary>
        /// Returns true if UnifiedFilePermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedFilePermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedFilePermissions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Download == input.Download ||
                    this.Download.Equals(input.Download)
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
                hashCode = (hashCode * 59) + this.Download.GetHashCode();
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
