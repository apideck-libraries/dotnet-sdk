/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Apideck.Client;
using Apideck.Api;
// uncomment below to import models
//using Apideck.Model;

namespace Apideck.Test.Api
{
    /// <summary>
    ///  Class for testing EcommerceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EcommerceApiTests : IDisposable
    {
        private EcommerceApi instance;

        public EcommerceApiTests()
        {
            instance = new EcommerceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EcommerceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EcommerceApi
            //Assert.IsType<EcommerceApi>(instance);
        }

        /// <summary>
        /// Test CustomersAll
        /// </summary>
        [Fact]
        public void CustomersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //EcommerceCustomersFilter filter = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.CustomersAll(raw, consumerId, appId, serviceId, cursor, limit, filter, passThrough, fields);
            //Assert.IsType<GetEcommerceCustomersResponse>(response);
        }

        /// <summary>
        /// Test CustomersOne
        /// </summary>
        [Fact]
        public void CustomersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.CustomersOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetEcommerceCustomerResponse>(response);
        }

        /// <summary>
        /// Test OrdersAll
        /// </summary>
        [Fact]
        public void OrdersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //EcommerceOrdersFilter filter = null;
            //OrdersSort sort = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.OrdersAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort, passThrough, fields);
            //Assert.IsType<GetEcommerceOrdersResponse>(response);
        }

        /// <summary>
        /// Test OrdersOne
        /// </summary>
        [Fact]
        public void OrdersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.OrdersOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetEcommerceOrderResponse>(response);
        }

        /// <summary>
        /// Test ProductsAll
        /// </summary>
        [Fact]
        public void ProductsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.ProductsAll(raw, consumerId, appId, serviceId, cursor, limit, passThrough, fields);
            //Assert.IsType<GetProductsResponse>(response);
        }

        /// <summary>
        /// Test ProductsOne
        /// </summary>
        [Fact]
        public void ProductsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.ProductsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetProductResponse>(response);
        }

        /// <summary>
        /// Test StoresOne
        /// </summary>
        [Fact]
        public void StoresOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.StoresOne(consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetStoreResponse>(response);
        }
    }
}
