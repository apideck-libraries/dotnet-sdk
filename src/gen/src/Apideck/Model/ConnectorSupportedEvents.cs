/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.49.0
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
    /// ConnectorSupportedEvents
    /// </summary>
    [DataContract(Name = "Connector_supported_events")]
    public partial class ConnectorSupportedEvents : IEquatable<ConnectorSupportedEvents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorSupportedEvents" /> class.
        /// </summary>
        /// <param name="eventType">eventType.</param>
        /// <param name="downstreamEventType">downstreamEventType.</param>
        /// <param name="resourceId">ID of the resource, typically a lowercased version of name..</param>
        public ConnectorSupportedEvents(string eventType = default(string), string downstreamEventType = default(string), string resourceId = default(string))
        {
            this.EventType = eventType;
            this.DownstreamEventType = downstreamEventType;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "event_type", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets DownstreamEventType
        /// </summary>
        [DataMember(Name = "downstream_event_type", EmitDefaultValue = false)]
        public string DownstreamEventType { get; set; }

        /// <summary>
        /// ID of the resource, typically a lowercased version of name.
        /// </summary>
        /// <value>ID of the resource, typically a lowercased version of name.</value>
        [DataMember(Name = "resource_id", EmitDefaultValue = false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorSupportedEvents {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  DownstreamEventType: ").Append(DownstreamEventType).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
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
            return this.Equals(input as ConnectorSupportedEvents);
        }

        /// <summary>
        /// Returns true if ConnectorSupportedEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorSupportedEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorSupportedEvents input)
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
                    this.DownstreamEventType == input.DownstreamEventType ||
                    (this.DownstreamEventType != null &&
                    this.DownstreamEventType.Equals(input.DownstreamEventType))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
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
                if (this.DownstreamEventType != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamEventType.GetHashCode();
                }
                if (this.ResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceId.GetHashCode();
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
