# Apideck.Model.AccountingLocation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**ParentId** | **string** | A unique identifier for an object. | [optional] 
**CompanyName** | **string** | The name of the company. | [optional] 
**DisplayName** | **string** | The display name of the location. | [optional] 
**Status** | **string** | Based on the status some functionality is enabled or disabled. | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**Subsidiaries** | [**List&lt;SubsidiaryReference&gt;**](SubsidiaryReference.md) |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

