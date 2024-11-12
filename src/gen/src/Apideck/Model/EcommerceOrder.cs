/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.8.1
 * Contact: support@apideck.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Apideck.Client.OpenAPIDateConverter;

namespace Apideck.Model
{
    /// <summary>
    /// EcommerceOrder
    /// </summary>
    [DataContract(Name = "EcommerceOrder")]
    public partial class EcommerceOrder : IEquatable<EcommerceOrder>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public Currency? Currency { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public EcommerceOrderStatus? Status { get; set; }
        /// <summary>
        /// Current payment status of the order.
        /// </summary>
        /// <value>Current payment status of the order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentStatusEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Authorized for value: authorized
            /// </summary>
            [EnumMember(Value = "authorized")]
            Authorized = 2,

            /// <summary>
            /// Enum Paid for value: paid
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid = 3,

            /// <summary>
            /// Enum Partial for value: partial
            /// </summary>
            [EnumMember(Value = "partial")]
            Partial = 4,

            /// <summary>
            /// Enum Refunded for value: refunded
            /// </summary>
            [EnumMember(Value = "refunded")]
            Refunded = 5,

            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 6,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 7

        }


        /// <summary>
        /// Current payment status of the order.
        /// </summary>
        /// <value>Current payment status of the order.</value>
        [DataMember(Name = "payment_status", EmitDefaultValue = true)]
        public PaymentStatusEnum? PaymentStatus { get; set; }
        /// <summary>
        /// Current fulfillment status of the order.
        /// </summary>
        /// <value>Current fulfillment status of the order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FulfillmentStatusEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Shipped for value: shipped
            /// </summary>
            [EnumMember(Value = "shipped")]
            Shipped = 2,

            /// <summary>
            /// Enum Partial for value: partial
            /// </summary>
            [EnumMember(Value = "partial")]
            Partial = 3,

            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 4,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 5,

            /// <summary>
            /// Enum Returned for value: returned
            /// </summary>
            [EnumMember(Value = "returned")]
            Returned = 6,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 7

        }


        /// <summary>
        /// Current fulfillment status of the order.
        /// </summary>
        /// <value>Current fulfillment status of the order.</value>
        [DataMember(Name = "fulfillment_status", EmitDefaultValue = true)]
        public FulfillmentStatusEnum? FulfillmentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EcommerceOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceOrder" /> class.
        /// </summary>
        /// <param name="orderNumber">Order number, if any..</param>
        /// <param name="currency">currency.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="subTotal">Sub-total amount, normally before tax..</param>
        /// <param name="shippingCost">Shipping cost, if any..</param>
        /// <param name="couponDiscount">Coupon discount, if any..</param>
        /// <param name="totalDiscount">Total discount, if any..</param>
        /// <param name="totalTax">Total tax, if any..</param>
        /// <param name="totalAmount">Total amount due..</param>
        /// <param name="refundedAmount">Refunded amount, if any..</param>
        /// <param name="status">status.</param>
        /// <param name="paymentStatus">Current payment status of the order..</param>
        /// <param name="fulfillmentStatus">Current fulfillment status of the order..</param>
        /// <param name="paymentMethod">Payment method used for this order..</param>
        /// <param name="customer">customer.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="tracking">tracking.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="note">Note for the order..</param>
        public EcommerceOrder(string orderNumber = default(string), Currency? currency = default(Currency?), List<EcommerceDiscount> discounts = default(List<EcommerceDiscount>), string subTotal = default(string), string shippingCost = default(string), string couponDiscount = default(string), string totalDiscount = default(string), string totalTax = default(string), string totalAmount = default(string), string refundedAmount = default(string), EcommerceOrderStatus? status = default(EcommerceOrderStatus?), PaymentStatusEnum? paymentStatus = default(PaymentStatusEnum?), FulfillmentStatusEnum? fulfillmentStatus = default(FulfillmentStatusEnum?), string paymentMethod = default(string), LinkedEcommerceCustomer customer = default(LinkedEcommerceCustomer), EcommerceAddress billingAddress = default(EcommerceAddress), EcommerceAddress shippingAddress = default(EcommerceAddress), List<TrackingItem> tracking = default(List<TrackingItem>), List<EcommerceOrderLineItem> lineItems = default(List<EcommerceOrderLineItem>), string note = default(string))
        {
            this.OrderNumber = orderNumber;
            this.Currency = currency;
            this.Discounts = discounts;
            this.SubTotal = subTotal;
            this.ShippingCost = shippingCost;
            this.CouponDiscount = couponDiscount;
            this.TotalDiscount = totalDiscount;
            this.TotalTax = totalTax;
            this.TotalAmount = totalAmount;
            this.RefundedAmount = refundedAmount;
            this.Status = status;
            this.PaymentStatus = paymentStatus;
            this.FulfillmentStatus = fulfillmentStatus;
            this.PaymentMethod = paymentMethod;
            this.Customer = customer;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.Tracking = tracking;
            this.LineItems = lineItems;
            this.Note = note;
        }

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        /// <value>A unique identifier for an object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Order number, if any.
        /// </summary>
        /// <value>Order number, if any.</value>
        [DataMember(Name = "order_number", EmitDefaultValue = true)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name = "discounts", EmitDefaultValue = false)]
        public List<EcommerceDiscount> Discounts { get; set; }

        /// <summary>
        /// Sub-total amount, normally before tax.
        /// </summary>
        /// <value>Sub-total amount, normally before tax.</value>
        [DataMember(Name = "sub_total", EmitDefaultValue = true)]
        public string SubTotal { get; set; }

        /// <summary>
        /// Shipping cost, if any.
        /// </summary>
        /// <value>Shipping cost, if any.</value>
        [DataMember(Name = "shipping_cost", EmitDefaultValue = true)]
        public string ShippingCost { get; set; }

        /// <summary>
        /// Coupon discount, if any.
        /// </summary>
        /// <value>Coupon discount, if any.</value>
        [DataMember(Name = "coupon_discount", EmitDefaultValue = true)]
        public string CouponDiscount { get; set; }

        /// <summary>
        /// Total discount, if any.
        /// </summary>
        /// <value>Total discount, if any.</value>
        [DataMember(Name = "total_discount", EmitDefaultValue = true)]
        public string TotalDiscount { get; set; }

        /// <summary>
        /// Total tax, if any.
        /// </summary>
        /// <value>Total tax, if any.</value>
        [DataMember(Name = "total_tax", EmitDefaultValue = true)]
        public string TotalTax { get; set; }

        /// <summary>
        /// Total amount due.
        /// </summary>
        /// <value>Total amount due.</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = true)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Refunded amount, if any.
        /// </summary>
        /// <value>Refunded amount, if any.</value>
        [DataMember(Name = "refunded_amount", EmitDefaultValue = true)]
        public string RefundedAmount { get; set; }

        /// <summary>
        /// Payment method used for this order.
        /// </summary>
        /// <value>Payment method used for this order.</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public LinkedEcommerceCustomer Customer { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billing_address", EmitDefaultValue = false)]
        public EcommerceAddress BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public EcommerceAddress ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Tracking
        /// </summary>
        [DataMember(Name = "tracking", EmitDefaultValue = false)]
        public List<TrackingItem> Tracking { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<EcommerceOrderLineItem> LineItems { get; set; }

        /// <summary>
        /// Note for the order.
        /// </summary>
        /// <value>Note for the order.</value>
        [DataMember(Name = "note", EmitDefaultValue = true)]
        public string Note { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        /// <value>When custom mappings are configured on the resource, the result is included here.</value>
        [DataMember(Name = "custom_mappings", EmitDefaultValue = true)]
        public Object CustomMappings { get; private set; }

        /// <summary>
        /// Returns false as CustomMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomMappings()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        /// <value>The date and time when the object was last updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcommerceOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  ShippingCost: ").Append(ShippingCost).Append("\n");
            sb.Append("  CouponDiscount: ").Append(CouponDiscount).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  FulfillmentStatus: ").Append(FulfillmentStatus).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  Tracking: ").Append(Tracking).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CustomMappings: ").Append(CustomMappings).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EcommerceOrder);
        }

        /// <summary>
        /// Returns true if EcommerceOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of EcommerceOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcommerceOrder input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrderNumber == input.OrderNumber ||
                    (this.OrderNumber != null &&
                    this.OrderNumber.Equals(input.OrderNumber))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Discounts == input.Discounts ||
                    this.Discounts != null &&
                    input.Discounts != null &&
                    this.Discounts.SequenceEqual(input.Discounts)
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    (this.SubTotal != null &&
                    this.SubTotal.Equals(input.SubTotal))
                ) && 
                (
                    this.ShippingCost == input.ShippingCost ||
                    (this.ShippingCost != null &&
                    this.ShippingCost.Equals(input.ShippingCost))
                ) && 
                (
                    this.CouponDiscount == input.CouponDiscount ||
                    (this.CouponDiscount != null &&
                    this.CouponDiscount.Equals(input.CouponDiscount))
                ) && 
                (
                    this.TotalDiscount == input.TotalDiscount ||
                    (this.TotalDiscount != null &&
                    this.TotalDiscount.Equals(input.TotalDiscount))
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    (this.TotalTax != null &&
                    this.TotalTax.Equals(input.TotalTax))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.RefundedAmount == input.RefundedAmount ||
                    (this.RefundedAmount != null &&
                    this.RefundedAmount.Equals(input.RefundedAmount))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    this.PaymentStatus.Equals(input.PaymentStatus)
                ) && 
                (
                    this.FulfillmentStatus == input.FulfillmentStatus ||
                    this.FulfillmentStatus.Equals(input.FulfillmentStatus)
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.Tracking == input.Tracking ||
                    this.Tracking != null &&
                    input.Tracking != null &&
                    this.Tracking.SequenceEqual(input.Tracking)
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.CustomMappings == input.CustomMappings ||
                    (this.CustomMappings != null &&
                    this.CustomMappings.Equals(input.CustomMappings))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.OrderNumber != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.Discounts != null)
                {
                    hashCode = (hashCode * 59) + this.Discounts.GetHashCode();
                }
                if (this.SubTotal != null)
                {
                    hashCode = (hashCode * 59) + this.SubTotal.GetHashCode();
                }
                if (this.ShippingCost != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingCost.GetHashCode();
                }
                if (this.CouponDiscount != null)
                {
                    hashCode = (hashCode * 59) + this.CouponDiscount.GetHashCode();
                }
                if (this.TotalDiscount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalDiscount.GetHashCode();
                }
                if (this.TotalTax != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTax.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.RefundedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundedAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.FulfillmentStatus.GetHashCode();
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingAddress.GetHashCode();
                }
                if (this.Tracking != null)
                {
                    hashCode = (hashCode * 59) + this.Tracking.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                if (this.CustomMappings != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMappings.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
