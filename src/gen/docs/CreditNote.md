# Apideck.Model.CreditNote

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier representing the entity | [optional] [readonly] 
**Number** | **string** | Credit note number. | [optional] 
**Customer** | [**LinkedCustomer**](LinkedCustomer.md) |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**TaxInclusive** | **bool?** | Amounts are including tax | [optional] 
**SubTotal** | **decimal?** | Sub-total amount, normally before tax. | [optional] 
**TotalAmount** | **decimal** | Amount of transaction | 
**TotalTax** | **decimal?** | Total tax amount applied to this invoice. | [optional] 
**TaxCode** | **string** | Applicable tax id/code override if tax is not supplied on a line item basis. | [optional] 
**Balance** | **decimal?** | The balance reflecting any payments made against the transaction. | [optional] 
**RemainingCredit** | **decimal?** | Indicates the total credit amount still available to apply towards the payment. | [optional] 
**Status** | **string** | Status of credit notes | [optional] 
**Reference** | **string** | Optional reference message ie: Debit remittance detail. | [optional] 
**DateIssued** | **DateTime** | Date credit note issued - YYYY:MM::DDThh:mm:ss.sTZD | [optional] 
**DatePaid** | **DateTime?** | Date credit note paid - YYYY:MM::DDThh:mm:ss.sTZD | [optional] 
**Type** | **string** | Type of payment | [optional] 
**Account** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**LineItems** | [**List&lt;InvoiceLineItem&gt;**](InvoiceLineItem.md) |  | [optional] 
**Allocations** | **List&lt;Object&gt;** |  | [optional] 
**Note** | **string** | Optional note to be associated with the credit note. | [optional] 
**RowVersion** | **string** |  | [optional] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime?** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

