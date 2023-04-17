# Apideck.Model.OrderTenders

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**Note** | **string** |  | [optional] 
**Amount** | **decimal** |  | [optional] 
**Percentage** | **decimal** |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**TotalAmount** | **int?** |  | [optional] 
**TotalTip** | **int?** |  | [optional] 
**TotalProcessingFee** | **int?** |  | [optional] 
**TotalTax** | **int?** |  | [optional] 
**TotalDiscount** | **int?** |  | [optional] 
**TotalRefund** | **int?** |  | [optional] 
**TotalServiceCharge** | **int?** |  | [optional] 
**BuyerTenderedCashAmount** | **int?** | The amount (in cents) of cash tendered by the buyer. Only applicable when the tender type is cash. | [optional] 
**ChangeBackCashAmount** | **int?** | The amount (in cents) of cash returned to the buyer. Only applicable when the tender type is cash. | [optional] 
**Card** | [**PaymentCard**](PaymentCard.md) |  | [optional] 
**CardStatus** | **string** | The status of the card. Only applicable when the tender type is card. | [optional] 
**CardEntryMethod** | **string** | The entry method of the card. Only applicable when the tender type is card. | [optional] 
**PaymentId** | **string** | A unique identifier for an object. | [optional] [readonly] 
**LocationId** | **string** | A unique identifier for an object. | [optional] [readonly] 
**TransactionId** | **string** | A unique identifier for an object. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

