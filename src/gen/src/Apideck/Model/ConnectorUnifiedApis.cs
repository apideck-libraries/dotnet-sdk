/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.4.0
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
        /// <param name="name">Name of the API..</param>
        /// <param name="oauthScopes">oauthScopes.</param>
        /// <param name="supportedResources">List of resources that are supported on the connector..</param>
        /// <param name="downstreamUnsupportedResources">List of resources that are not supported on the downstream..</param>
        /// <param name="supportedEvents">List of events that are supported on the connector for this Unified API..</param>
        public ConnectorUnifiedApis(UnifiedApiId? id = default(UnifiedApiId?), string name = default(string), List<ConnectorOauthScopes1> oauthScopes = default(List<ConnectorOauthScopes1>), List<LinkedConnectorResource> supportedResources = default(List<LinkedConnectorResource>), List<string> downstreamUnsupportedResources = default(List<string>), List<ConnectorEvent> supportedEvents = default(List<ConnectorEvent>))
        {
            this.Id = id;
            this.Name = name;
            this.OauthScopes = oauthScopes;
            this.SupportedResources = supportedResources;
            this.DownstreamUnsupportedResources = downstreamUnsupportedResources;
            this.SupportedEvents = supportedEvents;
        }

        /// <summary>
        /// Name of the API.
        /// </summary>
        /// <value>Name of the API.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OauthScopes
        /// </summary>
        [DataMember(Name = "oauth_scopes", EmitDefaultValue = false)]
        public List<ConnectorOauthScopes1> OauthScopes { get; set; }

        /// <summary>
        /// List of resources that are supported on the connector.
        /// </summary>
        /// <value>List of resources that are supported on the connector.</value>
        [DataMember(Name = "supported_resources", EmitDefaultValue = false)]
        public List<LinkedConnectorResource> SupportedResources { get; set; }

        /// <summary>
        /// List of resources that are not supported on the downstream.
        /// </summary>
        /// <value>List of resources that are not supported on the downstream.</value>
        [DataMember(Name = "downstream_unsupported_resources", EmitDefaultValue = false)]
        public List<string> DownstreamUnsupportedResources { get; set; }

        /// <summary>
        /// List of events that are supported on the connector for this Unified API.
        /// </summary>
        /// <value>List of events that are supported on the connector for this Unified API.</value>
        [DataMember(Name = "supported_events", EmitDefaultValue = false)]
        public List<ConnectorEvent> SupportedEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorUnifiedApis {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OauthScopes: ").Append(OauthScopes).Append("\n");
            sb.Append("  SupportedResources: ").Append(SupportedResources).Append("\n");
            sb.Append("  DownstreamUnsupportedResources: ").Append(DownstreamUnsupportedResources).Append("\n");
            sb.Append("  SupportedEvents: ").Append(SupportedEvents).Append("\n");
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OauthScopes == input.OauthScopes ||
                    this.OauthScopes != null &&
                    input.OauthScopes != null &&
                    this.OauthScopes.SequenceEqual(input.OauthScopes)
                ) && 
                (
                    this.SupportedResources == input.SupportedResources ||
                    this.SupportedResources != null &&
                    input.SupportedResources != null &&
                    this.SupportedResources.SequenceEqual(input.SupportedResources)
                ) && 
                (
                    this.DownstreamUnsupportedResources == input.DownstreamUnsupportedResources ||
                    this.DownstreamUnsupportedResources != null &&
                    input.DownstreamUnsupportedResources != null &&
                    this.DownstreamUnsupportedResources.SequenceEqual(input.DownstreamUnsupportedResources)
                ) && 
                (
                    this.SupportedEvents == input.SupportedEvents ||
                    this.SupportedEvents != null &&
                    input.SupportedEvents != null &&
                    this.SupportedEvents.SequenceEqual(input.SupportedEvents)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OauthScopes != null)
                {
                    hashCode = (hashCode * 59) + this.OauthScopes.GetHashCode();
                }
                if (this.SupportedResources != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedResources.GetHashCode();
                }
                if (this.DownstreamUnsupportedResources != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamUnsupportedResources.GetHashCode();
                }
                if (this.SupportedEvents != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedEvents.GetHashCode();
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
