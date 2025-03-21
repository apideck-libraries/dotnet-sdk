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
    /// TimeOffRequestsFilter
    /// </summary>
    [DataContract(Name = "TimeOffRequestsFilter")]
    public partial class TimeOffRequestsFilter : IEquatable<TimeOffRequestsFilter>, IValidatableObject
    {
        /// <summary>
        /// Time off request status to filter on
        /// </summary>
        /// <value>Time off request status to filter on</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeOffRequestStatusEnum
        {
            /// <summary>
            /// Enum Requested for value: requested
            /// </summary>
            [EnumMember(Value = "requested")]
            Requested = 1,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 2,

            /// <summary>
            /// Enum Declined for value: declined
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined = 3,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 4,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6

        }


        /// <summary>
        /// Time off request status to filter on
        /// </summary>
        /// <value>Time off request status to filter on</value>
        [DataMember(Name = "time_off_request_status", EmitDefaultValue = false)]
        public TimeOffRequestStatusEnum? TimeOffRequestStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestsFilter" /> class.
        /// </summary>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="updatedSince">Minimum date the time off request was last created or modified.</param>
        /// <param name="employeeId">Employee ID.</param>
        /// <param name="timeOffRequestStatus">Time off request status to filter on.</param>
        /// <param name="companyId">Company ID.</param>
        public TimeOffRequestsFilter(string startDate = default(string), string endDate = default(string), string updatedSince = default(string), string employeeId = default(string), TimeOffRequestStatusEnum? timeOffRequestStatus = default(TimeOffRequestStatusEnum?), string companyId = default(string))
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.UpdatedSince = updatedSince;
            this.EmployeeId = employeeId;
            this.TimeOffRequestStatus = timeOffRequestStatus;
            this.CompanyId = companyId;
        }

        /// <summary>
        /// Start date
        /// </summary>
        /// <value>Start date</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        /// <value>End date</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Minimum date the time off request was last created or modified
        /// </summary>
        /// <value>Minimum date the time off request was last created or modified</value>
        [DataMember(Name = "updated_since", EmitDefaultValue = false)]
        public string UpdatedSince { get; set; }

        /// <summary>
        /// Employee ID
        /// </summary>
        /// <value>Employee ID</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Company ID
        /// </summary>
        /// <value>Company ID</value>
        [DataMember(Name = "company_id", EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeOffRequestsFilter {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  UpdatedSince: ").Append(UpdatedSince).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  TimeOffRequestStatus: ").Append(TimeOffRequestStatus).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
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
            return this.Equals(input as TimeOffRequestsFilter);
        }

        /// <summary>
        /// Returns true if TimeOffRequestsFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeOffRequestsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffRequestsFilter input)
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
                    this.UpdatedSince == input.UpdatedSince ||
                    (this.UpdatedSince != null &&
                    this.UpdatedSince.Equals(input.UpdatedSince))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.TimeOffRequestStatus == input.TimeOffRequestStatus ||
                    this.TimeOffRequestStatus.Equals(input.TimeOffRequestStatus)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
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
                if (this.UpdatedSince != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedSince.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TimeOffRequestStatus.GetHashCode();
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
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
