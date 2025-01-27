/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.0
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
    /// WebhookEvent
    /// </summary>
    [DataContract(Name = "WebhookEvent")]
    public partial class WebhookEvent : IEquatable<WebhookEvent>, IValidatableObject
    {
        /// <summary>
        /// Name of Apideck Unified API
        /// </summary>
        /// <value>Name of Apideck Unified API</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnifiedApiEnum
        {
            /// <summary>
            /// Enum Accounting for value: accounting
            /// </summary>
            [EnumMember(Value = "accounting")]
            Accounting = 1,

            /// <summary>
            /// Enum Ats for value: ats
            /// </summary>
            [EnumMember(Value = "ats")]
            Ats = 2,

            /// <summary>
            /// Enum Calendar for value: calendar
            /// </summary>
            [EnumMember(Value = "calendar")]
            Calendar = 3,

            /// <summary>
            /// Enum Crm for value: crm
            /// </summary>
            [EnumMember(Value = "crm")]
            Crm = 4,

            /// <summary>
            /// Enum Csp for value: csp
            /// </summary>
            [EnumMember(Value = "csp")]
            Csp = 5,

            /// <summary>
            /// Enum CustomerSupport for value: customer-support
            /// </summary>
            [EnumMember(Value = "customer-support")]
            CustomerSupport = 6,

            /// <summary>
            /// Enum Ecommerce for value: ecommerce
            /// </summary>
            [EnumMember(Value = "ecommerce")]
            Ecommerce = 7,

            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 8,

            /// <summary>
            /// Enum EmailMarketing for value: email-marketing
            /// </summary>
            [EnumMember(Value = "email-marketing")]
            EmailMarketing = 9,

            /// <summary>
            /// Enum ExpenseManagement for value: expense-management
            /// </summary>
            [EnumMember(Value = "expense-management")]
            ExpenseManagement = 10,

            /// <summary>
            /// Enum FileStorage for value: file-storage
            /// </summary>
            [EnumMember(Value = "file-storage")]
            FileStorage = 11,

            /// <summary>
            /// Enum Form for value: form
            /// </summary>
            [EnumMember(Value = "form")]
            Form = 12,

            /// <summary>
            /// Enum Hris for value: hris
            /// </summary>
            [EnumMember(Value = "hris")]
            Hris = 13,

            /// <summary>
            /// Enum Lead for value: lead
            /// </summary>
            [EnumMember(Value = "lead")]
            Lead = 14,

            /// <summary>
            /// Enum Payroll for value: payroll
            /// </summary>
            [EnumMember(Value = "payroll")]
            Payroll = 15,

            /// <summary>
            /// Enum Pos for value: pos
            /// </summary>
            [EnumMember(Value = "pos")]
            Pos = 16,

            /// <summary>
            /// Enum Procurement for value: procurement
            /// </summary>
            [EnumMember(Value = "procurement")]
            Procurement = 17,

            /// <summary>
            /// Enum ProjectManagement for value: project-management
            /// </summary>
            [EnumMember(Value = "project-management")]
            ProjectManagement = 18,

            /// <summary>
            /// Enum Script for value: script
            /// </summary>
            [EnumMember(Value = "script")]
            Script = 19,

            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 20,

            /// <summary>
            /// Enum Spreadsheet for value: spreadsheet
            /// </summary>
            [EnumMember(Value = "spreadsheet")]
            Spreadsheet = 21,

            /// <summary>
            /// Enum TeamMessaging for value: team-messaging
            /// </summary>
            [EnumMember(Value = "team-messaging")]
            TeamMessaging = 22,

            /// <summary>
            /// Enum IssueTracking for value: issue-tracking
            /// </summary>
            [EnumMember(Value = "issue-tracking")]
            IssueTracking = 23,

            /// <summary>
            /// Enum TimeRegistration for value: time-registration
            /// </summary>
            [EnumMember(Value = "time-registration")]
            TimeRegistration = 24,

            /// <summary>
            /// Enum TransactionalEmail for value: transactional-email
            /// </summary>
            [EnumMember(Value = "transactional-email")]
            TransactionalEmail = 25,

            /// <summary>
            /// Enum Vault for value: vault
            /// </summary>
            [EnumMember(Value = "vault")]
            Vault = 26,

            /// <summary>
            /// Enum DataWarehouse for value: data-warehouse
            /// </summary>
            [EnumMember(Value = "data-warehouse")]
            DataWarehouse = 27

        }


        /// <summary>
        /// Name of Apideck Unified API
        /// </summary>
        /// <value>Name of Apideck Unified API</value>
        [DataMember(Name = "unified_api", EmitDefaultValue = false)]
        public UnifiedApiEnum? UnifiedApi { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvent" /> class.
        /// </summary>
        /// <param name="eventId">Unique reference to this request event.</param>
        /// <param name="unifiedApi">Name of Apideck Unified API.</param>
        /// <param name="serviceId">Service provider identifier.</param>
        /// <param name="consumerId">Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID..</param>
        /// <param name="entityId">The service provider&#39;s ID of the entity that triggered this event.</param>
        /// <param name="entityType">The type entity that triggered this event.</param>
        /// <param name="entityUrl">The url to retrieve entity detail..</param>
        /// <param name="executionAttempt">The current count this request event has been attempted.</param>
        /// <param name="occurredAt">ISO Datetime for when the original event occurred.</param>
        public WebhookEvent(string eventId = default(string), UnifiedApiEnum? unifiedApi = default(UnifiedApiEnum?), string serviceId = default(string), string consumerId = default(string), string entityId = default(string), string entityType = default(string), string entityUrl = default(string), decimal executionAttempt = default(decimal), string occurredAt = default(string))
        {
            this.EventId = eventId;
            this.UnifiedApi = unifiedApi;
            this.ServiceId = serviceId;
            this.ConsumerId = consumerId;
            this.EntityId = entityId;
            this.EntityType = entityType;
            this.EntityUrl = entityUrl;
            this.ExecutionAttempt = executionAttempt;
            this.OccurredAt = occurredAt;
        }

        /// <summary>
        /// Unique reference to this request event
        /// </summary>
        /// <value>Unique reference to this request event</value>
        [DataMember(Name = "event_id", EmitDefaultValue = false)]
        public string EventId { get; set; }

        /// <summary>
        /// Service provider identifier
        /// </summary>
        /// <value>Service provider identifier</value>
        [DataMember(Name = "service_id", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID.
        /// </summary>
        /// <value>Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID.</value>
        [DataMember(Name = "consumer_id", EmitDefaultValue = false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// The service provider&#39;s ID of the entity that triggered this event
        /// </summary>
        /// <value>The service provider&#39;s ID of the entity that triggered this event</value>
        [DataMember(Name = "entity_id", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// The type entity that triggered this event
        /// </summary>
        /// <value>The type entity that triggered this event</value>
        [DataMember(Name = "entity_type", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// The url to retrieve entity detail.
        /// </summary>
        /// <value>The url to retrieve entity detail.</value>
        [DataMember(Name = "entity_url", EmitDefaultValue = false)]
        public string EntityUrl { get; set; }

        /// <summary>
        /// The current count this request event has been attempted
        /// </summary>
        /// <value>The current count this request event has been attempted</value>
        [DataMember(Name = "execution_attempt", EmitDefaultValue = false)]
        public decimal ExecutionAttempt { get; set; }

        /// <summary>
        /// ISO Datetime for when the original event occurred
        /// </summary>
        /// <value>ISO Datetime for when the original event occurred</value>
        [DataMember(Name = "occurred_at", EmitDefaultValue = false)]
        public string OccurredAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookEvent {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EntityUrl: ").Append(EntityUrl).Append("\n");
            sb.Append("  ExecutionAttempt: ").Append(ExecutionAttempt).Append("\n");
            sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
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
            return this.Equals(input as WebhookEvent);
        }

        /// <summary>
        /// Returns true if WebhookEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.UnifiedApi == input.UnifiedApi ||
                    this.UnifiedApi.Equals(input.UnifiedApi)
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.ConsumerId == input.ConsumerId ||
                    (this.ConsumerId != null &&
                    this.ConsumerId.Equals(input.ConsumerId))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.EntityUrl == input.EntityUrl ||
                    (this.EntityUrl != null &&
                    this.EntityUrl.Equals(input.EntityUrl))
                ) && 
                (
                    this.ExecutionAttempt == input.ExecutionAttempt ||
                    this.ExecutionAttempt.Equals(input.ExecutionAttempt)
                ) && 
                (
                    this.OccurredAt == input.OccurredAt ||
                    (this.OccurredAt != null &&
                    this.OccurredAt.Equals(input.OccurredAt))
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
                if (this.EventId != null)
                {
                    hashCode = (hashCode * 59) + this.EventId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
                }
                if (this.EntityId != null)
                {
                    hashCode = (hashCode * 59) + this.EntityId.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                }
                if (this.EntityUrl != null)
                {
                    hashCode = (hashCode * 59) + this.EntityUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExecutionAttempt.GetHashCode();
                if (this.OccurredAt != null)
                {
                    hashCode = (hashCode * 59) + this.OccurredAt.GetHashCode();
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
