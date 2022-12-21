# Apideck.Model.ConnectionWebhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**Description** | **string** |  | [optional] 
**UnifiedApi** | **UnifiedApiId** |  | 
**Status** | **string** | The status of the webhook. | 
**DisabledReason** | **string** | Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&#39;s plan. | [optional] 
**DeliveryUrl** | **string** | The delivery url of the webhook endpoint. | 
**ExecuteBaseUrl** | **string** | The Unify Base URL events from connectors will be sent to after service id is appended. | [readonly] 
**Events** | **List&lt;string&gt;** | The list of subscribed events for this webhook. [&#x60;*&#x60;] indicates that all events are enabled. | 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

