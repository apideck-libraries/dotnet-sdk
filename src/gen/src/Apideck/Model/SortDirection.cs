/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.44.0
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
    /// The direction in which to sort the results
    /// </summary>
    /// <value>The direction in which to sort the results</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDirection
    {
        /// <summary>
        /// Enum Asc for value: asc
        /// </summary>
        [EnumMember(Value = "asc")]
        Asc = 1,

        /// <summary>
        /// Enum Desc for value: desc
        /// </summary>
        [EnumMember(Value = "desc")]
        Desc = 2

    }

}
