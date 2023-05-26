# Apideck.Model.ConnectorUnifiedApis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **UnifiedApiId** |  | [optional] 
**Name** | **string** | Name of the API. | [optional] 
**AuthOnly** | **bool** | Indicates whether a connector only supports authentication. In this case the connector is not mapped to a Unified API, but can be used with the Proxy API | [optional] [readonly] 
**OauthScopes** | [**List&lt;ConnectorOauthScopes1&gt;**](ConnectorOauthScopes1.md) |  | [optional] 
**SupportedResources** | [**List&lt;LinkedConnectorResource&gt;**](LinkedConnectorResource.md) | List of resources that are supported on the connector. | [optional] 
**DownstreamUnsupportedResources** | **List&lt;string&gt;** | List of resources that are not supported on the downstream. | [optional] 
**SupportedEvents** | [**List&lt;ConnectorEvent&gt;**](ConnectorEvent.md) | List of events that are supported on the connector for this Unified API. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

