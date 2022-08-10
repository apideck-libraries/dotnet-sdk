/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.39.0
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
    /// DriveGroupsFilter
    /// </summary>
    [DataContract(Name = "DriveGroupsFilter")]
    public partial class DriveGroupsFilter : IEquatable<DriveGroupsFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DriveGroupsFilter" /> class.
        /// </summary>
        /// <param name="parentGroupId">ID of the drive group to filter on.</param>
        public DriveGroupsFilter(string parentGroupId = default(string))
        {
            this.ParentGroupId = parentGroupId;
        }

        /// <summary>
        /// ID of the drive group to filter on
        /// </summary>
        /// <value>ID of the drive group to filter on</value>
        [DataMember(Name = "parent_group_id", EmitDefaultValue = false)]
        public string ParentGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DriveGroupsFilter {\n");
            sb.Append("  ParentGroupId: ").Append(ParentGroupId).Append("\n");
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
            return this.Equals(input as DriveGroupsFilter);
        }

        /// <summary>
        /// Returns true if DriveGroupsFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of DriveGroupsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DriveGroupsFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ParentGroupId == input.ParentGroupId ||
                    (this.ParentGroupId != null &&
                    this.ParentGroupId.Equals(input.ParentGroupId))
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
                if (this.ParentGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentGroupId.GetHashCode();
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
