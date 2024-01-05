/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.2.0
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
    ///  Class for testing PosApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PosApiTests : IDisposable
    {
        private PosApi instance;

        public PosApiTests()
        {
            instance = new PosApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PosApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PosApi
            //Assert.IsType<PosApi>(instance);
        }

        /// <summary>
        /// Test ItemsAdd
        /// </summary>
        [Fact]
        public void ItemsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item item = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.ItemsAdd(item, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateItemResponse>(response);
        }

        /// <summary>
        /// Test ItemsAll
        /// </summary>
        [Fact]
        public void ItemsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.ItemsAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetItemsResponse>(response);
        }

        /// <summary>
        /// Test ItemsDelete
        /// </summary>
        [Fact]
        public void ItemsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ItemsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteItemResponse>(response);
        }

        /// <summary>
        /// Test ItemsOne
        /// </summary>
        [Fact]
        public void ItemsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.ItemsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetItemResponse>(response);
        }

        /// <summary>
        /// Test ItemsUpdate
        /// </summary>
        [Fact]
        public void ItemsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item item = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ItemsUpdate(id, item, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateItemResponse>(response);
        }

        /// <summary>
        /// Test LocationsAdd
        /// </summary>
        [Fact]
        public void LocationsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Location location = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.LocationsAdd(location, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateLocationResponse>(response);
        }

        /// <summary>
        /// Test LocationsAll
        /// </summary>
        [Fact]
        public void LocationsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.LocationsAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetLocationsResponse>(response);
        }

        /// <summary>
        /// Test LocationsDelete
        /// </summary>
        [Fact]
        public void LocationsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.LocationsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteLocationResponse>(response);
        }

        /// <summary>
        /// Test LocationsOne
        /// </summary>
        [Fact]
        public void LocationsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.LocationsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetLocationResponse>(response);
        }

        /// <summary>
        /// Test LocationsUpdate
        /// </summary>
        [Fact]
        public void LocationsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Location location = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.LocationsUpdate(id, location, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateLocationResponse>(response);
        }

        /// <summary>
        /// Test MerchantsAdd
        /// </summary>
        [Fact]
        public void MerchantsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Merchant merchant = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.MerchantsAdd(merchant, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateMerchantResponse>(response);
        }

        /// <summary>
        /// Test MerchantsAll
        /// </summary>
        [Fact]
        public void MerchantsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.MerchantsAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetMerchantsResponse>(response);
        }

        /// <summary>
        /// Test MerchantsDelete
        /// </summary>
        [Fact]
        public void MerchantsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.MerchantsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteMerchantResponse>(response);
        }

        /// <summary>
        /// Test MerchantsOne
        /// </summary>
        [Fact]
        public void MerchantsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.MerchantsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetMerchantResponse>(response);
        }

        /// <summary>
        /// Test MerchantsUpdate
        /// </summary>
        [Fact]
        public void MerchantsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Merchant merchant = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.MerchantsUpdate(id, merchant, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateMerchantResponse>(response);
        }

        /// <summary>
        /// Test ModifierGroupsAdd
        /// </summary>
        [Fact]
        public void ModifierGroupsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ModifierGroup modifierGroup = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.ModifierGroupsAdd(modifierGroup, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateModifierGroupResponse>(response);
        }

        /// <summary>
        /// Test ModifierGroupsAll
        /// </summary>
        [Fact]
        public void ModifierGroupsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.ModifierGroupsAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetModifierGroupsResponse>(response);
        }

        /// <summary>
        /// Test ModifierGroupsDelete
        /// </summary>
        [Fact]
        public void ModifierGroupsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ModifierGroupsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteModifierGroupResponse>(response);
        }

        /// <summary>
        /// Test ModifierGroupsOne
        /// </summary>
        [Fact]
        public void ModifierGroupsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.ModifierGroupsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetModifierGroupResponse>(response);
        }

        /// <summary>
        /// Test ModifierGroupsUpdate
        /// </summary>
        [Fact]
        public void ModifierGroupsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ModifierGroup modifierGroup = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ModifierGroupsUpdate(id, modifierGroup, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateModifierGroupResponse>(response);
        }

        /// <summary>
        /// Test ModifiersAdd
        /// </summary>
        [Fact]
        public void ModifiersAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Modifier modifier = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.ModifiersAdd(modifier, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateModifierResponse>(response);
        }

        /// <summary>
        /// Test ModifiersAll
        /// </summary>
        [Fact]
        public void ModifiersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.ModifiersAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetModifiersResponse>(response);
        }

        /// <summary>
        /// Test ModifiersDelete
        /// </summary>
        [Fact]
        public void ModifiersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //ModifierGroupFilter filter = null;
            //var response = instance.ModifiersDelete(id, consumerId, appId, serviceId, raw, filter);
            //Assert.IsType<DeleteModifierResponse>(response);
        }

        /// <summary>
        /// Test ModifiersOne
        /// </summary>
        [Fact]
        public void ModifiersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //ModifierGroupFilter filter = null;
            //string fields = null;
            //var response = instance.ModifiersOne(id, consumerId, appId, serviceId, raw, filter, fields);
            //Assert.IsType<GetModifierResponse>(response);
        }

        /// <summary>
        /// Test ModifiersUpdate
        /// </summary>
        [Fact]
        public void ModifiersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Modifier modifier = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.ModifiersUpdate(id, modifier, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateModifierResponse>(response);
        }

        /// <summary>
        /// Test OrderTypesAdd
        /// </summary>
        [Fact]
        public void OrderTypesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderType orderType = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.OrderTypesAdd(orderType, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateOrderTypeResponse>(response);
        }

        /// <summary>
        /// Test OrderTypesAll
        /// </summary>
        [Fact]
        public void OrderTypesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.OrderTypesAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetOrderTypesResponse>(response);
        }

        /// <summary>
        /// Test OrderTypesDelete
        /// </summary>
        [Fact]
        public void OrderTypesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.OrderTypesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteOrderTypeResponse>(response);
        }

        /// <summary>
        /// Test OrderTypesOne
        /// </summary>
        [Fact]
        public void OrderTypesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.OrderTypesOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetOrderTypeResponse>(response);
        }

        /// <summary>
        /// Test OrderTypesUpdate
        /// </summary>
        [Fact]
        public void OrderTypesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //OrderType orderType = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.OrderTypesUpdate(id, orderType, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateOrderTypeResponse>(response);
        }

        /// <summary>
        /// Test OrdersAdd
        /// </summary>
        [Fact]
        public void OrdersAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Order order = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.OrdersAdd(order, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateOrderResponse>(response);
        }

        /// <summary>
        /// Test OrdersAll
        /// </summary>
        [Fact]
        public void OrdersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string locationId = null;
            //string fields = null;
            //var response = instance.OrdersAll(raw, consumerId, appId, serviceId, cursor, limit, locationId, fields);
            //Assert.IsType<GetOrdersResponse>(response);
        }

        /// <summary>
        /// Test OrdersDelete
        /// </summary>
        [Fact]
        public void OrdersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.OrdersDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteOrderResponse>(response);
        }

        /// <summary>
        /// Test OrdersOne
        /// </summary>
        [Fact]
        public void OrdersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.OrdersOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetOrderResponse>(response);
        }

        /// <summary>
        /// Test OrdersPay
        /// </summary>
        [Fact]
        public void OrdersPayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Order order = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string fields = null;
            //var response = instance.OrdersPay(id, order, raw, consumerId, appId, serviceId, fields);
            //Assert.IsType<CreateOrderResponse>(response);
        }

        /// <summary>
        /// Test OrdersUpdate
        /// </summary>
        [Fact]
        public void OrdersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Order order = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.OrdersUpdate(id, order, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateOrderResponse>(response);
        }

        /// <summary>
        /// Test PaymentsAdd
        /// </summary>
        [Fact]
        public void PaymentsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PosPayment posPayment = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.PaymentsAdd(posPayment, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreatePosPaymentResponse>(response);
        }

        /// <summary>
        /// Test PaymentsAll
        /// </summary>
        [Fact]
        public void PaymentsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.PaymentsAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetPosPaymentsResponse>(response);
        }

        /// <summary>
        /// Test PaymentsDelete
        /// </summary>
        [Fact]
        public void PaymentsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.PaymentsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeletePosPaymentResponse>(response);
        }

        /// <summary>
        /// Test PaymentsOne
        /// </summary>
        [Fact]
        public void PaymentsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.PaymentsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetPosPaymentResponse>(response);
        }

        /// <summary>
        /// Test PaymentsUpdate
        /// </summary>
        [Fact]
        public void PaymentsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PosPayment posPayment = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.PaymentsUpdate(id, posPayment, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdatePosPaymentResponse>(response);
        }

        /// <summary>
        /// Test TendersAdd
        /// </summary>
        [Fact]
        public void TendersAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Tender tender = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.TendersAdd(tender, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateTenderResponse>(response);
        }

        /// <summary>
        /// Test TendersAll
        /// </summary>
        [Fact]
        public void TendersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //string fields = null;
            //var response = instance.TendersAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
            //Assert.IsType<GetTendersResponse>(response);
        }

        /// <summary>
        /// Test TendersDelete
        /// </summary>
        [Fact]
        public void TendersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.TendersDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteTenderResponse>(response);
        }

        /// <summary>
        /// Test TendersOne
        /// </summary>
        [Fact]
        public void TendersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.TendersOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetTenderResponse>(response);
        }

        /// <summary>
        /// Test TendersUpdate
        /// </summary>
        [Fact]
        public void TendersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Tender tender = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.TendersUpdate(id, tender, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateTenderResponse>(response);
        }
    }
}
