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
    /// Modifier
    /// </summary>
    [DataContract(Name = "Modifier")]
    public partial class Modifier : IEquatable<Modifier>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Modifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Modifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Modifier" /> class.
        /// </summary>
        /// <param name="idempotencyKey">A value you specify that uniquely identifies this request among requests you have sent..</param>
        /// <param name="name">name (required).</param>
        /// <param name="alternateName">alternateName.</param>
        /// <param name="priceAmount">priceAmount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="modifierGroupId">modifierGroupId (required).</param>
        /// <param name="available">available.</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public Modifier(string idempotencyKey = default(string), string name = default(string), string alternateName = default(string), decimal priceAmount = default(decimal), Currency? currency = default(Currency?), string modifierGroupId = default(string), bool? available = default(bool?), List<Object> passThrough = default(List<Object>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Modifier and cannot be null");
            }
            this.Name = name;
            // to ensure "modifierGroupId" is required (not null)
            if (modifierGroupId == null) {
                throw new ArgumentNullException("modifierGroupId is a required property for Modifier and cannot be null");
            }
            this.ModifierGroupId = modifierGroupId;
            this.IdempotencyKey = idempotencyKey;
            this.AlternateName = alternateName;
            this.PriceAmount = priceAmount;
            this.Currency = currency;
            this.Available = available;
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
        /// Gets or Sets AlternateName
        /// </summary>
        [DataMember(Name = "alternate_name", EmitDefaultValue = false)]
        public string AlternateName { get; set; }

        /// <summary>
        /// Gets or Sets PriceAmount
        /// </summary>
        [DataMember(Name = "price_amount", EmitDefaultValue = false)]
        public decimal PriceAmount { get; set; }

        /// <summary>
        /// Gets or Sets ModifierGroupId
        /// </summary>
        [DataMember(Name = "modifier_group_id", IsRequired = true, EmitDefaultValue = false)]
        public string ModifierGroupId { get; set; }

        /// <summary>
        /// Gets or Sets Available
        /// </summary>
        [DataMember(Name = "available", EmitDefaultValue = true)]
        public bool? Available { get; set; }

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
            sb.Append("class Modifier {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AlternateName: ").Append(AlternateName).Append("\n");
            sb.Append("  PriceAmount: ").Append(PriceAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ModifierGroupId: ").Append(ModifierGroupId).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as Modifier);
        }

        /// <summary>
        /// Returns true if Modifier instances are equal
        /// </summary>
        /// <param name="input">Instance of Modifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Modifier input)
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
                    this.AlternateName == input.AlternateName ||
                    (this.AlternateName != null &&
                    this.AlternateName.Equals(input.AlternateName))
                ) && 
                (
                    this.PriceAmount == input.PriceAmount ||
                    this.PriceAmount.Equals(input.PriceAmount)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.ModifierGroupId == input.ModifierGroupId ||
                    (this.ModifierGroupId != null &&
                    this.ModifierGroupId.Equals(input.ModifierGroupId))
                ) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
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
                if (this.IdempotencyKey != null)
                {
                    hashCode = (hashCode * 59) + this.IdempotencyKey.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AlternateName != null)
                {
                    hashCode = (hashCode * 59) + this.AlternateName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PriceAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.ModifierGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.ModifierGroupId.GetHashCode();
                }
                if (this.Available != null)
                {
                    hashCode = (hashCode * 59) + this.Available.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
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
            // IdempotencyKey (string) maxLength
            if (this.IdempotencyKey != null && this.IdempotencyKey.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdempotencyKey, length must be less than 45.", new [] { "IdempotencyKey" });
            }

            yield break;
        }
    }

}
