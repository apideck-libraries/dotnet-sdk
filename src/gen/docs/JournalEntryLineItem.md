# Apideck.Model.JournalEntryLineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Description** | **string** | User defined description | [optional] 
**TaxAmount** | **decimal?** | Tax amount | [optional] 
**SubTotal** | **decimal?** | Sub-total amount, normally before tax. | [optional] 
**TotalAmount** | **decimal?** | Debit entries are considered positive, and credit entries are considered negative. | [optional] 
**Type** | **string** | Debit entries are considered positive, and credit entries are considered negative. | 
**TaxRate** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**TrackingCategory** | [**DeprecatedLinkedTrackingCategory**](DeprecatedLinkedTrackingCategory.md) |  | [optional] 
**TrackingCategories** | [**List&lt;LinkedTrackingCategory&gt;**](LinkedTrackingCategory.md) | A list of linked tracking categories. | [optional] 
**LedgerAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | 
**Customer** | [**LinkedCustomer**](LinkedCustomer.md) |  | [optional] 
**Supplier** | [**LinkedSupplier**](LinkedSupplier.md) |  | [optional] 
**DepartmentId** | **string** | A unique identifier for an object. | [optional] [readonly] 
**LocationId** | **string** | A unique identifier for an object. | [optional] [readonly] 
**LineNumber** | **int?** | Line number of the resource | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

