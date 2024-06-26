# Apideck.Model.Merchant

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Name** | **string** | The name of the merchant | [optional] 
**Address** | [**Address**](Address.md) |  | [optional] 
**OwnerId** | **string** |  | [optional] 
**MainLocationId** | **string** | The main location ID of the merchant | [optional] 
**Status** | **string** | Status of this merchant. | [optional] 
**ServiceCharges** | [**List&lt;ServiceCharge&gt;**](ServiceCharge.md) |  | [optional] 
**Language** | **string** | language code according to ISO 639-1. For the United States - EN | [optional] 
**Currency** | **Currency** |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

