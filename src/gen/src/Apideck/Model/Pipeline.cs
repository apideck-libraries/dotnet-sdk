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
    /// Pipeline
    /// </summary>
    [DataContract(Name = "Pipeline")]
    public partial class Pipeline : IEquatable<Pipeline>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Pipeline() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the Pipeline..</param>
        /// <param name="name">The name of the Pipeline. (required).</param>
        /// <param name="currency">currency.</param>
        /// <param name="archived">Whether the Pipeline is archived or not..</param>
        /// <param name="active">Whether the Pipeline is active or not..</param>
        /// <param name="displayOrder">The order in which the Pipeline is displayed in the UI..</param>
        /// <param name="winProbabilityEnabled">Whether the Pipeline has win probability enabled or not..</param>
        /// <param name="stages">The Pipeline Stages..</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public Pipeline(string id = default(string), string name = default(string), Currency? currency = default(Currency?), bool archived = default(bool), bool active = default(bool), int? displayOrder = default(int?), bool winProbabilityEnabled = default(bool), List<PipelineStages> stages = default(List<PipelineStages>), List<Object> passThrough = default(List<Object>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Pipeline and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.Currency = currency;
            this.Archived = archived;
            this.Active = active;
            this.DisplayOrder = displayOrder;
            this.WinProbabilityEnabled = winProbabilityEnabled;
            this.Stages = stages;
            this.PassThrough = passThrough;
        }

        /// <summary>
        /// The unique identifier of the Pipeline.
        /// </summary>
        /// <value>The unique identifier of the Pipeline.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the Pipeline.
        /// </summary>
        /// <value>The name of the Pipeline.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether the Pipeline is archived or not.
        /// </summary>
        /// <value>Whether the Pipeline is archived or not.</value>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Whether the Pipeline is active or not.
        /// </summary>
        /// <value>Whether the Pipeline is active or not.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// The order in which the Pipeline is displayed in the UI.
        /// </summary>
        /// <value>The order in which the Pipeline is displayed in the UI.</value>
        [DataMember(Name = "display_order", EmitDefaultValue = true)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Whether the Pipeline has win probability enabled or not.
        /// </summary>
        /// <value>Whether the Pipeline has win probability enabled or not.</value>
        [DataMember(Name = "win_probability_enabled", EmitDefaultValue = true)]
        public bool WinProbabilityEnabled { get; set; }

        /// <summary>
        /// The Pipeline Stages.
        /// </summary>
        /// <value>The Pipeline Stages.</value>
        [DataMember(Name = "stages", EmitDefaultValue = false)]
        public List<PipelineStages> Stages { get; set; }

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
            sb.Append("class Pipeline {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  WinProbabilityEnabled: ").Append(WinProbabilityEnabled).Append("\n");
            sb.Append("  Stages: ").Append(Stages).Append("\n");
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
            return this.Equals(input as Pipeline);
        }

        /// <summary>
        /// Returns true if Pipeline instances are equal
        /// </summary>
        /// <param name="input">Instance of Pipeline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pipeline input)
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
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.WinProbabilityEnabled == input.WinProbabilityEnabled ||
                    this.WinProbabilityEnabled.Equals(input.WinProbabilityEnabled)
                ) && 
                (
                    this.Stages == input.Stages ||
                    this.Stages != null &&
                    input.Stages != null &&
                    this.Stages.SequenceEqual(input.Stages)
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
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.DisplayOrder != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayOrder.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WinProbabilityEnabled.GetHashCode();
                if (this.Stages != null)
                {
                    hashCode = (hashCode * 59) + this.Stages.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
