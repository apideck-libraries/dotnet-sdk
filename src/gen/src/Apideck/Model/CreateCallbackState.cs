/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.5
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
    /// CreateCallbackState
    /// </summary>
    [DataContract(Name = "CreateCallbackState")]
    public partial class CreateCallbackState : IEquatable<CreateCallbackState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallbackState" /> class.
        /// </summary>
        /// <param name="redirectUri">The redirect URI to be used after the connection is created..</param>
        public CreateCallbackState(string redirectUri = default(string))
        {
            this.RedirectUri = redirectUri;
        }

        /// <summary>
        /// The redirect URI to be used after the connection is created.
        /// </summary>
        /// <value>The redirect URI to be used after the connection is created.</value>
        [DataMember(Name = "redirect_uri", EmitDefaultValue = false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCallbackState {\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
            return this.Equals(input as CreateCallbackState);
        }

        /// <summary>
        /// Returns true if CreateCallbackState instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCallbackState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCallbackState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RedirectUri == input.RedirectUri ||
                    (this.RedirectUri != null &&
                    this.RedirectUri.Equals(input.RedirectUri))
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
                if (this.RedirectUri != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUri.GetHashCode();
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
