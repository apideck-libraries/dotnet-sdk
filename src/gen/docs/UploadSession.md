# Apideck.Model.UploadSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Success** | **bool** | Indicates if the upload session was completed successfully. | [optional] [readonly] 
**PartSize** | **decimal** | Size in bytes of each part of the file that you will upload. Uploaded parts need to be this size for the upload to be successful. | [optional] [readonly] 
**ParallelUploadSupported** | **bool** | Indicates if parts of the file can uploaded in parallel. | [optional] [readonly] 
**UploadedByteRange** | **string** | The range of bytes that was successfully uploaded. | [optional] [readonly] 
**ExpiresAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

