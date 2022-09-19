/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.58.0
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
    /// TaxRate
    /// </summary>
    [DataContract(Name = "TaxRate")]
    public partial class TaxRate : IEquatable<TaxRate>, IValidatableObject
    {
        /// <summary>
        /// Tax rate status
        /// </summary>
        /// <value>Tax rate status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
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
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 3

        }


        /// <summary>
        /// Tax rate status
        /// </summary>
        /// <value>Tax rate status</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRate" /> class.
        /// </summary>
        /// <param name="id">ID assigned to identify this tax rate..</param>
        /// <param name="name">Name assigned to identify this tax rate..</param>
        /// <param name="code">Tax code assigned to identify this tax rate..</param>
        /// <param name="description">Description of tax rate.</param>
        /// <param name="effectiveTaxRate">Effective tax rate.</param>
        /// <param name="totalTaxRate">Not compounded sum of the components of a tax rate.</param>
        /// <param name="taxPayableAccountId">Unique identifier for the account for tax collected..</param>
        /// <param name="taxRemittedAccountId">Unique identifier for the account for tax remitted..</param>
        /// <param name="components">components.</param>
        /// <param name="type">Tax type used to indicate the source of tax collected or paid.</param>
        /// <param name="reportTaxType">Report Tax type to aggregate tax collected or paid for reporting purposes.</param>
        /// <param name="originalTaxRateId">ID of the original tax rate from which the new tax rate is derived. Helps to understand the relationship between corresponding tax rate entities..</param>
        /// <param name="status">Tax rate status.</param>
        /// <param name="rowVersion">rowVersion.</param>
        public TaxRate(string id = default(string), string name = default(string), string code = default(string), string description = default(string), decimal? effectiveTaxRate = default(decimal?), decimal? totalTaxRate = default(decimal?), string taxPayableAccountId = default(string), string taxRemittedAccountId = default(string), List<Object> components = default(List<Object>), string type = default(string), string reportTaxType = default(string), string originalTaxRateId = default(string), StatusEnum? status = default(StatusEnum?), string rowVersion = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
            this.Description = description;
            this.EffectiveTaxRate = effectiveTaxRate;
            this.TotalTaxRate = totalTaxRate;
            this.TaxPayableAccountId = taxPayableAccountId;
            this.TaxRemittedAccountId = taxRemittedAccountId;
            this.Components = components;
            this.Type = type;
            this.ReportTaxType = reportTaxType;
            this.OriginalTaxRateId = originalTaxRateId;
            this.Status = status;
            this.RowVersion = rowVersion;
        }

        /// <summary>
        /// ID assigned to identify this tax rate.
        /// </summary>
        /// <value>ID assigned to identify this tax rate.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Name assigned to identify this tax rate.
        /// </summary>
        /// <value>Name assigned to identify this tax rate.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Tax code assigned to identify this tax rate.
        /// </summary>
        /// <value>Tax code assigned to identify this tax rate.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Description of tax rate
        /// </summary>
        /// <value>Description of tax rate</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Effective tax rate
        /// </summary>
        /// <value>Effective tax rate</value>
        [DataMember(Name = "effective_tax_rate", EmitDefaultValue = true)]
        public decimal? EffectiveTaxRate { get; set; }

        /// <summary>
        /// Not compounded sum of the components of a tax rate
        /// </summary>
        /// <value>Not compounded sum of the components of a tax rate</value>
        [DataMember(Name = "total_tax_rate", EmitDefaultValue = true)]
        public decimal? TotalTaxRate { get; set; }

        /// <summary>
        /// Unique identifier for the account for tax collected.
        /// </summary>
        /// <value>Unique identifier for the account for tax collected.</value>
        [DataMember(Name = "tax_payable_account_id", EmitDefaultValue = true)]
        public string TaxPayableAccountId { get; set; }

        /// <summary>
        /// Unique identifier for the account for tax remitted.
        /// </summary>
        /// <value>Unique identifier for the account for tax remitted.</value>
        [DataMember(Name = "tax_remitted_account_id", EmitDefaultValue = true)]
        public string TaxRemittedAccountId { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = true)]
        public List<Object> Components { get; set; }

        /// <summary>
        /// Tax type used to indicate the source of tax collected or paid
        /// </summary>
        /// <value>Tax type used to indicate the source of tax collected or paid</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Report Tax type to aggregate tax collected or paid for reporting purposes
        /// </summary>
        /// <value>Report Tax type to aggregate tax collected or paid for reporting purposes</value>
        [DataMember(Name = "report_tax_type", EmitDefaultValue = true)]
        public string ReportTaxType { get; set; }

        /// <summary>
        /// ID of the original tax rate from which the new tax rate is derived. Helps to understand the relationship between corresponding tax rate entities.
        /// </summary>
        /// <value>ID of the original tax rate from which the new tax rate is derived. Helps to understand the relationship between corresponding tax rate entities.</value>
        [DataMember(Name = "original_tax_rate_id", EmitDefaultValue = true)]
        public string OriginalTaxRateId { get; set; }

        /// <summary>
        /// Gets or Sets RowVersion
        /// </summary>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

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
            sb.Append("class TaxRate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EffectiveTaxRate: ").Append(EffectiveTaxRate).Append("\n");
            sb.Append("  TotalTaxRate: ").Append(TotalTaxRate).Append("\n");
            sb.Append("  TaxPayableAccountId: ").Append(TaxPayableAccountId).Append("\n");
            sb.Append("  TaxRemittedAccountId: ").Append(TaxRemittedAccountId).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReportTaxType: ").Append(ReportTaxType).Append("\n");
            sb.Append("  OriginalTaxRateId: ").Append(OriginalTaxRateId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
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
            return this.Equals(input as TaxRate);
        }

        /// <summary>
        /// Returns true if TaxRate instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRate input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EffectiveTaxRate == input.EffectiveTaxRate ||
                    (this.EffectiveTaxRate != null &&
                    this.EffectiveTaxRate.Equals(input.EffectiveTaxRate))
                ) && 
                (
                    this.TotalTaxRate == input.TotalTaxRate ||
                    (this.TotalTaxRate != null &&
                    this.TotalTaxRate.Equals(input.TotalTaxRate))
                ) && 
                (
                    this.TaxPayableAccountId == input.TaxPayableAccountId ||
                    (this.TaxPayableAccountId != null &&
                    this.TaxPayableAccountId.Equals(input.TaxPayableAccountId))
                ) && 
                (
                    this.TaxRemittedAccountId == input.TaxRemittedAccountId ||
                    (this.TaxRemittedAccountId != null &&
                    this.TaxRemittedAccountId.Equals(input.TaxRemittedAccountId))
                ) && 
                (
                    this.Components == input.Components ||
                    this.Components != null &&
                    input.Components != null &&
                    this.Components.SequenceEqual(input.Components)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ReportTaxType == input.ReportTaxType ||
                    (this.ReportTaxType != null &&
                    this.ReportTaxType.Equals(input.ReportTaxType))
                ) && 
                (
                    this.OriginalTaxRateId == input.OriginalTaxRateId ||
                    (this.OriginalTaxRateId != null &&
                    this.OriginalTaxRateId.Equals(input.OriginalTaxRateId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EffectiveTaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveTaxRate.GetHashCode();
                }
                if (this.TotalTaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTaxRate.GetHashCode();
                }
                if (this.TaxPayableAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxPayableAccountId.GetHashCode();
                }
                if (this.TaxRemittedAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRemittedAccountId.GetHashCode();
                }
                if (this.Components != null)
                {
                    hashCode = (hashCode * 59) + this.Components.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.ReportTaxType != null)
                {
                    hashCode = (hashCode * 59) + this.ReportTaxType.GetHashCode();
                }
                if (this.OriginalTaxRateId != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalTaxRateId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
