/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.70.1
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
    /// Defines PaymentUnit
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentUnit
    {
        /// <summary>
        /// Enum Hour for value: hour
        /// </summary>
        [EnumMember(Value = "hour")]
        Hour = 1,

        /// <summary>
        /// Enum Week for value: week
        /// </summary>
        [EnumMember(Value = "week")]
        Week = 2,

        /// <summary>
        /// Enum Month for value: month
        /// </summary>
        [EnumMember(Value = "month")]
        Month = 3,

        /// <summary>
        /// Enum Year for value: year
        /// </summary>
        [EnumMember(Value = "year")]
        Year = 4,

        /// <summary>
        /// Enum Paycheck for value: paycheck
        /// </summary>
        [EnumMember(Value = "paycheck")]
        Paycheck = 5

    }

}
