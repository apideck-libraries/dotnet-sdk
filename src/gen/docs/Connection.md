# Apideck.Model.Connection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**ServiceId** | **string** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] [readonly] 
**TagLine** | **string** |  | [optional] [readonly] 
**UnifiedApi** | **string** |  | [optional] [readonly] 
**State** | **ConnectionState** |  | [optional] 
**AuthType** | **AuthType** |  | [optional] 
**OauthGrantType** | **OAuthGrantType** |  | [optional] 
**Status** | **string** |  | [optional] [readonly] 
**Enabled** | **bool** | Whether the connection is enabled or not. You can enable or disable a connection using the Update Connection API. | [optional] 
**Website** | **string** |  | [optional] [readonly] 
**Icon** | **string** |  | [optional] [readonly] 
**Logo** | **string** |  | [optional] [readonly] 
**AuthorizeUrl** | **string** | The OAuth redirect URI. Redirect your users to this URI to let them authorize your app in the connector&#39;s UI. Before you can use this URI, you must add &#x60;redirect_uri&#x60; as a query parameter. Your users will be redirected to this &#x60;redirect_uri&#x60; after they granted access to your app in the connector&#39;s UI. | [optional] [readonly] 
**RevokeUrl** | **string** | The OAuth revoke URI. Redirect your users to this URI to revoke this connection. Before you can use this URI, you must add &#x60;redirect_uri&#x60; as a query parameter. Your users will be redirected to this &#x60;redirect_uri&#x60; after they granted access to your app in the connector&#39;s UI. | [optional] [readonly] 
**Settings** | **Dictionary&lt;string, Object&gt;** | Connection settings. Values will persist to &#x60;form_fields&#x60; with corresponding id | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Attach your own consumer specific metadata | [optional] 
**FormFields** | [**List&lt;FormField&gt;**](FormField.md) |  | [optional] [readonly] 
**_Configuration** | [**List&lt;ConnectionConfiguration&gt;**](ConnectionConfiguration.md) |  | [optional] 
**ConfigurableResources** | **List&lt;string&gt;** |  | [optional] [readonly] 
**ResourceSchemaSupport** | **List&lt;string&gt;** |  | [optional] [readonly] 
**ResourceSettingsSupport** | **List&lt;string&gt;** |  | [optional] [readonly] 
**SettingsRequiredForAuthorization** | **List&lt;string&gt;** |  | [optional] [readonly] 
**HasGuide** | **bool** | Whether the connector has a guide available in the developer docs or not (https://docs.apideck.com/connectors/{service_id}/docs/consumer+connection). | [optional] [readonly] 
**CreatedAt** | **decimal** |  | [optional] [readonly] 
**UpdatedAt** | **decimal?** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

