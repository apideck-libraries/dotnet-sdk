/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.1.1
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
    ///  Class for testing LeadApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LeadApiTests : IDisposable
    {
        private LeadApi instance;

        public LeadApiTests()
        {
            instance = new LeadApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LeadApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LeadApi
            //Assert.IsType<LeadApi>(instance);
        }

        /// <summary>
        /// Test LeadsAdd
        /// </summary>
        [Fact]
        public void LeadsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Lead lead = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.LeadsAdd(lead, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateLeadResponse>(response);
        }

        /// <summary>
        /// Test LeadsAll
        /// </summary>
        [Fact]
        public void LeadsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //LeadsFilter filter = null;
            //LeadsSort sort = null;
            //var response = instance.LeadsAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort);
            //Assert.IsType<GetLeadsResponse>(response);
        }

        /// <summary>
        /// Test LeadsDelete
        /// </summary>
        [Fact]
        public void LeadsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.LeadsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteLeadResponse>(response);
        }

        /// <summary>
        /// Test LeadsOne
        /// </summary>
        [Fact]
        public void LeadsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.LeadsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetLeadResponse>(response);
        }

        /// <summary>
        /// Test LeadsUpdate
        /// </summary>
        [Fact]
        public void LeadsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Lead lead = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.LeadsUpdate(id, lead, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateLeadResponse>(response);
        }
    }
}
