# Apideck.Model.SharedLink

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The URL that can be used to view the file. | [optional] [readonly] 
**DownloadUrl** | **string** | The URL that can be used to download the file. | [optional] 
**TargetId** | **string** | The ID of the file or folder to link. | 
**Target** | [**SharedLinkTarget**](SharedLinkTarget.md) |  | [optional] 
**Scope** | **string** | The scope of the shared link. | [optional] 
**PasswordProtected** | **bool?** | Indicated if the shared link is password protected. | [optional] [readonly] 
**Password** | **string** | Optional password for the shared link. | [optional] 
**ExpiresAt** | **DateTime?** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

