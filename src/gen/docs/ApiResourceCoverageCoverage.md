# Apideck.Model.ApiResourceCoverageCoverage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DownstreamId** | **string** | ID of the resource in the Connector&#39;s API (downstream) | [optional] 
**DownstreamName** | **string** | Name of the resource in the Connector&#39;s API (downstream) | [optional] 
**PaginationSupported** | **bool** | Indicates if pagination (cursor and limit parameters) is supported on the list endpoint of the resource. | [optional] 
**Pagination** | [**PaginationCoverage**](PaginationCoverage.md) |  | [optional] 
**SupportedOperations** | **List&lt;string&gt;** | List of supported operations on the resource. | [optional] 
**SupportedFilters** | **List&lt;string&gt;** | Supported filters on the list endpoint of the resource. | [optional] 
**SupportedSortBy** | **List&lt;string&gt;** | Supported sorting properties on the list endpoint of the resource. | [optional] 
**SupportedFields** | [**List&lt;SupportedProperty&gt;**](SupportedProperty.md) | Supported fields on the detail endpoint. | [optional] 
**SupportedListFields** | [**List&lt;SupportedProperty&gt;**](SupportedProperty.md) | Supported fields on the list endpoint. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

