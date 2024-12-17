/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.9.0
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
    /// WebhookEventLogsFilter
    /// </summary>
    [DataContract(Name = "WebhookEventLogsFilter")]
    public partial class WebhookEventLogsFilter : IEquatable<WebhookEventLogsFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventLogsFilter" /> class.
        /// </summary>
        /// <param name="excludeApis">excludeApis.</param>
        /// <param name="service">service.</param>
        /// <param name="consumerId">consumerId.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="eventType">eventType.</param>
        public WebhookEventLogsFilter(string excludeApis = default(string), WebhookEventLogsFilterService service = default(WebhookEventLogsFilterService), string consumerId = default(string), string entityType = default(string), string eventType = default(string))
        {
            this.ExcludeApis = excludeApis;
            this.Service = service;
            this.ConsumerId = consumerId;
            this.EntityType = entityType;
            this.EventType = eventType;
        }

        /// <summary>
        /// Gets or Sets ExcludeApis
        /// </summary>
        [DataMember(Name = "exclude_apis", EmitDefaultValue = true)]
        public string ExcludeApis { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public WebhookEventLogsFilterService Service { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerId
        /// </summary>
        [DataMember(Name = "consumer_id", EmitDefaultValue = true)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entity_type", EmitDefaultValue = true)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "event_type", EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookEventLogsFilter {\n");
            sb.Append("  ExcludeApis: ").Append(ExcludeApis).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return this.Equals(input as WebhookEventLogsFilter);
        }

        /// <summary>
        /// Returns true if WebhookEventLogsFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEventLogsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventLogsFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExcludeApis == input.ExcludeApis ||
                    (this.ExcludeApis != null &&
                    this.ExcludeApis.Equals(input.ExcludeApis))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.ConsumerId == input.ConsumerId ||
                    (this.ConsumerId != null &&
                    this.ConsumerId.Equals(input.ConsumerId))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
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
                if (this.ExcludeApis != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeApis.GetHashCode();
                }
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
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
