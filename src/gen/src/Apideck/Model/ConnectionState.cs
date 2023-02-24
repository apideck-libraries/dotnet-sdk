/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.0.0
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
    /// [Connection state flow](#section/Connection-state)
    /// </summary>
    /// <value>[Connection state flow](#section/Connection-state)</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectionState
    {
        /// <summary>
        /// Enum Available for value: available
        /// </summary>
        [EnumMember(Value = "available")]
        Available = 1,

        /// <summary>
        /// Enum Callable for value: callable
        /// </summary>
        [EnumMember(Value = "callable")]
        Callable = 2,

        /// <summary>
        /// Enum Added for value: added
        /// </summary>
        [EnumMember(Value = "added")]
        Added = 3,

        /// <summary>
        /// Enum Authorized for value: authorized
        /// </summary>
        [EnumMember(Value = "authorized")]
        Authorized = 4

    }

}
