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
    /// The gender represents the gender identity of a person.
    /// </summary>
    /// <value>The gender represents the gender identity of a person.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gender
    {
        /// <summary>
        /// Enum Male for value: male
        /// </summary>
        [EnumMember(Value = "male")]
        Male = 1,

        /// <summary>
        /// Enum Female for value: female
        /// </summary>
        [EnumMember(Value = "female")]
        Female = 2,

        /// <summary>
        /// Enum Unisex for value: unisex
        /// </summary>
        [EnumMember(Value = "unisex")]
        Unisex = 3,

        /// <summary>
        /// Enum Other for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        Other = 4,

        /// <summary>
        /// Enum NotSpecified for value: not_specified
        /// </summary>
        [EnumMember(Value = "not_specified")]
        NotSpecified = 5

    }

}
