/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.3.5
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
    /// ConnectionWebhook
    /// </summary>
    [DataContract(Name = "ConnectionWebhook")]
    public partial class ConnectionWebhook : IEquatable<ConnectionWebhook>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets UnifiedApi
        /// </summary>
        [DataMember(Name = "unified_api", IsRequired = true, EmitDefaultValue = false)]
        public UnifiedApiId UnifiedApi { get; set; }
        /// <summary>
        /// The status of the webhook.
        /// </summary>
        /// <value>The status of the webhook.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Enabled for value: enabled
            /// </summary>
            [EnumMember(Value = "enabled")]
            Enabled = 1,

            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 2

        }


        /// <summary>
        /// The status of the webhook.
        /// </summary>
        /// <value>The status of the webhook.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan.
        /// </summary>
        /// <value>Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisabledReasonEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum RetryLimit for value: retry_limit
            /// </summary>
            [EnumMember(Value = "retry_limit")]
            RetryLimit = 2,

            /// <summary>
            /// Enum UsageLimit for value: usage_limit
            /// </summary>
            [EnumMember(Value = "usage_limit")]
            UsageLimit = 3

        }


        /// <summary>
        /// Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan.
        /// </summary>
        /// <value>Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan.</value>
        [DataMember(Name = "disabled_reason", EmitDefaultValue = false)]
        public DisabledReasonEnum? DisabledReason { get; set; }
        /// <summary>
        /// Defines Events
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventsEnum
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
            /// Enum VaultConnectionDisabled for value: vault.connection.disabled
            /// </summary>
            [EnumMember(Value = "vault.connection.disabled")]
            VaultConnectionDisabled = 25,

            /// <summary>
            /// Enum VaultConnectionDeleted for value: vault.connection.deleted
            /// </summary>
            [EnumMember(Value = "vault.connection.deleted")]
            VaultConnectionDeleted = 26,

            /// <summary>
            /// Enum VaultConnectionCallable for value: vault.connection.callable
            /// </summary>
            [EnumMember(Value = "vault.connection.callable")]
            VaultConnectionCallable = 27,

            /// <summary>
            /// Enum VaultConnectionRevoked for value: vault.connection.revoked
            /// </summary>
            [EnumMember(Value = "vault.connection.revoked")]
            VaultConnectionRevoked = 28,

            /// <summary>
            /// Enum VaultConnectionTokenRefreshFailed for value: vault.connection.token_refresh.failed
            /// </summary>
            [EnumMember(Value = "vault.connection.token_refresh.failed")]
            VaultConnectionTokenRefreshFailed = 29,

            /// <summary>
            /// Enum AtsJobCreated for value: ats.job.created
            /// </summary>
            [EnumMember(Value = "ats.job.created")]
            AtsJobCreated = 30,

            /// <summary>
            /// Enum AtsJobUpdated for value: ats.job.updated
            /// </summary>
            [EnumMember(Value = "ats.job.updated")]
            AtsJobUpdated = 31,

            /// <summary>
            /// Enum AtsJobDeleted for value: ats.job.deleted
            /// </summary>
            [EnumMember(Value = "ats.job.deleted")]
            AtsJobDeleted = 32,

            /// <summary>
            /// Enum AtsApplicantCreated for value: ats.applicant.created
            /// </summary>
            [EnumMember(Value = "ats.applicant.created")]
            AtsApplicantCreated = 33,

            /// <summary>
            /// Enum AtsApplicantUpdated for value: ats.applicant.updated
            /// </summary>
            [EnumMember(Value = "ats.applicant.updated")]
            AtsApplicantUpdated = 34,

            /// <summary>
            /// Enum AtsApplicantDeleted for value: ats.applicant.deleted
            /// </summary>
            [EnumMember(Value = "ats.applicant.deleted")]
            AtsApplicantDeleted = 35,

            /// <summary>
            /// Enum AccountingCustomerCreated for value: accounting.customer.created
            /// </summary>
            [EnumMember(Value = "accounting.customer.created")]
            AccountingCustomerCreated = 36,

            /// <summary>
            /// Enum AccountingCustomerUpdated for value: accounting.customer.updated
            /// </summary>
            [EnumMember(Value = "accounting.customer.updated")]
            AccountingCustomerUpdated = 37,

            /// <summary>
            /// Enum AccountingCustomerDeleted for value: accounting.customer.deleted
            /// </summary>
            [EnumMember(Value = "accounting.customer.deleted")]
            AccountingCustomerDeleted = 38,

            /// <summary>
            /// Enum AccountingInvoiceCreated for value: accounting.invoice.created
            /// </summary>
            [EnumMember(Value = "accounting.invoice.created")]
            AccountingInvoiceCreated = 39,

            /// <summary>
            /// Enum AccountingInvoiceUpdated for value: accounting.invoice.updated
            /// </summary>
            [EnumMember(Value = "accounting.invoice.updated")]
            AccountingInvoiceUpdated = 40,

            /// <summary>
            /// Enum AccountingInvoiceDeleted for value: accounting.invoice.deleted
            /// </summary>
            [EnumMember(Value = "accounting.invoice.deleted")]
            AccountingInvoiceDeleted = 41,

            /// <summary>
            /// Enum AccountingInvoiceItemCreated for value: accounting.invoice_item.created
            /// </summary>
            [EnumMember(Value = "accounting.invoice_item.created")]
            AccountingInvoiceItemCreated = 42,

            /// <summary>
            /// Enum AccountingInvoiceItemUpdated for value: accounting.invoice_item.updated
            /// </summary>
            [EnumMember(Value = "accounting.invoice_item.updated")]
            AccountingInvoiceItemUpdated = 43,

            /// <summary>
            /// Enum AccountingInvoiceItemDeleted for value: accounting.invoice_item.deleted
            /// </summary>
            [EnumMember(Value = "accounting.invoice_item.deleted")]
            AccountingInvoiceItemDeleted = 44,

            /// <summary>
            /// Enum AccountingLedgerAccountCreated for value: accounting.ledger_account.created
            /// </summary>
            [EnumMember(Value = "accounting.ledger_account.created")]
            AccountingLedgerAccountCreated = 45,

            /// <summary>
            /// Enum AccountingLedgerAccountUpdated for value: accounting.ledger_account.updated
            /// </summary>
            [EnumMember(Value = "accounting.ledger_account.updated")]
            AccountingLedgerAccountUpdated = 46,

            /// <summary>
            /// Enum AccountingLedgerAccountDeleted for value: accounting.ledger_account.deleted
            /// </summary>
            [EnumMember(Value = "accounting.ledger_account.deleted")]
            AccountingLedgerAccountDeleted = 47,

            /// <summary>
            /// Enum AccountingTaxRateCreated for value: accounting.tax_rate.created
            /// </summary>
            [EnumMember(Value = "accounting.tax_rate.created")]
            AccountingTaxRateCreated = 48,

            /// <summary>
            /// Enum AccountingTaxRateUpdated for value: accounting.tax_rate.updated
            /// </summary>
            [EnumMember(Value = "accounting.tax_rate.updated")]
            AccountingTaxRateUpdated = 49,

            /// <summary>
            /// Enum AccountingTaxRateDeleted for value: accounting.tax_rate.deleted
            /// </summary>
            [EnumMember(Value = "accounting.tax_rate.deleted")]
            AccountingTaxRateDeleted = 50,

            /// <summary>
            /// Enum AccountingBillCreated for value: accounting.bill.created
            /// </summary>
            [EnumMember(Value = "accounting.bill.created")]
            AccountingBillCreated = 51,

            /// <summary>
            /// Enum AccountingBillUpdated for value: accounting.bill.updated
            /// </summary>
            [EnumMember(Value = "accounting.bill.updated")]
            AccountingBillUpdated = 52,

            /// <summary>
            /// Enum AccountingBillDeleted for value: accounting.bill.deleted
            /// </summary>
            [EnumMember(Value = "accounting.bill.deleted")]
            AccountingBillDeleted = 53,

            /// <summary>
            /// Enum AccountingPaymentCreated for value: accounting.payment.created
            /// </summary>
            [EnumMember(Value = "accounting.payment.created")]
            AccountingPaymentCreated = 54,

            /// <summary>
            /// Enum AccountingPaymentUpdated for value: accounting.payment.updated
            /// </summary>
            [EnumMember(Value = "accounting.payment.updated")]
            AccountingPaymentUpdated = 55,

            /// <summary>
            /// Enum AccountingPaymentDeleted for value: accounting.payment.deleted
            /// </summary>
            [EnumMember(Value = "accounting.payment.deleted")]
            AccountingPaymentDeleted = 56,

            /// <summary>
            /// Enum AccountingSupplierCreated for value: accounting.supplier.created
            /// </summary>
            [EnumMember(Value = "accounting.supplier.created")]
            AccountingSupplierCreated = 57,

            /// <summary>
            /// Enum AccountingSupplierUpdated for value: accounting.supplier.updated
            /// </summary>
            [EnumMember(Value = "accounting.supplier.updated")]
            AccountingSupplierUpdated = 58,

            /// <summary>
            /// Enum AccountingSupplierDeleted for value: accounting.supplier.deleted
            /// </summary>
            [EnumMember(Value = "accounting.supplier.deleted")]
            AccountingSupplierDeleted = 59,

            /// <summary>
            /// Enum AccountingPurchaseOrderCreated for value: accounting.purchase-order.created
            /// </summary>
            [EnumMember(Value = "accounting.purchase-order.created")]
            AccountingPurchaseOrderCreated = 60,

            /// <summary>
            /// Enum AccountingPurchaseOrderUpdated for value: accounting.purchase-order.updated
            /// </summary>
            [EnumMember(Value = "accounting.purchase-order.updated")]
            AccountingPurchaseOrderUpdated = 61,

            /// <summary>
            /// Enum AccountingPurchaseOrderDeleted for value: accounting.purchase-order.deleted
            /// </summary>
            [EnumMember(Value = "accounting.purchase-order.deleted")]
            AccountingPurchaseOrderDeleted = 62,

            /// <summary>
            /// Enum PosOrderCreated for value: pos.order.created
            /// </summary>
            [EnumMember(Value = "pos.order.created")]
            PosOrderCreated = 63,

            /// <summary>
            /// Enum PosOrderUpdated for value: pos.order.updated
            /// </summary>
            [EnumMember(Value = "pos.order.updated")]
            PosOrderUpdated = 64,

            /// <summary>
            /// Enum PosOrderDeleted for value: pos.order.deleted
            /// </summary>
            [EnumMember(Value = "pos.order.deleted")]
            PosOrderDeleted = 65,

            /// <summary>
            /// Enum PosProductCreated for value: pos.product.created
            /// </summary>
            [EnumMember(Value = "pos.product.created")]
            PosProductCreated = 66,

            /// <summary>
            /// Enum PosProductUpdated for value: pos.product.updated
            /// </summary>
            [EnumMember(Value = "pos.product.updated")]
            PosProductUpdated = 67,

            /// <summary>
            /// Enum PosProductDeleted for value: pos.product.deleted
            /// </summary>
            [EnumMember(Value = "pos.product.deleted")]
            PosProductDeleted = 68,

            /// <summary>
            /// Enum PosPaymentCreated for value: pos.payment.created
            /// </summary>
            [EnumMember(Value = "pos.payment.created")]
            PosPaymentCreated = 69,

            /// <summary>
            /// Enum PosPaymentUpdated for value: pos.payment.updated
            /// </summary>
            [EnumMember(Value = "pos.payment.updated")]
            PosPaymentUpdated = 70,

            /// <summary>
            /// Enum PosPaymentDeleted for value: pos.payment.deleted
            /// </summary>
            [EnumMember(Value = "pos.payment.deleted")]
            PosPaymentDeleted = 71,

            /// <summary>
            /// Enum PosMerchantCreated for value: pos.merchant.created
            /// </summary>
            [EnumMember(Value = "pos.merchant.created")]
            PosMerchantCreated = 72,

            /// <summary>
            /// Enum PosMerchantUpdated for value: pos.merchant.updated
            /// </summary>
            [EnumMember(Value = "pos.merchant.updated")]
            PosMerchantUpdated = 73,

            /// <summary>
            /// Enum PosMerchantDeleted for value: pos.merchant.deleted
            /// </summary>
            [EnumMember(Value = "pos.merchant.deleted")]
            PosMerchantDeleted = 74,

            /// <summary>
            /// Enum PosLocationCreated for value: pos.location.created
            /// </summary>
            [EnumMember(Value = "pos.location.created")]
            PosLocationCreated = 75,

            /// <summary>
            /// Enum PosLocationUpdated for value: pos.location.updated
            /// </summary>
            [EnumMember(Value = "pos.location.updated")]
            PosLocationUpdated = 76,

            /// <summary>
            /// Enum PosLocationDeleted for value: pos.location.deleted
            /// </summary>
            [EnumMember(Value = "pos.location.deleted")]
            PosLocationDeleted = 77,

            /// <summary>
            /// Enum PosItemCreated for value: pos.item.created
            /// </summary>
            [EnumMember(Value = "pos.item.created")]
            PosItemCreated = 78,

            /// <summary>
            /// Enum PosItemUpdated for value: pos.item.updated
            /// </summary>
            [EnumMember(Value = "pos.item.updated")]
            PosItemUpdated = 79,

            /// <summary>
            /// Enum PosItemDeleted for value: pos.item.deleted
            /// </summary>
            [EnumMember(Value = "pos.item.deleted")]
            PosItemDeleted = 80,

            /// <summary>
            /// Enum PosModifierCreated for value: pos.modifier.created
            /// </summary>
            [EnumMember(Value = "pos.modifier.created")]
            PosModifierCreated = 81,

            /// <summary>
            /// Enum PosModifierUpdated for value: pos.modifier.updated
            /// </summary>
            [EnumMember(Value = "pos.modifier.updated")]
            PosModifierUpdated = 82,

            /// <summary>
            /// Enum PosModifierDeleted for value: pos.modifier.deleted
            /// </summary>
            [EnumMember(Value = "pos.modifier.deleted")]
            PosModifierDeleted = 83,

            /// <summary>
            /// Enum PosModifierGroupCreated for value: pos.modifier-group.created
            /// </summary>
            [EnumMember(Value = "pos.modifier-group.created")]
            PosModifierGroupCreated = 84,

            /// <summary>
            /// Enum PosModifierGroupUpdated for value: pos.modifier-group.updated
            /// </summary>
            [EnumMember(Value = "pos.modifier-group.updated")]
            PosModifierGroupUpdated = 85,

            /// <summary>
            /// Enum PosModifierGroupDeleted for value: pos.modifier-group.deleted
            /// </summary>
            [EnumMember(Value = "pos.modifier-group.deleted")]
            PosModifierGroupDeleted = 86,

            /// <summary>
            /// Enum HrisEmployeeCreated for value: hris.employee.created
            /// </summary>
            [EnumMember(Value = "hris.employee.created")]
            HrisEmployeeCreated = 87,

            /// <summary>
            /// Enum HrisEmployeeUpdated for value: hris.employee.updated
            /// </summary>
            [EnumMember(Value = "hris.employee.updated")]
            HrisEmployeeUpdated = 88,

            /// <summary>
            /// Enum HrisEmployeeDeleted for value: hris.employee.deleted
            /// </summary>
            [EnumMember(Value = "hris.employee.deleted")]
            HrisEmployeeDeleted = 89,

            /// <summary>
            /// Enum HrisEmployeeTerminated for value: hris.employee.terminated
            /// </summary>
            [EnumMember(Value = "hris.employee.terminated")]
            HrisEmployeeTerminated = 90,

            /// <summary>
            /// Enum HrisCompanyCreated for value: hris.company.created
            /// </summary>
            [EnumMember(Value = "hris.company.created")]
            HrisCompanyCreated = 91,

            /// <summary>
            /// Enum HrisCompanyUpdated for value: hris.company.updated
            /// </summary>
            [EnumMember(Value = "hris.company.updated")]
            HrisCompanyUpdated = 92,

            /// <summary>
            /// Enum HrisCompanyDeleted for value: hris.company.deleted
            /// </summary>
            [EnumMember(Value = "hris.company.deleted")]
            HrisCompanyDeleted = 93,

            /// <summary>
            /// Enum FileStorageFileCreated for value: file-storage.file.created
            /// </summary>
            [EnumMember(Value = "file-storage.file.created")]
            FileStorageFileCreated = 94,

            /// <summary>
            /// Enum FileStorageFileUpdated for value: file-storage.file.updated
            /// </summary>
            [EnumMember(Value = "file-storage.file.updated")]
            FileStorageFileUpdated = 95,

            /// <summary>
            /// Enum FileStorageFileDeleted for value: file-storage.file.deleted
            /// </summary>
            [EnumMember(Value = "file-storage.file.deleted")]
            FileStorageFileDeleted = 96,

            /// <summary>
            /// Enum IssueTrackingTicketCreated for value: issue-tracking.ticket.created
            /// </summary>
            [EnumMember(Value = "issue-tracking.ticket.created")]
            IssueTrackingTicketCreated = 97,

            /// <summary>
            /// Enum IssueTrackingTicketUpdated for value: issue-tracking.ticket.updated
            /// </summary>
            [EnumMember(Value = "issue-tracking.ticket.updated")]
            IssueTrackingTicketUpdated = 98,

            /// <summary>
            /// Enum IssueTrackingTicketDeleted for value: issue-tracking.ticket.deleted
            /// </summary>
            [EnumMember(Value = "issue-tracking.ticket.deleted")]
            IssueTrackingTicketDeleted = 99,

            /// <summary>
            /// Enum AtsApplicationCreated for value: ats.application.created
            /// </summary>
            [EnumMember(Value = "ats.application.created")]
            AtsApplicationCreated = 100,

            /// <summary>
            /// Enum AtsApplicationUpdated for value: ats.application.updated
            /// </summary>
            [EnumMember(Value = "ats.application.updated")]
            AtsApplicationUpdated = 101,

            /// <summary>
            /// Enum AtsApplicationDeleted for value: ats.application.deleted
            /// </summary>
            [EnumMember(Value = "ats.application.deleted")]
            AtsApplicationDeleted = 102

        }



        /// <summary>
        /// The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled.
        /// </summary>
        /// <value>The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled.</value>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = false)]
        public List<EventsEnum> Events { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionWebhook" /> class.
        /// </summary>
        /// <param name="description">A description of the object..</param>
        /// <param name="unifiedApi">unifiedApi (required).</param>
        /// <param name="status">The status of the webhook. (required).</param>
        /// <param name="disabledReason">Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan..</param>
        /// <param name="deliveryUrl">The delivery url of the webhook endpoint. (required).</param>
        /// <param name="events">The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled. (required).</param>
        public ConnectionWebhook(string description = default(string), UnifiedApiId unifiedApi = default(UnifiedApiId), StatusEnum status = default(StatusEnum), DisabledReasonEnum? disabledReason = default(DisabledReasonEnum?), string deliveryUrl = default(string), List<EventsEnum> events = default(List<EventsEnum>))
        {
            this.UnifiedApi = unifiedApi;
            this.Status = status;
            // to ensure "deliveryUrl" is required (not null)
            if (deliveryUrl == null) {
                throw new ArgumentNullException("deliveryUrl is a required property for ConnectionWebhook and cannot be null");
            }
            this.DeliveryUrl = deliveryUrl;
            // to ensure "events" is required (not null)
            if (events == null) {
                throw new ArgumentNullException("events is a required property for ConnectionWebhook and cannot be null");
            }
            this.Events = events;
            this.Description = description;
            this.DisabledReason = disabledReason;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// A description of the object.
        /// </summary>
        /// <value>A description of the object.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The delivery url of the webhook endpoint.
        /// </summary>
        /// <value>The delivery url of the webhook endpoint.</value>
        [DataMember(Name = "delivery_url", IsRequired = true, EmitDefaultValue = false)]
        public string DeliveryUrl { get; set; }

        /// <summary>
        /// The Unify Base URL events from connectors will be sent to after service id is appended.
        /// </summary>
        /// <value>The Unify Base URL events from connectors will be sent to after service id is appended.</value>
        [DataMember(Name = "execute_base_url", IsRequired = true, EmitDefaultValue = false)]
        public string ExecuteBaseUrl { get; private set; }

        /// <summary>
        /// Returns false as ExecuteBaseUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExecuteBaseUrl()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectionWebhook {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnifiedApi: ").Append(UnifiedApi).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DisabledReason: ").Append(DisabledReason).Append("\n");
            sb.Append("  DeliveryUrl: ").Append(DeliveryUrl).Append("\n");
            sb.Append("  ExecuteBaseUrl: ").Append(ExecuteBaseUrl).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionWebhook);
        }

        /// <summary>
        /// Returns true if ConnectionWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionWebhook input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UnifiedApi == input.UnifiedApi ||
                    this.UnifiedApi.Equals(input.UnifiedApi)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.DisabledReason == input.DisabledReason ||
                    this.DisabledReason.Equals(input.DisabledReason)
                ) && 
                (
                    this.DeliveryUrl == input.DeliveryUrl ||
                    (this.DeliveryUrl != null &&
                    this.DeliveryUrl.Equals(input.DeliveryUrl))
                ) && 
                (
                    this.ExecuteBaseUrl == input.ExecuteBaseUrl ||
                    (this.ExecuteBaseUrl != null &&
                    this.ExecuteBaseUrl.Equals(input.ExecuteBaseUrl))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnifiedApi.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.DisabledReason.GetHashCode();
                if (this.DeliveryUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryUrl.GetHashCode();
                }
                if (this.ExecuteBaseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExecuteBaseUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Events.GetHashCode();
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // DeliveryUrl (string) pattern
            Regex regexDeliveryUrl = new Regex(@"^(https?):\/\/", RegexOptions.CultureInvariant);
            if (false == regexDeliveryUrl.Match(this.DeliveryUrl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryUrl, must match a pattern of " + regexDeliveryUrl, new [] { "DeliveryUrl" });
            }

            // ExecuteBaseUrl (string) pattern
            Regex regexExecuteBaseUrl = new Regex(@"^(https?):\/\/", RegexOptions.CultureInvariant);
            if (false == regexExecuteBaseUrl.Match(this.ExecuteBaseUrl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExecuteBaseUrl, must match a pattern of " + regexExecuteBaseUrl, new [] { "ExecuteBaseUrl" });
            }

            yield break;
        }
    }

}
