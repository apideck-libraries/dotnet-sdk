/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.11.5
 * Contact: support@apideck.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Apideck.Client.OpenAPIDateConverter;

namespace Apideck.Model
{
    /// <summary>
    /// Defines AccountingEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountingEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum AccountingCustomerCreated for value: accounting.customer.created
        /// </summary>
        [EnumMember(Value = "accounting.customer.created")]
        AccountingCustomerCreated = 2,

        /// <summary>
        /// Enum AccountingCustomerUpdated for value: accounting.customer.updated
        /// </summary>
        [EnumMember(Value = "accounting.customer.updated")]
        AccountingCustomerUpdated = 3,

        /// <summary>
        /// Enum AccountingCustomerDeleted for value: accounting.customer.deleted
        /// </summary>
        [EnumMember(Value = "accounting.customer.deleted")]
        AccountingCustomerDeleted = 4,

        /// <summary>
        /// Enum AccountingInvoiceCreated for value: accounting.invoice.created
        /// </summary>
        [EnumMember(Value = "accounting.invoice.created")]
        AccountingInvoiceCreated = 5,

        /// <summary>
        /// Enum AccountingInvoiceUpdated for value: accounting.invoice.updated
        /// </summary>
        [EnumMember(Value = "accounting.invoice.updated")]
        AccountingInvoiceUpdated = 6,

        /// <summary>
        /// Enum AccountingInvoiceDeleted for value: accounting.invoice.deleted
        /// </summary>
        [EnumMember(Value = "accounting.invoice.deleted")]
        AccountingInvoiceDeleted = 7,

        /// <summary>
        /// Enum AccountingInvoiceItemCreated for value: accounting.invoice_item.created
        /// </summary>
        [EnumMember(Value = "accounting.invoice_item.created")]
        AccountingInvoiceItemCreated = 8,

        /// <summary>
        /// Enum AccountingInvoiceItemUpdated for value: accounting.invoice_item.updated
        /// </summary>
        [EnumMember(Value = "accounting.invoice_item.updated")]
        AccountingInvoiceItemUpdated = 9,

        /// <summary>
        /// Enum AccountingInvoiceItemDeleted for value: accounting.invoice_item.deleted
        /// </summary>
        [EnumMember(Value = "accounting.invoice_item.deleted")]
        AccountingInvoiceItemDeleted = 10,

        /// <summary>
        /// Enum AccountingLedgerAccountCreated for value: accounting.ledger_account.created
        /// </summary>
        [EnumMember(Value = "accounting.ledger_account.created")]
        AccountingLedgerAccountCreated = 11,

        /// <summary>
        /// Enum AccountingLedgerAccountUpdated for value: accounting.ledger_account.updated
        /// </summary>
        [EnumMember(Value = "accounting.ledger_account.updated")]
        AccountingLedgerAccountUpdated = 12,

        /// <summary>
        /// Enum AccountingLedgerAccountDeleted for value: accounting.ledger_account.deleted
        /// </summary>
        [EnumMember(Value = "accounting.ledger_account.deleted")]
        AccountingLedgerAccountDeleted = 13,

        /// <summary>
        /// Enum AccountingTaxRateCreated for value: accounting.tax_rate.created
        /// </summary>
        [EnumMember(Value = "accounting.tax_rate.created")]
        AccountingTaxRateCreated = 14,

        /// <summary>
        /// Enum AccountingTaxRateUpdated for value: accounting.tax_rate.updated
        /// </summary>
        [EnumMember(Value = "accounting.tax_rate.updated")]
        AccountingTaxRateUpdated = 15,

        /// <summary>
        /// Enum AccountingTaxRateDeleted for value: accounting.tax_rate.deleted
        /// </summary>
        [EnumMember(Value = "accounting.tax_rate.deleted")]
        AccountingTaxRateDeleted = 16,

        /// <summary>
        /// Enum AccountingBillCreated for value: accounting.bill.created
        /// </summary>
        [EnumMember(Value = "accounting.bill.created")]
        AccountingBillCreated = 17,

        /// <summary>
        /// Enum AccountingBillUpdated for value: accounting.bill.updated
        /// </summary>
        [EnumMember(Value = "accounting.bill.updated")]
        AccountingBillUpdated = 18,

        /// <summary>
        /// Enum AccountingBillDeleted for value: accounting.bill.deleted
        /// </summary>
        [EnumMember(Value = "accounting.bill.deleted")]
        AccountingBillDeleted = 19,

        /// <summary>
        /// Enum AccountingPaymentCreated for value: accounting.payment.created
        /// </summary>
        [EnumMember(Value = "accounting.payment.created")]
        AccountingPaymentCreated = 20,

        /// <summary>
        /// Enum AccountingPaymentUpdated for value: accounting.payment.updated
        /// </summary>
        [EnumMember(Value = "accounting.payment.updated")]
        AccountingPaymentUpdated = 21,

        /// <summary>
        /// Enum AccountingPaymentDeleted for value: accounting.payment.deleted
        /// </summary>
        [EnumMember(Value = "accounting.payment.deleted")]
        AccountingPaymentDeleted = 22,

        /// <summary>
        /// Enum AccountingSupplierCreated for value: accounting.supplier.created
        /// </summary>
        [EnumMember(Value = "accounting.supplier.created")]
        AccountingSupplierCreated = 23,

        /// <summary>
        /// Enum AccountingSupplierUpdated for value: accounting.supplier.updated
        /// </summary>
        [EnumMember(Value = "accounting.supplier.updated")]
        AccountingSupplierUpdated = 24,

        /// <summary>
        /// Enum AccountingSupplierDeleted for value: accounting.supplier.deleted
        /// </summary>
        [EnumMember(Value = "accounting.supplier.deleted")]
        AccountingSupplierDeleted = 25,

        /// <summary>
        /// Enum AccountingPurchaseOrderCreated for value: accounting.purchase_order.created
        /// </summary>
        [EnumMember(Value = "accounting.purchase_order.created")]
        AccountingPurchaseOrderCreated = 26,

        /// <summary>
        /// Enum AccountingPurchaseOrderUpdated for value: accounting.purchase_order.updated
        /// </summary>
        [EnumMember(Value = "accounting.purchase_order.updated")]
        AccountingPurchaseOrderUpdated = 27,

        /// <summary>
        /// Enum AccountingPurchaseOrderDeleted for value: accounting.purchase_order.deleted
        /// </summary>
        [EnumMember(Value = "accounting.purchase_order.deleted")]
        AccountingPurchaseOrderDeleted = 28,

        /// <summary>
        /// Enum AccountingExpenseCreated for value: accounting.expense.created
        /// </summary>
        [EnumMember(Value = "accounting.expense.created")]
        AccountingExpenseCreated = 29,

        /// <summary>
        /// Enum AccountingExpenseUpdated for value: accounting.expense.updated
        /// </summary>
        [EnumMember(Value = "accounting.expense.updated")]
        AccountingExpenseUpdated = 30,

        /// <summary>
        /// Enum AccountingExpenseDeleted for value: accounting.expense.deleted
        /// </summary>
        [EnumMember(Value = "accounting.expense.deleted")]
        AccountingExpenseDeleted = 31,

        /// <summary>
        /// Enum AccountingCreditNoteCreated for value: accounting.credit_note.created
        /// </summary>
        [EnumMember(Value = "accounting.credit_note.created")]
        AccountingCreditNoteCreated = 32,

        /// <summary>
        /// Enum AccountingCreditNoteUpdated for value: accounting.credit_note.updated
        /// </summary>
        [EnumMember(Value = "accounting.credit_note.updated")]
        AccountingCreditNoteUpdated = 33,

        /// <summary>
        /// Enum AccountingCreditNoteDeleted for value: accounting.credit_note.deleted
        /// </summary>
        [EnumMember(Value = "accounting.credit_note.deleted")]
        AccountingCreditNoteDeleted = 34

    }

}
