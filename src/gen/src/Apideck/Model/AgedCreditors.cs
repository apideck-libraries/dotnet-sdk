/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.10.0
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
    /// AgedCreditors
    /// </summary>
    [DataContract(Name = "AgedCreditors")]
    public partial class AgedCreditors : IEquatable<AgedCreditors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgedCreditors" /> class.
        /// </summary>
        /// <param name="reportGeneratedAt">The exact date and time the report was generated..</param>
        /// <param name="reportAsOfDate">The cutoff date for transactions included in the report..</param>
        /// <param name="periodCount">Number of aging periods shown in the report. (default to 4).</param>
        /// <param name="periodLength">Length of each aging period in days. (default to 30).</param>
        /// <param name="outstandingBalances">outstandingBalances.</param>
        public AgedCreditors(DateTime reportGeneratedAt = default(DateTime), DateTime reportAsOfDate = default(DateTime), int periodCount = 4, int periodLength = 30, List<OutstandingBalanceBySupplier> outstandingBalances = default(List<OutstandingBalanceBySupplier>))
        {
            this.ReportGeneratedAt = reportGeneratedAt;
            this.ReportAsOfDate = reportAsOfDate;
            this.PeriodCount = periodCount;
            this.PeriodLength = periodLength;
            this.OutstandingBalances = outstandingBalances;
        }

        /// <summary>
        /// The exact date and time the report was generated.
        /// </summary>
        /// <value>The exact date and time the report was generated.</value>
        [DataMember(Name = "report_generated_at", EmitDefaultValue = false)]
        public DateTime ReportGeneratedAt { get; set; }

        /// <summary>
        /// The cutoff date for transactions included in the report.
        /// </summary>
        /// <value>The cutoff date for transactions included in the report.</value>
        [DataMember(Name = "report_as_of_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ReportAsOfDate { get; set; }

        /// <summary>
        /// Number of aging periods shown in the report.
        /// </summary>
        /// <value>Number of aging periods shown in the report.</value>
        [DataMember(Name = "period_count", EmitDefaultValue = false)]
        public int PeriodCount { get; set; }

        /// <summary>
        /// Length of each aging period in days.
        /// </summary>
        /// <value>Length of each aging period in days.</value>
        [DataMember(Name = "period_length", EmitDefaultValue = false)]
        public int PeriodLength { get; set; }

        /// <summary>
        /// Gets or Sets OutstandingBalances
        /// </summary>
        [DataMember(Name = "outstanding_balances", EmitDefaultValue = false)]
        public List<OutstandingBalanceBySupplier> OutstandingBalances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgedCreditors {\n");
            sb.Append("  ReportGeneratedAt: ").Append(ReportGeneratedAt).Append("\n");
            sb.Append("  ReportAsOfDate: ").Append(ReportAsOfDate).Append("\n");
            sb.Append("  PeriodCount: ").Append(PeriodCount).Append("\n");
            sb.Append("  PeriodLength: ").Append(PeriodLength).Append("\n");
            sb.Append("  OutstandingBalances: ").Append(OutstandingBalances).Append("\n");
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
            return this.Equals(input as AgedCreditors);
        }

        /// <summary>
        /// Returns true if AgedCreditors instances are equal
        /// </summary>
        /// <param name="input">Instance of AgedCreditors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgedCreditors input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReportGeneratedAt == input.ReportGeneratedAt ||
                    (this.ReportGeneratedAt != null &&
                    this.ReportGeneratedAt.Equals(input.ReportGeneratedAt))
                ) && 
                (
                    this.ReportAsOfDate == input.ReportAsOfDate ||
                    (this.ReportAsOfDate != null &&
                    this.ReportAsOfDate.Equals(input.ReportAsOfDate))
                ) && 
                (
                    this.PeriodCount == input.PeriodCount ||
                    this.PeriodCount.Equals(input.PeriodCount)
                ) && 
                (
                    this.PeriodLength == input.PeriodLength ||
                    this.PeriodLength.Equals(input.PeriodLength)
                ) && 
                (
                    this.OutstandingBalances == input.OutstandingBalances ||
                    this.OutstandingBalances != null &&
                    input.OutstandingBalances != null &&
                    this.OutstandingBalances.SequenceEqual(input.OutstandingBalances)
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
                if (this.ReportGeneratedAt != null)
                {
                    hashCode = (hashCode * 59) + this.ReportGeneratedAt.GetHashCode();
                }
                if (this.ReportAsOfDate != null)
                {
                    hashCode = (hashCode * 59) + this.ReportAsOfDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PeriodCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PeriodLength.GetHashCode();
                if (this.OutstandingBalances != null)
                {
                    hashCode = (hashCode * 59) + this.OutstandingBalances.GetHashCode();
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
