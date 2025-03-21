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
    /// ModifierGroup
    /// </summary>
    [DataContract(Name = "ModifierGroup")]
    public partial class ModifierGroup : IEquatable<ModifierGroup>, IValidatableObject
    {
        /// <summary>
        /// Defines SelectionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SelectionTypeEnum
        {
            /// <summary>
            /// Enum Single for value: single
            /// </summary>
            [EnumMember(Value = "single")]
            Single = 1,

            /// <summary>
            /// Enum Multiple for value: multiple
            /// </summary>
            [EnumMember(Value = "multiple")]
            Multiple = 2

        }


        /// <summary>
        /// Gets or Sets SelectionType
        /// </summary>
        [DataMember(Name = "selection_type", EmitDefaultValue = false)]
        public SelectionTypeEnum? SelectionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierGroup" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="alternateName">alternateName.</param>
        /// <param name="minimumRequired">minimumRequired.</param>
        /// <param name="maximumAllowed">maximumAllowed.</param>
        /// <param name="selectionType">selectionType.</param>
        /// <param name="presentAtAllLocations">presentAtAllLocations.</param>
        /// <param name="modifiers">modifiers.</param>
        /// <param name="deleted">Flag to indicate if the object is deleted..</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public ModifierGroup(string name = default(string), string alternateName = default(string), int minimumRequired = default(int), int maximumAllowed = default(int), SelectionTypeEnum? selectionType = default(SelectionTypeEnum?), bool presentAtAllLocations = default(bool), List<Object> modifiers = default(List<Object>), bool? deleted = default(bool?), string rowVersion = default(string), List<Object> passThrough = default(List<Object>))
        {
            this.Name = name;
            this.AlternateName = alternateName;
            this.MinimumRequired = minimumRequired;
            this.MaximumAllowed = maximumAllowed;
            this.SelectionType = selectionType;
            this.PresentAtAllLocations = presentAtAllLocations;
            this.Modifiers = modifiers;
            this.Deleted = deleted;
            this.RowVersion = rowVersion;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AlternateName
        /// </summary>
        [DataMember(Name = "alternate_name", EmitDefaultValue = false)]
        public string AlternateName { get; set; }

        /// <summary>
        /// Gets or Sets MinimumRequired
        /// </summary>
        [DataMember(Name = "minimum_required", EmitDefaultValue = false)]
        public int MinimumRequired { get; set; }

        /// <summary>
        /// Gets or Sets MaximumAllowed
        /// </summary>
        [DataMember(Name = "maximum_allowed", EmitDefaultValue = false)]
        public int MaximumAllowed { get; set; }

        /// <summary>
        /// Gets or Sets PresentAtAllLocations
        /// </summary>
        [DataMember(Name = "present_at_all_locations", EmitDefaultValue = true)]
        public bool PresentAtAllLocations { get; set; }

        /// <summary>
        /// Gets or Sets Modifiers
        /// </summary>
        [DataMember(Name = "modifiers", EmitDefaultValue = false)]
        public List<Object> Modifiers { get; set; }

        /// <summary>
        /// Flag to indicate if the object is deleted.
        /// </summary>
        /// <value>Flag to indicate if the object is deleted.</value>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool? Deleted { get; set; }

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
            sb.Append("class ModifierGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AlternateName: ").Append(AlternateName).Append("\n");
            sb.Append("  MinimumRequired: ").Append(MinimumRequired).Append("\n");
            sb.Append("  MaximumAllowed: ").Append(MaximumAllowed).Append("\n");
            sb.Append("  SelectionType: ").Append(SelectionType).Append("\n");
            sb.Append("  PresentAtAllLocations: ").Append(PresentAtAllLocations).Append("\n");
            sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
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
            return this.Equals(input as ModifierGroup);
        }

        /// <summary>
        /// Returns true if ModifierGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifierGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifierGroup input)
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
                    this.AlternateName == input.AlternateName ||
                    (this.AlternateName != null &&
                    this.AlternateName.Equals(input.AlternateName))
                ) && 
                (
                    this.MinimumRequired == input.MinimumRequired ||
                    this.MinimumRequired.Equals(input.MinimumRequired)
                ) && 
                (
                    this.MaximumAllowed == input.MaximumAllowed ||
                    this.MaximumAllowed.Equals(input.MaximumAllowed)
                ) && 
                (
                    this.SelectionType == input.SelectionType ||
                    this.SelectionType.Equals(input.SelectionType)
                ) && 
                (
                    this.PresentAtAllLocations == input.PresentAtAllLocations ||
                    this.PresentAtAllLocations.Equals(input.PresentAtAllLocations)
                ) && 
                (
                    this.Modifiers == input.Modifiers ||
                    this.Modifiers != null &&
                    input.Modifiers != null &&
                    this.Modifiers.SequenceEqual(input.Modifiers)
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AlternateName != null)
                {
                    hashCode = (hashCode * 59) + this.AlternateName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinimumRequired.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumAllowed.GetHashCode();
                hashCode = (hashCode * 59) + this.SelectionType.GetHashCode();
                hashCode = (hashCode * 59) + this.PresentAtAllLocations.GetHashCode();
                if (this.Modifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Modifiers.GetHashCode();
                }
                if (this.Deleted != null)
                {
                    hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
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
            yield break;
        }
    }

}
