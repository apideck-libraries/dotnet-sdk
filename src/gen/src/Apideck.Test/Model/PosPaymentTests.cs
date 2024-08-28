/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.7.1
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
    ///  Class for testing PosPayment
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PosPaymentTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PosPayment
        //private PosPayment instance;

        public PosPaymentTests()
        {
            // TODO uncomment below to create an instance of PosPayment
            //instance = new PosPayment();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PosPayment
        /// </summary>
        [Fact]
        public void PosPaymentInstanceTest()
        {
            // TODO uncomment below to test "IsType" PosPayment
            //Assert.IsType<PosPayment>(instance);
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
        /// Test the property 'SourceId'
        /// </summary>
        [Fact]
        public void SourceIdTest()
        {
            // TODO unit test for the property 'SourceId'
        }
        /// <summary>
        /// Test the property 'OrderId'
        /// </summary>
        [Fact]
        public void OrderIdTest()
        {
            // TODO unit test for the property 'OrderId'
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
        /// Test the property 'DeviceId'
        /// </summary>
        [Fact]
        public void DeviceIdTest()
        {
            // TODO unit test for the property 'DeviceId'
        }
        /// <summary>
        /// Test the property 'TenderId'
        /// </summary>
        [Fact]
        public void TenderIdTest()
        {
            // TODO unit test for the property 'TenderId'
        }
        /// <summary>
        /// Test the property 'ExternalPaymentId'
        /// </summary>
        [Fact]
        public void ExternalPaymentIdTest()
        {
            // TODO unit test for the property 'ExternalPaymentId'
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
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
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
        /// Test the property 'Tip'
        /// </summary>
        [Fact]
        public void TipTest()
        {
            // TODO unit test for the property 'Tip'
        }
        /// <summary>
        /// Test the property 'Tax'
        /// </summary>
        [Fact]
        public void TaxTest()
        {
            // TODO unit test for the property 'Tax'
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
        /// Test the property 'AppFee'
        /// </summary>
        [Fact]
        public void AppFeeTest()
        {
            // TODO unit test for the property 'AppFee'
        }
        /// <summary>
        /// Test the property 'ChangeBackCashAmount'
        /// </summary>
        [Fact]
        public void ChangeBackCashAmountTest()
        {
            // TODO unit test for the property 'ChangeBackCashAmount'
        }
        /// <summary>
        /// Test the property 'Approved'
        /// </summary>
        [Fact]
        public void ApprovedTest()
        {
            // TODO unit test for the property 'Approved'
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
        /// Test the property 'ProcessingFees'
        /// </summary>
        [Fact]
        public void ProcessingFeesTest()
        {
            // TODO unit test for the property 'ProcessingFees'
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
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Cash'
        /// </summary>
        [Fact]
        public void CashTest()
        {
            // TODO unit test for the property 'Cash'
        }
        /// <summary>
        /// Test the property 'CardDetails'
        /// </summary>
        [Fact]
        public void CardDetailsTest()
        {
            // TODO unit test for the property 'CardDetails'
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
        /// Test the property 'Wallet'
        /// </summary>
        [Fact]
        public void WalletTest()
        {
            // TODO unit test for the property 'Wallet'
        }
        /// <summary>
        /// Test the property 'ExternalDetails'
        /// </summary>
        [Fact]
        public void ExternalDetailsTest()
        {
            // TODO unit test for the property 'ExternalDetails'
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
        /// Test the property 'CustomMappings'
        /// </summary>
        [Fact]
        public void CustomMappingsTest()
        {
            // TODO unit test for the property 'CustomMappings'
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
