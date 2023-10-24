# Apideck.Model.EcommerceCustomer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**Name** | **string** | Full name of the customer | [optional] 
**FirstName** | **string** | First name of the customer | [optional] 
**LastName** | **string** | Last name of the customer | [optional] 
**CompanyName** | **string** | Company name of the customer | [optional] 
**Status** | **string** | The current status of the customer | [optional] 
**Currency** | **Currency** |  | [optional] 
**Emails** | [**List&lt;Email&gt;**](Email.md) | An array of email addresses for the customer. | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) | An array of phone numbers for the customer. | [optional] 
**Addresses** | [**List&lt;EcommerceCustomerAddresses&gt;**](EcommerceCustomerAddresses.md) | An array of addresses for the customer. | [optional] 
**Orders** | [**List&lt;LinkedEcommerceOrder&gt;**](LinkedEcommerceOrder.md) |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

