/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.0.0
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
    /// Bill
    /// </summary>
    [DataContract(Name = "Bill")]
    public partial class Bill : IEquatable<Bill>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Invoice status
        /// </summary>
        /// <value>Invoice status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,

            /// <summary>
            /// Enum Submitted for value: submitted
            /// </summary>
            [EnumMember(Value = "submitted")]
            Submitted = 2,

            /// <summary>
            /// Enum Authorised for value: authorised
            /// </summary>
            [EnumMember(Value = "authorised")]
            Authorised = 3,

            /// <summary>
            /// Enum PartiallyPaid for value: partially_paid
            /// </summary>
            [EnumMember(Value = "partially_paid")]
            PartiallyPaid = 4,

            /// <summary>
            /// Enum Paid for value: paid
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid = 5,

            /// <summary>
            /// Enum Void for value: void
            /// </summary>
            [EnumMember(Value = "void")]
            Void = 6,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 7,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 8

        }


        /// <summary>
        /// Invoice status
        /// </summary>
        /// <value>Invoice status</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bill" /> class.
        /// </summary>
        /// <param name="billNumber">Reference to supplier bill number.</param>
        /// <param name="supplier">supplier.</param>
        /// <param name="currency">currency.</param>
        /// <param name="currencyRate">Currency Exchange Rate at the time entity was recorded/generated..</param>
        /// <param name="taxInclusive">Amounts are including tax.</param>
        /// <param name="billDate">Date bill was issued - YYYY-MM-DD..</param>
        /// <param name="dueDate">The due date is the date on which a payment is scheduled to be received - YYYY-MM-DD..</param>
        /// <param name="paidDate">The paid date is the date on which a payment was sent to the supplier - YYYY-MM-DD..</param>
        /// <param name="poNumber">A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order..</param>
        /// <param name="reference">Optional bill reference..</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="terms">Terms of payment..</param>
        /// <param name="balance">Balance of bill due..</param>
        /// <param name="deposit">Amount of deposit made to this bill..</param>
        /// <param name="subTotal">Sub-total amount, normally before tax..</param>
        /// <param name="totalTax">Total tax amount applied to this bill..</param>
        /// <param name="total">Total amount of bill, including tax..</param>
        /// <param name="taxCode">Applicable tax id/code override if tax is not supplied on a line item basis..</param>
        /// <param name="notes">notes.</param>
        /// <param name="status">Invoice status.</param>
        /// <param name="ledgerAccount">ledgerAccount.</param>
        /// <param name="paymentMethod">Payment method used for the transaction, such as cash, credit card, bank transfer, or check.</param>
        /// <param name="channel">The channel through which the transaction is processed..</param>
        /// <param name="language">language code according to ISO 639-1. For the United States - EN.</param>
        /// <param name="accountingByRow">Indicates if accounting by row is used (true) or not (false). Accounting by row means that a separate ledger transaction is created for each row..</param>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="discountPercentage">Discount percentage applied to this transaction..</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        /// <param name="customMappings">When custom mappings are configured on the resource, the result is included here..</param>
        public Bill(string billNumber = default(string), LinkedSupplier supplier = default(LinkedSupplier), Currency? currency = default(Currency?), decimal? currencyRate = default(decimal?), bool? taxInclusive = default(bool?), DateTime billDate = default(DateTime), DateTime dueDate = default(DateTime), DateTime? paidDate = default(DateTime?), string poNumber = default(string), string reference = default(string), List<BillLineItem> lineItems = default(List<BillLineItem>), string terms = default(string), decimal? balance = default(decimal?), decimal? deposit = default(decimal?), decimal? subTotal = default(decimal?), decimal? totalTax = default(decimal?), decimal? total = default(decimal?), string taxCode = default(string), string notes = default(string), StatusEnum? status = default(StatusEnum?), LinkedLedgerAccount ledgerAccount = default(LinkedLedgerAccount), string paymentMethod = default(string), string channel = default(string), string language = default(string), bool? accountingByRow = default(bool?), BankAccount bankAccount = default(BankAccount), decimal? discountPercentage = default(decimal?), string rowVersion = default(string), Object customMappings = default(Object))
        {
            this.BillNumber = billNumber;
            this.Supplier = supplier;
            this.Currency = currency;
            this.CurrencyRate = currencyRate;
            this.TaxInclusive = taxInclusive;
            this.BillDate = billDate;
            this.DueDate = dueDate;
            this.PaidDate = paidDate;
            this.PoNumber = poNumber;
            this.Reference = reference;
            this.LineItems = lineItems;
            this.Terms = terms;
            this.Balance = balance;
            this.Deposit = deposit;
            this.SubTotal = subTotal;
            this.TotalTax = totalTax;
            this.Total = total;
            this.TaxCode = taxCode;
            this.Notes = notes;
            this.Status = status;
            this.LedgerAccount = ledgerAccount;
            this.PaymentMethod = paymentMethod;
            this.Channel = channel;
            this.Language = language;
            this.AccountingByRow = accountingByRow;
            this.BankAccount = bankAccount;
            this.DiscountPercentage = discountPercentage;
            this.RowVersion = rowVersion;
            this.CustomMappings = customMappings;
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
        /// The third-party API ID of original entity
        /// </summary>
        /// <value>The third-party API ID of original entity</value>
        [DataMember(Name = "downstream_id", EmitDefaultValue = true)]
        public string DownstreamId { get; private set; }

        /// <summary>
        /// Returns false as DownstreamId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDownstreamId()
        {
            return false;
        }
        /// <summary>
        /// Reference to supplier bill number
        /// </summary>
        /// <value>Reference to supplier bill number</value>
        [DataMember(Name = "bill_number", EmitDefaultValue = true)]
        public string BillNumber { get; set; }

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name = "supplier", EmitDefaultValue = true)]
        public LinkedSupplier Supplier { get; set; }

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
        /// Date bill was issued - YYYY-MM-DD.
        /// </summary>
        /// <value>Date bill was issued - YYYY-MM-DD.</value>
        [DataMember(Name = "bill_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// The due date is the date on which a payment is scheduled to be received - YYYY-MM-DD.
        /// </summary>
        /// <value>The due date is the date on which a payment is scheduled to be received - YYYY-MM-DD.</value>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The paid date is the date on which a payment was sent to the supplier - YYYY-MM-DD.
        /// </summary>
        /// <value>The paid date is the date on which a payment was sent to the supplier - YYYY-MM-DD.</value>
        [DataMember(Name = "paid_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PaidDate { get; set; }

        /// <summary>
        /// A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order.
        /// </summary>
        /// <value>A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order.</value>
        [DataMember(Name = "po_number", EmitDefaultValue = true)]
        public string PoNumber { get; set; }

        /// <summary>
        /// Optional bill reference.
        /// </summary>
        /// <value>Optional bill reference.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<BillLineItem> LineItems { get; set; }

        /// <summary>
        /// Terms of payment.
        /// </summary>
        /// <value>Terms of payment.</value>
        [DataMember(Name = "terms", EmitDefaultValue = true)]
        public string Terms { get; set; }

        /// <summary>
        /// Balance of bill due.
        /// </summary>
        /// <value>Balance of bill due.</value>
        [DataMember(Name = "balance", EmitDefaultValue = true)]
        public decimal? Balance { get; set; }

        /// <summary>
        /// Amount of deposit made to this bill.
        /// </summary>
        /// <value>Amount of deposit made to this bill.</value>
        [DataMember(Name = "deposit", EmitDefaultValue = true)]
        public decimal? Deposit { get; set; }

        /// <summary>
        /// Sub-total amount, normally before tax.
        /// </summary>
        /// <value>Sub-total amount, normally before tax.</value>
        [DataMember(Name = "sub_total", EmitDefaultValue = true)]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// Total tax amount applied to this bill.
        /// </summary>
        /// <value>Total tax amount applied to this bill.</value>
        [DataMember(Name = "total_tax", EmitDefaultValue = true)]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Total amount of bill, including tax.
        /// </summary>
        /// <value>Total amount of bill, including tax.</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Applicable tax id/code override if tax is not supplied on a line item basis.
        /// </summary>
        /// <value>Applicable tax id/code override if tax is not supplied on a line item basis.</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = true)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets LedgerAccount
        /// </summary>
        [DataMember(Name = "ledger_account", EmitDefaultValue = true)]
        public LinkedLedgerAccount LedgerAccount { get; set; }

        /// <summary>
        /// Payment method used for the transaction, such as cash, credit card, bank transfer, or check
        /// </summary>
        /// <value>Payment method used for the transaction, such as cash, credit card, bank transfer, or check</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The channel through which the transaction is processed.
        /// </summary>
        /// <value>The channel through which the transaction is processed.</value>
        [DataMember(Name = "channel", EmitDefaultValue = true)]
        public string Channel { get; set; }

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        /// <value>language code according to ISO 639-1. For the United States - EN</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Indicates if accounting by row is used (true) or not (false). Accounting by row means that a separate ledger transaction is created for each row.
        /// </summary>
        /// <value>Indicates if accounting by row is used (true) or not (false). Accounting by row means that a separate ledger transaction is created for each row.</value>
        [DataMember(Name = "accounting_by_row", EmitDefaultValue = true)]
        public bool? AccountingByRow { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", EmitDefaultValue = false)]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// Discount percentage applied to this transaction.
        /// </summary>
        /// <value>Discount percentage applied to this transaction.</value>
        [DataMember(Name = "discount_percentage", EmitDefaultValue = true)]
        public decimal? DiscountPercentage { get; set; }

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
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Bill {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  BillNumber: ").Append(BillNumber).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  BillDate: ").Append(BillDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  PaidDate: ").Append(PaidDate).Append("\n");
            sb.Append("  PoNumber: ").Append(PoNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Deposit: ").Append(Deposit).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LedgerAccount: ").Append(LedgerAccount).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  AccountingByRow: ").Append(AccountingByRow).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
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
            return this.Equals(input as Bill);
        }

        /// <summary>
        /// Returns true if Bill instances are equal
        /// </summary>
        /// <param name="input">Instance of Bill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bill input)
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
                    this.DownstreamId == input.DownstreamId ||
                    (this.DownstreamId != null &&
                    this.DownstreamId.Equals(input.DownstreamId))
                ) && 
                (
                    this.BillNumber == input.BillNumber ||
                    (this.BillNumber != null &&
                    this.BillNumber.Equals(input.BillNumber))
                ) && 
                (
                    this.Supplier == input.Supplier ||
                    (this.Supplier != null &&
                    this.Supplier.Equals(input.Supplier))
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
                    this.BillDate == input.BillDate ||
                    (this.BillDate != null &&
                    this.BillDate.Equals(input.BillDate))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.PaidDate == input.PaidDate ||
                    (this.PaidDate != null &&
                    this.PaidDate.Equals(input.PaidDate))
                ) && 
                (
                    this.PoNumber == input.PoNumber ||
                    (this.PoNumber != null &&
                    this.PoNumber.Equals(input.PoNumber))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Deposit == input.Deposit ||
                    (this.Deposit != null &&
                    this.Deposit.Equals(input.Deposit))
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    (this.SubTotal != null &&
                    this.SubTotal.Equals(input.SubTotal))
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    (this.TotalTax != null &&
                    this.TotalTax.Equals(input.TotalTax))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    (this.TaxCode != null &&
                    this.TaxCode.Equals(input.TaxCode))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.LedgerAccount == input.LedgerAccount ||
                    (this.LedgerAccount != null &&
                    this.LedgerAccount.Equals(input.LedgerAccount))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.AccountingByRow == input.AccountingByRow ||
                    (this.AccountingByRow != null &&
                    this.AccountingByRow.Equals(input.AccountingByRow))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.DiscountPercentage == input.DiscountPercentage ||
                    (this.DiscountPercentage != null &&
                    this.DiscountPercentage.Equals(input.DiscountPercentage))
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
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
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
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                if (this.BillNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BillNumber.GetHashCode();
                }
                if (this.Supplier != null)
                {
                    hashCode = (hashCode * 59) + this.Supplier.GetHashCode();
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
                if (this.BillDate != null)
                {
                    hashCode = (hashCode * 59) + this.BillDate.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.PaidDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaidDate.GetHashCode();
                }
                if (this.PoNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PoNumber.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.Terms != null)
                {
                    hashCode = (hashCode * 59) + this.Terms.GetHashCode();
                }
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.Deposit != null)
                {
                    hashCode = (hashCode * 59) + this.Deposit.GetHashCode();
                }
                if (this.SubTotal != null)
                {
                    hashCode = (hashCode * 59) + this.SubTotal.GetHashCode();
                }
                if (this.TotalTax != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTax.GetHashCode();
                }
                if (this.Total != null)
                {
                    hashCode = (hashCode * 59) + this.Total.GetHashCode();
                }
                if (this.TaxCode != null)
                {
                    hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.LedgerAccount != null)
                {
                    hashCode = (hashCode * 59) + this.LedgerAccount.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.AccountingByRow != null)
                {
                    hashCode = (hashCode * 59) + this.AccountingByRow.GetHashCode();
                }
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.DiscountPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountPercentage.GetHashCode();
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
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
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
