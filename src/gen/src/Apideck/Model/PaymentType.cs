/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.9.0
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
    /// Type of payment
    /// </summary>
    /// <value>Type of payment</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentType
    {
        /// <summary>
        /// Enum Receivable for value: accounts_receivable
        /// </summary>
        [EnumMember(Value = "accounts_receivable")]
        Receivable = 1,

        /// <summary>
        /// Enum Payable for value: accounts_payable
        /// </summary>
        [EnumMember(Value = "accounts_payable")]
        Payable = 2,

        /// <summary>
        /// Enum ReceivableCredit for value: accounts_receivable_credit
        /// </summary>
        [EnumMember(Value = "accounts_receivable_credit")]
        ReceivableCredit = 3,

        /// <summary>
        /// Enum PayableCredit for value: accounts_payable_credit
        /// </summary>
        [EnumMember(Value = "accounts_payable_credit")]
        PayableCredit = 4,

        /// <summary>
        /// Enum ReceivableOverpayment for value: accounts_receivable_overpayment
        /// </summary>
        [EnumMember(Value = "accounts_receivable_overpayment")]
        ReceivableOverpayment = 5,

        /// <summary>
        /// Enum PayableOverpayment for value: accounts_payable_overpayment
        /// </summary>
        [EnumMember(Value = "accounts_payable_overpayment")]
        PayableOverpayment = 6,

        /// <summary>
        /// Enum ReceivablePrepayment for value: accounts_receivable_prepayment
        /// </summary>
        [EnumMember(Value = "accounts_receivable_prepayment")]
        ReceivablePrepayment = 7,

        /// <summary>
        /// Enum PayablePrepayment for value: accounts_payable_prepayment
        /// </summary>
        [EnumMember(Value = "accounts_payable_prepayment")]
        PayablePrepayment = 8

    }

}
