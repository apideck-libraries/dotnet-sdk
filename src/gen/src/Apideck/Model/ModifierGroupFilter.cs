/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.8.1
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
    /// ModifierGroupFilter
    /// </summary>
    [DataContract(Name = "ModifierGroupFilter")]
    public partial class ModifierGroupFilter : IEquatable<ModifierGroupFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierGroupFilter" /> class.
        /// </summary>
        /// <param name="modifierGroupId">Id of the job to filter on.</param>
        public ModifierGroupFilter(string modifierGroupId = default(string))
        {
            this.ModifierGroupId = modifierGroupId;
        }

        /// <summary>
        /// Id of the job to filter on
        /// </summary>
        /// <value>Id of the job to filter on</value>
        [DataMember(Name = "modifier_group_id", EmitDefaultValue = false)]
        public string ModifierGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifierGroupFilter {\n");
            sb.Append("  ModifierGroupId: ").Append(ModifierGroupId).Append("\n");
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
            return this.Equals(input as ModifierGroupFilter);
        }

        /// <summary>
        /// Returns true if ModifierGroupFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifierGroupFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifierGroupFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModifierGroupId == input.ModifierGroupId ||
                    (this.ModifierGroupId != null &&
                    this.ModifierGroupId.Equals(input.ModifierGroupId))
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
                if (this.ModifierGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.ModifierGroupId.GetHashCode();
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
