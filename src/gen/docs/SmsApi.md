# Apideck.Api.SmsApi

All URIs are relative to *https://unify.apideck.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MessagesAdd**](SmsApi.md#messagesadd) | **POST** /sms/messages | Create Message
[**MessagesAll**](SmsApi.md#messagesall) | **GET** /sms/messages | List Messages
[**MessagesDelete**](SmsApi.md#messagesdelete) | **DELETE** /sms/messages/{id} | Delete Message
[**MessagesOne**](SmsApi.md#messagesone) | **GET** /sms/messages/{id} | Get Message
[**MessagesUpdate**](SmsApi.md#messagesupdate) | **PATCH** /sms/messages/{id} | Update Message


<a name="messagesadd"></a>
# **MessagesAdd**
> CreateMessageResponse MessagesAdd (Message message, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create Message

Create Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class MessagesAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SmsApi(config);
            var message = new Message(); // Message | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create Message
                CreateMessageResponse result = apiInstance.MessagesAdd(message, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.MessagesAdd: " + e.Message );
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
 **message** | [**Message**](Message.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateMessageResponse**](CreateMessageResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Messages |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="messagesall"></a>
# **MessagesAll**
> GetMessagesResponse MessagesAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, string fields = null)

List Messages

List Messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class MessagesAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SmsApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of results to return. Minimum 1, Maximum 200, Default 20 (optional)  (default to 20)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List Messages
                GetMessagesResponse result = apiInstance.MessagesAll(raw, consumerId, appId, serviceId, cursor, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.MessagesAll: " + e.Message );
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
 **limit** | **int?**| Number of results to return. Minimum 1, Maximum 200, Default 20 | [optional] [default to 20]
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetMessagesResponse**](GetMessagesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Messages |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="messagesdelete"></a>
# **MessagesDelete**
> DeleteMessageResponse MessagesDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Message

Delete Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class MessagesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SmsApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Message
                DeleteMessageResponse result = apiInstance.MessagesDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.MessagesDelete: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**DeleteMessageResponse**](DeleteMessageResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Messages |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="messagesone"></a>
# **MessagesOne**
> GetMessageResponse MessagesOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get Message

Get Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class MessagesOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SmsApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get Message
                GetMessageResponse result = apiInstance.MessagesOne(id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.MessagesOne: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetMessageResponse**](GetMessageResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Messages |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="messagesupdate"></a>
# **MessagesUpdate**
> UpdateMessageResponse MessagesUpdate (string id, Message message, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update Message

Update Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class MessagesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SmsApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var message = new Message(); // Message | 
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update Message
                UpdateMessageResponse result = apiInstance.MessagesUpdate(id, message, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.MessagesUpdate: " + e.Message );
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
 **message** | [**Message**](Message.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateMessageResponse**](UpdateMessageResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Messages |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

