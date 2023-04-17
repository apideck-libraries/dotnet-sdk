# Apideck.Model.WebhookSupport
How webhooks are supported for the connector. Sometimes the connector natively supports webhooks, other times Apideck virtualizes them based on polling.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | Mode of the webhook support. | [optional] 
**SubscriptionLevel** | **string** | Received events are scoped to connection or across integration. | [optional] 
**ManagedVia** | **string** | How the subscription is managed in the downstream. | [optional] 
**VirtualWebhooks** | [**VirtualWebhooks**](VirtualWebhooks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

