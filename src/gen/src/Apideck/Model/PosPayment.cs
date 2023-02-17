/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.91.0
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
    /// PosPayment
    /// </summary>
    [DataContract(Name = "PosPayment")]
    public partial class PosPayment : IEquatable<PosPayment>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public Currency Currency { get; set; }
        /// <summary>
        /// Source of this payment.
        /// </summary>
        /// <value>Source of this payment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 1,

            /// <summary>
            /// Enum BankAccount for value: bank_account
            /// </summary>
            [EnumMember(Value = "bank_account")]
            BankAccount = 2,

            /// <summary>
            /// Enum Wallet for value: wallet
            /// </summary>
            [EnumMember(Value = "wallet")]
            Wallet = 3,

            /// <summary>
            /// Enum Bnpl for value: bnpl
            /// </summary>
            [EnumMember(Value = "bnpl")]
            Bnpl = 4,

            /// <summary>
            /// Enum Cash for value: cash
            /// </summary>
            [EnumMember(Value = "cash")]
            Cash = 5,

            /// <summary>
            /// Enum External for value: external
            /// </summary>
            [EnumMember(Value = "external")]
            External = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7

        }


        /// <summary>
        /// Source of this payment.
        /// </summary>
        /// <value>Source of this payment.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Status of this payment.
        /// </summary>
        /// <value>Status of this payment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,

            /// <summary>
            /// Enum Completed for value: completed
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed = 3,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 4,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6

        }


        /// <summary>
        /// Status of this payment.
        /// </summary>
        /// <value>Status of this payment.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PosPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PosPayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PosPayment" /> class.
        /// </summary>
        /// <param name="sourceId">The ID for the source of funds for this payment. Square-only: This can be a payment token (card nonce) generated by the payment form or a card on file made linked to the customer. if recording a payment that the seller received outside of Square, specify either &#x60;CASH&#x60; or &#x60;EXTERNAL&#x60;. (required).</param>
        /// <param name="orderId">orderId (required).</param>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="customerId">customerId (required).</param>
        /// <param name="employeeId">employeeId.</param>
        /// <param name="locationId">locationId.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="tenderId">tenderId (required).</param>
        /// <param name="externalPaymentId">externalPaymentId.</param>
        /// <param name="idempotencyKey">A value you specify that uniquely identifies this request among requests you have sent..</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="tip">tip.</param>
        /// <param name="tax">tax.</param>
        /// <param name="total">total.</param>
        /// <param name="appFee">The amount the developer is taking as a fee for facilitating the payment on behalf of the seller..</param>
        /// <param name="changeBackCashAmount">changeBackCashAmount.</param>
        /// <param name="approved">The initial amount of money approved for this payment..</param>
        /// <param name="refunded">The initial amount of money approved for this payment..</param>
        /// <param name="processingFees">processingFees.</param>
        /// <param name="source">Source of this payment..</param>
        /// <param name="status">Status of this payment..</param>
        /// <param name="cash">cash.</param>
        /// <param name="cardDetails">cardDetails.</param>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="wallet">wallet.</param>
        /// <param name="externalDetails">externalDetails.</param>
        /// <param name="serviceCharges">Optional service charges or gratuity tip applied to the order..</param>
        public PosPayment(string sourceId = default(string), string orderId = default(string), string merchantId = default(string), string customerId = default(string), string employeeId = default(string), string locationId = default(string), string deviceId = default(string), string tenderId = default(string), string externalPaymentId = default(string), string idempotencyKey = default(string), decimal amount = default(decimal), Currency currency = default(Currency), decimal tip = default(decimal), decimal tax = default(decimal), decimal total = default(decimal), decimal appFee = default(decimal), decimal changeBackCashAmount = default(decimal), decimal approved = default(decimal), decimal refunded = default(decimal), List<Object> processingFees = default(List<Object>), SourceEnum? source = default(SourceEnum?), StatusEnum? status = default(StatusEnum?), CashDetails cash = default(CashDetails), PosPaymentCardDetails cardDetails = default(PosPaymentCardDetails), PosBankAccount bankAccount = default(PosBankAccount), WalletDetails wallet = default(WalletDetails), PosPaymentExternalDetails externalDetails = default(PosPaymentExternalDetails), List<ServiceCharge> serviceCharges = default(List<ServiceCharge>))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null) {
                throw new ArgumentNullException("sourceId is a required property for PosPayment and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "orderId" is required (not null)
            if (orderId == null) {
                throw new ArgumentNullException("orderId is a required property for PosPayment and cannot be null");
            }
            this.OrderId = orderId;
            // to ensure "customerId" is required (not null)
            if (customerId == null) {
                throw new ArgumentNullException("customerId is a required property for PosPayment and cannot be null");
            }
            this.CustomerId = customerId;
            // to ensure "tenderId" is required (not null)
            if (tenderId == null) {
                throw new ArgumentNullException("tenderId is a required property for PosPayment and cannot be null");
            }
            this.TenderId = tenderId;
            this.Amount = amount;
            this.Currency = currency;
            this.MerchantId = merchantId;
            this.EmployeeId = employeeId;
            this.LocationId = locationId;
            this.DeviceId = deviceId;
            this.ExternalPaymentId = externalPaymentId;
            this.IdempotencyKey = idempotencyKey;
            this.Tip = tip;
            this.Tax = tax;
            this.Total = total;
            this.AppFee = appFee;
            this.ChangeBackCashAmount = changeBackCashAmount;
            this.Approved = approved;
            this.Refunded = refunded;
            this.ProcessingFees = processingFees;
            this.Source = source;
            this.Status = status;
            this.Cash = cash;
            this.CardDetails = cardDetails;
            this.BankAccount = bankAccount;
            this.Wallet = wallet;
            this.ExternalDetails = externalDetails;
            this.ServiceCharges = serviceCharges;
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
        /// The ID for the source of funds for this payment. Square-only: This can be a payment token (card nonce) generated by the payment form or a card on file made linked to the customer. if recording a payment that the seller received outside of Square, specify either &#x60;CASH&#x60; or &#x60;EXTERNAL&#x60;.
        /// </summary>
        /// <value>The ID for the source of funds for this payment. Square-only: This can be a payment token (card nonce) generated by the payment form or a card on file made linked to the customer. if recording a payment that the seller received outside of Square, specify either &#x60;CASH&#x60; or &#x60;EXTERNAL&#x60;.</value>
        [DataMember(Name = "source_id", IsRequired = true, EmitDefaultValue = false)]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "order_id", IsRequired = true, EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name = "customer_id", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name = "location_id", EmitDefaultValue = false)]
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "device_id", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets TenderId
        /// </summary>
        [DataMember(Name = "tender_id", IsRequired = true, EmitDefaultValue = false)]
        public string TenderId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalPaymentId
        /// </summary>
        [DataMember(Name = "external_payment_id", EmitDefaultValue = false)]
        public string ExternalPaymentId { get; set; }

        /// <summary>
        /// A value you specify that uniquely identifies this request among requests you have sent.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this request among requests you have sent.</value>
        [DataMember(Name = "idempotency_key", EmitDefaultValue = false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets Tip
        /// </summary>
        [DataMember(Name = "tip", EmitDefaultValue = false)]
        public decimal Tip { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        public decimal Tax { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public decimal Total { get; set; }

        /// <summary>
        /// The amount the developer is taking as a fee for facilitating the payment on behalf of the seller.
        /// </summary>
        /// <value>The amount the developer is taking as a fee for facilitating the payment on behalf of the seller.</value>
        [DataMember(Name = "app_fee", EmitDefaultValue = false)]
        public decimal AppFee { get; set; }

        /// <summary>
        /// Gets or Sets ChangeBackCashAmount
        /// </summary>
        [DataMember(Name = "change_back_cash_amount", EmitDefaultValue = false)]
        public decimal ChangeBackCashAmount { get; set; }

        /// <summary>
        /// The initial amount of money approved for this payment.
        /// </summary>
        /// <value>The initial amount of money approved for this payment.</value>
        [DataMember(Name = "approved", EmitDefaultValue = false)]
        public decimal Approved { get; set; }

        /// <summary>
        /// The initial amount of money approved for this payment.
        /// </summary>
        /// <value>The initial amount of money approved for this payment.</value>
        [DataMember(Name = "refunded", EmitDefaultValue = false)]
        public decimal Refunded { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingFees
        /// </summary>
        [DataMember(Name = "processing_fees", EmitDefaultValue = false)]
        public List<Object> ProcessingFees { get; set; }

        /// <summary>
        /// Gets or Sets Cash
        /// </summary>
        [DataMember(Name = "cash", EmitDefaultValue = false)]
        public CashDetails Cash { get; set; }

        /// <summary>
        /// Gets or Sets CardDetails
        /// </summary>
        [DataMember(Name = "card_details", EmitDefaultValue = false)]
        public PosPaymentCardDetails CardDetails { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", EmitDefaultValue = false)]
        public PosBankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name = "wallet", EmitDefaultValue = false)]
        public WalletDetails Wallet { get; set; }

        /// <summary>
        /// Gets or Sets ExternalDetails
        /// </summary>
        [DataMember(Name = "external_details", EmitDefaultValue = false)]
        public PosPaymentExternalDetails ExternalDetails { get; set; }

        /// <summary>
        /// Optional service charges or gratuity tip applied to the order.
        /// </summary>
        /// <value>Optional service charges or gratuity tip applied to the order.</value>
        [DataMember(Name = "service_charges", EmitDefaultValue = false)]
        public List<ServiceCharge> ServiceCharges { get; set; }

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
            sb.Append("class PosPayment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  TenderId: ").Append(TenderId).Append("\n");
            sb.Append("  ExternalPaymentId: ").Append(ExternalPaymentId).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Tip: ").Append(Tip).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  AppFee: ").Append(AppFee).Append("\n");
            sb.Append("  ChangeBackCashAmount: ").Append(ChangeBackCashAmount).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Refunded: ").Append(Refunded).Append("\n");
            sb.Append("  ProcessingFees: ").Append(ProcessingFees).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Cash: ").Append(Cash).Append("\n");
            sb.Append("  CardDetails: ").Append(CardDetails).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  ExternalDetails: ").Append(ExternalDetails).Append("\n");
            sb.Append("  ServiceCharges: ").Append(ServiceCharges).Append("\n");
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
            return this.Equals(input as PosPayment);
        }

        /// <summary>
        /// Returns true if PosPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of PosPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PosPayment input)
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
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.TenderId == input.TenderId ||
                    (this.TenderId != null &&
                    this.TenderId.Equals(input.TenderId))
                ) && 
                (
                    this.ExternalPaymentId == input.ExternalPaymentId ||
                    (this.ExternalPaymentId != null &&
                    this.ExternalPaymentId.Equals(input.ExternalPaymentId))
                ) && 
                (
                    this.IdempotencyKey == input.IdempotencyKey ||
                    (this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(input.IdempotencyKey))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Tip == input.Tip ||
                    this.Tip.Equals(input.Tip)
                ) && 
                (
                    this.Tax == input.Tax ||
                    this.Tax.Equals(input.Tax)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.AppFee == input.AppFee ||
                    this.AppFee.Equals(input.AppFee)
                ) && 
                (
                    this.ChangeBackCashAmount == input.ChangeBackCashAmount ||
                    this.ChangeBackCashAmount.Equals(input.ChangeBackCashAmount)
                ) && 
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) && 
                (
                    this.Refunded == input.Refunded ||
                    this.Refunded.Equals(input.Refunded)
                ) && 
                (
                    this.ProcessingFees == input.ProcessingFees ||
                    this.ProcessingFees != null &&
                    input.ProcessingFees != null &&
                    this.ProcessingFees.SequenceEqual(input.ProcessingFees)
                ) && 
                (
                    this.Source == input.Source ||
                    this.Source.Equals(input.Source)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Cash == input.Cash ||
                    (this.Cash != null &&
                    this.Cash.Equals(input.Cash))
                ) && 
                (
                    this.CardDetails == input.CardDetails ||
                    (this.CardDetails != null &&
                    this.CardDetails.Equals(input.CardDetails))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
                ) && 
                (
                    this.ExternalDetails == input.ExternalDetails ||
                    (this.ExternalDetails != null &&
                    this.ExternalDetails.Equals(input.ExternalDetails))
                ) && 
                (
                    this.ServiceCharges == input.ServiceCharges ||
                    this.ServiceCharges != null &&
                    input.ServiceCharges != null &&
                    this.ServiceCharges.SequenceEqual(input.ServiceCharges)
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
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
                }
                if (this.TenderId != null)
                {
                    hashCode = (hashCode * 59) + this.TenderId.GetHashCode();
                }
                if (this.ExternalPaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalPaymentId.GetHashCode();
                }
                if (this.IdempotencyKey != null)
                {
                    hashCode = (hashCode * 59) + this.IdempotencyKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                hashCode = (hashCode * 59) + this.Tip.GetHashCode();
                hashCode = (hashCode * 59) + this.Tax.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                hashCode = (hashCode * 59) + this.AppFee.GetHashCode();
                hashCode = (hashCode * 59) + this.ChangeBackCashAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.Approved.GetHashCode();
                hashCode = (hashCode * 59) + this.Refunded.GetHashCode();
                if (this.ProcessingFees != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessingFees.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Source.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Cash != null)
                {
                    hashCode = (hashCode * 59) + this.Cash.GetHashCode();
                }
                if (this.CardDetails != null)
                {
                    hashCode = (hashCode * 59) + this.CardDetails.GetHashCode();
                }
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.Wallet != null)
                {
                    hashCode = (hashCode * 59) + this.Wallet.GetHashCode();
                }
                if (this.ExternalDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalDetails.GetHashCode();
                }
                if (this.ServiceCharges != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCharges.GetHashCode();
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
            // IdempotencyKey (string) maxLength
            if (this.IdempotencyKey != null && this.IdempotencyKey.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdempotencyKey, length must be less than 45.", new [] { "IdempotencyKey" });
            }

            yield break;
        }
    }

}
