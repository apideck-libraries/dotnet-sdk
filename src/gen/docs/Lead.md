# Apideck.Model.Lead

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the contact. | [optional] [readonly] 
**Name** | **string** | Full name of the lead. | 
**CompanyName** | **string** | The name of the company the lead is associated with. | 
**OwnerId** | **string** | The owner of the lead. | [optional] 
**CompanyId** | **string** | The company the lead is associated with. | [optional] 
**LeadId** | **string** | The identifier of the lead. | [optional] 
**LeadSource** | **string** | The source of the lead. | [optional] 
**FirstName** | **string** | The first name of the lead. | [optional] 
**LastName** | **string** | The last name of the lead. | [optional] 
**Description** | **string** | The description of the lead. | [optional] 
**Prefix** | **string** | The prefix of the lead. | [optional] 
**Title** | **string** | The job title of the lead. | [optional] 
**Language** | **string** | language code according to ISO 639-1. For the United States - EN | [optional] 
**Status** | **string** |  | [optional] 
**MonetaryAmount** | **decimal?** | The monetary amount of the lead. | [optional] 
**Currency** | **Currency** |  | [optional] 
**Fax** | **string** | The fax number of the lead. | [optional] 
**Websites** | [**List&lt;Website&gt;**](Website.md) |  | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**SocialLinks** | [**List&lt;SocialLink&gt;**](SocialLink.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] 
**Emails** | [**List&lt;Email&gt;**](Email.md) |  | [optional] 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**UpdatedAt** | **string** | Date updated in ISO 8601 format | [optional] [readonly] 
**CreatedAt** | **string** | Date created in ISO 8601 format | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

