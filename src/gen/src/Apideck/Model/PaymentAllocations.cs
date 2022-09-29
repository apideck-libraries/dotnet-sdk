/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.64.0
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
    /// PaymentAllocations
    /// </summary>
    [DataContract(Name = "Payment_allocations")]
    public partial class PaymentAllocations : IEquatable<PaymentAllocations>, IValidatableObject
    {
        /// <summary>
        /// Type of entity this payment should be attributed to.
        /// </summary>
        /// <value>Type of entity this payment should be attributed to.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Invoice for value: invoice
            /// </summary>
            [EnumMember(Value = "invoice")]
            Invoice = 1,

            /// <summary>
            /// Enum Order for value: order
            /// </summary>
            [EnumMember(Value = "order")]
            Order = 2,

            /// <summary>
            /// Enum Expense for value: expense
            /// </summary>
            [EnumMember(Value = "expense")]
            Expense = 3,

            /// <summary>
            /// Enum CreditMemo for value: credit_memo
            /// </summary>
            [EnumMember(Value = "credit_memo")]
            CreditMemo = 4,

            /// <summary>
            /// Enum OverPayment for value: over_payment
            /// </summary>
            [EnumMember(Value = "over_payment")]
            OverPayment = 5,

            /// <summary>
            /// Enum PrePayment for value: pre_payment
            /// </summary>
            [EnumMember(Value = "pre_payment")]
            PrePayment = 6

        }


        /// <summary>
        /// Type of entity this payment should be attributed to.
        /// </summary>
        /// <value>Type of entity this payment should be attributed to.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAllocations" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of entity this payment should be attributed to..</param>
        /// <param name="type">Type of entity this payment should be attributed to..</param>
        /// <param name="amount">Amount of payment that should be attributed to this allocation. If null, the total_amount will be used..</param>
        public PaymentAllocations(string id = default(string), TypeEnum? type = default(TypeEnum?), decimal? amount = default(decimal?))
        {
            this.Id = id;
            this.Type = type;
            this.Amount = amount;
        }

        /// <summary>
        /// Unique identifier of entity this payment should be attributed to.
        /// </summary>
        /// <value>Unique identifier of entity this payment should be attributed to.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; private set; }

        /// <summary>
        /// Returns false as Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCode()
        {
            return false;
        }
        /// <summary>
        /// Amount of payment that should be attributed to this allocation. If null, the total_amount will be used.
        /// </summary>
        /// <value>Amount of payment that should be attributed to this allocation. If null, the total_amount will be used.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentAllocations {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as PaymentAllocations);
        }

        /// <summary>
        /// Returns true if PaymentAllocations instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAllocations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAllocations input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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