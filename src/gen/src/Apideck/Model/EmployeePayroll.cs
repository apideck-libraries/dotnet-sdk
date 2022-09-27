/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.62.0
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
        /// <param name="employee">employee.</param>
        /// <param name="payroll">payroll.</param>
        public EmployeePayroll(Employee employee = default(Employee), Payroll payroll = default(Payroll))
        {
            this.Employee = employee;
            this.Payroll = payroll;
        }

        /// <summary>
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name = "employee", EmitDefaultValue = false)]
        public Employee Employee { get; set; }

        /// <summary>
        /// Gets or Sets Payroll
        /// </summary>
        [DataMember(Name = "payroll", EmitDefaultValue = false)]
        public Payroll Payroll { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeePayroll {\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Payroll: ").Append(Payroll).Append("\n");
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
                    this.Employee == input.Employee ||
                    (this.Employee != null &&
                    this.Employee.Equals(input.Employee))
                ) && 
                (
                    this.Payroll == input.Payroll ||
                    (this.Payroll != null &&
                    this.Payroll.Equals(input.Payroll))
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
                if (this.Payroll != null)
                {
                    hashCode = (hashCode * 59) + this.Payroll.GetHashCode();
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
