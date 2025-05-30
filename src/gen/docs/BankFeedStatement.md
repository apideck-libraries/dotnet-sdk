# Apideck.Model.BankFeedStatement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**BankFeedAccountId** | **string** | The ID of the bank feed account this statement belongs to. | [optional] 
**Status** | **string** | The current status of the bank feed statement. | [optional] 
**StartDate** | **DateTime** | Start date of the bank feed statement. | [optional] 
**EndDate** | **DateTime** | End date of the bank feed statement. | [optional] 
**StartBalance** | **decimal** | Balance amount at the start of the period. | [optional] 
**StartBalanceCreditOrDebit** | **CreditOrDebit** |  | [optional] 
**EndBalance** | **decimal** | Balance amount at the end of the period. | [optional] 
**EndBalanceCreditOrDebit** | **CreditOrDebit** |  | [optional] 
**Transactions** | [**List&lt;BankFeedStatementTransactions&gt;**](BankFeedStatementTransactions.md) | List of transactions in the bank feed statement. | [optional] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

