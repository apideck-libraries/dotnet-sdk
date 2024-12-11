/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.9.0
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
    /// Current status of the order.
    /// </summary>
    /// <value>Current status of the order.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EcommerceOrderStatus
    {
        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,

        /// <summary>
        /// Enum Completed for value: completed
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed = 2,

        /// <summary>
        /// Enum Cancelled for value: cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled = 3,

        /// <summary>
        /// Enum Archived for value: archived
        /// </summary>
        [EnumMember(Value = "archived")]
        Archived = 4,

        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 5,

        /// <summary>
        /// Enum Other for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        Other = 6

    }

}
