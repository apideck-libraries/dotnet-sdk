/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.3.0
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
    /// The type of resource. Could be file, folder or url
    /// </summary>
    /// <value>The type of resource. Could be file, folder or url</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileType
    {
        /// <summary>
        /// Enum File for value: file
        /// </summary>
        [EnumMember(Value = "file")]
        File = 1,

        /// <summary>
        /// Enum Folder for value: folder
        /// </summary>
        [EnumMember(Value = "folder")]
        Folder = 2,

        /// <summary>
        /// Enum Url for value: url
        /// </summary>
        [EnumMember(Value = "url")]
        Url = 3

    }

}
