/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.13.0
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
    /// OutstandingBalanceBySupplier
    /// </summary>
    [DataContract(Name = "OutstandingBalanceBySupplier")]
    public partial class OutstandingBalanceBySupplier : IEquatable<OutstandingBalanceBySupplier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutstandingBalanceBySupplier" /> class.
        /// </summary>
        /// <param name="supplierId">Unique identifier for the supplier..</param>
        /// <param name="supplierName">Full name of the supplier..</param>
        /// <param name="outstandingBalancesByCurrency">outstandingBalancesByCurrency.</param>
        public OutstandingBalanceBySupplier(string supplierId = default(string), string supplierName = default(string), List<OutstandingBalanceByCurrency> outstandingBalancesByCurrency = default(List<OutstandingBalanceByCurrency>))
        {
            this.SupplierId = supplierId;
            this.SupplierName = supplierName;
            this.OutstandingBalancesByCurrency = outstandingBalancesByCurrency;
        }

        /// <summary>
        /// Unique identifier for the supplier.
        /// </summary>
        /// <value>Unique identifier for the supplier.</value>
        [DataMember(Name = "supplier_id", EmitDefaultValue = false)]
        public string SupplierId { get; set; }

        /// <summary>
        /// Full name of the supplier.
        /// </summary>
        /// <value>Full name of the supplier.</value>
        [DataMember(Name = "supplier_name", EmitDefaultValue = false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or Sets OutstandingBalancesByCurrency
        /// </summary>
        [DataMember(Name = "outstanding_balances_by_currency", EmitDefaultValue = false)]
        public List<OutstandingBalanceByCurrency> OutstandingBalancesByCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutstandingBalanceBySupplier {\n");
            sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  OutstandingBalancesByCurrency: ").Append(OutstandingBalancesByCurrency).Append("\n");
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
            return this.Equals(input as OutstandingBalanceBySupplier);
        }

        /// <summary>
        /// Returns true if OutstandingBalanceBySupplier instances are equal
        /// </summary>
        /// <param name="input">Instance of OutstandingBalanceBySupplier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutstandingBalanceBySupplier input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SupplierId == input.SupplierId ||
                    (this.SupplierId != null &&
                    this.SupplierId.Equals(input.SupplierId))
                ) && 
                (
                    this.SupplierName == input.SupplierName ||
                    (this.SupplierName != null &&
                    this.SupplierName.Equals(input.SupplierName))
                ) && 
                (
                    this.OutstandingBalancesByCurrency == input.OutstandingBalancesByCurrency ||
                    this.OutstandingBalancesByCurrency != null &&
                    input.OutstandingBalancesByCurrency != null &&
                    this.OutstandingBalancesByCurrency.SequenceEqual(input.OutstandingBalancesByCurrency)
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
                if (this.SupplierId != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierId.GetHashCode();
                }
                if (this.SupplierName != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierName.GetHashCode();
                }
                if (this.OutstandingBalancesByCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.OutstandingBalancesByCurrency.GetHashCode();
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
