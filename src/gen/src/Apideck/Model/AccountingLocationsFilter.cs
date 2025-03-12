/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.12.3
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
    /// AccountingLocationsFilter
    /// </summary>
    [DataContract(Name = "AccountingLocationsFilter")]
    public partial class AccountingLocationsFilter : IEquatable<AccountingLocationsFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingLocationsFilter" /> class.
        /// </summary>
        /// <param name="subsidiary">Id of the subsidiary to search for.</param>
        public AccountingLocationsFilter(string subsidiary = default(string))
        {
            this.Subsidiary = subsidiary;
        }

        /// <summary>
        /// Id of the subsidiary to search for
        /// </summary>
        /// <value>Id of the subsidiary to search for</value>
        [DataMember(Name = "subsidiary", EmitDefaultValue = false)]
        public string Subsidiary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountingLocationsFilter {\n");
            sb.Append("  Subsidiary: ").Append(Subsidiary).Append("\n");
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
            return this.Equals(input as AccountingLocationsFilter);
        }

        /// <summary>
        /// Returns true if AccountingLocationsFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountingLocationsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountingLocationsFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Subsidiary == input.Subsidiary ||
                    (this.Subsidiary != null &&
                    this.Subsidiary.Equals(input.Subsidiary))
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
                if (this.Subsidiary != null)
                {
                    hashCode = (hashCode * 59) + this.Subsidiary.GetHashCode();
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
