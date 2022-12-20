# Apideck.Api.ConnectorApi

All URIs are relative to *https://unify.apideck.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiResourceCoverageOne**](ConnectorApi.md#apiresourcecoverageone) | **GET** /connector/apis/{id}/resources/{resource_id}/coverage | Get API Resource Coverage
[**ApiResourcesOne**](ConnectorApi.md#apiresourcesone) | **GET** /connector/apis/{id}/resources/{resource_id} | Get API Resource
[**ApisAll**](ConnectorApi.md#apisall) | **GET** /connector/apis | List APIs
[**ApisOne**](ConnectorApi.md#apisone) | **GET** /connector/apis/{id} | Get API
[**ConnectorDocsOne**](ConnectorApi.md#connectordocsone) | **GET** /connector/connectors/{id}/docs/{doc_id} | Get Connector Doc content
[**ConnectorResourcesOne**](ConnectorApi.md#connectorresourcesone) | **GET** /connector/connectors/{id}/resources/{resource_id} | Get Connector Resource
[**ConnectorsAll**](ConnectorApi.md#connectorsall) | **GET** /connector/connectors | List Connectors
[**ConnectorsOne**](ConnectorApi.md#connectorsone) | **GET** /connector/connectors/{id} | Get Connector


<a name="apiresourcecoverageone"></a>
# **ApiResourceCoverageOne**
> GetApiResourceCoverageResponse ApiResourceCoverageOne (string id, string resourceId, string appId = null)

Get API Resource Coverage

Get API Resource Coverage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ApiResourceCoverageOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConnectorApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var resourceId = "resourceId_example";  // string | ID of the resource you are acting upon.
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Get API Resource Coverage
                GetApiResourceCoverageResponse result = apiInstance.ApiResourceCoverageOne(id, resourceId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.ApiResourceCoverageOne: " + e.Message );
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
 **resourceId** | **string**| ID of the resource you are acting upon. | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetApiResourceCoverageResponse**](GetApiResourceCoverageResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ApiResources |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiresourcesone"></a>
# **ApiResourcesOne**
> GetApiResourceResponse ApiResourcesOne (string id, string resourceId, string appId = null)

Get API Resource

Get API Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ApiResourcesOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConnectorApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var resourceId = "resourceId_example";  // string | ID of the resource you are acting upon.
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Get API Resource
                GetApiResourceResponse result = apiInstance.ApiResourcesOne(id, resourceId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.ApiResourcesOne: " + e.Message );
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
 **resourceId** | **string**| ID of the resource you are acting upon. | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetApiResourceResponse**](GetApiResourceResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ApiResources |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisall"></a>
# **ApisAll**
> GetApisResponse ApisAll (string appId = null, string cursor = null, int? limit = null, ApisFilter filter = null)

List APIs

List APIs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ApisAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConnectorApi(config);
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var filter = new ApisFilter(); // ApisFilter | Apply filters (optional) 

            try
            {
                // List APIs
                GetApisResponse result = apiInstance.ApisAll(appId, cursor, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.ApisAll: " + e.Message );
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
 **filter** | [**ApisFilter**](ApisFilter.md)| Apply filters | [optional] 

### Return type

[**GetApisResponse**](GetApisResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Apis |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisone"></a>
# **ApisOne**
> GetApiResponse ApisOne (string id, string appId = null)

Get API

Get API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ApisOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConnectorApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Get API
                GetApiResponse result = apiInstance.ApisOne(id, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.ApisOne: " + e.Message );
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
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetApiResponse**](GetApiResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Apis |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectordocsone"></a>
# **ConnectorDocsOne**
> string ConnectorDocsOne (string id, string docId, string appId = null)

Get Connector Doc content

Get Connector Doc content

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectorDocsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConnectorApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var docId = "docId_example";  // string | ID of the Doc
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Get Connector Doc content
                string result = apiInstance.ConnectorDocsOne(id, docId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.ConnectorDocsOne: " + e.Message );
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
 **docId** | **string**| ID of the Doc | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

**string**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/markdown, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connectors |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectorresourcesone"></a>
# **ConnectorResourcesOne**
> GetConnectorResourceResponse ConnectorResourcesOne (string id, string resourceId, string appId = null, UnifiedApiId? unifiedApi = null)

Get Connector Resource

Get Connector Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectorResourcesOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConnectorApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var resourceId = "resourceId_example";  // string | ID of the resource you are acting upon.
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var unifiedApi = (UnifiedApiId) "vault";  // UnifiedApiId? | Specify unified API for the connector resource. This is useful when a resource appears in multiple APIs (optional) 

            try
            {
                // Get Connector Resource
                GetConnectorResourceResponse result = apiInstance.ConnectorResourcesOne(id, resourceId, appId, unifiedApi);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.ConnectorResourcesOne: " + e.Message );
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
 **resourceId** | **string**| ID of the resource you are acting upon. | 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **unifiedApi** | **UnifiedApiId?**| Specify unified API for the connector resource. This is useful when a resource appears in multiple APIs | [optional] 

### Return type

[**GetConnectorResourceResponse**](GetConnectorResourceResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ConnectorResources |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectorsall"></a>
# **ConnectorsAll**
> GetConnectorsResponse ConnectorsAll (string appId = null, string cursor = null, int? limit = null, ConnectorsFilter filter = null)

List Connectors

List Connectors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectorsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConnectorApi(config);
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var filter = new ConnectorsFilter(); // ConnectorsFilter | Apply filters (optional) 

            try
            {
                // List Connectors
                GetConnectorsResponse result = apiInstance.ConnectorsAll(appId, cursor, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.ConnectorsAll: " + e.Message );
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
 **filter** | [**ConnectorsFilter**](ConnectorsFilter.md)| Apply filters | [optional] 

### Return type

[**GetConnectorsResponse**](GetConnectorsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connectors |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectorsone"></a>
# **ConnectorsOne**
> GetConnectorResponse ConnectorsOne (string id, string appId = null)

Get Connector

Get Connector

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectorsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConnectorApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Get Connector
                GetConnectorResponse result = apiInstance.ConnectorsOne(id, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.ConnectorsOne: " + e.Message );
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
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetConnectorResponse**](GetConnectorResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connectors |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

