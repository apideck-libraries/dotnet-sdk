/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.57.0
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
    /// JobSalary
    /// </summary>
    [DataContract(Name = "Job_salary")]
    public partial class JobSalary : IEquatable<JobSalary>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobSalary" /> class.
        /// </summary>
        /// <param name="min">Minimum salary payable for the job role..</param>
        /// <param name="max">Maximum salary payable for the job role..</param>
        /// <param name="currency">currency.</param>
        public JobSalary(int min = default(int), int max = default(int), Currency? currency = default(Currency?))
        {
            this.Min = min;
            this.Max = max;
            this.Currency = currency;
        }

        /// <summary>
        /// Minimum salary payable for the job role.
        /// </summary>
        /// <value>Minimum salary payable for the job role.</value>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public int Min { get; set; }

        /// <summary>
        /// Maximum salary payable for the job role.
        /// </summary>
        /// <value>Maximum salary payable for the job role.</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public int Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobSalary {\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as JobSalary);
        }

        /// <summary>
        /// Returns true if JobSalary instances are equal
        /// </summary>
        /// <param name="input">Instance of JobSalary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobSalary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
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
                hashCode = (hashCode * 59) + this.Min.GetHashCode();
                hashCode = (hashCode * 59) + this.Max.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
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
