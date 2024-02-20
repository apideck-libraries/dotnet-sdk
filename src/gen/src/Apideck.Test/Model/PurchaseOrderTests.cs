/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.3.1
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
    ///  Class for testing PurchaseOrder
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PurchaseOrderTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PurchaseOrder
        //private PurchaseOrder instance;

        public PurchaseOrderTests()
        {
            // TODO uncomment below to create an instance of PurchaseOrder
            //instance = new PurchaseOrder();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PurchaseOrder
        /// </summary>
        [Fact]
        public void PurchaseOrderInstanceTest()
        {
            // TODO uncomment below to test "IsType" PurchaseOrder
            //Assert.IsType<PurchaseOrder>(instance);
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
        /// Test the property 'DownstreamId'
        /// </summary>
        [Fact]
        public void DownstreamIdTest()
        {
            // TODO unit test for the property 'DownstreamId'
        }
        /// <summary>
        /// Test the property 'PoNumber'
        /// </summary>
        [Fact]
        public void PoNumberTest()
        {
            // TODO unit test for the property 'PoNumber'
        }
        /// <summary>
        /// Test the property 'Reference'
        /// </summary>
        [Fact]
        public void ReferenceTest()
        {
            // TODO unit test for the property 'Reference'
        }
        /// <summary>
        /// Test the property 'Supplier'
        /// </summary>
        [Fact]
        public void SupplierTest()
        {
            // TODO unit test for the property 'Supplier'
        }
        /// <summary>
        /// Test the property 'CompanyId'
        /// </summary>
        [Fact]
        public void CompanyIdTest()
        {
            // TODO unit test for the property 'CompanyId'
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
        /// Test the property 'IssuedDate'
        /// </summary>
        [Fact]
        public void IssuedDateTest()
        {
            // TODO unit test for the property 'IssuedDate'
        }
        /// <summary>
        /// Test the property 'DeliveryDate'
        /// </summary>
        [Fact]
        public void DeliveryDateTest()
        {
            // TODO unit test for the property 'DeliveryDate'
        }
        /// <summary>
        /// Test the property 'ExpectedArrivalDate'
        /// </summary>
        [Fact]
        public void ExpectedArrivalDateTest()
        {
            // TODO unit test for the property 'ExpectedArrivalDate'
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
        /// Test the property 'CurrencyRate'
        /// </summary>
        [Fact]
        public void CurrencyRateTest()
        {
            // TODO unit test for the property 'CurrencyRate'
        }
        /// <summary>
        /// Test the property 'SubTotal'
        /// </summary>
        [Fact]
        public void SubTotalTest()
        {
            // TODO unit test for the property 'SubTotal'
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
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'TaxInclusive'
        /// </summary>
        [Fact]
        public void TaxInclusiveTest()
        {
            // TODO unit test for the property 'TaxInclusive'
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
        /// Test the property 'ShippingAddress'
        /// </summary>
        [Fact]
        public void ShippingAddressTest()
        {
            // TODO unit test for the property 'ShippingAddress'
        }
        /// <summary>
        /// Test the property 'LedgerAccount'
        /// </summary>
        [Fact]
        public void LedgerAccountTest()
        {
            // TODO unit test for the property 'LedgerAccount'
        }
        /// <summary>
        /// Test the property 'TemplateId'
        /// </summary>
        [Fact]
        public void TemplateIdTest()
        {
            // TODO unit test for the property 'TemplateId'
        }
        /// <summary>
        /// Test the property 'DiscountPercentage'
        /// </summary>
        [Fact]
        public void DiscountPercentageTest()
        {
            // TODO unit test for the property 'DiscountPercentage'
        }
        /// <summary>
        /// Test the property 'BankAccount'
        /// </summary>
        [Fact]
        public void BankAccountTest()
        {
            // TODO unit test for the property 'BankAccount'
        }
        /// <summary>
        /// Test the property 'AccountingByRow'
        /// </summary>
        [Fact]
        public void AccountingByRowTest()
        {
            // TODO unit test for the property 'AccountingByRow'
        }
        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Fact]
        public void DueDateTest()
        {
            // TODO unit test for the property 'DueDate'
        }
        /// <summary>
        /// Test the property 'PaymentMethod'
        /// </summary>
        [Fact]
        public void PaymentMethodTest()
        {
            // TODO unit test for the property 'PaymentMethod'
        }
        /// <summary>
        /// Test the property 'TaxCode'
        /// </summary>
        [Fact]
        public void TaxCodeTest()
        {
            // TODO unit test for the property 'TaxCode'
        }
        /// <summary>
        /// Test the property 'Channel'
        /// </summary>
        [Fact]
        public void ChannelTest()
        {
            // TODO unit test for the property 'Channel'
        }
        /// <summary>
        /// Test the property 'Memo'
        /// </summary>
        [Fact]
        public void MemoTest()
        {
            // TODO unit test for the property 'Memo'
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
        /// Test the property 'RowVersion'
        /// </summary>
        [Fact]
        public void RowVersionTest()
        {
            // TODO unit test for the property 'RowVersion'
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
