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
    /// ExpenseLineItem
    /// </summary>
    [DataContract(Name = "ExpenseLineItem")]
    public partial class ExpenseLineItem : IEquatable<ExpenseLineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpenseLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseLineItem" /> class.
        /// </summary>
        /// <param name="trackingCategories">A list of linked tracking categories..</param>
        /// <param name="accountId">The unique identifier for the ledger account..</param>
        /// <param name="customerId">The ID of the customer this expense item is linked to..</param>
        /// <param name="departmentId">The ID of the department this expense item is linked to..</param>
        /// <param name="locationId">The ID of the location this expense item is linked to..</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="description">The expense line item description.</param>
        /// <param name="totalAmount">The total amount of the expense line item. (required).</param>
        /// <param name="billable">Boolean that indicates if the line item is billable or not..</param>
        public ExpenseLineItem(List<LinkedTrackingCategory> trackingCategories = default(List<LinkedTrackingCategory>), string accountId = default(string), string customerId = default(string), string departmentId = default(string), string locationId = default(string), LinkedTaxRate taxRate = default(LinkedTaxRate), string description = default(string), decimal? totalAmount = default(decimal?), bool billable = default(bool))
        {
            // to ensure "totalAmount" is required (not null)
            if (totalAmount == null) {
                throw new ArgumentNullException("totalAmount is a required property for ExpenseLineItem and cannot be null");
            }
            this.TotalAmount = totalAmount;
            this.TrackingCategories = trackingCategories;
            this.AccountId = accountId;
            this.CustomerId = customerId;
            this.DepartmentId = departmentId;
            this.LocationId = locationId;
            this.TaxRate = taxRate;
            this.Description = description;
            this.Billable = billable;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
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
        /// A list of linked tracking categories.
        /// </summary>
        /// <value>A list of linked tracking categories.</value>
        [DataMember(Name = "tracking_categories", EmitDefaultValue = true)]
        public List<LinkedTrackingCategory> TrackingCategories { get; set; }

        /// <summary>
        /// The unique identifier for the ledger account.
        /// </summary>
        /// <value>The unique identifier for the ledger account.</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The ID of the customer this expense item is linked to.
        /// </summary>
        /// <value>The ID of the customer this expense item is linked to.</value>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The ID of the department this expense item is linked to.
        /// </summary>
        /// <value>The ID of the department this expense item is linked to.</value>
        [DataMember(Name = "department_id", EmitDefaultValue = false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// The ID of the location this expense item is linked to.
        /// </summary>
        /// <value>The ID of the location this expense item is linked to.</value>
        [DataMember(Name = "location_id", EmitDefaultValue = false)]
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public LinkedTaxRate TaxRate { get; set; }

        /// <summary>
        /// The expense line item description
        /// </summary>
        /// <value>The expense line item description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The total amount of the expense line item.
        /// </summary>
        /// <value>The total amount of the expense line item.</value>
        [DataMember(Name = "total_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Boolean that indicates if the line item is billable or not.
        /// </summary>
        /// <value>Boolean that indicates if the line item is billable or not.</value>
        [DataMember(Name = "billable", EmitDefaultValue = true)]
        public bool Billable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpenseLineItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
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
            return this.Equals(input as ExpenseLineItem);
        }

        /// <summary>
        /// Returns true if ExpenseLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseLineItem input)
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
                    this.TrackingCategories == input.TrackingCategories ||
                    this.TrackingCategories != null &&
                    input.TrackingCategories != null &&
                    this.TrackingCategories.SequenceEqual(input.TrackingCategories)
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.Billable == input.Billable ||
                    this.Billable.Equals(input.Billable)
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
                if (this.TrackingCategories != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingCategories.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Billable.GetHashCode();
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
