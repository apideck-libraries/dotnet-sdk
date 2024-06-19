# Apideck.Model.LedgerAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**DisplayId** | **string** | The human readable display ID used when displaying the account | [optional] 
**NominalCode** | **string** | The nominal code of the ledger account. | [optional] 
**Code** | **string** | The code assigned to the account. | [optional] 
**Classification** | **string** | The classification of account. | [optional] 
**Type** | **string** | The type of account. | [optional] 
**SubType** | **string** | The sub type of account. | [optional] 
**Name** | **string** | The name of the account. | [optional] 
**FullyQualifiedName** | **string** | The fully qualified name of the account. | [optional] 
**Description** | **string** | The description of the account. | [optional] 
**OpeningBalance** | **decimal?** | The opening balance of the account. | [optional] 
**CurrentBalance** | **decimal?** | The current balance of the account. | [optional] 
**Currency** | **Currency** |  | [optional] 
**TaxType** | **string** | The tax type of the account. | [optional] 
**TaxRate** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**Level** | **decimal?** |  | [optional] 
**Active** | **bool?** | Whether the account is active or not. | [optional] 
**Status** | **string** | The status of the account. | [optional] 
**Header** | **bool?** | Whether the account is a header or not. | [optional] 
**BankAccount** | [**BankAccount**](BankAccount.md) |  | [optional] 
**Categories** | [**List&lt;LedgerAccountCategories&gt;**](LedgerAccountCategories.md) | The categories of the account. | [optional] [readonly] 
**ParentAccount** | [**LedgerAccountParentAccount**](LedgerAccountParentAccount.md) |  | [optional] 
**SubAccount** | **bool?** | Whether the account is a sub account or not. | [optional] 
**SubAccounts** | **List&lt;Object&gt;** | The sub accounts of the account. | [optional] [readonly] 
**LastReconciliationDate** | **DateTime?** | Reconciliation Date means the last calendar day of each Reconciliation Period. | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

