/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.91.1
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
    /// CreateWebhookRequest
    /// </summary>
    [DataContract(Name = "CreateWebhookRequest")]
    public partial class CreateWebhookRequest : IEquatable<CreateWebhookRequest>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebhookRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        /// <param name="description">A description of the object..</param>
        /// <param name="unifiedApi">unifiedApi (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="deliveryUrl">The delivery url of the webhook endpoint. (required).</param>
        /// <param name="events">The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled. (required).</param>
        public CreateWebhookRequest(string description = default(string), UnifiedApiId unifiedApi = default(UnifiedApiId), Status status = default(Status), string deliveryUrl = default(string), List<WebhookEventType> events = default(List<WebhookEventType>))
        {
            this.UnifiedApi = unifiedApi;
            this.Status = status;
            // to ensure "deliveryUrl" is required (not null)
            if (deliveryUrl == null) {
                throw new ArgumentNullException("deliveryUrl is a required property for CreateWebhookRequest and cannot be null");
            }
            this.DeliveryUrl = deliveryUrl;
            // to ensure "events" is required (not null)
            if (events == null) {
                throw new ArgumentNullException("events is a required property for CreateWebhookRequest and cannot be null");
            }
            this.Events = events;
            this.Description = description;
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
        /// The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled.
        /// </summary>
        /// <value>The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled.</value>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = false)]
        public List<WebhookEventType> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWebhookRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DeliveryUrl: ").Append(DeliveryUrl).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return this.Equals(input as CreateWebhookRequest);
        }

        /// <summary>
        /// Returns true if CreateWebhookRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebhookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebhookRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.DeliveryUrl == input.DeliveryUrl ||
                    (this.DeliveryUrl != null &&
                    this.DeliveryUrl.Equals(input.DeliveryUrl))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.DeliveryUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryUrl.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
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

            yield break;
        }
    }

}
