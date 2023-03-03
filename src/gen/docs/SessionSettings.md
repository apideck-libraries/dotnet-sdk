# Apideck.Model.SessionSettings
Settings to change the way the Vault is displayed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnifiedApis** | [**List&lt;UnifiedApiId&gt;**](UnifiedApiId.md) | Provide the IDs of the Unified APIs you want to be visible. Leaving it empty or omitting this field will show all Unified APIs. | [optional] 
**HideResourceSettings** | **bool** | A boolean that controls the display of the configurable resources for an integration. When set to true, the resource configuration options will be hidden and not shown to the user. When set to false, the resource configuration options will be displayed to the user. | [optional] [default to false]
**SandboxMode** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to show a banner informing the logged in user is in a test environment. | [optional] [default to false]
**IsolationMode** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to run in isolation mode, meaning it only shows the connection settings and hides the navigation items. | [optional] [default to false]
**SessionLength** | **string** | The duration of time the session is valid for (maximum 1 week). | [optional] [default to "1h"]
**ShowLogs** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to show the logs page. Defaults to &#x60;true&#x60;. | [optional] [default to true]
**ShowSuggestions** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to show the suggestions page. Defaults to &#x60;false&#x60;. | [optional] [default to false]
**ShowSidebar** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to show the sidebar. Defaults to &#x60;true&#x60;. | [optional] [default to true]
**AutoRedirect** | **bool** | Automatically redirect to redirect uri after the connection has been configured as callable. Defaults to &#x60;false&#x60;. | [optional] [default to false]
**HideGuides** | **bool** | Hide Apideck connection guides in [Vault](/apis/vault/reference#section/Get-Started). Defaults to &#x60;false&#x60;. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

