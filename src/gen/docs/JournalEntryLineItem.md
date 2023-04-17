# Apideck.Model.JournalEntryLineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Description** | **string** | User defined description | [optional] 
**TaxAmount** | **decimal?** | Tax amount | [optional] 
**TotalAmount** | **decimal?** | Debit entries are considered positive, and credit entries are considered negative. | 
**Type** | **string** | Debit entries are considered positive, and credit entries are considered negative. | 
**TaxRate** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**TrackingCategory** | [**LinkedTrackingCategory**](LinkedTrackingCategory.md) |  | [optional] 
**LedgerAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | 
**DepartmentId** | **string** | A unique identifier for an object. | [optional] [readonly] 
**LocationId** | **string** | A unique identifier for an object. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

