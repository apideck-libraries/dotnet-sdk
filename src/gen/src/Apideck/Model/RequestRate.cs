/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.6.2
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
    /// The rate at which requests for resources will be made to downstream.
    /// </summary>
    [DataContract(Name = "Request_Rate")]
    public partial class RequestRate : IEquatable<RequestRate>, IValidatableObject
    {
        /// <summary>
        /// The window unit for the rate.
        /// </summary>
        /// <value>The window unit for the rate.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum Second for value: second
            /// </summary>
            [EnumMember(Value = "second")]
            Second = 1,

            /// <summary>
            /// Enum Minute for value: minute
            /// </summary>
            [EnumMember(Value = "minute")]
            Minute = 2,

            /// <summary>
            /// Enum Hour for value: hour
            /// </summary>
            [EnumMember(Value = "hour")]
            Hour = 3,

            /// <summary>
            /// Enum Day for value: day
            /// </summary>
            [EnumMember(Value = "day")]
            Day = 4

        }


        /// <summary>
        /// The window unit for the rate.
        /// </summary>
        /// <value>The window unit for the rate.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public UnitEnum Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestRate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestRate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestRate" /> class.
        /// </summary>
        /// <param name="rate">The number of requests per window unit. (required).</param>
        /// <param name="size">Size of request window. (required).</param>
        /// <param name="unit">The window unit for the rate. (required).</param>
        public RequestRate(int rate = default(int), int size = default(int), UnitEnum unit = default(UnitEnum))
        {
            this.Rate = rate;
            this.Size = size;
            this.Unit = unit;
        }

        /// <summary>
        /// The number of requests per window unit.
        /// </summary>
        /// <value>The number of requests per window unit.</value>
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = false)]
        public int Rate { get; set; }

        /// <summary>
        /// Size of request window.
        /// </summary>
        /// <value>Size of request window.</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestRate {\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as RequestRate);
        }

        /// <summary>
        /// Returns true if RequestRate instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestRate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
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
                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                hashCode = (hashCode * 59) + this.Unit.GetHashCode();
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
