/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.55.0
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
        /// <param name="name">name.</param>
        /// <param name="value">value.</param>
        /// <param name="winProbability">The expected probability of winning an Opportunity in this Pipeline Stage. Valid values are [0-100]..</param>
        /// <param name="displayOrder">displayOrder.</param>
        public PipelineStages(string name = default(string), string value = default(string), int winProbability = default(int), int displayOrder = default(int))
        {
            this.Name = name;
            this.Value = value;
            this.WinProbability = winProbability;
            this.DisplayOrder = displayOrder;
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
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The expected probability of winning an Opportunity in this Pipeline Stage. Valid values are [0-100].
        /// </summary>
        /// <value>The expected probability of winning an Opportunity in this Pipeline Stage. Valid values are [0-100].</value>
        [DataMember(Name = "win_probability", EmitDefaultValue = false)]
        public int WinProbability { get; set; }

        /// <summary>
        /// Gets or Sets DisplayOrder
        /// </summary>
        [DataMember(Name = "display_order", EmitDefaultValue = false)]
        public int DisplayOrder { get; set; }

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
                    this.WinProbability.Equals(input.WinProbability)
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    this.DisplayOrder.Equals(input.DisplayOrder)
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
                hashCode = (hashCode * 59) + this.WinProbability.GetHashCode();
                hashCode = (hashCode * 59) + this.DisplayOrder.GetHashCode();
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
