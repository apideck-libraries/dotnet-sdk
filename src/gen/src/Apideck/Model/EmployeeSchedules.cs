/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.36.0
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
    /// EmployeeSchedules
    /// </summary>
    [DataContract(Name = "EmployeeSchedules")]
    public partial class EmployeeSchedules : IEquatable<EmployeeSchedules>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeSchedules" /> class.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <param name="schedules">schedules.</param>
        public EmployeeSchedules(Employee employee = default(Employee), List<Schedule> schedules = default(List<Schedule>))
        {
            this.Employee = employee;
            this.Schedules = schedules;
        }

        /// <summary>
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name = "employee", EmitDefaultValue = false)]
        public Employee Employee { get; set; }

        /// <summary>
        /// Gets or Sets Schedules
        /// </summary>
        [DataMember(Name = "schedules", EmitDefaultValue = false)]
        public List<Schedule> Schedules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeeSchedules {\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Schedules: ").Append(Schedules).Append("\n");
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
            return this.Equals(input as EmployeeSchedules);
        }

        /// <summary>
        /// Returns true if EmployeeSchedules instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeSchedules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeSchedules input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Employee == input.Employee ||
                    (this.Employee != null &&
                    this.Employee.Equals(input.Employee))
                ) && 
                (
                    this.Schedules == input.Schedules ||
                    this.Schedules != null &&
                    input.Schedules != null &&
                    this.Schedules.SequenceEqual(input.Schedules)
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
                if (this.Employee != null)
                {
                    hashCode = (hashCode * 59) + this.Employee.GetHashCode();
                }
                if (this.Schedules != null)
                {
                    hashCode = (hashCode * 59) + this.Schedules.GetHashCode();
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
