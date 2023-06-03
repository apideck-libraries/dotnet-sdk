/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.7.1
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
    /// FormFieldOption
    /// </summary>
    [JsonConverter(typeof(FormFieldOptionJsonConverter))]
    [DataContract(Name = "FormFieldOption")]
    public partial class FormFieldOption : AbstractOpenAPISchema, IEquatable<FormFieldOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormFieldOption" /> class
        /// with the <see cref="FormFieldOptionGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FormFieldOptionGroup.</param>
        public FormFieldOption(FormFieldOptionGroup actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormFieldOption" /> class
        /// with the <see cref="SimpleFormFieldOption" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SimpleFormFieldOption.</param>
        public FormFieldOption(SimpleFormFieldOption actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(FormFieldOptionGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SimpleFormFieldOption))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: FormFieldOptionGroup, SimpleFormFieldOption");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `FormFieldOptionGroup`. If the actual instance is not `FormFieldOptionGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of FormFieldOptionGroup</returns>
        public FormFieldOptionGroup GetFormFieldOptionGroup()
        {
            return (FormFieldOptionGroup)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SimpleFormFieldOption`. If the actual instance is not `SimpleFormFieldOption`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SimpleFormFieldOption</returns>
        public SimpleFormFieldOption GetSimpleFormFieldOption()
        {
            return (SimpleFormFieldOption)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormFieldOption {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, FormFieldOption.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of FormFieldOption
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of FormFieldOption</returns>
        public static FormFieldOption FromJson(string jsonString)
        {
            FormFieldOption newFormFieldOption = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newFormFieldOption;
            }

            try
            {
                newFormFieldOption = new FormFieldOption(JsonConvert.DeserializeObject<FormFieldOptionGroup>(jsonString, FormFieldOption.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newFormFieldOption;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FormFieldOptionGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newFormFieldOption = new FormFieldOption(JsonConvert.DeserializeObject<SimpleFormFieldOption>(jsonString, FormFieldOption.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newFormFieldOption;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SimpleFormFieldOption: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FormFieldOption);
        }

        /// <summary>
        /// Returns true if FormFieldOption instances are equal
        /// </summary>
        /// <param name="input">Instance of FormFieldOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormFieldOption input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for FormFieldOption
    /// </summary>
    public class FormFieldOptionJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(FormFieldOption).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return FormFieldOption.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
