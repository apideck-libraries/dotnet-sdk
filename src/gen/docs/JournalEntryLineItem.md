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
**LinkedTrackingCategory** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**LedgerAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

