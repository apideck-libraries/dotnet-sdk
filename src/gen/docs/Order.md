# Apideck.Model.Order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**OrderNumber** | **string** |  | [optional] 
**OrderDate** | **DateTime?** |  | [optional] 
**ClosedDate** | **DateTime?** |  | [optional] 
**ReferenceId** | **string** | An optional user-defined reference ID that associates this record with another entity in an external system. For example, a customer ID from an external customer management system. | [optional] 
**Status** | **string** | Order status. Clover specific: If no value is set, the status defaults to hidden, which indicates a hidden order. A hidden order is not displayed in user interfaces and can only be retrieved by its id. When creating an order via the REST API the value must be manually set to &#39;open&#39;. More info [https://docs.clover.com/reference/orderupdateorder]() | [optional] 
**PaymentStatus** | **string** | Is this order paid or not? | [optional] 
**Currency** | **Currency** |  | [optional] 
**Title** | **string** |  | [optional] 
**Note** | **string** | A note with information about this order, may be printed on the order receipt and displayed in apps | [optional] 
**MerchantId** | **string** |  | 
**CustomerId** | **string** |  | [optional] 
**EmployeeId** | **string** |  | [optional] 
**LocationId** | **string** |  | 
**OrderTypeId** | **string** |  | [optional] 
**Table** | **string** |  | [optional] 
**Seat** | **string** |  | [optional] 
**TotalAmount** | **decimal?** |  | [optional] 
**TotalTip** | **decimal?** |  | [optional] 
**TotalTax** | **decimal?** |  | [optional] 
**TotalDiscount** | **decimal?** |  | [optional] 
**TotalRefund** | **decimal?** |  | [optional] 
**TotalServiceCharge** | **decimal?** |  | [optional] 
**Refunded** | **bool** |  | [optional] 
**Customers** | [**List&lt;OrderCustomers&gt;**](OrderCustomers.md) |  | [optional] 
**Fulfillments** | [**List&lt;OrderFulfillments&gt;**](OrderFulfillments.md) |  | [optional] 
**LineItems** | [**List&lt;OrderLineItems&gt;**](OrderLineItems.md) |  | [optional] 
**Payments** | [**List&lt;OrderPayments&gt;**](OrderPayments.md) |  | [optional] 
**ServiceCharges** | [**List&lt;ServiceCharge&gt;**](ServiceCharge.md) | Optional service charges or gratuity tip applied to the order. | [optional] 
**Refunds** | [**List&lt;OrderRefunds&gt;**](OrderRefunds.md) |  | [optional] 
**Taxes** | **List&lt;Object&gt;** |  | [optional] 
**Discounts** | [**List&lt;OrderDiscounts&gt;**](OrderDiscounts.md) |  | [optional] 
**Tenders** | [**List&lt;OrderTenders&gt;**](OrderTenders.md) |  | [optional] 
**Source** | **string** | Source of order. Indicates the way that the order was placed. | [optional] [readonly] 
**Voided** | **bool** |  | [optional] 
**VoidedAt** | **DateTime** |  | [optional] [readonly] 
**_Version** | **string** |  | [optional] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

