/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.12.3
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
            //ApplicantsFilter filter = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.ApplicantsAll(raw, consumerId, appId, serviceId, cursor, limit, filter, passThrough, fields);
            //Assert.IsType<GetApplicantsResponse>(response);
        }

        /// <summary>
        /// Test ApplicantsDelete
        /// </summary>
        [Fact]
        public void ApplicantsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ApplicantsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteApplicantResponse>(response);
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
            //string fields = null;
            //var response = instance.ApplicantsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetApplicantResponse>(response);
        }

        /// <summary>
        /// Test ApplicantsUpdate
        /// </summary>
        [Fact]
        public void ApplicantsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Applicant applicant = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ApplicantsUpdate(id, applicant, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateApplicantResponse>(response);
        }

        /// <summary>
        /// Test ApplicationsAdd
        /// </summary>
        [Fact]
        public void ApplicationsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Application application = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.ApplicationsAdd(application, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateApplicationResponse>(response);
        }

        /// <summary>
        /// Test ApplicationsAll
        /// </summary>
        [Fact]
        public void ApplicationsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //PassThroughQuery passThrough = null;
            //int? limit = null;
            //var response = instance.ApplicationsAll(raw, consumerId, appId, serviceId, cursor, passThrough, limit);
            //Assert.IsType<GetApplicationsResponse>(response);
        }

        /// <summary>
        /// Test ApplicationsDelete
        /// </summary>
        [Fact]
        public void ApplicationsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ApplicationsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteApplicationResponse>(response);
        }

        /// <summary>
        /// Test ApplicationsOne
        /// </summary>
        [Fact]
        public void ApplicationsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ApplicationsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetApplicationResponse>(response);
        }

        /// <summary>
        /// Test ApplicationsUpdate
        /// </summary>
        [Fact]
        public void ApplicationsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Application application = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ApplicationsUpdate(id, application, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateApplicationResponse>(response);
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
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.JobsAll(raw, consumerId, appId, serviceId, cursor, limit, passThrough, fields);
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
            //string fields = null;
            //var response = instance.JobsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetJobResponse>(response);
        }
    }
}
