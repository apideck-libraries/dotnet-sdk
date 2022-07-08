/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.34.0
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
    /// BalanceSheet
    /// </summary>
    [DataContract(Name = "BalanceSheet")]
    public partial class BalanceSheet : IEquatable<BalanceSheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceSheet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheet" /> class.
        /// </summary>
        /// <param name="reportName">The name of the report (required).</param>
        /// <param name="startDate">The start date of the report (required).</param>
        /// <param name="assets">assets (required).</param>
        /// <param name="liabilities">liabilities (required).</param>
        /// <param name="equity">equity (required).</param>
        public BalanceSheet(string reportName = default(string), string startDate = default(string), BalanceSheetAssets assets = default(BalanceSheetAssets), BalanceSheetLiabilities liabilities = default(BalanceSheetLiabilities), BalanceSheetEquity equity = default(BalanceSheetEquity))
        {
            // to ensure "reportName" is required (not null)
            if (reportName == null) {
                throw new ArgumentNullException("reportName is a required property for BalanceSheet and cannot be null");
            }
            this.ReportName = reportName;
            // to ensure "startDate" is required (not null)
            if (startDate == null) {
                throw new ArgumentNullException("startDate is a required property for BalanceSheet and cannot be null");
            }
            this.StartDate = startDate;
            // to ensure "assets" is required (not null)
            if (assets == null) {
                throw new ArgumentNullException("assets is a required property for BalanceSheet and cannot be null");
            }
            this.Assets = assets;
            // to ensure "liabilities" is required (not null)
            if (liabilities == null) {
                throw new ArgumentNullException("liabilities is a required property for BalanceSheet and cannot be null");
            }
            this.Liabilities = liabilities;
            // to ensure "equity" is required (not null)
            if (equity == null) {
                throw new ArgumentNullException("equity is a required property for BalanceSheet and cannot be null");
            }
            this.Equity = equity;
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
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = false)]
        public BalanceSheetAssets Assets { get; set; }

        /// <summary>
        /// Gets or Sets Liabilities
        /// </summary>
        [DataMember(Name = "liabilities", IsRequired = true, EmitDefaultValue = false)]
        public BalanceSheetLiabilities Liabilities { get; set; }

        /// <summary>
        /// Gets or Sets Equity
        /// </summary>
        [DataMember(Name = "equity", IsRequired = true, EmitDefaultValue = false)]
        public BalanceSheetEquity Equity { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updated_by", EmitDefaultValue = true)]
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// Returns false as UpdatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = true)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceSheet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Liabilities: ").Append(Liabilities).Append("\n");
            sb.Append("  Equity: ").Append(Equity).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as BalanceSheet);
        }

        /// <summary>
        /// Returns true if BalanceSheet instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceSheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceSheet input)
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
                    this.Assets == input.Assets ||
                    (this.Assets != null &&
                    this.Assets.Equals(input.Assets))
                ) && 
                (
                    this.Liabilities == input.Liabilities ||
                    (this.Liabilities != null &&
                    this.Liabilities.Equals(input.Liabilities))
                ) && 
                (
                    this.Equity == input.Equity ||
                    (this.Equity != null &&
                    this.Equity.Equals(input.Equity))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Assets != null)
                {
                    hashCode = (hashCode * 59) + this.Assets.GetHashCode();
                }
                if (this.Liabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Liabilities.GetHashCode();
                }
                if (this.Equity != null)
                {
                    hashCode = (hashCode * 59) + this.Equity.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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

            yield break;
        }
    }

}
