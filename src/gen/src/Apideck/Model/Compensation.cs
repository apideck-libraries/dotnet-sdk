/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.2
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
    /// Compensation
    /// </summary>
    [DataContract(Name = "Compensation")]
    public partial class Compensation : IEquatable<Compensation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Compensation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Compensation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Compensation" /> class.
        /// </summary>
        /// <param name="netPay">The employee&#39;s net pay. Only available when payroll has been processed.</param>
        /// <param name="grossPay">The employee&#39;s gross pay. Only available when payroll has been processed.</param>
        /// <param name="taxes">An array of employer and employee taxes for the pay period..</param>
        /// <param name="deductions">An array of employee deductions for the pay period..</param>
        /// <param name="benefits">An array of employee benefits for the pay period..</param>
        public Compensation(decimal netPay = default(decimal), decimal grossPay = default(decimal), List<Tax> taxes = default(List<Tax>), List<Deduction> deductions = default(List<Deduction>), List<Benefit> benefits = default(List<Benefit>))
        {
            this.NetPay = netPay;
            this.GrossPay = grossPay;
            this.Taxes = taxes;
            this.Deductions = deductions;
            this.Benefits = benefits;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "employee_id", IsRequired = true, EmitDefaultValue = false)]
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
        /// The employee&#39;s net pay. Only available when payroll has been processed
        /// </summary>
        /// <value>The employee&#39;s net pay. Only available when payroll has been processed</value>
        [DataMember(Name = "net_pay", EmitDefaultValue = false)]
        public decimal NetPay { get; set; }

        /// <summary>
        /// The employee&#39;s gross pay. Only available when payroll has been processed
        /// </summary>
        /// <value>The employee&#39;s gross pay. Only available when payroll has been processed</value>
        [DataMember(Name = "gross_pay", EmitDefaultValue = false)]
        public decimal GrossPay { get; set; }

        /// <summary>
        /// An array of employer and employee taxes for the pay period.
        /// </summary>
        /// <value>An array of employer and employee taxes for the pay period.</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<Tax> Taxes { get; set; }

        /// <summary>
        /// An array of employee deductions for the pay period.
        /// </summary>
        /// <value>An array of employee deductions for the pay period.</value>
        [DataMember(Name = "deductions", EmitDefaultValue = false)]
        public List<Deduction> Deductions { get; set; }

        /// <summary>
        /// An array of employee benefits for the pay period.
        /// </summary>
        /// <value>An array of employee benefits for the pay period.</value>
        [DataMember(Name = "benefits", EmitDefaultValue = false)]
        public List<Benefit> Benefits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Compensation {\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  NetPay: ").Append(NetPay).Append("\n");
            sb.Append("  GrossPay: ").Append(GrossPay).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  Benefits: ").Append(Benefits).Append("\n");
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
            return this.Equals(input as Compensation);
        }

        /// <summary>
        /// Returns true if Compensation instances are equal
        /// </summary>
        /// <param name="input">Instance of Compensation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Compensation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.NetPay == input.NetPay ||
                    this.NetPay.Equals(input.NetPay)
                ) && 
                (
                    this.GrossPay == input.GrossPay ||
                    this.GrossPay.Equals(input.GrossPay)
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.Deductions == input.Deductions ||
                    this.Deductions != null &&
                    input.Deductions != null &&
                    this.Deductions.SequenceEqual(input.Deductions)
                ) && 
                (
                    this.Benefits == input.Benefits ||
                    this.Benefits != null &&
                    input.Benefits != null &&
                    this.Benefits.SequenceEqual(input.Benefits)
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
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NetPay.GetHashCode();
                hashCode = (hashCode * 59) + this.GrossPay.GetHashCode();
                if (this.Taxes != null)
                {
                    hashCode = (hashCode * 59) + this.Taxes.GetHashCode();
                }
                if (this.Deductions != null)
                {
                    hashCode = (hashCode * 59) + this.Deductions.GetHashCode();
                }
                if (this.Benefits != null)
                {
                    hashCode = (hashCode * 59) + this.Benefits.GetHashCode();
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
