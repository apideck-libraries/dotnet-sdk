/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Apideck.Api;
using Apideck.Model;
using Apideck.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Apideck.Test.Model
{
    /// <summary>
    ///  Class for testing Order
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OrderTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Order
        //private Order instance;

        public OrderTests()
        {
            // TODO uncomment below to create an instance of Order
            //instance = new Order();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Order
        /// </summary>
        [Fact]
        public void OrderInstanceTest()
        {
            // TODO uncomment below to test "IsType" Order
            //Assert.IsType<Order>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'IdempotencyKey'
        /// </summary>
        [Fact]
        public void IdempotencyKeyTest()
        {
            // TODO unit test for the property 'IdempotencyKey'
        }
        /// <summary>
        /// Test the property 'OrderNumber'
        /// </summary>
        [Fact]
        public void OrderNumberTest()
        {
            // TODO unit test for the property 'OrderNumber'
        }
        /// <summary>
        /// Test the property 'OrderDate'
        /// </summary>
        [Fact]
        public void OrderDateTest()
        {
            // TODO unit test for the property 'OrderDate'
        }
        /// <summary>
        /// Test the property 'ClosedDate'
        /// </summary>
        [Fact]
        public void ClosedDateTest()
        {
            // TODO unit test for the property 'ClosedDate'
        }
        /// <summary>
        /// Test the property 'ReferenceId'
        /// </summary>
        [Fact]
        public void ReferenceIdTest()
        {
            // TODO unit test for the property 'ReferenceId'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'PaymentStatus'
        /// </summary>
        [Fact]
        public void PaymentStatusTest()
        {
            // TODO unit test for the property 'PaymentStatus'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Note'
        /// </summary>
        [Fact]
        public void NoteTest()
        {
            // TODO unit test for the property 'Note'
        }
        /// <summary>
        /// Test the property 'MerchantId'
        /// </summary>
        [Fact]
        public void MerchantIdTest()
        {
            // TODO unit test for the property 'MerchantId'
        }
        /// <summary>
        /// Test the property 'CustomerId'
        /// </summary>
        [Fact]
        public void CustomerIdTest()
        {
            // TODO unit test for the property 'CustomerId'
        }
        /// <summary>
        /// Test the property 'EmployeeId'
        /// </summary>
        [Fact]
        public void EmployeeIdTest()
        {
            // TODO unit test for the property 'EmployeeId'
        }
        /// <summary>
        /// Test the property 'LocationId'
        /// </summary>
        [Fact]
        public void LocationIdTest()
        {
            // TODO unit test for the property 'LocationId'
        }
        /// <summary>
        /// Test the property 'OrderTypeId'
        /// </summary>
        [Fact]
        public void OrderTypeIdTest()
        {
            // TODO unit test for the property 'OrderTypeId'
        }
        /// <summary>
        /// Test the property 'Table'
        /// </summary>
        [Fact]
        public void TableTest()
        {
            // TODO unit test for the property 'Table'
        }
        /// <summary>
        /// Test the property 'Seat'
        /// </summary>
        [Fact]
        public void SeatTest()
        {
            // TODO unit test for the property 'Seat'
        }
        /// <summary>
        /// Test the property 'TotalAmount'
        /// </summary>
        [Fact]
        public void TotalAmountTest()
        {
            // TODO unit test for the property 'TotalAmount'
        }
        /// <summary>
        /// Test the property 'TotalTip'
        /// </summary>
        [Fact]
        public void TotalTipTest()
        {
            // TODO unit test for the property 'TotalTip'
        }
        /// <summary>
        /// Test the property 'TotalTax'
        /// </summary>
        [Fact]
        public void TotalTaxTest()
        {
            // TODO unit test for the property 'TotalTax'
        }
        /// <summary>
        /// Test the property 'TotalDiscount'
        /// </summary>
        [Fact]
        public void TotalDiscountTest()
        {
            // TODO unit test for the property 'TotalDiscount'
        }
        /// <summary>
        /// Test the property 'TotalRefund'
        /// </summary>
        [Fact]
        public void TotalRefundTest()
        {
            // TODO unit test for the property 'TotalRefund'
        }
        /// <summary>
        /// Test the property 'TotalServiceCharge'
        /// </summary>
        [Fact]
        public void TotalServiceChargeTest()
        {
            // TODO unit test for the property 'TotalServiceCharge'
        }
        /// <summary>
        /// Test the property 'Refunded'
        /// </summary>
        [Fact]
        public void RefundedTest()
        {
            // TODO unit test for the property 'Refunded'
        }
        /// <summary>
        /// Test the property 'Customers'
        /// </summary>
        [Fact]
        public void CustomersTest()
        {
            // TODO unit test for the property 'Customers'
        }
        /// <summary>
        /// Test the property 'Fulfillments'
        /// </summary>
        [Fact]
        public void FulfillmentsTest()
        {
            // TODO unit test for the property 'Fulfillments'
        }
        /// <summary>
        /// Test the property 'LineItems'
        /// </summary>
        [Fact]
        public void LineItemsTest()
        {
            // TODO unit test for the property 'LineItems'
        }
        /// <summary>
        /// Test the property 'Payments'
        /// </summary>
        [Fact]
        public void PaymentsTest()
        {
            // TODO unit test for the property 'Payments'
        }
        /// <summary>
        /// Test the property 'ServiceCharges'
        /// </summary>
        [Fact]
        public void ServiceChargesTest()
        {
            // TODO unit test for the property 'ServiceCharges'
        }
        /// <summary>
        /// Test the property 'Refunds'
        /// </summary>
        [Fact]
        public void RefundsTest()
        {
            // TODO unit test for the property 'Refunds'
        }
        /// <summary>
        /// Test the property 'Taxes'
        /// </summary>
        [Fact]
        public void TaxesTest()
        {
            // TODO unit test for the property 'Taxes'
        }
        /// <summary>
        /// Test the property 'Discounts'
        /// </summary>
        [Fact]
        public void DiscountsTest()
        {
            // TODO unit test for the property 'Discounts'
        }
        /// <summary>
        /// Test the property 'Tenders'
        /// </summary>
        [Fact]
        public void TendersTest()
        {
            // TODO unit test for the property 'Tenders'
        }
        /// <summary>
        /// Test the property 'Source'
        /// </summary>
        [Fact]
        public void SourceTest()
        {
            // TODO unit test for the property 'Source'
        }
        /// <summary>
        /// Test the property 'Voided'
        /// </summary>
        [Fact]
        public void VoidedTest()
        {
            // TODO unit test for the property 'Voided'
        }
        /// <summary>
        /// Test the property 'VoidedAt'
        /// </summary>
        [Fact]
        public void VoidedAtTest()
        {
            // TODO unit test for the property 'VoidedAt'
        }
        /// <summary>
        /// Test the property 'CustomMappings'
        /// </summary>
        [Fact]
        public void CustomMappingsTest()
        {
            // TODO unit test for the property 'CustomMappings'
        }
        /// <summary>
        /// Test the property '_Version'
        /// </summary>
        [Fact]
        public void _VersionTest()
        {
            // TODO unit test for the property '_Version'
        }
        /// <summary>
        /// Test the property 'UpdatedBy'
        /// </summary>
        [Fact]
        public void UpdatedByTest()
        {
            // TODO unit test for the property 'UpdatedBy'
        }
        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }

    }

}
