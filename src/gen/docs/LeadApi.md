# Apideck.Api.LeadApi

All URIs are relative to *https://unify.apideck.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadsAdd**](LeadApi.md#leadsadd) | **POST** /lead/leads | Create lead
[**LeadsAll**](LeadApi.md#leadsall) | **GET** /lead/leads | List leads
[**LeadsDelete**](LeadApi.md#leadsdelete) | **DELETE** /lead/leads/{id} | Delete lead
[**LeadsOne**](LeadApi.md#leadsone) | **GET** /lead/leads/{id} | Get lead
[**LeadsUpdate**](LeadApi.md#leadsupdate) | **PATCH** /lead/leads/{id} | Update lead


<a name="leadsadd"></a>
# **LeadsAdd**
> CreateLeadResponse LeadsAdd (Lead lead, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create lead

Create lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class LeadsAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LeadApi(config);
            var lead = new Lead(); // Lead | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create lead
                CreateLeadResponse result = apiInstance.LeadsAdd(lead, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadApi.LeadsAdd: " + e.Message );
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
 **lead** | [**Lead**](Lead.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateLeadResponse**](CreateLeadResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Lead created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsall"></a>
# **LeadsAll**
> GetLeadsResponse LeadsAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, LeadsFilter filter = null, LeadsSort sort = null, string fields = null)

List leads

List leads

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class LeadsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LeadApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var filter = new LeadsFilter(); // LeadsFilter | Apply filters (optional) 
            var sort = new LeadsSort(); // LeadsSort | Apply sorting (optional) 
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List leads
                GetLeadsResponse result = apiInstance.LeadsAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadApi.LeadsAll: " + e.Message );
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
 **filter** | [**LeadsFilter**](LeadsFilter.md)| Apply filters | [optional] 
 **sort** | [**LeadsSort**](LeadsSort.md)| Apply sorting | [optional] 
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetLeadsResponse**](GetLeadsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Leads |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsdelete"></a>
# **LeadsDelete**
> DeleteLeadResponse LeadsDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete lead

Delete lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class LeadsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LeadApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete lead
                DeleteLeadResponse result = apiInstance.LeadsDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadApi.LeadsDelete: " + e.Message );
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

[**DeleteLeadResponse**](DeleteLeadResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lead deleted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsone"></a>
# **LeadsOne**
> GetLeadResponse LeadsOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get lead

Get lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class LeadsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LeadApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields=name,age,email    In the example above, the API will only include the fields \"name\", \"age\", and \"email\" in the response. If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get lead
                GetLeadResponse result = apiInstance.LeadsOne(id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadApi.LeadsOne: " + e.Message );
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
 **fields** | **string**| This parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response.   Example: unify_fields&#x3D;name,age,email    In the example above, the API will only include the fields \&quot;name\&quot;, \&quot;age\&quot;, and \&quot;email\&quot; in the response. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetLeadResponse**](GetLeadResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lead |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsupdate"></a>
# **LeadsUpdate**
> UpdateLeadResponse LeadsUpdate (string id, Lead lead, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update lead

Update lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class LeadsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LeadApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var lead = new Lead(); // Lead | 
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update lead
                UpdateLeadResponse result = apiInstance.LeadsUpdate(id, lead, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadApi.LeadsUpdate: " + e.Message );
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
 **lead** | [**Lead**](Lead.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateLeadResponse**](UpdateLeadResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lead updated |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

