# Apideck.Model.Message

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**From** | **string** | The phone number that initiated the message. | 
**To** | **string** | The phone number that received the message. | 
**Subject** | **string** |  | [optional] 
**Body** | **string** | The message text. | 
**Type** | **string** | Set to sms for SMS messages and mms for MMS messages. | [optional] 
**NumberOfUnits** | **int** | The number of units that make up the complete message. Messages can be split up due to the constraints of the message size. | [optional] [readonly] 
**NumberOfMediaFiles** | **int** | The number of media files associated with the message. | [optional] [readonly] 
**Direction** | **string** | The direction of the message. | [optional] [readonly] 
**Status** | **string** | Status of the delivery of the message. | [optional] [readonly] 
**ScheduledAt** | **DateTime** | The scheduled date and time of the message. | [optional] 
**SentAt** | **DateTime** | The date and time that the message was sent | [optional] [readonly] 
**WebhookUrl** | **string** | Define a webhook to receive delivery notifications. | [optional] 
**Reference** | **string** | A client reference. | [optional] 
**Price** | [**Price**](Price.md) |  | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**MessagingServiceId** | **string** | The ID of the Messaging Service used with the message. In case of Plivo this links to the Powerpack ID. | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

