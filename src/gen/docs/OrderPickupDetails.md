# Apideck.Model.OrderPickupDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptedAt** | **DateTime?** |  | [optional] [readonly] 
**AutoCompleteDuration** | **string** | The duration of time after which an open and accepted pickup fulfillment is automatically moved to the COMPLETED state. The duration must be in RFC 3339 format (for example, &#39;P1W3D&#39;). | [optional] 
**CancelReason** | **string** | A description of why the pickup was canceled. | [optional] 
**ExpiresAt** | **DateTime** | Indicating when this fulfillment expires if it is not accepted. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). The expiration time can only be set up to 7 days in the future. If &#x60;expires_at&#x60; is not set, this pickup fulfillment is automatically accepted when  placed. | [optional] 
**ScheduleType** | **string** | The schedule type of the pickup fulfillment. | [optional] 
**PickupAt** | **DateTime** | The timestamp that represents the start of the pickup window. Must be in RFC 3339 timestamp format, e.g.,  \&quot;2016-09-04T23:59:33.123Z\&quot;.  For fulfillments with the schedule type &#x60;ASAP&#x60;, this is automatically set to the current time plus the expected duration to prepare the fulfillment. | [optional] 
**PickupWindowDuration** | **string** | The window of time in which the order should be picked up after the &#x60;pickup_at&#x60; timestamp. Must be in RFC 3339 duration format, e.g., \&quot;P1W3D\&quot;. Can be used as an informational guideline for merchants. | [optional] 
**PrepTimeDuration** | **string** | The duration of time it takes to prepare this fulfillment. The duration must be in RFC 3339 format (for example, \&quot;P1W3D\&quot;). | [optional] 
**Note** | **string** | A note meant to provide additional instructions about the pickup fulfillment displayed in the Square Point of Sale application and set by the API. | [optional] 
**PlacedAt** | **DateTime** | Indicating when the fulfillment was placed. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). | [optional] 
**RejectedAt** | **DateTime** | Indicating when the fulfillment was rejected. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). | [optional] 
**ReadyAt** | **DateTime** | Indicating when the fulfillment is marked as ready for pickup. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). | [optional] 
**ExpiredAt** | **DateTime** | Indicating when the fulfillment expired. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). | [optional] 
**PickedUpAt** | **DateTime** | Indicating when the fulfillment was picked up by the recipient. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). | [optional] 
**CanceledAt** | **DateTime** | Indicating when the fulfillment was canceled. The timestamp must be in RFC 3339 format (for example, \&quot;2016-09-04T23:59:33.123Z\&quot;). | [optional] 
**IsCurbsidePickup** | **bool** | If set to &#x60;true&#x60;, indicates that this pickup order is for curbside pickup, not in-store pickup. | [optional] 
**CurbsidePickupDetails** | [**OrderPickupDetailsCurbsidePickupDetails**](OrderPickupDetailsCurbsidePickupDetails.md) |  | [optional] 
**Recipient** | [**OrderPickupDetailsRecipient**](OrderPickupDetailsRecipient.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

