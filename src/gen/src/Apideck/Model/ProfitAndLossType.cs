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
    /// The type of profit and loss
    /// </summary>
    /// <value>The type of profit and loss</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProfitAndLossType
    {
        /// <summary>
        /// Enum Section for value: Section
        /// </summary>
        [EnumMember(Value = "Section")]
        Section = 1,

        /// <summary>
        /// Enum Record for value: Record
        /// </summary>
        [EnumMember(Value = "Record")]
        Record = 2

    }

}
