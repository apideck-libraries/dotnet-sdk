# Apideck.Model.WebhookEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **string** | Unique reference to this request event | [optional] 
**UnifiedApi** | **string** | Name of Apideck Unified API | [optional] 
**ServiceId** | **string** | Service provider identifier | [optional] 
**ConsumerId** | **string** | Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID. | [optional] 
**EntityId** | **string** | The service provider&#39;s ID of the entity that triggered this event | [optional] 
**EntityType** | **string** | The type entity that triggered this event | [optional] 
**EntityUrl** | **string** | The url to retrieve entity detail. | [optional] 
**ExecutionAttempt** | **decimal** | The current count this request event has been attempted | [optional] 
**OccurredAt** | **string** | ISO Datetime for when the original event occurred | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

