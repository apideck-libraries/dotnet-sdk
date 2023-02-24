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
    /// Name of Apideck Unified API
    /// </summary>
    /// <value>Name of Apideck Unified API</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnifiedApiId
    {
        /// <summary>
        /// Enum Accounting for value: accounting
        /// </summary>
        [EnumMember(Value = "accounting")]
        Accounting = 1,

        /// <summary>
        /// Enum Ats for value: ats
        /// </summary>
        [EnumMember(Value = "ats")]
        Ats = 2,

        /// <summary>
        /// Enum Calendar for value: calendar
        /// </summary>
        [EnumMember(Value = "calendar")]
        Calendar = 3,

        /// <summary>
        /// Enum Crm for value: crm
        /// </summary>
        [EnumMember(Value = "crm")]
        Crm = 4,

        /// <summary>
        /// Enum Csp for value: csp
        /// </summary>
        [EnumMember(Value = "csp")]
        Csp = 5,

        /// <summary>
        /// Enum CustomerSupport for value: customer-support
        /// </summary>
        [EnumMember(Value = "customer-support")]
        CustomerSupport = 6,

        /// <summary>
        /// Enum Ecommerce for value: ecommerce
        /// </summary>
        [EnumMember(Value = "ecommerce")]
        Ecommerce = 7,

        /// <summary>
        /// Enum Email for value: email
        /// </summary>
        [EnumMember(Value = "email")]
        Email = 8,

        /// <summary>
        /// Enum EmailMarketing for value: email-marketing
        /// </summary>
        [EnumMember(Value = "email-marketing")]
        EmailMarketing = 9,

        /// <summary>
        /// Enum ExpenseManagement for value: expense-management
        /// </summary>
        [EnumMember(Value = "expense-management")]
        ExpenseManagement = 10,

        /// <summary>
        /// Enum FileStorage for value: file-storage
        /// </summary>
        [EnumMember(Value = "file-storage")]
        FileStorage = 11,

        /// <summary>
        /// Enum Form for value: form
        /// </summary>
        [EnumMember(Value = "form")]
        Form = 12,

        /// <summary>
        /// Enum Hris for value: hris
        /// </summary>
        [EnumMember(Value = "hris")]
        Hris = 13,

        /// <summary>
        /// Enum Lead for value: lead
        /// </summary>
        [EnumMember(Value = "lead")]
        Lead = 14,

        /// <summary>
        /// Enum Payroll for value: payroll
        /// </summary>
        [EnumMember(Value = "payroll")]
        Payroll = 15,

        /// <summary>
        /// Enum Pos for value: pos
        /// </summary>
        [EnumMember(Value = "pos")]
        Pos = 16,

        /// <summary>
        /// Enum Procurement for value: procurement
        /// </summary>
        [EnumMember(Value = "procurement")]
        Procurement = 17,

        /// <summary>
        /// Enum ProjectManagement for value: project-management
        /// </summary>
        [EnumMember(Value = "project-management")]
        ProjectManagement = 18,

        /// <summary>
        /// Enum Script for value: script
        /// </summary>
        [EnumMember(Value = "script")]
        Script = 19,

        /// <summary>
        /// Enum Sms for value: sms
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms = 20,

        /// <summary>
        /// Enum Spreadsheet for value: spreadsheet
        /// </summary>
        [EnumMember(Value = "spreadsheet")]
        Spreadsheet = 21,

        /// <summary>
        /// Enum TeamMessaging for value: team-messaging
        /// </summary>
        [EnumMember(Value = "team-messaging")]
        TeamMessaging = 22,

        /// <summary>
        /// Enum IssueTracking for value: issue-tracking
        /// </summary>
        [EnumMember(Value = "issue-tracking")]
        IssueTracking = 23,

        /// <summary>
        /// Enum TimeRegistration for value: time-registration
        /// </summary>
        [EnumMember(Value = "time-registration")]
        TimeRegistration = 24,

        /// <summary>
        /// Enum TransactionalEmail for value: transactional-email
        /// </summary>
        [EnumMember(Value = "transactional-email")]
        TransactionalEmail = 25,

        /// <summary>
        /// Enum Vault for value: vault
        /// </summary>
        [EnumMember(Value = "vault")]
        Vault = 26

    }

}
