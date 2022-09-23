/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.60.0
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
    /// OrderLineItems
    /// </summary>
    [DataContract(Name = "Order_line_items")]
    public partial class OrderLineItems : IEquatable<OrderLineItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItems" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="item">item.</param>
        /// <param name="totalTax">totalTax.</param>
        /// <param name="totalDiscount">totalDiscount.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="appliedTaxes">appliedTaxes.</param>
        /// <param name="appliedDiscounts">appliedDiscounts.</param>
        /// <param name="modifiers">Customizable options – toppings, add-ons, or special requests – create item modifiers. Modifiers that are applied to items will display on your customers’ digital receipts.</param>
        public OrderLineItems(string name = default(string), Object item = default(Object), int? totalTax = default(int?), int? totalDiscount = default(int?), int? totalAmount = default(int?), decimal? quantity = default(decimal?), decimal? unitPrice = default(decimal?), List<Object> appliedTaxes = default(List<Object>), List<Object> appliedDiscounts = default(List<Object>), List<Object> modifiers = default(List<Object>))
        {
            this.Name = name;
            this.Item = item;
            this.TotalTax = totalTax;
            this.TotalDiscount = totalDiscount;
            this.TotalAmount = totalAmount;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.AppliedTaxes = appliedTaxes;
            this.AppliedDiscounts = appliedDiscounts;
            this.Modifiers = modifiers;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = true)]
        public Object Item { get; set; }

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
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name = "total_amount", EmitDefaultValue = true)]
        public int? TotalAmount { get; set; }

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
        /// Gets or Sets AppliedTaxes
        /// </summary>
        [DataMember(Name = "applied_taxes", EmitDefaultValue = false)]
        public List<Object> AppliedTaxes { get; set; }

        /// <summary>
        /// Gets or Sets AppliedDiscounts
        /// </summary>
        [DataMember(Name = "applied_discounts", EmitDefaultValue = false)]
        public List<Object> AppliedDiscounts { get; set; }

        /// <summary>
        /// Customizable options – toppings, add-ons, or special requests – create item modifiers. Modifiers that are applied to items will display on your customers’ digital receipts
        /// </summary>
        /// <value>Customizable options – toppings, add-ons, or special requests – create item modifiers. Modifiers that are applied to items will display on your customers’ digital receipts</value>
        [DataMember(Name = "modifiers", EmitDefaultValue = false)]
        public List<Object> Modifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderLineItems {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  AppliedTaxes: ").Append(AppliedTaxes).Append("\n");
            sb.Append("  AppliedDiscounts: ").Append(AppliedDiscounts).Append("\n");
            sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
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
            return this.Equals(input as OrderLineItems);
        }

        /// <summary>
        /// Returns true if OrderLineItems instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderLineItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLineItems input)
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
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
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
                    this.AppliedTaxes == input.AppliedTaxes ||
                    this.AppliedTaxes != null &&
                    input.AppliedTaxes != null &&
                    this.AppliedTaxes.SequenceEqual(input.AppliedTaxes)
                ) && 
                (
                    this.AppliedDiscounts == input.AppliedDiscounts ||
                    this.AppliedDiscounts != null &&
                    input.AppliedDiscounts != null &&
                    this.AppliedDiscounts.SequenceEqual(input.AppliedDiscounts)
                ) && 
                (
                    this.Modifiers == input.Modifiers ||
                    this.Modifiers != null &&
                    input.Modifiers != null &&
                    this.Modifiers.SequenceEqual(input.Modifiers)
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
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
                }
                if (this.TotalTax != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTax.GetHashCode();
                }
                if (this.TotalDiscount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalDiscount.GetHashCode();
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
                if (this.AppliedTaxes != null)
                {
                    hashCode = (hashCode * 59) + this.AppliedTaxes.GetHashCode();
                }
                if (this.AppliedDiscounts != null)
                {
                    hashCode = (hashCode * 59) + this.AppliedDiscounts.GetHashCode();
                }
                if (this.Modifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Modifiers.GetHashCode();
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
