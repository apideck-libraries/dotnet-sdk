/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.3.1
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
    /// EcommerceProduct
    /// </summary>
    [DataContract(Name = "EcommerceProduct")]
    public partial class EcommerceProduct : IEquatable<EcommerceProduct>, IValidatableObject
    {
        /// <summary>
        /// The current status of the product (active or archived).
        /// </summary>
        /// <value>The current status of the product (active or archived).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 2

        }


        /// <summary>
        /// The current status of the product (active or archived).
        /// </summary>
        /// <value>The current status of the product (active or archived).</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EcommerceProduct() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceProduct" /> class.
        /// </summary>
        /// <param name="name">The name of the product as it should be displayed to customers..</param>
        /// <param name="description">A detailed description of the product..</param>
        /// <param name="status">The current status of the product (active or archived)..</param>
        /// <param name="price">The price of the product..</param>
        /// <param name="sku">The stock keeping unit of the product..</param>
        /// <param name="inventoryQuantity">The quantity of the product in stock..</param>
        /// <param name="images">An array of image URLs for the product..</param>
        /// <param name="weight">The weight of the product..</param>
        /// <param name="weightUnit">The unit of measurement for the weight of the product..</param>
        /// <param name="options">An array of options for the product..</param>
        /// <param name="variants">variants.</param>
        /// <param name="tags">An array of tags for the product, used for organization and searching..</param>
        /// <param name="categories">An array of categories for the product, used for organization and searching..</param>
        public EcommerceProduct(string name = default(string), string description = default(string), StatusEnum? status = default(StatusEnum?), string price = default(string), string sku = default(string), string inventoryQuantity = default(string), List<EcommerceProductImages> images = default(List<EcommerceProductImages>), string weight = default(string), string weightUnit = default(string), List<EcommerceProductOptions> options = default(List<EcommerceProductOptions>), List<EcommerceProductVariants> variants = default(List<EcommerceProductVariants>), List<string> tags = default(List<string>), List<EcommerceProductCategories> categories = default(List<EcommerceProductCategories>))
        {
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.Price = price;
            this.Sku = sku;
            this.InventoryQuantity = inventoryQuantity;
            this.Images = images;
            this.Weight = weight;
            this.WeightUnit = weightUnit;
            this.Options = options;
            this.Variants = variants;
            this.Tags = tags;
            this.Categories = categories;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
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
        /// The name of the product as it should be displayed to customers.
        /// </summary>
        /// <value>The name of the product as it should be displayed to customers.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A detailed description of the product.
        /// </summary>
        /// <value>A detailed description of the product.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        /// <value>The price of the product.</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// The stock keeping unit of the product.
        /// </summary>
        /// <value>The stock keeping unit of the product.</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// The quantity of the product in stock.
        /// </summary>
        /// <value>The quantity of the product in stock.</value>
        [DataMember(Name = "inventory_quantity", EmitDefaultValue = false)]
        public string InventoryQuantity { get; set; }

        /// <summary>
        /// An array of image URLs for the product.
        /// </summary>
        /// <value>An array of image URLs for the product.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<EcommerceProductImages> Images { get; set; }

        /// <summary>
        /// The weight of the product.
        /// </summary>
        /// <value>The weight of the product.</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public string Weight { get; set; }

        /// <summary>
        /// The unit of measurement for the weight of the product.
        /// </summary>
        /// <value>The unit of measurement for the weight of the product.</value>
        [DataMember(Name = "weight_unit", EmitDefaultValue = false)]
        public string WeightUnit { get; set; }

        /// <summary>
        /// An array of options for the product.
        /// </summary>
        /// <value>An array of options for the product.</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<EcommerceProductOptions> Options { get; set; }

        /// <summary>
        /// Gets or Sets Variants
        /// </summary>
        [DataMember(Name = "variants", EmitDefaultValue = false)]
        public List<EcommerceProductVariants> Variants { get; set; }

        /// <summary>
        /// An array of tags for the product, used for organization and searching.
        /// </summary>
        /// <value>An array of tags for the product, used for organization and searching.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// An array of categories for the product, used for organization and searching.
        /// </summary>
        /// <value>An array of categories for the product, used for organization and searching.</value>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<EcommerceProductCategories> Categories { get; set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
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
            sb.Append("class EcommerceProduct {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  InventoryQuantity: ").Append(InventoryQuantity).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(input as EcommerceProduct);
        }

        /// <summary>
        /// Returns true if EcommerceProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceProduct input)
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
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
                    this.Variants == input.Variants ||
                    this.Variants != null &&
                    input.Variants != null &&
                    this.Variants.SequenceEqual(input.Variants)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
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
                if (this.Variants != null)
                {
                    hashCode = (hashCode * 59) + this.Variants.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
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
