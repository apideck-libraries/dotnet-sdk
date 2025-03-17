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
    /// Type of authorization used by the connector
    /// </summary>
    /// <value>Type of authorization used by the connector</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthType
    {
        /// <summary>
        /// Enum Oauth2 for value: oauth2
        /// </summary>
        [EnumMember(Value = "oauth2")]
        Oauth2 = 1,

        /// <summary>
        /// Enum ApiKey for value: apiKey
        /// </summary>
        [EnumMember(Value = "apiKey")]
        ApiKey = 2,

        /// <summary>
        /// Enum Basic for value: basic
        /// </summary>
        [EnumMember(Value = "basic")]
        Basic = 3,

        /// <summary>
        /// Enum Custom for value: custom
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom = 4,

        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 5

    }

}
