/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.1
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
    /// AgedReportFilter
    /// </summary>
    [DataContract(Name = "AgedReportFilter")]
    public partial class AgedReportFilter : IEquatable<AgedReportFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgedReportFilter" /> class.
        /// </summary>
        /// <param name="customerId">Filter by customer id.</param>
        /// <param name="supplierId">Filter by supplier id.</param>
        /// <param name="reportAsOfDate">The cutoff date for considering transactions.</param>
        /// <param name="periodCount">Number of periods to split the aged creditors report into.</param>
        /// <param name="periodLength">Length of each period in days.</param>
        public AgedReportFilter(string customerId = default(string), string supplierId = default(string), string reportAsOfDate = default(string), int periodCount = default(int), int periodLength = default(int))
        {
            this.CustomerId = customerId;
            this.SupplierId = supplierId;
            this.ReportAsOfDate = reportAsOfDate;
            this.PeriodCount = periodCount;
            this.PeriodLength = periodLength;
        }

        /// <summary>
        /// Filter by customer id
        /// </summary>
        /// <value>Filter by customer id</value>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Filter by supplier id
        /// </summary>
        /// <value>Filter by supplier id</value>
        [DataMember(Name = "supplier_id", EmitDefaultValue = false)]
        public string SupplierId { get; set; }

        /// <summary>
        /// The cutoff date for considering transactions
        /// </summary>
        /// <value>The cutoff date for considering transactions</value>
        [DataMember(Name = "report_as_of_date", EmitDefaultValue = false)]
        public string ReportAsOfDate { get; set; }

        /// <summary>
        /// Number of periods to split the aged creditors report into
        /// </summary>
        /// <value>Number of periods to split the aged creditors report into</value>
        [DataMember(Name = "period_count", EmitDefaultValue = false)]
        public int PeriodCount { get; set; }

        /// <summary>
        /// Length of each period in days
        /// </summary>
        /// <value>Length of each period in days</value>
        [DataMember(Name = "period_length", EmitDefaultValue = false)]
        public int PeriodLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgedReportFilter {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
            sb.Append("  ReportAsOfDate: ").Append(ReportAsOfDate).Append("\n");
            sb.Append("  PeriodCount: ").Append(PeriodCount).Append("\n");
            sb.Append("  PeriodLength: ").Append(PeriodLength).Append("\n");
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
            return this.Equals(input as AgedReportFilter);
        }

        /// <summary>
        /// Returns true if AgedReportFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of AgedReportFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgedReportFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.SupplierId == input.SupplierId ||
                    (this.SupplierId != null &&
                    this.SupplierId.Equals(input.SupplierId))
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
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.SupplierId != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierId.GetHashCode();
                }
                if (this.ReportAsOfDate != null)
                {
                    hashCode = (hashCode * 59) + this.ReportAsOfDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PeriodCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PeriodLength.GetHashCode();
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
            // PeriodCount (int) maximum
            if (this.PeriodCount > (int)12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PeriodCount, must be a value less than or equal to 12.", new [] { "PeriodCount" });
            }

            // PeriodCount (int) minimum
            if (this.PeriodCount < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PeriodCount, must be a value greater than or equal to 1.", new [] { "PeriodCount" });
            }

            // PeriodLength (int) maximum
            if (this.PeriodLength > (int)365)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PeriodLength, must be a value less than or equal to 365.", new [] { "PeriodLength" });
            }

            // PeriodLength (int) minimum
            if (this.PeriodLength < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PeriodLength, must be a value greater than or equal to 1.", new [] { "PeriodLength" });
            }

            yield break;
        }
    }

}
