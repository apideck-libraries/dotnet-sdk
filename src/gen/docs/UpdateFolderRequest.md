# Apideck.Model.UpdateFolderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Name** | **string** | The name of the folder. | [optional] 
**Description** | **string** | Optional description of the folder. | [optional] 
**ParentFolderId** | **string** | The parent folder to create the new file within. This can be an ID or a path depending on the downstream folder. Please see the connector section below to see downstream specific gotchas. | [optional] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

