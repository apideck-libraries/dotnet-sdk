/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.6
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
    /// ResourceExample
    /// </summary>
    [DataContract(Name = "ResourceExample")]
    public partial class ResourceExample : IEquatable<ResourceExample>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets UnifiedApi
        /// </summary>
        [DataMember(Name = "unified_api", EmitDefaultValue = false)]
        public UnifiedApiId? UnifiedApi { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceExample" /> class.
        /// </summary>
        /// <param name="unifiedApi">unifiedApi.</param>
        /// <param name="serviceId">Service provider identifier.</param>
        /// <param name="resource">resource.</param>
        /// <param name="exampleResponse">Example response from the downstream API.</param>
        public ResourceExample(UnifiedApiId? unifiedApi = default(UnifiedApiId?), string serviceId = default(string), LinkedConnectorResource resource = default(LinkedConnectorResource), Object exampleResponse = default(Object))
        {
            this.UnifiedApi = unifiedApi;
            this.ServiceId = serviceId;
            this.Resource = resource;
            this.ExampleResponse = exampleResponse;
        }

        /// <summary>
        /// Service provider identifier
        /// </summary>
        /// <value>Service provider identifier</value>
        [DataMember(Name = "service_id", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public LinkedConnectorResource Resource { get; set; }

        /// <summary>
        /// Example response from the downstream API
        /// </summary>
        /// <value>Example response from the downstream API</value>
        [DataMember(Name = "example_response", EmitDefaultValue = false)]
        public Object ExampleResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceExample {\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  ExampleResponse: ").Append(ExampleResponse).Append("\n");
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
            return this.Equals(input as ResourceExample);
        }

        /// <summary>
        /// Returns true if ResourceExample instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceExample to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceExample input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnifiedApi == input.UnifiedApi ||
                    this.UnifiedApi.Equals(input.UnifiedApi)
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.ExampleResponse == input.ExampleResponse ||
                    (this.ExampleResponse != null &&
                    this.ExampleResponse.Equals(input.ExampleResponse))
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
                hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
                }
                if (this.ExampleResponse != null)
                {
                    hashCode = (hashCode * 59) + this.ExampleResponse.GetHashCode();
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
