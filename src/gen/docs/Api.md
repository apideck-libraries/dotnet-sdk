# Apideck.Model.Api

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the API. | [optional] [readonly] 
**Type** | **string** | Indicates whether the API is a Unified API. If unified_api is false, the API is a Platform API. | [optional] 
**Name** | **string** | Name of the API. | [optional] 
**Description** | **string** | Description of the API. | [optional] 
**Status** | **ApiStatus** |  | [optional] 
**SpecUrl** | **string** | Link to the latest OpenAPI specification of the API. | [optional] 
**ApiReferenceUrl** | **string** | Link to the API reference of the API. | [optional] 
**PostmanCollectionId** | **string** | ID of the Postman collection of the API. | [optional] 
**Categories** | **List&lt;string&gt;** | List of categories the API belongs to. | [optional] 
**Resources** | [**List&lt;ApiResources&gt;**](ApiResources.md) | List of resources supported in this API. | [optional] 
**Events** | **List&lt;string&gt;** | List of event types this API supports. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

