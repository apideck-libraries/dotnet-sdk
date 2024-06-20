# Apideck.Model.Pipeline

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the Pipeline. | [optional] 
**Name** | **string** | The name of the Pipeline. | 
**Currency** | **Currency** |  | [optional] 
**Archived** | **bool** | Whether the Pipeline is archived or not. | [optional] 
**Active** | **bool** | Whether the Pipeline is active or not. | [optional] 
**DisplayOrder** | **int?** | The order in which the Pipeline is displayed in the UI. | [optional] 
**WinProbabilityEnabled** | **bool** | Whether the Pipeline has win probability enabled or not. | [optional] 
**Stages** | [**List&lt;PipelineStages&gt;**](PipelineStages.md) | The Pipeline Stages. | [optional] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

