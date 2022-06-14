# Apideck.Model.OrderTenders

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**Note** | **string** |  | [optional] 
**Amount** | **decimal** |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**TotalAmount** | **decimal?** |  | [optional] 
**TotalTip** | **decimal?** |  | [optional] 
**TotalProcessingFee** | **decimal?** |  | [optional] 
**TotalTax** | **decimal?** |  | [optional] 
**TotalDiscount** | **decimal?** |  | [optional] 
**TotalRefund** | **decimal?** |  | [optional] 
**TotalServiceCharge** | **decimal?** |  | [optional] 
**BuyerTenderedCashAmount** | **decimal?** | The amount of cash tendered by the buyer. Only applicable when the tender type is cash. | [optional] 
**ChangeBackCashAmount** | **decimal?** | The amount of cash returned to the buyer. Only applicable when the tender type is cash. | [optional] 
**Card** | [**PaymentCard**](PaymentCard.md) |  | [optional] 
**CardStatus** | **string** | The status of the card. Only applicable when the tender type is card. | [optional] 
**CardEntryMethod** | **string** | The entry method of the card. Only applicable when the tender type is card. | [optional] 
**PaymentId** | **string** |  | [optional] [readonly] 
**LocationId** | **string** |  | [optional] [readonly] 
**TransactionId** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

