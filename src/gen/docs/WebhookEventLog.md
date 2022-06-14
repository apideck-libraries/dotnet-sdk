# Apideck.Model.WebhookEventLog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**StatusCode** | **int** | HTTP Status code that was returned. | [optional] 
**Success** | **bool** | Whether or not the request was successful. | [optional] 
**ApplicationId** | **string** | ID of your Apideck Application | [optional] 
**ConsumerId** | **string** | Consumer identifier | [optional] 
**UnifiedApi** | **UnifiedApiId** |  | [optional] 
**Service** | [**WebhookEventLogService**](WebhookEventLogService.md) |  | [optional] 
**Endpoint** | **string** | The URL of the webhook endpoint. | [optional] 
**EventType** | **string** | Name of source event that webhook is subscribed to. | [optional] 
**ExecutionAttempt** | **decimal** | Number of attempts webhook endpoint was called before a success was returned or eventually failed | [optional] 
**HttpMethod** | **string** | HTTP Method of request to endpoint. | [optional] 
**Timestamp** | **string** | ISO Date and time when the request was made. | [optional] 
**EntityType** | **string** | Name of the Entity described by the attributes delivered within payload | [optional] 
**RequestBody** | **string** | The JSON stringified payload that was delivered to the webhook endpoint. | [optional] 
**ResponseBody** | **string** | The JSON stringified response that was returned from the webhook endpoint. | [optional] 
**RetryScheduled** | **bool** | If the request has not hit the max retry limit and will be retried. | [optional] 
**Attempts** | [**List&lt;WebhookEventLogAttempts&gt;**](WebhookEventLogAttempts.md) | record of each attempt to call webhook endpoint | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

