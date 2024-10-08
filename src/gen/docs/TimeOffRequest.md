# Apideck.Model.TimeOffRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**EmployeeId** | **string** | ID of the employee | [optional] 
**PolicyId** | **string** | ID of the policy | [optional] 
**Status** | **string** | The status of the time off request. | [optional] 
**Description** | **string** | Description of the time off request. | [optional] 
**StartDate** | **string** | The start date of the time off request. | [optional] 
**EndDate** | **string** | The end date of the time off request. | [optional] 
**RequestDate** | **string** | The date the request was made. | [optional] 
**RequestType** | **string** | The type of request | [optional] 
**ApprovalDate** | **string** | The date the request was approved | [optional] 
**Units** | **string** | The unit of time off requested. Possible values include: &#x60;hours&#x60;, &#x60;days&#x60;, or &#x60;other&#x60;. | [optional] 
**Amount** | **decimal?** | The amount of time off requested. | [optional] 
**DayPart** | **string** | The day part of the time off request. | [optional] 
**Notes** | [**TimeOffRequestNotes**](TimeOffRequestNotes.md) |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 
**PolicyType** | **string** | The policy type of the time off request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

