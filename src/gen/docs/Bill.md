# Apideck.Model.Bill

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**DownstreamId** | **string** | The third-party API ID of original entity | [optional] [readonly] 
**BillNumber** | **string** |  | [optional] 
**Supplier** | [**LinkedSupplier**](LinkedSupplier.md) |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**CurrencyRate** | **decimal?** | Currency Exchange Rate at the time entity was recorded/generated. | [optional] 
**TaxInclusive** | **bool?** | Amounts are including tax | [optional] 
**BillDate** | **DateTime** | Date bill was issued - YYYY-MM-DD. | [optional] 
**DueDate** | **DateTime** | The due date is the date on which a payment is scheduled to be received by the supplier - YYYY-MM-DD. | [optional] 
**PaidDate** | **DateTime?** | The paid date is the date on which a payment was sent to the supplier - YYYY-MM-DD. | [optional] 
**PoNumber** | **string** | A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order. | [optional] 
**Reference** | **string** | Optional invoice reference. | [optional] 
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
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime?** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**RowVersion** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

