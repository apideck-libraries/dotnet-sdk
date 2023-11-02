# Apideck.Model.Order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**IdempotencyKey** | **string** | A value you specify that uniquely identifies this request among requests you have sent. | [optional] 
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
**TotalAmount** | **int?** |  | [optional] 
**TotalTip** | **int?** |  | [optional] 
**TotalTax** | **int?** |  | [optional] 
**TotalDiscount** | **int?** |  | [optional] 
**TotalRefund** | **int?** |  | [optional] 
**TotalServiceCharge** | **int?** |  | [optional] 
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
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**_Version** | **string** |  | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

