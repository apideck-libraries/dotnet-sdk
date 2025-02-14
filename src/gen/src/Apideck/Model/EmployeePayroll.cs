/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.4
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
    /// EmployeePayroll
    /// </summary>
    [DataContract(Name = "EmployeePayroll")]
    public partial class EmployeePayroll : IEquatable<EmployeePayroll>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeePayroll" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmployeePayroll() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeePayroll" /> class.
        /// </summary>
        /// <param name="employeeId">ID of the employee.</param>
        /// <param name="companyId">The unique identifier of the company..</param>
        /// <param name="processed">Whether or not the payroll has been successfully processed. Note that processed payrolls cannot be updated. (required).</param>
        /// <param name="processedDate">The date the payroll was processed..</param>
        /// <param name="checkDate">The date on which employees will be paid for the payroll. (required).</param>
        /// <param name="startDate">The start date, inclusive, of the pay period. (required).</param>
        /// <param name="endDate">The end date, inclusive, of the pay period. (required).</param>
        /// <param name="totals">totals.</param>
        /// <param name="compensations">An array of compensations for the payroll..</param>
        public EmployeePayroll(string employeeId = default(string), string companyId = default(string), bool? processed = default(bool?), string processedDate = default(string), string checkDate = default(string), string startDate = default(string), string endDate = default(string), PayrollTotals totals = default(PayrollTotals), List<Compensation> compensations = default(List<Compensation>))
        {
            // to ensure "processed" is required (not null)
            if (processed == null) {
                throw new ArgumentNullException("processed is a required property for EmployeePayroll and cannot be null");
            }
            this.Processed = processed;
            // to ensure "checkDate" is required (not null)
            if (checkDate == null) {
                throw new ArgumentNullException("checkDate is a required property for EmployeePayroll and cannot be null");
            }
            this.CheckDate = checkDate;
            // to ensure "startDate" is required (not null)
            if (startDate == null) {
                throw new ArgumentNullException("startDate is a required property for EmployeePayroll and cannot be null");
            }
            this.StartDate = startDate;
            // to ensure "endDate" is required (not null)
            if (endDate == null) {
                throw new ArgumentNullException("endDate is a required property for EmployeePayroll and cannot be null");
            }
            this.EndDate = endDate;
            this.EmployeeId = employeeId;
            this.CompanyId = companyId;
            this.ProcessedDate = processedDate;
            this.Totals = totals;
            this.Compensations = compensations;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// ID of the employee
        /// </summary>
        /// <value>ID of the employee</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = true)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// The unique identifier of the company.
        /// </summary>
        /// <value>The unique identifier of the company.</value>
        [DataMember(Name = "company_id", EmitDefaultValue = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Whether or not the payroll has been successfully processed. Note that processed payrolls cannot be updated.
        /// </summary>
        /// <value>Whether or not the payroll has been successfully processed. Note that processed payrolls cannot be updated.</value>
        [DataMember(Name = "processed", IsRequired = true, EmitDefaultValue = true)]
        public bool? Processed { get; set; }

        /// <summary>
        /// The date the payroll was processed.
        /// </summary>
        /// <value>The date the payroll was processed.</value>
        [DataMember(Name = "processed_date", EmitDefaultValue = true)]
        public string ProcessedDate { get; set; }

        /// <summary>
        /// The date on which employees will be paid for the payroll.
        /// </summary>
        /// <value>The date on which employees will be paid for the payroll.</value>
        [DataMember(Name = "check_date", IsRequired = true, EmitDefaultValue = true)]
        public string CheckDate { get; set; }

        /// <summary>
        /// The start date, inclusive, of the pay period.
        /// </summary>
        /// <value>The start date, inclusive, of the pay period.</value>
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// The end date, inclusive, of the pay period.
        /// </summary>
        /// <value>The end date, inclusive, of the pay period.</value>
        [DataMember(Name = "end_date", IsRequired = true, EmitDefaultValue = true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Totals
        /// </summary>
        [DataMember(Name = "totals", EmitDefaultValue = false)]
        public PayrollTotals Totals { get; set; }

        /// <summary>
        /// An array of compensations for the payroll.
        /// </summary>
        /// <value>An array of compensations for the payroll.</value>
        [DataMember(Name = "compensations", EmitDefaultValue = false)]
        public List<Compensation> Compensations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeePayroll {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
            sb.Append("  ProcessedDate: ").Append(ProcessedDate).Append("\n");
            sb.Append("  CheckDate: ").Append(CheckDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Totals: ").Append(Totals).Append("\n");
            sb.Append("  Compensations: ").Append(Compensations).Append("\n");
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
            return this.Equals(input as EmployeePayroll);
        }

        /// <summary>
        /// Returns true if EmployeePayroll instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeePayroll to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeePayroll input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.Processed == input.Processed ||
                    (this.Processed != null &&
                    this.Processed.Equals(input.Processed))
                ) && 
                (
                    this.ProcessedDate == input.ProcessedDate ||
                    (this.ProcessedDate != null &&
                    this.ProcessedDate.Equals(input.ProcessedDate))
                ) && 
                (
                    this.CheckDate == input.CheckDate ||
                    (this.CheckDate != null &&
                    this.CheckDate.Equals(input.CheckDate))
                ) && 
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
                    this.Totals == input.Totals ||
                    (this.Totals != null &&
                    this.Totals.Equals(input.Totals))
                ) && 
                (
                    this.Compensations == input.Compensations ||
                    this.Compensations != null &&
                    input.Compensations != null &&
                    this.Compensations.SequenceEqual(input.Compensations)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.Processed != null)
                {
                    hashCode = (hashCode * 59) + this.Processed.GetHashCode();
                }
                if (this.ProcessedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessedDate.GetHashCode();
                }
                if (this.CheckDate != null)
                {
                    hashCode = (hashCode * 59) + this.CheckDate.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.Totals != null)
                {
                    hashCode = (hashCode * 59) + this.Totals.GetHashCode();
                }
                if (this.Compensations != null)
                {
                    hashCode = (hashCode * 59) + this.Compensations.GetHashCode();
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
            // ProcessedDate (string) pattern
            Regex regexProcessedDate = new Regex(@"^\\d{4}-\\d{2}-\\d{2}$", RegexOptions.CultureInvariant);
            if (false == regexProcessedDate.Match(this.ProcessedDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProcessedDate, must match a pattern of " + regexProcessedDate, new [] { "ProcessedDate" });
            }

            // CheckDate (string) pattern
            Regex regexCheckDate = new Regex(@"^\\d{4}-\\d{2}-\\d{2}$", RegexOptions.CultureInvariant);
            if (false == regexCheckDate.Match(this.CheckDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckDate, must match a pattern of " + regexCheckDate, new [] { "CheckDate" });
            }

            // StartDate (string) pattern
            Regex regexStartDate = new Regex(@"^\\d{4}-\\d{2}-\\d{2}$", RegexOptions.CultureInvariant);
            if (false == regexStartDate.Match(this.StartDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDate, must match a pattern of " + regexStartDate, new [] { "StartDate" });
            }

            // EndDate (string) pattern
            Regex regexEndDate = new Regex(@"^\\d{4}-\\d{2}-\\d{2}$", RegexOptions.CultureInvariant);
            if (false == regexEndDate.Match(this.EndDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndDate, must match a pattern of " + regexEndDate, new [] { "EndDate" });
            }

            yield break;
        }
    }

}
