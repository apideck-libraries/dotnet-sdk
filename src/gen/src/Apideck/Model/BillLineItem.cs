/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.6
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
    /// BillLineItem
    /// </summary>
    [DataContract(Name = "BillLineItem")]
    public partial class BillLineItem : IEquatable<BillLineItem>, IValidatableObject
    {
        /// <summary>
        /// Bill Line Item type
        /// </summary>
        /// <value>Bill Line Item type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ExpenseItem for value: expense_item
            /// </summary>
            [EnumMember(Value = "expense_item")]
            ExpenseItem = 1,

            /// <summary>
            /// Enum ExpenseAccount for value: expense_account
            /// </summary>
            [EnumMember(Value = "expense_account")]
            ExpenseAccount = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3

        }


        /// <summary>
        /// Bill Line Item type
        /// </summary>
        /// <value>Bill Line Item type</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillLineItem" /> class.
        /// </summary>
        /// <param name="rowId">Row ID.</param>
        /// <param name="code">User defined item code.</param>
        /// <param name="lineNumber">Line number in the invoice.</param>
        /// <param name="description">User defined description.</param>
        /// <param name="type">Bill Line Item type.</param>
        /// <param name="taxAmount">Tax amount.</param>
        /// <param name="totalAmount">Total amount of the line item.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="unitOfMeasure">Description of the unit type the item is sold as, ie: kg, hour..</param>
        /// <param name="discountPercentage">Discount percentage applied to the line item when supported downstream..</param>
        /// <param name="discountAmount">Discount amount applied to the line item when supported downstream..</param>
        /// <param name="locationId">Location id.</param>
        /// <param name="departmentId">Department id.</param>
        /// <param name="item">item.</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="ledgerAccount">ledgerAccount.</param>
        /// <param name="trackingCategories">A list of linked tracking categories..</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        public BillLineItem(string rowId = default(string), string code = default(string), int? lineNumber = default(int?), string description = default(string), TypeEnum? type = default(TypeEnum?), decimal? taxAmount = default(decimal?), decimal? totalAmount = default(decimal?), decimal? quantity = default(decimal?), decimal? unitPrice = default(decimal?), string unitOfMeasure = default(string), decimal? discountPercentage = default(decimal?), decimal? discountAmount = default(decimal?), string locationId = default(string), string departmentId = default(string), LinkedInvoiceItem item = default(LinkedInvoiceItem), LinkedTaxRate taxRate = default(LinkedTaxRate), LinkedLedgerAccount ledgerAccount = default(LinkedLedgerAccount), List<LinkedTrackingCategory> trackingCategories = default(List<LinkedTrackingCategory>), string rowVersion = default(string))
        {
            this.RowId = rowId;
            this.Code = code;
            this.LineNumber = lineNumber;
            this.Description = description;
            this.Type = type;
            this.TaxAmount = taxAmount;
            this.TotalAmount = totalAmount;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.UnitOfMeasure = unitOfMeasure;
            this.DiscountPercentage = discountPercentage;
            this.DiscountAmount = discountAmount;
            this.LocationId = locationId;
            this.DepartmentId = departmentId;
            this.Item = item;
            this.TaxRate = taxRate;
            this.LedgerAccount = ledgerAccount;
            this.TrackingCategories = trackingCategories;
            this.RowVersion = rowVersion;
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
        /// Row ID
        /// </summary>
        /// <value>Row ID</value>
        [DataMember(Name = "row_id", EmitDefaultValue = false)]
        public string RowId { get; set; }

        /// <summary>
        /// User defined item code
        /// </summary>
        /// <value>User defined item code</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Line number in the invoice
        /// </summary>
        /// <value>Line number in the invoice</value>
        [DataMember(Name = "line_number", EmitDefaultValue = true)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// User defined description
        /// </summary>
        /// <value>User defined description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Tax amount
        /// </summary>
        /// <value>Tax amount</value>
        [DataMember(Name = "tax_amount", EmitDefaultValue = true)]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Total amount of the line item
        /// </summary>
        /// <value>Total amount of the line item</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = true)]
        public decimal? TotalAmount { get; set; }

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
        /// Description of the unit type the item is sold as, ie: kg, hour.
        /// </summary>
        /// <value>Description of the unit type the item is sold as, ie: kg, hour.</value>
        [DataMember(Name = "unit_of_measure", EmitDefaultValue = true)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Discount percentage applied to the line item when supported downstream.
        /// </summary>
        /// <value>Discount percentage applied to the line item when supported downstream.</value>
        [DataMember(Name = "discount_percentage", EmitDefaultValue = true)]
        public decimal? DiscountPercentage { get; set; }

        /// <summary>
        /// Discount amount applied to the line item when supported downstream.
        /// </summary>
        /// <value>Discount amount applied to the line item when supported downstream.</value>
        [DataMember(Name = "discount_amount", EmitDefaultValue = true)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// Location id
        /// </summary>
        /// <value>Location id</value>
        [DataMember(Name = "location_id", EmitDefaultValue = true)]
        public string LocationId { get; set; }

        /// <summary>
        /// Department id
        /// </summary>
        /// <value>Department id</value>
        [DataMember(Name = "department_id", EmitDefaultValue = true)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = false)]
        public LinkedInvoiceItem Item { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public LinkedTaxRate TaxRate { get; set; }

        /// <summary>
        /// Gets or Sets LedgerAccount
        /// </summary>
        [DataMember(Name = "ledger_account", EmitDefaultValue = true)]
        public LinkedLedgerAccount LedgerAccount { get; set; }

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        /// <value>A list of linked tracking categories.</value>
        [DataMember(Name = "tracking_categories", EmitDefaultValue = true)]
        public List<LinkedTrackingCategory> TrackingCategories { get; set; }

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        /// <value>A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.</value>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillLineItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RowId: ").Append(RowId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  LedgerAccount: ").Append(LedgerAccount).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(input as BillLineItem);
        }

        /// <summary>
        /// Returns true if BillLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of BillLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillLineItem input)
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
                    this.RowId == input.RowId ||
                    (this.RowId != null &&
                    this.RowId.Equals(input.RowId))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
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
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.DiscountPercentage == input.DiscountPercentage ||
                    (this.DiscountPercentage != null &&
                    this.DiscountPercentage.Equals(input.DiscountPercentage))
                ) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.LedgerAccount == input.LedgerAccount ||
                    (this.LedgerAccount != null &&
                    this.LedgerAccount.Equals(input.LedgerAccount))
                ) && 
                (
                    this.TrackingCategories == input.TrackingCategories ||
                    this.TrackingCategories != null &&
                    input.TrackingCategories != null &&
                    this.TrackingCategories.SequenceEqual(input.TrackingCategories)
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
                if (this.RowId != null)
                {
                    hashCode = (hashCode * 59) + this.RowId.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.LineNumber != null)
                {
                    hashCode = (hashCode * 59) + this.LineNumber.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.TaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaxAmount.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.UnitPrice != null)
                {
                    hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                }
                if (this.UnitOfMeasure != null)
                {
                    hashCode = (hashCode * 59) + this.UnitOfMeasure.GetHashCode();
                }
                if (this.DiscountPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountPercentage.GetHashCode();
                }
                if (this.DiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountAmount.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
                }
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
                }
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                }
                if (this.LedgerAccount != null)
                {
                    hashCode = (hashCode * 59) + this.LedgerAccount.GetHashCode();
                }
                if (this.TrackingCategories != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingCategories.GetHashCode();
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
