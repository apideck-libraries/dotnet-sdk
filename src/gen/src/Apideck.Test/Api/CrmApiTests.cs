/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.49.0
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
    ///  Class for testing CrmApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CrmApiTests : IDisposable
    {
        private CrmApi instance;

        public CrmApiTests()
        {
            instance = new CrmApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CrmApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CrmApi
            //Assert.IsType<CrmApi>(instance);
        }

        /// <summary>
        /// Test ActivitiesAdd
        /// </summary>
        [Fact]
        public void ActivitiesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Activity activity = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.ActivitiesAdd(activity, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateActivityResponse>(response);
        }

        /// <summary>
        /// Test ActivitiesAll
        /// </summary>
        [Fact]
        public void ActivitiesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.ActivitiesAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetActivitiesResponse>(response);
        }

        /// <summary>
        /// Test ActivitiesDelete
        /// </summary>
        [Fact]
        public void ActivitiesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ActivitiesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteActivityResponse>(response);
        }

        /// <summary>
        /// Test ActivitiesOne
        /// </summary>
        [Fact]
        public void ActivitiesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ActivitiesOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetActivityResponse>(response);
        }

        /// <summary>
        /// Test ActivitiesUpdate
        /// </summary>
        [Fact]
        public void ActivitiesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Activity activity = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ActivitiesUpdate(id, activity, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateActivityResponse>(response);
        }

        /// <summary>
        /// Test CompaniesAdd
        /// </summary>
        [Fact]
        public void CompaniesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Company company = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CompaniesAdd(company, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateCompanyResponse>(response);
        }

        /// <summary>
        /// Test CompaniesAll
        /// </summary>
        [Fact]
        public void CompaniesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //CompaniesFilter filter = null;
            //CompaniesSort sort = null;
            //var response = instance.CompaniesAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort);
            //Assert.IsType<GetCompaniesResponse>(response);
        }

        /// <summary>
        /// Test CompaniesDelete
        /// </summary>
        [Fact]
        public void CompaniesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CompaniesDelete(id, raw, consumerId, appId, serviceId);
            //Assert.IsType<DeleteCompanyResponse>(response);
        }

        /// <summary>
        /// Test CompaniesOne
        /// </summary>
        [Fact]
        public void CompaniesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CompaniesOne(id, raw, consumerId, appId, serviceId);
            //Assert.IsType<GetCompanyResponse>(response);
        }

        /// <summary>
        /// Test CompaniesUpdate
        /// </summary>
        [Fact]
        public void CompaniesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Company company = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CompaniesUpdate(id, company, raw, consumerId, appId, serviceId);
            //Assert.IsType<UpdateCompanyResponse>(response);
        }

        /// <summary>
        /// Test ContactsAdd
        /// </summary>
        [Fact]
        public void ContactsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Contact contact = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.ContactsAdd(contact, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateContactResponse>(response);
        }

        /// <summary>
        /// Test ContactsAll
        /// </summary>
        [Fact]
        public void ContactsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //ContactsFilter filter = null;
            //ContactsSort sort = null;
            //var response = instance.ContactsAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort);
            //Assert.IsType<GetContactsResponse>(response);
        }

        /// <summary>
        /// Test ContactsDelete
        /// </summary>
        [Fact]
        public void ContactsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ContactsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteContactResponse>(response);
        }

        /// <summary>
        /// Test ContactsOne
        /// </summary>
        [Fact]
        public void ContactsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ContactsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetContactResponse>(response);
        }

        /// <summary>
        /// Test ContactsUpdate
        /// </summary>
        [Fact]
        public void ContactsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Contact contact = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ContactsUpdate(id, contact, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateContactResponse>(response);
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

        /// <summary>
        /// Test NotesAdd
        /// </summary>
        [Fact]
        public void NotesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Note note = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.NotesAdd(note, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateNoteResponse>(response);
        }

        /// <summary>
        /// Test NotesAll
        /// </summary>
        [Fact]
        public void NotesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.NotesAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetNotesResponse>(response);
        }

        /// <summary>
        /// Test NotesDelete
        /// </summary>
        [Fact]
        public void NotesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.NotesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteNoteResponse>(response);
        }

        /// <summary>
        /// Test NotesOne
        /// </summary>
        [Fact]
        public void NotesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.NotesOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetNoteResponse>(response);
        }

        /// <summary>
        /// Test NotesUpdate
        /// </summary>
        [Fact]
        public void NotesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Note note = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.NotesUpdate(id, note, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateNoteResponse>(response);
        }

        /// <summary>
        /// Test OpportunitiesAdd
        /// </summary>
        [Fact]
        public void OpportunitiesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Opportunity opportunity = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.OpportunitiesAdd(opportunity, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateOpportunityResponse>(response);
        }

        /// <summary>
        /// Test OpportunitiesAll
        /// </summary>
        [Fact]
        public void OpportunitiesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //OpportunitiesFilter filter = null;
            //OpportunitiesSort sort = null;
            //var response = instance.OpportunitiesAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort);
            //Assert.IsType<GetOpportunitiesResponse>(response);
        }

        /// <summary>
        /// Test OpportunitiesDelete
        /// </summary>
        [Fact]
        public void OpportunitiesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.OpportunitiesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteOpportunityResponse>(response);
        }

        /// <summary>
        /// Test OpportunitiesOne
        /// </summary>
        [Fact]
        public void OpportunitiesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.OpportunitiesOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetOpportunityResponse>(response);
        }

        /// <summary>
        /// Test OpportunitiesUpdate
        /// </summary>
        [Fact]
        public void OpportunitiesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Opportunity opportunity = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.OpportunitiesUpdate(id, opportunity, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateOpportunityResponse>(response);
        }

        /// <summary>
        /// Test PipelinesAdd
        /// </summary>
        [Fact]
        public void PipelinesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Pipeline pipeline = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.PipelinesAdd(pipeline, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreatePipelineResponse>(response);
        }

        /// <summary>
        /// Test PipelinesAll
        /// </summary>
        [Fact]
        public void PipelinesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.PipelinesAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetPipelinesResponse>(response);
        }

        /// <summary>
        /// Test PipelinesDelete
        /// </summary>
        [Fact]
        public void PipelinesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.PipelinesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeletePipelineResponse>(response);
        }

        /// <summary>
        /// Test PipelinesOne
        /// </summary>
        [Fact]
        public void PipelinesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.PipelinesOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetPipelineResponse>(response);
        }

        /// <summary>
        /// Test PipelinesUpdate
        /// </summary>
        [Fact]
        public void PipelinesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Pipeline pipeline = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.PipelinesUpdate(id, pipeline, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdatePipelineResponse>(response);
        }

        /// <summary>
        /// Test UsersAdd
        /// </summary>
        [Fact]
        public void UsersAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //User user = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.UsersAdd(user, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateUserResponse>(response);
        }

        /// <summary>
        /// Test UsersAll
        /// </summary>
        [Fact]
        public void UsersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.UsersAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetUsersResponse>(response);
        }

        /// <summary>
        /// Test UsersDelete
        /// </summary>
        [Fact]
        public void UsersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.UsersDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteUserResponse>(response);
        }

        /// <summary>
        /// Test UsersOne
        /// </summary>
        [Fact]
        public void UsersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.UsersOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetUserResponse>(response);
        }

        /// <summary>
        /// Test UsersUpdate
        /// </summary>
        [Fact]
        public void UsersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //User user = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.UsersUpdate(id, user, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateUserResponse>(response);
        }
    }
}
