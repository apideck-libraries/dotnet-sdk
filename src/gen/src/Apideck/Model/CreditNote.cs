/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.83.0
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
    /// CreditNote
    /// </summary>
    [DataContract(Name = "CreditNote")]
    public partial class CreditNote : IEquatable<CreditNote>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Status of payment
        /// </summary>
        /// <value>Status of payment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,

            /// <summary>
            /// Enum Authorised for value: authorised
            /// </summary>
            [EnumMember(Value = "authorised")]
            Authorised = 2,

            /// <summary>
            /// Enum Paid for value: paid
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid = 3,

            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 4,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 5

        }


        /// <summary>
        /// Status of payment
        /// </summary>
        /// <value>Status of payment</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Type of payment
        /// </summary>
        /// <value>Type of payment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ReceivableCredit for value: accounts_receivable_credit
            /// </summary>
            [EnumMember(Value = "accounts_receivable_credit")]
            ReceivableCredit = 1,

            /// <summary>
            /// Enum PayableCredit for value: accounts_payable_credit
            /// </summary>
            [EnumMember(Value = "accounts_payable_credit")]
            PayableCredit = 2

        }


        /// <summary>
        /// Type of payment
        /// </summary>
        /// <value>Type of payment</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditNote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNote" /> class.
        /// </summary>
        /// <param name="number">Credit note number..</param>
        /// <param name="customer">customer.</param>
        /// <param name="currency">currency.</param>
        /// <param name="currencyRate">Currency Exchange Rate at the time entity was recorded/generated..</param>
        /// <param name="taxInclusive">Amounts are including tax.</param>
        /// <param name="subTotal">Sub-total amount, normally before tax..</param>
        /// <param name="totalAmount">Amount of transaction (required).</param>
        /// <param name="totalTax">Total tax amount applied to this invoice..</param>
        /// <param name="taxCode">Applicable tax id/code override if tax is not supplied on a line item basis..</param>
        /// <param name="balance">The balance reflecting any payments made against the transaction..</param>
        /// <param name="remainingCredit">Indicates the total credit amount still available to apply towards the payment..</param>
        /// <param name="status">Status of payment.</param>
        /// <param name="reference">Optional reference message ie: Debit remittance detail..</param>
        /// <param name="dateIssued">Date credit note issued - YYYY:MM::DDThh:mm:ss.sTZD.</param>
        /// <param name="datePaid">Date credit note paid - YYYY:MM::DDThh:mm:ss.sTZD.</param>
        /// <param name="type">Type of payment.</param>
        /// <param name="account">account.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="allocations">allocations.</param>
        /// <param name="note">Optional note to be associated with the credit note..</param>
        /// <param name="rowVersion">rowVersion.</param>
        public CreditNote(string number = default(string), LinkedCustomer customer = default(LinkedCustomer), Currency? currency = default(Currency?), decimal? currencyRate = default(decimal?), bool? taxInclusive = default(bool?), decimal? subTotal = default(decimal?), decimal totalAmount = default(decimal), decimal? totalTax = default(decimal?), string taxCode = default(string), decimal? balance = default(decimal?), decimal? remainingCredit = default(decimal?), StatusEnum? status = default(StatusEnum?), string reference = default(string), DateTime dateIssued = default(DateTime), DateTime? datePaid = default(DateTime?), TypeEnum? type = default(TypeEnum?), LinkedLedgerAccount account = default(LinkedLedgerAccount), List<InvoiceLineItem> lineItems = default(List<InvoiceLineItem>), List<Object> allocations = default(List<Object>), string note = default(string), string rowVersion = default(string))
        {
            this.TotalAmount = totalAmount;
            this.Number = number;
            this.Customer = customer;
            this.Currency = currency;
            this.CurrencyRate = currencyRate;
            this.TaxInclusive = taxInclusive;
            this.SubTotal = subTotal;
            this.TotalTax = totalTax;
            this.TaxCode = taxCode;
            this.Balance = balance;
            this.RemainingCredit = remainingCredit;
            this.Status = status;
            this.Reference = reference;
            this.DateIssued = dateIssued;
            this.DatePaid = datePaid;
            this.Type = type;
            this.Account = account;
            this.LineItems = lineItems;
            this.Allocations = allocations;
            this.Note = note;
            this.RowVersion = rowVersion;
        }

        /// <summary>
        /// Unique identifier representing the entity
        /// </summary>
        /// <value>Unique identifier representing the entity</value>
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
        /// Credit note number.
        /// </summary>
        /// <value>Credit note number.</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = true)]
        public LinkedCustomer Customer { get; set; }

        /// <summary>
        /// Currency Exchange Rate at the time entity was recorded/generated.
        /// </summary>
        /// <value>Currency Exchange Rate at the time entity was recorded/generated.</value>
        [DataMember(Name = "currency_rate", EmitDefaultValue = true)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Amounts are including tax
        /// </summary>
        /// <value>Amounts are including tax</value>
        [DataMember(Name = "tax_inclusive", EmitDefaultValue = true)]
        public bool? TaxInclusive { get; set; }

        /// <summary>
        /// Sub-total amount, normally before tax.
        /// </summary>
        /// <value>Sub-total amount, normally before tax.</value>
        [DataMember(Name = "sub_total", EmitDefaultValue = true)]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// Amount of transaction
        /// </summary>
        /// <value>Amount of transaction</value>
        [DataMember(Name = "total_amount", IsRequired = true, EmitDefaultValue = false)]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Total tax amount applied to this invoice.
        /// </summary>
        /// <value>Total tax amount applied to this invoice.</value>
        [DataMember(Name = "total_tax", EmitDefaultValue = true)]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Applicable tax id/code override if tax is not supplied on a line item basis.
        /// </summary>
        /// <value>Applicable tax id/code override if tax is not supplied on a line item basis.</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = true)]
        public string TaxCode { get; set; }

        /// <summary>
        /// The balance reflecting any payments made against the transaction.
        /// </summary>
        /// <value>The balance reflecting any payments made against the transaction.</value>
        [DataMember(Name = "balance", EmitDefaultValue = true)]
        public decimal? Balance { get; set; }

        /// <summary>
        /// Indicates the total credit amount still available to apply towards the payment.
        /// </summary>
        /// <value>Indicates the total credit amount still available to apply towards the payment.</value>
        [DataMember(Name = "remaining_credit", EmitDefaultValue = true)]
        public decimal? RemainingCredit { get; set; }

        /// <summary>
        /// Optional reference message ie: Debit remittance detail.
        /// </summary>
        /// <value>Optional reference message ie: Debit remittance detail.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Date credit note issued - YYYY:MM::DDThh:mm:ss.sTZD
        /// </summary>
        /// <value>Date credit note issued - YYYY:MM::DDThh:mm:ss.sTZD</value>
        [DataMember(Name = "date_issued", EmitDefaultValue = false)]
        public DateTime DateIssued { get; set; }

        /// <summary>
        /// Date credit note paid - YYYY:MM::DDThh:mm:ss.sTZD
        /// </summary>
        /// <value>Date credit note paid - YYYY:MM::DDThh:mm:ss.sTZD</value>
        [DataMember(Name = "date_paid", EmitDefaultValue = true)]
        public DateTime? DatePaid { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public LinkedLedgerAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<InvoiceLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name = "allocations", EmitDefaultValue = false)]
        public List<Object> Allocations { get; set; }

        /// <summary>
        /// Optional note to be associated with the credit note.
        /// </summary>
        /// <value>Optional note to be associated with the credit note.</value>
        [DataMember(Name = "note", EmitDefaultValue = true)]
        public string Note { get; set; }

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
            sb.Append("class CreditNote {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  RemainingCredit: ").Append(RemainingCredit).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  DateIssued: ").Append(DateIssued).Append("\n");
            sb.Append("  DatePaid: ").Append(DatePaid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return this.Equals(input as CreditNote);
        }

        /// <summary>
        /// Returns true if CreditNote instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNote input)
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
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    (this.CurrencyRate != null &&
                    this.CurrencyRate.Equals(input.CurrencyRate))
                ) && 
                (
                    this.TaxInclusive == input.TaxInclusive ||
                    (this.TaxInclusive != null &&
                    this.TaxInclusive.Equals(input.TaxInclusive))
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    (this.SubTotal != null &&
                    this.SubTotal.Equals(input.SubTotal))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    this.TotalAmount.Equals(input.TotalAmount)
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    (this.TotalTax != null &&
                    this.TotalTax.Equals(input.TotalTax))
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    (this.TaxCode != null &&
                    this.TaxCode.Equals(input.TaxCode))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.RemainingCredit == input.RemainingCredit ||
                    (this.RemainingCredit != null &&
                    this.RemainingCredit.Equals(input.RemainingCredit))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.DateIssued == input.DateIssued ||
                    (this.DateIssued != null &&
                    this.DateIssued.Equals(input.DateIssued))
                ) && 
                (
                    this.DatePaid == input.DatePaid ||
                    (this.DatePaid != null &&
                    this.DatePaid.Equals(input.DatePaid))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    input.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.CurrencyRate != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyRate.GetHashCode();
                }
                if (this.TaxInclusive != null)
                {
                    hashCode = (hashCode * 59) + this.TaxInclusive.GetHashCode();
                }
                if (this.SubTotal != null)
                {
                    hashCode = (hashCode * 59) + this.SubTotal.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                if (this.TotalTax != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTax.GetHashCode();
                }
                if (this.TaxCode != null)
                {
                    hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                }
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.RemainingCredit != null)
                {
                    hashCode = (hashCode * 59) + this.RemainingCredit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.DateIssued != null)
                {
                    hashCode = (hashCode * 59) + this.DateIssued.GetHashCode();
                }
                if (this.DatePaid != null)
                {
                    hashCode = (hashCode * 59) + this.DatePaid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.Allocations != null)
                {
                    hashCode = (hashCode * 59) + this.Allocations.GetHashCode();
                }
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
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
            yield break;
        }
    }

}
