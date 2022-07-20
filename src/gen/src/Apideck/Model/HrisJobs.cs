/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.36.0
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
    /// HrisJobs
    /// </summary>
    [DataContract(Name = "HrisJobs")]
    public partial class HrisJobs : IEquatable<HrisJobs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HrisJobs" /> class.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <param name="jobs">jobs.</param>
        public HrisJobs(Employee employee = default(Employee), List<HrisJob> jobs = default(List<HrisJob>))
        {
            this.Employee = employee;
            this.Jobs = jobs;
        }

        /// <summary>
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name = "employee", EmitDefaultValue = false)]
        public Employee Employee { get; set; }

        /// <summary>
        /// Gets or Sets Jobs
        /// </summary>
        [DataMember(Name = "jobs", EmitDefaultValue = false)]
        public List<HrisJob> Jobs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HrisJobs {\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
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
            return this.Equals(input as HrisJobs);
        }

        /// <summary>
        /// Returns true if HrisJobs instances are equal
        /// </summary>
        /// <param name="input">Instance of HrisJobs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HrisJobs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Employee == input.Employee ||
                    (this.Employee != null &&
                    this.Employee.Equals(input.Employee))
                ) && 
                (
                    this.Jobs == input.Jobs ||
                    this.Jobs != null &&
                    input.Jobs != null &&
                    this.Jobs.SequenceEqual(input.Jobs)
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
                if (this.Employee != null)
                {
                    hashCode = (hashCode * 59) + this.Employee.GetHashCode();
                }
                if (this.Jobs != null)
                {
                    hashCode = (hashCode * 59) + this.Jobs.GetHashCode();
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
