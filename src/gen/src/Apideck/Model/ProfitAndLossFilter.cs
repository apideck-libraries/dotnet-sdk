/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.3
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
    /// ProfitAndLossFilter
    /// </summary>
    [DataContract(Name = "ProfitAndLossFilter")]
    public partial class ProfitAndLossFilter : IEquatable<ProfitAndLossFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfitAndLossFilter" /> class.
        /// </summary>
        /// <param name="customerId">Filter by customer id.</param>
        /// <param name="startDate">Filter by start date. If start date is given, end date is required..</param>
        /// <param name="endDate">Filter by end date. If end date is given, start date is required..</param>
        public ProfitAndLossFilter(string customerId = default(string), string startDate = default(string), string endDate = default(string))
        {
            this.CustomerId = customerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Filter by customer id
        /// </summary>
        /// <value>Filter by customer id</value>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Filter by start date. If start date is given, end date is required.
        /// </summary>
        /// <value>Filter by start date. If start date is given, end date is required.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Filter by end date. If end date is given, start date is required.
        /// </summary>
        /// <value>Filter by end date. If end date is given, start date is required.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProfitAndLossFilter {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as ProfitAndLossFilter);
        }

        /// <summary>
        /// Returns true if ProfitAndLossFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfitAndLossFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfitAndLossFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
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
