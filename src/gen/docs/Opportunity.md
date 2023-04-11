# Apideck.Model.Opportunity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for the opportunity. | [optional] [readonly] 
**Title** | **string** | The title or name of the opportunity. | 
**PrimaryContactId** | **string** | The unique identifier of the primary contact associated with the opportunity. | 
**Description** | **string** | A description of the opportunity. | [optional] 
**Type** | **string** | The type of the opportunity | [optional] 
**MonetaryAmount** | **decimal?** | The monetary value associated with the opportunity | [optional] 
**Currency** | **Currency** |  | [optional] 
**WinProbability** | **decimal?** | The probability of winning the opportunity, expressed as a percentage. | [optional] 
**ExpectedRevenue** | **decimal?** | The expected revenue from the opportunity | [optional] [readonly] 
**CloseDate** | **DateTime?** | The actual closing date for the opportunity. If close_date is null, the opportunity is not closed yet. | [optional] 
**LossReasonId** | **string** | The unique identifier of the reason why the opportunity was lost. | [optional] 
**LossReason** | **string** | The reason why the opportunity was lost. | [optional] 
**WonReasonId** | **string** | The unique identifier of the reason why the opportunity was won. | [optional] 
**WonReason** | **string** | The reason why the opportunity was won. | [optional] 
**PipelineId** | **string** | The unique identifier of the pipeline associated with the opportunity | [optional] 
**PipelineStageId** | **string** | The unique identifier of the stage in the pipeline associated with the opportunity. | [optional] 
**SourceId** | **string** | The unique identifier of the source of the opportunity. | [optional] 
**LeadId** | **string** | The unique identifier of the lead associated with the opportunity. | [optional] 
**LeadSource** | **string** | The source of the lead associated with the opportunity. | [optional] 
**ContactId** | **string** | The unique identifier of the contact associated with the opportunity. | [optional] 
**ContactIds** | **List&lt;string&gt;** | An array of unique identifiers of all contacts associated with the opportunity. | [optional] 
**CompanyId** | **string** | The unique identifier of the company associated with the opportunity. | [optional] 
**CompanyName** | **string** | The name of the company associated with the opportunity. | [optional] 
**OwnerId** | **string** | The unique identifier of the user who owns the opportunity. | [optional] 
**Priority** | **string** | The priority level of the opportunity. | [optional] 
**Status** | **string** | The current status of the opportunity. | [optional] 
**StatusId** | **string** | The unique identifier of the current status of the opportunity. | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**InteractionCount** | **decimal?** | The number of interactions with the opportunity. | [optional] [readonly] 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**StageLastChangedAt** | **DateTime?** | The date and time when the stage of the opportunity was last changed. | [optional] 
**LastActivityAt** | **string** | The date and time of the last activity associated with the opportunity. | [optional] [readonly] 
**Deleted** | **bool** | Indicates whether the opportunity has been deleted. | [optional] [readonly] 
**DateStageChanged** | **DateTime?** | The date and time when the stage of the opportunity was last changed. | [optional] [readonly] 
**DateLastContacted** | **DateTime?** | The date and time when the opportunity was last contacted. | [optional] [readonly] 
**DateLeadCreated** | **DateTime?** | The date and time when the lead associated with the opportunity was created. | [optional] [readonly] 
**UpdatedBy** | **string** | The unique identifier of the user who last updated the opportunity. | [optional] [readonly] 
**CreatedBy** | **string** | The unique identifier of the user who created the opportunity. | [optional] [readonly] 
**UpdatedAt** | **DateTime** | The date and time when the opportunity was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date and time when the opportunity was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

