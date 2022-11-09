/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.81.0
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
    /// ProfitAndLoss
    /// </summary>
    [DataContract(Name = "ProfitAndLoss")]
    public partial class ProfitAndLoss : IEquatable<ProfitAndLoss>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfitAndLoss" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfitAndLoss() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfitAndLoss" /> class.
        /// </summary>
        /// <param name="reportName">The name of the report (required).</param>
        /// <param name="startDate">The start date of the report.</param>
        /// <param name="endDate">The start date of the report.</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="customerId">Customer id.</param>
        /// <param name="income">income (required).</param>
        /// <param name="expenses">expenses (required).</param>
        /// <param name="netIncome">netIncome.</param>
        /// <param name="netOperatingIncome">netOperatingIncome.</param>
        /// <param name="grossProfit">grossProfit.</param>
        public ProfitAndLoss(string reportName = default(string), string startDate = default(string), string endDate = default(string), string currency = default(string), string customerId = default(string), ProfitAndLossIncome income = default(ProfitAndLossIncome), ProfitAndLossExpenses expenses = default(ProfitAndLossExpenses), ProfitAndLossNetIncome netIncome = default(ProfitAndLossNetIncome), ProfitAndLossNetOperatingIncome netOperatingIncome = default(ProfitAndLossNetOperatingIncome), ProfitAndLossGrossProfit grossProfit = default(ProfitAndLossGrossProfit))
        {
            // to ensure "reportName" is required (not null)
            if (reportName == null) {
                throw new ArgumentNullException("reportName is a required property for ProfitAndLoss and cannot be null");
            }
            this.ReportName = reportName;
            // to ensure "currency" is required (not null)
            if (currency == null) {
                throw new ArgumentNullException("currency is a required property for ProfitAndLoss and cannot be null");
            }
            this.Currency = currency;
            // to ensure "income" is required (not null)
            if (income == null) {
                throw new ArgumentNullException("income is a required property for ProfitAndLoss and cannot be null");
            }
            this.Income = income;
            // to ensure "expenses" is required (not null)
            if (expenses == null) {
                throw new ArgumentNullException("expenses is a required property for ProfitAndLoss and cannot be null");
            }
            this.Expenses = expenses;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CustomerId = customerId;
            this.NetIncome = netIncome;
            this.NetOperatingIncome = netOperatingIncome;
            this.GrossProfit = grossProfit;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
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
        /// The name of the report
        /// </summary>
        /// <value>The name of the report</value>
        [DataMember(Name = "report_name", IsRequired = true, EmitDefaultValue = false)]
        public string ReportName { get; set; }

        /// <summary>
        /// The start date of the report
        /// </summary>
        /// <value>The start date of the report</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The start date of the report
        /// </summary>
        /// <value>The start date of the report</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Customer id
        /// </summary>
        /// <value>Customer id</value>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Income
        /// </summary>
        [DataMember(Name = "income", IsRequired = true, EmitDefaultValue = false)]
        public ProfitAndLossIncome Income { get; set; }

        /// <summary>
        /// Gets or Sets Expenses
        /// </summary>
        [DataMember(Name = "expenses", IsRequired = true, EmitDefaultValue = false)]
        public ProfitAndLossExpenses Expenses { get; set; }

        /// <summary>
        /// Gets or Sets NetIncome
        /// </summary>
        [DataMember(Name = "net_income", EmitDefaultValue = true)]
        public ProfitAndLossNetIncome NetIncome { get; set; }

        /// <summary>
        /// Gets or Sets NetOperatingIncome
        /// </summary>
        [DataMember(Name = "net_operating_income", EmitDefaultValue = true)]
        public ProfitAndLossNetOperatingIncome NetOperatingIncome { get; set; }

        /// <summary>
        /// Gets or Sets GrossProfit
        /// </summary>
        [DataMember(Name = "gross_profit", EmitDefaultValue = true)]
        public ProfitAndLossGrossProfit GrossProfit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProfitAndLoss {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Income: ").Append(Income).Append("\n");
            sb.Append("  Expenses: ").Append(Expenses).Append("\n");
            sb.Append("  NetIncome: ").Append(NetIncome).Append("\n");
            sb.Append("  NetOperatingIncome: ").Append(NetOperatingIncome).Append("\n");
            sb.Append("  GrossProfit: ").Append(GrossProfit).Append("\n");
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
            return this.Equals(input as ProfitAndLoss);
        }

        /// <summary>
        /// Returns true if ProfitAndLoss instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfitAndLoss to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfitAndLoss input)
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
                    this.ReportName == input.ReportName ||
                    (this.ReportName != null &&
                    this.ReportName.Equals(input.ReportName))
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
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.Income == input.Income ||
                    (this.Income != null &&
                    this.Income.Equals(input.Income))
                ) && 
                (
                    this.Expenses == input.Expenses ||
                    (this.Expenses != null &&
                    this.Expenses.Equals(input.Expenses))
                ) && 
                (
                    this.NetIncome == input.NetIncome ||
                    (this.NetIncome != null &&
                    this.NetIncome.Equals(input.NetIncome))
                ) && 
                (
                    this.NetOperatingIncome == input.NetOperatingIncome ||
                    (this.NetOperatingIncome != null &&
                    this.NetOperatingIncome.Equals(input.NetOperatingIncome))
                ) && 
                (
                    this.GrossProfit == input.GrossProfit ||
                    (this.GrossProfit != null &&
                    this.GrossProfit.Equals(input.GrossProfit))
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
                if (this.ReportName != null)
                {
                    hashCode = (hashCode * 59) + this.ReportName.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.Income != null)
                {
                    hashCode = (hashCode * 59) + this.Income.GetHashCode();
                }
                if (this.Expenses != null)
                {
                    hashCode = (hashCode * 59) + this.Expenses.GetHashCode();
                }
                if (this.NetIncome != null)
                {
                    hashCode = (hashCode * 59) + this.NetIncome.GetHashCode();
                }
                if (this.NetOperatingIncome != null)
                {
                    hashCode = (hashCode * 59) + this.NetOperatingIncome.GetHashCode();
                }
                if (this.GrossProfit != null)
                {
                    hashCode = (hashCode * 59) + this.GrossProfit.GetHashCode();
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

            yield break;
        }
    }

}
