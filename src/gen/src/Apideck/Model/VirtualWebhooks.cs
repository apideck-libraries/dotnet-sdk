/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.91.0
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
    /// Virtual webhook config for the connector.
    /// </summary>
    [DataContract(Name = "Virtual_Webhooks")]
    public partial class VirtualWebhooks : IEquatable<VirtualWebhooks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualWebhooks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VirtualWebhooks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualWebhooks" /> class.
        /// </summary>
        /// <param name="requestRate">requestRate (required).</param>
        /// <param name="resources">The resources that will be requested from downstream..</param>
        public VirtualWebhooks(RequestRate requestRate = default(RequestRate), Object resources = default(Object))
        {
            // to ensure "requestRate" is required (not null)
            if (requestRate == null) {
                throw new ArgumentNullException("requestRate is a required property for VirtualWebhooks and cannot be null");
            }
            this.RequestRate = requestRate;
            this.Resources = resources;
        }

        /// <summary>
        /// Gets or Sets RequestRate
        /// </summary>
        [DataMember(Name = "request_rate", IsRequired = true, EmitDefaultValue = false)]
        public RequestRate RequestRate { get; set; }

        /// <summary>
        /// The resources that will be requested from downstream.
        /// </summary>
        /// <value>The resources that will be requested from downstream.</value>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public Object Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VirtualWebhooks {\n");
            sb.Append("  RequestRate: ").Append(RequestRate).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as VirtualWebhooks);
        }

        /// <summary>
        /// Returns true if VirtualWebhooks instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualWebhooks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualWebhooks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestRate == input.RequestRate ||
                    (this.RequestRate != null &&
                    this.RequestRate.Equals(input.RequestRate))
                ) && 
                (
                    this.Resources == input.Resources ||
                    (this.Resources != null &&
                    this.Resources.Equals(input.Resources))
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
                if (this.RequestRate != null)
                {
                    hashCode = (hashCode * 59) + this.RequestRate.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
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
