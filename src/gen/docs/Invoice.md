# Apideck.Model.Invoice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**Type** | **string** | Invoice type | [optional] 
**Number** | **string** | Invoice number. | [optional] 
**Customer** | [**LinkedCustomer**](LinkedCustomer.md) |  | [optional] 
**InvoiceDate** | **DateTime?** | Date invoice was issued - YYYY-MM-DD. | [optional] 
**DueDate** | **DateTime?** | The invoice due date is the date on which a payment or invoice is scheduled to be received by the seller - YYYY-MM-DD. | [optional] 
**Terms** | **string** | Terms of payment. | [optional] 
**PoNumber** | **string** | A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order. | [optional] 
**Reference** | **string** | Optional invoice reference. | [optional] 
**Status** | **string** | Invoice status | [optional] 
**InvoiceSent** | **bool** | Invoice sent to contact/customer. | [optional] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**TaxInclusive** | **bool?** | Amounts are including tax | [optional] 
**SubTotal** | **decimal?** | Sub-total amount, normally before tax. | [optional] 
**TotalTax** | **decimal?** | Total tax amount applied to this invoice. | [optional] 
**TaxCode** | **string** | Applicable tax id/code override if tax is not supplied on a line item basis. | [optional] 
**DiscountPercentage** | **decimal?** | Discount percentage applied to this invoice. | [optional] 
**Total** | **decimal?** | Total amount of invoice, including tax. | [optional] 
**Balance** | **decimal?** | Balance of invoice due. | [optional] 
**Deposit** | **decimal?** | Amount of deposit made to this invoice. | [optional] 
**CustomerMemo** | **string** | Customer memo | [optional] 
**LineItems** | [**List&lt;InvoiceLineItem&gt;**](InvoiceLineItem.md) |  | [optional] 
**BillingAddress** | [**Address**](Address.md) |  | [optional] 
**ShippingAddress** | [**Address**](Address.md) |  | [optional] 
**TemplateId** | **string** | Optional invoice template | [optional] 
**SourceDocumentUrl** | **string** | URL link to a source document - shown as &#39;Go to [appName]&#39; in the downstream app. Currently only supported for Xero. | [optional] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

