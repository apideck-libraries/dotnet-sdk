# Apideck.Model.Consumer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsumerId** | **string** | Unique consumer identifier. You can freely choose a consumer ID yourself. Most of the time, this is an ID of your internal data model that represents a user or account in your system (for example account:12345). If the consumer doesn&#39;t exist yet, Vault will upsert a consumer based on your ID. | 
**ApplicationId** | **string** | ID of your Apideck Application | [optional] [readonly] 
**Metadata** | [**ConsumerMetadata**](ConsumerMetadata.md) |  | [optional] 
**Connections** | [**List&lt;ConsumerConnection&gt;**](ConsumerConnection.md) |  | [optional] [readonly] 
**Services** | **List&lt;string&gt;** |  | [optional] [readonly] 
**AggregatedRequestCount** | **decimal** |  | [optional] [readonly] 
**RequestCounts** | [**RequestCountAllocation**](RequestCountAllocation.md) |  | [optional] 
**Created** | **string** |  | [optional] [readonly] 
**Modified** | **string** |  | [optional] [readonly] 
**RequestCountUpdated** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

