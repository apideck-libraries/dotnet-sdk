/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.7.4
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
    /// PaymentsFilter
    /// </summary>
    [DataContract(Name = "PaymentsFilter")]
    public partial class PaymentsFilter : IEquatable<PaymentsFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsFilter" /> class.
        /// </summary>
        /// <param name="invoiceNumber">Invoice number for payments to filter on.</param>
        public PaymentsFilter(string invoiceNumber = default(string))
        {
            this.InvoiceNumber = invoiceNumber;
        }

        /// <summary>
        /// Invoice number for payments to filter on
        /// </summary>
        /// <value>Invoice number for payments to filter on</value>
        [DataMember(Name = "invoice_number", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentsFilter {\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
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
            return this.Equals(input as PaymentsFilter);
        }

        /// <summary>
        /// Returns true if PaymentsFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
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
                if (this.InvoiceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNumber.GetHashCode();
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
