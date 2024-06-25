/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.6.2
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
    /// OrderTenders
    /// </summary>
    [DataContract(Name = "Order_tenders")]
    public partial class OrderTenders : IEquatable<OrderTenders>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Cash for value: cash
            /// </summary>
            [EnumMember(Value = "cash")]
            Cash = 1,

            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// The status of the card. Only applicable when the tender type is card.
        /// </summary>
        /// <value>The status of the card. Only applicable when the tender type is card.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardStatusEnum
        {
            /// <summary>
            /// Enum Authorized for value: authorized
            /// </summary>
            [EnumMember(Value = "authorized")]
            Authorized = 1,

            /// <summary>
            /// Enum Captured for value: captured
            /// </summary>
            [EnumMember(Value = "captured")]
            Captured = 2,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 3,

            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 4

        }


        /// <summary>
        /// The status of the card. Only applicable when the tender type is card.
        /// </summary>
        /// <value>The status of the card. Only applicable when the tender type is card.</value>
        [DataMember(Name = "card_status", EmitDefaultValue = true)]
        public CardStatusEnum? CardStatus { get; set; }
        /// <summary>
        /// The entry method of the card. Only applicable when the tender type is card.
        /// </summary>
        /// <value>The entry method of the card. Only applicable when the tender type is card.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardEntryMethodEnum
        {
            /// <summary>
            /// Enum Evm for value: evm
            /// </summary>
            [EnumMember(Value = "evm")]
            Evm = 1,

            /// <summary>
            /// Enum Swiped for value: swiped
            /// </summary>
            [EnumMember(Value = "swiped")]
            Swiped = 2,

            /// <summary>
            /// Enum Keyed for value: keyed
            /// </summary>
            [EnumMember(Value = "keyed")]
            Keyed = 3,

            /// <summary>
            /// Enum OnFile for value: on-file
            /// </summary>
            [EnumMember(Value = "on-file")]
            OnFile = 4,

            /// <summary>
            /// Enum Contactless for value: contactless
            /// </summary>
            [EnumMember(Value = "contactless")]
            Contactless = 5

        }


        /// <summary>
        /// The entry method of the card. Only applicable when the tender type is card.
        /// </summary>
        /// <value>The entry method of the card. Only applicable when the tender type is card.</value>
        [DataMember(Name = "card_entry_method", EmitDefaultValue = true)]
        public CardEntryMethodEnum? CardEntryMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTenders" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="note">note.</param>
        /// <param name="amount">amount.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="currency">currency.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="totalTip">totalTip.</param>
        /// <param name="totalProcessingFee">totalProcessingFee.</param>
        /// <param name="totalTax">totalTax.</param>
        /// <param name="totalDiscount">totalDiscount.</param>
        /// <param name="totalRefund">totalRefund.</param>
        /// <param name="totalServiceCharge">totalServiceCharge.</param>
        /// <param name="buyerTenderedCashAmount">The amount (in cents) of cash tendered by the buyer. Only applicable when the tender type is cash..</param>
        /// <param name="changeBackCashAmount">The amount (in cents) of cash returned to the buyer. Only applicable when the tender type is cash..</param>
        /// <param name="card">card.</param>
        /// <param name="cardStatus">The status of the card. Only applicable when the tender type is card..</param>
        /// <param name="cardEntryMethod">The entry method of the card. Only applicable when the tender type is card..</param>
        public OrderTenders(string name = default(string), TypeEnum? type = default(TypeEnum?), string note = default(string), decimal amount = default(decimal), decimal percentage = default(decimal), Currency? currency = default(Currency?), int? totalAmount = default(int?), int? totalTip = default(int?), int? totalProcessingFee = default(int?), int? totalTax = default(int?), int? totalDiscount = default(int?), int? totalRefund = default(int?), int? totalServiceCharge = default(int?), int? buyerTenderedCashAmount = default(int?), int? changeBackCashAmount = default(int?), PaymentCard card = default(PaymentCard), CardStatusEnum? cardStatus = default(CardStatusEnum?), CardEntryMethodEnum? cardEntryMethod = default(CardEntryMethodEnum?))
        {
            this.Name = name;
            this.Type = type;
            this.Note = note;
            this.Amount = amount;
            this.Percentage = percentage;
            this.Currency = currency;
            this.TotalAmount = totalAmount;
            this.TotalTip = totalTip;
            this.TotalProcessingFee = totalProcessingFee;
            this.TotalTax = totalTax;
            this.TotalDiscount = totalDiscount;
            this.TotalRefund = totalRefund;
            this.TotalServiceCharge = totalServiceCharge;
            this.BuyerTenderedCashAmount = buyerTenderedCashAmount;
            this.ChangeBackCashAmount = changeBackCashAmount;
            this.Card = card;
            this.CardStatus = cardStatus;
            this.CardEntryMethod = cardEntryMethod;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public decimal Percentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name = "total_amount", EmitDefaultValue = true)]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalTip
        /// </summary>
        [DataMember(Name = "total_tip", EmitDefaultValue = true)]
        public int? TotalTip { get; set; }

        /// <summary>
        /// Gets or Sets TotalProcessingFee
        /// </summary>
        [DataMember(Name = "total_processing_fee", EmitDefaultValue = true)]
        public int? TotalProcessingFee { get; set; }

        /// <summary>
        /// Gets or Sets TotalTax
        /// </summary>
        [DataMember(Name = "total_tax", EmitDefaultValue = true)]
        public int? TotalTax { get; set; }

        /// <summary>
        /// Gets or Sets TotalDiscount
        /// </summary>
        [DataMember(Name = "total_discount", EmitDefaultValue = true)]
        public int? TotalDiscount { get; set; }

        /// <summary>
        /// Gets or Sets TotalRefund
        /// </summary>
        [DataMember(Name = "total_refund", EmitDefaultValue = true)]
        public int? TotalRefund { get; set; }

        /// <summary>
        /// Gets or Sets TotalServiceCharge
        /// </summary>
        [DataMember(Name = "total_service_charge", EmitDefaultValue = true)]
        public int? TotalServiceCharge { get; set; }

        /// <summary>
        /// The amount (in cents) of cash tendered by the buyer. Only applicable when the tender type is cash.
        /// </summary>
        /// <value>The amount (in cents) of cash tendered by the buyer. Only applicable when the tender type is cash.</value>
        [DataMember(Name = "buyer_tendered_cash_amount", EmitDefaultValue = true)]
        public int? BuyerTenderedCashAmount { get; set; }

        /// <summary>
        /// The amount (in cents) of cash returned to the buyer. Only applicable when the tender type is cash.
        /// </summary>
        /// <value>The amount (in cents) of cash returned to the buyer. Only applicable when the tender type is cash.</value>
        [DataMember(Name = "change_back_cash_amount", EmitDefaultValue = true)]
        public int? ChangeBackCashAmount { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = true)]
        public PaymentCard Card { get; set; }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "payment_id", EmitDefaultValue = false)]
        public string PaymentId { get; private set; }

        /// <summary>
        /// Returns false as PaymentId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentId()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "location_id", EmitDefaultValue = false)]
        public string LocationId { get; private set; }

        /// <summary>
        /// Returns false as LocationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLocationId()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; private set; }

        /// <summary>
        /// Returns false as TransactionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionId()
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
            sb.Append("class OrderTenders {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TotalTip: ").Append(TotalTip).Append("\n");
            sb.Append("  TotalProcessingFee: ").Append(TotalProcessingFee).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  TotalRefund: ").Append(TotalRefund).Append("\n");
            sb.Append("  TotalServiceCharge: ").Append(TotalServiceCharge).Append("\n");
            sb.Append("  BuyerTenderedCashAmount: ").Append(BuyerTenderedCashAmount).Append("\n");
            sb.Append("  ChangeBackCashAmount: ").Append(ChangeBackCashAmount).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  CardStatus: ").Append(CardStatus).Append("\n");
            sb.Append("  CardEntryMethod: ").Append(CardEntryMethod).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as OrderTenders);
        }

        /// <summary>
        /// Returns true if OrderTenders instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderTenders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderTenders input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.TotalTip == input.TotalTip ||
                    (this.TotalTip != null &&
                    this.TotalTip.Equals(input.TotalTip))
                ) && 
                (
                    this.TotalProcessingFee == input.TotalProcessingFee ||
                    (this.TotalProcessingFee != null &&
                    this.TotalProcessingFee.Equals(input.TotalProcessingFee))
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    (this.TotalTax != null &&
                    this.TotalTax.Equals(input.TotalTax))
                ) && 
                (
                    this.TotalDiscount == input.TotalDiscount ||
                    (this.TotalDiscount != null &&
                    this.TotalDiscount.Equals(input.TotalDiscount))
                ) && 
                (
                    this.TotalRefund == input.TotalRefund ||
                    (this.TotalRefund != null &&
                    this.TotalRefund.Equals(input.TotalRefund))
                ) && 
                (
                    this.TotalServiceCharge == input.TotalServiceCharge ||
                    (this.TotalServiceCharge != null &&
                    this.TotalServiceCharge.Equals(input.TotalServiceCharge))
                ) && 
                (
                    this.BuyerTenderedCashAmount == input.BuyerTenderedCashAmount ||
                    (this.BuyerTenderedCashAmount != null &&
                    this.BuyerTenderedCashAmount.Equals(input.BuyerTenderedCashAmount))
                ) && 
                (
                    this.ChangeBackCashAmount == input.ChangeBackCashAmount ||
                    (this.ChangeBackCashAmount != null &&
                    this.ChangeBackCashAmount.Equals(input.ChangeBackCashAmount))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.CardStatus == input.CardStatus ||
                    this.CardStatus.Equals(input.CardStatus)
                ) && 
                (
                    this.CardEntryMethod == input.CardEntryMethod ||
                    this.CardEntryMethod.Equals(input.CardEntryMethod)
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.Percentage.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.TotalTip != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTip.GetHashCode();
                }
                if (this.TotalProcessingFee != null)
                {
                    hashCode = (hashCode * 59) + this.TotalProcessingFee.GetHashCode();
                }
                if (this.TotalTax != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTax.GetHashCode();
                }
                if (this.TotalDiscount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalDiscount.GetHashCode();
                }
                if (this.TotalRefund != null)
                {
                    hashCode = (hashCode * 59) + this.TotalRefund.GetHashCode();
                }
                if (this.TotalServiceCharge != null)
                {
                    hashCode = (hashCode * 59) + this.TotalServiceCharge.GetHashCode();
                }
                if (this.BuyerTenderedCashAmount != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerTenderedCashAmount.GetHashCode();
                }
                if (this.ChangeBackCashAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ChangeBackCashAmount.GetHashCode();
                }
                if (this.Card != null)
                {
                    hashCode = (hashCode * 59) + this.Card.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CardStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.CardEntryMethod.GetHashCode();
                if (this.PaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentId.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
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
