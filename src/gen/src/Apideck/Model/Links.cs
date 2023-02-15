/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.90.0
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
    /// Links to navigate to previous or next pages through the API
    /// </summary>
    [DataContract(Name = "Links")]
    public partial class Links : IEquatable<Links>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Links" /> class.
        /// </summary>
        /// <param name="previous">Link to navigate to the previous page through the API.</param>
        /// <param name="current">Link to navigate to the current page through the API.</param>
        /// <param name="next">Link to navigate to the previous page through the API.</param>
        public Links(string previous = default(string), string current = default(string), string next = default(string))
        {
            this.Previous = previous;
            this.Current = current;
            this.Next = next;
        }

        /// <summary>
        /// Link to navigate to the previous page through the API
        /// </summary>
        /// <value>Link to navigate to the previous page through the API</value>
        [DataMember(Name = "previous", EmitDefaultValue = true)]
        public string Previous { get; set; }

        /// <summary>
        /// Link to navigate to the current page through the API
        /// </summary>
        /// <value>Link to navigate to the current page through the API</value>
        [DataMember(Name = "current", EmitDefaultValue = false)]
        public string Current { get; set; }

        /// <summary>
        /// Link to navigate to the previous page through the API
        /// </summary>
        /// <value>Link to navigate to the previous page through the API</value>
        [DataMember(Name = "next", EmitDefaultValue = true)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Links {\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
            return this.Equals(input as Links);
        }

        /// <summary>
        /// Returns true if Links instances are equal
        /// </summary>
        /// <param name="input">Instance of Links to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Links input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Previous == input.Previous ||
                    (this.Previous != null &&
                    this.Previous.Equals(input.Previous))
                ) && 
                (
                    this.Current == input.Current ||
                    (this.Current != null &&
                    this.Current.Equals(input.Current))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
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
                if (this.Previous != null)
                {
                    hashCode = (hashCode * 59) + this.Previous.GetHashCode();
                }
                if (this.Current != null)
                {
                    hashCode = (hashCode * 59) + this.Current.GetHashCode();
                }
                if (this.Next != null)
                {
                    hashCode = (hashCode * 59) + this.Next.GetHashCode();
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
