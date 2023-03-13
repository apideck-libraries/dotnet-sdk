/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.1
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
    /// Defines IssueTrackingEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IssueTrackingEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum IssueTrackingTicketCreated for value: issue-tracking.ticket.created
        /// </summary>
        [EnumMember(Value = "issue-tracking.ticket.created")]
        IssueTrackingTicketCreated = 2,

        /// <summary>
        /// Enum IssueTrackingTicketUpdated for value: issue-tracking.ticket.updated
        /// </summary>
        [EnumMember(Value = "issue-tracking.ticket.updated")]
        IssueTrackingTicketUpdated = 3,

        /// <summary>
        /// Enum IssueTrackingTicketDeleted for value: issue-tracking.ticket.deleted
        /// </summary>
        [EnumMember(Value = "issue-tracking.ticket.deleted")]
        IssueTrackingTicketDeleted = 4

    }

}
