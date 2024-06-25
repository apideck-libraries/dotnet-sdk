/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.6.2
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
    /// The status of the job.
    /// </summary>
    /// <value>The status of the job.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobStatus
    {
        /// <summary>
        /// Enum Draft for value: draft
        /// </summary>
        [EnumMember(Value = "draft")]
        Draft = 1,

        /// <summary>
        /// Enum Internal for value: internal
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal = 2,

        /// <summary>
        /// Enum Published for value: published
        /// </summary>
        [EnumMember(Value = "published")]
        Published = 3,

        /// <summary>
        /// Enum Completed for value: completed
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed = 4,

        /// <summary>
        /// Enum OnHold for value: on-hold
        /// </summary>
        [EnumMember(Value = "on-hold")]
        OnHold = 5,

        /// <summary>
        /// Enum Private for value: private
        /// </summary>
        [EnumMember(Value = "private")]
        Private = 6

    }

}
