# Apideck.Model.Connector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the connector. | [optional] [readonly] 
**Name** | **string** | Name of the connector. | [optional] 
**Status** | **ConnectorStatus** |  | [optional] 
**Description** | **string** | A description of the object. | [optional] 
**IconUrl** | **string** | Link to a small square icon for the connector. | [optional] 
**LogoUrl** | **string** | Link to the full logo for the connector. | [optional] 
**WebsiteUrl** | **string** | Link to the connector&#39;s website. | [optional] 
**SignupUrl** | **string** | Link to the connector&#39;s signup page. | [optional] 
**PartnerSignupUrl** | **string** | Link to the connector&#39;s partner program signup page. | [optional] 
**FreeTrialAvailable** | **bool** | Set to &#x60;true&#x60; when the connector offers a free trial. Use &#x60;signup_url&#x60; to sign up for a free trial | [optional] 
**AuthType** | **string** | Type of authorization used by the connector | [optional] [readonly] 
**AuthOnly** | **bool** | Indicates whether a connector only supports authentication. In this case the connector is not mapped to a Unified API, but can be used with the Proxy API | [optional] [readonly] 
**BlindMapped** | **bool** | Set to &#x60;true&#x60; when connector was implemented from downstream docs only and without API access. This state indicates that integration will require Apideck support, and access to downstream API to validate mapping quality. | [optional] [readonly] 
**OauthGrantType** | **string** | OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types | [optional] [readonly] 
**OauthCredentialsSource** | **string** | Location of the OAuth client credentials. For most connectors the OAuth client credentials are stored on integration and managed by the application owner. For others they are stored on connection and managed by the consumer in Vault. | [optional] [readonly] 
**OauthScopes** | [**List&lt;ConnectorOauthScopes&gt;**](ConnectorOauthScopes.md) | List of OAuth Scopes available for this connector. | [optional] 
**CustomScopes** | **bool** | Set to &#x60;true&#x60; when connector allows the definition of custom scopes. | [optional] [readonly] 
**HasSandboxCredentials** | **bool** | Indicates whether Apideck Sandbox OAuth credentials are available. | [optional] 
**Settings** | [**List&lt;ConnectorSetting&gt;**](ConnectorSetting.md) |  | [optional] 
**ServiceId** | **string** | Service provider identifier | [optional] 
**UnifiedApis** | [**List&lt;ConnectorUnifiedApis&gt;**](ConnectorUnifiedApis.md) | List of Unified APIs that feature this connector. | [optional] 
**SupportedResources** | [**List&lt;LinkedConnectorResource&gt;**](LinkedConnectorResource.md) | List of resources that are supported on the connector. | [optional] 
**ConfigurableResources** | **List&lt;string&gt;** | List of resources that have settings that can be configured. | [optional] 
**SupportedEvents** | [**List&lt;ConnectorEvent&gt;**](ConnectorEvent.md) | List of events that are supported on the connector across all Unified APIs. | [optional] 
**WebhookSupport** | [**WebhookSupport**](WebhookSupport.md) |  | [optional] 
**SchemaSupport** | [**SchemaSupport**](SchemaSupport.md) |  | [optional] 
**Docs** | [**List&lt;ConnectorDoc&gt;**](ConnectorDoc.md) |  | [optional] 
**TlsSupport** | [**ConnectorTlsSupport**](ConnectorTlsSupport.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

