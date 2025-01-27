/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.0
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
    /// Defines EcommerceEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EcommerceEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum EcommerceOrderCreated for value: ecommerce.order.created
        /// </summary>
        [EnumMember(Value = "ecommerce.order.created")]
        EcommerceOrderCreated = 2,

        /// <summary>
        /// Enum EcommerceOrderUpdated for value: ecommerce.order.updated
        /// </summary>
        [EnumMember(Value = "ecommerce.order.updated")]
        EcommerceOrderUpdated = 3,

        /// <summary>
        /// Enum EcommerceOrderDeleted for value: ecommerce.order.deleted
        /// </summary>
        [EnumMember(Value = "ecommerce.order.deleted")]
        EcommerceOrderDeleted = 4,

        /// <summary>
        /// Enum EcommerceProductCreated for value: ecommerce.product.created
        /// </summary>
        [EnumMember(Value = "ecommerce.product.created")]
        EcommerceProductCreated = 5,

        /// <summary>
        /// Enum EcommerceProductUpdated for value: ecommerce.product.updated
        /// </summary>
        [EnumMember(Value = "ecommerce.product.updated")]
        EcommerceProductUpdated = 6,

        /// <summary>
        /// Enum EcommerceProductDeleted for value: ecommerce.product.deleted
        /// </summary>
        [EnumMember(Value = "ecommerce.product.deleted")]
        EcommerceProductDeleted = 7,

        /// <summary>
        /// Enum EcommerceCustomerCreated for value: ecommerce.customer.created
        /// </summary>
        [EnumMember(Value = "ecommerce.customer.created")]
        EcommerceCustomerCreated = 8,

        /// <summary>
        /// Enum EcommerceCustomerUpdated for value: ecommerce.customer.updated
        /// </summary>
        [EnumMember(Value = "ecommerce.customer.updated")]
        EcommerceCustomerUpdated = 9,

        /// <summary>
        /// Enum EcommerceCustomerDeleted for value: ecommerce.customer.deleted
        /// </summary>
        [EnumMember(Value = "ecommerce.customer.deleted")]
        EcommerceCustomerDeleted = 10

    }

}
