# Apideck.Model.EcommerceOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**OrderNumber** | **string** | Order number, if any. | [optional] 
**Currency** | **Currency** |  | [optional] 
**Discounts** | [**List&lt;EcommerceDiscount&gt;**](EcommerceDiscount.md) |  | [optional] 
**SubTotal** | **string** | Sub-total amount, normally before tax. | [optional] 
**ShippingCost** | **string** | Shipping cost, if any. | [optional] 
**TotalDiscount** | **string** | Total discount, if any. | [optional] 
**TotalTax** | **string** | Total tax, if any. | [optional] 
**TotalAmount** | **string** | Total amount due. | [optional] 
**Status** | **EcommerceOrderStatus** |  | [optional] 
**PaymentStatus** | **string** | Current payment status of the order. | [optional] 
**FulfillmentStatus** | **string** | Current fulfillment status of the order. | [optional] 
**PaymentMethod** | **string** | Payment method used for this order. | [optional] 
**Customer** | [**LinkedEcommerceCustomer**](LinkedEcommerceCustomer.md) |  | [optional] 
**BillingAddress** | [**EcommerceAddress**](EcommerceAddress.md) |  | [optional] 
**ShippingAddress** | [**EcommerceAddress**](EcommerceAddress.md) |  | [optional] 
**LineItems** | [**List&lt;EcommerceOrderLineItem&gt;**](EcommerceOrderLineItem.md) |  | [optional] 
**Note** | **string** | Note for the order. | [optional] 
**CreatedAt** | **DateTime** | The date and time when the object was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

