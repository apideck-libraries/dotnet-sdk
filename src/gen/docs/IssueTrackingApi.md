# Apideck.Api.IssueTrackingApi

All URIs are relative to *https://unify.apideck.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CollectionTagsAll**](IssueTrackingApi.md#collectiontagsall) | **GET** /issue-tracking/collections/{collection_id}/tags | List Tags
[**CollectionTicketCommentsAdd**](IssueTrackingApi.md#collectionticketcommentsadd) | **POST** /issue-tracking/collections/{collection_id}/tickets/{ticket_id}/comments | Create Comment
[**CollectionTicketCommentsAll**](IssueTrackingApi.md#collectionticketcommentsall) | **GET** /issue-tracking/collections/{collection_id}/tickets/{ticket_id}/comments | List Comments
[**CollectionTicketCommentsDelete**](IssueTrackingApi.md#collectionticketcommentsdelete) | **DELETE** /issue-tracking/collections/{collection_id}/tickets/{ticket_id}/comments/{id} | Delete Comment
[**CollectionTicketCommentsOne**](IssueTrackingApi.md#collectionticketcommentsone) | **GET** /issue-tracking/collections/{collection_id}/tickets/{ticket_id}/comments/{id} | Get Comment
[**CollectionTicketCommentsUpdate**](IssueTrackingApi.md#collectionticketcommentsupdate) | **PATCH** /issue-tracking/collections/{collection_id}/tickets/{ticket_id}/comments/{id} | Update Comment
[**CollectionTicketsAdd**](IssueTrackingApi.md#collectionticketsadd) | **POST** /issue-tracking/collections/{collection_id}/tickets | Create Ticket
[**CollectionTicketsAll**](IssueTrackingApi.md#collectionticketsall) | **GET** /issue-tracking/collections/{collection_id}/tickets | List Tickets
[**CollectionTicketsDelete**](IssueTrackingApi.md#collectionticketsdelete) | **DELETE** /issue-tracking/collections/{collection_id}/tickets/{ticket_id} | Delete Ticket
[**CollectionTicketsOne**](IssueTrackingApi.md#collectionticketsone) | **GET** /issue-tracking/collections/{collection_id}/tickets/{ticket_id} | Get Ticket
[**CollectionTicketsUpdate**](IssueTrackingApi.md#collectionticketsupdate) | **PATCH** /issue-tracking/collections/{collection_id}/tickets/{ticket_id} | Update Ticket
[**CollectionUsersAll**](IssueTrackingApi.md#collectionusersall) | **GET** /issue-tracking/collections/{collection_id}/users | List Users
[**CollectionUsersOne**](IssueTrackingApi.md#collectionusersone) | **GET** /issue-tracking/collections/{collection_id}/users/{id} | Get user
[**CollectionsAll**](IssueTrackingApi.md#collectionsall) | **GET** /issue-tracking/collections | List Collections
[**CollectionsOne**](IssueTrackingApi.md#collectionsone) | **GET** /issue-tracking/collections/{collection_id} | Get Collection


<a name="collectiontagsall"></a>
# **CollectionTagsAll**
> GetCollectionTagsResponse CollectionTagsAll (string collectionId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, string fields = null)

List Tags

List Tags

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTagsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var collectionId = apideck-io;  // string | The collection ID
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List Tags
                GetCollectionTagsResponse result = apiInstance.CollectionTagsAll(collectionId, raw, consumerId, appId, serviceId, cursor, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTagsAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of records to return | [optional] [default to 20]
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetCollectionTagsResponse**](GetCollectionTagsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Tags |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketcommentsadd"></a>
# **CollectionTicketCommentsAdd**
> CreateCommentResponse CollectionTicketCommentsAdd (string collectionId, string ticketId, CollectionTicketComment collectionTicketComment, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create Comment

Create Comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketCommentsAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var collectionId = apideck-io;  // string | The collection ID
            var ticketId = "ticketId_example";  // string | ID of the ticket you are acting upon.
            var collectionTicketComment = new CollectionTicketComment(); // CollectionTicketComment | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create Comment
                CreateCommentResponse result = apiInstance.CollectionTicketCommentsAdd(collectionId, ticketId, collectionTicketComment, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketCommentsAdd: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID | 
 **ticketId** | **string**| ID of the ticket you are acting upon. | 
 **collectionTicketComment** | [**CollectionTicketComment**](CollectionTicketComment.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateCommentResponse**](CreateCommentResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a Comment |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketcommentsall"></a>
# **CollectionTicketCommentsAll**
> GetCommentsResponse CollectionTicketCommentsAll (string collectionId, string ticketId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, CommentsSort sort = null, string fields = null)

List Comments

List Comments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketCommentsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var collectionId = apideck-io;  // string | The collection ID
            var ticketId = "ticketId_example";  // string | ID of the ticket you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var sort = new CommentsSort(); // CommentsSort | Apply sorting (optional) 
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List Comments
                GetCommentsResponse result = apiInstance.CollectionTicketCommentsAll(collectionId, ticketId, raw, consumerId, appId, serviceId, cursor, limit, sort, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketCommentsAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID | 
 **ticketId** | **string**| ID of the ticket you are acting upon. | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of records to return | [optional] [default to 20]
 **sort** | [**CommentsSort**](CommentsSort.md)| Apply sorting | [optional] 
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetCommentsResponse**](GetCommentsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Comments |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketcommentsdelete"></a>
# **CollectionTicketCommentsDelete**
> DeleteCommentResponse CollectionTicketCommentsDelete (string id, string collectionId, string ticketId, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Comment

Delete Comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketCommentsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var collectionId = apideck-io;  // string | The collection ID
            var ticketId = "ticketId_example";  // string | ID of the ticket you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Comment
                DeleteCommentResponse result = apiInstance.CollectionTicketCommentsDelete(id, collectionId, ticketId, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketCommentsDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the record you are acting upon. | 
 **collectionId** | **string**| The collection ID | 
 **ticketId** | **string**| ID of the ticket you are acting upon. | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**DeleteCommentResponse**](DeleteCommentResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete a Comment |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketcommentsone"></a>
# **CollectionTicketCommentsOne**
> GetCommentResponse CollectionTicketCommentsOne (string id, string collectionId, string ticketId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, string fields = null)

Get Comment

Get Comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketCommentsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var collectionId = apideck-io;  // string | The collection ID
            var ticketId = "ticketId_example";  // string | ID of the ticket you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get Comment
                GetCommentResponse result = apiInstance.CollectionTicketCommentsOne(id, collectionId, ticketId, raw, consumerId, appId, serviceId, cursor, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketCommentsOne: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the record you are acting upon. | 
 **collectionId** | **string**| The collection ID | 
 **ticketId** | **string**| ID of the ticket you are acting upon. | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of records to return | [optional] [default to 20]
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetCommentResponse**](GetCommentResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a Comment |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketcommentsupdate"></a>
# **CollectionTicketCommentsUpdate**
> UpdateCommentResponse CollectionTicketCommentsUpdate (string id, string collectionId, string ticketId, CollectionTicketComment collectionTicketComment, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update Comment

Update Comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketCommentsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var collectionId = apideck-io;  // string | The collection ID
            var ticketId = "ticketId_example";  // string | ID of the ticket you are acting upon.
            var collectionTicketComment = new CollectionTicketComment(); // CollectionTicketComment | 
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update Comment
                UpdateCommentResponse result = apiInstance.CollectionTicketCommentsUpdate(id, collectionId, ticketId, collectionTicketComment, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketCommentsUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the record you are acting upon. | 
 **collectionId** | **string**| The collection ID | 
 **ticketId** | **string**| ID of the ticket you are acting upon. | 
 **collectionTicketComment** | [**CollectionTicketComment**](CollectionTicketComment.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateCommentResponse**](UpdateCommentResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update a Comment |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketsadd"></a>
# **CollectionTicketsAdd**
> CreateTicketResponse CollectionTicketsAdd (string collectionId, Ticket ticket, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create Ticket

Create Ticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketsAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var collectionId = apideck-io;  // string | The collection ID
            var ticket = new Ticket(); // Ticket | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create Ticket
                CreateTicketResponse result = apiInstance.CollectionTicketsAdd(collectionId, ticket, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketsAdd: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID | 
 **ticket** | [**Ticket**](Ticket.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateTicketResponse**](CreateTicketResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a Ticket |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketsall"></a>
# **CollectionTicketsAll**
> GetTicketsResponse CollectionTicketsAll (string collectionId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, TicketsSort sort = null, IssuesFilter filter = null, string fields = null)

List Tickets

List Tickets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var collectionId = apideck-io;  // string | The collection ID
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var sort = new TicketsSort(); // TicketsSort | Apply sorting (optional) 
            var filter = new IssuesFilter(); // IssuesFilter | Apply filters (optional) 
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List Tickets
                GetTicketsResponse result = apiInstance.CollectionTicketsAll(collectionId, raw, consumerId, appId, serviceId, cursor, limit, sort, filter, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketsAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of records to return | [optional] [default to 20]
 **sort** | [**TicketsSort**](TicketsSort.md)| Apply sorting | [optional] 
 **filter** | [**IssuesFilter**](IssuesFilter.md)| Apply filters | [optional] 
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetTicketsResponse**](GetTicketsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Tickets |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketsdelete"></a>
# **CollectionTicketsDelete**
> DeleteTicketResponse CollectionTicketsDelete (string ticketId, string collectionId, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Ticket

Delete Ticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var ticketId = "ticketId_example";  // string | ID of the ticket you are acting upon.
            var collectionId = apideck-io;  // string | The collection ID
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Ticket
                DeleteTicketResponse result = apiInstance.CollectionTicketsDelete(ticketId, collectionId, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketsDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticketId** | **string**| ID of the ticket you are acting upon. | 
 **collectionId** | **string**| The collection ID | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**DeleteTicketResponse**](DeleteTicketResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete a Ticket |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketsone"></a>
# **CollectionTicketsOne**
> GetTicketResponse CollectionTicketsOne (string ticketId, string collectionId, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get Ticket

Get Ticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var ticketId = "ticketId_example";  // string | ID of the ticket you are acting upon.
            var collectionId = apideck-io;  // string | The collection ID
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get Ticket
                GetTicketResponse result = apiInstance.CollectionTicketsOne(ticketId, collectionId, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketsOne: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticketId** | **string**| ID of the ticket you are acting upon. | 
 **collectionId** | **string**| The collection ID | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetTicketResponse**](GetTicketResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a Ticket |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionticketsupdate"></a>
# **CollectionTicketsUpdate**
> UpdateTicketResponse CollectionTicketsUpdate (string ticketId, string collectionId, Ticket ticket, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update Ticket

Update Ticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionTicketsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var ticketId = "ticketId_example";  // string | ID of the ticket you are acting upon.
            var collectionId = apideck-io;  // string | The collection ID
            var ticket = new Ticket(); // Ticket | 
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update Ticket
                UpdateTicketResponse result = apiInstance.CollectionTicketsUpdate(ticketId, collectionId, ticket, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionTicketsUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticketId** | **string**| ID of the ticket you are acting upon. | 
 **collectionId** | **string**| The collection ID | 
 **ticket** | [**Ticket**](Ticket.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateTicketResponse**](UpdateTicketResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update a Ticket |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionusersall"></a>
# **CollectionUsersAll**
> GetCollectionUsersResponse CollectionUsersAll (string collectionId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, string fields = null)

List Users

List Users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionUsersAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var collectionId = apideck-io;  // string | The collection ID
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List Users
                GetCollectionUsersResponse result = apiInstance.CollectionUsersAll(collectionId, raw, consumerId, appId, serviceId, cursor, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionUsersAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of records to return | [optional] [default to 20]
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetCollectionUsersResponse**](GetCollectionUsersResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Users |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionusersone"></a>
# **CollectionUsersOne**
> GetCollectionUserResponse CollectionUsersOne (string collectionId, string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get user

Get user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionUsersOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var collectionId = apideck-io;  // string | The collection ID
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get user
                GetCollectionUserResponse result = apiInstance.CollectionUsersOne(collectionId, id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionUsersOne: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID | 
 **id** | **string**| ID of the record you are acting upon. | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetCollectionUserResponse**](GetCollectionUserResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionsall"></a>
# **CollectionsAll**
> GetCollectionsResponse CollectionsAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, CollectionsSort sort = null, string fields = null)

List Collections

List Collections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var sort = new CollectionsSort(); // CollectionsSort | Apply sorting (optional) 
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List Collections
                GetCollectionsResponse result = apiInstance.CollectionsAll(raw, consumerId, appId, serviceId, cursor, limit, sort, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionsAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of records to return | [optional] [default to 20]
 **sort** | [**CollectionsSort**](CollectionsSort.md)| Apply sorting | [optional] 
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetCollectionsResponse**](GetCollectionsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Collections |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectionsone"></a>
# **CollectionsOne**
> GetCollectionResponse CollectionsOne (string collectionId, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get Collection

Get Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CollectionsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssueTrackingApi(config);
            var collectionId = apideck-io;  // string | The collection ID
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get Collection
                GetCollectionResponse result = apiInstance.CollectionsOne(collectionId, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueTrackingApi.CollectionsOne: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetCollectionResponse**](GetCollectionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a Collection |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

