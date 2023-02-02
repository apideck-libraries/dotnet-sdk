/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.87.0
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
    /// A card&#39;s non-confidential details.
    /// </summary>
    [DataContract(Name = "PaymentCard")]
    public partial class PaymentCard : IEquatable<PaymentCard>, IValidatableObject
    {
        /// <summary>
        /// The first six digits of the card number, known as the Bank Identification Number (BIN).
        /// </summary>
        /// <value>The first six digits of the card number, known as the Bank Identification Number (BIN).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardBrandEnum
        {
            /// <summary>
            /// Enum Visa for value: visa
            /// </summary>
            [EnumMember(Value = "visa")]
            Visa = 1,

            /// <summary>
            /// Enum Mastercard for value: mastercard
            /// </summary>
            [EnumMember(Value = "mastercard")]
            Mastercard = 2,

            /// <summary>
            /// Enum Amex for value: amex
            /// </summary>
            [EnumMember(Value = "amex")]
            Amex = 3,

            /// <summary>
            /// Enum Discover for value: discover
            /// </summary>
            [EnumMember(Value = "discover")]
            Discover = 4,

            /// <summary>
            /// Enum DiscoverDiners for value: discover-diners
            /// </summary>
            [EnumMember(Value = "discover-diners")]
            DiscoverDiners = 5,

            /// <summary>
            /// Enum Jcb for value: jcb
            /// </summary>
            [EnumMember(Value = "jcb")]
            Jcb = 6,

            /// <summary>
            /// Enum ChinaUnionpay for value: china-unionpay
            /// </summary>
            [EnumMember(Value = "china-unionpay")]
            ChinaUnionpay = 7,

            /// <summary>
            /// Enum SquareGiftCard for value: square-gift-card
            /// </summary>
            [EnumMember(Value = "square-gift-card")]
            SquareGiftCard = 8,

            /// <summary>
            /// Enum SquareCapitalCard for value: square-capital-card
            /// </summary>
            [EnumMember(Value = "square-capital-card")]
            SquareCapitalCard = 9,

            /// <summary>
            /// Enum Interac for value: interac
            /// </summary>
            [EnumMember(Value = "interac")]
            Interac = 10,

            /// <summary>
            /// Enum Eftpos for value: eftpos
            /// </summary>
            [EnumMember(Value = "eftpos")]
            Eftpos = 11,

            /// <summary>
            /// Enum Felica for value: felica
            /// </summary>
            [EnumMember(Value = "felica")]
            Felica = 12,

            /// <summary>
            /// Enum Ebt for value: ebt
            /// </summary>
            [EnumMember(Value = "ebt")]
            Ebt = 13,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 14

        }


        /// <summary>
        /// The first six digits of the card number, known as the Bank Identification Number (BIN).
        /// </summary>
        /// <value>The first six digits of the card number, known as the Bank Identification Number (BIN).</value>
        [DataMember(Name = "card_brand", EmitDefaultValue = true)]
        public CardBrandEnum? CardBrand { get; set; }
        /// <summary>
        /// Defines CardType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardTypeEnum
        {
            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 1,

            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 2,

            /// <summary>
            /// Enum Prepaid for value: prepaid
            /// </summary>
            [EnumMember(Value = "prepaid")]
            Prepaid = 3,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4

        }


        /// <summary>
        /// Gets or Sets CardType
        /// </summary>
        [DataMember(Name = "card_type", EmitDefaultValue = true)]
        public CardTypeEnum? CardType { get; set; }
        /// <summary>
        /// Defines PrepaidType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrepaidTypeEnum
        {
            /// <summary>
            /// Enum NonPrepaid for value: non-prepaid
            /// </summary>
            [EnumMember(Value = "non-prepaid")]
            NonPrepaid = 1,

            /// <summary>
            /// Enum Prepaid for value: prepaid
            /// </summary>
            [EnumMember(Value = "prepaid")]
            Prepaid = 2,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 3

        }


        /// <summary>
        /// Gets or Sets PrepaidType
        /// </summary>
        [DataMember(Name = "prepaid_type", EmitDefaultValue = true)]
        public PrepaidTypeEnum? PrepaidType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCard" /> class.
        /// </summary>
        /// <param name="bin">The first six digits of the card number, known as the Bank Identification Number (BIN)..</param>
        /// <param name="cardBrand">The first six digits of the card number, known as the Bank Identification Number (BIN)..</param>
        /// <param name="cardType">cardType.</param>
        /// <param name="prepaidType">prepaidType.</param>
        /// <param name="cardholderName">cardholderName.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="expMonth">The expiration month of the associated card as an integer between 1 and 12..</param>
        /// <param name="expYear">The four-digit year of the card&#39;s expiration date..</param>
        /// <param name="fingerprint">fingerprint.</param>
        /// <param name="last4">last4.</param>
        /// <param name="enabled">Indicates whether or not a card can be used for payments..</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="referenceId">An optional user-defined reference ID that associates this record with another entity in an external system. For example, a customer ID from an external customer management system..</param>
        /// <param name="version">version.</param>
        public PaymentCard(string bin = default(string), CardBrandEnum? cardBrand = default(CardBrandEnum?), CardTypeEnum? cardType = default(CardTypeEnum?), PrepaidTypeEnum? prepaidType = default(PrepaidTypeEnum?), string cardholderName = default(string), string customerId = default(string), string merchantId = default(string), int? expMonth = default(int?), int? expYear = default(int?), string fingerprint = default(string), string last4 = default(string), bool? enabled = default(bool?), Address billingAddress = default(Address), string referenceId = default(string), string version = default(string))
        {
            this.Bin = bin;
            this.CardBrand = cardBrand;
            this.CardType = cardType;
            this.PrepaidType = prepaidType;
            this.CardholderName = cardholderName;
            this.CustomerId = customerId;
            this.MerchantId = merchantId;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Fingerprint = fingerprint;
            this.Last4 = last4;
            this.Enabled = enabled;
            this.BillingAddress = billingAddress;
            this.ReferenceId = referenceId;
            this._Version = version;
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
        /// The first six digits of the card number, known as the Bank Identification Number (BIN).
        /// </summary>
        /// <value>The first six digits of the card number, known as the Bank Identification Number (BIN).</value>
        [DataMember(Name = "bin", EmitDefaultValue = true)]
        public string Bin { get; set; }

        /// <summary>
        /// Gets or Sets CardholderName
        /// </summary>
        [DataMember(Name = "cardholder_name", EmitDefaultValue = true)]
        public string CardholderName { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name = "customer_id", EmitDefaultValue = true)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The expiration month of the associated card as an integer between 1 and 12.
        /// </summary>
        /// <value>The expiration month of the associated card as an integer between 1 and 12.</value>
        [DataMember(Name = "exp_month", EmitDefaultValue = true)]
        public int? ExpMonth { get; set; }

        /// <summary>
        /// The four-digit year of the card&#39;s expiration date.
        /// </summary>
        /// <value>The four-digit year of the card&#39;s expiration date.</value>
        [DataMember(Name = "exp_year", EmitDefaultValue = true)]
        public int? ExpYear { get; set; }

        /// <summary>
        /// Gets or Sets Fingerprint
        /// </summary>
        [DataMember(Name = "fingerprint", EmitDefaultValue = true)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        [DataMember(Name = "last_4", EmitDefaultValue = true)]
        public string Last4 { get; set; }

        /// <summary>
        /// Indicates whether or not a card can be used for payments.
        /// </summary>
        /// <value>Indicates whether or not a card can be used for payments.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billing_address", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// An optional user-defined reference ID that associates this record with another entity in an external system. For example, a customer ID from an external customer management system.
        /// </summary>
        /// <value>An optional user-defined reference ID that associates this record with another entity in an external system. For example, a customer ID from an external customer management system.</value>
        [DataMember(Name = "reference_id", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentCard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
            sb.Append("  CardBrand: ").Append(CardBrand).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  PrepaidType: ").Append(PrepaidType).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as PaymentCard);
        }

        /// <summary>
        /// Returns true if PaymentCard instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCard input)
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
                    this.Bin == input.Bin ||
                    (this.Bin != null &&
                    this.Bin.Equals(input.Bin))
                ) && 
                (
                    this.CardBrand == input.CardBrand ||
                    this.CardBrand.Equals(input.CardBrand)
                ) && 
                (
                    this.CardType == input.CardType ||
                    this.CardType.Equals(input.CardType)
                ) && 
                (
                    this.PrepaidType == input.PrepaidType ||
                    this.PrepaidType.Equals(input.PrepaidType)
                ) && 
                (
                    this.CardholderName == input.CardholderName ||
                    (this.CardholderName != null &&
                    this.CardholderName.Equals(input.CardholderName))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.ExpMonth == input.ExpMonth ||
                    (this.ExpMonth != null &&
                    this.ExpMonth.Equals(input.ExpMonth))
                ) && 
                (
                    this.ExpYear == input.ExpYear ||
                    (this.ExpYear != null &&
                    this.ExpYear.Equals(input.ExpYear))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.Last4 == input.Last4 ||
                    (this.Last4 != null &&
                    this.Last4.Equals(input.Last4))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.Bin != null)
                {
                    hashCode = (hashCode * 59) + this.Bin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CardBrand.GetHashCode();
                hashCode = (hashCode * 59) + this.CardType.GetHashCode();
                hashCode = (hashCode * 59) + this.PrepaidType.GetHashCode();
                if (this.CardholderName != null)
                {
                    hashCode = (hashCode * 59) + this.CardholderName.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.ExpMonth != null)
                {
                    hashCode = (hashCode * 59) + this.ExpMonth.GetHashCode();
                }
                if (this.ExpYear != null)
                {
                    hashCode = (hashCode * 59) + this.ExpYear.GetHashCode();
                }
                if (this.Fingerprint != null)
                {
                    hashCode = (hashCode * 59) + this.Fingerprint.GetHashCode();
                }
                if (this.Last4 != null)
                {
                    hashCode = (hashCode * 59) + this.Last4.GetHashCode();
                }
                if (this.Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                }
                if (this.ReferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceId.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
            // ExpMonth (int?) maximum
            if (this.ExpMonth > (int?)12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpMonth, must be a value less than or equal to 12.", new [] { "ExpMonth" });
            }

            // ExpMonth (int?) minimum
            if (this.ExpMonth < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpMonth, must be a value greater than or equal to 1.", new [] { "ExpMonth" });
            }

            yield break;
        }
    }

}
