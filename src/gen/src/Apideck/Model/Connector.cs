/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.43.0
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
    /// Connector
    /// </summary>
    [DataContract(Name = "Connector")]
    public partial class Connector : IEquatable<Connector>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ConnectorStatus? Status { get; set; }
        /// <summary>
        /// Type of authorization used by the connector
        /// </summary>
        /// <value>Type of authorization used by the connector</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            /// <summary>
            /// Enum Oauth2 for value: oauth2
            /// </summary>
            [EnumMember(Value = "oauth2")]
            Oauth2 = 1,

            /// <summary>
            /// Enum ApiKey for value: apiKey
            /// </summary>
            [EnumMember(Value = "apiKey")]
            ApiKey = 2,

            /// <summary>
            /// Enum Basic for value: basic
            /// </summary>
            [EnumMember(Value = "basic")]
            Basic = 3,

            /// <summary>
            /// Enum Custom for value: custom
            /// </summary>
            [EnumMember(Value = "custom")]
            Custom = 4,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 5

        }


        /// <summary>
        /// Type of authorization used by the connector
        /// </summary>
        /// <value>Type of authorization used by the connector</value>
        [DataMember(Name = "auth_type", EmitDefaultValue = false)]
        public AuthTypeEnum? AuthType { get; set; }

        /// <summary>
        /// Returns false as AuthType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthType()
        {
            return false;
        }
        /// <summary>
        /// OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types
        /// </summary>
        /// <value>OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OauthGrantTypeEnum
        {
            /// <summary>
            /// Enum AuthorizationCode for value: authorization_code
            /// </summary>
            [EnumMember(Value = "authorization_code")]
            AuthorizationCode = 1,

            /// <summary>
            /// Enum ClientCredentials for value: client_credentials
            /// </summary>
            [EnumMember(Value = "client_credentials")]
            ClientCredentials = 2

        }


        /// <summary>
        /// OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types
        /// </summary>
        /// <value>OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types</value>
        [DataMember(Name = "oauth_grant_type", EmitDefaultValue = false)]
        public OauthGrantTypeEnum? OauthGrantType { get; set; }

        /// <summary>
        /// Returns false as OauthGrantType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOauthGrantType()
        {
            return false;
        }
        /// <summary>
        /// Location of the OAuth client credentials. For most connectors the OAuth client credentials are stored on integration and managed by the application owner. For others they are stored on connection and managed by the consumer in Vault.
        /// </summary>
        /// <value>Location of the OAuth client credentials. For most connectors the OAuth client credentials are stored on integration and managed by the application owner. For others they are stored on connection and managed by the consumer in Vault.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OauthCredentialsSourceEnum
        {
            /// <summary>
            /// Enum Integration for value: integration
            /// </summary>
            [EnumMember(Value = "integration")]
            Integration = 1,

            /// <summary>
            /// Enum Connection for value: connection
            /// </summary>
            [EnumMember(Value = "connection")]
            Connection = 2

        }


        /// <summary>
        /// Location of the OAuth client credentials. For most connectors the OAuth client credentials are stored on integration and managed by the application owner. For others they are stored on connection and managed by the consumer in Vault.
        /// </summary>
        /// <value>Location of the OAuth client credentials. For most connectors the OAuth client credentials are stored on integration and managed by the application owner. For others they are stored on connection and managed by the consumer in Vault.</value>
        [DataMember(Name = "oauth_credentials_source", EmitDefaultValue = false)]
        public OauthCredentialsSourceEnum? OauthCredentialsSource { get; set; }

        /// <summary>
        /// Returns false as OauthCredentialsSource should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOauthCredentialsSource()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Connector" /> class.
        /// </summary>
        /// <param name="name">Name of the connector..</param>
        /// <param name="status">status.</param>
        /// <param name="description">description.</param>
        /// <param name="iconUrl">Link to a small square icon for the connector..</param>
        /// <param name="logoUrl">Link to the full logo for the connector..</param>
        /// <param name="websiteUrl">Link to the connector&#39;s website..</param>
        /// <param name="oauthScopes">List of OAuth Scopes available for this connector..</param>
        /// <param name="hasSandboxCredentials">Indicates whether Apideck Sandbox OAuth credentials are available..</param>
        /// <param name="settings">settings.</param>
        /// <param name="serviceId">Service provider identifier.</param>
        /// <param name="unifiedApis">List of Unified APIs that feature this connector..</param>
        /// <param name="supportedResources">List of resources that are supported on the connector..</param>
        /// <param name="configurableResources">List of resources that have settings that can be configured..</param>
        /// <param name="supportedEvents">List of events that are supported on the connector. Events are delivered via Webhooks..</param>
        /// <param name="docs">docs.</param>
        public Connector(string name = default(string), ConnectorStatus? status = default(ConnectorStatus?), string description = default(string), string iconUrl = default(string), string logoUrl = default(string), string websiteUrl = default(string), List<ConnectorOauthScopes> oauthScopes = default(List<ConnectorOauthScopes>), bool hasSandboxCredentials = default(bool), List<ConnectorSetting> settings = default(List<ConnectorSetting>), string serviceId = default(string), List<ConnectorUnifiedApis> unifiedApis = default(List<ConnectorUnifiedApis>), List<ConnectorSupportedResources> supportedResources = default(List<ConnectorSupportedResources>), List<string> configurableResources = default(List<string>), List<ConnectorSupportedEvents> supportedEvents = default(List<ConnectorSupportedEvents>), List<ConnectorDoc> docs = default(List<ConnectorDoc>))
        {
            this.Name = name;
            this.Status = status;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.LogoUrl = logoUrl;
            this.WebsiteUrl = websiteUrl;
            this.OauthScopes = oauthScopes;
            this.HasSandboxCredentials = hasSandboxCredentials;
            this.Settings = settings;
            this.ServiceId = serviceId;
            this.UnifiedApis = unifiedApis;
            this.SupportedResources = supportedResources;
            this.ConfigurableResources = configurableResources;
            this.SupportedEvents = supportedEvents;
            this.Docs = docs;
        }

        /// <summary>
        /// ID of the connector.
        /// </summary>
        /// <value>ID of the connector.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Name of the connector.
        /// </summary>
        /// <value>Name of the connector.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Link to a small square icon for the connector.
        /// </summary>
        /// <value>Link to a small square icon for the connector.</value>
        [DataMember(Name = "icon_url", EmitDefaultValue = false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Link to the full logo for the connector.
        /// </summary>
        /// <value>Link to the full logo for the connector.</value>
        [DataMember(Name = "logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Link to the connector&#39;s website.
        /// </summary>
        /// <value>Link to the connector&#39;s website.</value>
        [DataMember(Name = "website_url", EmitDefaultValue = false)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Indicates whether a connector only supports authentication. In this case the connector is not mapped to a Unified API, but can be used with the Proxy API
        /// </summary>
        /// <value>Indicates whether a connector only supports authentication. In this case the connector is not mapped to a Unified API, but can be used with the Proxy API</value>
        [DataMember(Name = "auth_only", EmitDefaultValue = true)]
        public bool AuthOnly { get; private set; }

        /// <summary>
        /// Returns false as AuthOnly should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthOnly()
        {
            return false;
        }
        /// <summary>
        /// List of OAuth Scopes available for this connector.
        /// </summary>
        /// <value>List of OAuth Scopes available for this connector.</value>
        [DataMember(Name = "oauth_scopes", EmitDefaultValue = false)]
        public List<ConnectorOauthScopes> OauthScopes { get; set; }

        /// <summary>
        /// Indicates whether Apideck Sandbox OAuth credentials are available.
        /// </summary>
        /// <value>Indicates whether Apideck Sandbox OAuth credentials are available.</value>
        [DataMember(Name = "has_sandbox_credentials", EmitDefaultValue = true)]
        public bool HasSandboxCredentials { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public List<ConnectorSetting> Settings { get; set; }

        /// <summary>
        /// Service provider identifier
        /// </summary>
        /// <value>Service provider identifier</value>
        [DataMember(Name = "service_id", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// List of Unified APIs that feature this connector.
        /// </summary>
        /// <value>List of Unified APIs that feature this connector.</value>
        [DataMember(Name = "unified_apis", EmitDefaultValue = false)]
        public List<ConnectorUnifiedApis> UnifiedApis { get; set; }

        /// <summary>
        /// List of resources that are supported on the connector.
        /// </summary>
        /// <value>List of resources that are supported on the connector.</value>
        [DataMember(Name = "supported_resources", EmitDefaultValue = false)]
        public List<ConnectorSupportedResources> SupportedResources { get; set; }

        /// <summary>
        /// List of resources that have settings that can be configured.
        /// </summary>
        /// <value>List of resources that have settings that can be configured.</value>
        [DataMember(Name = "configurable_resources", EmitDefaultValue = false)]
        public List<string> ConfigurableResources { get; set; }

        /// <summary>
        /// List of events that are supported on the connector. Events are delivered via Webhooks.
        /// </summary>
        /// <value>List of events that are supported on the connector. Events are delivered via Webhooks.</value>
        [DataMember(Name = "supported_events", EmitDefaultValue = false)]
        public List<ConnectorSupportedEvents> SupportedEvents { get; set; }

        /// <summary>
        /// Gets or Sets Docs
        /// </summary>
        [DataMember(Name = "docs", EmitDefaultValue = false)]
        public List<ConnectorDoc> Docs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Connector {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  AuthOnly: ").Append(AuthOnly).Append("\n");
            sb.Append("  OauthGrantType: ").Append(OauthGrantType).Append("\n");
            sb.Append("  OauthCredentialsSource: ").Append(OauthCredentialsSource).Append("\n");
            sb.Append("  OauthScopes: ").Append(OauthScopes).Append("\n");
            sb.Append("  HasSandboxCredentials: ").Append(HasSandboxCredentials).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  UnifiedApis: ").Append(UnifiedApis).Append("\n");
            sb.Append("  SupportedResources: ").Append(SupportedResources).Append("\n");
            sb.Append("  ConfigurableResources: ").Append(ConfigurableResources).Append("\n");
            sb.Append("  SupportedEvents: ").Append(SupportedEvents).Append("\n");
            sb.Append("  Docs: ").Append(Docs).Append("\n");
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
            return this.Equals(input as Connector);
        }

        /// <summary>
        /// Returns true if Connector instances are equal
        /// </summary>
        /// <param name="input">Instance of Connector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connector input)
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.WebsiteUrl == input.WebsiteUrl ||
                    (this.WebsiteUrl != null &&
                    this.WebsiteUrl.Equals(input.WebsiteUrl))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    this.AuthType.Equals(input.AuthType)
                ) && 
                (
                    this.AuthOnly == input.AuthOnly ||
                    this.AuthOnly.Equals(input.AuthOnly)
                ) && 
                (
                    this.OauthGrantType == input.OauthGrantType ||
                    this.OauthGrantType.Equals(input.OauthGrantType)
                ) && 
                (
                    this.OauthCredentialsSource == input.OauthCredentialsSource ||
                    this.OauthCredentialsSource.Equals(input.OauthCredentialsSource)
                ) && 
                (
                    this.OauthScopes == input.OauthScopes ||
                    this.OauthScopes != null &&
                    input.OauthScopes != null &&
                    this.OauthScopes.SequenceEqual(input.OauthScopes)
                ) && 
                (
                    this.HasSandboxCredentials == input.HasSandboxCredentials ||
                    this.HasSandboxCredentials.Equals(input.HasSandboxCredentials)
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.UnifiedApis == input.UnifiedApis ||
                    this.UnifiedApis != null &&
                    input.UnifiedApis != null &&
                    this.UnifiedApis.SequenceEqual(input.UnifiedApis)
                ) && 
                (
                    this.SupportedResources == input.SupportedResources ||
                    this.SupportedResources != null &&
                    input.SupportedResources != null &&
                    this.SupportedResources.SequenceEqual(input.SupportedResources)
                ) && 
                (
                    this.ConfigurableResources == input.ConfigurableResources ||
                    this.ConfigurableResources != null &&
                    input.ConfigurableResources != null &&
                    this.ConfigurableResources.SequenceEqual(input.ConfigurableResources)
                ) && 
                (
                    this.SupportedEvents == input.SupportedEvents ||
                    this.SupportedEvents != null &&
                    input.SupportedEvents != null &&
                    this.SupportedEvents.SequenceEqual(input.SupportedEvents)
                ) && 
                (
                    this.Docs == input.Docs ||
                    this.Docs != null &&
                    input.Docs != null &&
                    this.Docs.SequenceEqual(input.Docs)
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.IconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconUrl.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                if (this.WebsiteUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WebsiteUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AuthType.GetHashCode();
                hashCode = (hashCode * 59) + this.AuthOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.OauthGrantType.GetHashCode();
                hashCode = (hashCode * 59) + this.OauthCredentialsSource.GetHashCode();
                if (this.OauthScopes != null)
                {
                    hashCode = (hashCode * 59) + this.OauthScopes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasSandboxCredentials.GetHashCode();
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.UnifiedApis != null)
                {
                    hashCode = (hashCode * 59) + this.UnifiedApis.GetHashCode();
                }
                if (this.SupportedResources != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedResources.GetHashCode();
                }
                if (this.ConfigurableResources != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurableResources.GetHashCode();
                }
                if (this.SupportedEvents != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedEvents.GetHashCode();
                }
                if (this.Docs != null)
                {
                    hashCode = (hashCode * 59) + this.Docs.GetHashCode();
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
