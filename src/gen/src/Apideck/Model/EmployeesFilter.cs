/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.92.0
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
    /// EmployeesFilter
    /// </summary>
    [DataContract(Name = "EmployeesFilter")]
    public partial class EmployeesFilter : IEquatable<EmployeesFilter>, IValidatableObject
    {
        /// <summary>
        /// Employment status to filter on
        /// </summary>
        /// <value>Employment status to filter on</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmploymentStatusEnum
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
            /// Enum Terminated for value: terminated
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated = 3,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4

        }


        /// <summary>
        /// Employment status to filter on
        /// </summary>
        /// <value>Employment status to filter on</value>
        [DataMember(Name = "employment_status", EmitDefaultValue = false)]
        public EmploymentStatusEnum? EmploymentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeesFilter" /> class.
        /// </summary>
        /// <param name="companyId">Company ID to filter on.</param>
        /// <param name="email">Email to filter on.</param>
        /// <param name="firstName">First Name to filter on.</param>
        /// <param name="title">Job title to filter on.</param>
        /// <param name="lastName">Last Name to filter on.</param>
        /// <param name="managerId">Manager id to filter on.</param>
        /// <param name="employmentStatus">Employment status to filter on.</param>
        /// <param name="employeeNumber">Employee number to filter on.</param>
        /// <param name="departmentId">ID of the department to filter on.</param>
        public EmployeesFilter(string companyId = default(string), string email = default(string), string firstName = default(string), string title = default(string), string lastName = default(string), string managerId = default(string), EmploymentStatusEnum? employmentStatus = default(EmploymentStatusEnum?), string employeeNumber = default(string), string departmentId = default(string))
        {
            this.CompanyId = companyId;
            this.Email = email;
            this.FirstName = firstName;
            this.Title = title;
            this.LastName = lastName;
            this.ManagerId = managerId;
            this.EmploymentStatus = employmentStatus;
            this.EmployeeNumber = employeeNumber;
            this.DepartmentId = departmentId;
        }

        /// <summary>
        /// Company ID to filter on
        /// </summary>
        /// <value>Company ID to filter on</value>
        [DataMember(Name = "company_id", EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Email to filter on
        /// </summary>
        /// <value>Email to filter on</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// First Name to filter on
        /// </summary>
        /// <value>First Name to filter on</value>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Job title to filter on
        /// </summary>
        /// <value>Job title to filter on</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Last Name to filter on
        /// </summary>
        /// <value>Last Name to filter on</value>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Manager id to filter on
        /// </summary>
        /// <value>Manager id to filter on</value>
        [DataMember(Name = "manager_id", EmitDefaultValue = false)]
        public string ManagerId { get; set; }

        /// <summary>
        /// Employee number to filter on
        /// </summary>
        /// <value>Employee number to filter on</value>
        [DataMember(Name = "employee_number", EmitDefaultValue = false)]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// ID of the department to filter on
        /// </summary>
        /// <value>ID of the department to filter on</value>
        [DataMember(Name = "department_id", EmitDefaultValue = false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeesFilter {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ManagerId: ").Append(ManagerId).Append("\n");
            sb.Append("  EmploymentStatus: ").Append(EmploymentStatus).Append("\n");
            sb.Append("  EmployeeNumber: ").Append(EmployeeNumber).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
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
            return this.Equals(input as EmployeesFilter);
        }

        /// <summary>
        /// Returns true if EmployeesFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeesFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeesFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.ManagerId == input.ManagerId ||
                    (this.ManagerId != null &&
                    this.ManagerId.Equals(input.ManagerId))
                ) && 
                (
                    this.EmploymentStatus == input.EmploymentStatus ||
                    this.EmploymentStatus.Equals(input.EmploymentStatus)
                ) && 
                (
                    this.EmployeeNumber == input.EmployeeNumber ||
                    (this.EmployeeNumber != null &&
                    this.EmployeeNumber.Equals(input.EmployeeNumber))
                ) && 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
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
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.ManagerId != null)
                {
                    hashCode = (hashCode * 59) + this.ManagerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EmploymentStatus.GetHashCode();
                if (this.EmployeeNumber != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeNumber.GetHashCode();
                }
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
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
