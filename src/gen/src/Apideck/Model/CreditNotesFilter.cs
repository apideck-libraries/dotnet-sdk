/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.6
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
    /// CreditNotesFilter
    /// </summary>
    [DataContract(Name = "CreditNotesFilter")]
    public partial class CreditNotesFilter : IEquatable<CreditNotesFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNotesFilter" /> class.
        /// </summary>
        /// <param name="updatedSince">updatedSince.</param>
        public CreditNotesFilter(DateTime updatedSince = default(DateTime))
        {
            this.UpdatedSince = updatedSince;
        }

        /// <summary>
        /// Gets or Sets UpdatedSince
        /// </summary>
        [DataMember(Name = "updated_since", EmitDefaultValue = false)]
        public DateTime UpdatedSince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditNotesFilter {\n");
            sb.Append("  UpdatedSince: ").Append(UpdatedSince).Append("\n");
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
            return this.Equals(input as CreditNotesFilter);
        }

        /// <summary>
        /// Returns true if CreditNotesFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNotesFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNotesFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UpdatedSince == input.UpdatedSince ||
                    (this.UpdatedSince != null &&
                    this.UpdatedSince.Equals(input.UpdatedSince))
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
                if (this.UpdatedSince != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedSince.GetHashCode();
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
