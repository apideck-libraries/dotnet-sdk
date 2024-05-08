/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.4.1
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
    /// Response metadata
    /// </summary>
    [DataContract(Name = "Meta")]
    public partial class Meta : IEquatable<Meta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        /// <param name="itemsOnPage">Number of items returned in the data property of the response.</param>
        /// <param name="cursors">cursors.</param>
        public Meta(int itemsOnPage = default(int), MetaCursors cursors = default(MetaCursors))
        {
            this.ItemsOnPage = itemsOnPage;
            this.Cursors = cursors;
        }

        /// <summary>
        /// Number of items returned in the data property of the response
        /// </summary>
        /// <value>Number of items returned in the data property of the response</value>
        [DataMember(Name = "items_on_page", EmitDefaultValue = false)]
        public int ItemsOnPage { get; set; }

        /// <summary>
        /// Gets or Sets Cursors
        /// </summary>
        [DataMember(Name = "cursors", EmitDefaultValue = false)]
        public MetaCursors Cursors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Meta {\n");
            sb.Append("  ItemsOnPage: ").Append(ItemsOnPage).Append("\n");
            sb.Append("  Cursors: ").Append(Cursors).Append("\n");
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
            return this.Equals(input as Meta);
        }

        /// <summary>
        /// Returns true if Meta instances are equal
        /// </summary>
        /// <param name="input">Instance of Meta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Meta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemsOnPage == input.ItemsOnPage ||
                    this.ItemsOnPage.Equals(input.ItemsOnPage)
                ) && 
                (
                    this.Cursors == input.Cursors ||
                    (this.Cursors != null &&
                    this.Cursors.Equals(input.Cursors))
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
                hashCode = (hashCode * 59) + this.ItemsOnPage.GetHashCode();
                if (this.Cursors != null)
                {
                    hashCode = (hashCode * 59) + this.Cursors.GetHashCode();
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
