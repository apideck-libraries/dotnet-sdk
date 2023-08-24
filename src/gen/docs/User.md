# Apideck.Model.User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the user | [optional] [readonly] 
**ParentId** | **string** | The parent user id | [optional] 
**Username** | **string** | The username of the user | [optional] 
**FirstName** | **string** | The first name of the person. | [optional] 
**LastName** | **string** | The last name of the person. | [optional] 
**Title** | **string** | The job title of the person. | [optional] 
**Division** | **string** | The division the person is currently in. Usually a collection of departments or teams or regions. | [optional] 
**Department** | **string** | The department the person is currently in. [Deprecated](https://developers.apideck.com/changelog) in favor of the dedicated department_id and department_name field. | [optional] 
**CompanyName** | **string** | The name of the company. | [optional] 
**EmployeeNumber** | **string** | An Employee Number, Employee ID or Employee Code, is a unique number that has been assigned to each individual staff member within a company. | [optional] 
**Description** | **string** | A description of the object. | [optional] 
**Image** | **string** | The URL of the user&#39;s avatar | [optional] 
**Language** | **string** | language code according to ISO 639-1. For the United States - EN | [optional] 
**Status** | **string** | The status of the user | [optional] 
**Password** | **string** | The password of the user | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] 
**Emails** | [**List&lt;Email&gt;**](Email.md) |  | 
**UpdatedAt** | **string** | The date and time when the user was last updated. | [optional] [readonly] 
**CreatedAt** | **string** | The date and time when the user was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

