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
    /// EmployeeJob
    /// </summary>
    [DataContract(Name = "EmployeeJob")]
    public partial class EmployeeJob : IEquatable<EmployeeJob>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }

        /// <summary>
        /// Gets or Sets PaymentUnit
        /// </summary>
        [DataMember(Name = "payment_unit", EmitDefaultValue = true)]
        public PaymentUnit? PaymentUnit { get; set; }
        /// <summary>
        /// Indicates the status of the job.
        /// </summary>
        /// <value>Indicates the status of the job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3

        }


        /// <summary>
        /// Indicates the status of the job.
        /// </summary>
        /// <value>Indicates the status of the job.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeJob" /> class.
        /// </summary>
        /// <param name="title">The job title of the person..</param>
        /// <param name="role">The position and responsibilities of the person within the organization..</param>
        /// <param name="startDate">The date on which the employee starts working in their current job role..</param>
        /// <param name="endDate">The date on which the employee leaves or is expected to leave their current job role..</param>
        /// <param name="compensationRate">The rate of pay for the employee in their current job role..</param>
        /// <param name="currency">currency.</param>
        /// <param name="paymentUnit">paymentUnit.</param>
        /// <param name="hiredAt">The date on which the employee was hired by the organization.</param>
        /// <param name="isPrimary">Indicates whether this the employee&#39;s primary job..</param>
        /// <param name="isManager">Indicates whether this the employee has a manager role..</param>
        /// <param name="status">Indicates the status of the job..</param>
        /// <param name="location">location.</param>
        public EmployeeJob(string title = default(string), string role = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), decimal? compensationRate = default(decimal?), Currency? currency = default(Currency?), PaymentUnit? paymentUnit = default(PaymentUnit?), DateTime? hiredAt = default(DateTime?), bool? isPrimary = default(bool?), bool? isManager = default(bool?), StatusEnum? status = default(StatusEnum?), Address location = default(Address))
        {
            this.Title = title;
            this.Role = role;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CompensationRate = compensationRate;
            this.Currency = currency;
            this.PaymentUnit = paymentUnit;
            this.HiredAt = hiredAt;
            this.IsPrimary = isPrimary;
            this.IsManager = isManager;
            this.Status = status;
            this.Location = location;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
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
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = true)]
        public string EmployeeId { get; private set; }

        /// <summary>
        /// Returns false as EmployeeId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmployeeId()
        {
            return false;
        }
        /// <summary>
        /// The job title of the person.
        /// </summary>
        /// <value>The job title of the person.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The position and responsibilities of the person within the organization.
        /// </summary>
        /// <value>The position and responsibilities of the person within the organization.</value>
        [DataMember(Name = "role", EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// The date on which the employee starts working in their current job role.
        /// </summary>
        /// <value>The date on which the employee starts working in their current job role.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date on which the employee leaves or is expected to leave their current job role.
        /// </summary>
        /// <value>The date on which the employee leaves or is expected to leave their current job role.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The rate of pay for the employee in their current job role.
        /// </summary>
        /// <value>The rate of pay for the employee in their current job role.</value>
        [DataMember(Name = "compensation_rate", EmitDefaultValue = true)]
        public decimal? CompensationRate { get; set; }

        /// <summary>
        /// The date on which the employee was hired by the organization
        /// </summary>
        /// <value>The date on which the employee was hired by the organization</value>
        [DataMember(Name = "hired_at", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? HiredAt { get; set; }

        /// <summary>
        /// Indicates whether this the employee&#39;s primary job.
        /// </summary>
        /// <value>Indicates whether this the employee&#39;s primary job.</value>
        [DataMember(Name = "is_primary", EmitDefaultValue = true)]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Indicates whether this the employee has a manager role.
        /// </summary>
        /// <value>Indicates whether this the employee has a manager role.</value>
        [DataMember(Name = "is_manager", EmitDefaultValue = true)]
        public bool? IsManager { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public Address Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeeJob {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  CompensationRate: ").Append(CompensationRate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentUnit: ").Append(PaymentUnit).Append("\n");
            sb.Append("  HiredAt: ").Append(HiredAt).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
            sb.Append("  IsManager: ").Append(IsManager).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as EmployeeJob);
        }

        /// <summary>
        /// Returns true if EmployeeJob instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeJob input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                    this.CompensationRate == input.CompensationRate ||
                    (this.CompensationRate != null &&
                    this.CompensationRate.Equals(input.CompensationRate))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.PaymentUnit == input.PaymentUnit ||
                    this.PaymentUnit.Equals(input.PaymentUnit)
                ) && 
                (
                    this.HiredAt == input.HiredAt ||
                    (this.HiredAt != null &&
                    this.HiredAt.Equals(input.HiredAt))
                ) && 
                (
                    this.IsPrimary == input.IsPrimary ||
                    (this.IsPrimary != null &&
                    this.IsPrimary.Equals(input.IsPrimary))
                ) && 
                (
                    this.IsManager == input.IsManager ||
                    (this.IsManager != null &&
                    this.IsManager.Equals(input.IsManager))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.CompensationRate != null)
                {
                    hashCode = (hashCode * 59) + this.CompensationRate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentUnit.GetHashCode();
                if (this.HiredAt != null)
                {
                    hashCode = (hashCode * 59) + this.HiredAt.GetHashCode();
                }
                if (this.IsPrimary != null)
                {
                    hashCode = (hashCode * 59) + this.IsPrimary.GetHashCode();
                }
                if (this.IsManager != null)
                {
                    hashCode = (hashCode * 59) + this.IsManager.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
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
