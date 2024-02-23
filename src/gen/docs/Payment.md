# Apideck.Model.Payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier representing the entity | [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**TotalAmount** | **decimal** | Amount of payment | 
**Reference** | **string** | Optional payment reference message ie: Debit remittance detail. | [optional] 
**PaymentMethod** | **string** | Payment method name | [optional] 
**PaymentMethodReference** | **string** | Optional reference message returned by payment method on processing | [optional] 
**PaymentMethodId** | **string** | Unique identifier for the payment method. | [optional] 
**AccountsReceivableAccountType** | **string** | Type of accounts receivable account. | [optional] 
**AccountsReceivableAccountId** | **string** | Unique identifier for the account to allocate payment to. | [optional] 
**Account** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**TransactionDate** | **DateTime** | Date transaction was entered - YYYY:MM::DDThh:mm:ss.sTZD | 
**Customer** | [**LinkedCustomer**](LinkedCustomer.md) |  | [optional] 
**Supplier** | [**LinkedSupplier**](LinkedSupplier.md) |  | [optional] 
**CompanyId** | **string** | The company or subsidiary id the transaction belongs to | [optional] 
**Reconciled** | **bool** | Payment has been reconciled | [optional] 
**Status** | **string** | Status of payment | [optional] 
**Type** | **string** | Type of payment | [optional] 
**Allocations** | [**List&lt;PaymentAllocations&gt;**](PaymentAllocations.md) |  | [optional] 
**Note** | **string** | Optional note to be associated with the payment. | [optional] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**DisplayId** | **string** | Payment id to be displayed. | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

