/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.0.1
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
    ///  Class for testing SmsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SmsApiTests : IDisposable
    {
        private SmsApi instance;

        public SmsApiTests()
        {
            instance = new SmsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SmsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SmsApi
            //Assert.IsType<SmsApi>(instance);
        }

        /// <summary>
        /// Test MessagesAdd
        /// </summary>
        [Fact]
        public void MessagesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Message message = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.MessagesAdd(message, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateMessageResponse>(response);
        }

        /// <summary>
        /// Test MessagesAll
        /// </summary>
        [Fact]
        public void MessagesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.MessagesAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetMessagesResponse>(response);
        }

        /// <summary>
        /// Test MessagesDelete
        /// </summary>
        [Fact]
        public void MessagesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.MessagesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteMessageResponse>(response);
        }

        /// <summary>
        /// Test MessagesOne
        /// </summary>
        [Fact]
        public void MessagesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.MessagesOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetMessageResponse>(response);
        }

        /// <summary>
        /// Test MessagesUpdate
        /// </summary>
        [Fact]
        public void MessagesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Message message = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.MessagesUpdate(id, message, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateMessageResponse>(response);
        }
    }
}
