/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.1.3
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
    /// FormField
    /// </summary>
    [DataContract(Name = "FormField")]
    public partial class FormField : IEquatable<FormField>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,

            /// <summary>
            /// Enum Checkbox for value: checkbox
            /// </summary>
            [EnumMember(Value = "checkbox")]
            Checkbox = 2,

            /// <summary>
            /// Enum Tel for value: tel
            /// </summary>
            [EnumMember(Value = "tel")]
            Tel = 3,

            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 4,

            /// <summary>
            /// Enum Url for value: url
            /// </summary>
            [EnumMember(Value = "url")]
            Url = 5,

            /// <summary>
            /// Enum Textarea for value: textarea
            /// </summary>
            [EnumMember(Value = "textarea")]
            Textarea = 6,

            /// <summary>
            /// Enum Select for value: select
            /// </summary>
            [EnumMember(Value = "select")]
            Select = 7,

            /// <summary>
            /// Enum FilteredSelect for value: filtered-select
            /// </summary>
            [EnumMember(Value = "filtered-select")]
            FilteredSelect = 8,

            /// <summary>
            /// Enum MultiSelect for value: multi-select
            /// </summary>
            [EnumMember(Value = "multi-select")]
            MultiSelect = 9,

            /// <summary>
            /// Enum Datetime for value: datetime
            /// </summary>
            [EnumMember(Value = "datetime")]
            Datetime = 10,

            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 11,

            /// <summary>
            /// Enum Time for value: time
            /// </summary>
            [EnumMember(Value = "time")]
            Time = 12,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 13

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormField" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the form field..</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="placeholder">The placeholder for the form field.</param>
        /// <param name="description">The description of the form field.</param>
        /// <param name="type">type.</param>
        /// <param name="required">Indicates if the form field is required, which means it must be filled in before the form can be submitted.</param>
        /// <param name="customField">customField.</param>
        /// <param name="allowCustomValues">Only applicable to select fields. Allow the user to add a custom value though the option select if the desired value is not in the option select list. (default to false).</param>
        /// <param name="disabled">Indicates if the form field is displayed in a “read-only” mode..</param>
        /// <param name="hidden">Indicates if the form field is not displayed but the value that is being stored on the connection..</param>
        /// <param name="deprecated">When the setting is deprecated, it should be hidden from the user interface. The value will still be stored on the connection for the sake of backwards compatibility..</param>
        /// <param name="sensitive">Indicates if the form field contains sensitive data, which will display the value as a masked input..</param>
        /// <param name="prefix">Prefix to display in front of the form field..</param>
        /// <param name="suffix">Suffix to display next to the form field..</param>
        /// <param name="options">options.</param>
        public FormField(string id = default(string), string label = default(string), string placeholder = default(string), string description = default(string), TypeEnum? type = default(TypeEnum?), bool required = default(bool), bool customField = default(bool), bool allowCustomValues = false, bool? disabled = default(bool?), bool? hidden = default(bool?), bool? deprecated = default(bool?), bool? sensitive = default(bool?), string prefix = default(string), string suffix = default(string), List<FormFieldOption> options = default(List<FormFieldOption>))
        {
            this.Id = id;
            this.Label = label;
            this.Placeholder = placeholder;
            this.Description = description;
            this.Type = type;
            this.Required = required;
            this.CustomField = customField;
            this.AllowCustomValues = allowCustomValues;
            this.Disabled = disabled;
            this.Hidden = hidden;
            this.Deprecated = deprecated;
            this.Sensitive = sensitive;
            this.Prefix = prefix;
            this.Suffix = suffix;
            this.Options = options;
        }

        /// <summary>
        /// The unique identifier of the form field.
        /// </summary>
        /// <value>The unique identifier of the form field.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The label of the field
        /// </summary>
        /// <value>The label of the field</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// The placeholder for the form field
        /// </summary>
        /// <value>The placeholder for the form field</value>
        [DataMember(Name = "placeholder", EmitDefaultValue = true)]
        public string Placeholder { get; set; }

        /// <summary>
        /// The description of the form field
        /// </summary>
        /// <value>The description of the form field</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates if the form field is required, which means it must be filled in before the form can be submitted
        /// </summary>
        /// <value>Indicates if the form field is required, which means it must be filled in before the form can be submitted</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or Sets CustomField
        /// </summary>
        [DataMember(Name = "custom_field", EmitDefaultValue = true)]
        public bool CustomField { get; set; }

        /// <summary>
        /// Only applicable to select fields. Allow the user to add a custom value though the option select if the desired value is not in the option select list.
        /// </summary>
        /// <value>Only applicable to select fields. Allow the user to add a custom value though the option select if the desired value is not in the option select list.</value>
        [DataMember(Name = "allow_custom_values", EmitDefaultValue = true)]
        public bool AllowCustomValues { get; set; }

        /// <summary>
        /// Indicates if the form field is displayed in a “read-only” mode.
        /// </summary>
        /// <value>Indicates if the form field is displayed in a “read-only” mode.</value>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Indicates if the form field is not displayed but the value that is being stored on the connection.
        /// </summary>
        /// <value>Indicates if the form field is not displayed but the value that is being stored on the connection.</value>
        [DataMember(Name = "hidden", EmitDefaultValue = true)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// When the setting is deprecated, it should be hidden from the user interface. The value will still be stored on the connection for the sake of backwards compatibility.
        /// </summary>
        /// <value>When the setting is deprecated, it should be hidden from the user interface. The value will still be stored on the connection for the sake of backwards compatibility.</value>
        [DataMember(Name = "deprecated", EmitDefaultValue = true)]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Indicates if the form field contains sensitive data, which will display the value as a masked input.
        /// </summary>
        /// <value>Indicates if the form field contains sensitive data, which will display the value as a masked input.</value>
        [DataMember(Name = "sensitive", EmitDefaultValue = true)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Prefix to display in front of the form field.
        /// </summary>
        /// <value>Prefix to display in front of the form field.</value>
        [DataMember(Name = "prefix", EmitDefaultValue = true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Suffix to display next to the form field.
        /// </summary>
        /// <value>Suffix to display next to the form field.</value>
        [DataMember(Name = "suffix", EmitDefaultValue = true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<FormFieldOption> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FormField {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  AllowCustomValues: ").Append(AllowCustomValues).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  Sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as FormField);
        }

        /// <summary>
        /// Returns true if FormField instances are equal
        /// </summary>
        /// <param name="input">Instance of FormField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormField input)
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
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Placeholder == input.Placeholder ||
                    (this.Placeholder != null &&
                    this.Placeholder.Equals(input.Placeholder))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.CustomField == input.CustomField ||
                    this.CustomField.Equals(input.CustomField)
                ) && 
                (
                    this.AllowCustomValues == input.AllowCustomValues ||
                    this.AllowCustomValues.Equals(input.AllowCustomValues)
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Deprecated == input.Deprecated ||
                    (this.Deprecated != null &&
                    this.Deprecated.Equals(input.Deprecated))
                ) && 
                (
                    this.Sensitive == input.Sensitive ||
                    (this.Sensitive != null &&
                    this.Sensitive.Equals(input.Sensitive))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Placeholder != null)
                {
                    hashCode = (hashCode * 59) + this.Placeholder.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                hashCode = (hashCode * 59) + this.CustomField.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowCustomValues.GetHashCode();
                if (this.Disabled != null)
                {
                    hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
                }
                if (this.Hidden != null)
                {
                    hashCode = (hashCode * 59) + this.Hidden.GetHashCode();
                }
                if (this.Deprecated != null)
                {
                    hashCode = (hashCode * 59) + this.Deprecated.GetHashCode();
                }
                if (this.Sensitive != null)
                {
                    hashCode = (hashCode * 59) + this.Sensitive.GetHashCode();
                }
                if (this.Prefix != null)
                {
                    hashCode = (hashCode * 59) + this.Prefix.GetHashCode();
                }
                if (this.Suffix != null)
                {
                    hashCode = (hashCode * 59) + this.Suffix.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
