/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.10.0
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
    /// BalanceSheet
    /// </summary>
    [DataContract(Name = "BalanceSheet")]
    public partial class BalanceSheet : IEquatable<BalanceSheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceSheet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceSheet" /> class.
        /// </summary>
        /// <param name="reports">reports (required).</param>
        public BalanceSheet(List<BalanceSheetReports> reports = default(List<BalanceSheetReports>))
        {
            // to ensure "reports" is required (not null)
            if (reports == null) {
                throw new ArgumentNullException("reports is a required property for BalanceSheet and cannot be null");
            }
            this.Reports = reports;
        }

        /// <summary>
        /// Gets or Sets Reports
        /// </summary>
        [DataMember(Name = "reports", IsRequired = true, EmitDefaultValue = false)]
        public List<BalanceSheetReports> Reports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceSheet {\n");
            sb.Append("  Reports: ").Append(Reports).Append("\n");
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
            return this.Equals(input as BalanceSheet);
        }

        /// <summary>
        /// Returns true if BalanceSheet instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceSheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceSheet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reports == input.Reports ||
                    this.Reports != null &&
                    input.Reports != null &&
                    this.Reports.SequenceEqual(input.Reports)
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
                if (this.Reports != null)
                {
                    hashCode = (hashCode * 59) + this.Reports.GetHashCode();
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
