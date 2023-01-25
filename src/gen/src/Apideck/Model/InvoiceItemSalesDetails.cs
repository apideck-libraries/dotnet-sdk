/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.87.0
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
    /// InvoiceItemSalesDetails
    /// </summary>
    [DataContract(Name = "InvoiceItem_sales_details")]
    public partial class InvoiceItemSalesDetails : IEquatable<InvoiceItemSalesDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceItemSalesDetails" /> class.
        /// </summary>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="unitOfMeasure">Description of the unit type the item is sold as, ie: kg, hour..</param>
        /// <param name="taxInclusive">Amounts are including tax.</param>
        /// <param name="taxRate">taxRate.</param>
        public InvoiceItemSalesDetails(decimal? unitPrice = default(decimal?), string unitOfMeasure = default(string), bool? taxInclusive = default(bool?), LinkedTaxRate taxRate = default(LinkedTaxRate))
        {
            this.UnitPrice = unitPrice;
            this.UnitOfMeasure = unitOfMeasure;
            this.TaxInclusive = taxInclusive;
            this.TaxRate = taxRate;
        }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name = "unit_price", EmitDefaultValue = true)]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Description of the unit type the item is sold as, ie: kg, hour.
        /// </summary>
        /// <value>Description of the unit type the item is sold as, ie: kg, hour.</value>
        [DataMember(Name = "unit_of_measure", EmitDefaultValue = true)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Amounts are including tax
        /// </summary>
        /// <value>Amounts are including tax</value>
        [DataMember(Name = "tax_inclusive", EmitDefaultValue = true)]
        public bool? TaxInclusive { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public LinkedTaxRate TaxRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceItemSalesDetails {\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
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
            return this.Equals(input as InvoiceItemSalesDetails);
        }

        /// <summary>
        /// Returns true if InvoiceItemSalesDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceItemSalesDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceItemSalesDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.TaxInclusive == input.TaxInclusive ||
                    (this.TaxInclusive != null &&
                    this.TaxInclusive.Equals(input.TaxInclusive))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
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
                if (this.UnitPrice != null)
                {
                    hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                }
                if (this.UnitOfMeasure != null)
                {
                    hashCode = (hashCode * 59) + this.UnitOfMeasure.GetHashCode();
                }
                if (this.TaxInclusive != null)
                {
                    hashCode = (hashCode * 59) + this.TaxInclusive.GetHashCode();
                }
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
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
