# Apideck.Model.PaymentCard
A card's non-confidential details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Bin** | **string** | The first six digits of the card number, known as the Bank Identification Number (BIN). | [optional] 
**CardBrand** | **string** | The first six digits of the card number, known as the Bank Identification Number (BIN). | [optional] 
**CardType** | **string** |  | [optional] 
**PrepaidType** | **string** |  | [optional] 
**CardholderName** | **string** |  | [optional] 
**CustomerId** | **string** |  | [optional] 
**MerchantId** | **string** |  | [optional] 
**ExpMonth** | **int?** | The expiration month of the associated card as an integer between 1 and 12. | [optional] 
**ExpYear** | **int?** | The four-digit year of the card&#39;s expiration date. | [optional] 
**Fingerprint** | **string** |  | [optional] 
**Last4** | **string** |  | [optional] 
**Enabled** | **bool?** | Indicates whether or not a card can be used for payments. | [optional] 
**BillingAddress** | [**Address**](Address.md) |  | [optional] 
**ReferenceId** | **string** | An optional user-defined reference ID that associates this record with another entity in an external system. For example, a customer ID from an external customer management system. | [optional] 
**_Version** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

