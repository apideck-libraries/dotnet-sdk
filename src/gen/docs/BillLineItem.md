# Apideck.Model.BillLineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**RowId** | **string** | Row ID | [optional] 
**Code** | **string** | User defined item code | [optional] 
**LineNumber** | **int?** | Line number in the invoice | [optional] 
**Description** | **string** | User defined description | [optional] 
**Type** | **string** | Bill Line Item type | [optional] 
**TaxAmount** | **decimal?** | Tax amount | [optional] 
**TotalAmount** | **decimal?** | Total amount of the line item | [optional] 
**Quantity** | **decimal?** |  | [optional] 
**UnitPrice** | **decimal?** |  | [optional] 
**UnitOfMeasure** | **string** | Description of the unit type the item is sold as, ie: kg, hour. | [optional] 
**DiscountPercentage** | **decimal?** | Discount percentage | [optional] 
**Item** | [**LinkedInvoiceItem**](LinkedInvoiceItem.md) |  | [optional] 
**LedgerAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**TaxRate** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**RowVersion** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

