/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.39.0
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
    /// InvoiceLineItem
    /// </summary>
    [DataContract(Name = "InvoiceLineItem")]
    public partial class InvoiceLineItem : IEquatable<InvoiceLineItem>, IValidatableObject
    {
        /// <summary>
        /// Item type
        /// </summary>
        /// <value>Item type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SalesItem for value: sales_item
            /// </summary>
            [EnumMember(Value = "sales_item")]
            SalesItem = 1,

            /// <summary>
            /// Enum Discount for value: discount
            /// </summary>
            [EnumMember(Value = "discount")]
            Discount = 2,

            /// <summary>
            /// Enum Info for value: info
            /// </summary>
            [EnumMember(Value = "info")]
            Info = 3,

            /// <summary>
            /// Enum SubTotal for value: sub_total
            /// </summary>
            [EnumMember(Value = "sub_total")]
            SubTotal = 4

        }


        /// <summary>
        /// Item type
        /// </summary>
        /// <value>Item type</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItem" /> class.
        /// </summary>
        /// <param name="rowId">Row ID.</param>
        /// <param name="code">User defined item code.</param>
        /// <param name="lineNumber">Line number in the invoice.</param>
        /// <param name="description">User defined description.</param>
        /// <param name="type">Item type.</param>
        /// <param name="taxAmount">Tax amount.</param>
        /// <param name="totalAmount">Total amount of the line item.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="unitOfMeasure">Description of the unit type the item is sold as, ie: kg, hour..</param>
        /// <param name="discountPercentage">Discount percentage.</param>
        /// <param name="item">item.</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="ledgerAccount">ledgerAccount.</param>
        /// <param name="rowVersion">rowVersion.</param>
        public InvoiceLineItem(string rowId = default(string), string code = default(string), int? lineNumber = default(int?), string description = default(string), TypeEnum? type = default(TypeEnum?), decimal? taxAmount = default(decimal?), decimal? totalAmount = default(decimal?), decimal? quantity = default(decimal?), decimal? unitPrice = default(decimal?), string unitOfMeasure = default(string), decimal? discountPercentage = default(decimal?), LinkedInvoiceItem item = default(LinkedInvoiceItem), LinkedTaxRate taxRate = default(LinkedTaxRate), LinkedLedgerAccount ledgerAccount = default(LinkedLedgerAccount), string rowVersion = default(string))
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
            this.Item = item;
            this.TaxRate = taxRate;
            this.LedgerAccount = ledgerAccount;
            this.RowVersion = rowVersion;
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
        /// Discount percentage
        /// </summary>
        /// <value>Discount percentage</value>
        [DataMember(Name = "discount_percentage", EmitDefaultValue = true)]
        public decimal? DiscountPercentage { get; set; }

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
        /// Gets or Sets RowVersion
        /// </summary>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceLineItem {\n");
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
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  LedgerAccount: ").Append(LedgerAccount).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
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
            return this.Equals(input as InvoiceLineItem);
        }

        /// <summary>
        /// Returns true if InvoiceLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceLineItem input)
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
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
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
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
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
