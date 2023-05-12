# Apideck.Model.BillLineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
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
**DiscountPercentage** | **decimal?** | Discount percentage applied to the line item when supported downstream. | [optional] 
**DiscountAmount** | **decimal?** | Discount amount applied to the line item when supported downstream. | [optional] 
**LocationId** | **string** | Location id | [optional] 
**DepartmentId** | **string** | Department id | [optional] 
**Item** | [**LinkedInvoiceItem**](LinkedInvoiceItem.md) |  | [optional] 
**TaxRate** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**LedgerAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date and time when the object was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

