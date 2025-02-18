# Apideck.Model.JournalEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**Title** | **string** | Journal entry title | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**Currency** | **Currency** |  | [optional] 
**CompanyId** | **string** | The company or subsidiary id the transaction belongs to | [optional] 
**LineItems** | [**List&lt;JournalEntryLineItem&gt;**](JournalEntryLineItem.md) | Requires a minimum of 2 line items that sum to 0 | [optional] 
**Memo** | **string** | Reference for the journal entry. | [optional] 
**PostedAt** | **DateTime** | This is the date on which the journal entry was added. This can be different from the creation date and can also be backdated. | [optional] 
**JournalSymbol** | **string** | Journal symbol of the entry. For example IND for indirect costs | [optional] 
**TaxType** | **string** | The specific category of tax associated with a transaction like sales or purchase | [optional] 
**TaxCode** | **string** | Applicable tax id/code override if tax is not supplied on a line item basis. | [optional] 
**Number** | **string** | Journal entry number. | [optional] 
**TrackingCategories** | [**List&lt;LinkedTrackingCategory&gt;**](LinkedTrackingCategory.md) | A list of linked tracking categories. | [optional] 
**AccountingPeriod** | **string** | Accounting period | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

