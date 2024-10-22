/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.7
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
    /// JournalEntryLineItem
    /// </summary>
    [DataContract(Name = "JournalEntryLineItem")]
    public partial class JournalEntryLineItem : IEquatable<JournalEntryLineItem>, IValidatableObject
    {
        /// <summary>
        /// Debit entries are considered positive, and credit entries are considered negative.
        /// </summary>
        /// <value>Debit entries are considered positive, and credit entries are considered negative.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 1,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 2

        }


        /// <summary>
        /// Debit entries are considered positive, and credit entries are considered negative.
        /// </summary>
        /// <value>Debit entries are considered positive, and credit entries are considered negative.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JournalEntryLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryLineItem" /> class.
        /// </summary>
        /// <param name="description">User defined description.</param>
        /// <param name="taxAmount">Tax amount.</param>
        /// <param name="subTotal">Sub-total amount, normally before tax..</param>
        /// <param name="totalAmount">Debit entries are considered positive, and credit entries are considered negative..</param>
        /// <param name="type">Debit entries are considered positive, and credit entries are considered negative. (required).</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="trackingCategory">trackingCategory.</param>
        /// <param name="trackingCategories">A list of linked tracking categories..</param>
        /// <param name="ledgerAccount">ledgerAccount (required).</param>
        /// <param name="customer">customer.</param>
        /// <param name="supplier">supplier.</param>
        /// <param name="lineNumber">Line number of the resource.</param>
        public JournalEntryLineItem(string description = default(string), decimal? taxAmount = default(decimal?), decimal? subTotal = default(decimal?), decimal? totalAmount = default(decimal?), TypeEnum type = default(TypeEnum), LinkedTaxRate taxRate = default(LinkedTaxRate), DeprecatedLinkedTrackingCategory trackingCategory = default(DeprecatedLinkedTrackingCategory), List<LinkedTrackingCategory> trackingCategories = default(List<LinkedTrackingCategory>), LinkedLedgerAccount ledgerAccount = default(LinkedLedgerAccount), LinkedCustomer customer = default(LinkedCustomer), LinkedSupplier supplier = default(LinkedSupplier), int? lineNumber = default(int?))
        {
            this.Type = type;
            // to ensure "ledgerAccount" is required (not null)
            if (ledgerAccount == null) {
                throw new ArgumentNullException("ledgerAccount is a required property for JournalEntryLineItem and cannot be null");
            }
            this.LedgerAccount = ledgerAccount;
            this.Description = description;
            this.TaxAmount = taxAmount;
            this.SubTotal = subTotal;
            this.TotalAmount = totalAmount;
            this.TaxRate = taxRate;
            this.TrackingCategory = trackingCategory;
            this.TrackingCategories = trackingCategories;
            this.Customer = customer;
            this.Supplier = supplier;
            this.LineNumber = lineNumber;
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
        /// User defined description
        /// </summary>
        /// <value>User defined description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Tax amount
        /// </summary>
        /// <value>Tax amount</value>
        [DataMember(Name = "tax_amount", EmitDefaultValue = true)]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Sub-total amount, normally before tax.
        /// </summary>
        /// <value>Sub-total amount, normally before tax.</value>
        [DataMember(Name = "sub_total", EmitDefaultValue = true)]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// Debit entries are considered positive, and credit entries are considered negative.
        /// </summary>
        /// <value>Debit entries are considered positive, and credit entries are considered negative.</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = true)]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public LinkedTaxRate TaxRate { get; set; }

        /// <summary>
        /// Gets or Sets TrackingCategory
        /// </summary>
        [DataMember(Name = "tracking_category", EmitDefaultValue = true)]
        [Obsolete]
        public DeprecatedLinkedTrackingCategory TrackingCategory { get; set; }

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        /// <value>A list of linked tracking categories.</value>
        [DataMember(Name = "tracking_categories", EmitDefaultValue = true)]
        public List<LinkedTrackingCategory> TrackingCategories { get; set; }

        /// <summary>
        /// Gets or Sets LedgerAccount
        /// </summary>
        [DataMember(Name = "ledger_account", IsRequired = true, EmitDefaultValue = true)]
        public LinkedLedgerAccount LedgerAccount { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = true)]
        public LinkedCustomer Customer { get; set; }

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name = "supplier", EmitDefaultValue = true)]
        public LinkedSupplier Supplier { get; set; }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "department_id", EmitDefaultValue = false)]
        public string DepartmentId { get; private set; }

        /// <summary>
        /// Returns false as DepartmentId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDepartmentId()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "location_id", EmitDefaultValue = false)]
        public string LocationId { get; private set; }

        /// <summary>
        /// Returns false as LocationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLocationId()
        {
            return false;
        }
        /// <summary>
        /// Line number of the resource
        /// </summary>
        /// <value>Line number of the resource</value>
        [DataMember(Name = "line_number", EmitDefaultValue = true)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JournalEntryLineItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TrackingCategory: ").Append(TrackingCategory).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  LedgerAccount: ").Append(LedgerAccount).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
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
            return this.Equals(input as JournalEntryLineItem);
        }

        /// <summary>
        /// Returns true if JournalEntryLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalEntryLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalEntryLineItem input)
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
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    (this.SubTotal != null &&
                    this.SubTotal.Equals(input.SubTotal))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.TrackingCategory == input.TrackingCategory ||
                    (this.TrackingCategory != null &&
                    this.TrackingCategory.Equals(input.TrackingCategory))
                ) && 
                (
                    this.TrackingCategories == input.TrackingCategories ||
                    this.TrackingCategories != null &&
                    input.TrackingCategories != null &&
                    this.TrackingCategories.SequenceEqual(input.TrackingCategories)
                ) && 
                (
                    this.LedgerAccount == input.LedgerAccount ||
                    (this.LedgerAccount != null &&
                    this.LedgerAccount.Equals(input.LedgerAccount))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.Supplier == input.Supplier ||
                    (this.Supplier != null &&
                    this.Supplier.Equals(input.Supplier))
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
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
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
                if (this.TaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaxAmount.GetHashCode();
                }
                if (this.SubTotal != null)
                {
                    hashCode = (hashCode * 59) + this.SubTotal.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                }
                if (this.TrackingCategory != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingCategory.GetHashCode();
                }
                if (this.TrackingCategories != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingCategories.GetHashCode();
                }
                if (this.LedgerAccount != null)
                {
                    hashCode = (hashCode * 59) + this.LedgerAccount.GetHashCode();
                }
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                if (this.Supplier != null)
                {
                    hashCode = (hashCode * 59) + this.Supplier.GetHashCode();
                }
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.LineNumber != null)
                {
                    hashCode = (hashCode * 59) + this.LineNumber.GetHashCode();
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
