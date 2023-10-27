# Apideck.Model.Folder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Name** | **string** | The name of the folder | 
**Description** | **string** | Optional description of the folder | [optional] 
**Path** | **string** | The full path of the folder (includes the folder name) | [optional] [readonly] 
**Size** | **int?** | The size of the folder in bytes | [optional] [readonly] 
**Owner** | [**Owner**](Owner.md) |  | [optional] 
**ParentFolders** | [**List&lt;LinkedFolder&gt;**](LinkedFolder.md) | The parent folders of the file, starting from the root | 
**ParentFoldersComplete** | **bool** | Whether the list of parent folder is complete. Some connectors only return the direct parent of a folder | [optional] [readonly] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

