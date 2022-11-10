/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.83.0
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
    /// TimeOffRequestNotes
    /// </summary>
    [DataContract(Name = "TimeOffRequest_notes")]
    public partial class TimeOffRequestNotes : IEquatable<TimeOffRequestNotes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestNotes" /> class.
        /// </summary>
        /// <param name="employee">employee.</param>
        /// <param name="manager">manager.</param>
        public TimeOffRequestNotes(string employee = default(string), string manager = default(string))
        {
            this.Employee = employee;
            this.Manager = manager;
        }

        /// <summary>
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name = "employee", EmitDefaultValue = false)]
        public string Employee { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = false)]
        public string Manager { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeOffRequestNotes {\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
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
            return this.Equals(input as TimeOffRequestNotes);
        }

        /// <summary>
        /// Returns true if TimeOffRequestNotes instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeOffRequestNotes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffRequestNotes input)
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
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
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
                if (this.Manager != null)
                {
                    hashCode = (hashCode * 59) + this.Manager.GetHashCode();
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
