/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.5
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
    /// ConnectionImportDataCredentials
    /// </summary>
    [DataContract(Name = "ConnectionImportData_credentials")]
    public partial class ConnectionImportDataCredentials : IEquatable<ConnectionImportDataCredentials>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionImportDataCredentials" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionImportDataCredentials() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionImportDataCredentials" /> class.
        /// </summary>
        /// <param name="refreshToken">The refresh token can be used to obtain a new access token. (required).</param>
        /// <param name="accessToken">Access token.</param>
        /// <param name="issuedAt">The datetime at which the token was issued. If omitted the token will be queued for refresh..</param>
        /// <param name="expiresIn">The number of seconds until the token expires. If omitted the token will be queued for refresh..</param>
        public ConnectionImportDataCredentials(string refreshToken = default(string), string accessToken = default(string), DateTime? issuedAt = default(DateTime?), int? expiresIn = default(int?))
        {
            // to ensure "refreshToken" is required (not null)
            if (refreshToken == null) {
                throw new ArgumentNullException("refreshToken is a required property for ConnectionImportDataCredentials and cannot be null");
            }
            this.RefreshToken = refreshToken;
            this.AccessToken = accessToken;
            this.IssuedAt = issuedAt;
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// The refresh token can be used to obtain a new access token.
        /// </summary>
        /// <value>The refresh token can be used to obtain a new access token.</value>
        [DataMember(Name = "refresh_token", IsRequired = true, EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Access token
        /// </summary>
        /// <value>Access token</value>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The datetime at which the token was issued. If omitted the token will be queued for refresh.
        /// </summary>
        /// <value>The datetime at which the token was issued. If omitted the token will be queued for refresh.</value>
        [DataMember(Name = "issued_at", EmitDefaultValue = true)]
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// The number of seconds until the token expires. If omitted the token will be queued for refresh.
        /// </summary>
        /// <value>The number of seconds until the token expires. If omitted the token will be queued for refresh.</value>
        [DataMember(Name = "expires_in", EmitDefaultValue = true)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectionImportDataCredentials {\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
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
            return this.Equals(input as ConnectionImportDataCredentials);
        }

        /// <summary>
        /// Returns true if ConnectionImportDataCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionImportDataCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionImportDataCredentials input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.IssuedAt == input.IssuedAt ||
                    (this.IssuedAt != null &&
                    this.IssuedAt.Equals(input.IssuedAt))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
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
                if (this.RefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshToken.GetHashCode();
                }
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                if (this.IssuedAt != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedAt.GetHashCode();
                }
                if (this.ExpiresIn != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
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
