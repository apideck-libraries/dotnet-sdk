/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.89.0
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
    /// ConnectorDoc
    /// </summary>
    [DataContract(Name = "ConnectorDoc")]
    public partial class ConnectorDoc : IEquatable<ConnectorDoc>, IValidatableObject
    {
        /// <summary>
        /// Audience for the doc.
        /// </summary>
        /// <value>Audience for the doc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AudienceEnum
        {
            /// <summary>
            /// Enum ApplicationOwner for value: application_owner
            /// </summary>
            [EnumMember(Value = "application_owner")]
            ApplicationOwner = 1,

            /// <summary>
            /// Enum Consumer for value: consumer
            /// </summary>
            [EnumMember(Value = "consumer")]
            Consumer = 2

        }


        /// <summary>
        /// Audience for the doc.
        /// </summary>
        /// <value>Audience for the doc.</value>
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public AudienceEnum? Audience { get; set; }
        /// <summary>
        /// Format of the doc.
        /// </summary>
        /// <value>Format of the doc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum Markdown for value: markdown
            /// </summary>
            [EnumMember(Value = "markdown")]
            Markdown = 1

        }


        /// <summary>
        /// Format of the doc.
        /// </summary>
        /// <value>Format of the doc.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorDoc" /> class.
        /// </summary>
        /// <param name="name">Name of the doc..</param>
        /// <param name="audience">Audience for the doc..</param>
        /// <param name="format">Format of the doc..</param>
        /// <param name="url">Link to fetch the content of the doc..</param>
        public ConnectorDoc(string name = default(string), AudienceEnum? audience = default(AudienceEnum?), FormatEnum? format = default(FormatEnum?), string url = default(string))
        {
            this.Name = name;
            this.Audience = audience;
            this.Format = format;
            this.Url = url;
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
        /// Name of the doc.
        /// </summary>
        /// <value>Name of the doc.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Link to fetch the content of the doc.
        /// </summary>
        /// <value>Link to fetch the content of the doc.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorDoc {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ConnectorDoc);
        }

        /// <summary>
        /// Returns true if ConnectorDoc instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorDoc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorDoc input)
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
                ) && 
                (
                    this.Audience == input.Audience ||
                    this.Audience.Equals(input.Audience)
                ) && 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                hashCode = (hashCode * 59) + this.Audience.GetHashCode();
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
