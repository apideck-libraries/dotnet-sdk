/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.4
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
    /// ConnectorUnifiedApis
    /// </summary>
    [DataContract(Name = "Connector_unified_apis")]
    public partial class ConnectorUnifiedApis : IEquatable<ConnectorUnifiedApis>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public UnifiedApiId? Id { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorUnifiedApis" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="oauthScopes">oauthScopes.</param>
        public ConnectorUnifiedApis(UnifiedApiId? id = default(UnifiedApiId?), List<ConnectorOauthScopes1> oauthScopes = default(List<ConnectorOauthScopes1>))
        {
            this.Id = id;
            this.OauthScopes = oauthScopes;
        }

        /// <summary>
        /// Gets or Sets OauthScopes
        /// </summary>
        [DataMember(Name = "oauth_scopes", EmitDefaultValue = false)]
        public List<ConnectorOauthScopes1> OauthScopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorUnifiedApis {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OauthScopes: ").Append(OauthScopes).Append("\n");
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
            return this.Equals(input as ConnectorUnifiedApis);
        }

        /// <summary>
        /// Returns true if ConnectorUnifiedApis instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorUnifiedApis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorUnifiedApis input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.OauthScopes == input.OauthScopes ||
                    this.OauthScopes != null &&
                    input.OauthScopes != null &&
                    this.OauthScopes.SequenceEqual(input.OauthScopes)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.OauthScopes != null)
                {
                    hashCode = (hashCode * 59) + this.OauthScopes.GetHashCode();
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
