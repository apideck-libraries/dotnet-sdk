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
    /// OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types
    /// </summary>
    /// <value>OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OAuthGrantType
    {
        /// <summary>
        /// Enum AuthorizationCode for value: authorization_code
        /// </summary>
        [EnumMember(Value = "authorization_code")]
        AuthorizationCode = 1,

        /// <summary>
        /// Enum ClientCredentials for value: client_credentials
        /// </summary>
        [EnumMember(Value = "client_credentials")]
        ClientCredentials = 2,

        /// <summary>
        /// Enum Password for value: password
        /// </summary>
        [EnumMember(Value = "password")]
        Password = 3

    }

}
