# Apideck.Model.Bill

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**BillNumber** | **string** | Reference to supplier bill number | [optional] 
**Supplier** | [**LinkedSupplier**](LinkedSupplier.md) |  | [optional] 
**CompanyId** | **string** | The company or subsidiary id the transaction belongs to | [optional] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**TaxInclusive** | **bool?** | Amounts are including tax | [optional] 
**BillDate** | **DateTime?** | Date bill was issued - YYYY-MM-DD. | [optional] 
**DueDate** | **DateTime?** | The due date is the date on which a payment is scheduled to be received - YYYY-MM-DD. | [optional] 
**PaidDate** | **DateTime?** | The paid date is the date on which a payment was sent to the supplier - YYYY-MM-DD. | [optional] 
**PoNumber** | **string** | A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order. | [optional] 
**Reference** | **string** | Optional bill reference. | [optional] 
**LineItems** | [**List&lt;BillLineItem&gt;**](BillLineItem.md) |  | [optional] 
**Terms** | **string** | Terms of payment. | [optional] 
**Balance** | **decimal?** | Balance of bill due. | [optional] 
**Deposit** | **decimal?** | Amount of deposit made to this bill. | [optional] 
**SubTotal** | **decimal?** | Sub-total amount, normally before tax. | [optional] 
**TotalTax** | **decimal?** | Total tax amount applied to this bill. | [optional] 
**Total** | **decimal?** | Total amount of bill, including tax. | [optional] 
**TaxCode** | **string** | Applicable tax id/code override if tax is not supplied on a line item basis. | [optional] 
**Notes** | **string** |  | [optional] 
**Status** | **string** | Invoice status | [optional] 
**LedgerAccount** | [**LinkedLedgerAccount**](LinkedLedgerAccount.md) |  | [optional] 
**PaymentMethod** | **string** | Payment method used for the transaction, such as cash, credit card, bank transfer, or check | [optional] 
**Channel** | **string** | The channel through which the transaction is processed. | [optional] 
**Language** | **string** | language code according to ISO 639-1. For the United States - EN | [optional] 
**AccountingByRow** | **bool?** | Indicates if accounting by row is used (true) or not (false). Accounting by row means that a separate ledger transaction is created for each row. | [optional] 
**BankAccount** | [**BankAccount**](BankAccount.md) |  | [optional] 
**DiscountPercentage** | **decimal?** | Discount percentage applied to this transaction. | [optional] 
**SourceDocumentUrl** | **string** | URL link to a source document - shown as &#39;Go to [appName]&#39; in the downstream app. Currently only supported for Xero. | [optional] 
**TrackingCategories** | [**List&lt;LinkedTrackingCategory&gt;**](LinkedTrackingCategory.md) | A list of linked tracking categories. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**CustomFields** | [**List&lt;CustomField&gt;**](CustomField.md) |  | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**PassThrough** | **List&lt;Object&gt;** | The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources. | [optional] 
**AccountingPeriod** | **string** | Accounting period | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

