/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 8.34.0
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
    /// Defines WebhookEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookEventType
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 1,

        /// <summary>
        /// Enum CrmActivityCreated for value: crm.activity.created
        /// </summary>
        [EnumMember(Value = "crm.activity.created")]
        CrmActivityCreated = 2,

        /// <summary>
        /// Enum CrmActivityUpdated for value: crm.activity.updated
        /// </summary>
        [EnumMember(Value = "crm.activity.updated")]
        CrmActivityUpdated = 3,

        /// <summary>
        /// Enum CrmActivityDeleted for value: crm.activity.deleted
        /// </summary>
        [EnumMember(Value = "crm.activity.deleted")]
        CrmActivityDeleted = 4,

        /// <summary>
        /// Enum CrmCompanyCreated for value: crm.company.created
        /// </summary>
        [EnumMember(Value = "crm.company.created")]
        CrmCompanyCreated = 5,

        /// <summary>
        /// Enum CrmCompanyUpdated for value: crm.company.updated
        /// </summary>
        [EnumMember(Value = "crm.company.updated")]
        CrmCompanyUpdated = 6,

        /// <summary>
        /// Enum CrmCompanyDeleted for value: crm.company.deleted
        /// </summary>
        [EnumMember(Value = "crm.company.deleted")]
        CrmCompanyDeleted = 7,

        /// <summary>
        /// Enum CrmContactCreated for value: crm.contact.created
        /// </summary>
        [EnumMember(Value = "crm.contact.created")]
        CrmContactCreated = 8,

        /// <summary>
        /// Enum CrmContactUpdated for value: crm.contact.updated
        /// </summary>
        [EnumMember(Value = "crm.contact.updated")]
        CrmContactUpdated = 9,

        /// <summary>
        /// Enum CrmContactDeleted for value: crm.contact.deleted
        /// </summary>
        [EnumMember(Value = "crm.contact.deleted")]
        CrmContactDeleted = 10,

        /// <summary>
        /// Enum CrmLeadCreated for value: crm.lead.created
        /// </summary>
        [EnumMember(Value = "crm.lead.created")]
        CrmLeadCreated = 11,

        /// <summary>
        /// Enum CrmLeadUpdated for value: crm.lead.updated
        /// </summary>
        [EnumMember(Value = "crm.lead.updated")]
        CrmLeadUpdated = 12,

        /// <summary>
        /// Enum CrmLeadDeleted for value: crm.lead.deleted
        /// </summary>
        [EnumMember(Value = "crm.lead.deleted")]
        CrmLeadDeleted = 13,

        /// <summary>
        /// Enum CrmNoteCreated for value: crm.note.created
        /// </summary>
        [EnumMember(Value = "crm.note.created")]
        CrmNoteCreated = 14,

        /// <summary>
        /// Enum CrmNotesUpdated for value: crm.notes.updated
        /// </summary>
        [EnumMember(Value = "crm.notes.updated")]
        CrmNotesUpdated = 15,

        /// <summary>
        /// Enum CrmNotesDeleted for value: crm.notes.deleted
        /// </summary>
        [EnumMember(Value = "crm.notes.deleted")]
        CrmNotesDeleted = 16,

        /// <summary>
        /// Enum CrmOpportunityCreated for value: crm.opportunity.created
        /// </summary>
        [EnumMember(Value = "crm.opportunity.created")]
        CrmOpportunityCreated = 17,

        /// <summary>
        /// Enum CrmOpportunityUpdated for value: crm.opportunity.updated
        /// </summary>
        [EnumMember(Value = "crm.opportunity.updated")]
        CrmOpportunityUpdated = 18,

        /// <summary>
        /// Enum CrmOpportunityDeleted for value: crm.opportunity.deleted
        /// </summary>
        [EnumMember(Value = "crm.opportunity.deleted")]
        CrmOpportunityDeleted = 19,

        /// <summary>
        /// Enum LeadLeadCreated for value: lead.lead.created
        /// </summary>
        [EnumMember(Value = "lead.lead.created")]
        LeadLeadCreated = 20,

        /// <summary>
        /// Enum LeadLeadUpdated for value: lead.lead.updated
        /// </summary>
        [EnumMember(Value = "lead.lead.updated")]
        LeadLeadUpdated = 21,

        /// <summary>
        /// Enum LeadLeadDeleted for value: lead.lead.deleted
        /// </summary>
        [EnumMember(Value = "lead.lead.deleted")]
        LeadLeadDeleted = 22,

        /// <summary>
        /// Enum VaultConnectionCreated for value: vault.connection.created
        /// </summary>
        [EnumMember(Value = "vault.connection.created")]
        VaultConnectionCreated = 23,

        /// <summary>
        /// Enum VaultConnectionUpdated for value: vault.connection.updated
        /// </summary>
        [EnumMember(Value = "vault.connection.updated")]
        VaultConnectionUpdated = 24,

        /// <summary>
        /// Enum VaultConnectionDeleted for value: vault.connection.deleted
        /// </summary>
        [EnumMember(Value = "vault.connection.deleted")]
        VaultConnectionDeleted = 25,

        /// <summary>
        /// Enum VaultConnectionCallable for value: vault.connection.callable
        /// </summary>
        [EnumMember(Value = "vault.connection.callable")]
        VaultConnectionCallable = 26,

        /// <summary>
        /// Enum VaultConnectionTokenRefreshFailed for value: vault.connection.token_refresh.failed
        /// </summary>
        [EnumMember(Value = "vault.connection.token_refresh.failed")]
        VaultConnectionTokenRefreshFailed = 27,

        /// <summary>
        /// Enum AtsJobCreated for value: ats.job.created
        /// </summary>
        [EnumMember(Value = "ats.job.created")]
        AtsJobCreated = 28,

        /// <summary>
        /// Enum AtsJobUpdated for value: ats.job.updated
        /// </summary>
        [EnumMember(Value = "ats.job.updated")]
        AtsJobUpdated = 29,

        /// <summary>
        /// Enum AtsJobDeleted for value: ats.job.deleted
        /// </summary>
        [EnumMember(Value = "ats.job.deleted")]
        AtsJobDeleted = 30,

        /// <summary>
        /// Enum AtsApplicantCreated for value: ats.applicant.created
        /// </summary>
        [EnumMember(Value = "ats.applicant.created")]
        AtsApplicantCreated = 31,

        /// <summary>
        /// Enum AtsApplicantUpdated for value: ats.applicant.updated
        /// </summary>
        [EnumMember(Value = "ats.applicant.updated")]
        AtsApplicantUpdated = 32,

        /// <summary>
        /// Enum AtsApplicantDeleted for value: ats.applicant.deleted
        /// </summary>
        [EnumMember(Value = "ats.applicant.deleted")]
        AtsApplicantDeleted = 33,

        /// <summary>
        /// Enum AccountingCustomerCreated for value: accounting.customer.created
        /// </summary>
        [EnumMember(Value = "accounting.customer.created")]
        AccountingCustomerCreated = 34,

        /// <summary>
        /// Enum AccountingCustomerUpdated for value: accounting.customer.updated
        /// </summary>
        [EnumMember(Value = "accounting.customer.updated")]
        AccountingCustomerUpdated = 35,

        /// <summary>
        /// Enum AccountingCustomerDeleted for value: accounting.customer.deleted
        /// </summary>
        [EnumMember(Value = "accounting.customer.deleted")]
        AccountingCustomerDeleted = 36,

        /// <summary>
        /// Enum AccountingInvoiceCreated for value: accounting.invoice.created
        /// </summary>
        [EnumMember(Value = "accounting.invoice.created")]
        AccountingInvoiceCreated = 37,

        /// <summary>
        /// Enum AccountingInvoiceUpdated for value: accounting.invoice.updated
        /// </summary>
        [EnumMember(Value = "accounting.invoice.updated")]
        AccountingInvoiceUpdated = 38,

        /// <summary>
        /// Enum AccountingInvoiceDeleted for value: accounting.invoice.deleted
        /// </summary>
        [EnumMember(Value = "accounting.invoice.deleted")]
        AccountingInvoiceDeleted = 39,

        /// <summary>
        /// Enum AccountingInvoiceItemCreated for value: accounting.invoice_item.created
        /// </summary>
        [EnumMember(Value = "accounting.invoice_item.created")]
        AccountingInvoiceItemCreated = 40,

        /// <summary>
        /// Enum AccountingInvoiceItemUpdated for value: accounting.invoice_item.updated
        /// </summary>
        [EnumMember(Value = "accounting.invoice_item.updated")]
        AccountingInvoiceItemUpdated = 41,

        /// <summary>
        /// Enum AccountingInvoiceItemDeleted for value: accounting.invoice_item.deleted
        /// </summary>
        [EnumMember(Value = "accounting.invoice_item.deleted")]
        AccountingInvoiceItemDeleted = 42,

        /// <summary>
        /// Enum AccountingLedgerAccountCreated for value: accounting.ledger_account.created
        /// </summary>
        [EnumMember(Value = "accounting.ledger_account.created")]
        AccountingLedgerAccountCreated = 43,

        /// <summary>
        /// Enum AccountingLedgerAccountUpdated for value: accounting.ledger_account.updated
        /// </summary>
        [EnumMember(Value = "accounting.ledger_account.updated")]
        AccountingLedgerAccountUpdated = 44,

        /// <summary>
        /// Enum AccountingLedgerAccountDeleted for value: accounting.ledger_account.deleted
        /// </summary>
        [EnumMember(Value = "accounting.ledger_account.deleted")]
        AccountingLedgerAccountDeleted = 45,

        /// <summary>
        /// Enum AccountingTaxRateCreated for value: accounting.tax_rate.created
        /// </summary>
        [EnumMember(Value = "accounting.tax_rate.created")]
        AccountingTaxRateCreated = 46,

        /// <summary>
        /// Enum AccountingTaxRateUpdated for value: accounting.tax_rate.updated
        /// </summary>
        [EnumMember(Value = "accounting.tax_rate.updated")]
        AccountingTaxRateUpdated = 47,

        /// <summary>
        /// Enum AccountingTaxRateDeleted for value: accounting.tax_rate.deleted
        /// </summary>
        [EnumMember(Value = "accounting.tax_rate.deleted")]
        AccountingTaxRateDeleted = 48,

        /// <summary>
        /// Enum AccountingBillCreated for value: accounting.bill.created
        /// </summary>
        [EnumMember(Value = "accounting.bill.created")]
        AccountingBillCreated = 49,

        /// <summary>
        /// Enum AccountingBillUpdated for value: accounting.bill.updated
        /// </summary>
        [EnumMember(Value = "accounting.bill.updated")]
        AccountingBillUpdated = 50,

        /// <summary>
        /// Enum AccountingBillDeleted for value: accounting.bill.deleted
        /// </summary>
        [EnumMember(Value = "accounting.bill.deleted")]
        AccountingBillDeleted = 51,

        /// <summary>
        /// Enum AccountingPaymentCreated for value: accounting.payment.created
        /// </summary>
        [EnumMember(Value = "accounting.payment.created")]
        AccountingPaymentCreated = 52,

        /// <summary>
        /// Enum AccountingPaymentUpdated for value: accounting.payment.updated
        /// </summary>
        [EnumMember(Value = "accounting.payment.updated")]
        AccountingPaymentUpdated = 53,

        /// <summary>
        /// Enum AccountingPaymentDeleted for value: accounting.payment.deleted
        /// </summary>
        [EnumMember(Value = "accounting.payment.deleted")]
        AccountingPaymentDeleted = 54,

        /// <summary>
        /// Enum AccountingSupplierCreated for value: accounting.supplier.created
        /// </summary>
        [EnumMember(Value = "accounting.supplier.created")]
        AccountingSupplierCreated = 55,

        /// <summary>
        /// Enum AccountingSupplierUpdated for value: accounting.supplier.updated
        /// </summary>
        [EnumMember(Value = "accounting.supplier.updated")]
        AccountingSupplierUpdated = 56,

        /// <summary>
        /// Enum AccountingSupplierDeleted for value: accounting.supplier.deleted
        /// </summary>
        [EnumMember(Value = "accounting.supplier.deleted")]
        AccountingSupplierDeleted = 57,

        /// <summary>
        /// Enum PosOrderCreated for value: pos.order.created
        /// </summary>
        [EnumMember(Value = "pos.order.created")]
        PosOrderCreated = 58,

        /// <summary>
        /// Enum PosOrderUpdated for value: pos.order.updated
        /// </summary>
        [EnumMember(Value = "pos.order.updated")]
        PosOrderUpdated = 59,

        /// <summary>
        /// Enum PosOrderDeleted for value: pos.order.deleted
        /// </summary>
        [EnumMember(Value = "pos.order.deleted")]
        PosOrderDeleted = 60,

        /// <summary>
        /// Enum PosProductCreated for value: pos.product.created
        /// </summary>
        [EnumMember(Value = "pos.product.created")]
        PosProductCreated = 61,

        /// <summary>
        /// Enum PosProductUpdated for value: pos.product.updated
        /// </summary>
        [EnumMember(Value = "pos.product.updated")]
        PosProductUpdated = 62,

        /// <summary>
        /// Enum PosProductDeleted for value: pos.product.deleted
        /// </summary>
        [EnumMember(Value = "pos.product.deleted")]
        PosProductDeleted = 63,

        /// <summary>
        /// Enum PosPaymentCreated for value: pos.payment.created
        /// </summary>
        [EnumMember(Value = "pos.payment.created")]
        PosPaymentCreated = 64,

        /// <summary>
        /// Enum PosPaymentUpdated for value: pos.payment.updated
        /// </summary>
        [EnumMember(Value = "pos.payment.updated")]
        PosPaymentUpdated = 65,

        /// <summary>
        /// Enum PosPaymentDeleted for value: pos.payment.deleted
        /// </summary>
        [EnumMember(Value = "pos.payment.deleted")]
        PosPaymentDeleted = 66,

        /// <summary>
        /// Enum PosMerchantCreated for value: pos.merchant.created
        /// </summary>
        [EnumMember(Value = "pos.merchant.created")]
        PosMerchantCreated = 67,

        /// <summary>
        /// Enum PosMerchantUpdated for value: pos.merchant.updated
        /// </summary>
        [EnumMember(Value = "pos.merchant.updated")]
        PosMerchantUpdated = 68,

        /// <summary>
        /// Enum PosMerchantDeleted for value: pos.merchant.deleted
        /// </summary>
        [EnumMember(Value = "pos.merchant.deleted")]
        PosMerchantDeleted = 69,

        /// <summary>
        /// Enum PosLocationCreated for value: pos.location.created
        /// </summary>
        [EnumMember(Value = "pos.location.created")]
        PosLocationCreated = 70,

        /// <summary>
        /// Enum PosLocationUpdated for value: pos.location.updated
        /// </summary>
        [EnumMember(Value = "pos.location.updated")]
        PosLocationUpdated = 71,

        /// <summary>
        /// Enum PosLocationDeleted for value: pos.location.deleted
        /// </summary>
        [EnumMember(Value = "pos.location.deleted")]
        PosLocationDeleted = 72,

        /// <summary>
        /// Enum PosItemCreated for value: pos.item.created
        /// </summary>
        [EnumMember(Value = "pos.item.created")]
        PosItemCreated = 73,

        /// <summary>
        /// Enum PosItemUpdated for value: pos.item.updated
        /// </summary>
        [EnumMember(Value = "pos.item.updated")]
        PosItemUpdated = 74,

        /// <summary>
        /// Enum PosItemDeleted for value: pos.item.deleted
        /// </summary>
        [EnumMember(Value = "pos.item.deleted")]
        PosItemDeleted = 75,

        /// <summary>
        /// Enum PosModifierCreated for value: pos.modifier.created
        /// </summary>
        [EnumMember(Value = "pos.modifier.created")]
        PosModifierCreated = 76,

        /// <summary>
        /// Enum PosModifierUpdated for value: pos.modifier.updated
        /// </summary>
        [EnumMember(Value = "pos.modifier.updated")]
        PosModifierUpdated = 77,

        /// <summary>
        /// Enum PosModifierDeleted for value: pos.modifier.deleted
        /// </summary>
        [EnumMember(Value = "pos.modifier.deleted")]
        PosModifierDeleted = 78,

        /// <summary>
        /// Enum PosModifierGroupCreated for value: pos.modifier-group.created
        /// </summary>
        [EnumMember(Value = "pos.modifier-group.created")]
        PosModifierGroupCreated = 79,

        /// <summary>
        /// Enum PosModifierGroupUpdated for value: pos.modifier-group.updated
        /// </summary>
        [EnumMember(Value = "pos.modifier-group.updated")]
        PosModifierGroupUpdated = 80,

        /// <summary>
        /// Enum PosModifierGroupDeleted for value: pos.modifier-group.deleted
        /// </summary>
        [EnumMember(Value = "pos.modifier-group.deleted")]
        PosModifierGroupDeleted = 81,

        /// <summary>
        /// Enum HrisEmployeeCreated for value: hris.employee.created
        /// </summary>
        [EnumMember(Value = "hris.employee.created")]
        HrisEmployeeCreated = 82,

        /// <summary>
        /// Enum HrisEmployeeUpdated for value: hris.employee.updated
        /// </summary>
        [EnumMember(Value = "hris.employee.updated")]
        HrisEmployeeUpdated = 83,

        /// <summary>
        /// Enum HrisEmployeeDeleted for value: hris.employee.deleted
        /// </summary>
        [EnumMember(Value = "hris.employee.deleted")]
        HrisEmployeeDeleted = 84,

        /// <summary>
        /// Enum HrisCompanyCreated for value: hris.company.created
        /// </summary>
        [EnumMember(Value = "hris.company.created")]
        HrisCompanyCreated = 85,

        /// <summary>
        /// Enum HrisCompanyUpdated for value: hris.company.updated
        /// </summary>
        [EnumMember(Value = "hris.company.updated")]
        HrisCompanyUpdated = 86,

        /// <summary>
        /// Enum HrisCompanyDeleted for value: hris.company.deleted
        /// </summary>
        [EnumMember(Value = "hris.company.deleted")]
        HrisCompanyDeleted = 87

    }

}
