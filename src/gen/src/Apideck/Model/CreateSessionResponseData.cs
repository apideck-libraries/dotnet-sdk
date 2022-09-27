/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.63.0
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
    /// CreateSessionResponseData
    /// </summary>
    [DataContract(Name = "CreateSessionResponse_data")]
    public partial class CreateSessionResponseData : IEquatable<CreateSessionResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CreateSessionResponseData()
        {
        }

        /// <summary>
        /// Gets or Sets SessionUri
        /// </summary>
        [DataMember(Name = "session_uri", IsRequired = true, EmitDefaultValue = false)]
        public string SessionUri { get; private set; }

        /// <summary>
        /// Returns false as SessionUri should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSessionUri()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SessionToken
        /// </summary>
        [DataMember(Name = "session_token", IsRequired = true, EmitDefaultValue = false)]
        public string SessionToken { get; private set; }

        /// <summary>
        /// Returns false as SessionToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSessionToken()
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
            sb.Append("class CreateSessionResponseData {\n");
            sb.Append("  SessionUri: ").Append(SessionUri).Append("\n");
            sb.Append("  SessionToken: ").Append(SessionToken).Append("\n");
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
            return this.Equals(input as CreateSessionResponseData);
        }

        /// <summary>
        /// Returns true if CreateSessionResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSessionResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSessionResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SessionUri == input.SessionUri ||
                    (this.SessionUri != null &&
                    this.SessionUri.Equals(input.SessionUri))
                ) && 
                (
                    this.SessionToken == input.SessionToken ||
                    (this.SessionToken != null &&
                    this.SessionToken.Equals(input.SessionToken))
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
                if (this.SessionUri != null)
                {
                    hashCode = (hashCode * 59) + this.SessionUri.GetHashCode();
                }
                if (this.SessionToken != null)
                {
                    hashCode = (hashCode * 59) + this.SessionToken.GetHashCode();
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
