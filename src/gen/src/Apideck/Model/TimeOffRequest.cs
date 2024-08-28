/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.1
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
    /// TimeOffRequest
    /// </summary>
    [DataContract(Name = "TimeOffRequest")]
    public partial class TimeOffRequest : IEquatable<TimeOffRequest>, IValidatableObject
    {
        /// <summary>
        /// The status of the time off request.
        /// </summary>
        /// <value>The status of the time off request.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
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
        /// The status of the time off request.
        /// </summary>
        /// <value>The status of the time off request.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The type of request
        /// </summary>
        /// <value>The type of request</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestTypeEnum
        {
            /// <summary>
            /// Enum Vacation for value: vacation
            /// </summary>
            [EnumMember(Value = "vacation")]
            Vacation = 1,

            /// <summary>
            /// Enum Sick for value: sick
            /// </summary>
            [EnumMember(Value = "sick")]
            Sick = 2,

            /// <summary>
            /// Enum Personal for value: personal
            /// </summary>
            [EnumMember(Value = "personal")]
            Personal = 3,

            /// <summary>
            /// Enum JuryDuty for value: jury_duty
            /// </summary>
            [EnumMember(Value = "jury_duty")]
            JuryDuty = 4,

            /// <summary>
            /// Enum Volunteer for value: volunteer
            /// </summary>
            [EnumMember(Value = "volunteer")]
            Volunteer = 5,

            /// <summary>
            /// Enum Bereavement for value: bereavement
            /// </summary>
            [EnumMember(Value = "bereavement")]
            Bereavement = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7

        }


        /// <summary>
        /// The type of request
        /// </summary>
        /// <value>The type of request</value>
        [DataMember(Name = "request_type", EmitDefaultValue = true)]
        public RequestTypeEnum? RequestType { get; set; }
        /// <summary>
        /// The unit of time off requested. Possible values include: &#x60;hours&#x60;, &#x60;days&#x60;, or &#x60;other&#x60;.
        /// </summary>
        /// <value>The unit of time off requested. Possible values include: &#x60;hours&#x60;, &#x60;days&#x60;, or &#x60;other&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitsEnum
        {
            /// <summary>
            /// Enum Days for value: days
            /// </summary>
            [EnumMember(Value = "days")]
            Days = 1,

            /// <summary>
            /// Enum Hours for value: hours
            /// </summary>
            [EnumMember(Value = "hours")]
            Hours = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3

        }


        /// <summary>
        /// The unit of time off requested. Possible values include: &#x60;hours&#x60;, &#x60;days&#x60;, or &#x60;other&#x60;.
        /// </summary>
        /// <value>The unit of time off requested. Possible values include: &#x60;hours&#x60;, &#x60;days&#x60;, or &#x60;other&#x60;.</value>
        [DataMember(Name = "units", EmitDefaultValue = true)]
        public UnitsEnum? Units { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequest" /> class.
        /// </summary>
        /// <param name="employeeId">ID of the employee.</param>
        /// <param name="policyId">ID of the policy.</param>
        /// <param name="status">The status of the time off request..</param>
        /// <param name="description">Description of the time off request..</param>
        /// <param name="startDate">The start date of the time off request..</param>
        /// <param name="endDate">The end date of the time off request..</param>
        /// <param name="requestDate">The date the request was made..</param>
        /// <param name="requestType">The type of request.</param>
        /// <param name="approvalDate">The date the request was approved.</param>
        /// <param name="units">The unit of time off requested. Possible values include: &#x60;hours&#x60;, &#x60;days&#x60;, or &#x60;other&#x60;..</param>
        /// <param name="amount">The amount of time off requested..</param>
        /// <param name="notes">notes.</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        /// <param name="policyType">The policy type of the time off request.</param>
        public TimeOffRequest(string employeeId = default(string), string policyId = default(string), StatusEnum? status = default(StatusEnum?), string description = default(string), string startDate = default(string), string endDate = default(string), string requestDate = default(string), RequestTypeEnum? requestType = default(RequestTypeEnum?), string approvalDate = default(string), UnitsEnum? units = default(UnitsEnum?), decimal? amount = default(decimal?), TimeOffRequestNotes notes = default(TimeOffRequestNotes), List<Object> passThrough = default(List<Object>), string policyType = default(string))
        {
            this.EmployeeId = employeeId;
            this.PolicyId = policyId;
            this.Status = status;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.RequestDate = requestDate;
            this.RequestType = requestType;
            this.ApprovalDate = approvalDate;
            this.Units = units;
            this.Amount = amount;
            this.Notes = notes;
            this.PassThrough = passThrough;
            this.PolicyType = policyType;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
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
        /// ID of the policy
        /// </summary>
        /// <value>ID of the policy</value>
        [DataMember(Name = "policy_id", EmitDefaultValue = true)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Description of the time off request.
        /// </summary>
        /// <value>Description of the time off request.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The start date of the time off request.
        /// </summary>
        /// <value>The start date of the time off request.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// The end date of the time off request.
        /// </summary>
        /// <value>The end date of the time off request.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        public string EndDate { get; set; }

        /// <summary>
        /// The date the request was made.
        /// </summary>
        /// <value>The date the request was made.</value>
        [DataMember(Name = "request_date", EmitDefaultValue = true)]
        public string RequestDate { get; set; }

        /// <summary>
        /// The date the request was approved
        /// </summary>
        /// <value>The date the request was approved</value>
        [DataMember(Name = "approval_date", EmitDefaultValue = true)]
        public string ApprovalDate { get; set; }

        /// <summary>
        /// The amount of time off requested.
        /// </summary>
        /// <value>The amount of time off requested.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public TimeOffRequestNotes Notes { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; private set; }

        /// <summary>
        /// Returns false as CustomMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomMappings()
        {
            return false;
        }
        /// <summary>
        /// The user who last updated the object.
        /// </summary>
        /// <value>The user who last updated the object.</value>
        [DataMember(Name = "updated_by", EmitDefaultValue = true)]
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// Returns false as UpdatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedBy()
        {
            return false;
        }
        /// <summary>
        /// The user who created the object.
        /// </summary>
        /// <value>The user who created the object.</value>
        [DataMember(Name = "created_by", EmitDefaultValue = true)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        /// <value>The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.</value>
        [DataMember(Name = "pass_through", EmitDefaultValue = false)]
        public List<Object> PassThrough { get; set; }

        /// <summary>
        /// The policy type of the time off request
        /// </summary>
        /// <value>The policy type of the time off request</value>
        [DataMember(Name = "policy_type", EmitDefaultValue = false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeOffRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  RequestDate: ").Append(RequestDate).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  ApprovalDate: ").Append(ApprovalDate).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  PassThrough: ").Append(PassThrough).Append("\n");
            sb.Append("  PolicyType: ").Append(PolicyType).Append("\n");
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
            return this.Equals(input as TimeOffRequest);
        }

        /// <summary>
        /// Returns true if TimeOffRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeOffRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffRequest input)
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
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.RequestDate == input.RequestDate ||
                    (this.RequestDate != null &&
                    this.RequestDate.Equals(input.RequestDate))
                ) && 
                (
                    this.RequestType == input.RequestType ||
                    this.RequestType.Equals(input.RequestType)
                ) && 
                (
                    this.ApprovalDate == input.ApprovalDate ||
                    (this.ApprovalDate != null &&
                    this.ApprovalDate.Equals(input.ApprovalDate))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.PassThrough == input.PassThrough ||
                    this.PassThrough != null &&
                    input.PassThrough != null &&
                    this.PassThrough.SequenceEqual(input.PassThrough)
                ) && 
                (
                    this.PolicyType == input.PolicyType ||
                    (this.PolicyType != null &&
                    this.PolicyType.Equals(input.PolicyType))
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
                if (this.PolicyId != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.RequestDate != null)
                {
                    hashCode = (hashCode * 59) + this.RequestDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestType.GetHashCode();
                if (this.ApprovalDate != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovalDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.PassThrough != null)
                {
                    hashCode = (hashCode * 59) + this.PassThrough.GetHashCode();
                }
                if (this.PolicyType != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyType.GetHashCode();
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

            // RequestDate (string) pattern
            Regex regexRequestDate = new Regex(@"^\\d{4}-\\d{2}-\\d{2}$", RegexOptions.CultureInvariant);
            if (false == regexRequestDate.Match(this.RequestDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestDate, must match a pattern of " + regexRequestDate, new [] { "RequestDate" });
            }

            // ApprovalDate (string) pattern
            Regex regexApprovalDate = new Regex(@"^\\d{4}-\\d{2}-\\d{2}$", RegexOptions.CultureInvariant);
            if (false == regexApprovalDate.Match(this.ApprovalDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApprovalDate, must match a pattern of " + regexApprovalDate, new [] { "ApprovalDate" });
            }

            yield break;
        }
    }

}
