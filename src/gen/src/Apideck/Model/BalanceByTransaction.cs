/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.9.1
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
    /// BalanceByTransaction
    /// </summary>
    [DataContract(Name = "BalanceByTransaction")]
    public partial class BalanceByTransaction : IEquatable<BalanceByTransaction>, IValidatableObject
    {
        /// <summary>
        /// Type of the transaction.
        /// </summary>
        /// <value>Type of the transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionTypeEnum
        {
            /// <summary>
            /// Enum Invoice for value: invoice
            /// </summary>
            [EnumMember(Value = "invoice")]
            Invoice = 1,

            /// <summary>
            /// Enum CreditNote for value: credit_note
            /// </summary>
            [EnumMember(Value = "credit_note")]
            CreditNote = 2,

            /// <summary>
            /// Enum Bill for value: bill
            /// </summary>
            [EnumMember(Value = "bill")]
            Bill = 3,

            /// <summary>
            /// Enum Payment for value: payment
            /// </summary>
            [EnumMember(Value = "payment")]
            Payment = 4,

            /// <summary>
            /// Enum BillPayment for value: bill_payment
            /// </summary>
            [EnumMember(Value = "bill_payment")]
            BillPayment = 5

        }


        /// <summary>
        /// Type of the transaction.
        /// </summary>
        /// <value>Type of the transaction.</value>
        [DataMember(Name = "transaction_type", EmitDefaultValue = false)]
        public TransactionTypeEnum? TransactionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceByTransaction" /> class.
        /// </summary>
        /// <param name="transactionId">Unique identifier for the transaction..</param>
        /// <param name="transactionDate">Date of the transaction..</param>
        /// <param name="transactionType">Type of the transaction..</param>
        /// <param name="dueDate">Due date of the transaction..</param>
        /// <param name="originalAmount">Original amount of the transaction..</param>
        /// <param name="outstandingBalance">Outstanding balance of the transaction..</param>
        /// <param name="transactionNumber">Transaction number of the transaction..</param>
        public BalanceByTransaction(string transactionId = default(string), DateTime transactionDate = default(DateTime), TransactionTypeEnum? transactionType = default(TransactionTypeEnum?), DateTime dueDate = default(DateTime), decimal originalAmount = default(decimal), decimal outstandingBalance = default(decimal), string transactionNumber = default(string))
        {
            this.TransactionId = transactionId;
            this.TransactionDate = transactionDate;
            this.TransactionType = transactionType;
            this.DueDate = dueDate;
            this.OriginalAmount = originalAmount;
            this.OutstandingBalance = outstandingBalance;
            this.TransactionNumber = transactionNumber;
        }

        /// <summary>
        /// Unique identifier for the transaction.
        /// </summary>
        /// <value>Unique identifier for the transaction.</value>
        [DataMember(Name = "transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Date of the transaction.
        /// </summary>
        /// <value>Date of the transaction.</value>
        [DataMember(Name = "transaction_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Due date of the transaction.
        /// </summary>
        /// <value>Due date of the transaction.</value>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Original amount of the transaction.
        /// </summary>
        /// <value>Original amount of the transaction.</value>
        [DataMember(Name = "original_amount", EmitDefaultValue = false)]
        public decimal OriginalAmount { get; set; }

        /// <summary>
        /// Outstanding balance of the transaction.
        /// </summary>
        /// <value>Outstanding balance of the transaction.</value>
        [DataMember(Name = "outstanding_balance", EmitDefaultValue = false)]
        public decimal OutstandingBalance { get; set; }

        /// <summary>
        /// Transaction number of the transaction.
        /// </summary>
        /// <value>Transaction number of the transaction.</value>
        [DataMember(Name = "transaction_number", EmitDefaultValue = false)]
        public string TransactionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceByTransaction {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  OriginalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  OutstandingBalance: ").Append(OutstandingBalance).Append("\n");
            sb.Append("  TransactionNumber: ").Append(TransactionNumber).Append("\n");
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
            return this.Equals(input as BalanceByTransaction);
        }

        /// <summary>
        /// Returns true if BalanceByTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceByTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceByTransaction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    this.TransactionType.Equals(input.TransactionType)
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.OriginalAmount == input.OriginalAmount ||
                    this.OriginalAmount.Equals(input.OriginalAmount)
                ) && 
                (
                    this.OutstandingBalance == input.OutstandingBalance ||
                    this.OutstandingBalance.Equals(input.OutstandingBalance)
                ) && 
                (
                    this.TransactionNumber == input.TransactionNumber ||
                    (this.TransactionNumber != null &&
                    this.TransactionNumber.Equals(input.TransactionNumber))
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
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.TransactionDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransactionType.GetHashCode();
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OriginalAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.OutstandingBalance.GetHashCode();
                if (this.TransactionNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionNumber.GetHashCode();
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
