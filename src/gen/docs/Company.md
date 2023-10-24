# Apideck.Model.Company

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the company | [optional] [readonly] 
**Name** | **string** | Name of the company | 
**InteractionCount** | **int?** | Number of interactions | [optional] [readonly] 
**OwnerId** | **string** | Owner ID | [optional] 
**Image** | **string** | The Image URL of the company | [optional] 
**Description** | **string** | A description of the company | [optional] 
**VatNumber** | **string** | The VAT number of the company | [optional] 
**Currency** | **Currency** |  | [optional] 
**Status** | **string** | The status of the company | [optional] 
**Fax** | **string** | The fax number of the company | [optional] 
**AnnualRevenue** | **string** | The annual revenue of the company | [optional] 
**NumberOfEmployees** | **string** | Number of employees | [optional] 
**Industry** | **string** | The industry represents the type of business the company is in. | [optional] 
**Ownership** | **string** | The ownership indicates the type of ownership of the company. | [optional] 
**SalesTaxNumber** | **string** | A sales tax number is a unique number that identifies a company for tax purposes. | [optional] 
**PayeeNumber** | **string** | A payee number is a unique number that identifies a payee for tax purposes. | [optional] 
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
**ReadOnly** | **bool?** | Whether the company is read-only or not | [optional] 
**LastActivityAt** | **DateTime?** | Last activity date | [optional] [readonly] 
**Deleted** | **bool** | Whether the company is deleted or not | [optional] [readonly] 
**Salutation** | **string** | A formal salutation for the person. For example, &#39;Mr&#39;, &#39;Mrs&#39; | [optional] 
**Birthday** | **DateTime?** | The date of birth of the person. | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] 
**UpdatedBy** | **string** | Updated by user ID | [optional] [readonly] 
**CreatedBy** | **string** | Created by user ID | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | Last updated date | [optional] [readonly] 
**CreatedAt** | **DateTime?** | Creation date | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

