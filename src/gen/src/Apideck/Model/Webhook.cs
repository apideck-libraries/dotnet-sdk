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
    /// Webhook
    /// </summary>
    [DataContract(Name = "Webhook")]
    public partial class Webhook : IEquatable<Webhook>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets UnifiedApi
        /// </summary>
        [DataMember(Name = "unified_api", IsRequired = true, EmitDefaultValue = false)]
        public UnifiedApiId UnifiedApi { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public Status Status { get; set; }
        /// <summary>
        /// Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan.
        /// </summary>
        /// <value>Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisabledReasonEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum RetryLimit for value: retry_limit
            /// </summary>
            [EnumMember(Value = "retry_limit")]
            RetryLimit = 2,

            /// <summary>
            /// Enum UsageLimit for value: usage_limit
            /// </summary>
            [EnumMember(Value = "usage_limit")]
            UsageLimit = 3

        }


        /// <summary>
        /// Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan.
        /// </summary>
        /// <value>Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan.</value>
        [DataMember(Name = "disabled_reason", EmitDefaultValue = false)]
        public DisabledReasonEnum? DisabledReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Webhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="description">A description of the object..</param>
        /// <param name="unifiedApi">unifiedApi (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="disabledReason">Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan..</param>
        /// <param name="deliveryUrl">The delivery url of the webhook endpoint. (required).</param>
        /// <param name="events">The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled. (required).</param>
        public Webhook(string description = default(string), UnifiedApiId unifiedApi = default(UnifiedApiId), Status status = default(Status), DisabledReasonEnum? disabledReason = default(DisabledReasonEnum?), string deliveryUrl = default(string), List<WebhookEventType> events = default(List<WebhookEventType>))
        {
            this.UnifiedApi = unifiedApi;
            this.Status = status;
            // to ensure "deliveryUrl" is required (not null)
            if (deliveryUrl == null) {
                throw new ArgumentNullException("deliveryUrl is a required property for Webhook and cannot be null");
            }
            this.DeliveryUrl = deliveryUrl;
            // to ensure "events" is required (not null)
            if (events == null) {
                throw new ArgumentNullException("events is a required property for Webhook and cannot be null");
            }
            this.Events = events;
            this.Description = description;
            this.DisabledReason = disabledReason;
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
        /// A description of the object.
        /// </summary>
        /// <value>A description of the object.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The delivery url of the webhook endpoint.
        /// </summary>
        /// <value>The delivery url of the webhook endpoint.</value>
        [DataMember(Name = "delivery_url", IsRequired = true, EmitDefaultValue = false)]
        public string DeliveryUrl { get; set; }

        /// <summary>
        /// The Unify Base URL events from connectors will be sent to after service id is appended.
        /// </summary>
        /// <value>The Unify Base URL events from connectors will be sent to after service id is appended.</value>
        [DataMember(Name = "execute_base_url", IsRequired = true, EmitDefaultValue = false)]
        public string ExecuteBaseUrl { get; private set; }

        /// <summary>
        /// Returns false as ExecuteBaseUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExecuteBaseUrl()
        {
            return false;
        }
        /// <summary>
        /// The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled.
        /// </summary>
        /// <value>The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled.</value>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = false)]
        public List<WebhookEventType> Events { get; set; }

        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
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
            sb.Append("class Webhook {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DisabledReason: ").Append(DisabledReason).Append("\n");
            sb.Append("  DeliveryUrl: ").Append(DeliveryUrl).Append("\n");
            sb.Append("  ExecuteBaseUrl: ").Append(ExecuteBaseUrl).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Webhook);
        }

        /// <summary>
        /// Returns true if Webhook instances are equal
        /// </summary>
        /// <param name="input">Instance of Webhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Webhook input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UnifiedApi == input.UnifiedApi ||
                    this.UnifiedApi.Equals(input.UnifiedApi)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.DisabledReason == input.DisabledReason ||
                    this.DisabledReason.Equals(input.DisabledReason)
                ) && 
                (
                    this.DeliveryUrl == input.DeliveryUrl ||
                    (this.DeliveryUrl != null &&
                    this.DeliveryUrl.Equals(input.DeliveryUrl))
                ) && 
                (
                    this.ExecuteBaseUrl == input.ExecuteBaseUrl ||
                    (this.ExecuteBaseUrl != null &&
                    this.ExecuteBaseUrl.Equals(input.ExecuteBaseUrl))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.DisabledReason.GetHashCode();
                if (this.DeliveryUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryUrl.GetHashCode();
                }
                if (this.ExecuteBaseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExecuteBaseUrl.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
            // DeliveryUrl (string) pattern
            Regex regexDeliveryUrl = new Regex(@"^(https?):\/\/", RegexOptions.CultureInvariant);
            if (false == regexDeliveryUrl.Match(this.DeliveryUrl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryUrl, must match a pattern of " + regexDeliveryUrl, new [] { "DeliveryUrl" });
            }

            // ExecuteBaseUrl (string) pattern
            Regex regexExecuteBaseUrl = new Regex(@"^(https?):\/\/", RegexOptions.CultureInvariant);
            if (false == regexExecuteBaseUrl.Match(this.ExecuteBaseUrl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExecuteBaseUrl, must match a pattern of " + regexExecuteBaseUrl, new [] { "ExecuteBaseUrl" });
            }

            yield break;
        }
    }

}
