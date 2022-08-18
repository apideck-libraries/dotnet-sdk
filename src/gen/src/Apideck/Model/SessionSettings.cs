/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.41.0
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
    /// SessionSettings
    /// </summary>
    [DataContract(Name = "Session_settings")]
    public partial class SessionSettings : IEquatable<SessionSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSettings" /> class.
        /// </summary>
        /// <param name="unifiedApis">Provide the IDs of the Unified APIs you want to be visible. Leaving it empty or omiting this field will show all Unified APIs..</param>
        /// <param name="hideResourceSettings">hideResourceSettings (default to false).</param>
        /// <param name="sandboxMode">Configure [Vault](/apis/vault/reference#section/Get-Started) to show a banner informing the logged in user is in a test environment. (default to false).</param>
        /// <param name="isolationMode">Configure [Vault](/apis/vault/reference#section/Get-Started) to run in isolation mode, meaning it only shows the connection settings and hides the navigation items. (default to false).</param>
        /// <param name="sessionLength">The duration of time the session is valid for (maximum 1 week). (default to &quot;1h&quot;).</param>
        /// <param name="showLogs">Configure [Vault](/apis/vault/reference#section/Get-Started) to show the logs page. Defaults to &#x60;true&#x60;. (default to true).</param>
        /// <param name="showSuggestions">Configure [Vault](/apis/vault/reference#section/Get-Started) to show the suggestions page. Defaults to &#x60;true&#x60;. (default to false).</param>
        /// <param name="autoRedirect">Automatically redirect to redirect uri after the connection has been configured as callable. Defaults to &#x60;false&#x60;. (default to false).</param>
        public SessionSettings(List<UnifiedApiId> unifiedApis = default(List<UnifiedApiId>), bool hideResourceSettings = false, bool sandboxMode = false, bool isolationMode = false, string sessionLength = "1h", bool showLogs = true, bool showSuggestions = false, bool autoRedirect = false)
        {
            this.UnifiedApis = unifiedApis;
            this.HideResourceSettings = hideResourceSettings;
            this.SandboxMode = sandboxMode;
            this.IsolationMode = isolationMode;
            // use default value if no "sessionLength" provided
            this.SessionLength = sessionLength ?? "1h";
            this.ShowLogs = showLogs;
            this.ShowSuggestions = showSuggestions;
            this.AutoRedirect = autoRedirect;
        }

        /// <summary>
        /// Provide the IDs of the Unified APIs you want to be visible. Leaving it empty or omiting this field will show all Unified APIs.
        /// </summary>
        /// <value>Provide the IDs of the Unified APIs you want to be visible. Leaving it empty or omiting this field will show all Unified APIs.</value>
        [DataMember(Name = "unified_apis", EmitDefaultValue = false)]
        public List<UnifiedApiId> UnifiedApis { get; set; }

        /// <summary>
        /// Gets or Sets HideResourceSettings
        /// </summary>
        [DataMember(Name = "hide_resource_settings", EmitDefaultValue = true)]
        public bool HideResourceSettings { get; set; }

        /// <summary>
        /// Configure [Vault](/apis/vault/reference#section/Get-Started) to show a banner informing the logged in user is in a test environment.
        /// </summary>
        /// <value>Configure [Vault](/apis/vault/reference#section/Get-Started) to show a banner informing the logged in user is in a test environment.</value>
        [DataMember(Name = "sandbox_mode", EmitDefaultValue = true)]
        public bool SandboxMode { get; set; }

        /// <summary>
        /// Configure [Vault](/apis/vault/reference#section/Get-Started) to run in isolation mode, meaning it only shows the connection settings and hides the navigation items.
        /// </summary>
        /// <value>Configure [Vault](/apis/vault/reference#section/Get-Started) to run in isolation mode, meaning it only shows the connection settings and hides the navigation items.</value>
        [DataMember(Name = "isolation_mode", EmitDefaultValue = true)]
        public bool IsolationMode { get; set; }

        /// <summary>
        /// The duration of time the session is valid for (maximum 1 week).
        /// </summary>
        /// <value>The duration of time the session is valid for (maximum 1 week).</value>
        [DataMember(Name = "session_length", EmitDefaultValue = false)]
        public string SessionLength { get; set; }

        /// <summary>
        /// Configure [Vault](/apis/vault/reference#section/Get-Started) to show the logs page. Defaults to &#x60;true&#x60;.
        /// </summary>
        /// <value>Configure [Vault](/apis/vault/reference#section/Get-Started) to show the logs page. Defaults to &#x60;true&#x60;.</value>
        [DataMember(Name = "show_logs", EmitDefaultValue = true)]
        public bool ShowLogs { get; set; }

        /// <summary>
        /// Configure [Vault](/apis/vault/reference#section/Get-Started) to show the suggestions page. Defaults to &#x60;true&#x60;.
        /// </summary>
        /// <value>Configure [Vault](/apis/vault/reference#section/Get-Started) to show the suggestions page. Defaults to &#x60;true&#x60;.</value>
        [DataMember(Name = "show_suggestions", EmitDefaultValue = true)]
        public bool ShowSuggestions { get; set; }

        /// <summary>
        /// Automatically redirect to redirect uri after the connection has been configured as callable. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>Automatically redirect to redirect uri after the connection has been configured as callable. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "auto_redirect", EmitDefaultValue = true)]
        public bool AutoRedirect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SessionSettings {\n");
            sb.Append("  UnifiedApis: ").Append(UnifiedApis).Append("\n");
            sb.Append("  HideResourceSettings: ").Append(HideResourceSettings).Append("\n");
            sb.Append("  SandboxMode: ").Append(SandboxMode).Append("\n");
            sb.Append("  IsolationMode: ").Append(IsolationMode).Append("\n");
            sb.Append("  SessionLength: ").Append(SessionLength).Append("\n");
            sb.Append("  ShowLogs: ").Append(ShowLogs).Append("\n");
            sb.Append("  ShowSuggestions: ").Append(ShowSuggestions).Append("\n");
            sb.Append("  AutoRedirect: ").Append(AutoRedirect).Append("\n");
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
            return this.Equals(input as SessionSettings);
        }

        /// <summary>
        /// Returns true if SessionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnifiedApis == input.UnifiedApis ||
                    this.UnifiedApis != null &&
                    input.UnifiedApis != null &&
                    this.UnifiedApis.SequenceEqual(input.UnifiedApis)
                ) && 
                (
                    this.HideResourceSettings == input.HideResourceSettings ||
                    this.HideResourceSettings.Equals(input.HideResourceSettings)
                ) && 
                (
                    this.SandboxMode == input.SandboxMode ||
                    this.SandboxMode.Equals(input.SandboxMode)
                ) && 
                (
                    this.IsolationMode == input.IsolationMode ||
                    this.IsolationMode.Equals(input.IsolationMode)
                ) && 
                (
                    this.SessionLength == input.SessionLength ||
                    (this.SessionLength != null &&
                    this.SessionLength.Equals(input.SessionLength))
                ) && 
                (
                    this.ShowLogs == input.ShowLogs ||
                    this.ShowLogs.Equals(input.ShowLogs)
                ) && 
                (
                    this.ShowSuggestions == input.ShowSuggestions ||
                    this.ShowSuggestions.Equals(input.ShowSuggestions)
                ) && 
                (
                    this.AutoRedirect == input.AutoRedirect ||
                    this.AutoRedirect.Equals(input.AutoRedirect)
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
                if (this.UnifiedApis != null)
                {
                    hashCode = (hashCode * 59) + this.UnifiedApis.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HideResourceSettings.GetHashCode();
                hashCode = (hashCode * 59) + this.SandboxMode.GetHashCode();
                hashCode = (hashCode * 59) + this.IsolationMode.GetHashCode();
                if (this.SessionLength != null)
                {
                    hashCode = (hashCode * 59) + this.SessionLength.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowLogs.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowSuggestions.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoRedirect.GetHashCode();
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
