# Apideck.Model.BankAccount
Card details for this payment. This field is currently not available. Reach out to our team for more info.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankName** | **string** | The name of the bank associated with the bank account. | [optional] 
**TransferType** | **string** | The type of the bank transfer. The type can be &#x60;ACH&#x60; or &#x60;UNKNOWN&#x60;. | [optional] 
**AccountOwnershipType** | **string** | The ownership type of the bank account performing the transfer. The type can be &#x60;INDIVIDUAL&#x60;, &#x60;COMPANY&#x60;, or &#x60;UNKNOWN&#x60;. | [optional] 
**Fingerprint** | **string** | Uniquely identifies the bank account for this seller and can be used to determine if payments are from the same bank account. | [optional] 
**Country** | **string** | country code according to ISO 3166-1 alpha-2. | [optional] 
**StatementDescription** | **string** | The statement description as sent to the bank. | [optional] 
**AchDetails** | [**BankAccountAchDetails**](BankAccountAchDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

