# Apideck.Model.Ticket

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**ParentId** | **string** | The ticket&#39;s parent ID | [optional] 
**CollectionId** | **string** | The ticket&#39;s collection ID | [optional] [readonly] 
**Type** | **string** | The ticket&#39;s type | [optional] 
**Subject** | **string** | Subject of the ticket | [optional] 
**Description** | **string** | The ticket&#39;s description. HTML version of description is mapped if supported by the third-party platform | [optional] 
**Status** | **string** | The current status of the ticket. Possible values include: open, in_progress, closed, or - in cases where there is no clear mapping - the original value passed through. | [optional] 
**Priority** | **string** | Priority of the ticket | [optional] 
**Assignees** | [**List&lt;Assignee&gt;**](Assignee.md) |  | [optional] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**DueDate** | **DateTime?** | Due date of the ticket | [optional] 
**CompletedAt** | **DateTime?** | When the ticket was completed | [optional] [readonly] 
**Tags** | [**List&lt;CollectionTag&gt;**](CollectionTag.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

