# Apideck.Model.SessionSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnifiedApis** | [**List&lt;UnifiedApiId&gt;**](UnifiedApiId.md) | Provide the IDs of the Unified APIs you want to be visible. Leaving it empty or omiting this field will show all Unified APIs. | [optional] 
**HideResourceSettings** | **bool** |  | [optional] [default to false]
**SandboxMode** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to show a banner informing the logged in user is in a test environment. | [optional] [default to false]
**IsolationMode** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to run in isolation mode, meaning it only shows the connection settings and hides the navigation items. | [optional] [default to false]
**SessionLength** | **string** | The duration of time the session is valid for (maximum 1 week). | [optional] [default to "1h"]
**ShowLogs** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to show the logs page. Defaults to &#x60;true&#x60;. | [optional] [default to true]
**ShowSuggestions** | **bool** | Configure [Vault](/apis/vault/reference#section/Get-Started) to show the suggestions page. Defaults to &#x60;true&#x60;. | [optional] [default to false]
**AutoRedirect** | **bool** | Automatically redirect to redirect uri after the connection has been configured as callable. Defaults to &#x60;false&#x60;. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

