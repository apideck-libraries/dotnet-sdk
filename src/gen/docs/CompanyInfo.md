# Apideck.Model.CompanyInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**CompanyName** | **string** | The name of the company. | [optional] 
**Status** | **string** | Based on the status some functionality is enabled or disabled. | [optional] 
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
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

