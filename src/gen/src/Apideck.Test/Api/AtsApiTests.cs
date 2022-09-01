/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.44.0
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
    ///  Class for testing AtsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AtsApiTests : IDisposable
    {
        private AtsApi instance;

        public AtsApiTests()
        {
            instance = new AtsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AtsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AtsApi
            //Assert.IsType<AtsApi>(instance);
        }

        /// <summary>
        /// Test ApplicantsAdd
        /// </summary>
        [Fact]
        public void ApplicantsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Applicant applicant = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.ApplicantsAdd(applicant, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateApplicantResponse>(response);
        }

        /// <summary>
        /// Test ApplicantsAll
        /// </summary>
        [Fact]
        public void ApplicantsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //JobsFilter filter = null;
            //var response = instance.ApplicantsAll(raw, consumerId, appId, serviceId, cursor, limit, filter);
            //Assert.IsType<GetApplicantsResponse>(response);
        }

        /// <summary>
        /// Test ApplicantsOne
        /// </summary>
        [Fact]
        public void ApplicantsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ApplicantsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetApplicantResponse>(response);
        }

        /// <summary>
        /// Test JobsAll
        /// </summary>
        [Fact]
        public void JobsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.JobsAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetJobsResponse>(response);
        }

        /// <summary>
        /// Test JobsOne
        /// </summary>
        [Fact]
        public void JobsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.JobsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetJobResponse>(response);
        }
    }
}
