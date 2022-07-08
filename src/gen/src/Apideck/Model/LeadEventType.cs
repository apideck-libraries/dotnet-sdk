/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.34.0
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
    /// Defines LeadEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LeadEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum LeadLeadCreated for value: lead.lead.created
        /// </summary>
        [EnumMember(Value = "lead.lead.created")]
        LeadLeadCreated = 2,

        /// <summary>
        /// Enum LeadLeadUpdated for value: lead.lead.updated
        /// </summary>
        [EnumMember(Value = "lead.lead.updated")]
        LeadLeadUpdated = 3,

        /// <summary>
        /// Enum LeadLeadDeleted for value: lead.lead.deleted
        /// </summary>
        [EnumMember(Value = "lead.lead.deleted")]
        LeadLeadDeleted = 4

    }

}
