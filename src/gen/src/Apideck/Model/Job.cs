/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.38.0
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
    /// Job
    /// </summary>
    [DataContract(Name = "Job")]
    public partial class Job : IEquatable<Job>, IValidatableObject
    {
        /// <summary>
        /// Defines Visibility
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 1,

            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 2

        }



        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public List<VisibilityEnum> Visibility { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public JobStatus? Status { get; set; }
        /// <summary>
        /// Defines EmploymentTerms
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmploymentTermsEnum
        {
            /// <summary>
            /// Enum FullTime for value: full-time
            /// </summary>
            [EnumMember(Value = "full-time")]
            FullTime = 1,

            /// <summary>
            /// Enum PartTime for value: part-time
            /// </summary>
            [EnumMember(Value = "part-time")]
            PartTime = 2,

            /// <summary>
            /// Enum Intership for value: intership
            /// </summary>
            [EnumMember(Value = "intership")]
            Intership = 3,

            /// <summary>
            /// Enum Contractor for value: contractor
            /// </summary>
            [EnumMember(Value = "contractor")]
            Contractor = 4,

            /// <summary>
            /// Enum Employee for value: employee
            /// </summary>
            [EnumMember(Value = "employee")]
            Employee = 5,

            /// <summary>
            /// Enum Freelance for value: freelance
            /// </summary>
            [EnumMember(Value = "freelance")]
            Freelance = 6,

            /// <summary>
            /// Enum Temp for value: temp
            /// </summary>
            [EnumMember(Value = "temp")]
            Temp = 7,

            /// <summary>
            /// Enum Seasonal for value: seasonal
            /// </summary>
            [EnumMember(Value = "seasonal")]
            Seasonal = 8,

            /// <summary>
            /// Enum Volunteer for value: volunteer
            /// </summary>
            [EnumMember(Value = "volunteer")]
            Volunteer = 9,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 10

        }


        /// <summary>
        /// Gets or Sets EmploymentTerms
        /// </summary>
        [DataMember(Name = "employment_terms", EmitDefaultValue = true)]
        public EmploymentTermsEnum? EmploymentTerms { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="slug">slug.</param>
        /// <param name="title">title.</param>
        /// <param name="sequence">Sequence in relation to other jobs..</param>
        /// <param name="visibility">visibility.</param>
        /// <param name="status">status.</param>
        /// <param name="code">The code of the job..</param>
        /// <param name="language">language code according to ISO 639-1. For the United States - EN.</param>
        /// <param name="employmentTerms">employmentTerms.</param>
        /// <param name="experience">Level of experience required for the job role..</param>
        /// <param name="remote">Specifies whether the posting is for a remote job..</param>
        /// <param name="requisitionId">A job&#39;s Requisition ID (Req ID) allows your organization to identify and track a job based on alphanumeric naming conventions unique to your company&#39;s internal processes..</param>
        /// <param name="department">department.</param>
        /// <param name="branch">branch.</param>
        /// <param name="recruiters">The recruiter is generally someone who is tasked to help the hiring manager find and screen qualified applicant.</param>
        /// <param name="hiringManagers">hiringManagers.</param>
        /// <param name="followers">followers.</param>
        /// <param name="description">description.</param>
        /// <param name="descriptionHtml">The job description in HTML format.</param>
        /// <param name="blocks">blocks.</param>
        /// <param name="closing">closing.</param>
        /// <param name="closingHtml">The closing section of the job description in HTML format.</param>
        /// <param name="closingDate">closingDate.</param>
        /// <param name="salary">salary.</param>
        /// <param name="url">URL of the job description.</param>
        /// <param name="jobPortalUrl">URL of the job portal.</param>
        /// <param name="confidential">confidential.</param>
        /// <param name="availableToEmployees">Specifies whether an employee of the organization can apply for the job..</param>
        /// <param name="tags">tags.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="recordUrl">recordUrl.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="ownerId">ownerId.</param>
        public Job(string slug = default(string), string title = default(string), int sequence = default(int), List<VisibilityEnum> visibility = default(List<VisibilityEnum>), JobStatus? status = default(JobStatus?), string code = default(string), string language = default(string), EmploymentTermsEnum? employmentTerms = default(EmploymentTermsEnum?), string experience = default(string), bool? remote = default(bool?), string requisitionId = default(string), Department department = default(Department), Branch branch = default(Branch), List<string> recruiters = default(List<string>), List<Object> hiringManagers = default(List<Object>), List<string> followers = default(List<string>), string description = default(string), string descriptionHtml = default(string), List<Object> blocks = default(List<Object>), string closing = default(string), string closingHtml = default(string), DateTime? closingDate = default(DateTime?), JobSalary salary = default(JobSalary), string url = default(string), string jobPortalUrl = default(string), bool confidential = default(bool), bool availableToEmployees = default(bool), List<string> tags = default(List<string>), List<Address> addresses = default(List<Address>), string recordUrl = default(string), bool? deleted = default(bool?), string ownerId = default(string))
        {
            this.Slug = slug;
            this.Title = title;
            this.Sequence = sequence;
            this.Visibility = visibility;
            this.Status = status;
            this.Code = code;
            this.Language = language;
            this.EmploymentTerms = employmentTerms;
            this.Experience = experience;
            this.Remote = remote;
            this.RequisitionId = requisitionId;
            this.Department = department;
            this.Branch = branch;
            this.Recruiters = recruiters;
            this.HiringManagers = hiringManagers;
            this.Followers = followers;
            this.Description = description;
            this.DescriptionHtml = descriptionHtml;
            this.Blocks = blocks;
            this.Closing = closing;
            this.ClosingHtml = closingHtml;
            this.ClosingDate = closingDate;
            this.Salary = salary;
            this.Url = url;
            this.JobPortalUrl = jobPortalUrl;
            this.Confidential = confidential;
            this.AvailableToEmployees = availableToEmployees;
            this.Tags = tags;
            this.Addresses = addresses;
            this.RecordUrl = recordUrl;
            this.Deleted = deleted;
            this.OwnerId = ownerId;
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
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Sequence in relation to other jobs.
        /// </summary>
        /// <value>Sequence in relation to other jobs.</value>
        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        public int Sequence { get; set; }

        /// <summary>
        /// The code of the job.
        /// </summary>
        /// <value>The code of the job.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        /// <value>language code according to ISO 639-1. For the United States - EN</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Level of experience required for the job role.
        /// </summary>
        /// <value>Level of experience required for the job role.</value>
        [DataMember(Name = "experience", EmitDefaultValue = false)]
        public string Experience { get; set; }

        /// <summary>
        /// Specifies whether the posting is for a remote job.
        /// </summary>
        /// <value>Specifies whether the posting is for a remote job.</value>
        [DataMember(Name = "remote", EmitDefaultValue = true)]
        public bool? Remote { get; set; }

        /// <summary>
        /// A job&#39;s Requisition ID (Req ID) allows your organization to identify and track a job based on alphanumeric naming conventions unique to your company&#39;s internal processes.
        /// </summary>
        /// <value>A job&#39;s Requisition ID (Req ID) allows your organization to identify and track a job based on alphanumeric naming conventions unique to your company&#39;s internal processes.</value>
        [DataMember(Name = "requisition_id", EmitDefaultValue = false)]
        public string RequisitionId { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name = "department", EmitDefaultValue = false)]
        public Department Department { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name = "branch", EmitDefaultValue = false)]
        public Branch Branch { get; set; }

        /// <summary>
        /// The recruiter is generally someone who is tasked to help the hiring manager find and screen qualified applicant
        /// </summary>
        /// <value>The recruiter is generally someone who is tasked to help the hiring manager find and screen qualified applicant</value>
        [DataMember(Name = "recruiters", EmitDefaultValue = true)]
        public List<string> Recruiters { get; set; }

        /// <summary>
        /// Gets or Sets HiringManagers
        /// </summary>
        [DataMember(Name = "hiring_managers", EmitDefaultValue = false)]
        public List<Object> HiringManagers { get; set; }

        /// <summary>
        /// Gets or Sets Followers
        /// </summary>
        [DataMember(Name = "followers", EmitDefaultValue = true)]
        public List<string> Followers { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The job description in HTML format
        /// </summary>
        /// <value>The job description in HTML format</value>
        [DataMember(Name = "description_html", EmitDefaultValue = true)]
        public string DescriptionHtml { get; set; }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name = "blocks", EmitDefaultValue = false)]
        public List<Object> Blocks { get; set; }

        /// <summary>
        /// Gets or Sets Closing
        /// </summary>
        [DataMember(Name = "closing", EmitDefaultValue = true)]
        public string Closing { get; set; }

        /// <summary>
        /// The closing section of the job description in HTML format
        /// </summary>
        /// <value>The closing section of the job description in HTML format</value>
        [DataMember(Name = "closing_html", EmitDefaultValue = true)]
        public string ClosingHtml { get; set; }

        /// <summary>
        /// Gets or Sets ClosingDate
        /// </summary>
        [DataMember(Name = "closing_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ClosingDate { get; set; }

        /// <summary>
        /// Gets or Sets Salary
        /// </summary>
        [DataMember(Name = "salary", EmitDefaultValue = false)]
        public JobSalary Salary { get; set; }

        /// <summary>
        /// URL of the job description
        /// </summary>
        /// <value>URL of the job description</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// URL of the job portal
        /// </summary>
        /// <value>URL of the job portal</value>
        [DataMember(Name = "job_portal_url", EmitDefaultValue = true)]
        public string JobPortalUrl { get; set; }

        /// <summary>
        /// Gets or Sets Confidential
        /// </summary>
        [DataMember(Name = "confidential", EmitDefaultValue = true)]
        public bool Confidential { get; set; }

        /// <summary>
        /// Specifies whether an employee of the organization can apply for the job.
        /// </summary>
        /// <value>Specifies whether an employee of the organization can apply for the job.</value>
        [DataMember(Name = "available_to_employees", EmitDefaultValue = true)]
        public bool AvailableToEmployees { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets RecordUrl
        /// </summary>
        [DataMember(Name = "record_url", EmitDefaultValue = true)]
        public string RecordUrl { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets PublishedAt
        /// </summary>
        [DataMember(Name = "published_at", EmitDefaultValue = false)]
        public DateTime PublishedAt { get; private set; }

        /// <summary>
        /// Returns false as PublishedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePublishedAt()
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
            sb.Append("class Job {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  EmploymentTerms: ").Append(EmploymentTerms).Append("\n");
            sb.Append("  Experience: ").Append(Experience).Append("\n");
            sb.Append("  Remote: ").Append(Remote).Append("\n");
            sb.Append("  RequisitionId: ").Append(RequisitionId).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  Recruiters: ").Append(Recruiters).Append("\n");
            sb.Append("  HiringManagers: ").Append(HiringManagers).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionHtml: ").Append(DescriptionHtml).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Closing: ").Append(Closing).Append("\n");
            sb.Append("  ClosingHtml: ").Append(ClosingHtml).Append("\n");
            sb.Append("  ClosingDate: ").Append(ClosingDate).Append("\n");
            sb.Append("  Salary: ").Append(Salary).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  JobPortalUrl: ").Append(JobPortalUrl).Append("\n");
            sb.Append("  Confidential: ").Append(Confidential).Append("\n");
            sb.Append("  AvailableToEmployees: ").Append(AvailableToEmployees).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  RecordUrl: ").Append(RecordUrl).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
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
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="input">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job input)
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
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    this.Sequence.Equals(input.Sequence)
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    this.Visibility.SequenceEqual(input.Visibility)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.EmploymentTerms == input.EmploymentTerms ||
                    this.EmploymentTerms.Equals(input.EmploymentTerms)
                ) && 
                (
                    this.Experience == input.Experience ||
                    (this.Experience != null &&
                    this.Experience.Equals(input.Experience))
                ) && 
                (
                    this.Remote == input.Remote ||
                    (this.Remote != null &&
                    this.Remote.Equals(input.Remote))
                ) && 
                (
                    this.RequisitionId == input.RequisitionId ||
                    (this.RequisitionId != null &&
                    this.RequisitionId.Equals(input.RequisitionId))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.Recruiters == input.Recruiters ||
                    this.Recruiters != null &&
                    input.Recruiters != null &&
                    this.Recruiters.SequenceEqual(input.Recruiters)
                ) && 
                (
                    this.HiringManagers == input.HiringManagers ||
                    this.HiringManagers != null &&
                    input.HiringManagers != null &&
                    this.HiringManagers.SequenceEqual(input.HiringManagers)
                ) && 
                (
                    this.Followers == input.Followers ||
                    this.Followers != null &&
                    input.Followers != null &&
                    this.Followers.SequenceEqual(input.Followers)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DescriptionHtml == input.DescriptionHtml ||
                    (this.DescriptionHtml != null &&
                    this.DescriptionHtml.Equals(input.DescriptionHtml))
                ) && 
                (
                    this.Blocks == input.Blocks ||
                    this.Blocks != null &&
                    input.Blocks != null &&
                    this.Blocks.SequenceEqual(input.Blocks)
                ) && 
                (
                    this.Closing == input.Closing ||
                    (this.Closing != null &&
                    this.Closing.Equals(input.Closing))
                ) && 
                (
                    this.ClosingHtml == input.ClosingHtml ||
                    (this.ClosingHtml != null &&
                    this.ClosingHtml.Equals(input.ClosingHtml))
                ) && 
                (
                    this.ClosingDate == input.ClosingDate ||
                    (this.ClosingDate != null &&
                    this.ClosingDate.Equals(input.ClosingDate))
                ) && 
                (
                    this.Salary == input.Salary ||
                    (this.Salary != null &&
                    this.Salary.Equals(input.Salary))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.JobPortalUrl == input.JobPortalUrl ||
                    (this.JobPortalUrl != null &&
                    this.JobPortalUrl.Equals(input.JobPortalUrl))
                ) && 
                (
                    this.Confidential == input.Confidential ||
                    this.Confidential.Equals(input.Confidential)
                ) && 
                (
                    this.AvailableToEmployees == input.AvailableToEmployees ||
                    this.AvailableToEmployees.Equals(input.AvailableToEmployees)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.RecordUrl == input.RecordUrl ||
                    (this.RecordUrl != null &&
                    this.RecordUrl.Equals(input.RecordUrl))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.PublishedAt == input.PublishedAt ||
                    (this.PublishedAt != null &&
                    this.PublishedAt.Equals(input.PublishedAt))
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
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Sequence.GetHashCode();
                hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EmploymentTerms.GetHashCode();
                if (this.Experience != null)
                {
                    hashCode = (hashCode * 59) + this.Experience.GetHashCode();
                }
                if (this.Remote != null)
                {
                    hashCode = (hashCode * 59) + this.Remote.GetHashCode();
                }
                if (this.RequisitionId != null)
                {
                    hashCode = (hashCode * 59) + this.RequisitionId.GetHashCode();
                }
                if (this.Department != null)
                {
                    hashCode = (hashCode * 59) + this.Department.GetHashCode();
                }
                if (this.Branch != null)
                {
                    hashCode = (hashCode * 59) + this.Branch.GetHashCode();
                }
                if (this.Recruiters != null)
                {
                    hashCode = (hashCode * 59) + this.Recruiters.GetHashCode();
                }
                if (this.HiringManagers != null)
                {
                    hashCode = (hashCode * 59) + this.HiringManagers.GetHashCode();
                }
                if (this.Followers != null)
                {
                    hashCode = (hashCode * 59) + this.Followers.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DescriptionHtml != null)
                {
                    hashCode = (hashCode * 59) + this.DescriptionHtml.GetHashCode();
                }
                if (this.Blocks != null)
                {
                    hashCode = (hashCode * 59) + this.Blocks.GetHashCode();
                }
                if (this.Closing != null)
                {
                    hashCode = (hashCode * 59) + this.Closing.GetHashCode();
                }
                if (this.ClosingHtml != null)
                {
                    hashCode = (hashCode * 59) + this.ClosingHtml.GetHashCode();
                }
                if (this.ClosingDate != null)
                {
                    hashCode = (hashCode * 59) + this.ClosingDate.GetHashCode();
                }
                if (this.Salary != null)
                {
                    hashCode = (hashCode * 59) + this.Salary.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.JobPortalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.JobPortalUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Confidential.GetHashCode();
                hashCode = (hashCode * 59) + this.AvailableToEmployees.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.RecordUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RecordUrl.GetHashCode();
                }
                if (this.Deleted != null)
                {
                    hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.PublishedAt != null)
                {
                    hashCode = (hashCode * 59) + this.PublishedAt.GetHashCode();
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
            yield break;
        }
    }

}
