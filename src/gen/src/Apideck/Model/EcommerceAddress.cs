/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.89.0
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
    /// An object representing a shipping or billing address.
    /// </summary>
    [DataContract(Name = "EcommerceAddress")]
    public partial class EcommerceAddress : IEquatable<EcommerceAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceAddress" /> class.
        /// </summary>
        /// <param name="line1">Address line 1 of the billing address..</param>
        /// <param name="line2">Address line 2 of the billing address..</param>
        /// <param name="city">City of the billing address..</param>
        /// <param name="state">State/province of the billing address..</param>
        /// <param name="postalCode">Postal/ZIP code of the billing address..</param>
        /// <param name="country">Country of the billing address..</param>
        public EcommerceAddress(string line1 = default(string), string line2 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string country = default(string))
        {
            this.Line1 = line1;
            this.Line2 = line2;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
        }

        /// <summary>
        /// Address line 1 of the billing address.
        /// </summary>
        /// <value>Address line 1 of the billing address.</value>
        [DataMember(Name = "line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Address line 2 of the billing address.
        /// </summary>
        /// <value>Address line 2 of the billing address.</value>
        [DataMember(Name = "line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// City of the billing address.
        /// </summary>
        /// <value>City of the billing address.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// State/province of the billing address.
        /// </summary>
        /// <value>State/province of the billing address.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Postal/ZIP code of the billing address.
        /// </summary>
        /// <value>Postal/ZIP code of the billing address.</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country of the billing address.
        /// </summary>
        /// <value>Country of the billing address.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcommerceAddress {\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as EcommerceAddress);
        }

        /// <summary>
        /// Returns true if EcommerceAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Line1 != null)
                {
                    hashCode = (hashCode * 59) + this.Line1.GetHashCode();
                }
                if (this.Line2 != null)
                {
                    hashCode = (hashCode * 59) + this.Line2.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
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
            // Country (string) maxLength
            if (this.Country != null && this.Country.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 2.", new [] { "Country" });
            }

            yield break;
        }
    }

}
