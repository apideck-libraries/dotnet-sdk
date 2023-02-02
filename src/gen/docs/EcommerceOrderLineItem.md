# Apideck.Model.EcommerceOrderLineItem
A single line item of an ecommerce order, representing a product or variant with associated options, quantity, and pricing information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**ProductId** | **string** | A unique identifier for the product associated with the line item. | [optional] 
**VariantId** | **string** | A unique identifier for the variant of the product associated with the line item, if applicable. | [optional] 
**Sku** | **string** | The SKU of the product or variant associated with the line item. | [optional] 
**Name** | **string** | The name of the product or variant associated with the line item. | 
**Description** | **string** | The description of the product or variant associated with the line item. | [optional] 
**Options** | **List&lt;Object&gt;** |  | [optional] 
**Quantity** | **decimal** | The quantity of the product or variant associated with the line item. | 
**UnitPrice** | **string** | The unit price of the product or variant associated with the line item. | [optional] 
**TaxRate** | **string** | The tax rate applied to the product or variant associated with the line item. | [optional] 
**TaxAmount** | **string** | The total tax amount applied to the product or variant associated with the line item. | [optional] 
**TotalAmount** | **string** | The total amount for the product(s) or variant associated with the line item, including taxes and discounts. | 
**Discounts** | [**List&lt;EcommerceDiscount&gt;**](EcommerceDiscount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

