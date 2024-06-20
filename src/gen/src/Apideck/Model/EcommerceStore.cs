/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.6.0
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
    /// EcommerceStore
    /// </summary>
    [DataContract(Name = "EcommerceStore")]
    public partial class EcommerceStore : IEquatable<EcommerceStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EcommerceStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceStore" /> class.
        /// </summary>
        /// <param name="name">The store&#39;s name.</param>
        /// <param name="storeUrl">The store&#39;s website URL.</param>
        /// <param name="adminUrl">The store&#39;s admin login URL.</param>
        public EcommerceStore(string name = default(string), string storeUrl = default(string), string adminUrl = default(string))
        {
            this.Name = name;
            this.StoreUrl = storeUrl;
            this.AdminUrl = adminUrl;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
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
        /// The store&#39;s name
        /// </summary>
        /// <value>The store&#39;s name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The store&#39;s website URL
        /// </summary>
        /// <value>The store&#39;s website URL</value>
        [DataMember(Name = "store_url", EmitDefaultValue = true)]
        public string StoreUrl { get; set; }

        /// <summary>
        /// The store&#39;s admin login URL
        /// </summary>
        /// <value>The store&#39;s admin login URL</value>
        [DataMember(Name = "admin_url", EmitDefaultValue = true)]
        public string AdminUrl { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; private set; }

        /// <summary>
        /// Returns false as CustomMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomMappings()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcommerceStore {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StoreUrl: ").Append(StoreUrl).Append("\n");
            sb.Append("  AdminUrl: ").Append(AdminUrl).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as EcommerceStore);
        }

        /// <summary>
        /// Returns true if EcommerceStore instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceStore input)
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
                    this.StoreUrl == input.StoreUrl ||
                    (this.StoreUrl != null &&
                    this.StoreUrl.Equals(input.StoreUrl))
                ) && 
                (
                    this.AdminUrl == input.AdminUrl ||
                    (this.AdminUrl != null &&
                    this.AdminUrl.Equals(input.AdminUrl))
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.StoreUrl != null)
                {
                    hashCode = (hashCode * 59) + this.StoreUrl.GetHashCode();
                }
                if (this.AdminUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AdminUrl.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
            // StoreUrl (string) pattern
            Regex regexStoreUrl = new Regex(@"^https?:\/\/", RegexOptions.CultureInvariant);
            if (false == regexStoreUrl.Match(this.StoreUrl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreUrl, must match a pattern of " + regexStoreUrl, new [] { "StoreUrl" });
            }

            // AdminUrl (string) pattern
            Regex regexAdminUrl = new Regex(@"^https?:\/\/", RegexOptions.CultureInvariant);
            if (false == regexAdminUrl.Match(this.AdminUrl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdminUrl, must match a pattern of " + regexAdminUrl, new [] { "AdminUrl" });
            }

            yield break;
        }
    }

}
