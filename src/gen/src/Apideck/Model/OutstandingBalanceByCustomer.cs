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
    /// OutstandingBalanceByCustomer
    /// </summary>
    [DataContract(Name = "OutstandingBalanceByCustomer")]
    public partial class OutstandingBalanceByCustomer : IEquatable<OutstandingBalanceByCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutstandingBalanceByCustomer" /> class.
        /// </summary>
        /// <param name="customerId">Unique identifier for the customer..</param>
        /// <param name="customerName">Full name of the customer..</param>
        /// <param name="outstandingBalancesByCurrency">outstandingBalancesByCurrency.</param>
        public OutstandingBalanceByCustomer(string customerId = default(string), string customerName = default(string), List<OutstandingBalanceByCurrency> outstandingBalancesByCurrency = default(List<OutstandingBalanceByCurrency>))
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.OutstandingBalancesByCurrency = outstandingBalancesByCurrency;
        }

        /// <summary>
        /// Unique identifier for the customer.
        /// </summary>
        /// <value>Unique identifier for the customer.</value>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Full name of the customer.
        /// </summary>
        /// <value>Full name of the customer.</value>
        [DataMember(Name = "customer_name", EmitDefaultValue = false)]
        public string CustomerName { get; set; }

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
            sb.Append("class OutstandingBalanceByCustomer {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
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
            return this.Equals(input as OutstandingBalanceByCustomer);
        }

        /// <summary>
        /// Returns true if OutstandingBalanceByCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of OutstandingBalanceByCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutstandingBalanceByCustomer input)
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
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
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
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.CustomerName != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerName.GetHashCode();
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
