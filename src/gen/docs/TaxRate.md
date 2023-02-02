# Apideck.Model.TaxRate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID assigned to identify this tax rate. | [optional] 
**Name** | **string** | Name assigned to identify this tax rate. | [optional] 
**Code** | **string** | Tax code assigned to identify this tax rate. | [optional] 
**Description** | **string** | Description of tax rate | [optional] 
**EffectiveTaxRate** | **decimal?** | Effective tax rate | [optional] 
**TotalTaxRate** | **decimal?** | Not compounded sum of the components of a tax rate | [optional] 
**TaxPayableAccountId** | **string** | Unique identifier for the account for tax collected. | [optional] 
**TaxRemittedAccountId** | **string** | Unique identifier for the account for tax remitted. | [optional] 
**Components** | **List&lt;Object&gt;** |  | [optional] 
**Type** | **string** | Tax type used to indicate the source of tax collected or paid | [optional] 
**ReportTaxType** | **string** | Report Tax type to aggregate tax collected or paid for reporting purposes | [optional] 
**OriginalTaxRateId** | **string** | ID of the original tax rate from which the new tax rate is derived. Helps to understand the relationship between corresponding tax rate entities. | [optional] 
**Status** | **string** | Tax rate status | [optional] 
**RowVersion** | **string** | A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object. | [optional] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

