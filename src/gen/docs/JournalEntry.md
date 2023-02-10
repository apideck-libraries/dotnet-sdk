# Apideck.Model.JournalEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**CurrencyRate** | **Currency** |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**LineItems** | [**List&lt;JournalEntryLineItem&gt;**](JournalEntryLineItem.md) | Requires a minimum of 2 line items that sum to 0 | [optional] 
**Memo** | **string** | Reference for the journal entry. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**PostedAt** | **DateTime** | This is the date on which the journal entry was added. This can be different from the creation date and can also be backdated. | [optional] 
**CreatedAt** | **DateTime** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

