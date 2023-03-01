/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.0
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
    /// The employment status of the employee, indicating whether they are currently employed, inactive, terminated, or in another status.
    /// </summary>
    /// <value>The employment status of the employee, indicating whether they are currently employed, inactive, terminated, or in another status.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmploymentStatus
    {
        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,

        /// <summary>
        /// Enum Inactive for value: inactive
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive = 2,

        /// <summary>
        /// Enum Terminated for value: terminated
        /// </summary>
        [EnumMember(Value = "terminated")]
        Terminated = 3,

        /// <summary>
        /// Enum Other for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        Other = 4

    }

}
