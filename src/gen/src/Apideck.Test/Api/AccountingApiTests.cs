/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.71.0
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
    ///  Class for testing AccountingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountingApiTests : IDisposable
    {
        private AccountingApi instance;

        public AccountingApiTests()
        {
            instance = new AccountingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AccountingApi
            //Assert.IsType<AccountingApi>(instance);
        }

        /// <summary>
        /// Test BalanceSheetOne
        /// </summary>
        [Fact]
        public void BalanceSheetOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //Passthrough passThrough = null;
            //BalanceSheetFilter filter = null;
            //bool? raw = null;
            //var response = instance.BalanceSheetOne(consumerId, appId, serviceId, passThrough, filter, raw);
            //Assert.IsType<GetBalanceSheetResponse>(response);
        }

        /// <summary>
        /// Test BillsAdd
        /// </summary>
        [Fact]
        public void BillsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Bill bill = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.BillsAdd(bill, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateBillResponse>(response);
        }

        /// <summary>
        /// Test BillsAll
        /// </summary>
        [Fact]
        public void BillsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.BillsAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetBillsResponse>(response);
        }

        /// <summary>
        /// Test BillsDelete
        /// </summary>
        [Fact]
        public void BillsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.BillsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteBillResponse>(response);
        }

        /// <summary>
        /// Test BillsOne
        /// </summary>
        [Fact]
        public void BillsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.BillsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetBillResponse>(response);
        }

        /// <summary>
        /// Test BillsUpdate
        /// </summary>
        [Fact]
        public void BillsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Bill bill = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.BillsUpdate(id, bill, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateBillResponse>(response);
        }

        /// <summary>
        /// Test CompanyInfoOne
        /// </summary>
        [Fact]
        public void CompanyInfoOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CompanyInfoOne(raw, consumerId, appId, serviceId);
            //Assert.IsType<GetCompanyInfoResponse>(response);
        }

        /// <summary>
        /// Test CreditNotesAdd
        /// </summary>
        [Fact]
        public void CreditNotesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreditNote creditNote = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CreditNotesAdd(creditNote, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateCreditNoteResponse>(response);
        }

        /// <summary>
        /// Test CreditNotesAll
        /// </summary>
        [Fact]
        public void CreditNotesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.CreditNotesAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetCreditNotesResponse>(response);
        }

        /// <summary>
        /// Test CreditNotesDelete
        /// </summary>
        [Fact]
        public void CreditNotesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CreditNotesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteCreditNoteResponse>(response);
        }

        /// <summary>
        /// Test CreditNotesOne
        /// </summary>
        [Fact]
        public void CreditNotesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CreditNotesOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetCreditNoteResponse>(response);
        }

        /// <summary>
        /// Test CreditNotesUpdate
        /// </summary>
        [Fact]
        public void CreditNotesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CreditNote creditNote = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CreditNotesUpdate(id, creditNote, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateCreditNoteResponse>(response);
        }

        /// <summary>
        /// Test CustomersAdd
        /// </summary>
        [Fact]
        public void CustomersAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountingCustomer accountingCustomer = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CustomersAdd(accountingCustomer, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateCustomerResponse>(response);
        }

        /// <summary>
        /// Test CustomersAll
        /// </summary>
        [Fact]
        public void CustomersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //CustomersFilter filter = null;
            //var response = instance.CustomersAll(raw, consumerId, appId, serviceId, cursor, limit, filter);
            //Assert.IsType<GetCustomersResponse>(response);
        }

        /// <summary>
        /// Test CustomersDelete
        /// </summary>
        [Fact]
        public void CustomersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CustomersDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteCustomerResponse>(response);
        }

        /// <summary>
        /// Test CustomersOne
        /// </summary>
        [Fact]
        public void CustomersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CustomersOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetCustomerResponse>(response);
        }

        /// <summary>
        /// Test CustomersUpdate
        /// </summary>
        [Fact]
        public void CustomersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AccountingCustomer accountingCustomer = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CustomersUpdate(id, accountingCustomer, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateCustomerResponse>(response);
        }

        /// <summary>
        /// Test InvoiceItemsAdd
        /// </summary>
        [Fact]
        public void InvoiceItemsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceItem invoiceItem = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.InvoiceItemsAdd(invoiceItem, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateInvoiceItemResponse>(response);
        }

        /// <summary>
        /// Test InvoiceItemsAll
        /// </summary>
        [Fact]
        public void InvoiceItemsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //InvoiceItemsFilter filter = null;
            //var response = instance.InvoiceItemsAll(raw, consumerId, appId, serviceId, cursor, limit, filter);
            //Assert.IsType<GetInvoiceItemsResponse>(response);
        }

        /// <summary>
        /// Test InvoiceItemsDelete
        /// </summary>
        [Fact]
        public void InvoiceItemsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.InvoiceItemsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteTaxRateResponse>(response);
        }

        /// <summary>
        /// Test InvoiceItemsOne
        /// </summary>
        [Fact]
        public void InvoiceItemsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.InvoiceItemsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetInvoiceItemResponse>(response);
        }

        /// <summary>
        /// Test InvoiceItemsUpdate
        /// </summary>
        [Fact]
        public void InvoiceItemsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //InvoiceItem invoiceItem = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.InvoiceItemsUpdate(id, invoiceItem, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateInvoiceItemsResponse>(response);
        }

        /// <summary>
        /// Test InvoicesAdd
        /// </summary>
        [Fact]
        public void InvoicesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Invoice invoice = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.InvoicesAdd(invoice, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateInvoiceResponse>(response);
        }

        /// <summary>
        /// Test InvoicesAll
        /// </summary>
        [Fact]
        public void InvoicesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //InvoicesSort sort = null;
            //var response = instance.InvoicesAll(raw, consumerId, appId, serviceId, cursor, limit, sort);
            //Assert.IsType<GetInvoicesResponse>(response);
        }

        /// <summary>
        /// Test InvoicesDelete
        /// </summary>
        [Fact]
        public void InvoicesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.InvoicesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteInvoiceResponse>(response);
        }

        /// <summary>
        /// Test InvoicesOne
        /// </summary>
        [Fact]
        public void InvoicesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.InvoicesOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetInvoiceResponse>(response);
        }

        /// <summary>
        /// Test InvoicesUpdate
        /// </summary>
        [Fact]
        public void InvoicesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Invoice invoice = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.InvoicesUpdate(id, invoice, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateInvoiceResponse>(response);
        }

        /// <summary>
        /// Test LedgerAccountsAdd
        /// </summary>
        [Fact]
        public void LedgerAccountsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dictionary<string, Object> requestBody = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.LedgerAccountsAdd(requestBody, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateLedgerAccountResponse>(response);
        }

        /// <summary>
        /// Test LedgerAccountsAll
        /// </summary>
        [Fact]
        public void LedgerAccountsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.LedgerAccountsAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetLedgerAccountsResponse>(response);
        }

        /// <summary>
        /// Test LedgerAccountsDelete
        /// </summary>
        [Fact]
        public void LedgerAccountsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.LedgerAccountsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteLedgerAccountResponse>(response);
        }

        /// <summary>
        /// Test LedgerAccountsOne
        /// </summary>
        [Fact]
        public void LedgerAccountsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.LedgerAccountsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetLedgerAccountResponse>(response);
        }

        /// <summary>
        /// Test LedgerAccountsUpdate
        /// </summary>
        [Fact]
        public void LedgerAccountsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Dictionary<string, Object> requestBody = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.LedgerAccountsUpdate(id, requestBody, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateLedgerAccountResponse>(response);
        }

        /// <summary>
        /// Test PaymentsAdd
        /// </summary>
        [Fact]
        public void PaymentsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Payment payment = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.PaymentsAdd(payment, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreatePaymentResponse>(response);
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
            //var response = instance.PaymentsAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetPaymentsResponse>(response);
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
            //Assert.IsType<DeletePaymentResponse>(response);
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
            //var response = instance.PaymentsOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetPaymentResponse>(response);
        }

        /// <summary>
        /// Test PaymentsUpdate
        /// </summary>
        [Fact]
        public void PaymentsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Payment payment = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.PaymentsUpdate(id, payment, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdatePaymentResponse>(response);
        }

        /// <summary>
        /// Test ProfitAndLossOne
        /// </summary>
        [Fact]
        public void ProfitAndLossOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //ProfitAndLossFilter filter = null;
            //var response = instance.ProfitAndLossOne(raw, consumerId, appId, serviceId, filter);
            //Assert.IsType<GetProfitAndLossResponse>(response);
        }

        /// <summary>
        /// Test SuppliersAdd
        /// </summary>
        [Fact]
        public void SuppliersAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Supplier supplier = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.SuppliersAdd(supplier, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateSupplierResponse>(response);
        }

        /// <summary>
        /// Test SuppliersAll
        /// </summary>
        [Fact]
        public void SuppliersAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.SuppliersAll(raw, consumerId, appId, serviceId, cursor, limit);
            //Assert.IsType<GetSuppliersResponse>(response);
        }

        /// <summary>
        /// Test SuppliersDelete
        /// </summary>
        [Fact]
        public void SuppliersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.SuppliersDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteSupplierResponse>(response);
        }

        /// <summary>
        /// Test SuppliersOne
        /// </summary>
        [Fact]
        public void SuppliersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.SuppliersOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetSupplierResponse>(response);
        }

        /// <summary>
        /// Test SuppliersUpdate
        /// </summary>
        [Fact]
        public void SuppliersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Supplier supplier = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.SuppliersUpdate(id, supplier, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateSupplierResponse>(response);
        }

        /// <summary>
        /// Test TaxRatesAdd
        /// </summary>
        [Fact]
        public void TaxRatesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaxRate taxRate = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.TaxRatesAdd(taxRate, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateTaxRateResponse>(response);
        }

        /// <summary>
        /// Test TaxRatesAll
        /// </summary>
        [Fact]
        public void TaxRatesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //TaxRatesFilter filter = null;
            //var response = instance.TaxRatesAll(raw, consumerId, appId, serviceId, cursor, limit, filter);
            //Assert.IsType<GetTaxRatesResponse>(response);
        }

        /// <summary>
        /// Test TaxRatesDelete
        /// </summary>
        [Fact]
        public void TaxRatesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.TaxRatesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteTaxRateResponse>(response);
        }

        /// <summary>
        /// Test TaxRatesOne
        /// </summary>
        [Fact]
        public void TaxRatesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.TaxRatesOne(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<GetTaxRateResponse>(response);
        }

        /// <summary>
        /// Test TaxRatesUpdate
        /// </summary>
        [Fact]
        public void TaxRatesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TaxRate taxRate = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.TaxRatesUpdate(id, taxRate, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateTaxRateResponse>(response);
        }
    }
}
