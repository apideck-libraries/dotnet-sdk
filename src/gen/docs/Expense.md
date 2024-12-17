# Apideck.Model.Expense

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Number** | **string** | Number. | [optional] 
**TransactionDate** | **DateTime?** | The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD | 
**AccountId** | **string** | The unique identifier for the ledger account that this expense should be credited to.  | 
**CustomerId** | **string** | The ID of the customer this entity is linked to. Used for expenses that should be marked as billable to customers. | [optional] 
**SupplierId** | **string** | The ID of the supplier this entity is linked to. | [optional] 
**CompanyId** | **string** | The company or subsidiary id the transaction belongs to | [optional] 
**DepartmentId** | **string** | The ID of the department this expense is linked to. | [optional] 
**PaymentType** | **string** | The type of payment for the expense. | [optional] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**Type** | **string** | The type of expense. | [optional] 
**Memo** | **string** | The memo of the expense. | [optional] 
**TaxRate** | [**LinkedTaxRate**](LinkedTaxRate.md) |  | [optional] 
**TotalAmount** | **decimal?** | The total amount of the expense line item. | [optional] 
**LineItems** | [**List&lt;ExpenseLineItem&gt;**](ExpenseLineItem.md) | Expense line items linked to this expense. | 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

