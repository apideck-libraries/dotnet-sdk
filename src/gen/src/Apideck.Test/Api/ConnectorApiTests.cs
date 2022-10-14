/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.70.1
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
    ///  Class for testing ConnectorApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConnectorApiTests : IDisposable
    {
        private ConnectorApi instance;

        public ConnectorApiTests()
        {
            instance = new ConnectorApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConnectorApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConnectorApi
            //Assert.IsType<ConnectorApi>(instance);
        }

        /// <summary>
        /// Test ApiResourceCoverageOne
        /// </summary>
        [Fact]
        public void ApiResourceCoverageOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string resourceId = null;
            //string appId = null;
            //var response = instance.ApiResourceCoverageOne(id, resourceId, appId);
            //Assert.IsType<GetApiResourceCoverageResponse>(response);
        }

        /// <summary>
        /// Test ApiResourcesOne
        /// </summary>
        [Fact]
        public void ApiResourcesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string resourceId = null;
            //string appId = null;
            //var response = instance.ApiResourcesOne(id, resourceId, appId);
            //Assert.IsType<GetApiResourceResponse>(response);
        }

        /// <summary>
        /// Test ApisAll
        /// </summary>
        [Fact]
        public void ApisAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string cursor = null;
            //int? limit = null;
            //ApisFilter filter = null;
            //var response = instance.ApisAll(appId, cursor, limit, filter);
            //Assert.IsType<GetApisResponse>(response);
        }

        /// <summary>
        /// Test ApisOne
        /// </summary>
        [Fact]
        public void ApisOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string appId = null;
            //var response = instance.ApisOne(id, appId);
            //Assert.IsType<GetApiResponse>(response);
        }

        /// <summary>
        /// Test ConnectorDocsOne
        /// </summary>
        [Fact]
        public void ConnectorDocsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string docId = null;
            //string appId = null;
            //var response = instance.ConnectorDocsOne(id, docId, appId);
            //Assert.IsType<GetConnectorResponse>(response);
        }

        /// <summary>
        /// Test ConnectorResourcesOne
        /// </summary>
        [Fact]
        public void ConnectorResourcesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string resourceId = null;
            //string appId = null;
            //var response = instance.ConnectorResourcesOne(id, resourceId, appId);
            //Assert.IsType<GetConnectorResourceResponse>(response);
        }

        /// <summary>
        /// Test ConnectorsAll
        /// </summary>
        [Fact]
        public void ConnectorsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string cursor = null;
            //int? limit = null;
            //ConnectorsFilter filter = null;
            //var response = instance.ConnectorsAll(appId, cursor, limit, filter);
            //Assert.IsType<GetConnectorsResponse>(response);
        }

        /// <summary>
        /// Test ConnectorsOne
        /// </summary>
        [Fact]
        public void ConnectorsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string appId = null;
            //var response = instance.ConnectorsOne(id, appId);
            //Assert.IsType<GetConnectorResponse>(response);
        }
    }
}
