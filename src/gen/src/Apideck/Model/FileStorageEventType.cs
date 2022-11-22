/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.85.0
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
    /// Defines FileStorageEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileStorageEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum FileStorageFileCreated for value: file-storage.file.created
        /// </summary>
        [EnumMember(Value = "file-storage.file.created")]
        FileStorageFileCreated = 2,

        /// <summary>
        /// Enum FileStorageFileUpdated for value: file-storage.file.updated
        /// </summary>
        [EnumMember(Value = "file-storage.file.updated")]
        FileStorageFileUpdated = 3,

        /// <summary>
        /// Enum FileStorageFileDeleted for value: file-storage.file.deleted
        /// </summary>
        [EnumMember(Value = "file-storage.file.deleted")]
        FileStorageFileDeleted = 4

    }

}