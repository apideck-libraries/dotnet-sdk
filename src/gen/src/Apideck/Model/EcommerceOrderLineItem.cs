/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.3
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
    /// A single line item of an ecommerce order, representing a product or variant with associated options, quantity, and pricing information.
    /// </summary>
    [DataContract(Name = "EcommerceOrderLineItem")]
    public partial class EcommerceOrderLineItem : IEquatable<EcommerceOrderLineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceOrderLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EcommerceOrderLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceOrderLineItem" /> class.
        /// </summary>
        /// <param name="productId">A unique identifier for the product associated with the line item..</param>
        /// <param name="variantId">A unique identifier for the variant of the product associated with the line item, if applicable..</param>
        /// <param name="sku">The SKU of the product or variant associated with the line item..</param>
        /// <param name="name">The name of the product or variant associated with the line item. (required).</param>
        /// <param name="description">The description of the product or variant associated with the line item..</param>
        /// <param name="options">options.</param>
        /// <param name="quantity">The quantity of the product or variant associated with the line item. (required).</param>
        /// <param name="unitPrice">The unit price of the product or variant associated with the line item..</param>
        /// <param name="taxRate">The tax rate applied to the product or variant associated with the line item..</param>
        /// <param name="taxAmount">The total tax amount applied to the product or variant associated with the line item..</param>
        /// <param name="isRefunded">Whether the line item has been refunded..</param>
        /// <param name="refundedAmount">The amount of the line item that has been refunded..</param>
        /// <param name="refundedQuantity">The quantity of the line item that has been refunded..</param>
        /// <param name="subTotal">The sub total for the product(s) or variant associated with the line item, excluding taxes and discounts..</param>
        /// <param name="totalAmount">The total amount for the product(s) or variant associated with the line item, including taxes and discounts. (required).</param>
        /// <param name="discounts">discounts.</param>
        public EcommerceOrderLineItem(string productId = default(string), string variantId = default(string), string sku = default(string), string name = default(string), string description = default(string), List<Object> options = default(List<Object>), string quantity = default(string), string unitPrice = default(string), string taxRate = default(string), string taxAmount = default(string), bool? isRefunded = default(bool?), string refundedAmount = default(string), string refundedQuantity = default(string), string subTotal = default(string), string totalAmount = default(string), List<EcommerceDiscount> discounts = default(List<EcommerceDiscount>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for EcommerceOrderLineItem and cannot be null");
            }
            this.Name = name;
            // to ensure "quantity" is required (not null)
            if (quantity == null) {
                throw new ArgumentNullException("quantity is a required property for EcommerceOrderLineItem and cannot be null");
            }
            this.Quantity = quantity;
            // to ensure "totalAmount" is required (not null)
            if (totalAmount == null) {
                throw new ArgumentNullException("totalAmount is a required property for EcommerceOrderLineItem and cannot be null");
            }
            this.TotalAmount = totalAmount;
            this.ProductId = productId;
            this.VariantId = variantId;
            this.Sku = sku;
            this.Description = description;
            this.Options = options;
            this.UnitPrice = unitPrice;
            this.TaxRate = taxRate;
            this.TaxAmount = taxAmount;
            this.IsRefunded = isRefunded;
            this.RefundedAmount = refundedAmount;
            this.RefundedQuantity = refundedQuantity;
            this.SubTotal = subTotal;
            this.Discounts = discounts;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
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
        /// A unique identifier for the product associated with the line item.
        /// </summary>
        /// <value>A unique identifier for the product associated with the line item.</value>
        [DataMember(Name = "product_id", EmitDefaultValue = true)]
        public string ProductId { get; set; }

        /// <summary>
        /// A unique identifier for the variant of the product associated with the line item, if applicable.
        /// </summary>
        /// <value>A unique identifier for the variant of the product associated with the line item, if applicable.</value>
        [DataMember(Name = "variant_id", EmitDefaultValue = true)]
        public string VariantId { get; set; }

        /// <summary>
        /// The SKU of the product or variant associated with the line item.
        /// </summary>
        /// <value>The SKU of the product or variant associated with the line item.</value>
        [DataMember(Name = "sku", EmitDefaultValue = true)]
        public string Sku { get; set; }

        /// <summary>
        /// The name of the product or variant associated with the line item.
        /// </summary>
        /// <value>The name of the product or variant associated with the line item.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the product or variant associated with the line item.
        /// </summary>
        /// <value>The description of the product or variant associated with the line item.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<Object> Options { get; set; }

        /// <summary>
        /// The quantity of the product or variant associated with the line item.
        /// </summary>
        /// <value>The quantity of the product or variant associated with the line item.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public string Quantity { get; set; }

        /// <summary>
        /// The unit price of the product or variant associated with the line item.
        /// </summary>
        /// <value>The unit price of the product or variant associated with the line item.</value>
        [DataMember(Name = "unit_price", EmitDefaultValue = true)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// The tax rate applied to the product or variant associated with the line item.
        /// </summary>
        /// <value>The tax rate applied to the product or variant associated with the line item.</value>
        [DataMember(Name = "tax_rate", EmitDefaultValue = true)]
        public string TaxRate { get; set; }

        /// <summary>
        /// The total tax amount applied to the product or variant associated with the line item.
        /// </summary>
        /// <value>The total tax amount applied to the product or variant associated with the line item.</value>
        [DataMember(Name = "tax_amount", EmitDefaultValue = true)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Whether the line item has been refunded.
        /// </summary>
        /// <value>Whether the line item has been refunded.</value>
        [DataMember(Name = "is_refunded", EmitDefaultValue = true)]
        public bool? IsRefunded { get; set; }

        /// <summary>
        /// The amount of the line item that has been refunded.
        /// </summary>
        /// <value>The amount of the line item that has been refunded.</value>
        [DataMember(Name = "refunded_amount", EmitDefaultValue = true)]
        public string RefundedAmount { get; set; }

        /// <summary>
        /// The quantity of the line item that has been refunded.
        /// </summary>
        /// <value>The quantity of the line item that has been refunded.</value>
        [DataMember(Name = "refunded_quantity", EmitDefaultValue = true)]
        public string RefundedQuantity { get; set; }

        /// <summary>
        /// The sub total for the product(s) or variant associated with the line item, excluding taxes and discounts.
        /// </summary>
        /// <value>The sub total for the product(s) or variant associated with the line item, excluding taxes and discounts.</value>
        [DataMember(Name = "sub_total", EmitDefaultValue = true)]
        public string SubTotal { get; set; }

        /// <summary>
        /// The total amount for the product(s) or variant associated with the line item, including taxes and discounts.
        /// </summary>
        /// <value>The total amount for the product(s) or variant associated with the line item, including taxes and discounts.</value>
        [DataMember(Name = "total_amount", IsRequired = true, EmitDefaultValue = true)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name = "discounts", EmitDefaultValue = false)]
        public List<EcommerceDiscount> Discounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcommerceOrderLineItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  VariantId: ").Append(VariantId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  IsRefunded: ").Append(IsRefunded).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  RefundedQuantity: ").Append(RefundedQuantity).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
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
            return this.Equals(input as EcommerceOrderLineItem);
        }

        /// <summary>
        /// Returns true if EcommerceOrderLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceOrderLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceOrderLineItem input)
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
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.VariantId == input.VariantId ||
                    (this.VariantId != null &&
                    this.VariantId.Equals(input.VariantId))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
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
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.IsRefunded == input.IsRefunded ||
                    (this.IsRefunded != null &&
                    this.IsRefunded.Equals(input.IsRefunded))
                ) && 
                (
                    this.RefundedAmount == input.RefundedAmount ||
                    (this.RefundedAmount != null &&
                    this.RefundedAmount.Equals(input.RefundedAmount))
                ) && 
                (
                    this.RefundedQuantity == input.RefundedQuantity ||
                    (this.RefundedQuantity != null &&
                    this.RefundedQuantity.Equals(input.RefundedQuantity))
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    (this.SubTotal != null &&
                    this.SubTotal.Equals(input.SubTotal))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.Discounts == input.Discounts ||
                    this.Discounts != null &&
                    input.Discounts != null &&
                    this.Discounts.SequenceEqual(input.Discounts)
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
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                if (this.VariantId != null)
                {
                    hashCode = (hashCode * 59) + this.VariantId.GetHashCode();
                }
                if (this.Sku != null)
                {
                    hashCode = (hashCode * 59) + this.Sku.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.UnitPrice != null)
                {
                    hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                }
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                }
                if (this.TaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaxAmount.GetHashCode();
                }
                if (this.IsRefunded != null)
                {
                    hashCode = (hashCode * 59) + this.IsRefunded.GetHashCode();
                }
                if (this.RefundedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundedAmount.GetHashCode();
                }
                if (this.RefundedQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.RefundedQuantity.GetHashCode();
                }
                if (this.SubTotal != null)
                {
                    hashCode = (hashCode * 59) + this.SubTotal.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.Discounts != null)
                {
                    hashCode = (hashCode * 59) + this.Discounts.GetHashCode();
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
