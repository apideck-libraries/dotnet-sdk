/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.3.1
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
    /// LinkedLedgerAccount
    /// </summary>
    [DataContract(Name = "LinkedLedgerAccount")]
    public partial class LinkedLedgerAccount : IEquatable<LinkedLedgerAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedLedgerAccount" /> class.
        /// </summary>
        /// <param name="id">The unique identifier for the account..</param>
        /// <param name="nominalCode">The nominal code of the account..</param>
        /// <param name="code">The code assigned to the account..</param>
        public LinkedLedgerAccount(string id = default(string), string nominalCode = default(string), string code = default(string))
        {
            this.Id = id;
            this.NominalCode = nominalCode;
            this.Code = code;
        }

        /// <summary>
        /// The unique identifier for the account.
        /// </summary>
        /// <value>The unique identifier for the account.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// The nominal code of the account.
        /// </summary>
        /// <value>The nominal code of the account.</value>
        [DataMember(Name = "nominal_code", EmitDefaultValue = true)]
        public string NominalCode { get; set; }

        /// <summary>
        /// The code assigned to the account.
        /// </summary>
        /// <value>The code assigned to the account.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkedLedgerAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NominalCode: ").Append(NominalCode).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as LinkedLedgerAccount);
        }

        /// <summary>
        /// Returns true if LinkedLedgerAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedLedgerAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedLedgerAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NominalCode == input.NominalCode ||
                    (this.NominalCode != null &&
                    this.NominalCode.Equals(input.NominalCode))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NominalCode != null)
                {
                    hashCode = (hashCode * 59) + this.NominalCode.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
