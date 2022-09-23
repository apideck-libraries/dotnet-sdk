# Apideck.Model.Payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier representing the entity | [optional] [readonly] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**TotalAmount** | **decimal** | Amount of payment | 
**Reference** | **string** | Optional payment reference message ie: Debit remittance detail. | [optional] 
**PaymentMethod** | **string** | Payment method | [optional] 
**PaymentMethodReference** | **string** | Optional reference message returned by payment method on processing | [optional] 
**AccountsReceivableAccountType** | **string** | Type of accounts receivable account. | [optional] 
**AccountsReceivableAccountId** | **string** | Unique identifier for the account to allocate payment to. | [optional] 
**Account** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**TransactionDate** | **DateTime** | Date transaction was entered - YYYY:MM::DDThh:mm:ss.sTZD | 
**Customer** | [**LinkedCustomer**](LinkedCustomer.md) |  | [optional] 
**Reconciled** | **bool** | Payment has been reconciled | [optional] 
**Status** | **string** | Status of payment | [optional] 
**Type** | **string** | Type of payment | [optional] 
**Allocations** | [**List&lt;PaymentAllocations&gt;**](PaymentAllocations.md) |  | [optional] 
**Note** | **string** | Optional note to be associated with the payment. | [optional] 
**RowVersion** | **string** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

