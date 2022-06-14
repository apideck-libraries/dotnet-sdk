# Apideck.Model.PosPayment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**SourceId** | **string** |  | 
**OrderId** | **string** |  | 
**MerchantId** | **string** |  | [optional] 
**CustomerId** | **string** |  | 
**EmployeeId** | **string** |  | [optional] 
**LocationId** | **string** |  | [optional] 
**DeviceId** | **string** |  | [optional] 
**TenderId** | **string** |  | 
**ExternalPaymentId** | **string** |  | [optional] 
**IdempotencyKey** | **string** | A value you specify that uniquely identifies this request among requests you have sent. | [optional] 
**Amount** | **decimal** |  | 
**Currency** | **Currency** |  | 
**Tip** | **decimal** |  | [optional] 
**Tax** | **decimal** |  | [optional] 
**Total** | **decimal** |  | [optional] 
**AppFee** | **decimal** | The amount the developer is taking as a fee for facilitating the payment on behalf of the seller. | [optional] 
**ChangeBackCashAmount** | **decimal** |  | [optional] 
**Approved** | **decimal** | The initial amount of money approved for this payment. | [optional] 
**Refunded** | **decimal** | The initial amount of money approved for this payment. | [optional] 
**ProcessingFees** | **List&lt;Object&gt;** |  | [optional] 
**Source** | **string** | Source of this payment. | [optional] 
**Status** | **string** | Status of this payment. | [optional] 
**Cash** | [**CashDetails**](CashDetails.md) |  | [optional] 
**CardDetails** | [**PosPaymentCardDetails**](PosPaymentCardDetails.md) |  | [optional] 
**BankAccount** | [**BankAccount**](BankAccount.md) |  | [optional] 
**Wallet** | [**WalletDetails**](WalletDetails.md) |  | [optional] 
**ExternalDetails** | [**PosPaymentExternalDetails**](PosPaymentExternalDetails.md) |  | [optional] 
**ServiceCharges** | **List&lt;Object&gt;** | Optional service charges or gratuity tip applied to the order. | [optional] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

