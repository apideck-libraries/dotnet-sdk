/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.8.0
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
    /// EmployeeCompensation
    /// </summary>
    [DataContract(Name = "EmployeeCompensation")]
    public partial class EmployeeCompensation : IEquatable<EmployeeCompensation>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PaymentUnit
        /// </summary>
        [DataMember(Name = "payment_unit", EmitDefaultValue = false)]
        public PaymentUnit? PaymentUnit { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// The FLSA status for this compensation.
        /// </summary>
        /// <value>The FLSA status for this compensation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlsaStatusEnum
        {
            /// <summary>
            /// Enum Exempt for value: exempt
            /// </summary>
            [EnumMember(Value = "exempt")]
            Exempt = 1,

            /// <summary>
            /// Enum SalariedNonexempt for value: salaried-nonexempt
            /// </summary>
            [EnumMember(Value = "salaried-nonexempt")]
            SalariedNonexempt = 2,

            /// <summary>
            /// Enum Nonexempt for value: nonexempt
            /// </summary>
            [EnumMember(Value = "nonexempt")]
            Nonexempt = 3,

            /// <summary>
            /// Enum Owner for value: owner
            /// </summary>
            [EnumMember(Value = "owner")]
            Owner = 4,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 5

        }


        /// <summary>
        /// The FLSA status for this compensation.
        /// </summary>
        /// <value>The FLSA status for this compensation.</value>
        [DataMember(Name = "flsa_status", EmitDefaultValue = false)]
        public FlsaStatusEnum? FlsaStatus { get; set; }

        /// <summary>
        /// Gets or Sets PaymentFrequency
        /// </summary>
        [DataMember(Name = "payment_frequency", EmitDefaultValue = false)]
        public PaymentFrequency? PaymentFrequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeCompensation" /> class.
        /// </summary>
        /// <param name="rate">The amount paid per payment unit..</param>
        /// <param name="paymentUnit">paymentUnit.</param>
        /// <param name="currency">currency.</param>
        /// <param name="flsaStatus">The FLSA status for this compensation..</param>
        /// <param name="effectiveDate">The date on which a change to an employee&#39;s compensation takes effect..</param>
        /// <param name="paymentFrequency">paymentFrequency.</param>
        public EmployeeCompensation(decimal rate = default(decimal), PaymentUnit? paymentUnit = default(PaymentUnit?), Currency? currency = default(Currency?), FlsaStatusEnum? flsaStatus = default(FlsaStatusEnum?), string effectiveDate = default(string), PaymentFrequency? paymentFrequency = default(PaymentFrequency?))
        {
            this.Rate = rate;
            this.PaymentUnit = paymentUnit;
            this.Currency = currency;
            this.FlsaStatus = flsaStatus;
            this.EffectiveDate = effectiveDate;
            this.PaymentFrequency = paymentFrequency;
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
        /// The ID of the job to which the compensation belongs.
        /// </summary>
        /// <value>The ID of the job to which the compensation belongs.</value>
        [DataMember(Name = "job_id", EmitDefaultValue = false)]
        public string JobId { get; private set; }

        /// <summary>
        /// Returns false as JobId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJobId()
        {
            return false;
        }
        /// <summary>
        /// The amount paid per payment unit.
        /// </summary>
        /// <value>The amount paid per payment unit.</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public decimal Rate { get; set; }

        /// <summary>
        /// The date on which a change to an employee&#39;s compensation takes effect.
        /// </summary>
        /// <value>The date on which a change to an employee&#39;s compensation takes effect.</value>
        [DataMember(Name = "effective_date", EmitDefaultValue = false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeeCompensation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  PaymentUnit: ").Append(PaymentUnit).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  FlsaStatus: ").Append(FlsaStatus).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  PaymentFrequency: ").Append(PaymentFrequency).Append("\n");
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
            return this.Equals(input as EmployeeCompensation);
        }

        /// <summary>
        /// Returns true if EmployeeCompensation instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeCompensation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeCompensation input)
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
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
                ) && 
                (
                    this.PaymentUnit == input.PaymentUnit ||
                    this.PaymentUnit.Equals(input.PaymentUnit)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.FlsaStatus == input.FlsaStatus ||
                    this.FlsaStatus.Equals(input.FlsaStatus)
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.PaymentFrequency == input.PaymentFrequency ||
                    this.PaymentFrequency.Equals(input.PaymentFrequency)
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
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentUnit.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                hashCode = (hashCode * 59) + this.FlsaStatus.GetHashCode();
                if (this.EffectiveDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentFrequency.GetHashCode();
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