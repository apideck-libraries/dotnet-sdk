# Apideck.Api.VaultApi

All URIs are relative to *https://unify.apideck.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConnectionCustomMappingsAll**](VaultApi.md#connectioncustommappingsall) | **GET** /vault/connections/{unified_api}/{service_id}/{resource}/custom-mappings | List connection custom mappings
[**ConnectionSettingsAll**](VaultApi.md#connectionsettingsall) | **GET** /vault/connections/{unified_api}/{service_id}/{resource}/config | Get resource settings
[**ConnectionSettingsUpdate**](VaultApi.md#connectionsettingsupdate) | **PATCH** /vault/connections/{unified_api}/{service_id}/{resource}/config | Update settings
[**ConnectionsAll**](VaultApi.md#connectionsall) | **GET** /vault/connections | Get all connections
[**ConnectionsDelete**](VaultApi.md#connectionsdelete) | **DELETE** /vault/connections/{unified_api}/{service_id} | Deletes a connection
[**ConnectionsImport**](VaultApi.md#connectionsimport) | **POST** /vault/connections/{unified_api}/{service_id}/import | Import connection
[**ConnectionsOne**](VaultApi.md#connectionsone) | **GET** /vault/connections/{unified_api}/{service_id} | Get connection
[**ConnectionsToken**](VaultApi.md#connectionstoken) | **POST** /vault/connections/{unified_api}/{service_id}/token | Authorize Access Token
[**ConnectionsUpdate**](VaultApi.md#connectionsupdate) | **PATCH** /vault/connections/{unified_api}/{service_id} | Update connection
[**ConsumerRequestCountsAll**](VaultApi.md#consumerrequestcountsall) | **GET** /vault/consumers/{consumer_id}/stats | Consumer request counts
[**ConsumersAdd**](VaultApi.md#consumersadd) | **POST** /vault/consumers | Create consumer
[**ConsumersAll**](VaultApi.md#consumersall) | **GET** /vault/consumers | Get all consumers
[**ConsumersDelete**](VaultApi.md#consumersdelete) | **DELETE** /vault/consumers/{consumer_id} | Delete consumer
[**ConsumersOne**](VaultApi.md#consumersone) | **GET** /vault/consumers/{consumer_id} | Get consumer
[**ConsumersUpdate**](VaultApi.md#consumersupdate) | **PATCH** /vault/consumers/{consumer_id} | Update consumer
[**CreateCallbackState**](VaultApi.md#createcallbackstate) | **POST** /vault/connections/{unified_api}/{service_id}/callback-state | Create Callback State
[**CustomFieldsAll**](VaultApi.md#customfieldsall) | **GET** /vault/connections/{unified_api}/{service_id}/{resource}/custom-fields | Get resource custom fields
[**CustomMappingsAll**](VaultApi.md#custommappingsall) | **GET** /vault/custom-mappings/{unified_api}/{service_id} | List custom mappings
[**LogsAll**](VaultApi.md#logsall) | **GET** /vault/logs | Get all consumer request logs
[**SessionsCreate**](VaultApi.md#sessionscreate) | **POST** /vault/sessions | Create Session
[**ValidateConnectionState**](VaultApi.md#validateconnectionstate) | **POST** /vault/connections/{unified_api}/{service_id}/validate | Validate Connection State


<a name="connectioncustommappingsall"></a>
# **ConnectionCustomMappingsAll**
> GetCustomMappingsResponse ConnectionCustomMappingsAll (string unifiedApi, string serviceId, string resource, string consumerId = null, string appId = null, string resourceId = null)

List connection custom mappings

This endpoint returns a list of custom mappings for a connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionCustomMappingsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var unifiedApi = crm;  // string | Unified API
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var resource = leads;  // string | Name of the resource (plural)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var resourceId = 1234;  // string | This is the id of the resource you want to fetch when listing custom fields. For example, if you want to fetch custom fields for a specific contact, you would use the contact id. (optional) 

            try
            {
                // List connection custom mappings
                GetCustomMappingsResponse result = apiInstance.ConnectionCustomMappingsAll(unifiedApi, serviceId, resource, consumerId, appId, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionCustomMappingsAll: " + e.Message );
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
 **unifiedApi** | **string**| Unified API | 
 **serviceId** | **string**| Service ID of the resource to return | 
 **resource** | **string**| Name of the resource (plural) | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **resourceId** | **string**| This is the id of the resource you want to fetch when listing custom fields. For example, if you want to fetch custom fields for a specific contact, you would use the contact id. | [optional] 

### Return type

[**GetCustomMappingsResponse**](GetCustomMappingsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom mapping |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectionsettingsall"></a>
# **ConnectionSettingsAll**
> GetConnectionResponse ConnectionSettingsAll (string unifiedApi, string serviceId, string resource, string consumerId = null, string appId = null)

Get resource settings

This endpoint returns custom settings and their defaults required by connection for a given resource. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionSettingsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var unifiedApi = crm;  // string | Unified API
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var resource = leads;  // string | Name of the resource (plural)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Get resource settings
                GetConnectionResponse result = apiInstance.ConnectionSettingsAll(unifiedApi, serviceId, resource, consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionSettingsAll: " + e.Message );
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
 **unifiedApi** | **string**| Unified API | 
 **serviceId** | **string**| Service ID of the resource to return | 
 **resource** | **string**| Name of the resource (plural) | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetConnectionResponse**](GetConnectionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connection |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectionsettingsupdate"></a>
# **ConnectionSettingsUpdate**
> UpdateConnectionResponse ConnectionSettingsUpdate (string serviceId, string unifiedApi, string resource, Connection connection, string consumerId = null, string appId = null)

Update settings

Update default values for a connection's resource settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionSettingsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var unifiedApi = crm;  // string | Unified API
            var resource = leads;  // string | Name of the resource (plural)
            var connection = new Connection(); // Connection | Fields that need to be updated on the resource
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Update settings
                UpdateConnectionResponse result = apiInstance.ConnectionSettingsUpdate(serviceId, unifiedApi, resource, connection, consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionSettingsUpdate: " + e.Message );
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
 **serviceId** | **string**| Service ID of the resource to return | 
 **unifiedApi** | **string**| Unified API | 
 **resource** | **string**| Name of the resource (plural) | 
 **connection** | [**Connection**](Connection.md)| Fields that need to be updated on the resource | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**UpdateConnectionResponse**](UpdateConnectionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connection updated |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectionsall"></a>
# **ConnectionsAll**
> GetConnectionsResponse ConnectionsAll (string consumerId = null, string appId = null, string api = null, bool? configured = null)

Get all connections

This endpoint includes all the configured integrations and contains the required assets to build an integrations page where your users can install integrations. OAuth2 supported integrations will contain authorize and revoke links to handle the authentication flows. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var api = crm;  // string | Scope results to Unified API (optional) 
            var configured = true;  // bool? | Scopes results to connections that have been configured or not (optional) 

            try
            {
                // Get all connections
                GetConnectionsResponse result = apiInstance.ConnectionsAll(consumerId, appId, api, configured);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionsAll: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **api** | **string**| Scope results to Unified API | [optional] 
 **configured** | **bool?**| Scopes results to connections that have been configured or not | [optional] 

### Return type

[**GetConnectionsResponse**](GetConnectionsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connections |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectionsdelete"></a>
# **ConnectionsDelete**
> void ConnectionsDelete (string serviceId, string unifiedApi, string consumerId = null, string appId = null)

Deletes a connection

Deletes a connection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var unifiedApi = crm;  // string | Unified API
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Deletes a connection
                apiInstance.ConnectionsDelete(serviceId, unifiedApi, consumerId, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionsDelete: " + e.Message );
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
 **serviceId** | **string**| Service ID of the resource to return | 
 **unifiedApi** | **string**| Unified API | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Resource deleted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectionsimport"></a>
# **ConnectionsImport**
> CreateConnectionResponse ConnectionsImport (string serviceId, string unifiedApi, ConnectionImportData connectionImportData, string consumerId = null, string appId = null)

Import connection

Import an authorized connection. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionsImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var unifiedApi = crm;  // string | Unified API
            var connectionImportData = new ConnectionImportData(); // ConnectionImportData | Fields that need to be persisted on the resource
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Import connection
                CreateConnectionResponse result = apiInstance.ConnectionsImport(serviceId, unifiedApi, connectionImportData, consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionsImport: " + e.Message );
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
 **serviceId** | **string**| Service ID of the resource to return | 
 **unifiedApi** | **string**| Unified API | 
 **connectionImportData** | [**ConnectionImportData**](ConnectionImportData.md)| Fields that need to be persisted on the resource | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**CreateConnectionResponse**](CreateConnectionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connection created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectionsone"></a>
# **ConnectionsOne**
> GetConnectionResponse ConnectionsOne (string serviceId, string unifiedApi, string consumerId = null, string appId = null)

Get connection

Get a connection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var unifiedApi = crm;  // string | Unified API
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Get connection
                GetConnectionResponse result = apiInstance.ConnectionsOne(serviceId, unifiedApi, consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionsOne: " + e.Message );
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
 **serviceId** | **string**| Service ID of the resource to return | 
 **unifiedApi** | **string**| Unified API | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetConnectionResponse**](GetConnectionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connection |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectionstoken"></a>
# **ConnectionsToken**
> GetConnectionResponse ConnectionsToken (string serviceId, string unifiedApi, string consumerId = null, string appId = null, Object body = null)

Authorize Access Token

Triggers exchanging persisted connection credentials for an access token and store it in Vault. Currently supported for connections with the `client_credentials` or `password` OAuth grant type.  Note:   - Do not include any credentials in the request body. This operation does not persist changes, but only triggers the exchange of persisted connection credentials for an access token.   - The access token will not be returned in the response. A 200 response code indicates the authorization was successful and that a valid access token was stored on the connection.   - The access token will be used for subsequent API requests. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionsTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var unifiedApi = crm;  // string | Unified API
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var body = null;  // Object |  (optional) 

            try
            {
                // Authorize Access Token
                GetConnectionResponse result = apiInstance.ConnectionsToken(serviceId, unifiedApi, consumerId, appId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionsToken: " + e.Message );
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
 **serviceId** | **string**| Service ID of the resource to return | 
 **unifiedApi** | **string**| Unified API | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**GetConnectionResponse**](GetConnectionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connection |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectionsupdate"></a>
# **ConnectionsUpdate**
> UpdateConnectionResponse ConnectionsUpdate (string serviceId, string unifiedApi, Connection connection, string consumerId = null, string appId = null)

Update connection

Update a connection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConnectionsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var unifiedApi = crm;  // string | Unified API
            var connection = new Connection(); // Connection | Fields that need to be updated on the resource
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Update connection
                UpdateConnectionResponse result = apiInstance.ConnectionsUpdate(serviceId, unifiedApi, connection, consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConnectionsUpdate: " + e.Message );
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
 **serviceId** | **string**| Service ID of the resource to return | 
 **unifiedApi** | **string**| Unified API | 
 **connection** | [**Connection**](Connection.md)| Fields that need to be updated on the resource | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**UpdateConnectionResponse**](UpdateConnectionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connection updated |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumerrequestcountsall"></a>
# **ConsumerRequestCountsAll**
> ConsumerRequestCountsInDateRangeResponse ConsumerRequestCountsAll (string consumerId, string startDatetime, string endDatetime, string appId = null)

Consumer request counts

Get consumer request counts within a given datetime range. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConsumerRequestCountsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var consumerId = test_user_id;  // string | ID of the consumer to return
            var startDatetime = 2021-05-01T12:00:00.000Z;  // string | Scopes results to requests that happened after datetime
            var endDatetime = 2021-05-30T12:00:00.000Z;  // string | Scopes results to requests that happened before datetime
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Consumer request counts
                ConsumerRequestCountsInDateRangeResponse result = apiInstance.ConsumerRequestCountsAll(consumerId, startDatetime, endDatetime, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConsumerRequestCountsAll: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer to return | 
 **startDatetime** | **string**| Scopes results to requests that happened after datetime | 
 **endDatetime** | **string**| Scopes results to requests that happened before datetime | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**ConsumerRequestCountsInDateRangeResponse**](ConsumerRequestCountsInDateRangeResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumers Request Counts within Date Range |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumersadd"></a>
# **ConsumersAdd**
> CreateConsumerResponse ConsumersAdd (Consumer consumer, string appId = null)

Create consumer

Create a consumer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConsumersAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var consumer = new Consumer(); // Consumer | 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Create consumer
                CreateConsumerResponse result = apiInstance.ConsumersAdd(consumer, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConsumersAdd: " + e.Message );
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
 **consumer** | [**Consumer**](Consumer.md)|  | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**CreateConsumerResponse**](CreateConsumerResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumer created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumersall"></a>
# **ConsumersAll**
> GetConsumersResponse ConsumersAll (string appId = null, string cursor = null, int? limit = null)

Get all consumers

This endpoint includes all application consumers, along with an aggregated count of requests made. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConsumersAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of results to return. Minimum 1, Maximum 200, Default 20 (optional)  (default to 20)

            try
            {
                // Get all consumers
                GetConsumersResponse result = apiInstance.ConsumersAll(appId, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConsumersAll: " + e.Message );
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
 **limit** | **int?**| Number of results to return. Minimum 1, Maximum 200, Default 20 | [optional] [default to 20]

### Return type

[**GetConsumersResponse**](GetConsumersResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumers |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumersdelete"></a>
# **ConsumersDelete**
> DeleteConsumerResponse ConsumersDelete (string consumerId, string appId = null)

Delete consumer

Delete consumer and all their connections, including credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConsumersDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var consumerId = test_user_id;  // string | ID of the consumer to return
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Delete consumer
                DeleteConsumerResponse result = apiInstance.ConsumersDelete(consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConsumersDelete: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer to return | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**DeleteConsumerResponse**](DeleteConsumerResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumer deleted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumersone"></a>
# **ConsumersOne**
> GetConsumerResponse ConsumersOne (string consumerId, string appId = null)

Get consumer

Consumer detail including their aggregated counts with the connections they have authorized. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConsumersOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var consumerId = test_user_id;  // string | ID of the consumer to return
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Get consumer
                GetConsumerResponse result = apiInstance.ConsumersOne(consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConsumersOne: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer to return | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetConsumerResponse**](GetConsumerResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumer |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumersupdate"></a>
# **ConsumersUpdate**
> UpdateConsumerResponse ConsumersUpdate (string consumerId, UpdateConsumerRequest updateConsumerRequest, string appId = null)

Update consumer

Update consumer metadata such as name and email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ConsumersUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var consumerId = test_user_id;  // string | ID of the consumer to return
            var updateConsumerRequest = new UpdateConsumerRequest(); // UpdateConsumerRequest | 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Update consumer
                UpdateConsumerResponse result = apiInstance.ConsumersUpdate(consumerId, updateConsumerRequest, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ConsumersUpdate: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer to return | 
 **updateConsumerRequest** | [**UpdateConsumerRequest**](UpdateConsumerRequest.md)|  | 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**UpdateConsumerResponse**](UpdateConsumerResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumer updated |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcallbackstate"></a>
# **CreateCallbackState**
> CreateCallbackStateResponse CreateCallbackState (string serviceId, string unifiedApi, CreateCallbackStateData createCallbackStateData, string consumerId = null, string appId = null)

Create Callback State

This endpoint creates a callback state that can be used to issue requests to the callback endpoint. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CreateCallbackStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var unifiedApi = crm;  // string | Unified API
            var createCallbackStateData = new CreateCallbackStateData(); // CreateCallbackStateData | Callback state data
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // Create Callback State
                CreateCallbackStateResponse result = apiInstance.CreateCallbackState(serviceId, unifiedApi, createCallbackStateData, consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.CreateCallbackState: " + e.Message );
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
 **serviceId** | **string**| Service ID of the resource to return | 
 **unifiedApi** | **string**| Unified API | 
 **createCallbackStateData** | [**CreateCallbackStateData**](CreateCallbackStateData.md)| Callback state data | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**CreateCallbackStateResponse**](CreateCallbackStateResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Callback state created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customfieldsall"></a>
# **CustomFieldsAll**
> GetCustomFieldsResponse CustomFieldsAll (string unifiedApi, string serviceId, string resource, string consumerId = null, string appId = null, string resourceId = null)

Get resource custom fields

This endpoint returns an custom fields on a connection resource. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CustomFieldsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var unifiedApi = crm;  // string | Unified API
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var resource = leads;  // string | Name of the resource (plural)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var resourceId = 1234;  // string | This is the id of the resource you want to fetch when listing custom fields. For example, if you want to fetch custom fields for a specific contact, you would use the contact id. (optional) 

            try
            {
                // Get resource custom fields
                GetCustomFieldsResponse result = apiInstance.CustomFieldsAll(unifiedApi, serviceId, resource, consumerId, appId, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.CustomFieldsAll: " + e.Message );
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
 **unifiedApi** | **string**| Unified API | 
 **serviceId** | **string**| Service ID of the resource to return | 
 **resource** | **string**| Name of the resource (plural) | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **resourceId** | **string**| This is the id of the resource you want to fetch when listing custom fields. For example, if you want to fetch custom fields for a specific contact, you would use the contact id. | [optional] 

### Return type

[**GetCustomFieldsResponse**](GetCustomFieldsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom mapping |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="custommappingsall"></a>
# **CustomMappingsAll**
> GetCustomMappingsResponse CustomMappingsAll (string unifiedApi, string serviceId, string consumerId = null, string appId = null)

List custom mappings

This endpoint returns a list of custom mappings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CustomMappingsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var unifiedApi = crm;  // string | Unified API
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 

            try
            {
                // List custom mappings
                GetCustomMappingsResponse result = apiInstance.CustomMappingsAll(unifiedApi, serviceId, consumerId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.CustomMappingsAll: " + e.Message );
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
 **unifiedApi** | **string**| Unified API | 
 **serviceId** | **string**| Service ID of the resource to return | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 

### Return type

[**GetCustomMappingsResponse**](GetCustomMappingsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom mapping |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logsall"></a>
# **LogsAll**
> GetLogsResponse LogsAll (string appId = null, string consumerId = null, LogsFilter filter = null, string cursor = null, int? limit = null)

Get all consumer request logs

This endpoint includes all consumer request logs. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class LogsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var filter = new LogsFilter(); // LogsFilter | Filter results (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of results to return. Minimum 1, Maximum 200, Default 20 (optional)  (default to 20)

            try
            {
                // Get all consumer request logs
                GetLogsResponse result = apiInstance.LogsAll(appId, consumerId, filter, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.LogsAll: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **filter** | [**LogsFilter**](LogsFilter.md)| Filter results | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of results to return. Minimum 1, Maximum 200, Default 20 | [optional] [default to 20]

### Return type

[**GetLogsResponse**](GetLogsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Logs |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionscreate"></a>
# **SessionsCreate**
> CreateSessionResponse SessionsCreate (string consumerId = null, string appId = null, Session session = null)

Create Session

Making a POST request to this endpoint will initiate a Hosted Vault session. Redirect the consumer to the returned URL to allow temporary access to manage their integrations and settings.  Note: This is a short lived token that will expire after 1 hour (TTL: 3600). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class SessionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var session = new Session(); // Session | Additional redirect uri and/or consumer metadata (optional) 

            try
            {
                // Create Session
                CreateSessionResponse result = apiInstance.SessionsCreate(consumerId, appId, session);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.SessionsCreate: " + e.Message );
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
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **session** | [**Session**](Session.md)| Additional redirect uri and/or consumer metadata | [optional] 

### Return type

[**CreateSessionResponse**](CreateSessionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validateconnectionstate"></a>
# **ValidateConnectionState**
> ValidateConnectionStateResponse ValidateConnectionState (string serviceId, string unifiedApi, string consumerId = null, string appId = null, Object body = null)

Validate Connection State

This endpoint validates the current state of a given connection. This will perform different checks based on the connection auth type. For basic and apiKey auth types, the presence of required fields is checked. For connectors that implement OAuth2, this operation forces the refresh flow for an access token regardless of its expiry.  Note:   - Do not include any credentials in the request body. This operation does not persist changes, but only triggers the validation of connection state.   - If a refresh token flow was performed and successful, the new access token will then be used for subsequent API requests. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class ValidateConnectionStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VaultApi(config);
            var serviceId = pipedrive;  // string | Service ID of the resource to return
            var unifiedApi = crm;  // string | Unified API
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var body = null;  // Object |  (optional) 

            try
            {
                // Validate Connection State
                ValidateConnectionStateResponse result = apiInstance.ValidateConnectionState(serviceId, unifiedApi, consumerId, appId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.ValidateConnectionState: " + e.Message );
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
 **serviceId** | **string**| Service ID of the resource to return | 
 **unifiedApi** | **string**| Unified API | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**ValidateConnectionStateResponse**](ValidateConnectionStateResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connection access token refreshed |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

