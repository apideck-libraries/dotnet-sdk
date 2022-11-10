/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.83.0
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
        /// Initializes a new instance of the <see cref="ConnectorEvent" /> class.
        /// </summary>
        /// <param name="eventType">Unify event type.</param>
        /// <param name="downstreamEventType">Downstream event type.</param>
        /// <param name="resource">ID of the resource, typically a lowercased version of name..</param>
        public ConnectorEvent(string eventType = default(string), string downstreamEventType = default(string), string resource = default(string))
        {
            this.EventType = eventType;
            this.DownstreamEventType = downstreamEventType;
            this.Resource = resource;
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
        /// ID of the resource, typically a lowercased version of name.
        /// </summary>
        /// <value>ID of the resource, typically a lowercased version of name.</value>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public string Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorEvent {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  DownstreamEventType: ").Append(DownstreamEventType).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
                    this.DownstreamEventType == input.DownstreamEventType ||
                    (this.DownstreamEventType != null &&
                    this.DownstreamEventType.Equals(input.DownstreamEventType))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
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
                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
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
