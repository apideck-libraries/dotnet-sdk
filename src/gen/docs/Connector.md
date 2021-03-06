# Apideck.Model.Connector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the connector. | [optional] [readonly] 
**Name** | **string** | Name of the connector. | [optional] 
**Status** | **ConnectorStatus** |  | [optional] 
**Description** | **string** |  | [optional] 
**IconUrl** | **string** | Link to a small square icon for the connector. | [optional] 
**LogoUrl** | **string** | Link to the full logo for the connector. | [optional] 
**WebsiteUrl** | **string** | Link to the connector&#39;s website. | [optional] 
**AuthType** | **string** | Type of authorization used by the connector | [optional] [readonly] 
**AuthOnly** | **bool** | Indicates whether a connector only supports authentication. In this case the connector is not mapped to a Unified API, but can be used with the Proxy API | [optional] [readonly] 
**OauthGrantType** | **string** | OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types | [optional] [readonly] 
**OauthCredentialsSource** | **string** | Location of the OAuth client credentials. For most connectors the OAuth client credentials are stored on integration and managed by the application owner. For others they are stored on connection and managed by the consumer in Vault. | [optional] [readonly] 
**OauthScopes** | [**List&lt;ConnectorOauthScopes&gt;**](ConnectorOauthScopes.md) | List of OAuth Scopes available for this connector. | [optional] 
**HasSandboxCredentials** | **bool** | Indicates whether Apideck Sandbox OAuth credentials are available. | [optional] 
**Settings** | [**List&lt;ConnectorSetting&gt;**](ConnectorSetting.md) |  | [optional] 
**ServiceId** | **string** | Service provider identifier | [optional] 
**UnifiedApis** | [**List&lt;ConnectorUnifiedApis&gt;**](ConnectorUnifiedApis.md) | List of Unified APIs that feature this connector. | [optional] 
**SupportedResources** | [**List&lt;ConnectorSupportedResources&gt;**](ConnectorSupportedResources.md) | List of resources that are supported on the connector. | [optional] 
**ConfigurableResources** | **List&lt;string&gt;** | List of resources that have settings that can be configured. | [optional] 
**SupportedEvents** | [**List&lt;ConnectorSupportedEvents&gt;**](ConnectorSupportedEvents.md) | List of events that are supported on the connector. Events are delivered via Webhooks. | [optional] 
**Docs** | [**List&lt;ConnectorDoc&gt;**](ConnectorDoc.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

