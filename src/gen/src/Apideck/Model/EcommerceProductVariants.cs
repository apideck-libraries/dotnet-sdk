/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.4
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
    /// EcommerceProductVariants
    /// </summary>
    [DataContract(Name = "EcommerceProduct_variants")]
    public partial class EcommerceProductVariants : IEquatable<EcommerceProductVariants>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceProductVariants" /> class.
        /// </summary>
        /// <param name="id">A unique identifier for the variant of the product..</param>
        /// <param name="name">The name for the variant, used for displaying to customers..</param>
        /// <param name="price">The price of the variant..</param>
        /// <param name="sku">The stock keeping unit of the variant..</param>
        /// <param name="inventoryQuantity">The quantity of the variant in stock..</param>
        /// <param name="weight">The weight of the variant..</param>
        /// <param name="weightUnit">The unit of measurement for the weight of the variant..</param>
        /// <param name="options">options.</param>
        /// <param name="images">images.</param>
        public EcommerceProductVariants(string id = default(string), string name = default(string), string price = default(string), string sku = default(string), string inventoryQuantity = default(string), string weight = default(string), string weightUnit = default(string), List<EcommerceProductOptions1> options = default(List<EcommerceProductOptions1>), List<EcommerceProductImages1> images = default(List<EcommerceProductImages1>))
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Sku = sku;
            this.InventoryQuantity = inventoryQuantity;
            this.Weight = weight;
            this.WeightUnit = weightUnit;
            this.Options = options;
            this.Images = images;
        }

        /// <summary>
        /// A unique identifier for the variant of the product.
        /// </summary>
        /// <value>A unique identifier for the variant of the product.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name for the variant, used for displaying to customers.
        /// </summary>
        /// <value>The name for the variant, used for displaying to customers.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The price of the variant.
        /// </summary>
        /// <value>The price of the variant.</value>
        [DataMember(Name = "price", EmitDefaultValue = true)]
        public string Price { get; set; }

        /// <summary>
        /// The stock keeping unit of the variant.
        /// </summary>
        /// <value>The stock keeping unit of the variant.</value>
        [DataMember(Name = "sku", EmitDefaultValue = true)]
        public string Sku { get; set; }

        /// <summary>
        /// The quantity of the variant in stock.
        /// </summary>
        /// <value>The quantity of the variant in stock.</value>
        [DataMember(Name = "inventory_quantity", EmitDefaultValue = true)]
        public string InventoryQuantity { get; set; }

        /// <summary>
        /// The weight of the variant.
        /// </summary>
        /// <value>The weight of the variant.</value>
        [DataMember(Name = "weight", EmitDefaultValue = true)]
        public string Weight { get; set; }

        /// <summary>
        /// The unit of measurement for the weight of the variant.
        /// </summary>
        /// <value>The unit of measurement for the weight of the variant.</value>
        [DataMember(Name = "weight_unit", EmitDefaultValue = true)]
        public string WeightUnit { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<EcommerceProductOptions1> Options { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<EcommerceProductImages1> Images { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcommerceProductVariants {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  InventoryQuantity: ").Append(InventoryQuantity).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
            return this.Equals(input as EcommerceProductVariants);
        }

        /// <summary>
        /// Returns true if EcommerceProductVariants instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceProductVariants to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceProductVariants input)
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
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.InventoryQuantity == input.InventoryQuantity ||
                    (this.InventoryQuantity != null &&
                    this.InventoryQuantity.Equals(input.InventoryQuantity))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.WeightUnit == input.WeightUnit ||
                    (this.WeightUnit != null &&
                    this.WeightUnit.Equals(input.WeightUnit))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
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
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Sku != null)
                {
                    hashCode = (hashCode * 59) + this.Sku.GetHashCode();
                }
                if (this.InventoryQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryQuantity.GetHashCode();
                }
                if (this.Weight != null)
                {
                    hashCode = (hashCode * 59) + this.Weight.GetHashCode();
                }
                if (this.WeightUnit != null)
                {
                    hashCode = (hashCode * 59) + this.WeightUnit.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
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
