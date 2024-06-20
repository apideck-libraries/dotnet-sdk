# Apideck.Model.Item

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**IdempotencyKey** | **string** | A value you specify that uniquely identifies this request among requests you have sent. | [optional] 
**Name** | **string** |  | 
**Description** | **string** |  | [optional] 
**Abbreviation** | **string** |  | [optional] 
**ProductType** | **string** |  | [optional] 
**PriceAmount** | **decimal** |  | [optional] 
**PricingType** | **string** |  | [optional] 
**PriceCurrency** | **Currency** |  | [optional] 
**Cost** | **decimal** |  | [optional] 
**TaxIds** | **List&lt;string&gt;** | A list of Tax IDs for the product. | [optional] 
**IsRevenue** | **bool** | True if this item should be counted as revenue. For example, gift cards and donations would not be counted as revenue. | [optional] 
**UseDefaultTaxRates** | **bool** |  | [optional] 
**AbsentAtLocationIds** | **List&lt;string&gt;** | A list of locations where the object is not present, even if present_at_all_locations is true. This can include locations that are deactivated. | [optional] 
**PresentAtAllLocations** | **bool** |  | [optional] 
**AvailableForPickup** | **bool** |  | [optional] 
**AvailableOnline** | **bool** |  | [optional] 
**Sku** | **string** | SKU of the item | [optional] 
**Code** | **string** | Product code, e.g. UPC or EAN | [optional] 
**Categories** | **List&lt;Object&gt;** |  | [optional] 
**Options** | **List&lt;Object&gt;** | List of options pertaining to this item&#39;s attribute variation | [optional] 
**Variations** | **List&lt;Object&gt;** |  | [optional] 
**ModifierGroups** | **List&lt;Object&gt;** |  | [optional] 
**Available** | **bool?** |  | [optional] 
**Hidden** | **bool?** |  | [optional] 
**_Version** | **string** | The user who last updated the object. | [optional] [readonly] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**Deleted** | **bool?** | Flag to indicate if the object is deleted. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

