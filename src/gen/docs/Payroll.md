# Apideck.Model.Payroll

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [readonly] 
**CompanyId** | **string** |  | [optional] 
**Processed** | **bool** | Whether or not the payroll has been successfully processed. Note that processed payrolls cannot be updated. | 
**ProcessedDate** | **string** | The date the payroll was processed. | [optional] 
**CheckDate** | **string** | The date on which employees will be paid for the payroll. | 
**StartDate** | **string** | The start date, inclusive, of the pay period. | 
**EndDate** | **string** | The end date, inclusive, of the pay period. | 
**Totals** | [**PayrollTotals**](.md) |  | [optional] 
**Compensations** | [**List&lt;Compensation&gt;**](Compensation.md) | An array of compensations for the payroll. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

