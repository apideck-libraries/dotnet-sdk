/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.3
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
    /// InvoiceItemsFilter
    /// </summary>
    [DataContract(Name = "InvoiceItemsFilter")]
    public partial class InvoiceItemsFilter : IEquatable<InvoiceItemsFilter>, IValidatableObject
    {
        /// <summary>
        /// The type of invoice item, indicating whether it is an inventory item, a service, or another type.
        /// </summary>
        /// <value>The type of invoice item, indicating whether it is an inventory item, a service, or another type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Inventory for value: inventory
            /// </summary>
            [EnumMember(Value = "inventory")]
            Inventory = 1,

            /// <summary>
            /// Enum Service for value: service
            /// </summary>
            [EnumMember(Value = "service")]
            Service = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3

        }


        /// <summary>
        /// The type of invoice item, indicating whether it is an inventory item, a service, or another type.
        /// </summary>
        /// <value>The type of invoice item, indicating whether it is an inventory item, a service, or another type.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceItemsFilter" /> class.
        /// </summary>
        /// <param name="name">Name of Invoice Items to search for.</param>
        /// <param name="type">The type of invoice item, indicating whether it is an inventory item, a service, or another type..</param>
        public InvoiceItemsFilter(string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Name of Invoice Items to search for
        /// </summary>
        /// <value>Name of Invoice Items to search for</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceItemsFilter {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as InvoiceItemsFilter);
        }

        /// <summary>
        /// Returns true if InvoiceItemsFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceItemsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceItemsFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
