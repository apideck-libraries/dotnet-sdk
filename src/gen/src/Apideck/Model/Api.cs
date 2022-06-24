/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.6
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
    /// Api
    /// </summary>
    [DataContract(Name = "Api")]
    public partial class Api : IEquatable<Api>, IValidatableObject
    {
        /// <summary>
        /// Indicates whether the API is a Unified API. If unified_api is false, the API is a Platform API.
        /// </summary>
        /// <value>Indicates whether the API is a Unified API. If unified_api is false, the API is a Platform API.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Platform for value: platform
            /// </summary>
            [EnumMember(Value = "platform")]
            Platform = 1,

            /// <summary>
            /// Enum Unified for value: unified
            /// </summary>
            [EnumMember(Value = "unified")]
            Unified = 2

        }


        /// <summary>
        /// Indicates whether the API is a Unified API. If unified_api is false, the API is a Platform API.
        /// </summary>
        /// <value>Indicates whether the API is a Unified API. If unified_api is false, the API is a Platform API.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ApiStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Api" /> class.
        /// </summary>
        /// <param name="type">Indicates whether the API is a Unified API. If unified_api is false, the API is a Platform API..</param>
        /// <param name="name">Name of the API..</param>
        /// <param name="description">Description of the API..</param>
        /// <param name="status">status.</param>
        /// <param name="specUrl">Link to the latest OpenAPI specification of the API..</param>
        /// <param name="apiReferenceUrl">Link to the API reference of the API..</param>
        /// <param name="postmanCollectionId">ID of the Postman collection of the API..</param>
        /// <param name="categories">List of categories the API belongs to..</param>
        /// <param name="resources">List of resources supported in this API..</param>
        /// <param name="events">List of event types this API supports..</param>
        public Api(TypeEnum? type = default(TypeEnum?), string name = default(string), string description = default(string), ApiStatus? status = default(ApiStatus?), string specUrl = default(string), string apiReferenceUrl = default(string), string postmanCollectionId = default(string), List<string> categories = default(List<string>), List<ApiResources> resources = default(List<ApiResources>), List<string> events = default(List<string>))
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.SpecUrl = specUrl;
            this.ApiReferenceUrl = apiReferenceUrl;
            this.PostmanCollectionId = postmanCollectionId;
            this.Categories = categories;
            this.Resources = resources;
            this.Events = events;
        }

        /// <summary>
        /// ID of the API.
        /// </summary>
        /// <value>ID of the API.</value>
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
        /// Name of the API.
        /// </summary>
        /// <value>Name of the API.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the API.
        /// </summary>
        /// <value>Description of the API.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Link to the latest OpenAPI specification of the API.
        /// </summary>
        /// <value>Link to the latest OpenAPI specification of the API.</value>
        [DataMember(Name = "spec_url", EmitDefaultValue = false)]
        public string SpecUrl { get; set; }

        /// <summary>
        /// Link to the API reference of the API.
        /// </summary>
        /// <value>Link to the API reference of the API.</value>
        [DataMember(Name = "api_reference_url", EmitDefaultValue = false)]
        public string ApiReferenceUrl { get; set; }

        /// <summary>
        /// ID of the Postman collection of the API.
        /// </summary>
        /// <value>ID of the Postman collection of the API.</value>
        [DataMember(Name = "postman_collection_id", EmitDefaultValue = true)]
        public string PostmanCollectionId { get; set; }

        /// <summary>
        /// List of categories the API belongs to.
        /// </summary>
        /// <value>List of categories the API belongs to.</value>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// List of resources supported in this API.
        /// </summary>
        /// <value>List of resources supported in this API.</value>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public List<ApiResources> Resources { get; set; }

        /// <summary>
        /// List of event types this API supports.
        /// </summary>
        /// <value>List of event types this API supports.</value>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Api {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SpecUrl: ").Append(SpecUrl).Append("\n");
            sb.Append("  ApiReferenceUrl: ").Append(ApiReferenceUrl).Append("\n");
            sb.Append("  PostmanCollectionId: ").Append(PostmanCollectionId).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return this.Equals(input as Api);
        }

        /// <summary>
        /// Returns true if Api instances are equal
        /// </summary>
        /// <param name="input">Instance of Api to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Api input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SpecUrl == input.SpecUrl ||
                    (this.SpecUrl != null &&
                    this.SpecUrl.Equals(input.SpecUrl))
                ) && 
                (
                    this.ApiReferenceUrl == input.ApiReferenceUrl ||
                    (this.ApiReferenceUrl != null &&
                    this.ApiReferenceUrl.Equals(input.ApiReferenceUrl))
                ) && 
                (
                    this.PostmanCollectionId == input.PostmanCollectionId ||
                    (this.PostmanCollectionId != null &&
                    this.PostmanCollectionId.Equals(input.PostmanCollectionId))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SpecUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SpecUrl.GetHashCode();
                }
                if (this.ApiReferenceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ApiReferenceUrl.GetHashCode();
                }
                if (this.PostmanCollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.PostmanCollectionId.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
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
