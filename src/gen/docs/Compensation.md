# Apideck.Model.Compensation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeId** | **string** |  | [readonly] 
**NetPay** | **decimal** | The employee&#39;s net pay. Only available when payroll has been processed | [optional] 
**GrossPay** | **decimal** | The employee&#39;s gross pay. Only available when payroll has been processed | [optional] 
**Taxes** | [**List&lt;Tax&gt;**](Tax.md) | An array of employer and employee taxes for the pay period. | [optional] 
**Deductions** | [**List&lt;Deduction&gt;**](Deduction.md) | An array of employee deductions for the pay period. | [optional] 
**Benefits** | [**List&lt;Benefit&gt;**](Benefit.md) | An array of employee benefits for the pay period. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

