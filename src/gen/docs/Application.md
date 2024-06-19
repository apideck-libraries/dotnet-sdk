# Apideck.Model.Application

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**ApplicantId** | **string** |  | 
**JobId** | **string** |  | 
**Status** | **string** |  | [optional] 
**Stage** | [**ApplicationStage**](ApplicationStage.md) |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

