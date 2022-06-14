# Apideck.Model.Folder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**Name** | **string** | The name of the folder | 
**Description** | **string** | Optional description of the folder | [optional] 
**Path** | **string** | The full path of the folder (includes the folder name) | [optional] [readonly] 
**Size** | **int** | The size of the folder in bytes | [optional] [readonly] 
**Owner** | [**Owner**](Owner.md) |  | [optional] 
**ParentFolders** | [**List&lt;LinkedFolder&gt;**](LinkedFolder.md) | The parent folders of the file, starting from the root | 
**ParentFoldersComplete** | **bool** | Whether the list of parent folder is complete. Some connectors only return the direct parent of a folder | [optional] [readonly] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

