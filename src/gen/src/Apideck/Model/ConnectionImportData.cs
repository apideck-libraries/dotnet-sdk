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
    /// ConnectionImportData
    /// </summary>
    [DataContract(Name = "ConnectionImportData")]
    public partial class ConnectionImportData : IEquatable<ConnectionImportData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionImportData" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="settings">Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id.</param>
        /// <param name="metadata">Attach your own consumer specific metadata.</param>
        public ConnectionImportData(ConnectionImportDataCredentials credentials = default(ConnectionImportDataCredentials), Object settings = default(Object), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            this.Credentials = credentials;
            this.Settings = settings;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public ConnectionImportDataCredentials Credentials { get; set; }

        /// <summary>
        /// Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id
        /// </summary>
        /// <value>Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id</value>
        [DataMember(Name = "settings", EmitDefaultValue = true)]
        public Object Settings { get; set; }

        /// <summary>
        /// Attach your own consumer specific metadata
        /// </summary>
        /// <value>Attach your own consumer specific metadata</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectionImportData {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as ConnectionImportData);
        }

        /// <summary>
        /// Returns true if ConnectionImportData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionImportData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionImportData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
