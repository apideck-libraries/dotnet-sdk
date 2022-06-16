# Apideck.Model.CompanyInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**CompanyName** | **string** |  | [optional] 
**LegalName** | **string** | The legal name of the company | [optional] 
**Country** | **string** | country code according to ISO 3166-1 alpha-2. | [optional] 
**SalesTaxNumber** | **string** |  | [optional] 
**AutomatedSalesTax** | **bool** | Whether sales tax is calculated automatically for the company | [optional] 
**SalesTaxEnabled** | **bool** | Whether sales tax is enabled for the company | [optional] 
**DefaultSalesTax** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**Language** | **string** | language code according to ISO 639-1. For the United States - EN | [optional] 
**FiscalYearStartMonth** | **string** | The start month of fiscal year. | [optional] 
**CompanyStartDate** | **DateTime** | Date when company file was created | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] 
**Emails** | [**List&lt;Email&gt;**](Email.md) |  | [optional] 
**RowVersion** | **string** |  | [optional] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

