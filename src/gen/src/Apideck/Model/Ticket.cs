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
    /// Ticket
    /// </summary>
    [DataContract(Name = "Ticket")]
    public partial class Ticket : IEquatable<Ticket>, IValidatableObject
    {
        /// <summary>
        /// Priority of the ticket
        /// </summary>
        /// <value>Priority of the ticket</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 1,

            /// <summary>
            /// Enum Normal for value: normal
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal = 2,

            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 3,

            /// <summary>
            /// Enum Urgent for value: urgent
            /// </summary>
            [EnumMember(Value = "urgent")]
            Urgent = 4

        }


        /// <summary>
        /// Priority of the ticket
        /// </summary>
        /// <value>Priority of the ticket</value>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ticket" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Ticket() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ticket" /> class.
        /// </summary>
        /// <param name="parentId">The ticket&#39;s parent ID.</param>
        /// <param name="type">The ticket&#39;s type.</param>
        /// <param name="subject">Subject of the ticket.</param>
        /// <param name="description">The ticket&#39;s description. HTML version of description is mapped if supported by the third-party platform.</param>
        /// <param name="status">The current status of the ticket. Possible values include: open, in_progress, closed, or - in cases where there is no clear mapping - the original value passed through..</param>
        /// <param name="priority">Priority of the ticket.</param>
        /// <param name="assignees">assignees.</param>
        /// <param name="dueDate">Due date of the ticket.</param>
        /// <param name="tags">tags.</param>
        /// <param name="passThrough">The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources..</param>
        public Ticket(string parentId = default(string), string type = default(string), string subject = default(string), string description = default(string), string status = default(string), PriorityEnum? priority = default(PriorityEnum?), List<Assignee> assignees = default(List<Assignee>), DateTime? dueDate = default(DateTime?), List<CollectionTag> tags = default(List<CollectionTag>), List<Object> passThrough = default(List<Object>))
        {
            this.ParentId = parentId;
            this.Type = type;
            this.Subject = subject;
            this.Description = description;
            this.Status = status;
            this.Priority = priority;
            this.Assignees = assignees;
            this.DueDate = dueDate;
            this.Tags = tags;
            this.PassThrough = passThrough;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
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
        /// The ticket&#39;s parent ID
        /// </summary>
        /// <value>The ticket&#39;s parent ID</value>
        [DataMember(Name = "parent_id", EmitDefaultValue = true)]
        public string ParentId { get; set; }

        /// <summary>
        /// The ticket&#39;s collection ID
        /// </summary>
        /// <value>The ticket&#39;s collection ID</value>
        [DataMember(Name = "collection_id", EmitDefaultValue = true)]
        public string CollectionId { get; private set; }

        /// <summary>
        /// Returns false as CollectionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCollectionId()
        {
            return false;
        }
        /// <summary>
        /// The ticket&#39;s type
        /// </summary>
        /// <value>The ticket&#39;s type</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Subject of the ticket
        /// </summary>
        /// <value>Subject of the ticket</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// The ticket&#39;s description. HTML version of description is mapped if supported by the third-party platform
        /// </summary>
        /// <value>The ticket&#39;s description. HTML version of description is mapped if supported by the third-party platform</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The current status of the ticket. Possible values include: open, in_progress, closed, or - in cases where there is no clear mapping - the original value passed through.
        /// </summary>
        /// <value>The current status of the ticket. Possible values include: open, in_progress, closed, or - in cases where there is no clear mapping - the original value passed through.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Assignees
        /// </summary>
        [DataMember(Name = "assignees", EmitDefaultValue = false)]
        public List<Assignee> Assignees { get; set; }

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
        /// The user who created the object.
        /// </summary>
        /// <value>The user who created the object.</value>
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
        /// Due date of the ticket
        /// </summary>
        /// <value>Due date of the ticket</value>
        [DataMember(Name = "due_date", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// When the ticket was completed
        /// </summary>
        /// <value>When the ticket was completed</value>
        [DataMember(Name = "completed_at", EmitDefaultValue = true)]
        public DateTime? CompletedAt { get; private set; }

        /// <summary>
        /// Returns false as CompletedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompletedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<CollectionTag> Tags { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; private set; }

        /// <summary>
        /// Returns false as CustomMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomMappings()
        {
            return false;
        }
        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        /// <value>The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.</value>
        [DataMember(Name = "pass_through", EmitDefaultValue = false)]
        public List<Object> PassThrough { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Ticket {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Assignees: ").Append(Assignees).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  PassThrough: ").Append(PassThrough).Append("\n");
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
            return this.Equals(input as Ticket);
        }

        /// <summary>
        /// Returns true if Ticket instances are equal
        /// </summary>
        /// <param name="input">Instance of Ticket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ticket input)
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
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Assignees == input.Assignees ||
                    this.Assignees != null &&
                    input.Assignees != null &&
                    this.Assignees.SequenceEqual(input.Assignees)
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
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
                ) && 
                (
                    this.PassThrough == input.PassThrough ||
                    this.PassThrough != null &&
                    input.PassThrough != null &&
                    this.PassThrough.SequenceEqual(input.PassThrough)
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
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                if (this.Assignees != null)
                {
                    hashCode = (hashCode * 59) + this.Assignees.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.CompletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedAt.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.PassThrough != null)
                {
                    hashCode = (hashCode * 59) + this.PassThrough.GetHashCode();
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
