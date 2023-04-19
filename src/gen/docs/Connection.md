# Apideck.Model.Connection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the connection. | [optional] [readonly] 
**ServiceId** | **string** | The ID of the service this connection belongs to. | [optional] [readonly] 
**Name** | **string** | The name of the connection | [optional] [readonly] 
**TagLine** | **string** |  | [optional] [readonly] 
**UnifiedApi** | **string** | The unified API category where the connection belongs to. | [optional] [readonly] 
**State** | **ConnectionState** |  | [optional] 
**IntegrationState** | **IntegrationState** |  | [optional] 
**AuthType** | **AuthType** |  | [optional] 
**OauthGrantType** | **OAuthGrantType** |  | [optional] 
**Status** | **string** | Status of the connection. | [optional] [readonly] 
**Enabled** | **bool** | Whether the connection is enabled or not. You can enable or disable a connection using the Update Connection API. | [optional] 
**Website** | **string** | The website URL of the connection | [optional] [readonly] 
**Icon** | **string** | A visual icon of the connection, that will be shown in the Vault | [optional] [readonly] 
**Logo** | **string** | The logo of the connection, that will be shown in the Vault | [optional] [readonly] 
**AuthorizeUrl** | **string** | The OAuth redirect URI. Redirect your users to this URI to let them authorize your app in the connector&#39;s UI. Before you can use this URI, you must add &#x60;redirect_uri&#x60; as a query parameter. Your users will be redirected to this &#x60;redirect_uri&#x60; after they granted access to your app in the connector&#39;s UI. | [optional] [readonly] 
**RevokeUrl** | **string** | The OAuth revoke URI. Redirect your users to this URI to revoke this connection. Before you can use this URI, you must add &#x60;redirect_uri&#x60; as a query parameter. Your users will be redirected to this &#x60;redirect_uri&#x60; after they granted access to your app in the connector&#39;s UI. | [optional] [readonly] 
**Settings** | **Dictionary&lt;string, Object&gt;** | Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Attach your own consumer specific metadata | [optional] 
**FormFields** | [**List&lt;FormField&gt;**](FormField.md) | The settings that are wanted to create a connection. | [optional] [readonly] 
**_Configuration** | [**List&lt;ConnectionConfiguration&gt;**](ConnectionConfiguration.md) |  | [optional] 
**ConfigurableResources** | **List&lt;string&gt;** |  | [optional] [readonly] 
**ResourceSchemaSupport** | **List&lt;string&gt;** |  | [optional] [readonly] 
**ResourceSettingsSupport** | **List&lt;string&gt;** |  | [optional] [readonly] 
**ValidationSupport** | **bool** |  | [optional] [readonly] 
**SettingsRequiredForAuthorization** | **List&lt;string&gt;** | List of settings that are required to be configured on integration before authorization can occur | [optional] [readonly] 
**Subscriptions** | [**List&lt;WebhookSubscription&gt;**](WebhookSubscription.md) |  | [optional] [readonly] 
**HasGuide** | **bool** | Whether the connector has a guide available in the developer docs or not (https://docs.apideck.com/connectors/{service_id}/docs/consumer+connection). | [optional] [readonly] 
**CreatedAt** | **decimal** |  | [optional] [readonly] 
**UpdatedAt** | **decimal?** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

