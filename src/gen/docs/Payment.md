# Apideck.Model.Payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**TotalAmount** | **decimal?** | The total amount of the transaction | 
**Reference** | **string** | Optional transaction reference message ie: Debit remittance detail. | [optional] 
**PaymentMethod** | **string** | Payment method used for the transaction, such as cash, credit card, bank transfer, or check | [optional] 
**PaymentMethodReference** | **string** | Optional reference message returned by payment method on processing | [optional] 
**PaymentMethodId** | **string** | A unique identifier for an object. | [optional] 
**AccountsReceivableAccountType** | **string** | Type of accounts receivable account. | [optional] 
**AccountsReceivableAccountId** | **string** | Unique identifier for the account to allocate payment to. | [optional] 
**Account** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**TransactionDate** | **DateTime?** | The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD | 
**Customer** | [**LinkedCustomer**](LinkedCustomer.md) |  | [optional] 
**Supplier** | [**DeprecatedLinkedSupplier**](DeprecatedLinkedSupplier.md) |  | [optional] 
**CompanyId** | **string** | The company or subsidiary id the transaction belongs to | [optional] 
**Reconciled** | **bool?** | Indicates if the transaction has been reconciled. | [optional] 
**Status** | **PaymentStatus** |  | [optional] 
**Type** | **PaymentType** |  | [optional] 
**Allocations** | [**List&lt;Allocation&gt;**](Allocation.md) |  | [optional] 
**Note** | **string** | Note associated with the transaction | [optional] 
**Number** | **string** | Number associated with the transaction | [optional] 
**TrackingCategories** | [**List&lt;LinkedTrackingCategory&gt;**](LinkedTrackingCategory.md) | A list of linked tracking categories. | [optional] 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**DisplayId** | **string** | Id to be displayed. | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

