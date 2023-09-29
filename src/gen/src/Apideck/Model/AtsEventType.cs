/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.9.2
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
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum AtsJobCreated for value: ats.job.created
        /// </summary>
        [EnumMember(Value = "ats.job.created")]
        AtsJobCreated = 2,

        /// <summary>
        /// Enum AtsJobUpdated for value: ats.job.updated
        /// </summary>
        [EnumMember(Value = "ats.job.updated")]
        AtsJobUpdated = 3,

        /// <summary>
        /// Enum AtsJobDeleted for value: ats.job.deleted
        /// </summary>
        [EnumMember(Value = "ats.job.deleted")]
        AtsJobDeleted = 4,

        /// <summary>
        /// Enum AtsApplicantCreated for value: ats.applicant.created
        /// </summary>
        [EnumMember(Value = "ats.applicant.created")]
        AtsApplicantCreated = 5,

        /// <summary>
        /// Enum AtsApplicantUpdated for value: ats.applicant.updated
        /// </summary>
        [EnumMember(Value = "ats.applicant.updated")]
        AtsApplicantUpdated = 6,

        /// <summary>
        /// Enum AtsApplicantDeleted for value: ats.applicant.deleted
        /// </summary>
        [EnumMember(Value = "ats.applicant.deleted")]
        AtsApplicantDeleted = 7,

        /// <summary>
        /// Enum AtsApplicationCreated for value: ats.application.created
        /// </summary>
        [EnumMember(Value = "ats.application.created")]
        AtsApplicationCreated = 8,

        /// <summary>
        /// Enum AtsApplicationUpdated for value: ats.application.updated
        /// </summary>
        [EnumMember(Value = "ats.application.updated")]
        AtsApplicationUpdated = 9,

        /// <summary>
        /// Enum AtsApplicationDeleted for value: ats.application.deleted
        /// </summary>
        [EnumMember(Value = "ats.application.deleted")]
        AtsApplicationDeleted = 10

    }

}
