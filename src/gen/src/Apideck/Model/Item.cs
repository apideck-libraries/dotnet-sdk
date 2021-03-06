/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.34.0
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
    /// Item
    /// </summary>
    [DataContract(Name = "Item")]
    public partial class Item : IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Defines ProductType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductTypeEnum
        {
            /// <summary>
            /// Enum Regular for value: regular
            /// </summary>
            [EnumMember(Value = "regular")]
            Regular = 1,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 2

        }


        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name = "product_type", EmitDefaultValue = false)]
        public ProductTypeEnum? ProductType { get; set; }
        /// <summary>
        /// Defines PricingType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PricingTypeEnum
        {
            /// <summary>
            /// Enum Fixed for value: fixed
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed = 1,

            /// <summary>
            /// Enum Variable for value: variable
            /// </summary>
            [EnumMember(Value = "variable")]
            Variable = 2,

            /// <summary>
            /// Enum PerUnit for value: per_unit
            /// </summary>
            [EnumMember(Value = "per_unit")]
            PerUnit = 3,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4

        }


        /// <summary>
        /// Gets or Sets PricingType
        /// </summary>
        [DataMember(Name = "pricing_type", EmitDefaultValue = false)]
        public PricingTypeEnum? PricingType { get; set; }

        /// <summary>
        /// Gets or Sets PriceCurrency
        /// </summary>
        [DataMember(Name = "price_currency", EmitDefaultValue = true)]
        public Currency? PriceCurrency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="idempotencyKey">A value you specify that uniquely identifies this request among requests you have sent..</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="abbreviation">abbreviation.</param>
        /// <param name="productType">productType.</param>
        /// <param name="priceAmount">priceAmount.</param>
        /// <param name="pricingType">pricingType.</param>
        /// <param name="priceCurrency">priceCurrency.</param>
        /// <param name="cost">cost.</param>
        /// <param name="taxIds">A list of Tax IDs for the product..</param>
        /// <param name="absentAtLocationIds">A list of locations where the object is not present, even if present_at_all_locations is true. This can include locations that are deactivated..</param>
        /// <param name="presentAtAllLocations">presentAtAllLocations.</param>
        /// <param name="sku">SKU of the item.</param>
        /// <param name="code">Product code, e.g. UPC or EAN.</param>
        /// <param name="categories">categories.</param>
        /// <param name="options">List of options pertaining to this item&#39;s attribute variation.</param>
        /// <param name="variations">variations.</param>
        /// <param name="available">available.</param>
        /// <param name="hidden">hidden.</param>
        /// <param name="deleted">deleted.</param>
        public Item(string id = default(string), string idempotencyKey = default(string), string name = default(string), string description = default(string), string abbreviation = default(string), ProductTypeEnum? productType = default(ProductTypeEnum?), decimal priceAmount = default(decimal), PricingTypeEnum? pricingType = default(PricingTypeEnum?), Currency? priceCurrency = default(Currency?), decimal cost = default(decimal), List<string> taxIds = default(List<string>), List<string> absentAtLocationIds = default(List<string>), bool presentAtAllLocations = default(bool), string sku = default(string), string code = default(string), List<Object> categories = default(List<Object>), List<Object> options = default(List<Object>), List<Object> variations = default(List<Object>), bool? available = default(bool?), bool? hidden = default(bool?), bool? deleted = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Item and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.IdempotencyKey = idempotencyKey;
            this.Description = description;
            this.Abbreviation = abbreviation;
            this.ProductType = productType;
            this.PriceAmount = priceAmount;
            this.PricingType = pricingType;
            this.PriceCurrency = priceCurrency;
            this.Cost = cost;
            this.TaxIds = taxIds;
            this.AbsentAtLocationIds = absentAtLocationIds;
            this.PresentAtAllLocations = presentAtAllLocations;
            this.Sku = sku;
            this.Code = code;
            this.Categories = categories;
            this.Options = options;
            this.Variations = variations;
            this.Available = available;
            this.Hidden = hidden;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A value you specify that uniquely identifies this request among requests you have sent.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this request among requests you have sent.</value>
        [DataMember(Name = "idempotency_key", EmitDefaultValue = false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name = "abbreviation", EmitDefaultValue = false)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets PriceAmount
        /// </summary>
        [DataMember(Name = "price_amount", EmitDefaultValue = false)]
        public decimal PriceAmount { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public decimal Cost { get; set; }

        /// <summary>
        /// A list of Tax IDs for the product.
        /// </summary>
        /// <value>A list of Tax IDs for the product.</value>
        [DataMember(Name = "tax_ids", EmitDefaultValue = false)]
        public List<string> TaxIds { get; set; }

        /// <summary>
        /// A list of locations where the object is not present, even if present_at_all_locations is true. This can include locations that are deactivated.
        /// </summary>
        /// <value>A list of locations where the object is not present, even if present_at_all_locations is true. This can include locations that are deactivated.</value>
        [DataMember(Name = "absent_at_location_ids", EmitDefaultValue = false)]
        public List<string> AbsentAtLocationIds { get; set; }

        /// <summary>
        /// Gets or Sets PresentAtAllLocations
        /// </summary>
        [DataMember(Name = "present_at_all_locations", EmitDefaultValue = true)]
        public bool PresentAtAllLocations { get; set; }

        /// <summary>
        /// SKU of the item
        /// </summary>
        /// <value>SKU of the item</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Product code, e.g. UPC or EAN
        /// </summary>
        /// <value>Product code, e.g. UPC or EAN</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<Object> Categories { get; set; }

        /// <summary>
        /// List of options pertaining to this item&#39;s attribute variation
        /// </summary>
        /// <value>List of options pertaining to this item&#39;s attribute variation</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<Object> Options { get; set; }

        /// <summary>
        /// Gets or Sets Variations
        /// </summary>
        [DataMember(Name = "variations", EmitDefaultValue = false)]
        public List<Object> Variations { get; set; }

        /// <summary>
        /// Gets or Sets Available
        /// </summary>
        [DataMember(Name = "available", EmitDefaultValue = true)]
        public bool? Available { get; set; }

        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name = "hidden", EmitDefaultValue = true)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string _Version { get; private set; }

        /// <summary>
        /// Returns false as _Version should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerialize_Version()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool? Deleted { get; set; }

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
            sb.Append("class Item {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  PriceAmount: ").Append(PriceAmount).Append("\n");
            sb.Append("  PricingType: ").Append(PricingType).Append("\n");
            sb.Append("  PriceCurrency: ").Append(PriceCurrency).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  TaxIds: ").Append(TaxIds).Append("\n");
            sb.Append("  AbsentAtLocationIds: ").Append(AbsentAtLocationIds).Append("\n");
            sb.Append("  PresentAtAllLocations: ").Append(PresentAtAllLocations).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Variations: ").Append(Variations).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
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
                    this.IdempotencyKey == input.IdempotencyKey ||
                    (this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(input.IdempotencyKey))
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
                    this.Abbreviation == input.Abbreviation ||
                    (this.Abbreviation != null &&
                    this.Abbreviation.Equals(input.Abbreviation))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    this.ProductType.Equals(input.ProductType)
                ) && 
                (
                    this.PriceAmount == input.PriceAmount ||
                    this.PriceAmount.Equals(input.PriceAmount)
                ) && 
                (
                    this.PricingType == input.PricingType ||
                    this.PricingType.Equals(input.PricingType)
                ) && 
                (
                    this.PriceCurrency == input.PriceCurrency ||
                    this.PriceCurrency.Equals(input.PriceCurrency)
                ) && 
                (
                    this.Cost == input.Cost ||
                    this.Cost.Equals(input.Cost)
                ) && 
                (
                    this.TaxIds == input.TaxIds ||
                    this.TaxIds != null &&
                    input.TaxIds != null &&
                    this.TaxIds.SequenceEqual(input.TaxIds)
                ) && 
                (
                    this.AbsentAtLocationIds == input.AbsentAtLocationIds ||
                    this.AbsentAtLocationIds != null &&
                    input.AbsentAtLocationIds != null &&
                    this.AbsentAtLocationIds.SequenceEqual(input.AbsentAtLocationIds)
                ) && 
                (
                    this.PresentAtAllLocations == input.PresentAtAllLocations ||
                    this.PresentAtAllLocations.Equals(input.PresentAtAllLocations)
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Variations == input.Variations ||
                    this.Variations != null &&
                    input.Variations != null &&
                    this.Variations.SequenceEqual(input.Variations)
                ) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
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
                if (this.IdempotencyKey != null)
                {
                    hashCode = (hashCode * 59) + this.IdempotencyKey.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Abbreviation != null)
                {
                    hashCode = (hashCode * 59) + this.Abbreviation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProductType.GetHashCode();
                hashCode = (hashCode * 59) + this.PriceAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.PricingType.GetHashCode();
                hashCode = (hashCode * 59) + this.PriceCurrency.GetHashCode();
                hashCode = (hashCode * 59) + this.Cost.GetHashCode();
                if (this.TaxIds != null)
                {
                    hashCode = (hashCode * 59) + this.TaxIds.GetHashCode();
                }
                if (this.AbsentAtLocationIds != null)
                {
                    hashCode = (hashCode * 59) + this.AbsentAtLocationIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PresentAtAllLocations.GetHashCode();
                if (this.Sku != null)
                {
                    hashCode = (hashCode * 59) + this.Sku.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Variations != null)
                {
                    hashCode = (hashCode * 59) + this.Variations.GetHashCode();
                }
                if (this.Available != null)
                {
                    hashCode = (hashCode * 59) + this.Available.GetHashCode();
                }
                if (this.Hidden != null)
                {
                    hashCode = (hashCode * 59) + this.Hidden.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Deleted != null)
                {
                    hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
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
            // IdempotencyKey (string) maxLength
            if (this.IdempotencyKey != null && this.IdempotencyKey.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdempotencyKey, length must be less than 45.", new [] { "IdempotencyKey" });
            }

            yield break;
        }
    }

}
