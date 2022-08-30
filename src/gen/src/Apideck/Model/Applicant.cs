/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.43.0
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
    /// Applicant
    /// </summary>
    [DataContract(Name = "Applicant")]
    public partial class Applicant : IEquatable<Applicant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Applicant" /> class.
        /// </summary>
        /// <param name="positionId">The PositionId the applicant applied for..</param>
        /// <param name="name">The name of an applicant..</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="initials">initials.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="coverLetter">coverLetter.</param>
        /// <param name="photoUrl">photoUrl.</param>
        /// <param name="headline">Typically a list of previous companies where the contact has worked or schools that the contact has attended.</param>
        /// <param name="title">title.</param>
        /// <param name="emails">emails.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="websites">websites.</param>
        /// <param name="socialLinks">socialLinks.</param>
        /// <param name="stageId">stageId.</param>
        /// <param name="recruiterId">recruiterId.</param>
        /// <param name="coordinatorId">coordinatorId.</param>
        /// <param name="applications">applications.</param>
        /// <param name="followers">followers.</param>
        /// <param name="sources">sources.</param>
        /// <param name="confidential">confidential.</param>
        /// <param name="anonymized">anonymized.</param>
        /// <param name="tags">tags.</param>
        /// <param name="archived">archived.</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="recordUrl">recordUrl.</param>
        /// <param name="deleted">deleted.</param>
        public Applicant(string positionId = default(string), string name = default(string), string firstName = default(string), string lastName = default(string), string middleName = default(string), string initials = default(string), DateTime? birthday = default(DateTime?), string coverLetter = default(string), string photoUrl = default(string), string headline = default(string), string title = default(string), List<Email> emails = default(List<Email>), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<Address> addresses = default(List<Address>), List<ApplicantWebsites> websites = default(List<ApplicantWebsites>), List<ApplicantSocialLinks> socialLinks = default(List<ApplicantSocialLinks>), string stageId = default(string), string recruiterId = default(string), string coordinatorId = default(string), List<string> applications = default(List<string>), List<string> followers = default(List<string>), List<string> sources = default(List<string>), bool confidential = default(bool), bool anonymized = default(bool), List<string> tags = default(List<string>), bool archived = default(bool), string ownerId = default(string), string recordUrl = default(string), bool? deleted = default(bool?))
        {
            this.PositionId = positionId;
            this.Name = name;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Initials = initials;
            this.Birthday = birthday;
            this.CoverLetter = coverLetter;
            this.PhotoUrl = photoUrl;
            this.Headline = headline;
            this.Title = title;
            this.Emails = emails;
            this.PhoneNumbers = phoneNumbers;
            this.Addresses = addresses;
            this.Websites = websites;
            this.SocialLinks = socialLinks;
            this.StageId = stageId;
            this.RecruiterId = recruiterId;
            this.CoordinatorId = coordinatorId;
            this.Applications = applications;
            this.Followers = followers;
            this.Sources = sources;
            this.Confidential = confidential;
            this.Anonymized = anonymized;
            this.Tags = tags;
            this.Archived = archived;
            this.OwnerId = ownerId;
            this.RecordUrl = recordUrl;
            this.Deleted = deleted;
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
        /// The PositionId the applicant applied for.
        /// </summary>
        /// <value>The PositionId the applicant applied for.</value>
        [DataMember(Name = "position_id", EmitDefaultValue = false)]
        public string PositionId { get; set; }

        /// <summary>
        /// The name of an applicant.
        /// </summary>
        /// <value>The name of an applicant.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middle_name", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name = "initials", EmitDefaultValue = true)]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name = "birthday", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or Sets CoverLetter
        /// </summary>
        [DataMember(Name = "cover_letter", EmitDefaultValue = false)]
        public string CoverLetter { get; set; }

        /// <summary>
        /// Gets or Sets JobUrl
        /// </summary>
        [DataMember(Name = "job_url", EmitDefaultValue = true)]
        public string JobUrl { get; private set; }

        /// <summary>
        /// Returns false as JobUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJobUrl()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PhotoUrl
        /// </summary>
        [DataMember(Name = "photo_url", EmitDefaultValue = true)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// Typically a list of previous companies where the contact has worked or schools that the contact has attended
        /// </summary>
        /// <value>Typically a list of previous companies where the contact has worked or schools that the contact has attended</value>
        [DataMember(Name = "headline", EmitDefaultValue = false)]
        public string Headline { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name = "emails", EmitDefaultValue = false)]
        public List<Email> Emails { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name = "phone_numbers", EmitDefaultValue = false)]
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        public List<ApplicantWebsites> Websites { get; set; }

        /// <summary>
        /// Gets or Sets SocialLinks
        /// </summary>
        [DataMember(Name = "social_links", EmitDefaultValue = false)]
        public List<ApplicantSocialLinks> SocialLinks { get; set; }

        /// <summary>
        /// Gets or Sets StageId
        /// </summary>
        [DataMember(Name = "stage_id", EmitDefaultValue = false)]
        public string StageId { get; set; }

        /// <summary>
        /// Gets or Sets RecruiterId
        /// </summary>
        [DataMember(Name = "recruiter_id", EmitDefaultValue = false)]
        public string RecruiterId { get; set; }

        /// <summary>
        /// Gets or Sets CoordinatorId
        /// </summary>
        [DataMember(Name = "coordinator_id", EmitDefaultValue = false)]
        public string CoordinatorId { get; set; }

        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name = "applications", EmitDefaultValue = true)]
        public List<string> Applications { get; set; }

        /// <summary>
        /// Gets or Sets Followers
        /// </summary>
        [DataMember(Name = "followers", EmitDefaultValue = true)]
        public List<string> Followers { get; set; }

        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [DataMember(Name = "sources", EmitDefaultValue = true)]
        public List<string> Sources { get; set; }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name = "source_id", EmitDefaultValue = false)]
        public string SourceId { get; private set; }

        /// <summary>
        /// Returns false as SourceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSourceId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Confidential
        /// </summary>
        [DataMember(Name = "confidential", EmitDefaultValue = true)]
        public bool Confidential { get; set; }

        /// <summary>
        /// Gets or Sets Anonymized
        /// </summary>
        [DataMember(Name = "anonymized", EmitDefaultValue = true)]
        public bool Anonymized { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or Sets LastInteractionAt
        /// </summary>
        [DataMember(Name = "last_interaction_at", EmitDefaultValue = false)]
        public DateTime LastInteractionAt { get; private set; }

        /// <summary>
        /// Returns false as LastInteractionAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastInteractionAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets SourcedBy
        /// </summary>
        [DataMember(Name = "sourced_by", EmitDefaultValue = true)]
        public string SourcedBy { get; private set; }

        /// <summary>
        /// Returns false as SourcedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSourcedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CvUrl
        /// </summary>
        [DataMember(Name = "cv_url", EmitDefaultValue = false)]
        public string CvUrl { get; private set; }

        /// <summary>
        /// Returns false as CvUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCvUrl()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RecordUrl
        /// </summary>
        [DataMember(Name = "record_url", EmitDefaultValue = true)]
        public string RecordUrl { get; set; }

        /// <summary>
        /// Gets or Sets RejectedAt
        /// </summary>
        [DataMember(Name = "rejected_at", EmitDefaultValue = true)]
        public DateTime? RejectedAt { get; private set; }

        /// <summary>
        /// Returns false as RejectedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRejectedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Gets or Sets DeletedBy
        /// </summary>
        [DataMember(Name = "deleted_by", EmitDefaultValue = true)]
        public string DeletedBy { get; private set; }

        /// <summary>
        /// Returns false as DeletedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeletedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name = "deleted_at", EmitDefaultValue = true)]
        public DateTime? DeletedAt { get; private set; }

        /// <summary>
        /// Returns false as DeletedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeletedAt()
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
            sb.Append("class Applicant {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  CoverLetter: ").Append(CoverLetter).Append("\n");
            sb.Append("  JobUrl: ").Append(JobUrl).Append("\n");
            sb.Append("  PhotoUrl: ").Append(PhotoUrl).Append("\n");
            sb.Append("  Headline: ").Append(Headline).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  SocialLinks: ").Append(SocialLinks).Append("\n");
            sb.Append("  StageId: ").Append(StageId).Append("\n");
            sb.Append("  RecruiterId: ").Append(RecruiterId).Append("\n");
            sb.Append("  CoordinatorId: ").Append(CoordinatorId).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Confidential: ").Append(Confidential).Append("\n");
            sb.Append("  Anonymized: ").Append(Anonymized).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  LastInteractionAt: ").Append(LastInteractionAt).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  SourcedBy: ").Append(SourcedBy).Append("\n");
            sb.Append("  CvUrl: ").Append(CvUrl).Append("\n");
            sb.Append("  RecordUrl: ").Append(RecordUrl).Append("\n");
            sb.Append("  RejectedAt: ").Append(RejectedAt).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
            return this.Equals(input as Applicant);
        }

        /// <summary>
        /// Returns true if Applicant instances are equal
        /// </summary>
        /// <param name="input">Instance of Applicant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Applicant input)
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
                    this.PositionId == input.PositionId ||
                    (this.PositionId != null &&
                    this.PositionId.Equals(input.PositionId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.Initials == input.Initials ||
                    (this.Initials != null &&
                    this.Initials.Equals(input.Initials))
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.CoverLetter == input.CoverLetter ||
                    (this.CoverLetter != null &&
                    this.CoverLetter.Equals(input.CoverLetter))
                ) && 
                (
                    this.JobUrl == input.JobUrl ||
                    (this.JobUrl != null &&
                    this.JobUrl.Equals(input.JobUrl))
                ) && 
                (
                    this.PhotoUrl == input.PhotoUrl ||
                    (this.PhotoUrl != null &&
                    this.PhotoUrl.Equals(input.PhotoUrl))
                ) && 
                (
                    this.Headline == input.Headline ||
                    (this.Headline != null &&
                    this.Headline.Equals(input.Headline))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Websites == input.Websites ||
                    this.Websites != null &&
                    input.Websites != null &&
                    this.Websites.SequenceEqual(input.Websites)
                ) && 
                (
                    this.SocialLinks == input.SocialLinks ||
                    this.SocialLinks != null &&
                    input.SocialLinks != null &&
                    this.SocialLinks.SequenceEqual(input.SocialLinks)
                ) && 
                (
                    this.StageId == input.StageId ||
                    (this.StageId != null &&
                    this.StageId.Equals(input.StageId))
                ) && 
                (
                    this.RecruiterId == input.RecruiterId ||
                    (this.RecruiterId != null &&
                    this.RecruiterId.Equals(input.RecruiterId))
                ) && 
                (
                    this.CoordinatorId == input.CoordinatorId ||
                    (this.CoordinatorId != null &&
                    this.CoordinatorId.Equals(input.CoordinatorId))
                ) && 
                (
                    this.Applications == input.Applications ||
                    this.Applications != null &&
                    input.Applications != null &&
                    this.Applications.SequenceEqual(input.Applications)
                ) && 
                (
                    this.Followers == input.Followers ||
                    this.Followers != null &&
                    input.Followers != null &&
                    this.Followers.SequenceEqual(input.Followers)
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.Confidential == input.Confidential ||
                    this.Confidential.Equals(input.Confidential)
                ) && 
                (
                    this.Anonymized == input.Anonymized ||
                    this.Anonymized.Equals(input.Anonymized)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
                ) && 
                (
                    this.LastInteractionAt == input.LastInteractionAt ||
                    (this.LastInteractionAt != null &&
                    this.LastInteractionAt.Equals(input.LastInteractionAt))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.SourcedBy == input.SourcedBy ||
                    (this.SourcedBy != null &&
                    this.SourcedBy.Equals(input.SourcedBy))
                ) && 
                (
                    this.CvUrl == input.CvUrl ||
                    (this.CvUrl != null &&
                    this.CvUrl.Equals(input.CvUrl))
                ) && 
                (
                    this.RecordUrl == input.RecordUrl ||
                    (this.RecordUrl != null &&
                    this.RecordUrl.Equals(input.RecordUrl))
                ) && 
                (
                    this.RejectedAt == input.RejectedAt ||
                    (this.RejectedAt != null &&
                    this.RejectedAt.Equals(input.RejectedAt))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.DeletedBy == input.DeletedBy ||
                    (this.DeletedBy != null &&
                    this.DeletedBy.Equals(input.DeletedBy))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
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
                if (this.PositionId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
                }
                if (this.Initials != null)
                {
                    hashCode = (hashCode * 59) + this.Initials.GetHashCode();
                }
                if (this.Birthday != null)
                {
                    hashCode = (hashCode * 59) + this.Birthday.GetHashCode();
                }
                if (this.CoverLetter != null)
                {
                    hashCode = (hashCode * 59) + this.CoverLetter.GetHashCode();
                }
                if (this.JobUrl != null)
                {
                    hashCode = (hashCode * 59) + this.JobUrl.GetHashCode();
                }
                if (this.PhotoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PhotoUrl.GetHashCode();
                }
                if (this.Headline != null)
                {
                    hashCode = (hashCode * 59) + this.Headline.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                if (this.PhoneNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumbers.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.Websites != null)
                {
                    hashCode = (hashCode * 59) + this.Websites.GetHashCode();
                }
                if (this.SocialLinks != null)
                {
                    hashCode = (hashCode * 59) + this.SocialLinks.GetHashCode();
                }
                if (this.StageId != null)
                {
                    hashCode = (hashCode * 59) + this.StageId.GetHashCode();
                }
                if (this.RecruiterId != null)
                {
                    hashCode = (hashCode * 59) + this.RecruiterId.GetHashCode();
                }
                if (this.CoordinatorId != null)
                {
                    hashCode = (hashCode * 59) + this.CoordinatorId.GetHashCode();
                }
                if (this.Applications != null)
                {
                    hashCode = (hashCode * 59) + this.Applications.GetHashCode();
                }
                if (this.Followers != null)
                {
                    hashCode = (hashCode * 59) + this.Followers.GetHashCode();
                }
                if (this.Sources != null)
                {
                    hashCode = (hashCode * 59) + this.Sources.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Confidential.GetHashCode();
                hashCode = (hashCode * 59) + this.Anonymized.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
                if (this.LastInteractionAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastInteractionAt.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.SourcedBy != null)
                {
                    hashCode = (hashCode * 59) + this.SourcedBy.GetHashCode();
                }
                if (this.CvUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CvUrl.GetHashCode();
                }
                if (this.RecordUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RecordUrl.GetHashCode();
                }
                if (this.RejectedAt != null)
                {
                    hashCode = (hashCode * 59) + this.RejectedAt.GetHashCode();
                }
                if (this.Deleted != null)
                {
                    hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                }
                if (this.DeletedBy != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedBy.GetHashCode();
                }
                if (this.DeletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedAt.GetHashCode();
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
            yield break;
        }
    }

}
