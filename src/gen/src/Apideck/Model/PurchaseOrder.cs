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
    /// PurchaseOrder
    /// </summary>
    [DataContract(Name = "PurchaseOrder")]
    public partial class PurchaseOrder : IEquatable<PurchaseOrder>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,

            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 2,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 3,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 4,

            /// <summary>
            /// Enum Billed for value: billed
            /// </summary>
            [EnumMember(Value = "billed")]
            Billed = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrder" /> class.
        /// </summary>
        /// <param name="poNumber">A PO Number uniquely identifies a purchase order and is generally defined by the buyer..</param>
        /// <param name="reference">Optional purchase order reference..</param>
        /// <param name="supplier">supplier.</param>
        /// <param name="status">status.</param>
        /// <param name="issuedDate">Date purchase order was issued - YYYY-MM-DD..</param>
        /// <param name="deliveryDate">The date on which the purchase order is to be delivered - YYYY-MM-DD..</param>
        /// <param name="expectedArrivalDate">The date on which the order is expected to arrive - YYYY-MM-DD..</param>
        /// <param name="currency">currency.</param>
        /// <param name="currencyRate">Currency Exchange Rate at the time entity was recorded/generated..</param>
        /// <param name="subTotal">Sub-total amount, normally before tax..</param>
        /// <param name="totalTax">Total tax amount applied to this invoice..</param>
        /// <param name="total">Total amount of invoice, including tax..</param>
        /// <param name="taxInclusive">Amounts are including tax.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="ledgerAccount">ledgerAccount.</param>
        /// <param name="templateId">Optional purchase order template.</param>
        /// <param name="discountPercentage">Discount percentage applied to this transaction..</param>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="accountingByRow">Indicates if accounting by row is used (true) or not (false). Accounting by row means that a separate ledger transaction is created for each row..</param>
        /// <param name="dueDate">The due date is the date on which a payment is scheduled to be received - YYYY-MM-DD..</param>
        /// <param name="paymentMethod">Payment method used for the transaction, such as cash, credit card, bank transfer, or check.</param>
        /// <param name="taxCode">Applicable tax id/code override if tax is not supplied on a line item basis..</param>
        /// <param name="channel">The channel through which the transaction is processed..</param>
        /// <param name="memo">Message for the supplier. This text appears on the Purchase Order..</param>
        /// <param name="customMappings">When custom mappings are configured on the resource, the result is included here..</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        public PurchaseOrder(string poNumber = default(string), string reference = default(string), LinkedSupplier supplier = default(LinkedSupplier), StatusEnum? status = default(StatusEnum?), DateTime? issuedDate = default(DateTime?), DateTime? deliveryDate = default(DateTime?), DateTime? expectedArrivalDate = default(DateTime?), Currency? currency = default(Currency?), decimal? currencyRate = default(decimal?), decimal? subTotal = default(decimal?), decimal? totalTax = default(decimal?), decimal? total = default(decimal?), bool? taxInclusive = default(bool?), List<InvoiceLineItem> lineItems = default(List<InvoiceLineItem>), Address shippingAddress = default(Address), LinkedLedgerAccount ledgerAccount = default(LinkedLedgerAccount), string templateId = default(string), decimal? discountPercentage = default(decimal?), BankAccount bankAccount = default(BankAccount), bool? accountingByRow = default(bool?), DateTime dueDate = default(DateTime), string paymentMethod = default(string), string taxCode = default(string), string channel = default(string), string memo = default(string), Object customMappings = default(Object), string rowVersion = default(string))
        {
            this.PoNumber = poNumber;
            this.Reference = reference;
            this.Supplier = supplier;
            this.Status = status;
            this.IssuedDate = issuedDate;
            this.DeliveryDate = deliveryDate;
            this.ExpectedArrivalDate = expectedArrivalDate;
            this.Currency = currency;
            this.CurrencyRate = currencyRate;
            this.SubTotal = subTotal;
            this.TotalTax = totalTax;
            this.Total = total;
            this.TaxInclusive = taxInclusive;
            this.LineItems = lineItems;
            this.ShippingAddress = shippingAddress;
            this.LedgerAccount = ledgerAccount;
            this.TemplateId = templateId;
            this.DiscountPercentage = discountPercentage;
            this.BankAccount = bankAccount;
            this.AccountingByRow = accountingByRow;
            this.DueDate = dueDate;
            this.PaymentMethod = paymentMethod;
            this.TaxCode = taxCode;
            this.Channel = channel;
            this.Memo = memo;
            this.CustomMappings = customMappings;
            this.RowVersion = rowVersion;
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
        /// A PO Number uniquely identifies a purchase order and is generally defined by the buyer.
        /// </summary>
        /// <value>A PO Number uniquely identifies a purchase order and is generally defined by the buyer.</value>
        [DataMember(Name = "po_number", EmitDefaultValue = true)]
        public string PoNumber { get; set; }

        /// <summary>
        /// Optional purchase order reference.
        /// </summary>
        /// <value>Optional purchase order reference.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name = "supplier", EmitDefaultValue = true)]
        public LinkedSupplier Supplier { get; set; }

        /// <summary>
        /// Date purchase order was issued - YYYY-MM-DD.
        /// </summary>
        /// <value>Date purchase order was issued - YYYY-MM-DD.</value>
        [DataMember(Name = "issued_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? IssuedDate { get; set; }

        /// <summary>
        /// The date on which the purchase order is to be delivered - YYYY-MM-DD.
        /// </summary>
        /// <value>The date on which the purchase order is to be delivered - YYYY-MM-DD.</value>
        [DataMember(Name = "delivery_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// The date on which the order is expected to arrive - YYYY-MM-DD.
        /// </summary>
        /// <value>The date on which the order is expected to arrive - YYYY-MM-DD.</value>
        [DataMember(Name = "expected_arrival_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ExpectedArrivalDate { get; set; }

        /// <summary>
        /// Currency Exchange Rate at the time entity was recorded/generated.
        /// </summary>
        /// <value>Currency Exchange Rate at the time entity was recorded/generated.</value>
        [DataMember(Name = "currency_rate", EmitDefaultValue = true)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Sub-total amount, normally before tax.
        /// </summary>
        /// <value>Sub-total amount, normally before tax.</value>
        [DataMember(Name = "sub_total", EmitDefaultValue = true)]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// Total tax amount applied to this invoice.
        /// </summary>
        /// <value>Total tax amount applied to this invoice.</value>
        [DataMember(Name = "total_tax", EmitDefaultValue = true)]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Total amount of invoice, including tax.
        /// </summary>
        /// <value>Total amount of invoice, including tax.</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Amounts are including tax
        /// </summary>
        /// <value>Amounts are including tax</value>
        [DataMember(Name = "tax_inclusive", EmitDefaultValue = true)]
        public bool? TaxInclusive { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<InvoiceLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets LedgerAccount
        /// </summary>
        [DataMember(Name = "ledger_account", EmitDefaultValue = true)]
        public LinkedLedgerAccount LedgerAccount { get; set; }

        /// <summary>
        /// Optional purchase order template
        /// </summary>
        /// <value>Optional purchase order template</value>
        [DataMember(Name = "template_id", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Discount percentage applied to this transaction.
        /// </summary>
        /// <value>Discount percentage applied to this transaction.</value>
        [DataMember(Name = "discount_percentage", EmitDefaultValue = true)]
        public decimal? DiscountPercentage { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", EmitDefaultValue = false)]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// Indicates if accounting by row is used (true) or not (false). Accounting by row means that a separate ledger transaction is created for each row.
        /// </summary>
        /// <value>Indicates if accounting by row is used (true) or not (false). Accounting by row means that a separate ledger transaction is created for each row.</value>
        [DataMember(Name = "accounting_by_row", EmitDefaultValue = true)]
        public bool? AccountingByRow { get; set; }

        /// <summary>
        /// The due date is the date on which a payment is scheduled to be received - YYYY-MM-DD.
        /// </summary>
        /// <value>The due date is the date on which a payment is scheduled to be received - YYYY-MM-DD.</value>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Payment method used for the transaction, such as cash, credit card, bank transfer, or check
        /// </summary>
        /// <value>Payment method used for the transaction, such as cash, credit card, bank transfer, or check</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Applicable tax id/code override if tax is not supplied on a line item basis.
        /// </summary>
        /// <value>Applicable tax id/code override if tax is not supplied on a line item basis.</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = true)]
        public string TaxCode { get; set; }

        /// <summary>
        /// The channel through which the transaction is processed.
        /// </summary>
        /// <value>The channel through which the transaction is processed.</value>
        [DataMember(Name = "channel", EmitDefaultValue = true)]
        public string Channel { get; set; }

        /// <summary>
        /// Message for the supplier. This text appears on the Purchase Order.
        /// </summary>
        /// <value>Message for the supplier. This text appears on the Purchase Order.</value>
        [DataMember(Name = "memo", EmitDefaultValue = true)]
        public string Memo { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; set; }

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        /// <value>A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.</value>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PurchaseOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  PoNumber: ").Append(PoNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IssuedDate: ").Append(IssuedDate).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  ExpectedArrivalDate: ").Append(ExpectedArrivalDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  LedgerAccount: ").Append(LedgerAccount).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  AccountingByRow: ").Append(AccountingByRow).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
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
            return this.Equals(input as PurchaseOrder);
        }

        /// <summary>
        /// Returns true if PurchaseOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrder input)
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
                    this.Supplier == input.Supplier ||
                    (this.Supplier != null &&
                    this.Supplier.Equals(input.Supplier))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.IssuedDate == input.IssuedDate ||
                    (this.IssuedDate != null &&
                    this.IssuedDate.Equals(input.IssuedDate))
                ) && 
                (
                    this.DeliveryDate == input.DeliveryDate ||
                    (this.DeliveryDate != null &&
                    this.DeliveryDate.Equals(input.DeliveryDate))
                ) && 
                (
                    this.ExpectedArrivalDate == input.ExpectedArrivalDate ||
                    (this.ExpectedArrivalDate != null &&
                    this.ExpectedArrivalDate.Equals(input.ExpectedArrivalDate))
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
                    this.TaxInclusive == input.TaxInclusive ||
                    (this.TaxInclusive != null &&
                    this.TaxInclusive.Equals(input.TaxInclusive))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.LedgerAccount == input.LedgerAccount ||
                    (this.LedgerAccount != null &&
                    this.LedgerAccount.Equals(input.LedgerAccount))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.DiscountPercentage == input.DiscountPercentage ||
                    (this.DiscountPercentage != null &&
                    this.DiscountPercentage.Equals(input.DiscountPercentage))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.AccountingByRow == input.AccountingByRow ||
                    (this.AccountingByRow != null &&
                    this.AccountingByRow.Equals(input.AccountingByRow))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    (this.TaxCode != null &&
                    this.TaxCode.Equals(input.TaxCode))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
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
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                if (this.PoNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PoNumber.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Supplier != null)
                {
                    hashCode = (hashCode * 59) + this.Supplier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.IssuedDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedDate.GetHashCode();
                }
                if (this.DeliveryDate != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryDate.GetHashCode();
                }
                if (this.ExpectedArrivalDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedArrivalDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.CurrencyRate != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyRate.GetHashCode();
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
                if (this.TaxInclusive != null)
                {
                    hashCode = (hashCode * 59) + this.TaxInclusive.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingAddress.GetHashCode();
                }
                if (this.LedgerAccount != null)
                {
                    hashCode = (hashCode * 59) + this.LedgerAccount.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.DiscountPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountPercentage.GetHashCode();
                }
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.AccountingByRow != null)
                {
                    hashCode = (hashCode * 59) + this.AccountingByRow.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.TaxCode != null)
                {
                    hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                }
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
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
