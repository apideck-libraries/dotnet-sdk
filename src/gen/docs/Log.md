# Apideck.Model.Log

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiStyle** | **string** | Indicates if the request was made via REST or Graphql endpoint. | 
**BaseUrl** | **string** | The Apideck base URL the request was made to. | 
**ChildRequest** | **bool** | Indicates whether or not this is a child or parent request. | 
**ConsumerId** | **string** | The consumer Id associated with the request. | 
**Duration** | **decimal** | The entire execution time in milliseconds it took to call the Apideck service provider. | 
**ErrorMessage** | **string** | If error occurred, this is brief explanation | [optional] 
**Execution** | **int** | The entire execution time in milliseconds it took to make the request. | 
**HasChildren** | **bool** | When request is a parent request, this indicates if there are child requests associated. | 
**HttpMethod** | **string** | HTTP Method of request. | 
**Id** | **string** | UUID acting as Request Identifier. | 
**Latency** | **decimal** | Latency added by making this request via Unified Api. | 
**Operation** | [**LogOperation**](LogOperation.md) |  | 
**ParentId** | **string** | When request is a child request, this UUID indicates it&#39;s parent request. | 
**Path** | **string** | The path component of the URI the request was made to. | 
**Sandbox** | **bool** | Indicates whether the request was made using Apidecks sandbox credentials or not. | 
**Service** | [**LogService**](LogService.md) |  | 
**SourceIp** | **string** | The IP address of the source of the request. | [optional] 
**StatusCode** | **int** | HTTP Status code that was returned. | 
**Success** | **bool** | Whether or not the request was successful. | 
**Timestamp** | **string** | ISO Date and time when the request was made. | 
**UnifiedApi** | **string** | Which Unified Api request was made to. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

