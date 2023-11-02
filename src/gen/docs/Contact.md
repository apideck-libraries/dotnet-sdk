# Apideck.Model.Contact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the contact. | [optional] [readonly] 
**Name** | **string** | Full name of the contact. | 
**OwnerId** | **string** | The owner of the contact. | [optional] 
**Type** | **string** | The type of the contact. | [optional] 
**CompanyId** | **string** | The company the contact is associated with. | [optional] 
**CompanyName** | **string** | The name of the company the contact is associated with. | [optional] 
**LeadId** | **string** | The lead the contact is associated with. | [optional] 
**FirstName** | **string** | The first name of the contact. | [optional] 
**MiddleName** | **string** | The middle name of the contact. | [optional] 
**LastName** | **string** | The last name of the contact. | [optional] 
**Prefix** | **string** | The prefix of the contact. | [optional] 
**Suffix** | **string** | The suffix of the contact. | [optional] 
**Title** | **string** | The job title of the contact. | [optional] 
**Department** | **string** | The department of the contact. | [optional] 
**Language** | **string** | language code according to ISO 639-1. For the United States - EN | [optional] 
**Gender** | **string** | The gender of the contact. | [optional] 
**Birthday** | **string** | The birthday of the contact. | [optional] 
**Image** | **string** |  | [optional] 
**PhotoUrl** | **string** | The URL of the photo of a person. | [optional] 
**LeadSource** | **string** | The lead source of the contact. | [optional] 
**Fax** | **string** | The fax number of the contact. | [optional] 
**Description** | **string** | The description of the contact. | [optional] 
**CurrentBalance** | **decimal?** | The current balance of the contact. | [optional] 
**Status** | **string** | The status of the contact. | [optional] 
**Active** | **bool?** | The active status of the contact. | [optional] 
**Websites** | [**List&lt;Website&gt;**](Website.md) |  | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**SocialLinks** | [**List&lt;SocialLink&gt;**](SocialLink.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] 
**Emails** | [**List&lt;Email&gt;**](Email.md) |  | [optional] 
**EmailDomain** | **string** |  | [optional] 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**FirstCallAt** | **DateTime?** | The first call date of the contact. | [optional] [readonly] 
**FirstEmailAt** | **DateTime?** | The first email date of the contact. | [optional] [readonly] 
**LastActivityAt** | **DateTime?** | The last activity date of the contact. | [optional] [readonly] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The last update date of the contact. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The creation date of the contact. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

