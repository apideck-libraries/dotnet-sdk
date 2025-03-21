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
    /// Connection
    /// </summary>
    [DataContract(Name = "Connection")]
    public partial class Connection : IEquatable<Connection>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public ConnectionState? State { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationState
        /// </summary>
        [DataMember(Name = "integration_state", EmitDefaultValue = false)]
        public IntegrationState? IntegrationState { get; set; }

        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [DataMember(Name = "auth_type", EmitDefaultValue = false)]
        public AuthType? AuthType { get; set; }

        /// <summary>
        /// Gets or Sets OauthGrantType
        /// </summary>
        [DataMember(Name = "oauth_grant_type", EmitDefaultValue = false)]
        public OAuthGrantType? OauthGrantType { get; set; }
        /// <summary>
        /// Status of the connection.
        /// </summary>
        /// <value>Status of the connection.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Live for value: live
            /// </summary>
            [EnumMember(Value = "live")]
            Live = 1,

            /// <summary>
            /// Enum Upcoming for value: upcoming
            /// </summary>
            [EnumMember(Value = "upcoming")]
            Upcoming = 2,

            /// <summary>
            /// Enum Requested for value: requested
            /// </summary>
            [EnumMember(Value = "requested")]
            Requested = 3

        }


        /// <summary>
        /// Status of the connection.
        /// </summary>
        /// <value>Status of the connection.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="integrationState">integrationState.</param>
        /// <param name="authType">authType.</param>
        /// <param name="oauthGrantType">oauthGrantType.</param>
        /// <param name="enabled">Whether the connection is enabled or not. You can enable or disable a connection using the Update Connection API..</param>
        /// <param name="settings">Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id.</param>
        /// <param name="metadata">Attach your own consumer specific metadata.</param>
        /// <param name="configuration">configuration.</param>
        /// <param name="customMappings">List of custom mappings configured for this connection.</param>
        public Connection(ConnectionState? state = default(ConnectionState?), IntegrationState? integrationState = default(IntegrationState?), AuthType? authType = default(AuthType?), OAuthGrantType? oauthGrantType = default(OAuthGrantType?), bool enabled = default(bool), Dictionary<string, Object> settings = default(Dictionary<string, Object>), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), List<ConnectionConfiguration> configuration = default(List<ConnectionConfiguration>), List<CustomMapping> customMappings = default(List<CustomMapping>))
        {
            this.State = state;
            this.IntegrationState = integrationState;
            this.AuthType = authType;
            this.OauthGrantType = oauthGrantType;
            this.Enabled = enabled;
            this.Settings = settings;
            this.Metadata = metadata;
            this._Configuration = configuration;
            this.CustomMappings = customMappings;
        }

        /// <summary>
        /// The unique identifier of the connection.
        /// </summary>
        /// <value>The unique identifier of the connection.</value>
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
        /// The ID of the service this connection belongs to.
        /// </summary>
        /// <value>The ID of the service this connection belongs to.</value>
        [DataMember(Name = "service_id", EmitDefaultValue = false)]
        public string ServiceId { get; private set; }

        /// <summary>
        /// Returns false as ServiceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeServiceId()
        {
            return false;
        }
        /// <summary>
        /// The name of the connection
        /// </summary>
        /// <value>The name of the connection</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
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
        /// Gets or Sets TagLine
        /// </summary>
        [DataMember(Name = "tag_line", EmitDefaultValue = false)]
        public string TagLine { get; private set; }

        /// <summary>
        /// Returns false as TagLine should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTagLine()
        {
            return false;
        }
        /// <summary>
        /// The unified API category where the connection belongs to.
        /// </summary>
        /// <value>The unified API category where the connection belongs to.</value>
        [DataMember(Name = "unified_api", EmitDefaultValue = false)]
        public string UnifiedApi { get; private set; }

        /// <summary>
        /// Returns false as UnifiedApi should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUnifiedApi()
        {
            return false;
        }
        /// <summary>
        /// Whether the connection is enabled or not. You can enable or disable a connection using the Update Connection API.
        /// </summary>
        /// <value>Whether the connection is enabled or not. You can enable or disable a connection using the Update Connection API.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The website URL of the connection
        /// </summary>
        /// <value>The website URL of the connection</value>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public string Website { get; private set; }

        /// <summary>
        /// Returns false as Website should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWebsite()
        {
            return false;
        }
        /// <summary>
        /// A visual icon of the connection, that will be shown in the Vault
        /// </summary>
        /// <value>A visual icon of the connection, that will be shown in the Vault</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; private set; }

        /// <summary>
        /// Returns false as Icon should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIcon()
        {
            return false;
        }
        /// <summary>
        /// The logo of the connection, that will be shown in the Vault
        /// </summary>
        /// <value>The logo of the connection, that will be shown in the Vault</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; private set; }

        /// <summary>
        /// Returns false as Logo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLogo()
        {
            return false;
        }
        /// <summary>
        /// The OAuth redirect URI. Redirect your users to this URI to let them authorize your app in the connector&#39;s UI. Before you can use this URI, you must add &#x60;redirect_uri&#x60; as a query parameter to the &#x60;authorize_url&#x60;. Be sure to URL encode the &#x60;redirect_uri&#x60; part. Your users will be redirected to this &#x60;redirect_uri&#x60; after they granted access to your app in the connector&#39;s UI.
        /// </summary>
        /// <value>The OAuth redirect URI. Redirect your users to this URI to let them authorize your app in the connector&#39;s UI. Before you can use this URI, you must add &#x60;redirect_uri&#x60; as a query parameter to the &#x60;authorize_url&#x60;. Be sure to URL encode the &#x60;redirect_uri&#x60; part. Your users will be redirected to this &#x60;redirect_uri&#x60; after they granted access to your app in the connector&#39;s UI.</value>
        [DataMember(Name = "authorize_url", EmitDefaultValue = true)]
        public string AuthorizeUrl { get; private set; }

        /// <summary>
        /// Returns false as AuthorizeUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthorizeUrl()
        {
            return false;
        }
        /// <summary>
        /// The OAuth revoke URI. Redirect your users to this URI to revoke this connection. Before you can use this URI, you must add &#x60;redirect_uri&#x60; as a query parameter. Your users will be redirected to this &#x60;redirect_uri&#x60; after they granted access to your app in the connector&#39;s UI.
        /// </summary>
        /// <value>The OAuth revoke URI. Redirect your users to this URI to revoke this connection. Before you can use this URI, you must add &#x60;redirect_uri&#x60; as a query parameter. Your users will be redirected to this &#x60;redirect_uri&#x60; after they granted access to your app in the connector&#39;s UI.</value>
        [DataMember(Name = "revoke_url", EmitDefaultValue = true)]
        public string RevokeUrl { get; private set; }

        /// <summary>
        /// Returns false as RevokeUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRevokeUrl()
        {
            return false;
        }
        /// <summary>
        /// Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id
        /// </summary>
        /// <value>Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id</value>
        [DataMember(Name = "settings", EmitDefaultValue = true)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// Attach your own consumer specific metadata
        /// </summary>
        /// <value>Attach your own consumer specific metadata</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// The settings that are wanted to create a connection.
        /// </summary>
        /// <value>The settings that are wanted to create a connection.</value>
        [DataMember(Name = "form_fields", EmitDefaultValue = false)]
        public List<FormField> FormFields { get; private set; }

        /// <summary>
        /// Returns false as FormFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFormFields()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets _Configuration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public List<ConnectionConfiguration> _Configuration { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurableResources
        /// </summary>
        [DataMember(Name = "configurable_resources", EmitDefaultValue = false)]
        public List<string> ConfigurableResources { get; private set; }

        /// <summary>
        /// Returns false as ConfigurableResources should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConfigurableResources()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ResourceSchemaSupport
        /// </summary>
        [DataMember(Name = "resource_schema_support", EmitDefaultValue = false)]
        public List<string> ResourceSchemaSupport { get; private set; }

        /// <summary>
        /// Returns false as ResourceSchemaSupport should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceSchemaSupport()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ResourceSettingsSupport
        /// </summary>
        [DataMember(Name = "resource_settings_support", EmitDefaultValue = false)]
        public List<string> ResourceSettingsSupport { get; private set; }

        /// <summary>
        /// Returns false as ResourceSettingsSupport should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceSettingsSupport()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ValidationSupport
        /// </summary>
        [DataMember(Name = "validation_support", EmitDefaultValue = true)]
        public bool ValidationSupport { get; private set; }

        /// <summary>
        /// Returns false as ValidationSupport should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidationSupport()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SchemaSupport
        /// </summary>
        [DataMember(Name = "schema_support", EmitDefaultValue = true)]
        public bool SchemaSupport { get; private set; }

        /// <summary>
        /// Returns false as SchemaSupport should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSchemaSupport()
        {
            return false;
        }
        /// <summary>
        /// List of settings that are required to be configured on integration before authorization can occur
        /// </summary>
        /// <value>List of settings that are required to be configured on integration before authorization can occur</value>
        [DataMember(Name = "settings_required_for_authorization", EmitDefaultValue = false)]
        public List<string> SettingsRequiredForAuthorization { get; private set; }

        /// <summary>
        /// Returns false as SettingsRequiredForAuthorization should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSettingsRequiredForAuthorization()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name = "subscriptions", EmitDefaultValue = false)]
        public List<WebhookSubscription> Subscriptions { get; private set; }

        /// <summary>
        /// Returns false as Subscriptions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubscriptions()
        {
            return false;
        }
        /// <summary>
        /// Whether the connector has a guide available in the developer docs or not (https://docs.apideck.com/connectors/{service_id}/docs/consumer+connection).
        /// </summary>
        /// <value>Whether the connector has a guide available in the developer docs or not (https://docs.apideck.com/connectors/{service_id}/docs/consumer+connection).</value>
        [DataMember(Name = "has_guide", EmitDefaultValue = true)]
        public bool HasGuide { get; private set; }

        /// <summary>
        /// Returns false as HasGuide should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasGuide()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public decimal CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// List of custom mappings configured for this connection
        /// </summary>
        /// <value>List of custom mappings configured for this connection</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = false)]
        public List<CustomMapping> CustomMappings { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public decimal? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Connection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TagLine: ").Append(TagLine).Append("\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  IntegrationState: ").Append(IntegrationState).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  OauthGrantType: ").Append(OauthGrantType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  AuthorizeUrl: ").Append(AuthorizeUrl).Append("\n");
            sb.Append("  RevokeUrl: ").Append(RevokeUrl).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  FormFields: ").Append(FormFields).Append("\n");
            sb.Append("  _Configuration: ").Append(_Configuration).Append("\n");
            sb.Append("  ConfigurableResources: ").Append(ConfigurableResources).Append("\n");
            sb.Append("  ResourceSchemaSupport: ").Append(ResourceSchemaSupport).Append("\n");
            sb.Append("  ResourceSettingsSupport: ").Append(ResourceSettingsSupport).Append("\n");
            sb.Append("  ValidationSupport: ").Append(ValidationSupport).Append("\n");
            sb.Append("  SchemaSupport: ").Append(SchemaSupport).Append("\n");
            sb.Append("  SettingsRequiredForAuthorization: ").Append(SettingsRequiredForAuthorization).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  HasGuide: ").Append(HasGuide).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Connection);
        }

        /// <summary>
        /// Returns true if Connection instances are equal
        /// </summary>
        /// <param name="input">Instance of Connection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connection input)
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
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TagLine == input.TagLine ||
                    (this.TagLine != null &&
                    this.TagLine.Equals(input.TagLine))
                ) && 
                (
                    this.UnifiedApi == input.UnifiedApi ||
                    (this.UnifiedApi != null &&
                    this.UnifiedApi.Equals(input.UnifiedApi))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.IntegrationState == input.IntegrationState ||
                    this.IntegrationState.Equals(input.IntegrationState)
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    this.AuthType.Equals(input.AuthType)
                ) && 
                (
                    this.OauthGrantType == input.OauthGrantType ||
                    this.OauthGrantType.Equals(input.OauthGrantType)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.AuthorizeUrl == input.AuthorizeUrl ||
                    (this.AuthorizeUrl != null &&
                    this.AuthorizeUrl.Equals(input.AuthorizeUrl))
                ) && 
                (
                    this.RevokeUrl == input.RevokeUrl ||
                    (this.RevokeUrl != null &&
                    this.RevokeUrl.Equals(input.RevokeUrl))
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.FormFields == input.FormFields ||
                    this.FormFields != null &&
                    input.FormFields != null &&
                    this.FormFields.SequenceEqual(input.FormFields)
                ) && 
                (
                    this._Configuration == input._Configuration ||
                    this._Configuration != null &&
                    input._Configuration != null &&
                    this._Configuration.SequenceEqual(input._Configuration)
                ) && 
                (
                    this.ConfigurableResources == input.ConfigurableResources ||
                    this.ConfigurableResources != null &&
                    input.ConfigurableResources != null &&
                    this.ConfigurableResources.SequenceEqual(input.ConfigurableResources)
                ) && 
                (
                    this.ResourceSchemaSupport == input.ResourceSchemaSupport ||
                    this.ResourceSchemaSupport != null &&
                    input.ResourceSchemaSupport != null &&
                    this.ResourceSchemaSupport.SequenceEqual(input.ResourceSchemaSupport)
                ) && 
                (
                    this.ResourceSettingsSupport == input.ResourceSettingsSupport ||
                    this.ResourceSettingsSupport != null &&
                    input.ResourceSettingsSupport != null &&
                    this.ResourceSettingsSupport.SequenceEqual(input.ResourceSettingsSupport)
                ) && 
                (
                    this.ValidationSupport == input.ValidationSupport ||
                    this.ValidationSupport.Equals(input.ValidationSupport)
                ) && 
                (
                    this.SchemaSupport == input.SchemaSupport ||
                    this.SchemaSupport.Equals(input.SchemaSupport)
                ) && 
                (
                    this.SettingsRequiredForAuthorization == input.SettingsRequiredForAuthorization ||
                    this.SettingsRequiredForAuthorization != null &&
                    input.SettingsRequiredForAuthorization != null &&
                    this.SettingsRequiredForAuthorization.SequenceEqual(input.SettingsRequiredForAuthorization)
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    input.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
                ) && 
                (
                    this.HasGuide == input.HasGuide ||
                    this.HasGuide.Equals(input.HasGuide)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    this.CustomMappings != null &&
                    input.CustomMappings != null &&
                    this.CustomMappings.SequenceEqual(input.CustomMappings)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.TagLine != null)
                {
                    hashCode = (hashCode * 59) + this.TagLine.GetHashCode();
                }
                if (this.UnifiedApi != null)
                {
                    hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                hashCode = (hashCode * 59) + this.IntegrationState.GetHashCode();
                hashCode = (hashCode * 59) + this.AuthType.GetHashCode();
                hashCode = (hashCode * 59) + this.OauthGrantType.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.AuthorizeUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizeUrl.GetHashCode();
                }
                if (this.RevokeUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RevokeUrl.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.FormFields != null)
                {
                    hashCode = (hashCode * 59) + this.FormFields.GetHashCode();
                }
                if (this._Configuration != null)
                {
                    hashCode = (hashCode * 59) + this._Configuration.GetHashCode();
                }
                if (this.ConfigurableResources != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurableResources.GetHashCode();
                }
                if (this.ResourceSchemaSupport != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceSchemaSupport.GetHashCode();
                }
                if (this.ResourceSettingsSupport != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceSettingsSupport.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValidationSupport.GetHashCode();
                hashCode = (hashCode * 59) + this.SchemaSupport.GetHashCode();
                if (this.SettingsRequiredForAuthorization != null)
                {
                    hashCode = (hashCode * 59) + this.SettingsRequiredForAuthorization.GetHashCode();
                }
                if (this.Subscriptions != null)
                {
                    hashCode = (hashCode * 59) + this.Subscriptions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasGuide.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
