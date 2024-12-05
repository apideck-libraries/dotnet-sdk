/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.8.2
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
    /// BalanceSheetFilter
    /// </summary>
    [DataContract(Name = "BalanceSheetFilter")]
    public partial class BalanceSheetFilter : IEquatable<BalanceSheetFilter>, IValidatableObject
    {
        /// <summary>
        /// The type of period to include in the resource: month, quarter, year.
        /// </summary>
        /// <value>The type of period to include in the resource: month, quarter, year.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodTypeEnum
        {
            /// <summary>
            /// Enum Month for value: month
            /// </summary>
            [EnumMember(Value = "month")]
            Month = 1,

            /// <summary>
            /// Enum Quarter for value: quarter
            /// </summary>
            [EnumMember(Value = "quarter")]
            Quarter = 2,

            /// <summary>
            /// Enum Year for value: year
            /// </summary>
            [EnumMember(Value = "year")]
            Year = 3

        }


        /// <summary>
        /// The type of period to include in the resource: month, quarter, year.
        /// </summary>
        /// <value>The type of period to include in the resource: month, quarter, year.</value>
        [DataMember(Name = "period_type", EmitDefaultValue = false)]
        public PeriodTypeEnum? PeriodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheetFilter" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the period to include in the resource..</param>
        /// <param name="endDate">The end date of the period to include in the resource..</param>
        /// <param name="periodCount">The number of periods to include in the resource..</param>
        /// <param name="periodType">The type of period to include in the resource: month, quarter, year..</param>
        public BalanceSheetFilter(string startDate = default(string), string endDate = default(string), int periodCount = default(int), PeriodTypeEnum? periodType = default(PeriodTypeEnum?))
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.PeriodCount = periodCount;
            this.PeriodType = periodType;
        }

        /// <summary>
        /// The start date of the period to include in the resource.
        /// </summary>
        /// <value>The start date of the period to include in the resource.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The end date of the period to include in the resource.
        /// </summary>
        /// <value>The end date of the period to include in the resource.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The number of periods to include in the resource.
        /// </summary>
        /// <value>The number of periods to include in the resource.</value>
        [DataMember(Name = "period_count", EmitDefaultValue = false)]
        public int PeriodCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceSheetFilter {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PeriodCount: ").Append(PeriodCount).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
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
            return this.Equals(input as BalanceSheetFilter);
        }

        /// <summary>
        /// Returns true if BalanceSheetFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceSheetFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceSheetFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.PeriodCount == input.PeriodCount ||
                    this.PeriodCount.Equals(input.PeriodCount)
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    this.PeriodType.Equals(input.PeriodType)
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PeriodCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PeriodType.GetHashCode();
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
