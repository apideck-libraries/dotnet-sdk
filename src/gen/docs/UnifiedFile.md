# Apideck.Model.UnifiedFile

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**Name** | **string** | The name of the file | 
**Description** | **string** | Optional description of the file | [optional] 
**Type** | **FileType** |  | 
**Path** | **string** | The full path of the file or folder (includes the file name) | [optional] 
**MimeType** | **string** | The MIME type of the file. | [optional] 
**Downloadable** | **bool** | Whether the current user can download this file | [optional] 
**Size** | **int** | The size of the file in bytes | [optional] 
**Owner** | [**Owner**](Owner.md) |  | [optional] 
**ParentFolders** | [**List&lt;LinkedFolder&gt;**](LinkedFolder.md) | The parent folders of the file, starting from the root | [optional] 
**ParentFoldersComplete** | **bool** | Whether the list of parent folder is complete. Some connectors only return the direct parent of a file | [optional] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime?** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

