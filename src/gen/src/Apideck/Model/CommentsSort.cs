/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.3.0
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
    /// CommentsSort
    /// </summary>
    [DataContract(Name = "CommentsSort")]
    public partial class CommentsSort : IEquatable<CommentsSort>, IValidatableObject
    {
        /// <summary>
        /// The field on which to sort the Comments
        /// </summary>
        /// <value>The field on which to sort the Comments</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ByEnum
        {
            /// <summary>
            /// Enum CreatedAt for value: created_at
            /// </summary>
            [EnumMember(Value = "created_at")]
            CreatedAt = 1,

            /// <summary>
            /// Enum UpdatedAt for value: updated_at
            /// </summary>
            [EnumMember(Value = "updated_at")]
            UpdatedAt = 2

        }


        /// <summary>
        /// The field on which to sort the Comments
        /// </summary>
        /// <value>The field on which to sort the Comments</value>
        [DataMember(Name = "by", EmitDefaultValue = false)]
        public ByEnum? By { get; set; }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public SortDirection? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentsSort" /> class.
        /// </summary>
        /// <param name="by">The field on which to sort the Comments.</param>
        /// <param name="direction">direction.</param>
        public CommentsSort(ByEnum? by = default(ByEnum?), SortDirection? direction = default(SortDirection?))
        {
            this.By = by;
            this.Direction = direction;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommentsSort {\n");
            sb.Append("  By: ").Append(By).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as CommentsSort);
        }

        /// <summary>
        /// Returns true if CommentsSort instances are equal
        /// </summary>
        /// <param name="input">Instance of CommentsSort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommentsSort input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.By == input.By ||
                    this.By.Equals(input.By)
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
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
                hashCode = (hashCode * 59) + this.By.GetHashCode();
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
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
