/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.13.0
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
    /// Defines HrisEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HrisEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum HrisEmployeeCreated for value: hris.employee.created
        /// </summary>
        [EnumMember(Value = "hris.employee.created")]
        HrisEmployeeCreated = 2,

        /// <summary>
        /// Enum HrisEmployeeUpdated for value: hris.employee.updated
        /// </summary>
        [EnumMember(Value = "hris.employee.updated")]
        HrisEmployeeUpdated = 3,

        /// <summary>
        /// Enum HrisEmployeeTerminated for value: hris.employee.terminated
        /// </summary>
        [EnumMember(Value = "hris.employee.terminated")]
        HrisEmployeeTerminated = 4,

        /// <summary>
        /// Enum HrisEmployeeDeleted for value: hris.employee.deleted
        /// </summary>
        [EnumMember(Value = "hris.employee.deleted")]
        HrisEmployeeDeleted = 5,

        /// <summary>
        /// Enum HrisCompanyCreated for value: hris.company.created
        /// </summary>
        [EnumMember(Value = "hris.company.created")]
        HrisCompanyCreated = 6,

        /// <summary>
        /// Enum HrisCompanyUpdated for value: hris.company.updated
        /// </summary>
        [EnumMember(Value = "hris.company.updated")]
        HrisCompanyUpdated = 7,

        /// <summary>
        /// Enum HrisCompanyDeleted for value: hris.company.deleted
        /// </summary>
        [EnumMember(Value = "hris.company.deleted")]
        HrisCompanyDeleted = 8

    }

}
