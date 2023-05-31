# Apideck.Model.Customer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**DisplayId** | **string** | Display ID | [optional] 
**DisplayName** | **string** | Display name | [optional] 
**CompanyName** | **string** | The name of the company. | [optional] 
**Title** | **string** | The job title of the person. | [optional] 
**FirstName** | **string** | The first name of the person. | [optional] 
**MiddleName** | **string** | Middle name of the person. | [optional] 
**LastName** | **string** | The last name of the person. | [optional] 
**Suffix** | **string** |  | [optional] 
**Individual** | **bool?** | Is this an individual or business customer | [optional] 
**Project** | **bool?** | If true, indicates this is a Project. | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] 
**Emails** | [**List&lt;Email&gt;**](Email.md) |  | [optional] 
**Websites** | [**List&lt;Website&gt;**](Website.md) |  | [optional] 
**BankAccounts** | [**List&lt;BankAccount&gt;**](BankAccount.md) |  | [optional] 
**Notes** | **string** | Some notes about this customer | [optional] 
**TaxRate** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**TaxNumber** | **string** |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**Account** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**Parent** | [**LinkedParentCustomer**](LinkedParentCustomer.md) |  | [optional] 
**Status** | **string** | Customer status | [optional] 
**PaymentMethod** | **string** | Payment method used for the transaction, such as cash, credit card, bank transfer, or check | [optional] 
**Channel** | **string** | The channel through which the transaction is processed. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date and time when the object was created. | [optional] [readonly] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

