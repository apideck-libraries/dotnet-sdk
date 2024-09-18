# Apideck.Model.ExpenseLineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**TrackingCategories** | [**List&lt;LinkedTrackingCategory&gt;**](LinkedTrackingCategory.md) | A list of linked tracking categories. | [optional] 
**AccountId** | **string** | The unique identifier for the ledger account. | [optional] 
**CustomerId** | **string** | The ID of the customer this expense item is linked to. | [optional] 
**DepartmentId** | **string** | The ID of the department this expense item is linked to. | [optional] 
**LocationId** | **string** | The ID of the location this expense item is linked to. | [optional] 
**TaxRate** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**Description** | **string** | The expense line item description | [optional] 
**TotalAmount** | **decimal?** | The total amount of the expense line item. | 
**Billable** | **bool** | Boolean that indicates if the line item is billable or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

