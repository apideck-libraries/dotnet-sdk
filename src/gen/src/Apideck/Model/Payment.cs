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
    /// Payment
    /// </summary>
    [DataContract(Name = "Payment")]
    public partial class Payment : IEquatable<Payment>, IValidatableObject
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
            /// Enum Authorised for value: authorised
            /// </summary>
            [EnumMember(Value = "authorised")]
            Authorised = 1,

            /// <summary>
            /// Enum Paid for value: paid
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid = 2,

            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 3,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 4

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
            /// Enum Receivable for value: accounts_receivable
            /// </summary>
            [EnumMember(Value = "accounts_receivable")]
            Receivable = 1,

            /// <summary>
            /// Enum Payable for value: accounts_payable
            /// </summary>
            [EnumMember(Value = "accounts_payable")]
            Payable = 2,

            /// <summary>
            /// Enum ReceivableCredit for value: accounts_receivable_credit
            /// </summary>
            [EnumMember(Value = "accounts_receivable_credit")]
            ReceivableCredit = 3,

            /// <summary>
            /// Enum PayableCredit for value: accounts_payable_credit
            /// </summary>
            [EnumMember(Value = "accounts_payable_credit")]
            PayableCredit = 4,

            /// <summary>
            /// Enum ReceivableOverpayment for value: accounts_receivable_overpayment
            /// </summary>
            [EnumMember(Value = "accounts_receivable_overpayment")]
            ReceivableOverpayment = 5,

            /// <summary>
            /// Enum PayableOverpayment for value: accounts_payable_overpayment
            /// </summary>
            [EnumMember(Value = "accounts_payable_overpayment")]
            PayableOverpayment = 6,

            /// <summary>
            /// Enum ReceivablePrepayment for value: accounts_receivable_prepayment
            /// </summary>
            [EnumMember(Value = "accounts_receivable_prepayment")]
            ReceivablePrepayment = 7,

            /// <summary>
            /// Enum PayablePrepayment for value: accounts_payable_prepayment
            /// </summary>
            [EnumMember(Value = "accounts_payable_prepayment")]
            PayablePrepayment = 8

        }


        /// <summary>
        /// Type of payment
        /// </summary>
        /// <value>Type of payment</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="currencyRate">Currency Exchange Rate at the time entity was recorded/generated..</param>
        /// <param name="totalAmount">Amount of payment (required).</param>
        /// <param name="reference">Optional payment reference message ie: Debit remittance detail..</param>
        /// <param name="paymentMethod">Payment method.</param>
        /// <param name="paymentMethodReference">Optional reference message returned by payment method on processing.</param>
        /// <param name="accountsReceivableAccountType">Type of accounts receivable account..</param>
        /// <param name="accountsReceivableAccountId">Unique identifier for the account to allocate payment to..</param>
        /// <param name="account">account.</param>
        /// <param name="transactionDate">Date transaction was entered - YYYY:MM::DDThh:mm:ss.sTZD (required).</param>
        /// <param name="customer">customer.</param>
        /// <param name="reconciled">Payment has been reconciled.</param>
        /// <param name="status">Status of payment.</param>
        /// <param name="type">Type of payment.</param>
        /// <param name="allocations">allocations.</param>
        /// <param name="note">Optional note to be associated with the payment..</param>
        /// <param name="rowVersion">rowVersion.</param>
        public Payment(Currency? currency = default(Currency?), decimal? currencyRate = default(decimal?), decimal totalAmount = default(decimal), string reference = default(string), string paymentMethod = default(string), string paymentMethodReference = default(string), string accountsReceivableAccountType = default(string), string accountsReceivableAccountId = default(string), LinkedLedgerAccount account = default(LinkedLedgerAccount), DateTime transactionDate = default(DateTime), LinkedCustomer customer = default(LinkedCustomer), bool reconciled = default(bool), StatusEnum? status = default(StatusEnum?), TypeEnum? type = default(TypeEnum?), List<Object> allocations = default(List<Object>), string note = default(string), string rowVersion = default(string))
        {
            this.TotalAmount = totalAmount;
            this.TransactionDate = transactionDate;
            this.Currency = currency;
            this.CurrencyRate = currencyRate;
            this.Reference = reference;
            this.PaymentMethod = paymentMethod;
            this.PaymentMethodReference = paymentMethodReference;
            this.AccountsReceivableAccountType = accountsReceivableAccountType;
            this.AccountsReceivableAccountId = accountsReceivableAccountId;
            this.Account = account;
            this.Customer = customer;
            this.Reconciled = reconciled;
            this.Status = status;
            this.Type = type;
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
        /// Currency Exchange Rate at the time entity was recorded/generated.
        /// </summary>
        /// <value>Currency Exchange Rate at the time entity was recorded/generated.</value>
        [DataMember(Name = "currency_rate", EmitDefaultValue = true)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Amount of payment
        /// </summary>
        /// <value>Amount of payment</value>
        [DataMember(Name = "total_amount", IsRequired = true, EmitDefaultValue = false)]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Optional payment reference message ie: Debit remittance detail.
        /// </summary>
        /// <value>Optional payment reference message ie: Debit remittance detail.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Payment method
        /// </summary>
        /// <value>Payment method</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Optional reference message returned by payment method on processing
        /// </summary>
        /// <value>Optional reference message returned by payment method on processing</value>
        [DataMember(Name = "payment_method_reference", EmitDefaultValue = true)]
        public string PaymentMethodReference { get; set; }

        /// <summary>
        /// Type of accounts receivable account.
        /// </summary>
        /// <value>Type of accounts receivable account.</value>
        [DataMember(Name = "accounts_receivable_account_type", EmitDefaultValue = true)]
        [Obsolete]
        public string AccountsReceivableAccountType { get; set; }

        /// <summary>
        /// Unique identifier for the account to allocate payment to.
        /// </summary>
        /// <value>Unique identifier for the account to allocate payment to.</value>
        [DataMember(Name = "accounts_receivable_account_id", EmitDefaultValue = true)]
        [Obsolete]
        public string AccountsReceivableAccountId { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public LinkedLedgerAccount Account { get; set; }

        /// <summary>
        /// Date transaction was entered - YYYY:MM::DDThh:mm:ss.sTZD
        /// </summary>
        /// <value>Date transaction was entered - YYYY:MM::DDThh:mm:ss.sTZD</value>
        [DataMember(Name = "transaction_date", IsRequired = true, EmitDefaultValue = false)]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = true)]
        public LinkedCustomer Customer { get; set; }

        /// <summary>
        /// Payment has been reconciled
        /// </summary>
        /// <value>Payment has been reconciled</value>
        [DataMember(Name = "reconciled", EmitDefaultValue = true)]
        public bool Reconciled { get; set; }

        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name = "allocations", EmitDefaultValue = false)]
        public List<Object> Allocations { get; set; }

        /// <summary>
        /// Optional note to be associated with the payment.
        /// </summary>
        /// <value>Optional note to be associated with the payment.</value>
        [DataMember(Name = "note", EmitDefaultValue = true)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets RowVersion
        /// </summary>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentMethodReference: ").Append(PaymentMethodReference).Append("\n");
            sb.Append("  AccountsReceivableAccountType: ").Append(AccountsReceivableAccountType).Append("\n");
            sb.Append("  AccountsReceivableAccountId: ").Append(AccountsReceivableAccountId).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Reconciled: ").Append(Reconciled).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
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
                    this.TotalAmount.Equals(input.TotalAmount)
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
                    this.AccountsReceivableAccountType == input.AccountsReceivableAccountType ||
                    (this.AccountsReceivableAccountType != null &&
                    this.AccountsReceivableAccountType.Equals(input.AccountsReceivableAccountType))
                ) && 
                (
                    this.AccountsReceivableAccountId == input.AccountsReceivableAccountId ||
                    (this.AccountsReceivableAccountId != null &&
                    this.AccountsReceivableAccountId.Equals(input.AccountsReceivableAccountId))
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
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.Reconciled == input.Reconciled ||
                    this.Reconciled.Equals(input.Reconciled)
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
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
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
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.CurrencyRate != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyRate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
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
                if (this.AccountsReceivableAccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountsReceivableAccountType.GetHashCode();
                }
                if (this.AccountsReceivableAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountsReceivableAccountId.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.TransactionDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDate.GetHashCode();
                }
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Reconciled.GetHashCode();
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
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
