/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.4
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
    /// Defines AtsEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AtsEventType
    {
        /// <summary>
        /// Enum JobCreated for value: ats.job.created
        /// </summary>
        [EnumMember(Value = "ats.job.created")]
        JobCreated = 1,

        /// <summary>
        /// Enum JobUpdated for value: ats.job.updated
        /// </summary>
        [EnumMember(Value = "ats.job.updated")]
        JobUpdated = 2,

        /// <summary>
        /// Enum JobDeleted for value: ats.job.deleted
        /// </summary>
        [EnumMember(Value = "ats.job.deleted")]
        JobDeleted = 3,

        /// <summary>
        /// Enum ApplicantCreated for value: ats.applicant.created
        /// </summary>
        [EnumMember(Value = "ats.applicant.created")]
        ApplicantCreated = 4,

        /// <summary>
        /// Enum ApplicantUpdated for value: ats.applicant.updated
        /// </summary>
        [EnumMember(Value = "ats.applicant.updated")]
        ApplicantUpdated = 5,

        /// <summary>
        /// Enum ApplicantDeleted for value: ats.applicant.deleted
        /// </summary>
        [EnumMember(Value = "ats.applicant.deleted")]
        ApplicantDeleted = 6

    }

}
