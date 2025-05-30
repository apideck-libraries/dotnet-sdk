# Apideck.Model.CustomObjectSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the custom object schema | [optional] [readonly] 
**Name** | **string** | The name of the custom object schema | [optional] 
**Description** | **string** | The description of the custom object schema | [optional] 
**Fields** | [**List&lt;CustomObjectSchemaFields&gt;**](CustomObjectSchemaFields.md) | The fields defined in the schema | [optional] 
**Visible** | **bool?** | Whether the custom object schema is visible in the UI | [optional] 
**Active** | **bool?** | Whether the custom object schema is active | [optional] 
**CreatedBy** | **string** | The ID of the user who created the custom object schema | [optional] [readonly] 
**UpdatedBy** | **string** | The ID of the user who last updated the custom object schema | [optional] [readonly] 
**UpdatedAt** | **string** | The timestamp when the custom object schema was last updated | [optional] [readonly] 
**CreatedAt** | **string** | The timestamp when the custom object schema was created | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

