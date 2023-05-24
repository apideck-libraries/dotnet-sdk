# Apideck.Model.PurchaseOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**PoNumber** | **string** | A PO Number uniquely identifies a purchase order and is generally defined by the buyer. | [optional] 
**Reference** | **string** | Optional purchase order reference. | [optional] 
**Supplier** | [**LinkedSupplier**](LinkedSupplier.md) |  | [optional] 
**Status** | **string** |  | [optional] 
**IssuedDate** | **DateTime?** | Date purchase order was issued - YYYY-MM-DD. | [optional] 
**DeliveryDate** | **DateTime?** | The date on which the purchase order is to be delivered - YYYY-MM-DD. | [optional] 
**ExpectedArrivalDate** | **DateTime?** | The date on which the order is expected to arrive - YYYY-MM-DD. | [optional] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**SubTotal** | **decimal?** | Sub-total amount, normally before tax. | [optional] 
**TotalTax** | **decimal?** | Total tax amount applied to this invoice. | [optional] 
**Total** | **decimal?** | Total amount of invoice, including tax. | [optional] 
**TaxInclusive** | **bool?** | Amounts are including tax | [optional] 
**LineItems** | [**List&lt;InvoiceLineItem&gt;**](InvoiceLineItem.md) |  | [optional] 
**ShippingAddress** | [**Address**](Address.md) |  | [optional] 
**LedgerAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**TemplateId** | **string** | Optional purchase order template | [optional] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

