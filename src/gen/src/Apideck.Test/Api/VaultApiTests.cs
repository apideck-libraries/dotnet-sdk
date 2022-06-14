/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.32.1
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
    ///  Class for testing VaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VaultApiTests : IDisposable
    {
        private VaultApi instance;

        public VaultApiTests()
        {
            instance = new VaultApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' VaultApi
            //Assert.IsType<VaultApi>(instance);
        }

        /// <summary>
        /// Test ConnectionsAll
        /// </summary>
        [Fact]
        public void ConnectionsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consumerId = null;
            //string appId = null;
            //string api = null;
            //bool? configured = null;
            //var response = instance.ConnectionsAll(consumerId, appId, api, configured);
            //Assert.IsType<GetConnectionsResponse>(response);
        }

        /// <summary>
        /// Test ConnectionsDelete
        /// </summary>
        [Fact]
        public void ConnectionsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serviceId = null;
            //string unifiedApi = null;
            //string consumerId = null;
            //string appId = null;
            //instance.ConnectionsDelete(serviceId, unifiedApi, consumerId, appId);
        }

        /// <summary>
        /// Test ConnectionsGetSettings
        /// </summary>
        [Fact]
        public void ConnectionsGetSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string unifiedApi = null;
            //string serviceId = null;
            //string resource = null;
            //string consumerId = null;
            //string appId = null;
            //var response = instance.ConnectionsGetSettings(unifiedApi, serviceId, resource, consumerId, appId);
            //Assert.IsType<GetConnectionResponse>(response);
        }

        /// <summary>
        /// Test ConnectionsImport
        /// </summary>
        [Fact]
        public void ConnectionsImportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serviceId = null;
            //string unifiedApi = null;
            //ConnectionImportData connectionImportData = null;
            //string consumerId = null;
            //string appId = null;
            //var response = instance.ConnectionsImport(serviceId, unifiedApi, connectionImportData, consumerId, appId);
            //Assert.IsType<CreateConnectionResponse>(response);
        }

        /// <summary>
        /// Test ConnectionsOne
        /// </summary>
        [Fact]
        public void ConnectionsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serviceId = null;
            //string unifiedApi = null;
            //string consumerId = null;
            //string appId = null;
            //var response = instance.ConnectionsOne(serviceId, unifiedApi, consumerId, appId);
            //Assert.IsType<GetConnectionResponse>(response);
        }

        /// <summary>
        /// Test ConnectionsUpdate
        /// </summary>
        [Fact]
        public void ConnectionsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serviceId = null;
            //string unifiedApi = null;
            //Connection connection = null;
            //string consumerId = null;
            //string appId = null;
            //var response = instance.ConnectionsUpdate(serviceId, unifiedApi, connection, consumerId, appId);
            //Assert.IsType<UpdateConnectionResponse>(response);
        }

        /// <summary>
        /// Test ConnectionsUpdateSettings
        /// </summary>
        [Fact]
        public void ConnectionsUpdateSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serviceId = null;
            //string unifiedApi = null;
            //string resource = null;
            //Connection connection = null;
            //string consumerId = null;
            //string appId = null;
            //var response = instance.ConnectionsUpdateSettings(serviceId, unifiedApi, resource, connection, consumerId, appId);
            //Assert.IsType<UpdateConnectionResponse>(response);
        }

        /// <summary>
        /// Test ConsumersAll
        /// </summary>
        [Fact]
        public void ConsumersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.ConsumersAll(appId, cursor, limit);
            //Assert.IsType<GetConsumersResponse>(response);
        }

        /// <summary>
        /// Test ConsumersOne
        /// </summary>
        [Fact]
        public void ConsumersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consumerId = null;
            //string appId = null;
            //var response = instance.ConsumersOne(consumerId, appId);
            //Assert.IsType<GetConsumerResponse>(response);
        }

        /// <summary>
        /// Test ConsumersRequestCounts
        /// </summary>
        [Fact]
        public void ConsumersRequestCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consumerId = null;
            //string startDatetime = null;
            //string endDatetime = null;
            //string appId = null;
            //var response = instance.ConsumersRequestCounts(consumerId, startDatetime, endDatetime, appId);
            //Assert.IsType<ConsumerRequestCountsInDateRangeResponse>(response);
        }

        /// <summary>
        /// Test LogsAll
        /// </summary>
        [Fact]
        public void LogsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string consumerId = null;
            //LogsFilter filter = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.LogsAll(appId, consumerId, filter, cursor, limit);
            //Assert.IsType<GetLogsResponse>(response);
        }

        /// <summary>
        /// Test SessionsCreate
        /// </summary>
        [Fact]
        public void SessionsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consumerId = null;
            //string appId = null;
            //Session session = null;
            //var response = instance.SessionsCreate(consumerId, appId, session);
            //Assert.IsType<CreateSessionResponse>(response);
        }
    }
}
