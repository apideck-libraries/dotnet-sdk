/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.47.0
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
    /// LedgerAccount
    /// </summary>
    [DataContract(Name = "LedgerAccount")]
    public partial class LedgerAccount : Dictionary<String, Object>, IEquatable<LedgerAccount>, IValidatableObject
    {
        /// <summary>
        /// The classification of account.
        /// </summary>
        /// <value>The classification of account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClassificationEnum
        {
            /// <summary>
            /// Enum Asset for value: asset
            /// </summary>
            [EnumMember(Value = "asset")]
            Asset = 1,

            /// <summary>
            /// Enum Equity for value: equity
            /// </summary>
            [EnumMember(Value = "equity")]
            Equity = 2,

            /// <summary>
            /// Enum Expense for value: expense
            /// </summary>
            [EnumMember(Value = "expense")]
            Expense = 3,

            /// <summary>
            /// Enum Liability for value: liability
            /// </summary>
            [EnumMember(Value = "liability")]
            Liability = 4,

            /// <summary>
            /// Enum Revenue for value: revenue
            /// </summary>
            [EnumMember(Value = "revenue")]
            Revenue = 5,

            /// <summary>
            /// Enum Income for value: income
            /// </summary>
            [EnumMember(Value = "income")]
            Income = 6,

            /// <summary>
            /// Enum OtherIncome for value: other_income
            /// </summary>
            [EnumMember(Value = "other_income")]
            OtherIncome = 7,

            /// <summary>
            /// Enum OtherExpense for value: other_expense
            /// </summary>
            [EnumMember(Value = "other_expense")]
            OtherExpense = 8,

            /// <summary>
            /// Enum CostsOfSales for value: costs_of_sales
            /// </summary>
            [EnumMember(Value = "costs_of_sales")]
            CostsOfSales = 9

        }


        /// <summary>
        /// The classification of account.
        /// </summary>
        /// <value>The classification of account.</value>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public ClassificationEnum? Classification { get; set; }
        /// <summary>
        /// The type of account.
        /// </summary>
        /// <value>The type of account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AccountsReceivable for value: accounts_receivable
            /// </summary>
            [EnumMember(Value = "accounts_receivable")]
            AccountsReceivable = 1,

            /// <summary>
            /// Enum Revenue for value: revenue
            /// </summary>
            [EnumMember(Value = "revenue")]
            Revenue = 2,

            /// <summary>
            /// Enum Sales for value: sales
            /// </summary>
            [EnumMember(Value = "sales")]
            Sales = 3,

            /// <summary>
            /// Enum OtherIncome for value: other_income
            /// </summary>
            [EnumMember(Value = "other_income")]
            OtherIncome = 4,

            /// <summary>
            /// Enum Bank for value: bank
            /// </summary>
            [EnumMember(Value = "bank")]
            Bank = 5,

            /// <summary>
            /// Enum CurrentAsset for value: current_asset
            /// </summary>
            [EnumMember(Value = "current_asset")]
            CurrentAsset = 6,

            /// <summary>
            /// Enum FixedAsset for value: fixed_asset
            /// </summary>
            [EnumMember(Value = "fixed_asset")]
            FixedAsset = 7,

            /// <summary>
            /// Enum NonCurrentAsset for value: non_current_asset
            /// </summary>
            [EnumMember(Value = "non_current_asset")]
            NonCurrentAsset = 8,

            /// <summary>
            /// Enum OtherAsset for value: other_asset
            /// </summary>
            [EnumMember(Value = "other_asset")]
            OtherAsset = 9,

            /// <summary>
            /// Enum Balancesheet for value: balancesheet
            /// </summary>
            [EnumMember(Value = "balancesheet")]
            Balancesheet = 10,

            /// <summary>
            /// Enum Equity for value: equity
            /// </summary>
            [EnumMember(Value = "equity")]
            Equity = 11,

            /// <summary>
            /// Enum Expense for value: expense
            /// </summary>
            [EnumMember(Value = "expense")]
            Expense = 12,

            /// <summary>
            /// Enum OtherExpense for value: other_expense
            /// </summary>
            [EnumMember(Value = "other_expense")]
            OtherExpense = 13,

            /// <summary>
            /// Enum CostsOfSales for value: costs_of_sales
            /// </summary>
            [EnumMember(Value = "costs_of_sales")]
            CostsOfSales = 14,

            /// <summary>
            /// Enum AccountsPayable for value: accounts_payable
            /// </summary>
            [EnumMember(Value = "accounts_payable")]
            AccountsPayable = 15,

            /// <summary>
            /// Enum CreditCard for value: credit_card
            /// </summary>
            [EnumMember(Value = "credit_card")]
            CreditCard = 16,

            /// <summary>
            /// Enum CurrentLiability for value: current_liability
            /// </summary>
            [EnumMember(Value = "current_liability")]
            CurrentLiability = 17,

            /// <summary>
            /// Enum NonCurrentLiability for value: non_current_liability
            /// </summary>
            [EnumMember(Value = "non_current_liability")]
            NonCurrentLiability = 18,

            /// <summary>
            /// Enum OtherLiability for value: other_liability
            /// </summary>
            [EnumMember(Value = "other_liability")]
            OtherLiability = 19

        }


        /// <summary>
        /// The type of account.
        /// </summary>
        /// <value>The type of account.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// The status of the account.
        /// </summary>
        /// <value>The status of the account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2,

            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 3

        }


        /// <summary>
        /// The status of the account.
        /// </summary>
        /// <value>The status of the account.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgerAccount" /> class.
        /// </summary>
        /// <param name="displayId">The human readable display ID used when displaying the account.</param>
        /// <param name="nominalCode">The nominal code of the ledger account..</param>
        /// <param name="code">The code assigned to the account..</param>
        /// <param name="classification">The classification of account..</param>
        /// <param name="type">The type of account..</param>
        /// <param name="subType">The sub type of account..</param>
        /// <param name="name">The name of the account..</param>
        /// <param name="fullyQualifiedName">The fully qualified name of the account..</param>
        /// <param name="description">The description of the account..</param>
        /// <param name="openingBalance">The opening balance of the account..</param>
        /// <param name="currentBalance">The current balance of the account..</param>
        /// <param name="currency">currency.</param>
        /// <param name="taxType">The tax type of the account..</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="level">level.</param>
        /// <param name="active">Whether the account is active or not..</param>
        /// <param name="status">The status of the account..</param>
        /// <param name="header">Whether the account is a header or not..</param>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="parentAccount">parentAccount.</param>
        /// <param name="subAccount">Whether the account is a sub account or not..</param>
        /// <param name="lastReconciliationDate">Reconciliation Date means the last calendar day of each Reconciliation Period..</param>
        /// <param name="rowVersion">rowVersion.</param>
        public LedgerAccount(string displayId = default(string), string nominalCode = default(string), string code = default(string), ClassificationEnum? classification = default(ClassificationEnum?), TypeEnum? type = default(TypeEnum?), string subType = default(string), string name = default(string), string fullyQualifiedName = default(string), string description = default(string), decimal? openingBalance = default(decimal?), decimal? currentBalance = default(decimal?), Currency? currency = default(Currency?), string taxType = default(string), LinkedTaxRate taxRate = default(LinkedTaxRate), decimal? level = default(decimal?), bool? active = default(bool?), StatusEnum? status = default(StatusEnum?), bool? header = default(bool?), BankAccount bankAccount = default(BankAccount), LedgerAccountParentAccount parentAccount = default(LedgerAccountParentAccount), bool? subAccount = default(bool?), DateTime? lastReconciliationDate = default(DateTime?), string rowVersion = default(string)) : base()
        {
            this.DisplayId = displayId;
            this.NominalCode = nominalCode;
            this.Code = code;
            this.Classification = classification;
            this.Type = type;
            this.SubType = subType;
            this.Name = name;
            this.FullyQualifiedName = fullyQualifiedName;
            this.Description = description;
            this.OpeningBalance = openingBalance;
            this.CurrentBalance = currentBalance;
            this.Currency = currency;
            this.TaxType = taxType;
            this.TaxRate = taxRate;
            this.Level = level;
            this.Active = active;
            this.Status = status;
            this.Header = header;
            this.BankAccount = bankAccount;
            this.ParentAccount = parentAccount;
            this.SubAccount = subAccount;
            this.LastReconciliationDate = lastReconciliationDate;
            this.RowVersion = rowVersion;
            this.AdditionalProperties = new Dictionary<string, object>();
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
        /// The human readable display ID used when displaying the account
        /// </summary>
        /// <value>The human readable display ID used when displaying the account</value>
        [DataMember(Name = "display_id", EmitDefaultValue = false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// The nominal code of the ledger account.
        /// </summary>
        /// <value>The nominal code of the ledger account.</value>
        [DataMember(Name = "nominal_code", EmitDefaultValue = true)]
        [Obsolete]
        public string NominalCode { get; set; }

        /// <summary>
        /// The code assigned to the account.
        /// </summary>
        /// <value>The code assigned to the account.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The sub type of account.
        /// </summary>
        /// <value>The sub type of account.</value>
        [DataMember(Name = "sub_type", EmitDefaultValue = true)]
        public string SubType { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The fully qualified name of the account.
        /// </summary>
        /// <value>The fully qualified name of the account.</value>
        [DataMember(Name = "fully_qualified_name", EmitDefaultValue = true)]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// The description of the account.
        /// </summary>
        /// <value>The description of the account.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The opening balance of the account.
        /// </summary>
        /// <value>The opening balance of the account.</value>
        [DataMember(Name = "opening_balance", EmitDefaultValue = true)]
        public decimal? OpeningBalance { get; set; }

        /// <summary>
        /// The current balance of the account.
        /// </summary>
        /// <value>The current balance of the account.</value>
        [DataMember(Name = "current_balance", EmitDefaultValue = true)]
        public decimal? CurrentBalance { get; set; }

        /// <summary>
        /// The tax type of the account.
        /// </summary>
        /// <value>The tax type of the account.</value>
        [DataMember(Name = "tax_type", EmitDefaultValue = true)]
        public string TaxType { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public LinkedTaxRate TaxRate { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = true)]
        public decimal? Level { get; set; }

        /// <summary>
        /// Whether the account is active or not.
        /// </summary>
        /// <value>Whether the account is active or not.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Whether the account is a header or not.
        /// </summary>
        /// <value>Whether the account is a header or not.</value>
        [DataMember(Name = "header", EmitDefaultValue = true)]
        public bool? Header { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", EmitDefaultValue = false)]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// The categories of the account.
        /// </summary>
        /// <value>The categories of the account.</value>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<Object> Categories { get; private set; }

        /// <summary>
        /// Returns false as Categories should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategories()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ParentAccount
        /// </summary>
        [DataMember(Name = "parent_account", EmitDefaultValue = false)]
        public LedgerAccountParentAccount ParentAccount { get; set; }

        /// <summary>
        /// Whether the account is a sub account or not.
        /// </summary>
        /// <value>Whether the account is a sub account or not.</value>
        [DataMember(Name = "sub_account", EmitDefaultValue = true)]
        public bool? SubAccount { get; set; }

        /// <summary>
        /// The sub accounts of the account.
        /// </summary>
        /// <value>The sub accounts of the account.</value>
        [DataMember(Name = "sub_accounts", EmitDefaultValue = false)]
        public List<Object> SubAccounts { get; private set; }

        /// <summary>
        /// Returns false as SubAccounts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubAccounts()
        {
            return false;
        }
        /// <summary>
        /// Reconciliation Date means the last calendar day of each Reconciliation Period.
        /// </summary>
        /// <value>Reconciliation Date means the last calendar day of each Reconciliation Period.</value>
        [DataMember(Name = "last_reconciliation_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? LastReconciliationDate { get; set; }

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
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LedgerAccount {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  NominalCode: ").Append(NominalCode).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FullyQualifiedName: ").Append(FullyQualifiedName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OpeningBalance: ").Append(OpeningBalance).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  ParentAccount: ").Append(ParentAccount).Append("\n");
            sb.Append("  SubAccount: ").Append(SubAccount).Append("\n");
            sb.Append("  SubAccounts: ").Append(SubAccounts).Append("\n");
            sb.Append("  LastReconciliationDate: ").Append(LastReconciliationDate).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as LedgerAccount);
        }

        /// <summary>
        /// Returns true if LedgerAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of LedgerAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LedgerAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && base.Equals(input) && 
                (
                    this.NominalCode == input.NominalCode ||
                    (this.NominalCode != null &&
                    this.NominalCode.Equals(input.NominalCode))
                ) && base.Equals(input) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && base.Equals(input) && 
                (
                    this.Classification == input.Classification ||
                    this.Classification.Equals(input.Classification)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && base.Equals(input) && 
                (
                    this.SubType == input.SubType ||
                    (this.SubType != null &&
                    this.SubType.Equals(input.SubType))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.FullyQualifiedName == input.FullyQualifiedName ||
                    (this.FullyQualifiedName != null &&
                    this.FullyQualifiedName.Equals(input.FullyQualifiedName))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.OpeningBalance == input.OpeningBalance ||
                    (this.OpeningBalance != null &&
                    this.OpeningBalance.Equals(input.OpeningBalance))
                ) && base.Equals(input) && 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    (this.CurrentBalance != null &&
                    this.CurrentBalance.Equals(input.CurrentBalance))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && base.Equals(input) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && base.Equals(input) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && base.Equals(input) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && base.Equals(input) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && base.Equals(input) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && base.Equals(input) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && base.Equals(input) && 
                (
                    this.ParentAccount == input.ParentAccount ||
                    (this.ParentAccount != null &&
                    this.ParentAccount.Equals(input.ParentAccount))
                ) && base.Equals(input) && 
                (
                    this.SubAccount == input.SubAccount ||
                    (this.SubAccount != null &&
                    this.SubAccount.Equals(input.SubAccount))
                ) && base.Equals(input) && 
                (
                    this.SubAccounts == input.SubAccounts ||
                    this.SubAccounts != null &&
                    input.SubAccounts != null &&
                    this.SubAccounts.SequenceEqual(input.SubAccounts)
                ) && base.Equals(input) && 
                (
                    this.LastReconciliationDate == input.LastReconciliationDate ||
                    (this.LastReconciliationDate != null &&
                    this.LastReconciliationDate.Equals(input.LastReconciliationDate))
                ) && base.Equals(input) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
                ) && base.Equals(input) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && base.Equals(input) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && base.Equals(input) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DisplayId != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayId.GetHashCode();
                }
                if (this.NominalCode != null)
                {
                    hashCode = (hashCode * 59) + this.NominalCode.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Classification.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.SubType != null)
                {
                    hashCode = (hashCode * 59) + this.SubType.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.FullyQualifiedName != null)
                {
                    hashCode = (hashCode * 59) + this.FullyQualifiedName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.OpeningBalance != null)
                {
                    hashCode = (hashCode * 59) + this.OpeningBalance.GetHashCode();
                }
                if (this.CurrentBalance != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentBalance.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.TaxType != null)
                {
                    hashCode = (hashCode * 59) + this.TaxType.GetHashCode();
                }
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                }
                if (this.Level != null)
                {
                    hashCode = (hashCode * 59) + this.Level.GetHashCode();
                }
                if (this.Active != null)
                {
                    hashCode = (hashCode * 59) + this.Active.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Header != null)
                {
                    hashCode = (hashCode * 59) + this.Header.GetHashCode();
                }
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.ParentAccount != null)
                {
                    hashCode = (hashCode * 59) + this.ParentAccount.GetHashCode();
                }
                if (this.SubAccount != null)
                {
                    hashCode = (hashCode * 59) + this.SubAccount.GetHashCode();
                }
                if (this.SubAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.SubAccounts.GetHashCode();
                }
                if (this.LastReconciliationDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastReconciliationDate.GetHashCode();
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
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
