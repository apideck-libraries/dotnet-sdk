# Apideck.Model.BalanceSheetReports

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for an object. | [optional] [readonly] 
**ReportName** | **string** | The name of the report | [optional] 
**StartDate** | **string** | The start date of the report | [optional] 
**EndDate** | **string** | The start date of the report | 
**Currency** | **Currency** |  | [optional] 
**Assets** | [**BalanceSheetAccount**](BalanceSheetAccount.md) |  | 
**Liabilities** | [**BalanceSheetAccount**](BalanceSheetAccount.md) |  | 
**Equity** | [**BalanceSheetAccount**](BalanceSheetAccount.md) |  | 
**NetAssets** | **decimal** | The net assets of the balance sheet | [optional] 
**CustomMappings** | **Object** | When custom mappings are configured on the resource, the result is included here. | [optional] [readonly] 
**UpdatedBy** | **string** | The user who last updated the object. | [optional] [readonly] 
**CreatedBy** | **string** | The user who created the object. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The date and time when the object was last updated. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The date and time when the object was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

