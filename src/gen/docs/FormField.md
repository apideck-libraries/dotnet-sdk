# Apideck.Model.FormField

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the form field. | [optional] 
**Label** | **string** | The label of the field | [optional] 
**Placeholder** | **string** | The placeholder for the form field | [optional] 
**Description** | **string** | The description of the form field | [optional] 
**Type** | **string** |  | [optional] 
**Required** | **bool** | Indicates if the form field is required, which means it must be filled in before the form can be submitted | [optional] 
**CustomField** | **bool** |  | [optional] 
**AllowCustomValues** | **bool** | Only applicable to select fields. Allow the user to add a custom value though the option select if the desired value is not in the option select list. | [optional] [default to false]
**Disabled** | **bool?** | Indicates if the form field is displayed in a “read-only” mode. | [optional] 
**Hidden** | **bool?** | Indicates if the form field is not displayed but the value that is being stored on the connection. | [optional] 
**Sensitive** | **bool?** | Indicates if the form field contains sensitive data, which will display the value as a masked input. | [optional] 
**Options** | [**List&lt;FormFieldOption&gt;**](FormFieldOption.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

