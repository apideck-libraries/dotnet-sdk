/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.7
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
    /// JournalEntry
    /// </summary>
    [DataContract(Name = "JournalEntry")]
    public partial class JournalEntry : IEquatable<JournalEntry>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntry" /> class.
        /// </summary>
        /// <param name="title">Journal entry title.</param>
        /// <param name="currencyRate">Currency Exchange Rate at the time entity was recorded/generated..</param>
        /// <param name="currency">currency.</param>
        /// <param name="companyId">The company or subsidiary id the transaction belongs to.</param>
        /// <param name="lineItems">Requires a minimum of 2 line items that sum to 0.</param>
        /// <param name="memo">Reference for the journal entry..</param>
        /// <param name="postedAt">This is the date on which the journal entry was added. This can be different from the creation date and can also be backdated..</param>
        /// <param name="journalSymbol">Journal symbol of the entry. For example IND for indirect costs.</param>
        /// <param name="taxType">The specific category of tax associated with a transaction like sales or purchase.</param>
        /// <param name="taxCode">Applicable tax id/code override if tax is not supplied on a line item basis..</param>
        /// <param name="number">Journal entry number..</param>
        /// <param name="trackingCategories">A list of linked tracking categories..</param>
        /// <param name="accountingPeriod">Accounting period.</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public JournalEntry(string title = default(string), decimal? currencyRate = default(decimal?), Currency? currency = default(Currency?), string companyId = default(string), List<JournalEntryLineItem> lineItems = default(List<JournalEntryLineItem>), string memo = default(string), DateTime postedAt = default(DateTime), string journalSymbol = default(string), string taxType = default(string), string taxCode = default(string), string number = default(string), List<LinkedTrackingCategory> trackingCategories = default(List<LinkedTrackingCategory>), string accountingPeriod = default(string), string rowVersion = default(string), List<Object> passThrough = default(List<Object>))
        {
            this.Title = title;
            this.CurrencyRate = currencyRate;
            this.Currency = currency;
            this.CompanyId = companyId;
            this.LineItems = lineItems;
            this.Memo = memo;
            this.PostedAt = postedAt;
            this.JournalSymbol = journalSymbol;
            this.TaxType = taxType;
            this.TaxCode = taxCode;
            this.Number = number;
            this.TrackingCategories = trackingCategories;
            this.AccountingPeriod = accountingPeriod;
            this.RowVersion = rowVersion;
            this.PassThrough = passThrough;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
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
        /// Journal entry title
        /// </summary>
        /// <value>Journal entry title</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Currency Exchange Rate at the time entity was recorded/generated.
        /// </summary>
        /// <value>Currency Exchange Rate at the time entity was recorded/generated.</value>
        [DataMember(Name = "currency_rate", EmitDefaultValue = true)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// The company or subsidiary id the transaction belongs to
        /// </summary>
        /// <value>The company or subsidiary id the transaction belongs to</value>
        [DataMember(Name = "company_id", EmitDefaultValue = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Requires a minimum of 2 line items that sum to 0
        /// </summary>
        /// <value>Requires a minimum of 2 line items that sum to 0</value>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<JournalEntryLineItem> LineItems { get; set; }

        /// <summary>
        /// Reference for the journal entry.
        /// </summary>
        /// <value>Reference for the journal entry.</value>
        [DataMember(Name = "memo", EmitDefaultValue = true)]
        public string Memo { get; set; }

        /// <summary>
        /// This is the date on which the journal entry was added. This can be different from the creation date and can also be backdated.
        /// </summary>
        /// <value>This is the date on which the journal entry was added. This can be different from the creation date and can also be backdated.</value>
        [DataMember(Name = "posted_at", EmitDefaultValue = false)]
        public DateTime PostedAt { get; set; }

        /// <summary>
        /// Journal symbol of the entry. For example IND for indirect costs
        /// </summary>
        /// <value>Journal symbol of the entry. For example IND for indirect costs</value>
        [DataMember(Name = "journal_symbol", EmitDefaultValue = true)]
        public string JournalSymbol { get; set; }

        /// <summary>
        /// The specific category of tax associated with a transaction like sales or purchase
        /// </summary>
        /// <value>The specific category of tax associated with a transaction like sales or purchase</value>
        [DataMember(Name = "tax_type", EmitDefaultValue = true)]
        public string TaxType { get; set; }

        /// <summary>
        /// Applicable tax id/code override if tax is not supplied on a line item basis.
        /// </summary>
        /// <value>Applicable tax id/code override if tax is not supplied on a line item basis.</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = true)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Journal entry number.
        /// </summary>
        /// <value>Journal entry number.</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        /// <value>A list of linked tracking categories.</value>
        [DataMember(Name = "tracking_categories", EmitDefaultValue = true)]
        public List<LinkedTrackingCategory> TrackingCategories { get; set; }

        /// <summary>
        /// Accounting period
        /// </summary>
        /// <value>Accounting period</value>
        [DataMember(Name = "accounting_period", EmitDefaultValue = true)]
        public string AccountingPeriod { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; private set; }

        /// <summary>
        /// Returns false as CustomMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomMappings()
        {
            return false;
        }
        /// <summary>
        /// The user who last updated the object.
        /// </summary>
        /// <value>The user who last updated the object.</value>
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
        /// The user who created the object.
        /// </summary>
        /// <value>The user who created the object.</value>
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
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        /// <value>A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.</value>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        /// <value>The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.</value>
        [DataMember(Name = "pass_through", EmitDefaultValue = false)]
        public List<Object> PassThrough { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JournalEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  PostedAt: ").Append(PostedAt).Append("\n");
            sb.Append("  JournalSymbol: ").Append(JournalSymbol).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  AccountingPeriod: ").Append(AccountingPeriod).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
            sb.Append("  PassThrough: ").Append(PassThrough).Append("\n");
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
            return this.Equals(input as JournalEntry);
        }

        /// <summary>
        /// Returns true if JournalEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalEntry input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    (this.CurrencyRate != null &&
                    this.CurrencyRate.Equals(input.CurrencyRate))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.PostedAt == input.PostedAt ||
                    (this.PostedAt != null &&
                    this.PostedAt.Equals(input.PostedAt))
                ) && 
                (
                    this.JournalSymbol == input.JournalSymbol ||
                    (this.JournalSymbol != null &&
                    this.JournalSymbol.Equals(input.JournalSymbol))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    (this.TaxCode != null &&
                    this.TaxCode.Equals(input.TaxCode))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.TrackingCategories == input.TrackingCategories ||
                    this.TrackingCategories != null &&
                    input.TrackingCategories != null &&
                    this.TrackingCategories.SequenceEqual(input.TrackingCategories)
                ) && 
                (
                    this.AccountingPeriod == input.AccountingPeriod ||
                    (this.AccountingPeriod != null &&
                    this.AccountingPeriod.Equals(input.AccountingPeriod))
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
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
                ) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
                ) && 
                (
                    this.PassThrough == input.PassThrough ||
                    this.PassThrough != null &&
                    input.PassThrough != null &&
                    this.PassThrough.SequenceEqual(input.PassThrough)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.CurrencyRate != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyRate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.PostedAt != null)
                {
                    hashCode = (hashCode * 59) + this.PostedAt.GetHashCode();
                }
                if (this.JournalSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.JournalSymbol.GetHashCode();
                }
                if (this.TaxType != null)
                {
                    hashCode = (hashCode * 59) + this.TaxType.GetHashCode();
                }
                if (this.TaxCode != null)
                {
                    hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.TrackingCategories != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingCategories.GetHashCode();
                }
                if (this.AccountingPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.AccountingPeriod.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
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
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
                }
                if (this.PassThrough != null)
                {
                    hashCode = (hashCode * 59) + this.PassThrough.GetHashCode();
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
