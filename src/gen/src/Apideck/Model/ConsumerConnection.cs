/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.4
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
    /// ConsumerConnection
    /// </summary>
    [DataContract(Name = "ConsumerConnection")]
    public partial class ConsumerConnection : IEquatable<ConsumerConnection>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [DataMember(Name = "auth_type", EmitDefaultValue = false)]
        public AuthType? AuthType { get; set; }
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 1,

            /// <summary>
            /// Enum Callable for value: callable
            /// </summary>
            [EnumMember(Value = "callable")]
            Callable = 2,

            /// <summary>
            /// Enum Added for value: added
            /// </summary>
            [EnumMember(Value = "added")]
            Added = 3,

            /// <summary>
            /// Enum Configured for value: configured
            /// </summary>
            [EnumMember(Value = "configured")]
            Configured = 4,

            /// <summary>
            /// Enum Authorized for value: authorized
            /// </summary>
            [EnumMember(Value = "authorized")]
            Authorized = 5

        }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumerConnection" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="icon">icon.</param>
        /// <param name="logo">logo.</param>
        /// <param name="serviceId">serviceId.</param>
        /// <param name="unifiedApi">unifiedApi.</param>
        /// <param name="consumerId">consumerId.</param>
        /// <param name="authType">authType.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="settings">Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id.</param>
        /// <param name="metadata">Attach your own consumer specific metadata.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="state">state.</param>
        public ConsumerConnection(string name = default(string), string icon = default(string), string logo = default(string), string serviceId = default(string), string unifiedApi = default(string), string consumerId = default(string), AuthType? authType = default(AuthType?), bool enabled = default(bool), Object settings = default(Object), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string createdAt = default(string), string updatedAt = default(string), StateEnum? state = default(StateEnum?))
        {
            this.Name = name;
            this.Icon = icon;
            this.Logo = logo;
            this.ServiceId = serviceId;
            this.UnifiedApi = unifiedApi;
            this.ConsumerId = consumerId;
            this.AuthType = authType;
            this.Enabled = enabled;
            this.Settings = settings;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
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
        /// Gets or Sets ServiceId
        /// </summary>
        [DataMember(Name = "service_id", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Gets or Sets UnifiedApi
        /// </summary>
        [DataMember(Name = "unified_api", EmitDefaultValue = false)]
        public string UnifiedApi { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerId
        /// </summary>
        [DataMember(Name = "consumer_id", EmitDefaultValue = false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id
        /// </summary>
        /// <value>Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id</value>
        [DataMember(Name = "settings", EmitDefaultValue = true)]
        public Object Settings { get; set; }

        /// <summary>
        /// Attach your own consumer specific metadata
        /// </summary>
        /// <value>Attach your own consumer specific metadata</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConsumerConnection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  TagLine: ").Append(TagLine).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as ConsumerConnection);
        }

        /// <summary>
        /// Returns true if ConsumerConnection instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsumerConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumerConnection input)
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
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.TagLine == input.TagLine ||
                    (this.TagLine != null &&
                    this.TagLine.Equals(input.TagLine))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.UnifiedApi == input.UnifiedApi ||
                    (this.UnifiedApi != null &&
                    this.UnifiedApi.Equals(input.UnifiedApi))
                ) && 
                (
                    this.ConsumerId == input.ConsumerId ||
                    (this.ConsumerId != null &&
                    this.ConsumerId.Equals(input.ConsumerId))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    this.AuthType.Equals(input.AuthType)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.TagLine != null)
                {
                    hashCode = (hashCode * 59) + this.TagLine.GetHashCode();
                }
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.UnifiedApi != null)
                {
                    hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
                }
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AuthType.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
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
