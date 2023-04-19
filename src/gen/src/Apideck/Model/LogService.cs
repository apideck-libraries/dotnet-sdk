/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.3.0
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
    /// Apideck service provider associated with request.
    /// </summary>
    [DataContract(Name = "Log_service")]
    public partial class LogService : IEquatable<LogService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LogService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogService" /> class.
        /// </summary>
        /// <param name="id">Apideck service provider id. (required).</param>
        /// <param name="name">Apideck service provider name. (required).</param>
        public LogService(string id = default(string), string name = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for LogService and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for LogService and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Apideck service provider id.
        /// </summary>
        /// <value>Apideck service provider id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Apideck service provider name.
        /// </summary>
        /// <value>Apideck service provider name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogService {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as LogService);
        }

        /// <summary>
        /// Returns true if LogService instances are equal
        /// </summary>
        /// <param name="input">Instance of LogService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogService input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
