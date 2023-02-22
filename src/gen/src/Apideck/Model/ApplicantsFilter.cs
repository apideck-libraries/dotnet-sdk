/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.92.0
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
    /// ApplicantsFilter
    /// </summary>
    [DataContract(Name = "ApplicantsFilter")]
    public partial class ApplicantsFilter : IEquatable<ApplicantsFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantsFilter" /> class.
        /// </summary>
        /// <param name="jobId">Id of the job to filter on.</param>
        public ApplicantsFilter(string jobId = default(string))
        {
            this.JobId = jobId;
        }

        /// <summary>
        /// Id of the job to filter on
        /// </summary>
        /// <value>Id of the job to filter on</value>
        [DataMember(Name = "job_id", EmitDefaultValue = false)]
        public string JobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicantsFilter {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
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
            return this.Equals(input as ApplicantsFilter);
        }

        /// <summary>
        /// Returns true if ApplicantsFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicantsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicantsFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
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
