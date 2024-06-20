# Apideck.Model.InvoiceItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the item. | [optional] [readonly] 
**Name** | **string** | Item name | [optional] 
**Description** | **string** | A short description of the item | [optional] 
**Code** | **string** | User defined item code | [optional] 
**Sold** | **bool?** | Item will be available on sales transactions | [optional] 
**Purchased** | **bool?** | Item is available for purchase transactions | [optional] 
**Tracked** | **bool?** | Item is inventoried | [optional] 
**Taxable** | **bool?** | If true, transactions for this item are taxable | [optional] 
**InventoryDate** | **DateTime?** | The date of opening balance if inventory item is tracked - YYYY-MM-DD. | [optional] 
**Type** | **string** | Item type | [optional] 
**SalesDetails** | [**InvoiceItemSalesDetails**](InvoiceItemSalesDetails.md) |  | [optional] 
**PurchaseDetails** | [**InvoiceItemSalesDetails**](InvoiceItemSalesDetails.md) |  | [optional] 
**Quantity** | **decimal?** |  | [optional] 
**UnitPrice** | **decimal?** |  | [optional] 
**AssetAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**IncomeAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**ExpenseAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**TrackingCategory** | [**LinkedTrackingCategory**](LinkedTrackingCategory.md) |  | [optional] 
**Active** | **bool?** |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

