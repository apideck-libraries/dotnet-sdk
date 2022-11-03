/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.77.0
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
    /// RequestCountAllocation
    /// </summary>
    [DataContract(Name = "RequestCountAllocation")]
    public partial class RequestCountAllocation : IEquatable<RequestCountAllocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCountAllocation" /> class.
        /// </summary>
        /// <param name="unify">unify.</param>
        /// <param name="proxy">proxy.</param>
        /// <param name="vault">vault.</param>
        public RequestCountAllocation(decimal unify = default(decimal), decimal proxy = default(decimal), decimal vault = default(decimal))
        {
            this.Unify = unify;
            this.Proxy = proxy;
            this.Vault = vault;
        }

        /// <summary>
        /// Gets or Sets Unify
        /// </summary>
        [DataMember(Name = "unify", EmitDefaultValue = false)]
        public decimal Unify { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name = "proxy", EmitDefaultValue = false)]
        public decimal Proxy { get; set; }

        /// <summary>
        /// Gets or Sets Vault
        /// </summary>
        [DataMember(Name = "vault", EmitDefaultValue = false)]
        public decimal Vault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestCountAllocation {\n");
            sb.Append("  Unify: ").Append(Unify).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  Vault: ").Append(Vault).Append("\n");
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
            return this.Equals(input as RequestCountAllocation);
        }

        /// <summary>
        /// Returns true if RequestCountAllocation instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestCountAllocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestCountAllocation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Unify == input.Unify ||
                    this.Unify.Equals(input.Unify)
                ) && 
                (
                    this.Proxy == input.Proxy ||
                    this.Proxy.Equals(input.Proxy)
                ) && 
                (
                    this.Vault == input.Vault ||
                    this.Vault.Equals(input.Vault)
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
                hashCode = (hashCode * 59) + this.Unify.GetHashCode();
                hashCode = (hashCode * 59) + this.Proxy.GetHashCode();
                hashCode = (hashCode * 59) + this.Vault.GetHashCode();
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
