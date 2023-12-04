/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.1.0
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
    /// EmployeeEmploymentRole
    /// </summary>
    [DataContract(Name = "Employee_employment_role")]
    public partial class EmployeeEmploymentRole : IEquatable<EmployeeEmploymentRole>, IValidatableObject
    {
        /// <summary>
        /// The type of employment relationship the employee has with the organization.
        /// </summary>
        /// <value>The type of employment relationship the employee has with the organization.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Contractor for value: contractor
            /// </summary>
            [EnumMember(Value = "contractor")]
            Contractor = 1,

            /// <summary>
            /// Enum Employee for value: employee
            /// </summary>
            [EnumMember(Value = "employee")]
            Employee = 2,

            /// <summary>
            /// Enum Freelance for value: freelance
            /// </summary>
            [EnumMember(Value = "freelance")]
            Freelance = 3,

            /// <summary>
            /// Enum Temp for value: temp
            /// </summary>
            [EnumMember(Value = "temp")]
            Temp = 4,

            /// <summary>
            /// Enum Internship for value: internship
            /// </summary>
            [EnumMember(Value = "internship")]
            Internship = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6

        }


        /// <summary>
        /// The type of employment relationship the employee has with the organization.
        /// </summary>
        /// <value>The type of employment relationship the employee has with the organization.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The work schedule of the employee.
        /// </summary>
        /// <value>The work schedule of the employee.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubTypeEnum
        {
            /// <summary>
            /// Enum FullTime for value: full_time
            /// </summary>
            [EnumMember(Value = "full_time")]
            FullTime = 1,

            /// <summary>
            /// Enum PartTime for value: part_time
            /// </summary>
            [EnumMember(Value = "part_time")]
            PartTime = 2,

            /// <summary>
            /// Enum Hourly for value: hourly
            /// </summary>
            [EnumMember(Value = "hourly")]
            Hourly = 3,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4

        }


        /// <summary>
        /// The work schedule of the employee.
        /// </summary>
        /// <value>The work schedule of the employee.</value>
        [DataMember(Name = "sub_type", EmitDefaultValue = true)]
        public SubTypeEnum? SubType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeEmploymentRole" /> class.
        /// </summary>
        /// <param name="type">The type of employment relationship the employee has with the organization..</param>
        /// <param name="subType">The work schedule of the employee..</param>
        public EmployeeEmploymentRole(TypeEnum? type = default(TypeEnum?), SubTypeEnum? subType = default(SubTypeEnum?))
        {
            this.Type = type;
            this.SubType = subType;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeeEmploymentRole {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
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
            return this.Equals(input as EmployeeEmploymentRole);
        }

        /// <summary>
        /// Returns true if EmployeeEmploymentRole instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeEmploymentRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeEmploymentRole input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SubType == input.SubType ||
                    this.SubType.Equals(input.SubType)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.SubType.GetHashCode();
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
