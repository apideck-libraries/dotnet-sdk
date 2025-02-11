/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.3
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
    /// Defines AttachmentReferenceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttachmentReferenceType
    {
        /// <summary>
        /// Enum Invoice for value: invoice
        /// </summary>
        [EnumMember(Value = "invoice")]
        Invoice = 1,

        /// <summary>
        /// Enum Bill for value: bill
        /// </summary>
        [EnumMember(Value = "bill")]
        Bill = 2,

        /// <summary>
        /// Enum Expense for value: expense
        /// </summary>
        [EnumMember(Value = "expense")]
        Expense = 3

    }

}
