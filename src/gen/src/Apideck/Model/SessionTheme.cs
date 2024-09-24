/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.5
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
    /// Theming options to change the look and feel of Vault.
    /// </summary>
    [DataContract(Name = "Session_theme")]
    public partial class SessionTheme : IEquatable<SessionTheme>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTheme" /> class.
        /// </summary>
        /// <param name="favicon">The URL to the favicon to use for Vault..</param>
        /// <param name="logo">The URL to the logo to use for Vault..</param>
        /// <param name="primaryColor">The primary color to use for Vault..</param>
        /// <param name="sidepanelBackgroundColor">The background color to use for the sidebar..</param>
        /// <param name="sidepanelTextColor">The text color to use for the sidebar..</param>
        /// <param name="vaultName">The name that will be shown in the sidebar..</param>
        /// <param name="privacyUrl">The URL to the privacy policy that will be shown in the sidebar..</param>
        /// <param name="termsUrl">The URL to the terms and conditions that will be shown in the sidebar..</param>
        public SessionTheme(string favicon = default(string), string logo = default(string), string primaryColor = default(string), string sidepanelBackgroundColor = default(string), string sidepanelTextColor = default(string), string vaultName = default(string), string privacyUrl = default(string), string termsUrl = default(string))
        {
            this.Favicon = favicon;
            this.Logo = logo;
            this.PrimaryColor = primaryColor;
            this.SidepanelBackgroundColor = sidepanelBackgroundColor;
            this.SidepanelTextColor = sidepanelTextColor;
            this.VaultName = vaultName;
            this.PrivacyUrl = privacyUrl;
            this.TermsUrl = termsUrl;
        }

        /// <summary>
        /// The URL to the favicon to use for Vault.
        /// </summary>
        /// <value>The URL to the favicon to use for Vault.</value>
        [DataMember(Name = "favicon", EmitDefaultValue = false)]
        public string Favicon { get; set; }

        /// <summary>
        /// The URL to the logo to use for Vault.
        /// </summary>
        /// <value>The URL to the logo to use for Vault.</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// The primary color to use for Vault.
        /// </summary>
        /// <value>The primary color to use for Vault.</value>
        [DataMember(Name = "primary_color", EmitDefaultValue = false)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The background color to use for the sidebar.
        /// </summary>
        /// <value>The background color to use for the sidebar.</value>
        [DataMember(Name = "sidepanel_background_color", EmitDefaultValue = false)]
        public string SidepanelBackgroundColor { get; set; }

        /// <summary>
        /// The text color to use for the sidebar.
        /// </summary>
        /// <value>The text color to use for the sidebar.</value>
        [DataMember(Name = "sidepanel_text_color", EmitDefaultValue = false)]
        public string SidepanelTextColor { get; set; }

        /// <summary>
        /// The name that will be shown in the sidebar.
        /// </summary>
        /// <value>The name that will be shown in the sidebar.</value>
        [DataMember(Name = "vault_name", EmitDefaultValue = false)]
        public string VaultName { get; set; }

        /// <summary>
        /// The URL to the privacy policy that will be shown in the sidebar.
        /// </summary>
        /// <value>The URL to the privacy policy that will be shown in the sidebar.</value>
        [DataMember(Name = "privacy_url", EmitDefaultValue = false)]
        public string PrivacyUrl { get; set; }

        /// <summary>
        /// The URL to the terms and conditions that will be shown in the sidebar.
        /// </summary>
        /// <value>The URL to the terms and conditions that will be shown in the sidebar.</value>
        [DataMember(Name = "terms_url", EmitDefaultValue = false)]
        public string TermsUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SessionTheme {\n");
            sb.Append("  Favicon: ").Append(Favicon).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  PrimaryColor: ").Append(PrimaryColor).Append("\n");
            sb.Append("  SidepanelBackgroundColor: ").Append(SidepanelBackgroundColor).Append("\n");
            sb.Append("  SidepanelTextColor: ").Append(SidepanelTextColor).Append("\n");
            sb.Append("  VaultName: ").Append(VaultName).Append("\n");
            sb.Append("  PrivacyUrl: ").Append(PrivacyUrl).Append("\n");
            sb.Append("  TermsUrl: ").Append(TermsUrl).Append("\n");
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
            return this.Equals(input as SessionTheme);
        }

        /// <summary>
        /// Returns true if SessionTheme instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionTheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionTheme input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Favicon == input.Favicon ||
                    (this.Favicon != null &&
                    this.Favicon.Equals(input.Favicon))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.PrimaryColor == input.PrimaryColor ||
                    (this.PrimaryColor != null &&
                    this.PrimaryColor.Equals(input.PrimaryColor))
                ) && 
                (
                    this.SidepanelBackgroundColor == input.SidepanelBackgroundColor ||
                    (this.SidepanelBackgroundColor != null &&
                    this.SidepanelBackgroundColor.Equals(input.SidepanelBackgroundColor))
                ) && 
                (
                    this.SidepanelTextColor == input.SidepanelTextColor ||
                    (this.SidepanelTextColor != null &&
                    this.SidepanelTextColor.Equals(input.SidepanelTextColor))
                ) && 
                (
                    this.VaultName == input.VaultName ||
                    (this.VaultName != null &&
                    this.VaultName.Equals(input.VaultName))
                ) && 
                (
                    this.PrivacyUrl == input.PrivacyUrl ||
                    (this.PrivacyUrl != null &&
                    this.PrivacyUrl.Equals(input.PrivacyUrl))
                ) && 
                (
                    this.TermsUrl == input.TermsUrl ||
                    (this.TermsUrl != null &&
                    this.TermsUrl.Equals(input.TermsUrl))
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
                if (this.Favicon != null)
                {
                    hashCode = (hashCode * 59) + this.Favicon.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.PrimaryColor != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryColor.GetHashCode();
                }
                if (this.SidepanelBackgroundColor != null)
                {
                    hashCode = (hashCode * 59) + this.SidepanelBackgroundColor.GetHashCode();
                }
                if (this.SidepanelTextColor != null)
                {
                    hashCode = (hashCode * 59) + this.SidepanelTextColor.GetHashCode();
                }
                if (this.VaultName != null)
                {
                    hashCode = (hashCode * 59) + this.VaultName.GetHashCode();
                }
                if (this.PrivacyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PrivacyUrl.GetHashCode();
                }
                if (this.TermsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TermsUrl.GetHashCode();
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
