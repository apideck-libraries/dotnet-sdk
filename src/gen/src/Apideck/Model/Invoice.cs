/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.36.0
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
    /// Invoice
    /// </summary>
    [DataContract(Name = "Invoice")]
    public partial class Invoice : IEquatable<Invoice>, IValidatableObject
    {
        /// <summary>
        /// Invoice type
        /// </summary>
        /// <value>Invoice type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 1,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 2,

            /// <summary>
            /// Enum Service for value: service
            /// </summary>
            [EnumMember(Value = "service")]
            Service = 3,

            /// <summary>
            /// Enum Product for value: product
            /// </summary>
            [EnumMember(Value = "product")]
            Product = 4,

            /// <summary>
            /// Enum Supplier for value: supplier
            /// </summary>
            [EnumMember(Value = "supplier")]
            Supplier = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6

        }


        /// <summary>
        /// Invoice type
        /// </summary>
        /// <value>Invoice type</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
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
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="type">Invoice type.</param>
        /// <param name="number">Invoice number..</param>
        /// <param name="customer">customer.</param>
        /// <param name="invoiceDate">Date invoice was issued - YYYY-MM-DD..</param>
        /// <param name="dueDate">The invoice due date is the date on which a payment or invoice is scheduled to be received by the seller - YYYY-MM-DD..</param>
        /// <param name="terms">Terms of payment..</param>
        /// <param name="poNumber">A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order..</param>
        /// <param name="reference">Optional invoice reference..</param>
        /// <param name="status">Invoice status.</param>
        /// <param name="invoiceSent">Invoice sent to contact/customer..</param>
        /// <param name="currency">currency.</param>
        /// <param name="currencyRate">Currency Exchange Rate at the time entity was recorded/generated..</param>
        /// <param name="taxInclusive">Amounts are including tax.</param>
        /// <param name="subTotal">Sub-total amount, normally before tax..</param>
        /// <param name="totalTax">Total tax amount applied to this invoice..</param>
        /// <param name="taxCode">Applicable tax id/code override if tax is not supplied on a line item basis..</param>
        /// <param name="total">Total amount of invoice, including tax..</param>
        /// <param name="balance">Balance of invoice due..</param>
        /// <param name="deposit">Amount of deposit made to this invoice..</param>
        /// <param name="customerMemo">Customer memo.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="templateId">Optional invoice template.</param>
        /// <param name="sourceDocumentUrl">URL link to a source document - shown as &#39;Go to [appName]&#39; in the downstream app. Currently only supported for Xero..</param>
        /// <param name="rowVersion">rowVersion.</param>
        public Invoice(TypeEnum? type = default(TypeEnum?), string number = default(string), LinkedCustomer customer = default(LinkedCustomer), DateTime invoiceDate = default(DateTime), DateTime dueDate = default(DateTime), string terms = default(string), string poNumber = default(string), string reference = default(string), StatusEnum? status = default(StatusEnum?), bool invoiceSent = default(bool), Currency? currency = default(Currency?), decimal? currencyRate = default(decimal?), bool? taxInclusive = default(bool?), decimal? subTotal = default(decimal?), decimal? totalTax = default(decimal?), string taxCode = default(string), decimal? total = default(decimal?), decimal? balance = default(decimal?), decimal? deposit = default(decimal?), string customerMemo = default(string), List<InvoiceLineItem> lineItems = default(List<InvoiceLineItem>), Address billingAddress = default(Address), Address shippingAddress = default(Address), string templateId = default(string), string sourceDocumentUrl = default(string), string rowVersion = default(string))
        {
            this.Type = type;
            this.Number = number;
            this.Customer = customer;
            this.InvoiceDate = invoiceDate;
            this.DueDate = dueDate;
            this.Terms = terms;
            this.PoNumber = poNumber;
            this.Reference = reference;
            this.Status = status;
            this.InvoiceSent = invoiceSent;
            this.Currency = currency;
            this.CurrencyRate = currencyRate;
            this.TaxInclusive = taxInclusive;
            this.SubTotal = subTotal;
            this.TotalTax = totalTax;
            this.TaxCode = taxCode;
            this.Total = total;
            this.Balance = balance;
            this.Deposit = deposit;
            this.CustomerMemo = customerMemo;
            this.LineItems = lineItems;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.TemplateId = templateId;
            this.SourceDocumentUrl = sourceDocumentUrl;
            this.RowVersion = rowVersion;
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
        /// Invoice number.
        /// </summary>
        /// <value>Invoice number.</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = true)]
        public LinkedCustomer Customer { get; set; }

        /// <summary>
        /// Date invoice was issued - YYYY-MM-DD.
        /// </summary>
        /// <value>Date invoice was issued - YYYY-MM-DD.</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// The invoice due date is the date on which a payment or invoice is scheduled to be received by the seller - YYYY-MM-DD.
        /// </summary>
        /// <value>The invoice due date is the date on which a payment or invoice is scheduled to be received by the seller - YYYY-MM-DD.</value>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Terms of payment.
        /// </summary>
        /// <value>Terms of payment.</value>
        [DataMember(Name = "terms", EmitDefaultValue = true)]
        public string Terms { get; set; }

        /// <summary>
        /// A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order.
        /// </summary>
        /// <value>A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order.</value>
        [DataMember(Name = "po_number", EmitDefaultValue = true)]
        public string PoNumber { get; set; }

        /// <summary>
        /// Optional invoice reference.
        /// </summary>
        /// <value>Optional invoice reference.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Invoice sent to contact/customer.
        /// </summary>
        /// <value>Invoice sent to contact/customer.</value>
        [DataMember(Name = "invoice_sent", EmitDefaultValue = true)]
        public bool InvoiceSent { get; set; }

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
        /// Total amount of invoice, including tax.
        /// </summary>
        /// <value>Total amount of invoice, including tax.</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Balance of invoice due.
        /// </summary>
        /// <value>Balance of invoice due.</value>
        [DataMember(Name = "balance", EmitDefaultValue = true)]
        public decimal? Balance { get; set; }

        /// <summary>
        /// Amount of deposit made to this invoice.
        /// </summary>
        /// <value>Amount of deposit made to this invoice.</value>
        [DataMember(Name = "deposit", EmitDefaultValue = true)]
        public decimal? Deposit { get; set; }

        /// <summary>
        /// Customer memo
        /// </summary>
        /// <value>Customer memo</value>
        [DataMember(Name = "customer_memo", EmitDefaultValue = true)]
        public string CustomerMemo { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<InvoiceLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billing_address", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Optional invoice template
        /// </summary>
        /// <value>Optional invoice template</value>
        [DataMember(Name = "template_id", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        /// URL link to a source document - shown as &#39;Go to [appName]&#39; in the downstream app. Currently only supported for Xero.
        /// </summary>
        /// <value>URL link to a source document - shown as &#39;Go to [appName]&#39; in the downstream app. Currently only supported for Xero.</value>
        [DataMember(Name = "source_document_url", EmitDefaultValue = true)]
        public string SourceDocumentUrl { get; set; }

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
            sb.Append("class Invoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  PoNumber: ").Append(PoNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  InvoiceSent: ").Append(InvoiceSent).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Deposit: ").Append(Deposit).Append("\n");
            sb.Append("  CustomerMemo: ").Append(CustomerMemo).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  SourceDocumentUrl: ").Append(SourceDocumentUrl).Append("\n");
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
            return this.Equals(input as Invoice);
        }

        /// <summary>
        /// Returns true if Invoice instances are equal
        /// </summary>
        /// <param name="input">Instance of Invoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoice input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.InvoiceSent == input.InvoiceSent ||
                    this.InvoiceSent.Equals(input.InvoiceSent)
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
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                    this.CustomerMemo == input.CustomerMemo ||
                    (this.CustomerMemo != null &&
                    this.CustomerMemo.Equals(input.CustomerMemo))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.SourceDocumentUrl == input.SourceDocumentUrl ||
                    (this.SourceDocumentUrl != null &&
                    this.SourceDocumentUrl.Equals(input.SourceDocumentUrl))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.Terms != null)
                {
                    hashCode = (hashCode * 59) + this.Terms.GetHashCode();
                }
                if (this.PoNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PoNumber.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.InvoiceSent.GetHashCode();
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
                if (this.TotalTax != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTax.GetHashCode();
                }
                if (this.TaxCode != null)
                {
                    hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                }
                if (this.Total != null)
                {
                    hashCode = (hashCode * 59) + this.Total.GetHashCode();
                }
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.Deposit != null)
                {
                    hashCode = (hashCode * 59) + this.Deposit.GetHashCode();
                }
                if (this.CustomerMemo != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerMemo.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingAddress.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.SourceDocumentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SourceDocumentUrl.GetHashCode();
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
