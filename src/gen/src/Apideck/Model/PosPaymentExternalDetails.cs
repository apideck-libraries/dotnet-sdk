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
    /// Details about an external payment.
    /// </summary>
    [DataContract(Name = "PosPayment_external_details")]
    public partial class PosPaymentExternalDetails : IEquatable<PosPaymentExternalDetails>, IValidatableObject
    {
        /// <summary>
        /// The type of external payment the seller received. It can be one of the following: - CHECK - Paid using a physical check. - BANK_TRANSFER - Paid using external bank transfer. - OTHER\\_GIFT\\_CARD - Paid using a non-Square gift card. - CRYPTO - Paid using a crypto currency. - SQUARE_CASH - Paid using Square Cash App. - SOCIAL - Paid using peer-to-peer payment applications. - EXTERNAL - A third-party application gathered this payment outside of Square. - EMONEY - Paid using an E-money provider. - CARD - A credit or debit card that Square does not support. - STORED_BALANCE - Use for house accounts, store credit, and so forth. - FOOD_VOUCHER - Restaurant voucher provided by employers to employees to pay for meals - OTHER - A type not listed here.
        /// </summary>
        /// <value>The type of external payment the seller received. It can be one of the following: - CHECK - Paid using a physical check. - BANK_TRANSFER - Paid using external bank transfer. - OTHER\\_GIFT\\_CARD - Paid using a non-Square gift card. - CRYPTO - Paid using a crypto currency. - SQUARE_CASH - Paid using Square Cash App. - SOCIAL - Paid using peer-to-peer payment applications. - EXTERNAL - A third-party application gathered this payment outside of Square. - EMONEY - Paid using an E-money provider. - CARD - A credit or debit card that Square does not support. - STORED_BALANCE - Use for house accounts, store credit, and so forth. - FOOD_VOUCHER - Restaurant voucher provided by employers to employees to pay for meals - OTHER - A type not listed here.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Check for value: check
            /// </summary>
            [EnumMember(Value = "check")]
            Check = 1,

            /// <summary>
            /// Enum BankTransfer for value: bank_transfer
            /// </summary>
            [EnumMember(Value = "bank_transfer")]
            BankTransfer = 2,

            /// <summary>
            /// Enum OtherGiftCard for value: other_gift_card
            /// </summary>
            [EnumMember(Value = "other_gift_card")]
            OtherGiftCard = 3,

            /// <summary>
            /// Enum Crypto for value: crypto
            /// </summary>
            [EnumMember(Value = "crypto")]
            Crypto = 4,

            /// <summary>
            /// Enum SquareCash for value: square_cash
            /// </summary>
            [EnumMember(Value = "square_cash")]
            SquareCash = 5,

            /// <summary>
            /// Enum Social for value: social
            /// </summary>
            [EnumMember(Value = "social")]
            Social = 6,

            /// <summary>
            /// Enum External for value: external
            /// </summary>
            [EnumMember(Value = "external")]
            External = 7,

            /// <summary>
            /// Enum Emoney for value: emoney
            /// </summary>
            [EnumMember(Value = "emoney")]
            Emoney = 8,

            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 9,

            /// <summary>
            /// Enum StoredBalance for value: stored_balance
            /// </summary>
            [EnumMember(Value = "stored_balance")]
            StoredBalance = 10,

            /// <summary>
            /// Enum FoodVoucher for value: food_voucher
            /// </summary>
            [EnumMember(Value = "food_voucher")]
            FoodVoucher = 11,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 12

        }


        /// <summary>
        /// The type of external payment the seller received. It can be one of the following: - CHECK - Paid using a physical check. - BANK_TRANSFER - Paid using external bank transfer. - OTHER\\_GIFT\\_CARD - Paid using a non-Square gift card. - CRYPTO - Paid using a crypto currency. - SQUARE_CASH - Paid using Square Cash App. - SOCIAL - Paid using peer-to-peer payment applications. - EXTERNAL - A third-party application gathered this payment outside of Square. - EMONEY - Paid using an E-money provider. - CARD - A credit or debit card that Square does not support. - STORED_BALANCE - Use for house accounts, store credit, and so forth. - FOOD_VOUCHER - Restaurant voucher provided by employers to employees to pay for meals - OTHER - A type not listed here.
        /// </summary>
        /// <value>The type of external payment the seller received. It can be one of the following: - CHECK - Paid using a physical check. - BANK_TRANSFER - Paid using external bank transfer. - OTHER\\_GIFT\\_CARD - Paid using a non-Square gift card. - CRYPTO - Paid using a crypto currency. - SQUARE_CASH - Paid using Square Cash App. - SOCIAL - Paid using peer-to-peer payment applications. - EXTERNAL - A third-party application gathered this payment outside of Square. - EMONEY - Paid using an E-money provider. - CARD - A credit or debit card that Square does not support. - STORED_BALANCE - Use for house accounts, store credit, and so forth. - FOOD_VOUCHER - Restaurant voucher provided by employers to employees to pay for meals - OTHER - A type not listed here.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PosPaymentExternalDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PosPaymentExternalDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PosPaymentExternalDetails" /> class.
        /// </summary>
        /// <param name="type">The type of external payment the seller received. It can be one of the following: - CHECK - Paid using a physical check. - BANK_TRANSFER - Paid using external bank transfer. - OTHER\\_GIFT\\_CARD - Paid using a non-Square gift card. - CRYPTO - Paid using a crypto currency. - SQUARE_CASH - Paid using Square Cash App. - SOCIAL - Paid using peer-to-peer payment applications. - EXTERNAL - A third-party application gathered this payment outside of Square. - EMONEY - Paid using an E-money provider. - CARD - A credit or debit card that Square does not support. - STORED_BALANCE - Use for house accounts, store credit, and so forth. - FOOD_VOUCHER - Restaurant voucher provided by employers to employees to pay for meals - OTHER - A type not listed here. (required).</param>
        /// <param name="source">A description of the external payment source. For example,  \&quot;Food Delivery Service\&quot;. (required).</param>
        /// <param name="sourceId">An ID to associate the payment to its originating source..</param>
        /// <param name="sourceFeeAmount">The fees paid to the source. The amount minus this field is the net amount seller receives..</param>
        public PosPaymentExternalDetails(TypeEnum type = default(TypeEnum), string source = default(string), string sourceId = default(string), decimal sourceFeeAmount = default(decimal))
        {
            this.Type = type;
            // to ensure "source" is required (not null)
            if (source == null) {
                throw new ArgumentNullException("source is a required property for PosPaymentExternalDetails and cannot be null");
            }
            this.Source = source;
            this.SourceId = sourceId;
            this.SourceFeeAmount = sourceFeeAmount;
        }

        /// <summary>
        /// A description of the external payment source. For example,  \&quot;Food Delivery Service\&quot;.
        /// </summary>
        /// <value>A description of the external payment source. For example,  \&quot;Food Delivery Service\&quot;.</value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// An ID to associate the payment to its originating source.
        /// </summary>
        /// <value>An ID to associate the payment to its originating source.</value>
        [DataMember(Name = "source_id", EmitDefaultValue = false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The fees paid to the source. The amount minus this field is the net amount seller receives.
        /// </summary>
        /// <value>The fees paid to the source. The amount minus this field is the net amount seller receives.</value>
        [DataMember(Name = "source_fee_amount", EmitDefaultValue = false)]
        public decimal SourceFeeAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PosPaymentExternalDetails {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceFeeAmount: ").Append(SourceFeeAmount).Append("\n");
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
            return this.Equals(input as PosPaymentExternalDetails);
        }

        /// <summary>
        /// Returns true if PosPaymentExternalDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PosPaymentExternalDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PosPaymentExternalDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.SourceFeeAmount == input.SourceFeeAmount ||
                    this.SourceFeeAmount.Equals(input.SourceFeeAmount)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SourceFeeAmount.GetHashCode();
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
            // Source (string) maxLength
            if (this.Source != null && this.Source.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Source, length must be less than 255.", new [] { "Source" });
            }

            // SourceId (string) maxLength
            if (this.SourceId != null && this.SourceId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceId, length must be less than 255.", new [] { "SourceId" });
            }

            yield break;
        }
    }

}
