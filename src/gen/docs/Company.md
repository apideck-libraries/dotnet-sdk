# Apideck.Model.Company

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**Name** | **string** |  | 
**InteractionCount** | **int?** |  | [optional] [readonly] 
**OwnerId** | **string** |  | [optional] 
**Image** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**VatNumber** | **string** | VAT number | [optional] 
**Currency** | **Currency** |  | [optional] 
**Status** | **string** |  | [optional] 
**Fax** | **string** |  | [optional] 
**AnnualRevenue** | **string** | Annual revenue | [optional] 
**NumberOfEmployees** | **string** | Number of employees | [optional] 
**Industry** | **string** | Industry | [optional] 
**Ownership** | **string** | Ownership | [optional] 
**SalesTaxNumber** | **string** |  | [optional] 
**PayeeNumber** | **string** |  | [optional] 
**AbnOrTfn** | **string** | An ABN is necessary for operating a business, while a TFN (Tax File Number) is required for any person working in Australia. | [optional] 
**AbnBranch** | **string** | An ABN Branch (also known as a GST Branch) is used if part of your business needs to account for GST separately from its parent entity. | [optional] 
**Acn** | **string** | The Australian Company Number (ACN) is a nine digit number with the last digit being a check digit calculated using a modified modulus 10 calculation. ASIC has adopted a convention of always printing and displaying the ACN in the format XXX XXX XXX; three blocks of three characters, each block separated by a blank. | [optional] 
**FirstName** | **string** | The first name of the person. | [optional] 
**LastName** | **string** | The last name of the person. | [optional] 
**ParentId** | **string** | Parent ID | [optional] [readonly] 
**BankAccounts** | [**List&lt;BankAccount&gt;**](BankAccount.md) |  | [optional] 
**Websites** | [**List&lt;Website&gt;**](Website.md) |  | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**SocialLinks** | [**List&lt;SocialLink&gt;**](SocialLink.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] 
**Emails** | [**List&lt;Email&gt;**](Email.md) |  | [optional] 
**RowType** | [**CompanyRowType**](CompanyRowType.md) |  | [optional] 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**ReadOnly** | **bool?** |  | [optional] 
**LastActivityAt** | **DateTime?** |  | [optional] [readonly] 
**Deleted** | **bool** |  | [optional] [readonly] 
**Salutation** | **string** | A formal salutation for the person. For example, &#39;Mr&#39;, &#39;Mrs&#39; | [optional] 
**Birthday** | **DateTime?** | The date of birth of the person. | [optional] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

