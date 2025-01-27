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
    ///  Class for testing WebhookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhookApiTests : IDisposable
    {
        private WebhookApi instance;

        public WebhookApiTests()
        {
            instance = new WebhookApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhookApi
            //Assert.IsType<WebhookApi>(instance);
        }

        /// <summary>
        /// Test EventLogsAll
        /// </summary>
        [Fact]
        public void EventLogsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string cursor = null;
            //int? limit = null;
            //WebhookEventLogsFilter filter = null;
            //var response = instance.EventLogsAll(appId, cursor, limit, filter);
            //Assert.IsType<GetWebhookEventLogsResponse>(response);
        }

        /// <summary>
        /// Test WebhooksAdd
        /// </summary>
        [Fact]
        public void WebhooksAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateWebhookRequest createWebhookRequest = null;
            //string appId = null;
            //var response = instance.WebhooksAdd(createWebhookRequest, appId);
            //Assert.IsType<CreateWebhookResponse>(response);
        }

        /// <summary>
        /// Test WebhooksAll
        /// </summary>
        [Fact]
        public void WebhooksAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.WebhooksAll(appId, cursor, limit);
            //Assert.IsType<GetWebhooksResponse>(response);
        }

        /// <summary>
        /// Test WebhooksDelete
        /// </summary>
        [Fact]
        public void WebhooksDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string appId = null;
            //var response = instance.WebhooksDelete(id, appId);
            //Assert.IsType<DeleteWebhookResponse>(response);
        }

        /// <summary>
        /// Test WebhooksOne
        /// </summary>
        [Fact]
        public void WebhooksOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string appId = null;
            //var response = instance.WebhooksOne(id, appId);
            //Assert.IsType<GetWebhookResponse>(response);
        }

        /// <summary>
        /// Test WebhooksUpdate
        /// </summary>
        [Fact]
        public void WebhooksUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UpdateWebhookRequest updateWebhookRequest = null;
            //string appId = null;
            //var response = instance.WebhooksUpdate(id, updateWebhookRequest, appId);
            //Assert.IsType<UpdateWebhookResponse>(response);
        }
    }
}
