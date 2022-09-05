/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.47.0
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
    /// ConnectorOauthScopes
    /// </summary>
    [DataContract(Name = "Connector_oauth_scopes")]
    public partial class ConnectorOauthScopes : IEquatable<ConnectorOauthScopes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorOauthScopes" /> class.
        /// </summary>
        /// <param name="id">ID of the OAuth scope..</param>
        /// <param name="label">Label of the OAuth scope..</param>
        /// <param name="defaultApis">List of Unified APIs that request this OAuth Scope by default. Application owners can customize the requested scopes..</param>
        public ConnectorOauthScopes(string id = default(string), string label = default(string), List<string> defaultApis = default(List<string>))
        {
            this.Id = id;
            this.Label = label;
            this.DefaultApis = defaultApis;
        }

        /// <summary>
        /// ID of the OAuth scope.
        /// </summary>
        /// <value>ID of the OAuth scope.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Label of the OAuth scope.
        /// </summary>
        /// <value>Label of the OAuth scope.</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// List of Unified APIs that request this OAuth Scope by default. Application owners can customize the requested scopes.
        /// </summary>
        /// <value>List of Unified APIs that request this OAuth Scope by default. Application owners can customize the requested scopes.</value>
        [DataMember(Name = "default_apis", EmitDefaultValue = false)]
        public List<string> DefaultApis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorOauthScopes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  DefaultApis: ").Append(DefaultApis).Append("\n");
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
            return this.Equals(input as ConnectorOauthScopes);
        }

        /// <summary>
        /// Returns true if ConnectorOauthScopes instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorOauthScopes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorOauthScopes input)
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
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.DefaultApis == input.DefaultApis ||
                    this.DefaultApis != null &&
                    input.DefaultApis != null &&
                    this.DefaultApis.SequenceEqual(input.DefaultApis)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.DefaultApis != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultApis.GetHashCode();
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
