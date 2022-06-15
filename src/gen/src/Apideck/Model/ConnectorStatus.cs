/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.2
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
    /// Status of the connector. Connectors with status live or beta are callable.
    /// </summary>
    /// <value>Status of the connector. Connectors with status live or beta are callable.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorStatus
    {
        /// <summary>
        /// Enum Live for value: live
        /// </summary>
        [EnumMember(Value = "live")]
        Live = 1,

        /// <summary>
        /// Enum Beta for value: beta
        /// </summary>
        [EnumMember(Value = "beta")]
        Beta = 2,

        /// <summary>
        /// Enum Development for value: development
        /// </summary>
        [EnumMember(Value = "development")]
        Development = 3,

        /// <summary>
        /// Enum Considering for value: considering
        /// </summary>
        [EnumMember(Value = "considering")]
        Considering = 4

    }

}
