/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.6.3
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
    /// ScheduleWorkPattern
    /// </summary>
    [DataContract(Name = "Schedule_work_pattern")]
    public partial class ScheduleWorkPattern : IEquatable<ScheduleWorkPattern>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleWorkPattern" /> class.
        /// </summary>
        /// <param name="oddWeeks">oddWeeks.</param>
        /// <param name="evenWeeks">evenWeeks.</param>
        public ScheduleWorkPattern(ScheduleWorkPatternOddWeeks oddWeeks = default(ScheduleWorkPatternOddWeeks), ScheduleWorkPatternOddWeeks evenWeeks = default(ScheduleWorkPatternOddWeeks))
        {
            this.OddWeeks = oddWeeks;
            this.EvenWeeks = evenWeeks;
        }

        /// <summary>
        /// Gets or Sets OddWeeks
        /// </summary>
        [DataMember(Name = "odd_weeks", EmitDefaultValue = false)]
        public ScheduleWorkPatternOddWeeks OddWeeks { get; set; }

        /// <summary>
        /// Gets or Sets EvenWeeks
        /// </summary>
        [DataMember(Name = "even_weeks", EmitDefaultValue = false)]
        public ScheduleWorkPatternOddWeeks EvenWeeks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleWorkPattern {\n");
            sb.Append("  OddWeeks: ").Append(OddWeeks).Append("\n");
            sb.Append("  EvenWeeks: ").Append(EvenWeeks).Append("\n");
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
            return this.Equals(input as ScheduleWorkPattern);
        }

        /// <summary>
        /// Returns true if ScheduleWorkPattern instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleWorkPattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleWorkPattern input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OddWeeks == input.OddWeeks ||
                    (this.OddWeeks != null &&
                    this.OddWeeks.Equals(input.OddWeeks))
                ) && 
                (
                    this.EvenWeeks == input.EvenWeeks ||
                    (this.EvenWeeks != null &&
                    this.EvenWeeks.Equals(input.EvenWeeks))
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
                if (this.OddWeeks != null)
                {
                    hashCode = (hashCode * 59) + this.OddWeeks.GetHashCode();
                }
                if (this.EvenWeeks != null)
                {
                    hashCode = (hashCode * 59) + this.EvenWeeks.GetHashCode();
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
