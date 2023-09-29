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
    /// Defines VaultEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VaultEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum VaultConnectionCreated for value: vault.connection.created
        /// </summary>
        [EnumMember(Value = "vault.connection.created")]
        VaultConnectionCreated = 2,

        /// <summary>
        /// Enum VaultConnectionUpdated for value: vault.connection.updated
        /// </summary>
        [EnumMember(Value = "vault.connection.updated")]
        VaultConnectionUpdated = 3,

        /// <summary>
        /// Enum VaultConnectionDisabled for value: vault.connection.disabled
        /// </summary>
        [EnumMember(Value = "vault.connection.disabled")]
        VaultConnectionDisabled = 4,

        /// <summary>
        /// Enum VaultConnectionDeleted for value: vault.connection.deleted
        /// </summary>
        [EnumMember(Value = "vault.connection.deleted")]
        VaultConnectionDeleted = 5,

        /// <summary>
        /// Enum VaultConnectionCallable for value: vault.connection.callable
        /// </summary>
        [EnumMember(Value = "vault.connection.callable")]
        VaultConnectionCallable = 6,

        /// <summary>
        /// Enum VaultConnectionRevoked for value: vault.connection.revoked
        /// </summary>
        [EnumMember(Value = "vault.connection.revoked")]
        VaultConnectionRevoked = 7,

        /// <summary>
        /// Enum VaultConnectionTokenRefreshFailed for value: vault.connection.token_refresh.failed
        /// </summary>
        [EnumMember(Value = "vault.connection.token_refresh.failed")]
        VaultConnectionTokenRefreshFailed = 8

    }

}
