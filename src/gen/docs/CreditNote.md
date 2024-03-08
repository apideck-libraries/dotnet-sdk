# Apideck.Model.CreditNote

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier representing the entity | [readonly] 
**Number** | **string** | Credit note number. | [optional] 
**Customer** | [**LinkedCustomer**](LinkedCustomer.md) |  | [optional] 
**CompanyId** | **string** | The company or subsidiary id the transaction belongs to | [optional] 
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
**Terms** | **string** | Optional terms to be associated with the credit note. | [optional] 
**BillingAddress** | [**Address**](Address.md) |  | [optional] 
**ShippingAddress** | [**Address**](Address.md) |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

