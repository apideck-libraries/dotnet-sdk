/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.37.0
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
    /// Opportunity
    /// </summary>
    [DataContract(Name = "Opportunity")]
    public partial class Opportunity : IEquatable<Opportunity>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Opportunity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Opportunity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Opportunity" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="primaryContactId">primaryContactId (required).</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="monetaryAmount">monetaryAmount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="winProbability">winProbability.</param>
        /// <param name="closeDate">closeDate.</param>
        /// <param name="lossReasonId">lossReasonId.</param>
        /// <param name="lossReason">lossReason.</param>
        /// <param name="wonReasonId">wonReasonId.</param>
        /// <param name="wonReason">wonReason.</param>
        /// <param name="pipelineId">pipelineId.</param>
        /// <param name="pipelineStageId">pipelineStageId.</param>
        /// <param name="sourceId">sourceId.</param>
        /// <param name="leadId">leadId.</param>
        /// <param name="leadSource">Lead source.</param>
        /// <param name="contactId">contactId.</param>
        /// <param name="companyId">companyId.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="priority">priority.</param>
        /// <param name="status">status.</param>
        /// <param name="statusId">statusId.</param>
        /// <param name="tags">tags.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="stageLastChangedAt">stageLastChangedAt.</param>
        public Opportunity(string title = default(string), string primaryContactId = default(string), string description = default(string), string type = default(string), decimal? monetaryAmount = default(decimal?), Currency? currency = default(Currency?), decimal? winProbability = default(decimal?), DateTime? closeDate = default(DateTime?), string lossReasonId = default(string), string lossReason = default(string), string wonReasonId = default(string), string wonReason = default(string), string pipelineId = default(string), string pipelineStageId = default(string), string sourceId = default(string), string leadId = default(string), string leadSource = default(string), string contactId = default(string), string companyId = default(string), string companyName = default(string), string ownerId = default(string), string priority = default(string), string status = default(string), string statusId = default(string), List<string> tags = default(List<string>), List<CustomField> customFields = default(List<CustomField>), DateTime? stageLastChangedAt = default(DateTime?))
        {
            // to ensure "title" is required (not null)
            if (title == null) {
                throw new ArgumentNullException("title is a required property for Opportunity and cannot be null");
            }
            this.Title = title;
            // to ensure "primaryContactId" is required (not null)
            if (primaryContactId == null) {
                throw new ArgumentNullException("primaryContactId is a required property for Opportunity and cannot be null");
            }
            this.PrimaryContactId = primaryContactId;
            this.Description = description;
            this.Type = type;
            this.MonetaryAmount = monetaryAmount;
            this.Currency = currency;
            this.WinProbability = winProbability;
            this.CloseDate = closeDate;
            this.LossReasonId = lossReasonId;
            this.LossReason = lossReason;
            this.WonReasonId = wonReasonId;
            this.WonReason = wonReason;
            this.PipelineId = pipelineId;
            this.PipelineStageId = pipelineStageId;
            this.SourceId = sourceId;
            this.LeadId = leadId;
            this.LeadSource = leadSource;
            this.ContactId = contactId;
            this.CompanyId = companyId;
            this.CompanyName = companyName;
            this.OwnerId = ownerId;
            this.Priority = priority;
            this.Status = status;
            this.StatusId = statusId;
            this.Tags = tags;
            this.CustomFields = customFields;
            this.StageLastChangedAt = stageLastChangedAt;
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
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContactId
        /// </summary>
        [DataMember(Name = "primary_contact_id", IsRequired = true, EmitDefaultValue = true)]
        public string PrimaryContactId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MonetaryAmount
        /// </summary>
        [DataMember(Name = "monetary_amount", EmitDefaultValue = true)]
        public decimal? MonetaryAmount { get; set; }

        /// <summary>
        /// Gets or Sets WinProbability
        /// </summary>
        [DataMember(Name = "win_probability", EmitDefaultValue = true)]
        public decimal? WinProbability { get; set; }

        /// <summary>
        /// Expected Revenue
        /// </summary>
        /// <value>Expected Revenue</value>
        [DataMember(Name = "expected_revenue", EmitDefaultValue = true)]
        public decimal? ExpectedRevenue { get; private set; }

        /// <summary>
        /// Returns false as ExpectedRevenue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpectedRevenue()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CloseDate
        /// </summary>
        [DataMember(Name = "close_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? CloseDate { get; set; }

        /// <summary>
        /// Gets or Sets LossReasonId
        /// </summary>
        [DataMember(Name = "loss_reason_id", EmitDefaultValue = true)]
        public string LossReasonId { get; set; }

        /// <summary>
        /// Gets or Sets LossReason
        /// </summary>
        [DataMember(Name = "loss_reason", EmitDefaultValue = true)]
        public string LossReason { get; set; }

        /// <summary>
        /// Gets or Sets WonReasonId
        /// </summary>
        [DataMember(Name = "won_reason_id", EmitDefaultValue = true)]
        public string WonReasonId { get; set; }

        /// <summary>
        /// Gets or Sets WonReason
        /// </summary>
        [DataMember(Name = "won_reason", EmitDefaultValue = true)]
        public string WonReason { get; set; }

        /// <summary>
        /// Gets or Sets PipelineId
        /// </summary>
        [DataMember(Name = "pipeline_id", EmitDefaultValue = true)]
        public string PipelineId { get; set; }

        /// <summary>
        /// Gets or Sets PipelineStageId
        /// </summary>
        [DataMember(Name = "pipeline_stage_id", EmitDefaultValue = true)]
        public string PipelineStageId { get; set; }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name = "source_id", EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or Sets LeadId
        /// </summary>
        [DataMember(Name = "lead_id", EmitDefaultValue = true)]
        public string LeadId { get; set; }

        /// <summary>
        /// Lead source
        /// </summary>
        /// <value>Lead source</value>
        [DataMember(Name = "lead_source", EmitDefaultValue = true)]
        public string LeadSource { get; set; }

        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name = "contact_id", EmitDefaultValue = true)]
        public string ContactId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name = "company_id", EmitDefaultValue = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "company_name", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "owner_id", EmitDefaultValue = true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name = "status_id", EmitDefaultValue = true)]
        public string StatusId { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets InteractionCount
        /// </summary>
        [DataMember(Name = "interaction_count", EmitDefaultValue = true)]
        public decimal? InteractionCount { get; private set; }

        /// <summary>
        /// Returns false as InteractionCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInteractionCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public List<CustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets StageLastChangedAt
        /// </summary>
        [DataMember(Name = "stage_last_changed_at", EmitDefaultValue = true)]
        public DateTime? StageLastChangedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityAt
        /// </summary>
        [DataMember(Name = "last_activity_at", EmitDefaultValue = true)]
        public string LastActivityAt { get; private set; }

        /// <summary>
        /// Returns false as LastActivityAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastActivityAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; private set; }

        /// <summary>
        /// Returns false as Deleted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeleted()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DateStageChanged
        /// </summary>
        [DataMember(Name = "date_stage_changed", EmitDefaultValue = true)]
        public DateTime? DateStageChanged { get; private set; }

        /// <summary>
        /// Returns false as DateStageChanged should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDateStageChanged()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DateLastContacted
        /// </summary>
        [DataMember(Name = "date_last_contacted", EmitDefaultValue = true)]
        public DateTime? DateLastContacted { get; private set; }

        /// <summary>
        /// Returns false as DateLastContacted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDateLastContacted()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DateLeadCreated
        /// </summary>
        [DataMember(Name = "date_lead_created", EmitDefaultValue = true)]
        public DateTime? DateLeadCreated { get; private set; }

        /// <summary>
        /// Returns false as DateLeadCreated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDateLeadCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updated_by", EmitDefaultValue = true)]
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// Returns false as UpdatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = true)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

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
            sb.Append("class Opportunity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PrimaryContactId: ").Append(PrimaryContactId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MonetaryAmount: ").Append(MonetaryAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  WinProbability: ").Append(WinProbability).Append("\n");
            sb.Append("  ExpectedRevenue: ").Append(ExpectedRevenue).Append("\n");
            sb.Append("  CloseDate: ").Append(CloseDate).Append("\n");
            sb.Append("  LossReasonId: ").Append(LossReasonId).Append("\n");
            sb.Append("  LossReason: ").Append(LossReason).Append("\n");
            sb.Append("  WonReasonId: ").Append(WonReasonId).Append("\n");
            sb.Append("  WonReason: ").Append(WonReason).Append("\n");
            sb.Append("  PipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  PipelineStageId: ").Append(PipelineStageId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  LeadId: ").Append(LeadId).Append("\n");
            sb.Append("  LeadSource: ").Append(LeadSource).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  InteractionCount: ").Append(InteractionCount).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  StageLastChangedAt: ").Append(StageLastChangedAt).Append("\n");
            sb.Append("  LastActivityAt: ").Append(LastActivityAt).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  DateStageChanged: ").Append(DateStageChanged).Append("\n");
            sb.Append("  DateLastContacted: ").Append(DateLastContacted).Append("\n");
            sb.Append("  DateLeadCreated: ").Append(DateLeadCreated).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(input as Opportunity);
        }

        /// <summary>
        /// Returns true if Opportunity instances are equal
        /// </summary>
        /// <param name="input">Instance of Opportunity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Opportunity input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.PrimaryContactId == input.PrimaryContactId ||
                    (this.PrimaryContactId != null &&
                    this.PrimaryContactId.Equals(input.PrimaryContactId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.MonetaryAmount == input.MonetaryAmount ||
                    (this.MonetaryAmount != null &&
                    this.MonetaryAmount.Equals(input.MonetaryAmount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.WinProbability == input.WinProbability ||
                    (this.WinProbability != null &&
                    this.WinProbability.Equals(input.WinProbability))
                ) && 
                (
                    this.ExpectedRevenue == input.ExpectedRevenue ||
                    (this.ExpectedRevenue != null &&
                    this.ExpectedRevenue.Equals(input.ExpectedRevenue))
                ) && 
                (
                    this.CloseDate == input.CloseDate ||
                    (this.CloseDate != null &&
                    this.CloseDate.Equals(input.CloseDate))
                ) && 
                (
                    this.LossReasonId == input.LossReasonId ||
                    (this.LossReasonId != null &&
                    this.LossReasonId.Equals(input.LossReasonId))
                ) && 
                (
                    this.LossReason == input.LossReason ||
                    (this.LossReason != null &&
                    this.LossReason.Equals(input.LossReason))
                ) && 
                (
                    this.WonReasonId == input.WonReasonId ||
                    (this.WonReasonId != null &&
                    this.WonReasonId.Equals(input.WonReasonId))
                ) && 
                (
                    this.WonReason == input.WonReason ||
                    (this.WonReason != null &&
                    this.WonReason.Equals(input.WonReason))
                ) && 
                (
                    this.PipelineId == input.PipelineId ||
                    (this.PipelineId != null &&
                    this.PipelineId.Equals(input.PipelineId))
                ) && 
                (
                    this.PipelineStageId == input.PipelineStageId ||
                    (this.PipelineStageId != null &&
                    this.PipelineStageId.Equals(input.PipelineStageId))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.LeadId == input.LeadId ||
                    (this.LeadId != null &&
                    this.LeadId.Equals(input.LeadId))
                ) && 
                (
                    this.LeadSource == input.LeadSource ||
                    (this.LeadSource != null &&
                    this.LeadSource.Equals(input.LeadSource))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusId == input.StatusId ||
                    (this.StatusId != null &&
                    this.StatusId.Equals(input.StatusId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.InteractionCount == input.InteractionCount ||
                    (this.InteractionCount != null &&
                    this.InteractionCount.Equals(input.InteractionCount))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.StageLastChangedAt == input.StageLastChangedAt ||
                    (this.StageLastChangedAt != null &&
                    this.StageLastChangedAt.Equals(input.StageLastChangedAt))
                ) && 
                (
                    this.LastActivityAt == input.LastActivityAt ||
                    (this.LastActivityAt != null &&
                    this.LastActivityAt.Equals(input.LastActivityAt))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.DateStageChanged == input.DateStageChanged ||
                    (this.DateStageChanged != null &&
                    this.DateStageChanged.Equals(input.DateStageChanged))
                ) && 
                (
                    this.DateLastContacted == input.DateLastContacted ||
                    (this.DateLastContacted != null &&
                    this.DateLastContacted.Equals(input.DateLastContacted))
                ) && 
                (
                    this.DateLeadCreated == input.DateLeadCreated ||
                    (this.DateLeadCreated != null &&
                    this.DateLeadCreated.Equals(input.DateLeadCreated))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.PrimaryContactId != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryContactId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.MonetaryAmount != null)
                {
                    hashCode = (hashCode * 59) + this.MonetaryAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.WinProbability != null)
                {
                    hashCode = (hashCode * 59) + this.WinProbability.GetHashCode();
                }
                if (this.ExpectedRevenue != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedRevenue.GetHashCode();
                }
                if (this.CloseDate != null)
                {
                    hashCode = (hashCode * 59) + this.CloseDate.GetHashCode();
                }
                if (this.LossReasonId != null)
                {
                    hashCode = (hashCode * 59) + this.LossReasonId.GetHashCode();
                }
                if (this.LossReason != null)
                {
                    hashCode = (hashCode * 59) + this.LossReason.GetHashCode();
                }
                if (this.WonReasonId != null)
                {
                    hashCode = (hashCode * 59) + this.WonReasonId.GetHashCode();
                }
                if (this.WonReason != null)
                {
                    hashCode = (hashCode * 59) + this.WonReason.GetHashCode();
                }
                if (this.PipelineId != null)
                {
                    hashCode = (hashCode * 59) + this.PipelineId.GetHashCode();
                }
                if (this.PipelineStageId != null)
                {
                    hashCode = (hashCode * 59) + this.PipelineStageId.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.LeadId != null)
                {
                    hashCode = (hashCode * 59) + this.LeadId.GetHashCode();
                }
                if (this.LeadSource != null)
                {
                    hashCode = (hashCode * 59) + this.LeadSource.GetHashCode();
                }
                if (this.ContactId != null)
                {
                    hashCode = (hashCode * 59) + this.ContactId.GetHashCode();
                }
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.StatusId != null)
                {
                    hashCode = (hashCode * 59) + this.StatusId.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.InteractionCount != null)
                {
                    hashCode = (hashCode * 59) + this.InteractionCount.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.StageLastChangedAt != null)
                {
                    hashCode = (hashCode * 59) + this.StageLastChangedAt.GetHashCode();
                }
                if (this.LastActivityAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastActivityAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.DateStageChanged != null)
                {
                    hashCode = (hashCode * 59) + this.DateStageChanged.GetHashCode();
                }
                if (this.DateLastContacted != null)
                {
                    hashCode = (hashCode * 59) + this.DateLastContacted.GetHashCode();
                }
                if (this.DateLeadCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateLeadCreated.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
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
            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            yield break;
        }
    }

}
