/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.1.1
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
    /// Frequency of employee compensation.
    /// </summary>
    /// <value>Frequency of employee compensation.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentFrequency
    {
        /// <summary>
        /// Enum Weekly for value: weekly
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly = 1,

        /// <summary>
        /// Enum Biweekly for value: biweekly
        /// </summary>
        [EnumMember(Value = "biweekly")]
        Biweekly = 2,

        /// <summary>
        /// Enum Monthly for value: monthly
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly = 3,

        /// <summary>
        /// Enum ProRata for value: pro-rata
        /// </summary>
        [EnumMember(Value = "pro-rata")]
        ProRata = 4,

        /// <summary>
        /// Enum Other for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        Other = 5

    }

}
