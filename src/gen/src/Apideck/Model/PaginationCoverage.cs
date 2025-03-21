/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.13.0
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
    /// PaginationCoverage
    /// </summary>
    [DataContract(Name = "PaginationCoverage")]
    public partial class PaginationCoverage : IEquatable<PaginationCoverage>, IValidatableObject
    {
        /// <summary>
        /// How pagination is implemented on this connector. Native mode means Apideck is using the pagination parameters of the connector. With virtual pagination, the connector does not support pagination, but Apideck emulates it.
        /// </summary>
        /// <value>How pagination is implemented on this connector. Native mode means Apideck is using the pagination parameters of the connector. With virtual pagination, the connector does not support pagination, but Apideck emulates it.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Native for value: native
            /// </summary>
            [EnumMember(Value = "native")]
            Native = 1,

            /// <summary>
            /// Enum Virtual for value: virtual
            /// </summary>
            [EnumMember(Value = "virtual")]
            Virtual = 2

        }


        /// <summary>
        /// How pagination is implemented on this connector. Native mode means Apideck is using the pagination parameters of the connector. With virtual pagination, the connector does not support pagination, but Apideck emulates it.
        /// </summary>
        /// <value>How pagination is implemented on this connector. Native mode means Apideck is using the pagination parameters of the connector. With virtual pagination, the connector does not support pagination, but Apideck emulates it.</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationCoverage" /> class.
        /// </summary>
        /// <param name="mode">How pagination is implemented on this connector. Native mode means Apideck is using the pagination parameters of the connector. With virtual pagination, the connector does not support pagination, but Apideck emulates it..</param>
        /// <param name="pagingSupport">Indicates whether the connector supports paging through results using the cursor parameter..</param>
        /// <param name="limitSupport">Indicates whether the connector supports changing the page size by using the limit parameter..</param>
        public PaginationCoverage(ModeEnum? mode = default(ModeEnum?), bool pagingSupport = default(bool), bool limitSupport = default(bool))
        {
            this.Mode = mode;
            this.PagingSupport = pagingSupport;
            this.LimitSupport = limitSupport;
        }

        /// <summary>
        /// Indicates whether the connector supports paging through results using the cursor parameter.
        /// </summary>
        /// <value>Indicates whether the connector supports paging through results using the cursor parameter.</value>
        [DataMember(Name = "paging_support", EmitDefaultValue = true)]
        public bool PagingSupport { get; set; }

        /// <summary>
        /// Indicates whether the connector supports changing the page size by using the limit parameter.
        /// </summary>
        /// <value>Indicates whether the connector supports changing the page size by using the limit parameter.</value>
        [DataMember(Name = "limit_support", EmitDefaultValue = true)]
        public bool LimitSupport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginationCoverage {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  PagingSupport: ").Append(PagingSupport).Append("\n");
            sb.Append("  LimitSupport: ").Append(LimitSupport).Append("\n");
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
            return this.Equals(input as PaginationCoverage);
        }

        /// <summary>
        /// Returns true if PaginationCoverage instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginationCoverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginationCoverage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.PagingSupport == input.PagingSupport ||
                    this.PagingSupport.Equals(input.PagingSupport)
                ) && 
                (
                    this.LimitSupport == input.LimitSupport ||
                    this.LimitSupport.Equals(input.LimitSupport)
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
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                hashCode = (hashCode * 59) + this.PagingSupport.GetHashCode();
                hashCode = (hashCode * 59) + this.LimitSupport.GetHashCode();
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
