/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.13.0
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
    /// BillPayment
    /// </summary>
    [DataContract(Name = "BillPayment")]
    public partial class BillPayment : IEquatable<BillPayment>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public PaymentStatus? Status { get; set; }
        /// <summary>
        /// Type of payment
        /// </summary>
        /// <value>Type of payment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PayableCredit for value: accounts_payable_credit
            /// </summary>
            [EnumMember(Value = "accounts_payable_credit")]
            PayableCredit = 1,

            /// <summary>
            /// Enum PayableOverpayment for value: accounts_payable_overpayment
            /// </summary>
            [EnumMember(Value = "accounts_payable_overpayment")]
            PayableOverpayment = 2,

            /// <summary>
            /// Enum PayablePrepayment for value: accounts_payable_prepayment
            /// </summary>
            [EnumMember(Value = "accounts_payable_prepayment")]
            PayablePrepayment = 3,

            /// <summary>
            /// Enum Payable for value: accounts_payable
            /// </summary>
            [EnumMember(Value = "accounts_payable")]
            Payable = 4

        }


        /// <summary>
        /// Type of payment
        /// </summary>
        /// <value>Type of payment</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillPayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillPayment" /> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="currencyRate">Currency Exchange Rate at the time entity was recorded/generated..</param>
        /// <param name="totalAmount">The total amount of the transaction or record (required).</param>
        /// <param name="reference">Optional transaction reference message ie: Debit remittance detail..</param>
        /// <param name="paymentMethod">Payment method used for the transaction, such as cash, credit card, bank transfer, or check.</param>
        /// <param name="paymentMethodReference">Optional reference message returned by payment method on processing.</param>
        /// <param name="paymentMethodId">A unique identifier for an object..</param>
        /// <param name="account">account.</param>
        /// <param name="transactionDate">The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD (required).</param>
        /// <param name="supplier">supplier.</param>
        /// <param name="companyId">The company or subsidiary id the transaction belongs to.</param>
        /// <param name="reconciled">Indicates if the transaction has been reconciled..</param>
        /// <param name="status">status.</param>
        /// <param name="type">Type of payment.</param>
        /// <param name="allocations">allocations.</param>
        /// <param name="note">Note associated with the transaction.</param>
        /// <param name="number">Number associated with the transaction.</param>
        /// <param name="trackingCategories">A list of linked tracking categories..</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        /// <param name="displayId">Id to be displayed..</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public BillPayment(Currency? currency = default(Currency?), decimal? currencyRate = default(decimal?), decimal? totalAmount = default(decimal?), string reference = default(string), string paymentMethod = default(string), string paymentMethodReference = default(string), string paymentMethodId = default(string), LinkedLedgerAccount account = default(LinkedLedgerAccount), DateTime? transactionDate = default(DateTime?), LinkedSupplier supplier = default(LinkedSupplier), string companyId = default(string), bool? reconciled = default(bool?), PaymentStatus? status = default(PaymentStatus?), TypeEnum? type = default(TypeEnum?), List<BillPaymentAllocations> allocations = default(List<BillPaymentAllocations>), string note = default(string), string number = default(string), List<LinkedTrackingCategory> trackingCategories = default(List<LinkedTrackingCategory>), List<CustomField> customFields = default(List<CustomField>), string rowVersion = default(string), string displayId = default(string), List<Object> passThrough = default(List<Object>))
        {
            // to ensure "totalAmount" is required (not null)
            if (totalAmount == null) {
                throw new ArgumentNullException("totalAmount is a required property for BillPayment and cannot be null");
            }
            this.TotalAmount = totalAmount;
            // to ensure "transactionDate" is required (not null)
            if (transactionDate == null) {
                throw new ArgumentNullException("transactionDate is a required property for BillPayment and cannot be null");
            }
            this.TransactionDate = transactionDate;
            this.Currency = currency;
            this.CurrencyRate = currencyRate;
            this.Reference = reference;
            this.PaymentMethod = paymentMethod;
            this.PaymentMethodReference = paymentMethodReference;
            this.PaymentMethodId = paymentMethodId;
            this.Account = account;
            this.Supplier = supplier;
            this.CompanyId = companyId;
            this.Reconciled = reconciled;
            this.Status = status;
            this.Type = type;
            this.Allocations = allocations;
            this.Note = note;
            this.Number = number;
            this.TrackingCategories = trackingCategories;
            this.CustomFields = customFields;
            this.RowVersion = rowVersion;
            this.DisplayId = displayId;
            this.PassThrough = passThrough;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
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
        /// Currency Exchange Rate at the time entity was recorded/generated.
        /// </summary>
        /// <value>Currency Exchange Rate at the time entity was recorded/generated.</value>
        [DataMember(Name = "currency_rate", EmitDefaultValue = true)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// The total amount of the transaction or record
        /// </summary>
        /// <value>The total amount of the transaction or record</value>
        [DataMember(Name = "total_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Optional transaction reference message ie: Debit remittance detail.
        /// </summary>
        /// <value>Optional transaction reference message ie: Debit remittance detail.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Payment method used for the transaction, such as cash, credit card, bank transfer, or check
        /// </summary>
        /// <value>Payment method used for the transaction, such as cash, credit card, bank transfer, or check</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Optional reference message returned by payment method on processing
        /// </summary>
        /// <value>Optional reference message returned by payment method on processing</value>
        [DataMember(Name = "payment_method_reference", EmitDefaultValue = true)]
        public string PaymentMethodReference { get; set; }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "payment_method_id", EmitDefaultValue = true)]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public LinkedLedgerAccount Account { get; set; }

        /// <summary>
        /// The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD
        /// </summary>
        /// <value>The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD</value>
        [DataMember(Name = "transaction_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name = "supplier", EmitDefaultValue = true)]
        public LinkedSupplier Supplier { get; set; }

        /// <summary>
        /// The company or subsidiary id the transaction belongs to
        /// </summary>
        /// <value>The company or subsidiary id the transaction belongs to</value>
        [DataMember(Name = "company_id", EmitDefaultValue = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Indicates if the transaction has been reconciled.
        /// </summary>
        /// <value>Indicates if the transaction has been reconciled.</value>
        [DataMember(Name = "reconciled", EmitDefaultValue = true)]
        public bool? Reconciled { get; set; }

        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name = "allocations", EmitDefaultValue = false)]
        public List<BillPaymentAllocations> Allocations { get; set; }

        /// <summary>
        /// Note associated with the transaction
        /// </summary>
        /// <value>Note associated with the transaction</value>
        [DataMember(Name = "note", EmitDefaultValue = true)]
        public string Note { get; set; }

        /// <summary>
        /// Number associated with the transaction
        /// </summary>
        /// <value>Number associated with the transaction</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        /// <value>A list of linked tracking categories.</value>
        [DataMember(Name = "tracking_categories", EmitDefaultValue = true)]
        public List<LinkedTrackingCategory> TrackingCategories { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public List<CustomField> CustomFields { get; set; }

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        /// <value>A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.</value>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

        /// <summary>
        /// Id to be displayed.
        /// </summary>
        /// <value>Id to be displayed.</value>
        [DataMember(Name = "display_id", EmitDefaultValue = true)]
        public string DisplayId { get; set; }

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
            sb.Append("class BillPayment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentMethodReference: ").Append(PaymentMethodReference).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Reconciled: ").Append(Reconciled).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as BillPayment);
        }

        /// <summary>
        /// Returns true if BillPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of BillPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillPayment input)
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
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    (this.CurrencyRate != null &&
                    this.CurrencyRate.Equals(input.CurrencyRate))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PaymentMethodReference == input.PaymentMethodReference ||
                    (this.PaymentMethodReference != null &&
                    this.PaymentMethodReference.Equals(input.PaymentMethodReference))
                ) && 
                (
                    this.PaymentMethodId == input.PaymentMethodId ||
                    (this.PaymentMethodId != null &&
                    this.PaymentMethodId.Equals(input.PaymentMethodId))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.Supplier == input.Supplier ||
                    (this.Supplier != null &&
                    this.Supplier.Equals(input.Supplier))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.Reconciled == input.Reconciled ||
                    (this.Reconciled != null &&
                    this.Reconciled.Equals(input.Reconciled))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
                ) && 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.CurrencyRate != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyRate.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.PaymentMethodReference != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodReference.GetHashCode();
                }
                if (this.PaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodId.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.TransactionDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDate.GetHashCode();
                }
                if (this.Supplier != null)
                {
                    hashCode = (hashCode * 59) + this.Supplier.GetHashCode();
                }
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.Reconciled != null)
                {
                    hashCode = (hashCode * 59) + this.Reconciled.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Allocations != null)
                {
                    hashCode = (hashCode * 59) + this.Allocations.GetHashCode();
                }
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.TrackingCategories != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingCategories.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
                }
                if (this.DisplayId != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayId.GetHashCode();
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
