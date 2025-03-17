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
    /// Expense
    /// </summary>
    [DataContract(Name = "Expense")]
    public partial class Expense : IEquatable<Expense>, IValidatableObject
    {
        /// <summary>
        /// The type of payment for the expense.
        /// </summary>
        /// <value>The type of payment for the expense.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum Cash for value: cash
            /// </summary>
            [EnumMember(Value = "cash")]
            Cash = 1,

            /// <summary>
            /// Enum Check for value: check
            /// </summary>
            [EnumMember(Value = "check")]
            Check = 2,

            /// <summary>
            /// Enum CreditCard for value: credit_card
            /// </summary>
            [EnumMember(Value = "credit_card")]
            CreditCard = 3

        }


        /// <summary>
        /// The type of payment for the expense.
        /// </summary>
        /// <value>The type of payment for the expense.</value>
        [DataMember(Name = "payment_type", EmitDefaultValue = true)]
        public PaymentTypeEnum? PaymentType { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// The type of expense.
        /// </summary>
        /// <value>The type of expense.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Expense for value: expense
            /// </summary>
            [EnumMember(Value = "expense")]
            Expense = 1,

            /// <summary>
            /// Enum Refund for value: refund
            /// </summary>
            [EnumMember(Value = "refund")]
            Refund = 2

        }


        /// <summary>
        /// The type of expense.
        /// </summary>
        /// <value>The type of expense.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Expense" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Expense() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Expense" /> class.
        /// </summary>
        /// <param name="number">Number..</param>
        /// <param name="transactionDate">The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD (required).</param>
        /// <param name="accountId">The unique identifier for the ledger account that this expense should be credited to.  (required).</param>
        /// <param name="customerId">The ID of the customer this entity is linked to. Used for expenses that should be marked as billable to customers..</param>
        /// <param name="supplierId">The ID of the supplier this entity is linked to..</param>
        /// <param name="companyId">The company or subsidiary id the transaction belongs to.</param>
        /// <param name="departmentId">The ID of the department this expense is linked to..</param>
        /// <param name="paymentType">The type of payment for the expense..</param>
        /// <param name="currency">currency.</param>
        /// <param name="currencyRate">Currency Exchange Rate at the time entity was recorded/generated..</param>
        /// <param name="type">The type of expense..</param>
        /// <param name="memo">The memo of the expense..</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="totalAmount">The total amount of the expense line item..</param>
        /// <param name="lineItems">Expense line items linked to this expense. (required).</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public Expense(string number = default(string), DateTime? transactionDate = default(DateTime?), string accountId = default(string), string customerId = default(string), string supplierId = default(string), string companyId = default(string), string departmentId = default(string), PaymentTypeEnum? paymentType = default(PaymentTypeEnum?), Currency? currency = default(Currency?), decimal? currencyRate = default(decimal?), TypeEnum? type = default(TypeEnum?), string memo = default(string), LinkedTaxRate taxRate = default(LinkedTaxRate), decimal? totalAmount = default(decimal?), List<ExpenseLineItem> lineItems = default(List<ExpenseLineItem>), List<CustomField> customFields = default(List<CustomField>), string rowVersion = default(string), List<Object> passThrough = default(List<Object>))
        {
            // to ensure "transactionDate" is required (not null)
            if (transactionDate == null) {
                throw new ArgumentNullException("transactionDate is a required property for Expense and cannot be null");
            }
            this.TransactionDate = transactionDate;
            // to ensure "accountId" is required (not null)
            if (accountId == null) {
                throw new ArgumentNullException("accountId is a required property for Expense and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "lineItems" is required (not null)
            if (lineItems == null) {
                throw new ArgumentNullException("lineItems is a required property for Expense and cannot be null");
            }
            this.LineItems = lineItems;
            this.Number = number;
            this.CustomerId = customerId;
            this.SupplierId = supplierId;
            this.CompanyId = companyId;
            this.DepartmentId = departmentId;
            this.PaymentType = paymentType;
            this.Currency = currency;
            this.CurrencyRate = currencyRate;
            this.Type = type;
            this.Memo = memo;
            this.TaxRate = taxRate;
            this.TotalAmount = totalAmount;
            this.CustomFields = customFields;
            this.RowVersion = rowVersion;
            this.PassThrough = passThrough;
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
        /// Number.
        /// </summary>
        /// <value>Number.</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD
        /// </summary>
        /// <value>The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD</value>
        [DataMember(Name = "transaction_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// The unique identifier for the ledger account that this expense should be credited to. 
        /// </summary>
        /// <value>The unique identifier for the ledger account that this expense should be credited to. </value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The ID of the customer this entity is linked to. Used for expenses that should be marked as billable to customers.
        /// </summary>
        /// <value>The ID of the customer this entity is linked to. Used for expenses that should be marked as billable to customers.</value>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The ID of the supplier this entity is linked to.
        /// </summary>
        /// <value>The ID of the supplier this entity is linked to.</value>
        [DataMember(Name = "supplier_id", EmitDefaultValue = false)]
        public string SupplierId { get; set; }

        /// <summary>
        /// The company or subsidiary id the transaction belongs to
        /// </summary>
        /// <value>The company or subsidiary id the transaction belongs to</value>
        [DataMember(Name = "company_id", EmitDefaultValue = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The ID of the department this expense is linked to.
        /// </summary>
        /// <value>The ID of the department this expense is linked to.</value>
        [DataMember(Name = "department_id", EmitDefaultValue = false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// Currency Exchange Rate at the time entity was recorded/generated.
        /// </summary>
        /// <value>Currency Exchange Rate at the time entity was recorded/generated.</value>
        [DataMember(Name = "currency_rate", EmitDefaultValue = true)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// The memo of the expense.
        /// </summary>
        /// <value>The memo of the expense.</value>
        [DataMember(Name = "memo", EmitDefaultValue = true)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public LinkedTaxRate TaxRate { get; set; }

        /// <summary>
        /// The total amount of the expense line item.
        /// </summary>
        /// <value>The total amount of the expense line item.</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = true)]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Expense line items linked to this expense.
        /// </summary>
        /// <value>Expense line items linked to this expense.</value>
        [DataMember(Name = "line_items", IsRequired = true, EmitDefaultValue = false)]
        public List<ExpenseLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public List<CustomField> CustomFields { get; set; }

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
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        /// <value>A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.</value>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

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
            sb.Append("class Expense {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
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
            return this.Equals(input as Expense);
        }

        /// <summary>
        /// Returns true if Expense instances are equal
        /// </summary>
        /// <param name="input">Instance of Expense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Expense input)
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
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.SupplierId == input.SupplierId ||
                    (this.SupplierId != null &&
                    this.SupplierId.Equals(input.SupplierId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    this.PaymentType.Equals(input.PaymentType)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
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
                ) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.TransactionDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDate.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.SupplierId != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierId.GetHashCode();
                }
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentType.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.CurrencyRate != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyRate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
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
