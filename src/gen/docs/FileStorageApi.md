# Apideck.Api.FileStorageApi

All URIs are relative to *https://unify.apideck.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DriveGroupsAdd**](FileStorageApi.md#drivegroupsadd) | **POST** /file-storage/drive-groups | Create DriveGroup
[**DriveGroupsAll**](FileStorageApi.md#drivegroupsall) | **GET** /file-storage/drive-groups | List DriveGroups
[**DriveGroupsDelete**](FileStorageApi.md#drivegroupsdelete) | **DELETE** /file-storage/drive-groups/{id} | Delete DriveGroup
[**DriveGroupsOne**](FileStorageApi.md#drivegroupsone) | **GET** /file-storage/drive-groups/{id} | Get DriveGroup
[**DriveGroupsUpdate**](FileStorageApi.md#drivegroupsupdate) | **PATCH** /file-storage/drive-groups/{id} | Update DriveGroup
[**DrivesAdd**](FileStorageApi.md#drivesadd) | **POST** /file-storage/drives | Create Drive
[**DrivesAll**](FileStorageApi.md#drivesall) | **GET** /file-storage/drives | List Drives
[**DrivesDelete**](FileStorageApi.md#drivesdelete) | **DELETE** /file-storage/drives/{id} | Delete Drive
[**DrivesOne**](FileStorageApi.md#drivesone) | **GET** /file-storage/drives/{id} | Get Drive
[**DrivesUpdate**](FileStorageApi.md#drivesupdate) | **PATCH** /file-storage/drives/{id} | Update Drive
[**FilesAll**](FileStorageApi.md#filesall) | **GET** /file-storage/files | List Files
[**FilesDelete**](FileStorageApi.md#filesdelete) | **DELETE** /file-storage/files/{id} | Delete File
[**FilesDownload**](FileStorageApi.md#filesdownload) | **GET** /file-storage/files/{id}/download | Download File
[**FilesExport**](FileStorageApi.md#filesexport) | **GET** /file-storage/files/{id}/export | Export File
[**FilesOne**](FileStorageApi.md#filesone) | **GET** /file-storage/files/{id} | Get File
[**FilesSearch**](FileStorageApi.md#filessearch) | **POST** /file-storage/files/search | Search Files
[**FilesUpdate**](FileStorageApi.md#filesupdate) | **PATCH** /file-storage/files/{id} | Rename or move File
[**FoldersAdd**](FileStorageApi.md#foldersadd) | **POST** /file-storage/folders | Create Folder
[**FoldersCopy**](FileStorageApi.md#folderscopy) | **POST** /file-storage/folders/{id}/copy | Copy Folder
[**FoldersDelete**](FileStorageApi.md#foldersdelete) | **DELETE** /file-storage/folders/{id} | Delete Folder
[**FoldersOne**](FileStorageApi.md#foldersone) | **GET** /file-storage/folders/{id} | Get Folder
[**FoldersUpdate**](FileStorageApi.md#foldersupdate) | **PATCH** /file-storage/folders/{id} | Rename or move Folder
[**SharedLinksAdd**](FileStorageApi.md#sharedlinksadd) | **POST** /file-storage/shared-links | Create Shared Link
[**SharedLinksAll**](FileStorageApi.md#sharedlinksall) | **GET** /file-storage/shared-links | List SharedLinks
[**SharedLinksDelete**](FileStorageApi.md#sharedlinksdelete) | **DELETE** /file-storage/shared-links/{id} | Delete Shared Link
[**SharedLinksOne**](FileStorageApi.md#sharedlinksone) | **GET** /file-storage/shared-links/{id} | Get Shared Link
[**SharedLinksUpdate**](FileStorageApi.md#sharedlinksupdate) | **PATCH** /file-storage/shared-links/{id} | Update Shared Link
[**UploadSessionsAdd**](FileStorageApi.md#uploadsessionsadd) | **POST** /file-storage/upload-sessions | Start Upload Session
[**UploadSessionsDelete**](FileStorageApi.md#uploadsessionsdelete) | **DELETE** /file-storage/upload-sessions/{id} | Abort Upload Session
[**UploadSessionsFinish**](FileStorageApi.md#uploadsessionsfinish) | **POST** /file-storage/upload-sessions/{id}/finish | Finish Upload Session
[**UploadSessionsOne**](FileStorageApi.md#uploadsessionsone) | **GET** /file-storage/upload-sessions/{id} | Get Upload Session


<a name="drivegroupsadd"></a>
# **DriveGroupsAdd**
> CreateDriveGroupResponse DriveGroupsAdd (DriveGroup driveGroup, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create DriveGroup

Create DriveGroup

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DriveGroupsAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var driveGroup = new DriveGroup(); // DriveGroup | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create DriveGroup
                CreateDriveGroupResponse result = apiInstance.DriveGroupsAdd(driveGroup, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DriveGroupsAdd: " + e.Message );
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
 **driveGroup** | [**DriveGroup**](DriveGroup.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateDriveGroupResponse**](CreateDriveGroupResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | DriveGroups |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivegroupsall"></a>
# **DriveGroupsAll**
> GetDriveGroupsResponse DriveGroupsAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, DriveGroupsFilter filter = null, PassThroughQuery passThrough = null, string fields = null)

List DriveGroups

List DriveGroups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DriveGroupsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of results to return. Minimum 1, Maximum 200, Default 20 (optional)  (default to 20)
            var filter = new DriveGroupsFilter(); // DriveGroupsFilter | Apply filters (optional) 
            var passThrough = new PassThroughQuery(); // PassThroughQuery | Optional unmapped key/values that will be passed through to downstream as query parameters. Ie: ?pass_through[search]=leads becomes ?search=leads (optional) 
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List DriveGroups
                GetDriveGroupsResponse result = apiInstance.DriveGroupsAll(raw, consumerId, appId, serviceId, cursor, limit, filter, passThrough, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DriveGroupsAll: " + e.Message );
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
 **filter** | [**DriveGroupsFilter**](DriveGroupsFilter.md)| Apply filters | [optional] 
 **passThrough** | [**PassThroughQuery**](PassThroughQuery.md)| Optional unmapped key/values that will be passed through to downstream as query parameters. Ie: ?pass_through[search]&#x3D;leads becomes ?search&#x3D;leads | [optional] 
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetDriveGroupsResponse**](GetDriveGroupsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DriveGroups |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivegroupsdelete"></a>
# **DriveGroupsDelete**
> DeleteDriveGroupResponse DriveGroupsDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete DriveGroup

Delete DriveGroup

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DriveGroupsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete DriveGroup
                DeleteDriveGroupResponse result = apiInstance.DriveGroupsDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DriveGroupsDelete: " + e.Message );
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

[**DeleteDriveGroupResponse**](DeleteDriveGroupResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DriveGroups |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivegroupsone"></a>
# **DriveGroupsOne**
> GetDriveGroupResponse DriveGroupsOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get DriveGroup

Get DriveGroup

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DriveGroupsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get DriveGroup
                GetDriveGroupResponse result = apiInstance.DriveGroupsOne(id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DriveGroupsOne: " + e.Message );
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

[**GetDriveGroupResponse**](GetDriveGroupResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DriveGroups |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivegroupsupdate"></a>
# **DriveGroupsUpdate**
> UpdateDriveGroupResponse DriveGroupsUpdate (string id, DriveGroup driveGroup, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update DriveGroup

Update DriveGroup

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DriveGroupsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var driveGroup = new DriveGroup(); // DriveGroup | 
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update DriveGroup
                UpdateDriveGroupResponse result = apiInstance.DriveGroupsUpdate(id, driveGroup, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DriveGroupsUpdate: " + e.Message );
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
 **driveGroup** | [**DriveGroup**](DriveGroup.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateDriveGroupResponse**](UpdateDriveGroupResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DriveGroups |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivesadd"></a>
# **DrivesAdd**
> CreateDriveResponse DrivesAdd (Drive drive, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create Drive

Create Drive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DrivesAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var drive = new Drive(); // Drive | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create Drive
                CreateDriveResponse result = apiInstance.DrivesAdd(drive, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DrivesAdd: " + e.Message );
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
 **drive** | [**Drive**](Drive.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateDriveResponse**](CreateDriveResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Drives |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivesall"></a>
# **DrivesAll**
> GetDrivesResponse DrivesAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, DrivesFilter filter = null, string fields = null)

List Drives

List Drives

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DrivesAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of results to return. Minimum 1, Maximum 200, Default 20 (optional)  (default to 20)
            var filter = new DrivesFilter(); // DrivesFilter | Apply filters (optional) 
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List Drives
                GetDrivesResponse result = apiInstance.DrivesAll(raw, consumerId, appId, serviceId, cursor, limit, filter, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DrivesAll: " + e.Message );
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
 **filter** | [**DrivesFilter**](DrivesFilter.md)| Apply filters | [optional] 
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetDrivesResponse**](GetDrivesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Drives |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivesdelete"></a>
# **DrivesDelete**
> DeleteDriveResponse DrivesDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Drive

Delete Drive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DrivesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Drive
                DeleteDriveResponse result = apiInstance.DrivesDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DrivesDelete: " + e.Message );
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

[**DeleteDriveResponse**](DeleteDriveResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Drives |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivesone"></a>
# **DrivesOne**
> GetDriveResponse DrivesOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get Drive

Get Drive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DrivesOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get Drive
                GetDriveResponse result = apiInstance.DrivesOne(id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DrivesOne: " + e.Message );
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

[**GetDriveResponse**](GetDriveResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Drives |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="drivesupdate"></a>
# **DrivesUpdate**
> UpdateDriveResponse DrivesUpdate (string id, Drive drive, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update Drive

Update Drive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DrivesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var drive = new Drive(); // Drive | 
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update Drive
                UpdateDriveResponse result = apiInstance.DrivesUpdate(id, drive, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.DrivesUpdate: " + e.Message );
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
 **drive** | [**Drive**](Drive.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateDriveResponse**](UpdateDriveResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Drives |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesall"></a>
# **FilesAll**
> GetFilesResponse FilesAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, FilesFilter filter = null, FilesSort sort = null, PassThroughQuery passThrough = null, string fields = null)

List Files

List Files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FilesAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of results to return. Minimum 1, Maximum 200, Default 20 (optional)  (default to 20)
            var filter = new FilesFilter(); // FilesFilter | Apply filters (optional) 
            var sort = new FilesSort(); // FilesSort | Apply sorting (optional) 
            var passThrough = new PassThroughQuery(); // PassThroughQuery | Optional unmapped key/values that will be passed through to downstream as query parameters. Ie: ?pass_through[search]=leads becomes ?search=leads (optional) 
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List Files
                GetFilesResponse result = apiInstance.FilesAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort, passThrough, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FilesAll: " + e.Message );
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
 **filter** | [**FilesFilter**](FilesFilter.md)| Apply filters | [optional] 
 **sort** | [**FilesSort**](FilesSort.md)| Apply sorting | [optional] 
 **passThrough** | [**PassThroughQuery**](PassThroughQuery.md)| Optional unmapped key/values that will be passed through to downstream as query parameters. Ie: ?pass_through[search]&#x3D;leads becomes ?search&#x3D;leads | [optional] 
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetFilesResponse**](GetFilesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Files |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesdelete"></a>
# **FilesDelete**
> DeleteFileResponse FilesDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete File

Delete File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FilesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete File
                DeleteFileResponse result = apiInstance.FilesDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FilesDelete: " + e.Message );
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

[**DeleteFileResponse**](DeleteFileResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Files |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesdownload"></a>
# **FilesDownload**
> System.IO.Stream FilesDownload (string id, string consumerId = null, string appId = null, string serviceId = null, string fields = null)

Download File

Download File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FilesDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Download File
                System.IO.Stream result = apiInstance.FilesDownload(id, consumerId, appId, serviceId, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FilesDownload: " + e.Message );
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
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File Download |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesexport"></a>
# **FilesExport**
> System.IO.Stream FilesExport (string id, string format, string consumerId = null, string appId = null, string serviceId = null, string fields = null)

Export File

Export File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FilesExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var format = pdf;  // string | File format to export this file to. A list of available file formats for the current file is available as `export_formats` on the File resource.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Export File
                System.IO.Stream result = apiInstance.FilesExport(id, format, consumerId, appId, serviceId, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FilesExport: " + e.Message );
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
 **format** | **string**| File format to export this file to. A list of available file formats for the current file is available as &#x60;export_formats&#x60; on the File resource. | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File Download |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesone"></a>
# **FilesOne**
> GetFileResponse FilesOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get File

Get File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FilesOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get File
                GetFileResponse result = apiInstance.FilesOne(id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FilesOne: " + e.Message );
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

[**GetFileResponse**](GetFileResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filessearch"></a>
# **FilesSearch**
> GetFilesResponse FilesSearch (FilesSearch filesSearch, string consumerId = null, string appId = null, string serviceId = null, PassThroughQuery passThrough = null, string fields = null, string cursor = null, int? limit = null, bool? raw = null, FilesFilter filter = null)

Search Files

Search Files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FilesSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var filesSearch = new FilesSearch(); // FilesSearch | 
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var passThrough = new PassThroughQuery(); // PassThroughQuery | Optional unmapped key/values that will be passed through to downstream as query parameters. Ie: ?pass_through[search]=leads becomes ?search=leads (optional) 
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of results to return. Minimum 1, Maximum 200, Default 20 (optional)  (default to 20)
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var filter = new FilesFilter(); // FilesFilter | Apply filters (optional) 

            try
            {
                // Search Files
                GetFilesResponse result = apiInstance.FilesSearch(filesSearch, consumerId, appId, serviceId, passThrough, fields, cursor, limit, raw, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FilesSearch: " + e.Message );
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
 **filesSearch** | [**FilesSearch**](FilesSearch.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **passThrough** | [**PassThroughQuery**](PassThroughQuery.md)| Optional unmapped key/values that will be passed through to downstream as query parameters. Ie: ?pass_through[search]&#x3D;leads becomes ?search&#x3D;leads | [optional] 
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 
 **cursor** | **string**| Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. | [optional] 
 **limit** | **int?**| Number of results to return. Minimum 1, Maximum 200, Default 20 | [optional] [default to 20]
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **filter** | [**FilesFilter**](FilesFilter.md)| Apply filters | [optional] 

### Return type

[**GetFilesResponse**](GetFilesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Files |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesupdate"></a>
# **FilesUpdate**
> UpdateFileResponse FilesUpdate (string id, UpdateFileRequest updateFileRequest, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Rename or move File

Rename or move File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FilesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var updateFileRequest = new UpdateFileRequest(); // UpdateFileRequest | 
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Rename or move File
                UpdateFileResponse result = apiInstance.FilesUpdate(id, updateFileRequest, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FilesUpdate: " + e.Message );
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
 **updateFileRequest** | [**UpdateFileRequest**](UpdateFileRequest.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateFileResponse**](UpdateFileResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Files |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersadd"></a>
# **FoldersAdd**
> CreateFolderResponse FoldersAdd (CreateFolderRequest createFolderRequest, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string fields = null)

Create Folder

Create Folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FoldersAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var createFolderRequest = new CreateFolderRequest(); // CreateFolderRequest | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Create Folder
                CreateFolderResponse result = apiInstance.FoldersAdd(createFolderRequest, raw, consumerId, appId, serviceId, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FoldersAdd: " + e.Message );
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
 **createFolderRequest** | [**CreateFolderRequest**](CreateFolderRequest.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**CreateFolderResponse**](CreateFolderResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Folders |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="folderscopy"></a>
# **FoldersCopy**
> UpdateFolderResponse FoldersCopy (string id, CopyFolderRequest copyFolderRequest, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Copy Folder

Copy Folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FoldersCopyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var copyFolderRequest = new CopyFolderRequest(); // CopyFolderRequest | 
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Copy Folder
                UpdateFolderResponse result = apiInstance.FoldersCopy(id, copyFolderRequest, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FoldersCopy: " + e.Message );
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
 **copyFolderRequest** | [**CopyFolderRequest**](CopyFolderRequest.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**UpdateFolderResponse**](UpdateFolderResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folders |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersdelete"></a>
# **FoldersDelete**
> DeleteFolderResponse FoldersDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Folder

Delete Folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FoldersDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Folder
                DeleteFolderResponse result = apiInstance.FoldersDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FoldersDelete: " + e.Message );
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

[**DeleteFolderResponse**](DeleteFolderResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folders |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersone"></a>
# **FoldersOne**
> GetFolderResponse FoldersOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get Folder

Get Folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FoldersOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get Folder
                GetFolderResponse result = apiInstance.FoldersOne(id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FoldersOne: " + e.Message );
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

[**GetFolderResponse**](GetFolderResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folders |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersupdate"></a>
# **FoldersUpdate**
> UpdateFolderResponse FoldersUpdate (string id, UpdateFolderRequest updateFolderRequest, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Rename or move Folder

Rename or move Folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class FoldersUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var updateFolderRequest = new UpdateFolderRequest(); // UpdateFolderRequest | 
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Rename or move Folder
                UpdateFolderResponse result = apiInstance.FoldersUpdate(id, updateFolderRequest, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.FoldersUpdate: " + e.Message );
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
 **updateFolderRequest** | [**UpdateFolderRequest**](UpdateFolderRequest.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateFolderResponse**](UpdateFolderResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folders |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharedlinksadd"></a>
# **SharedLinksAdd**
> CreateSharedLinkResponse SharedLinksAdd (SharedLink sharedLink, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create Shared Link

Create Shared Link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class SharedLinksAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var sharedLink = new SharedLink(); // SharedLink | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create Shared Link
                CreateSharedLinkResponse result = apiInstance.SharedLinksAdd(sharedLink, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.SharedLinksAdd: " + e.Message );
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
 **sharedLink** | [**SharedLink**](SharedLink.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateSharedLinkResponse**](CreateSharedLinkResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Shared Links |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharedlinksall"></a>
# **SharedLinksAll**
> GetSharedLinksResponse SharedLinksAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, PassThroughQuery passThrough = null, string fields = null)

List SharedLinks

List SharedLinks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class SharedLinksAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of results to return. Minimum 1, Maximum 200, Default 20 (optional)  (default to 20)
            var passThrough = new PassThroughQuery(); // PassThroughQuery | Optional unmapped key/values that will be passed through to downstream as query parameters. Ie: ?pass_through[search]=leads becomes ?search=leads (optional) 
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // List SharedLinks
                GetSharedLinksResponse result = apiInstance.SharedLinksAll(raw, consumerId, appId, serviceId, cursor, limit, passThrough, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.SharedLinksAll: " + e.Message );
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
 **passThrough** | [**PassThroughQuery**](PassThroughQuery.md)| Optional unmapped key/values that will be passed through to downstream as query parameters. Ie: ?pass_through[search]&#x3D;leads becomes ?search&#x3D;leads | [optional] 
 **fields** | **string**| The &#39;fields&#39; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: &#x60;fields&#x3D;name,email,addresses.city&#x60;&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields \&quot;name\&quot;, \&quot;email\&quot; and \&quot;addresses.city\&quot;. If any other fields are available, they will be excluded. | [optional] 

### Return type

[**GetSharedLinksResponse**](GetSharedLinksResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Shared Links |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharedlinksdelete"></a>
# **SharedLinksDelete**
> DeleteSharedLinkResponse SharedLinksDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Shared Link

Delete Shared Link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class SharedLinksDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Shared Link
                DeleteSharedLinkResponse result = apiInstance.SharedLinksDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.SharedLinksDelete: " + e.Message );
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

[**DeleteSharedLinkResponse**](DeleteSharedLinkResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Shared Links |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharedlinksone"></a>
# **SharedLinksOne**
> GetSharedLinkResponse SharedLinksOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get Shared Link

Get Shared Link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class SharedLinksOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get Shared Link
                GetSharedLinkResponse result = apiInstance.SharedLinksOne(id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.SharedLinksOne: " + e.Message );
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

[**GetSharedLinkResponse**](GetSharedLinkResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Shared Link |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharedlinksupdate"></a>
# **SharedLinksUpdate**
> UpdateSharedLinkResponse SharedLinksUpdate (string id, SharedLink sharedLink, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update Shared Link

Update Shared Link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class SharedLinksUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var sharedLink = new SharedLink(); // SharedLink | 
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update Shared Link
                UpdateSharedLinkResponse result = apiInstance.SharedLinksUpdate(id, sharedLink, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.SharedLinksUpdate: " + e.Message );
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
 **sharedLink** | [**SharedLink**](SharedLink.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateSharedLinkResponse**](UpdateSharedLinkResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Shared Links |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadsessionsadd"></a>
# **UploadSessionsAdd**
> CreateUploadSessionResponse UploadSessionsAdd (CreateUploadSessionRequest createUploadSessionRequest, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Start Upload Session

Start an Upload Session. Upload sessions are used to upload large files, use the [Upload File](#operation/filesUpload) endpoint to upload smaller files (up to 100MB). Note that the base URL is upload.apideck.com instead of unify.apideck.com. For more information on uploads, refer to the [file upload guide](/guides/file-upload).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class UploadSessionsAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var createUploadSessionRequest = new CreateUploadSessionRequest(); // CreateUploadSessionRequest | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Start Upload Session
                CreateUploadSessionResponse result = apiInstance.UploadSessionsAdd(createUploadSessionRequest, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.UploadSessionsAdd: " + e.Message );
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
 **createUploadSessionRequest** | [**CreateUploadSessionRequest**](CreateUploadSessionRequest.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateUploadSessionResponse**](CreateUploadSessionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | UploadSessions |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadsessionsdelete"></a>
# **UploadSessionsDelete**
> DeleteUploadSessionResponse UploadSessionsDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Abort Upload Session

Abort Upload Session. Note that the base URL is upload.apideck.com instead of unify.apideck.com. For more information on uploads, refer to the [file upload guide](/guides/file-upload).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class UploadSessionsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Abort Upload Session
                DeleteUploadSessionResponse result = apiInstance.UploadSessionsDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.UploadSessionsDelete: " + e.Message );
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

[**DeleteUploadSessionResponse**](DeleteUploadSessionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | UploadSessions |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadsessionsfinish"></a>
# **UploadSessionsFinish**
> GetFileResponse UploadSessionsFinish (string id, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string digest = null, Object body = null)

Finish Upload Session

Finish Upload Session. Only call this endpoint after all File parts have been uploaded to [Upload part of File](#operation/uploadSessionsUpload). Note that the base URL is upload.apideck.com instead of unify.apideck.com. For more information on uploads, refer to the [file upload guide](/guides/file-upload).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class UploadSessionsFinishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var digest = sha=fpRyg5eVQletdZqEKaFlqwBXJzM=;  // string | The RFC3230 message digest of the uploaded part. Only required for the Box connector. More information on the Box API docs [here](https://developer.box.com/reference/put-files-upload-sessions-id/#param-digest) (optional) 
            var body = null;  // Object |  (optional) 

            try
            {
                // Finish Upload Session
                GetFileResponse result = apiInstance.UploadSessionsFinish(id, raw, consumerId, appId, serviceId, digest, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.UploadSessionsFinish: " + e.Message );
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
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **digest** | **string**| The RFC3230 message digest of the uploaded part. Only required for the Box connector. More information on the Box API docs [here](https://developer.box.com/reference/put-files-upload-sessions-id/#param-digest) | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**GetFileResponse**](GetFileResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | File |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadsessionsone"></a>
# **UploadSessionsOne**
> GetUploadSessionResponse UploadSessionsOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null, string fields = null)

Get Upload Session

Get Upload Session. Use the `part_size` to split your file into parts. Upload the parts to the [Upload part of File](#operation/uploadSessionsUpload) endpoint. Note that the base URL is upload.apideck.com instead of unify.apideck.com. For more information on uploads, refer to the [file upload guide](/guides/file-upload).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class UploadSessionsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileStorageApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = test-consumer;  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX;  // string | The ID of your Unify application (optional) 
            var serviceId = salesforce;  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var fields = id,updated_at;  // string | The 'fields' parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. <br /><br />Example: `fields=name,email,addresses.city`<br /><br />In the example above, the response will only include the fields \"name\", \"email\" and \"addresses.city\". If any other fields are available, they will be excluded. (optional) 

            try
            {
                // Get Upload Session
                GetUploadSessionResponse result = apiInstance.UploadSessionsOne(id, consumerId, appId, serviceId, raw, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStorageApi.UploadSessionsOne: " + e.Message );
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

[**GetUploadSessionResponse**](GetUploadSessionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | UploadSessions |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

