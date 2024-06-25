/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.6.2
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
    /// PayrollTotals
    /// </summary>
    [DataContract(Name = "PayrollTotals")]
    public partial class PayrollTotals : IEquatable<PayrollTotals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollTotals" /> class.
        /// </summary>
        /// <param name="companyDebit">The total company debit for the payroll..</param>
        /// <param name="taxDebit">The total tax debit for the payroll..</param>
        /// <param name="checkAmount">The total check amount for the payroll..</param>
        /// <param name="netPay">The net pay amount for the payroll..</param>
        /// <param name="grossPay">The gross pay amount for the payroll..</param>
        /// <param name="employerTaxes">The total amount of employer paid taxes for the payroll..</param>
        /// <param name="employeeTaxes">The total amount of employee paid taxes for the payroll..</param>
        /// <param name="employerBenefitContributions">The total amount of company contributed benefits for the payroll..</param>
        /// <param name="employeeBenefitDeductions">The total amount of employee deducted benefits for the payroll..</param>
        public PayrollTotals(decimal? companyDebit = default(decimal?), decimal? taxDebit = default(decimal?), decimal? checkAmount = default(decimal?), decimal? netPay = default(decimal?), decimal? grossPay = default(decimal?), decimal? employerTaxes = default(decimal?), decimal? employeeTaxes = default(decimal?), decimal? employerBenefitContributions = default(decimal?), decimal? employeeBenefitDeductions = default(decimal?))
        {
            this.CompanyDebit = companyDebit;
            this.TaxDebit = taxDebit;
            this.CheckAmount = checkAmount;
            this.NetPay = netPay;
            this.GrossPay = grossPay;
            this.EmployerTaxes = employerTaxes;
            this.EmployeeTaxes = employeeTaxes;
            this.EmployerBenefitContributions = employerBenefitContributions;
            this.EmployeeBenefitDeductions = employeeBenefitDeductions;
        }

        /// <summary>
        /// The total company debit for the payroll.
        /// </summary>
        /// <value>The total company debit for the payroll.</value>
        [DataMember(Name = "company_debit", EmitDefaultValue = true)]
        public decimal? CompanyDebit { get; set; }

        /// <summary>
        /// The total tax debit for the payroll.
        /// </summary>
        /// <value>The total tax debit for the payroll.</value>
        [DataMember(Name = "tax_debit", EmitDefaultValue = true)]
        public decimal? TaxDebit { get; set; }

        /// <summary>
        /// The total check amount for the payroll.
        /// </summary>
        /// <value>The total check amount for the payroll.</value>
        [DataMember(Name = "check_amount", EmitDefaultValue = true)]
        public decimal? CheckAmount { get; set; }

        /// <summary>
        /// The net pay amount for the payroll.
        /// </summary>
        /// <value>The net pay amount for the payroll.</value>
        [DataMember(Name = "net_pay", EmitDefaultValue = true)]
        public decimal? NetPay { get; set; }

        /// <summary>
        /// The gross pay amount for the payroll.
        /// </summary>
        /// <value>The gross pay amount for the payroll.</value>
        [DataMember(Name = "gross_pay", EmitDefaultValue = true)]
        public decimal? GrossPay { get; set; }

        /// <summary>
        /// The total amount of employer paid taxes for the payroll.
        /// </summary>
        /// <value>The total amount of employer paid taxes for the payroll.</value>
        [DataMember(Name = "employer_taxes", EmitDefaultValue = true)]
        public decimal? EmployerTaxes { get; set; }

        /// <summary>
        /// The total amount of employee paid taxes for the payroll.
        /// </summary>
        /// <value>The total amount of employee paid taxes for the payroll.</value>
        [DataMember(Name = "employee_taxes", EmitDefaultValue = true)]
        public decimal? EmployeeTaxes { get; set; }

        /// <summary>
        /// The total amount of company contributed benefits for the payroll.
        /// </summary>
        /// <value>The total amount of company contributed benefits for the payroll.</value>
        [DataMember(Name = "employer_benefit_contributions", EmitDefaultValue = true)]
        public decimal? EmployerBenefitContributions { get; set; }

        /// <summary>
        /// The total amount of employee deducted benefits for the payroll.
        /// </summary>
        /// <value>The total amount of employee deducted benefits for the payroll.</value>
        [DataMember(Name = "employee_benefit_deductions", EmitDefaultValue = true)]
        public decimal? EmployeeBenefitDeductions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayrollTotals {\n");
            sb.Append("  CompanyDebit: ").Append(CompanyDebit).Append("\n");
            sb.Append("  TaxDebit: ").Append(TaxDebit).Append("\n");
            sb.Append("  CheckAmount: ").Append(CheckAmount).Append("\n");
            sb.Append("  NetPay: ").Append(NetPay).Append("\n");
            sb.Append("  GrossPay: ").Append(GrossPay).Append("\n");
            sb.Append("  EmployerTaxes: ").Append(EmployerTaxes).Append("\n");
            sb.Append("  EmployeeTaxes: ").Append(EmployeeTaxes).Append("\n");
            sb.Append("  EmployerBenefitContributions: ").Append(EmployerBenefitContributions).Append("\n");
            sb.Append("  EmployeeBenefitDeductions: ").Append(EmployeeBenefitDeductions).Append("\n");
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
            return this.Equals(input as PayrollTotals);
        }

        /// <summary>
        /// Returns true if PayrollTotals instances are equal
        /// </summary>
        /// <param name="input">Instance of PayrollTotals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayrollTotals input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyDebit == input.CompanyDebit ||
                    (this.CompanyDebit != null &&
                    this.CompanyDebit.Equals(input.CompanyDebit))
                ) && 
                (
                    this.TaxDebit == input.TaxDebit ||
                    (this.TaxDebit != null &&
                    this.TaxDebit.Equals(input.TaxDebit))
                ) && 
                (
                    this.CheckAmount == input.CheckAmount ||
                    (this.CheckAmount != null &&
                    this.CheckAmount.Equals(input.CheckAmount))
                ) && 
                (
                    this.NetPay == input.NetPay ||
                    (this.NetPay != null &&
                    this.NetPay.Equals(input.NetPay))
                ) && 
                (
                    this.GrossPay == input.GrossPay ||
                    (this.GrossPay != null &&
                    this.GrossPay.Equals(input.GrossPay))
                ) && 
                (
                    this.EmployerTaxes == input.EmployerTaxes ||
                    (this.EmployerTaxes != null &&
                    this.EmployerTaxes.Equals(input.EmployerTaxes))
                ) && 
                (
                    this.EmployeeTaxes == input.EmployeeTaxes ||
                    (this.EmployeeTaxes != null &&
                    this.EmployeeTaxes.Equals(input.EmployeeTaxes))
                ) && 
                (
                    this.EmployerBenefitContributions == input.EmployerBenefitContributions ||
                    (this.EmployerBenefitContributions != null &&
                    this.EmployerBenefitContributions.Equals(input.EmployerBenefitContributions))
                ) && 
                (
                    this.EmployeeBenefitDeductions == input.EmployeeBenefitDeductions ||
                    (this.EmployeeBenefitDeductions != null &&
                    this.EmployeeBenefitDeductions.Equals(input.EmployeeBenefitDeductions))
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
                if (this.CompanyDebit != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyDebit.GetHashCode();
                }
                if (this.TaxDebit != null)
                {
                    hashCode = (hashCode * 59) + this.TaxDebit.GetHashCode();
                }
                if (this.CheckAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CheckAmount.GetHashCode();
                }
                if (this.NetPay != null)
                {
                    hashCode = (hashCode * 59) + this.NetPay.GetHashCode();
                }
                if (this.GrossPay != null)
                {
                    hashCode = (hashCode * 59) + this.GrossPay.GetHashCode();
                }
                if (this.EmployerTaxes != null)
                {
                    hashCode = (hashCode * 59) + this.EmployerTaxes.GetHashCode();
                }
                if (this.EmployeeTaxes != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeTaxes.GetHashCode();
                }
                if (this.EmployerBenefitContributions != null)
                {
                    hashCode = (hashCode * 59) + this.EmployerBenefitContributions.GetHashCode();
                }
                if (this.EmployeeBenefitDeductions != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeBenefitDeductions.GetHashCode();
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
