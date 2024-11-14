/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.8.1
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
    /// Defines CrmEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CrmEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum CrmActivityCreated for value: crm.activity.created
        /// </summary>
        [EnumMember(Value = "crm.activity.created")]
        CrmActivityCreated = 2,

        /// <summary>
        /// Enum CrmActivityUpdated for value: crm.activity.updated
        /// </summary>
        [EnumMember(Value = "crm.activity.updated")]
        CrmActivityUpdated = 3,

        /// <summary>
        /// Enum CrmActivityDeleted for value: crm.activity.deleted
        /// </summary>
        [EnumMember(Value = "crm.activity.deleted")]
        CrmActivityDeleted = 4,

        /// <summary>
        /// Enum CrmCompanyCreated for value: crm.company.created
        /// </summary>
        [EnumMember(Value = "crm.company.created")]
        CrmCompanyCreated = 5,

        /// <summary>
        /// Enum CrmCompanyUpdated for value: crm.company.updated
        /// </summary>
        [EnumMember(Value = "crm.company.updated")]
        CrmCompanyUpdated = 6,

        /// <summary>
        /// Enum CrmCompanyDeleted for value: crm.company.deleted
        /// </summary>
        [EnumMember(Value = "crm.company.deleted")]
        CrmCompanyDeleted = 7,

        /// <summary>
        /// Enum CrmContactCreated for value: crm.contact.created
        /// </summary>
        [EnumMember(Value = "crm.contact.created")]
        CrmContactCreated = 8,

        /// <summary>
        /// Enum CrmContactUpdated for value: crm.contact.updated
        /// </summary>
        [EnumMember(Value = "crm.contact.updated")]
        CrmContactUpdated = 9,

        /// <summary>
        /// Enum CrmContactDeleted for value: crm.contact.deleted
        /// </summary>
        [EnumMember(Value = "crm.contact.deleted")]
        CrmContactDeleted = 10,

        /// <summary>
        /// Enum CrmLeadCreated for value: crm.lead.created
        /// </summary>
        [EnumMember(Value = "crm.lead.created")]
        CrmLeadCreated = 11,

        /// <summary>
        /// Enum CrmLeadUpdated for value: crm.lead.updated
        /// </summary>
        [EnumMember(Value = "crm.lead.updated")]
        CrmLeadUpdated = 12,

        /// <summary>
        /// Enum CrmLeadDeleted for value: crm.lead.deleted
        /// </summary>
        [EnumMember(Value = "crm.lead.deleted")]
        CrmLeadDeleted = 13,

        /// <summary>
        /// Enum CrmNoteCreated for value: crm.note.created
        /// </summary>
        [EnumMember(Value = "crm.note.created")]
        CrmNoteCreated = 14,

        /// <summary>
        /// Enum CrmNoteUpdated for value: crm.note.updated
        /// </summary>
        [EnumMember(Value = "crm.note.updated")]
        CrmNoteUpdated = 15,

        /// <summary>
        /// Enum CrmNoteDeleted for value: crm.note.deleted
        /// </summary>
        [EnumMember(Value = "crm.note.deleted")]
        CrmNoteDeleted = 16,

        /// <summary>
        /// Enum CrmOpportunityCreated for value: crm.opportunity.created
        /// </summary>
        [EnumMember(Value = "crm.opportunity.created")]
        CrmOpportunityCreated = 17,

        /// <summary>
        /// Enum CrmOpportunityUpdated for value: crm.opportunity.updated
        /// </summary>
        [EnumMember(Value = "crm.opportunity.updated")]
        CrmOpportunityUpdated = 18,

        /// <summary>
        /// Enum CrmOpportunityDeleted for value: crm.opportunity.deleted
        /// </summary>
        [EnumMember(Value = "crm.opportunity.deleted")]
        CrmOpportunityDeleted = 19

    }

}
