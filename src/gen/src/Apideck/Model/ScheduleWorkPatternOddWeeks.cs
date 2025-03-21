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
    /// ScheduleWorkPatternOddWeeks
    /// </summary>
    [DataContract(Name = "Schedule_work_pattern_odd_weeks")]
    public partial class ScheduleWorkPatternOddWeeks : IEquatable<ScheduleWorkPatternOddWeeks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleWorkPatternOddWeeks" /> class.
        /// </summary>
        /// <param name="hoursMonday">hoursMonday.</param>
        /// <param name="hoursTuesday">hoursTuesday.</param>
        /// <param name="hoursWednesday">hoursWednesday.</param>
        /// <param name="hoursThursday">hoursThursday.</param>
        /// <param name="hoursFriday">hoursFriday.</param>
        /// <param name="hoursSaturday">hoursSaturday.</param>
        /// <param name="hoursSunday">hoursSunday.</param>
        public ScheduleWorkPatternOddWeeks(double hoursMonday = default(double), double hoursTuesday = default(double), double hoursWednesday = default(double), double hoursThursday = default(double), double hoursFriday = default(double), double hoursSaturday = default(double), double hoursSunday = default(double))
        {
            this.HoursMonday = hoursMonday;
            this.HoursTuesday = hoursTuesday;
            this.HoursWednesday = hoursWednesday;
            this.HoursThursday = hoursThursday;
            this.HoursFriday = hoursFriday;
            this.HoursSaturday = hoursSaturday;
            this.HoursSunday = hoursSunday;
        }

        /// <summary>
        /// Gets or Sets HoursMonday
        /// </summary>
        [DataMember(Name = "hours_monday", EmitDefaultValue = false)]
        public double HoursMonday { get; set; }

        /// <summary>
        /// Gets or Sets HoursTuesday
        /// </summary>
        [DataMember(Name = "hours_tuesday", EmitDefaultValue = false)]
        public double HoursTuesday { get; set; }

        /// <summary>
        /// Gets or Sets HoursWednesday
        /// </summary>
        [DataMember(Name = "hours_wednesday", EmitDefaultValue = false)]
        public double HoursWednesday { get; set; }

        /// <summary>
        /// Gets or Sets HoursThursday
        /// </summary>
        [DataMember(Name = "hours_thursday", EmitDefaultValue = false)]
        public double HoursThursday { get; set; }

        /// <summary>
        /// Gets or Sets HoursFriday
        /// </summary>
        [DataMember(Name = "hours_friday", EmitDefaultValue = false)]
        public double HoursFriday { get; set; }

        /// <summary>
        /// Gets or Sets HoursSaturday
        /// </summary>
        [DataMember(Name = "hours_saturday", EmitDefaultValue = false)]
        public double HoursSaturday { get; set; }

        /// <summary>
        /// Gets or Sets HoursSunday
        /// </summary>
        [DataMember(Name = "hours_sunday", EmitDefaultValue = false)]
        public double HoursSunday { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleWorkPatternOddWeeks {\n");
            sb.Append("  HoursMonday: ").Append(HoursMonday).Append("\n");
            sb.Append("  HoursTuesday: ").Append(HoursTuesday).Append("\n");
            sb.Append("  HoursWednesday: ").Append(HoursWednesday).Append("\n");
            sb.Append("  HoursThursday: ").Append(HoursThursday).Append("\n");
            sb.Append("  HoursFriday: ").Append(HoursFriday).Append("\n");
            sb.Append("  HoursSaturday: ").Append(HoursSaturday).Append("\n");
            sb.Append("  HoursSunday: ").Append(HoursSunday).Append("\n");
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
            return this.Equals(input as ScheduleWorkPatternOddWeeks);
        }

        /// <summary>
        /// Returns true if ScheduleWorkPatternOddWeeks instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleWorkPatternOddWeeks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleWorkPatternOddWeeks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HoursMonday == input.HoursMonday ||
                    this.HoursMonday.Equals(input.HoursMonday)
                ) && 
                (
                    this.HoursTuesday == input.HoursTuesday ||
                    this.HoursTuesday.Equals(input.HoursTuesday)
                ) && 
                (
                    this.HoursWednesday == input.HoursWednesday ||
                    this.HoursWednesday.Equals(input.HoursWednesday)
                ) && 
                (
                    this.HoursThursday == input.HoursThursday ||
                    this.HoursThursday.Equals(input.HoursThursday)
                ) && 
                (
                    this.HoursFriday == input.HoursFriday ||
                    this.HoursFriday.Equals(input.HoursFriday)
                ) && 
                (
                    this.HoursSaturday == input.HoursSaturday ||
                    this.HoursSaturday.Equals(input.HoursSaturday)
                ) && 
                (
                    this.HoursSunday == input.HoursSunday ||
                    this.HoursSunday.Equals(input.HoursSunday)
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
                hashCode = (hashCode * 59) + this.HoursMonday.GetHashCode();
                hashCode = (hashCode * 59) + this.HoursTuesday.GetHashCode();
                hashCode = (hashCode * 59) + this.HoursWednesday.GetHashCode();
                hashCode = (hashCode * 59) + this.HoursThursday.GetHashCode();
                hashCode = (hashCode * 59) + this.HoursFriday.GetHashCode();
                hashCode = (hashCode * 59) + this.HoursSaturday.GetHashCode();
                hashCode = (hashCode * 59) + this.HoursSunday.GetHashCode();
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
            // HoursMonday (double) maximum
            if (this.HoursMonday > (double)24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursMonday, must be a value less than or equal to 24.", new [] { "HoursMonday" });
            }

            // HoursMonday (double) minimum
            if (this.HoursMonday < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursMonday, must be a value greater than or equal to 0.", new [] { "HoursMonday" });
            }

            // HoursTuesday (double) maximum
            if (this.HoursTuesday > (double)24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursTuesday, must be a value less than or equal to 24.", new [] { "HoursTuesday" });
            }

            // HoursTuesday (double) minimum
            if (this.HoursTuesday < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursTuesday, must be a value greater than or equal to 0.", new [] { "HoursTuesday" });
            }

            // HoursWednesday (double) maximum
            if (this.HoursWednesday > (double)24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursWednesday, must be a value less than or equal to 24.", new [] { "HoursWednesday" });
            }

            // HoursWednesday (double) minimum
            if (this.HoursWednesday < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursWednesday, must be a value greater than or equal to 0.", new [] { "HoursWednesday" });
            }

            // HoursThursday (double) maximum
            if (this.HoursThursday > (double)24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursThursday, must be a value less than or equal to 24.", new [] { "HoursThursday" });
            }

            // HoursThursday (double) minimum
            if (this.HoursThursday < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursThursday, must be a value greater than or equal to 0.", new [] { "HoursThursday" });
            }

            // HoursFriday (double) maximum
            if (this.HoursFriday > (double)24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursFriday, must be a value less than or equal to 24.", new [] { "HoursFriday" });
            }

            // HoursFriday (double) minimum
            if (this.HoursFriday < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursFriday, must be a value greater than or equal to 0.", new [] { "HoursFriday" });
            }

            // HoursSaturday (double) maximum
            if (this.HoursSaturday > (double)24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursSaturday, must be a value less than or equal to 24.", new [] { "HoursSaturday" });
            }

            // HoursSaturday (double) minimum
            if (this.HoursSaturday < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursSaturday, must be a value greater than or equal to 0.", new [] { "HoursSaturday" });
            }

            // HoursSunday (double) maximum
            if (this.HoursSunday > (double)24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursSunday, must be a value less than or equal to 24.", new [] { "HoursSunday" });
            }

            // HoursSunday (double) minimum
            if (this.HoursSunday < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoursSunday, must be a value greater than or equal to 0.", new [] { "HoursSunday" });
            }

            yield break;
        }
    }

}
