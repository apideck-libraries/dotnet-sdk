# Apideck.Api.WebhookApi

All URIs are relative to *https://unify.apideck.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventLogsAll**](WebhookApi.md#eventlogsall) | **GET** /webhook/logs | List event logs
[**WebhooksAdd**](WebhookApi.md#webhooksadd) | **POST** /webhook/webhooks | Create webhook
[**WebhooksAll**](WebhookApi.md#webhooksall) | **GET** /webhook/webhooks | List webhooks
[**WebhooksDelete**](WebhookApi.md#webhooksdelete) | **DELETE** /webhook/webhooks/{id} | Delete webhook
[**WebhooksOne**](WebhookApi.md#webhooksone) | **GET** /webhook/webhooks/{id} | Get webhook
[**WebhooksUpdate**](WebhookApi.md#webhooksupdate) | **PATCH** /webhook/webhooks/{id} | Update webhook


<a name="eventlogsall"></a>
# **EventLogsAll**
> GetWebhookEventLogsResponse EventLogsAll (string appId = null, string cursor = null, int? limit = null, WebhookEventLogsFilter filter = null)

List event logs

List event logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EventLogsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var filter = new WebhookEventLogsFilter(); // WebhookEventLogsFilter | Filter results (optional) 

            try
            {
                // List event logs
                GetWebhookEventLogsResponse result = apiInstance.EventLogsAll(appId, cursor, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.EventLogsAll: " + e.Message );
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
 **appId** | **string**| The ID of your Unify application | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of records to return | [optional] [default to 20]
 **filter** | [**WebhookEventLogsFilter**](WebhookEventLogsFilter.md)| Filter results | [optional] 

### Return type

[**GetWebhookEventLogsResponse**](GetWebhookEventLogsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | EventLogs |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksadd"></a>
# **WebhooksAdd**
> CreateWebhookResponse WebhooksAdd (CreateWebhookRequest createWebhookRequest, string appId = null)

Create webhook

Create a webhook subscription to receive events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class WebhooksAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var createWebhookRequest = new CreateWebhookRequest(); // CreateWebhookRequest | 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 

            try
            {
                // Create webhook
                CreateWebhookResponse result = apiInstance.WebhooksAdd(createWebhookRequest, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksAdd: " + e.Message );
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
 **createWebhookRequest** | [**CreateWebhookRequest**](CreateWebhookRequest.md)|  | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**CreateWebhookResponse**](CreateWebhookResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Webhooks |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksall"></a>
# **WebhooksAll**
> GetWebhooksResponse WebhooksAll (string appId = null, string cursor = null, int? limit = null)

List webhooks

List all webhook subscriptions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class WebhooksAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)

            try
            {
                // List webhooks
                GetWebhooksResponse result = apiInstance.WebhooksAll(appId, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksAll: " + e.Message );
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
 **appId** | **string**| The ID of your Unify application | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of records to return | [optional] [default to 20]

### Return type

[**GetWebhooksResponse**](GetWebhooksResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhooks |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksdelete"></a>
# **WebhooksDelete**
> DeleteWebhookResponse WebhooksDelete (string id, string appId = null)

Delete webhook

Delete a webhook subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class WebhooksDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var id = "id_example";  // string | JWT Webhook token that represents the unifiedApi and applicationId associated to the event source.
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 

            try
            {
                // Delete webhook
                DeleteWebhookResponse result = apiInstance.WebhooksDelete(id, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksDelete: " + e.Message );
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
 **id** | **string**| JWT Webhook token that represents the unifiedApi and applicationId associated to the event source. | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**DeleteWebhookResponse**](DeleteWebhookResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhooks |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksone"></a>
# **WebhooksOne**
> GetWebhookResponse WebhooksOne (string id, string appId = null)

Get webhook

Get the webhook subscription details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class WebhooksOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var id = "id_example";  // string | JWT Webhook token that represents the unifiedApi and applicationId associated to the event source.
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 

            try
            {
                // Get webhook
                GetWebhookResponse result = apiInstance.WebhooksOne(id, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksOne: " + e.Message );
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
 **id** | **string**| JWT Webhook token that represents the unifiedApi and applicationId associated to the event source. | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetWebhookResponse**](GetWebhookResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhooks |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksupdate"></a>
# **WebhooksUpdate**
> UpdateWebhookResponse WebhooksUpdate (string id, UpdateWebhookRequest updateWebhookRequest, string appId = null)

Update webhook

Update a webhook subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class WebhooksUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var id = "id_example";  // string | JWT Webhook token that represents the unifiedApi and applicationId associated to the event source.
            var updateWebhookRequest = new UpdateWebhookRequest(); // UpdateWebhookRequest | 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 

            try
            {
                // Update webhook
                UpdateWebhookResponse result = apiInstance.WebhooksUpdate(id, updateWebhookRequest, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksUpdate: " + e.Message );
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
 **id** | **string**| JWT Webhook token that represents the unifiedApi and applicationId associated to the event source. | 
 **updateWebhookRequest** | [**UpdateWebhookRequest**](UpdateWebhookRequest.md)|  | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**UpdateWebhookResponse**](UpdateWebhookResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhooks |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

