# Apideck.Model.BankFeedAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**BankAccountType** | **string** | Type of the bank account. | [optional] 
**SourceAccountId** | **string** | The source account&#39;s unique identifier. | [optional] 
**TargetAccountId** | **string** | The target account&#39;s unique identifier in the accounting connector. | [optional] 
**TargetAccountName** | **string** | Name associated with the target account. | [optional] 
**TargetAccountNumber** | **string** | Account number of the destination bank account. | [optional] 
**Currency** | **Currency** |  | [optional] 
**FeedStatus** | **string** | Current status of the bank feed. | [optional] 
**Country** | **string** | Country code according to ISO 3166-1 alpha-2. | [optional] 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**CustomMappings** | **Dictionary&lt;string, Object&gt;** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

