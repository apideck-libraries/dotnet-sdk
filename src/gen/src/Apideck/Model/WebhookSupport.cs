/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.9.3
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
    /// How webhooks are supported for the connector. Sometimes the connector natively supports webhooks, other times Apideck virtualizes them based on polling.
    /// </summary>
    [DataContract(Name = "WebhookSupport")]
    public partial class WebhookSupport : IEquatable<WebhookSupport>, IValidatableObject
    {
        /// <summary>
        /// Mode of the webhook support.
        /// </summary>
        /// <value>Mode of the webhook support.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
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
            Virtual = 2,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 3

        }


        /// <summary>
        /// Mode of the webhook support.
        /// </summary>
        /// <value>Mode of the webhook support.</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Received events are scoped to connection or across integration.
        /// </summary>
        /// <value>Received events are scoped to connection or across integration.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubscriptionLevelEnum
        {
            /// <summary>
            /// Enum Connection for value: connection
            /// </summary>
            [EnumMember(Value = "connection")]
            Connection = 1,

            /// <summary>
            /// Enum Integration for value: integration
            /// </summary>
            [EnumMember(Value = "integration")]
            Integration = 2

        }


        /// <summary>
        /// Received events are scoped to connection or across integration.
        /// </summary>
        /// <value>Received events are scoped to connection or across integration.</value>
        [DataMember(Name = "subscription_level", EmitDefaultValue = false)]
        public SubscriptionLevelEnum? SubscriptionLevel { get; set; }
        /// <summary>
        /// How the subscription is managed in the downstream.
        /// </summary>
        /// <value>How the subscription is managed in the downstream.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ManagedViaEnum
        {
            /// <summary>
            /// Enum Manual for value: manual
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual = 1,

            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 2

        }


        /// <summary>
        /// How the subscription is managed in the downstream.
        /// </summary>
        /// <value>How the subscription is managed in the downstream.</value>
        [DataMember(Name = "managed_via", EmitDefaultValue = false)]
        public ManagedViaEnum? ManagedVia { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSupport" /> class.
        /// </summary>
        /// <param name="mode">Mode of the webhook support..</param>
        /// <param name="subscriptionLevel">Received events are scoped to connection or across integration..</param>
        /// <param name="managedVia">How the subscription is managed in the downstream..</param>
        /// <param name="virtualWebhooks">virtualWebhooks.</param>
        public WebhookSupport(ModeEnum? mode = default(ModeEnum?), SubscriptionLevelEnum? subscriptionLevel = default(SubscriptionLevelEnum?), ManagedViaEnum? managedVia = default(ManagedViaEnum?), VirtualWebhooks virtualWebhooks = default(VirtualWebhooks))
        {
            this.Mode = mode;
            this.SubscriptionLevel = subscriptionLevel;
            this.ManagedVia = managedVia;
            this.VirtualWebhooks = virtualWebhooks;
        }

        /// <summary>
        /// Gets or Sets VirtualWebhooks
        /// </summary>
        [DataMember(Name = "virtual_webhooks", EmitDefaultValue = false)]
        public VirtualWebhooks VirtualWebhooks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookSupport {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  SubscriptionLevel: ").Append(SubscriptionLevel).Append("\n");
            sb.Append("  ManagedVia: ").Append(ManagedVia).Append("\n");
            sb.Append("  VirtualWebhooks: ").Append(VirtualWebhooks).Append("\n");
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
            return this.Equals(input as WebhookSupport);
        }

        /// <summary>
        /// Returns true if WebhookSupport instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSupport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSupport input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.SubscriptionLevel == input.SubscriptionLevel ||
                    this.SubscriptionLevel.Equals(input.SubscriptionLevel)
                ) && 
                (
                    this.ManagedVia == input.ManagedVia ||
                    this.ManagedVia.Equals(input.ManagedVia)
                ) && 
                (
                    this.VirtualWebhooks == input.VirtualWebhooks ||
                    (this.VirtualWebhooks != null &&
                    this.VirtualWebhooks.Equals(input.VirtualWebhooks))
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
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriptionLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.ManagedVia.GetHashCode();
                if (this.VirtualWebhooks != null)
                {
                    hashCode = (hashCode * 59) + this.VirtualWebhooks.GetHashCode();
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
