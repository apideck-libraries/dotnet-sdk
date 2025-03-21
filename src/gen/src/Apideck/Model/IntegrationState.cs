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
    /// The current state of the Integration.
    /// </summary>
    /// <value>The current state of the Integration.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IntegrationState
    {
        /// <summary>
        /// Enum Disabled for value: disabled
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled = 1,

        /// <summary>
        /// Enum NeedsConfiguration for value: needs_configuration
        /// </summary>
        [EnumMember(Value = "needs_configuration")]
        NeedsConfiguration = 2,

        /// <summary>
        /// Enum Configured for value: configured
        /// </summary>
        [EnumMember(Value = "configured")]
        Configured = 3

    }

}
