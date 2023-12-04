/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.1.0
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
    ///  Class for testing IssueTrackingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IssueTrackingApiTests : IDisposable
    {
        private IssueTrackingApi instance;

        public IssueTrackingApiTests()
        {
            instance = new IssueTrackingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IssueTrackingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IssueTrackingApi
            //Assert.IsType<IssueTrackingApi>(instance);
        }

        /// <summary>
        /// Test CollectionTagsAll
        /// </summary>
        [Fact]
        public void CollectionTagsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.CollectionTagsAll(collectionId, raw, consumerId, appId, serviceId, cursor, limit, passThrough, fields);
            //Assert.IsType<GetCollectionTagsResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketCommentsAdd
        /// </summary>
        [Fact]
        public void CollectionTicketCommentsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string ticketId = null;
            //CollectionTicketComment collectionTicketComment = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CollectionTicketCommentsAdd(collectionId, ticketId, collectionTicketComment, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateCommentResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketCommentsAll
        /// </summary>
        [Fact]
        public void CollectionTicketCommentsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string ticketId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //CommentsSort sort = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.CollectionTicketCommentsAll(collectionId, ticketId, raw, consumerId, appId, serviceId, cursor, limit, sort, passThrough, fields);
            //Assert.IsType<GetCommentsResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketCommentsDelete
        /// </summary>
        [Fact]
        public void CollectionTicketCommentsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string collectionId = null;
            //string ticketId = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CollectionTicketCommentsDelete(id, collectionId, ticketId, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteCommentResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketCommentsOne
        /// </summary>
        [Fact]
        public void CollectionTicketCommentsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string collectionId = null;
            //string ticketId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.CollectionTicketCommentsOne(id, collectionId, ticketId, raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetCommentResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketCommentsUpdate
        /// </summary>
        [Fact]
        public void CollectionTicketCommentsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string collectionId = null;
            //string ticketId = null;
            //CollectionTicketComment collectionTicketComment = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CollectionTicketCommentsUpdate(id, collectionId, ticketId, collectionTicketComment, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateCommentResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketsAdd
        /// </summary>
        [Fact]
        public void CollectionTicketsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //Ticket ticket = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CollectionTicketsAdd(collectionId, ticket, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateTicketResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketsAll
        /// </summary>
        [Fact]
        public void CollectionTicketsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //TicketsSort sort = null;
            //IssuesFilter filter = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.CollectionTicketsAll(collectionId, raw, consumerId, appId, serviceId, cursor, limit, sort, filter, passThrough, fields);
            //Assert.IsType<GetTicketsResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketsDelete
        /// </summary>
        [Fact]
        public void CollectionTicketsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticketId = null;
            //string collectionId = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CollectionTicketsDelete(ticketId, collectionId, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteTicketResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketsOne
        /// </summary>
        [Fact]
        public void CollectionTicketsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticketId = null;
            //string collectionId = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.CollectionTicketsOne(ticketId, collectionId, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetTicketResponse>(response);
        }

        /// <summary>
        /// Test CollectionTicketsUpdate
        /// </summary>
        [Fact]
        public void CollectionTicketsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticketId = null;
            //string collectionId = null;
            //Ticket ticket = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CollectionTicketsUpdate(ticketId, collectionId, ticket, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateTicketResponse>(response);
        }

        /// <summary>
        /// Test CollectionUsersAll
        /// </summary>
        [Fact]
        public void CollectionUsersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.CollectionUsersAll(collectionId, raw, consumerId, appId, serviceId, cursor, limit, passThrough, fields);
            //Assert.IsType<GetCollectionUsersResponse>(response);
        }

        /// <summary>
        /// Test CollectionUsersOne
        /// </summary>
        [Fact]
        public void CollectionUsersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.CollectionUsersOne(collectionId, id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetCollectionUserResponse>(response);
        }

        /// <summary>
        /// Test CollectionsAll
        /// </summary>
        [Fact]
        public void CollectionsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //CollectionsSort sort = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.CollectionsAll(raw, consumerId, appId, serviceId, cursor, limit, sort, passThrough, fields);
            //Assert.IsType<GetCollectionsResponse>(response);
        }

        /// <summary>
        /// Test CollectionsOne
        /// </summary>
        [Fact]
        public void CollectionsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.CollectionsOne(collectionId, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetCollectionResponse>(response);
        }
    }
}
