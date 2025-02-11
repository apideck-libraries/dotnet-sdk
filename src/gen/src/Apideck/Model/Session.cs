/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.3
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
    /// Session
    /// </summary>
    [DataContract(Name = "Session")]
    public partial class Session : IEquatable<Session>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        /// <param name="consumerMetadata">consumerMetadata.</param>
        /// <param name="redirectUri">The URL to redirect the user to after the session has been configured..</param>
        /// <param name="settings">settings.</param>
        /// <param name="theme">theme.</param>
        /// <param name="customConsumerSettings">Custom consumer settings that are passed as part of the session..</param>
        public Session(ConsumerMetadata consumerMetadata = default(ConsumerMetadata), string redirectUri = default(string), SessionSettings settings = default(SessionSettings), SessionTheme theme = default(SessionTheme), Dictionary<string, Object> customConsumerSettings = default(Dictionary<string, Object>))
        {
            this.ConsumerMetadata = consumerMetadata;
            this.RedirectUri = redirectUri;
            this.Settings = settings;
            this.Theme = theme;
            this.CustomConsumerSettings = customConsumerSettings;
        }

        /// <summary>
        /// Gets or Sets ConsumerMetadata
        /// </summary>
        [DataMember(Name = "consumer_metadata", EmitDefaultValue = false)]
        public ConsumerMetadata ConsumerMetadata { get; set; }

        /// <summary>
        /// The URL to redirect the user to after the session has been configured.
        /// </summary>
        /// <value>The URL to redirect the user to after the session has been configured.</value>
        [DataMember(Name = "redirect_uri", EmitDefaultValue = false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public SessionSettings Settings { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public SessionTheme Theme { get; set; }

        /// <summary>
        /// Custom consumer settings that are passed as part of the session.
        /// </summary>
        /// <value>Custom consumer settings that are passed as part of the session.</value>
        [DataMember(Name = "custom_consumer_settings", EmitDefaultValue = false)]
        public Dictionary<string, Object> CustomConsumerSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Session {\n");
            sb.Append("  ConsumerMetadata: ").Append(ConsumerMetadata).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  CustomConsumerSettings: ").Append(CustomConsumerSettings).Append("\n");
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
            return this.Equals(input as Session);
        }

        /// <summary>
        /// Returns true if Session instances are equal
        /// </summary>
        /// <param name="input">Instance of Session to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Session input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsumerMetadata == input.ConsumerMetadata ||
                    (this.ConsumerMetadata != null &&
                    this.ConsumerMetadata.Equals(input.ConsumerMetadata))
                ) && 
                (
                    this.RedirectUri == input.RedirectUri ||
                    (this.RedirectUri != null &&
                    this.RedirectUri.Equals(input.RedirectUri))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) && 
                (
                    this.Theme == input.Theme ||
                    (this.Theme != null &&
                    this.Theme.Equals(input.Theme))
                ) && 
                (
                    this.CustomConsumerSettings == input.CustomConsumerSettings ||
                    this.CustomConsumerSettings != null &&
                    input.CustomConsumerSettings != null &&
                    this.CustomConsumerSettings.SequenceEqual(input.CustomConsumerSettings)
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
                if (this.ConsumerMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerMetadata.GetHashCode();
                }
                if (this.RedirectUri != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUri.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.Theme != null)
                {
                    hashCode = (hashCode * 59) + this.Theme.GetHashCode();
                }
                if (this.CustomConsumerSettings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomConsumerSettings.GetHashCode();
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
