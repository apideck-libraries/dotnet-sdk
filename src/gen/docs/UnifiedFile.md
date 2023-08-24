# Apideck.Model.UnifiedFile

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**Name** | **string** | The name of the file | 
**Description** | **string** | Optional description of the file | [optional] 
**Type** | **FileType** |  | 
**Path** | **string** | The full path of the file or folder (includes the file name) | [optional] 
**MimeType** | **string** | The MIME type of the file. | [optional] 
**Downloadable** | **bool** | Whether the current user can download this file | [optional] 
**Size** | **int?** | The size of the file in bytes | [optional] 
**Owner** | [**Owner**](Owner.md) |  | [optional] 
**ParentFolders** | [**List&lt;LinkedFolder&gt;**](LinkedFolder.md) | The parent folders of the file, starting from the root | [optional] 
**ParentFoldersComplete** | **bool** | Whether the list of parent folders is complete. Some connectors only return the direct parent of a file | [optional] 
**Permissions** | [**UnifiedFilePermissions**](UnifiedFilePermissions.md) |  | [optional] 
**Exportable** | **bool** | Whether the current file is exportable to other file formats. This property is relevant for proprietary file formats such as Google Docs or Dropbox Paper. | [optional] 
**ExportFormats** | **List&lt;string&gt;** | The available file formats when exporting this file. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

