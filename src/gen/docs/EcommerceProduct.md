# Apideck.Model.EcommerceProduct

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**Name** | **string** | The name of the product as it should be displayed to customers. | [optional] 
**Description** | **string** | A detailed description of the product. | [optional] 
**Status** | **string** | The current status of the product (active or archived). | [optional] 
**Price** | **string** | The price of the product. | [optional] 
**Sku** | **string** | The stock keeping unit of the product. | [optional] 
**InventoryQuantity** | **string** | The quantity of the product in stock. | [optional] 
**Images** | [**List&lt;EcommerceProductImages&gt;**](EcommerceProductImages.md) | An array of image URLs for the product. | [optional] 
**Weight** | **string** | The weight of the product. | [optional] 
**WeightUnit** | **string** | The unit of measurement for the weight of the product. | [optional] 
**Options** | [**List&lt;EcommerceProductOptions&gt;**](EcommerceProductOptions.md) | An array of options for the product. | [optional] 
**Variants** | [**List&lt;EcommerceProductVariants&gt;**](EcommerceProductVariants.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | An array of tags for the product, used for organization and searching. | [optional] 
**Categories** | [**List&lt;EcommerceProductCategories&gt;**](EcommerceProductCategories.md) | An array of categories for the product, used for organization and searching. | [optional] 
**CreatedAt** | **DateTime** | The date and time when the object was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

