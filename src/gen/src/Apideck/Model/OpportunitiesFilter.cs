/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.6.2
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
    /// OpportunitiesFilter
    /// </summary>
    [DataContract(Name = "OpportunitiesFilter")]
    public partial class OpportunitiesFilter : IEquatable<OpportunitiesFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunitiesFilter" /> class.
        /// </summary>
        /// <param name="title">Title of the opportunity to filter on.</param>
        /// <param name="status">Status to filter on.</param>
        /// <param name="monetaryAmount">Monetary amount to filter on.</param>
        /// <param name="winProbability">Win probability to filter on.</param>
        /// <param name="companyId">Company ID to filter on.</param>
        /// <param name="ownerId">Owner ID to filter on.</param>
        /// <param name="primaryContactId">Primary contact ID to filter on.</param>
        public OpportunitiesFilter(string title = default(string), string status = default(string), decimal monetaryAmount = default(decimal), decimal winProbability = default(decimal), string companyId = default(string), string ownerId = default(string), string primaryContactId = default(string))
        {
            this.Title = title;
            this.Status = status;
            this.MonetaryAmount = monetaryAmount;
            this.WinProbability = winProbability;
            this.CompanyId = companyId;
            this.OwnerId = ownerId;
            this.PrimaryContactId = primaryContactId;
        }

        /// <summary>
        /// Title of the opportunity to filter on
        /// </summary>
        /// <value>Title of the opportunity to filter on</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Status to filter on
        /// </summary>
        /// <value>Status to filter on</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Monetary amount to filter on
        /// </summary>
        /// <value>Monetary amount to filter on</value>
        [DataMember(Name = "monetary_amount", EmitDefaultValue = false)]
        public decimal MonetaryAmount { get; set; }

        /// <summary>
        /// Win probability to filter on
        /// </summary>
        /// <value>Win probability to filter on</value>
        [DataMember(Name = "win_probability", EmitDefaultValue = false)]
        public decimal WinProbability { get; set; }

        /// <summary>
        /// Company ID to filter on
        /// </summary>
        /// <value>Company ID to filter on</value>
        [DataMember(Name = "company_id", EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Owner ID to filter on
        /// </summary>
        /// <value>Owner ID to filter on</value>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Primary contact ID to filter on
        /// </summary>
        /// <value>Primary contact ID to filter on</value>
        [DataMember(Name = "primary_contact_id", EmitDefaultValue = false)]
        public string PrimaryContactId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpportunitiesFilter {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MonetaryAmount: ").Append(MonetaryAmount).Append("\n");
            sb.Append("  WinProbability: ").Append(WinProbability).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  PrimaryContactId: ").Append(PrimaryContactId).Append("\n");
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
            return this.Equals(input as OpportunitiesFilter);
        }

        /// <summary>
        /// Returns true if OpportunitiesFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of OpportunitiesFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpportunitiesFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MonetaryAmount == input.MonetaryAmount ||
                    this.MonetaryAmount.Equals(input.MonetaryAmount)
                ) && 
                (
                    this.WinProbability == input.WinProbability ||
                    this.WinProbability.Equals(input.WinProbability)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.PrimaryContactId == input.PrimaryContactId ||
                    (this.PrimaryContactId != null &&
                    this.PrimaryContactId.Equals(input.PrimaryContactId))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MonetaryAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.WinProbability.GetHashCode();
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.PrimaryContactId != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryContactId.GetHashCode();
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
