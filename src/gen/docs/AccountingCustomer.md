# Apideck.Model.AccountingCustomer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**DisplayId** | **string** | Display ID | [optional] 
**DisplayName** | **string** | Display name | [optional] 
**CompanyName** | **string** |  | [optional] 
**Title** | **string** |  | [optional] 
**FirstName** | **string** |  | [optional] 
**MiddleName** | **string** |  | [optional] 
**LastName** | **string** |  | [optional] 
**Suffix** | **string** |  | [optional] 
**Individual** | **bool?** | Is this an individual or business customer | [optional] 
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
**Status** | **string** | Customer status | [optional] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime?** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**RowVersion** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

