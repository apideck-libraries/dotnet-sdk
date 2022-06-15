/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.3
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
    /// Wallet details for this payment. This field is currently not available. Reach out to our team for more info.
    /// </summary>
    [DataContract(Name = "Wallet_details")]
    public partial class WalletDetails : IEquatable<WalletDetails>, IValidatableObject
    {
        /// <summary>
        /// The status of the wallet payment. The status can be AUTHORIZED, CAPTURED, VOIDED, or FAILED.
        /// </summary>
        /// <value>The status of the wallet payment. The status can be AUTHORIZED, CAPTURED, VOIDED, or FAILED.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Authorized for value: authorized
            /// </summary>
            [EnumMember(Value = "authorized")]
            Authorized = 1,

            /// <summary>
            /// Enum Captured for value: captured
            /// </summary>
            [EnumMember(Value = "captured")]
            Captured = 2,

            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 3,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 4,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 5

        }


        /// <summary>
        /// The status of the wallet payment. The status can be AUTHORIZED, CAPTURED, VOIDED, or FAILED.
        /// </summary>
        /// <value>The status of the wallet payment. The status can be AUTHORIZED, CAPTURED, VOIDED, or FAILED.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletDetails" /> class.
        /// </summary>
        /// <param name="status">The status of the wallet payment. The status can be AUTHORIZED, CAPTURED, VOIDED, or FAILED..</param>
        public WalletDetails(StatusEnum? status = default(StatusEnum?))
        {
            this.Status = status;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletDetails {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as WalletDetails);
        }

        /// <summary>
        /// Returns true if WalletDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
