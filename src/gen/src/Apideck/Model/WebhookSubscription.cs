/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.4
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
    /// WebhookSubscription
    /// </summary>
    [DataContract(Name = "WebhookSubscription")]
    public partial class WebhookSubscription : IEquatable<WebhookSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscription" /> class.
        /// </summary>
        /// <param name="downstreamId">The ID of the downstream service.</param>
        /// <param name="unifyEventTypes">The list of Unify Events this connection is subscribed to.</param>
        /// <param name="downstreamEventTypes">The list of downstream Events this connection is subscribed to.</param>
        /// <param name="executeUrl">The URL the downstream is sending to when the event is triggered.</param>
        /// <param name="createdAt">The date and time the webhook subscription was created downstream.</param>
        public WebhookSubscription(string downstreamId = default(string), List<string> unifyEventTypes = default(List<string>), List<string> downstreamEventTypes = default(List<string>), string executeUrl = default(string), string createdAt = default(string))
        {
            this.DownstreamId = downstreamId;
            this.UnifyEventTypes = unifyEventTypes;
            this.DownstreamEventTypes = downstreamEventTypes;
            this.ExecuteUrl = executeUrl;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// The ID of the downstream service
        /// </summary>
        /// <value>The ID of the downstream service</value>
        [DataMember(Name = "downstream_id", EmitDefaultValue = false)]
        public string DownstreamId { get; set; }

        /// <summary>
        /// The list of Unify Events this connection is subscribed to
        /// </summary>
        /// <value>The list of Unify Events this connection is subscribed to</value>
        [DataMember(Name = "unify_event_types", EmitDefaultValue = false)]
        public List<string> UnifyEventTypes { get; set; }

        /// <summary>
        /// The list of downstream Events this connection is subscribed to
        /// </summary>
        /// <value>The list of downstream Events this connection is subscribed to</value>
        [DataMember(Name = "downstream_event_types", EmitDefaultValue = false)]
        public List<string> DownstreamEventTypes { get; set; }

        /// <summary>
        /// The URL the downstream is sending to when the event is triggered
        /// </summary>
        /// <value>The URL the downstream is sending to when the event is triggered</value>
        [DataMember(Name = "execute_url", EmitDefaultValue = false)]
        public string ExecuteUrl { get; set; }

        /// <summary>
        /// The date and time the webhook subscription was created downstream
        /// </summary>
        /// <value>The date and time the webhook subscription was created downstream</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookSubscription {\n");
            sb.Append("  DownstreamId: ").Append(DownstreamId).Append("\n");
            sb.Append("  UnifyEventTypes: ").Append(UnifyEventTypes).Append("\n");
            sb.Append("  DownstreamEventTypes: ").Append(DownstreamEventTypes).Append("\n");
            sb.Append("  ExecuteUrl: ").Append(ExecuteUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as WebhookSubscription);
        }

        /// <summary>
        /// Returns true if WebhookSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSubscription input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DownstreamId == input.DownstreamId ||
                    (this.DownstreamId != null &&
                    this.DownstreamId.Equals(input.DownstreamId))
                ) && 
                (
                    this.UnifyEventTypes == input.UnifyEventTypes ||
                    this.UnifyEventTypes != null &&
                    input.UnifyEventTypes != null &&
                    this.UnifyEventTypes.SequenceEqual(input.UnifyEventTypes)
                ) && 
                (
                    this.DownstreamEventTypes == input.DownstreamEventTypes ||
                    this.DownstreamEventTypes != null &&
                    input.DownstreamEventTypes != null &&
                    this.DownstreamEventTypes.SequenceEqual(input.DownstreamEventTypes)
                ) && 
                (
                    this.ExecuteUrl == input.ExecuteUrl ||
                    (this.ExecuteUrl != null &&
                    this.ExecuteUrl.Equals(input.ExecuteUrl))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.DownstreamId != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamId.GetHashCode();
                }
                if (this.UnifyEventTypes != null)
                {
                    hashCode = (hashCode * 59) + this.UnifyEventTypes.GetHashCode();
                }
                if (this.DownstreamEventTypes != null)
                {
                    hashCode = (hashCode * 59) + this.DownstreamEventTypes.GetHashCode();
                }
                if (this.ExecuteUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExecuteUrl.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
