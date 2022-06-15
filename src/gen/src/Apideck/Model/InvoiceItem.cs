/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.2
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
    /// InvoiceItem
    /// </summary>
    [DataContract(Name = "InvoiceItem")]
    public partial class InvoiceItem : IEquatable<InvoiceItem>, IValidatableObject
    {
        /// <summary>
        /// Item type
        /// </summary>
        /// <value>Item type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Inventory for value: inventory
            /// </summary>
            [EnumMember(Value = "inventory")]
            Inventory = 1,

            /// <summary>
            /// Enum Service for value: service
            /// </summary>
            [EnumMember(Value = "service")]
            Service = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3

        }


        /// <summary>
        /// Item type
        /// </summary>
        /// <value>Item type</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceItem" /> class.
        /// </summary>
        /// <param name="name">Item name.</param>
        /// <param name="description">A short description of the item.</param>
        /// <param name="code">User defined item code.</param>
        /// <param name="sold">Item will be available on sales transactions.</param>
        /// <param name="purchased">Item is available for purchase transactions.</param>
        /// <param name="tracked">Item is inventoried.</param>
        /// <param name="inventoryDate">The date of opening balance if inventory item is tracked - YYYY-MM-DD..</param>
        /// <param name="type">Item type.</param>
        /// <param name="salesDetails">salesDetails.</param>
        /// <param name="purchaseDetails">purchaseDetails.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="assetAccount">assetAccount.</param>
        /// <param name="incomeAccount">incomeAccount.</param>
        /// <param name="expenseAccount">expenseAccount.</param>
        /// <param name="active">active.</param>
        /// <param name="rowVersion">rowVersion.</param>
        public InvoiceItem(string name = default(string), string description = default(string), string code = default(string), bool? sold = default(bool?), bool? purchased = default(bool?), bool? tracked = default(bool?), DateTime? inventoryDate = default(DateTime?), TypeEnum? type = default(TypeEnum?), InvoiceItemSalesDetails salesDetails = default(InvoiceItemSalesDetails), InvoiceItemSalesDetails purchaseDetails = default(InvoiceItemSalesDetails), decimal? quantity = default(decimal?), decimal? unitPrice = default(decimal?), LinkedLedgerAccount assetAccount = default(LinkedLedgerAccount), LinkedLedgerAccount incomeAccount = default(LinkedLedgerAccount), LinkedLedgerAccount expenseAccount = default(LinkedLedgerAccount), bool? active = default(bool?), string rowVersion = default(string))
        {
            this.Name = name;
            this.Description = description;
            this.Code = code;
            this.Sold = sold;
            this.Purchased = purchased;
            this.Tracked = tracked;
            this.InventoryDate = inventoryDate;
            this.Type = type;
            this.SalesDetails = salesDetails;
            this.PurchaseDetails = purchaseDetails;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.AssetAccount = assetAccount;
            this.IncomeAccount = incomeAccount;
            this.ExpenseAccount = expenseAccount;
            this.Active = active;
            this.RowVersion = rowVersion;
        }

        /// <summary>
        /// The ID of the item.
        /// </summary>
        /// <value>The ID of the item.</value>
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
        /// Item name
        /// </summary>
        /// <value>Item name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A short description of the item
        /// </summary>
        /// <value>A short description of the item</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// User defined item code
        /// </summary>
        /// <value>User defined item code</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Item will be available on sales transactions
        /// </summary>
        /// <value>Item will be available on sales transactions</value>
        [DataMember(Name = "sold", EmitDefaultValue = true)]
        public bool? Sold { get; set; }

        /// <summary>
        /// Item is available for purchase transactions
        /// </summary>
        /// <value>Item is available for purchase transactions</value>
        [DataMember(Name = "purchased", EmitDefaultValue = true)]
        public bool? Purchased { get; set; }

        /// <summary>
        /// Item is inventoried
        /// </summary>
        /// <value>Item is inventoried</value>
        [DataMember(Name = "tracked", EmitDefaultValue = true)]
        public bool? Tracked { get; set; }

        /// <summary>
        /// The date of opening balance if inventory item is tracked - YYYY-MM-DD.
        /// </summary>
        /// <value>The date of opening balance if inventory item is tracked - YYYY-MM-DD.</value>
        [DataMember(Name = "inventory_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? InventoryDate { get; set; }

        /// <summary>
        /// Gets or Sets SalesDetails
        /// </summary>
        [DataMember(Name = "sales_details", EmitDefaultValue = false)]
        public InvoiceItemSalesDetails SalesDetails { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseDetails
        /// </summary>
        [DataMember(Name = "purchase_details", EmitDefaultValue = false)]
        public InvoiceItemSalesDetails PurchaseDetails { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = true)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name = "unit_price", EmitDefaultValue = true)]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets AssetAccount
        /// </summary>
        [DataMember(Name = "asset_account", EmitDefaultValue = true)]
        public LinkedLedgerAccount AssetAccount { get; set; }

        /// <summary>
        /// Gets or Sets IncomeAccount
        /// </summary>
        [DataMember(Name = "income_account", EmitDefaultValue = true)]
        public LinkedLedgerAccount IncomeAccount { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAccount
        /// </summary>
        [DataMember(Name = "expense_account", EmitDefaultValue = true)]
        public LinkedLedgerAccount ExpenseAccount { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool? Active { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Sold: ").Append(Sold).Append("\n");
            sb.Append("  Purchased: ").Append(Purchased).Append("\n");
            sb.Append("  Tracked: ").Append(Tracked).Append("\n");
            sb.Append("  InventoryDate: ").Append(InventoryDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SalesDetails: ").Append(SalesDetails).Append("\n");
            sb.Append("  PurchaseDetails: ").Append(PurchaseDetails).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  AssetAccount: ").Append(AssetAccount).Append("\n");
            sb.Append("  IncomeAccount: ").Append(IncomeAccount).Append("\n");
            sb.Append("  ExpenseAccount: ").Append(ExpenseAccount).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
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
            return this.Equals(input as InvoiceItem);
        }

        /// <summary>
        /// Returns true if InvoiceItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceItem input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Sold == input.Sold ||
                    (this.Sold != null &&
                    this.Sold.Equals(input.Sold))
                ) && 
                (
                    this.Purchased == input.Purchased ||
                    (this.Purchased != null &&
                    this.Purchased.Equals(input.Purchased))
                ) && 
                (
                    this.Tracked == input.Tracked ||
                    (this.Tracked != null &&
                    this.Tracked.Equals(input.Tracked))
                ) && 
                (
                    this.InventoryDate == input.InventoryDate ||
                    (this.InventoryDate != null &&
                    this.InventoryDate.Equals(input.InventoryDate))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SalesDetails == input.SalesDetails ||
                    (this.SalesDetails != null &&
                    this.SalesDetails.Equals(input.SalesDetails))
                ) && 
                (
                    this.PurchaseDetails == input.PurchaseDetails ||
                    (this.PurchaseDetails != null &&
                    this.PurchaseDetails.Equals(input.PurchaseDetails))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.AssetAccount == input.AssetAccount ||
                    (this.AssetAccount != null &&
                    this.AssetAccount.Equals(input.AssetAccount))
                ) && 
                (
                    this.IncomeAccount == input.IncomeAccount ||
                    (this.IncomeAccount != null &&
                    this.IncomeAccount.Equals(input.IncomeAccount))
                ) && 
                (
                    this.ExpenseAccount == input.ExpenseAccount ||
                    (this.ExpenseAccount != null &&
                    this.ExpenseAccount.Equals(input.ExpenseAccount))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Sold != null)
                {
                    hashCode = (hashCode * 59) + this.Sold.GetHashCode();
                }
                if (this.Purchased != null)
                {
                    hashCode = (hashCode * 59) + this.Purchased.GetHashCode();
                }
                if (this.Tracked != null)
                {
                    hashCode = (hashCode * 59) + this.Tracked.GetHashCode();
                }
                if (this.InventoryDate != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.SalesDetails != null)
                {
                    hashCode = (hashCode * 59) + this.SalesDetails.GetHashCode();
                }
                if (this.PurchaseDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseDetails.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.UnitPrice != null)
                {
                    hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                }
                if (this.AssetAccount != null)
                {
                    hashCode = (hashCode * 59) + this.AssetAccount.GetHashCode();
                }
                if (this.IncomeAccount != null)
                {
                    hashCode = (hashCode * 59) + this.IncomeAccount.GetHashCode();
                }
                if (this.ExpenseAccount != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseAccount.GetHashCode();
                }
                if (this.Active != null)
                {
                    hashCode = (hashCode * 59) + this.Active.GetHashCode();
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
