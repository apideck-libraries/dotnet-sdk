# Apideck.Model.AgedDebtors

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReportGeneratedAt** | **DateTime** | The exact date and time the report was generated. | [optional] 
**ReportAsOfDate** | **DateTime** | The cutoff date for transactions included in the report. | [optional] 
**PeriodCount** | **int** | Number of aging periods shown in the report. | [optional] [default to 4]
**PeriodLength** | **int** | Length of each aging period in days. | [optional] [default to 30]
**OutstandingBalances** | [**List&lt;OutstandingBalance&gt;**](OutstandingBalance.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

