/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.1
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
    /// Unify event that is supported on the connector. Events are delivered via Webhooks.
    /// </summary>
    [DataContract(Name = "ConnectorEvent")]
    public partial class ConnectorEvent : IEquatable<ConnectorEvent>, IValidatableObject
    {
        /// <summary>
        /// Unify event source
        /// </summary>
        /// <value>Unify event source</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventSourceEnum
        {
            /// <summary>
            /// Enum Native for value: native
            /// </summary>
            [EnumMember(Value = "native")]
            Native = 1,

            /// <summary>
            /// Enum Virtual for value: virtual
            /// </summary>
            [EnumMember(Value = "virtual")]
            Virtual = 2

        }


        /// <summary>
        /// Unify event source
        /// </summary>
        /// <value>Unify event source</value>
        [DataMember(Name = "event_source", EmitDefaultValue = false)]
        public EventSourceEnum? EventSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorEvent" /> class.
        /// </summary>
        /// <param name="eventType">Unify event type.</param>
        /// <param name="eventSource">Unify event source.</param>
        /// <param name="downstreamEventType">Downstream event type.</param>
        /// <param name="resources">resources.</param>
        /// <param name="entityType">Unify entity type.</param>
        public ConnectorEvent(string eventType = default(string), EventSourceEnum? eventSource = default(EventSourceEnum?), string downstreamEventType = default(string), List<string> resources = default(List<string>), string entityType = default(string))
        {
            this.EventType = eventType;
            this.EventSource = eventSource;
            this.DownstreamEventType = downstreamEventType;
            this.Resources = resources;
            this.EntityType = entityType;
        }

        /// <summary>
        /// Unify event type
        /// </summary>
        /// <value>Unify event type</value>
        [DataMember(Name = "event_type", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// Downstream event type
        /// </summary>
        /// <value>Downstream event type</value>
        [DataMember(Name = "downstream_event_type", EmitDefaultValue = false)]
        public string DownstreamEventType { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// Unify entity type
        /// </summary>
        /// <value>Unify entity type</value>
        [DataMember(Name = "entity_type", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorEvent {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventSource: ").Append(EventSource).Append("\n");
            sb.Append("  DownstreamEventType: ").Append(DownstreamEventType).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
            return this.Equals(input as ConnectorEvent);
        }

        /// <summary>
        /// Returns true if ConnectorEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.EventSource == input.EventSource ||
                    this.EventSource.Equals(input.EventSource)
                ) && 
                (
                    this.DownstreamEventType == input.DownstreamEventType ||
                    (this.DownstreamEventType != null &&
                    this.DownstreamEventType.Equals(input.DownstreamEventType))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
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
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventSource.GetHashCode();
                if (this.DownstreamEventType != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamEventType.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
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
