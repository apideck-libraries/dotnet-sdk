/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.13.0
 * Contact: support@apideck.com
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
    ///  Class for testing CreditNote
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreditNoteTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreditNote
        //private CreditNote instance;

        public CreditNoteTests()
        {
            // TODO uncomment below to create an instance of CreditNote
            //instance = new CreditNote();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreditNote
        /// </summary>
        [Fact]
        public void CreditNoteInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreditNote
            //Assert.IsType<CreditNote>(instance);
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
        /// Test the property 'Number'
        /// </summary>
        [Fact]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'Customer'
        /// </summary>
        [Fact]
        public void CustomerTest()
        {
            // TODO unit test for the property 'Customer'
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
        /// Test the property 'TaxInclusive'
        /// </summary>
        [Fact]
        public void TaxInclusiveTest()
        {
            // TODO unit test for the property 'TaxInclusive'
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
        /// Test the property 'TotalAmount'
        /// </summary>
        [Fact]
        public void TotalAmountTest()
        {
            // TODO unit test for the property 'TotalAmount'
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
        /// Test the property 'TaxCode'
        /// </summary>
        [Fact]
        public void TaxCodeTest()
        {
            // TODO unit test for the property 'TaxCode'
        }
        /// <summary>
        /// Test the property 'Balance'
        /// </summary>
        [Fact]
        public void BalanceTest()
        {
            // TODO unit test for the property 'Balance'
        }
        /// <summary>
        /// Test the property 'RemainingCredit'
        /// </summary>
        [Fact]
        public void RemainingCreditTest()
        {
            // TODO unit test for the property 'RemainingCredit'
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
        /// Test the property 'Reference'
        /// </summary>
        [Fact]
        public void ReferenceTest()
        {
            // TODO unit test for the property 'Reference'
        }
        /// <summary>
        /// Test the property 'DateIssued'
        /// </summary>
        [Fact]
        public void DateIssuedTest()
        {
            // TODO unit test for the property 'DateIssued'
        }
        /// <summary>
        /// Test the property 'DatePaid'
        /// </summary>
        [Fact]
        public void DatePaidTest()
        {
            // TODO unit test for the property 'DatePaid'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Account'
        /// </summary>
        [Fact]
        public void AccountTest()
        {
            // TODO unit test for the property 'Account'
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
        /// Test the property 'Allocations'
        /// </summary>
        [Fact]
        public void AllocationsTest()
        {
            // TODO unit test for the property 'Allocations'
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
        /// Test the property 'Terms'
        /// </summary>
        [Fact]
        public void TermsTest()
        {
            // TODO unit test for the property 'Terms'
        }
        /// <summary>
        /// Test the property 'BillingAddress'
        /// </summary>
        [Fact]
        public void BillingAddressTest()
        {
            // TODO unit test for the property 'BillingAddress'
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
        /// Test the property 'TrackingCategories'
        /// </summary>
        [Fact]
        public void TrackingCategoriesTest()
        {
            // TODO unit test for the property 'TrackingCategories'
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
        /// Test the property 'CustomFields'
        /// </summary>
        [Fact]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
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
        /// <summary>
        /// Test the property 'PassThrough'
        /// </summary>
        [Fact]
        public void PassThroughTest()
        {
            // TODO unit test for the property 'PassThrough'
        }

    }

}
