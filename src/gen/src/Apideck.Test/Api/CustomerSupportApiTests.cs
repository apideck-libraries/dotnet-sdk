/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.36.0
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
    ///  Class for testing CustomerSupportApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CustomerSupportApiTests : IDisposable
    {
        private CustomerSupportApi instance;

        public CustomerSupportApiTests()
        {
            instance = new CustomerSupportApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomerSupportApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CustomerSupportApi
            //Assert.IsType<CustomerSupportApi>(instance);
        }

        /// <summary>
        /// Test CustomersAdd
        /// </summary>
        [Fact]
        public void CustomersAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomerSupportCustomer customerSupportCustomer = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CustomersAdd(customerSupportCustomer, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateCustomerSupportCustomerResponse>(response);
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
            //var response = instance.CustomersAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetCustomerSupportCustomersResponse>(response);
        }

        /// <summary>
        /// Test CustomersDelete
        /// </summary>
        [Fact]
        public void CustomersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CustomersDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteCustomerSupportCustomerResponse>(response);
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
            //var response = instance.CustomersOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetCustomerSupportCustomerResponse>(response);
        }

        /// <summary>
        /// Test CustomersUpdate
        /// </summary>
        [Fact]
        public void CustomersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CustomerSupportCustomer customerSupportCustomer = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CustomersUpdate(id, customerSupportCustomer, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateCustomerSupportCustomerResponse>(response);
        }
    }
}
