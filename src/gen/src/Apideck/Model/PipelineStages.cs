/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.3.6
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
    /// PipelineStages
    /// </summary>
    [DataContract(Name = "Pipeline_stages")]
    public partial class PipelineStages : IEquatable<PipelineStages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineStages" /> class.
        /// </summary>
        /// <param name="name">The name of the Pipeline Stage..</param>
        /// <param name="value">The value of the Pipeline Stage..</param>
        /// <param name="winProbability">The expected probability of winning an Opportunity in this Pipeline Stage. Valid values are [0-100]..</param>
        /// <param name="displayOrder">The order in which the Pipeline Stage is displayed in the UI..</param>
        public PipelineStages(string name = default(string), string value = default(string), int? winProbability = default(int?), int? displayOrder = default(int?))
        {
            this.Name = name;
            this.Value = value;
            this.WinProbability = winProbability;
            this.DisplayOrder = displayOrder;
        }

        /// <summary>
        /// The unique identifier of the Pipeline Stage.
        /// </summary>
        /// <value>The unique identifier of the Pipeline Stage.</value>
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
        /// The name of the Pipeline Stage.
        /// </summary>
        /// <value>The name of the Pipeline Stage.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the Pipeline Stage.
        /// </summary>
        /// <value>The value of the Pipeline Stage.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// The expected probability of winning an Opportunity in this Pipeline Stage. Valid values are [0-100].
        /// </summary>
        /// <value>The expected probability of winning an Opportunity in this Pipeline Stage. Valid values are [0-100].</value>
        [DataMember(Name = "win_probability", EmitDefaultValue = true)]
        public int? WinProbability { get; set; }

        /// <summary>
        /// The order in which the Pipeline Stage is displayed in the UI.
        /// </summary>
        /// <value>The order in which the Pipeline Stage is displayed in the UI.</value>
        [DataMember(Name = "display_order", EmitDefaultValue = true)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PipelineStages {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  WinProbability: ").Append(WinProbability).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
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
            return this.Equals(input as PipelineStages);
        }

        /// <summary>
        /// Returns true if PipelineStages instances are equal
        /// </summary>
        /// <param name="input">Instance of PipelineStages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PipelineStages input)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.WinProbability == input.WinProbability ||
                    (this.WinProbability != null &&
                    this.WinProbability.Equals(input.WinProbability))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.WinProbability != null)
                {
                    hashCode = (hashCode * 59) + this.WinProbability.GetHashCode();
                }
                if (this.DisplayOrder != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayOrder.GetHashCode();
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
