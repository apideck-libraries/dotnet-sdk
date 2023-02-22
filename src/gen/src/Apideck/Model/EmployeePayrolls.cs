/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.91.1
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
    /// EmployeePayrolls
    /// </summary>
    [DataContract(Name = "EmployeePayrolls")]
    public partial class EmployeePayrolls : IEquatable<EmployeePayrolls>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeePayrolls" /> class.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <param name="payrolls">payrolls.</param>
        public EmployeePayrolls(Employee employee = default(Employee), List<Payroll> payrolls = default(List<Payroll>))
        {
            this.Employee = employee;
            this.Payrolls = payrolls;
        }

        /// <summary>
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name = "employee", EmitDefaultValue = false)]
        public Employee Employee { get; set; }

        /// <summary>
        /// Gets or Sets Payrolls
        /// </summary>
        [DataMember(Name = "payrolls", EmitDefaultValue = false)]
        public List<Payroll> Payrolls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeePayrolls {\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Payrolls: ").Append(Payrolls).Append("\n");
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
            return this.Equals(input as EmployeePayrolls);
        }

        /// <summary>
        /// Returns true if EmployeePayrolls instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeePayrolls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeePayrolls input)
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
                    this.Payrolls == input.Payrolls ||
                    this.Payrolls != null &&
                    input.Payrolls != null &&
                    this.Payrolls.SequenceEqual(input.Payrolls)
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
                if (this.Payrolls != null)
                {
                    hashCode = (hashCode * 59) + this.Payrolls.GetHashCode();
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
