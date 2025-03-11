/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.12.2
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
    /// Benefit
    /// </summary>
    [DataContract(Name = "Benefit")]
    public partial class Benefit : IEquatable<Benefit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Benefit" /> class.
        /// </summary>
        /// <param name="name">The name of the benefit..</param>
        /// <param name="employeeDeduction">The amount deducted for benefit..</param>
        /// <param name="employerContribution">The amount of employer contribution..</param>
        public Benefit(string name = default(string), decimal? employeeDeduction = default(decimal?), decimal? employerContribution = default(decimal?))
        {
            this.Name = name;
            this.EmployeeDeduction = employeeDeduction;
            this.EmployerContribution = employerContribution;
        }

        /// <summary>
        /// The name of the benefit.
        /// </summary>
        /// <value>The name of the benefit.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The amount deducted for benefit.
        /// </summary>
        /// <value>The amount deducted for benefit.</value>
        [DataMember(Name = "employee_deduction", EmitDefaultValue = true)]
        public decimal? EmployeeDeduction { get; set; }

        /// <summary>
        /// The amount of employer contribution.
        /// </summary>
        /// <value>The amount of employer contribution.</value>
        [DataMember(Name = "employer_contribution", EmitDefaultValue = true)]
        public decimal? EmployerContribution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Benefit {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmployeeDeduction: ").Append(EmployeeDeduction).Append("\n");
            sb.Append("  EmployerContribution: ").Append(EmployerContribution).Append("\n");
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
            return this.Equals(input as Benefit);
        }

        /// <summary>
        /// Returns true if Benefit instances are equal
        /// </summary>
        /// <param name="input">Instance of Benefit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Benefit input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EmployeeDeduction == input.EmployeeDeduction ||
                    (this.EmployeeDeduction != null &&
                    this.EmployeeDeduction.Equals(input.EmployeeDeduction))
                ) && 
                (
                    this.EmployerContribution == input.EmployerContribution ||
                    (this.EmployerContribution != null &&
                    this.EmployerContribution.Equals(input.EmployerContribution))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.EmployeeDeduction != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeDeduction.GetHashCode();
                }
                if (this.EmployerContribution != null)
                {
                    hashCode = (hashCode * 59) + this.EmployerContribution.GetHashCode();
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
