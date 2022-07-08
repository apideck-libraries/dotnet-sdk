# Apideck.Api.HrisApi

All URIs are relative to *https://unify.apideck.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompaniesAdd**](HrisApi.md#companiesadd) | **POST** /hris/companies | Create Company
[**CompaniesAll**](HrisApi.md#companiesall) | **GET** /hris/companies | List Companies
[**CompaniesDelete**](HrisApi.md#companiesdelete) | **DELETE** /hris/companies/{id} | Delete Company
[**CompaniesOne**](HrisApi.md#companiesone) | **GET** /hris/companies/{id} | Get Company
[**CompaniesUpdate**](HrisApi.md#companiesupdate) | **PATCH** /hris/companies/{id} | Update Company
[**DepartmentsAdd**](HrisApi.md#departmentsadd) | **POST** /hris/departments | Create Department
[**DepartmentsAll**](HrisApi.md#departmentsall) | **GET** /hris/departments | List Departments
[**DepartmentsDelete**](HrisApi.md#departmentsdelete) | **DELETE** /hris/departments/{id} | Delete Department
[**DepartmentsOne**](HrisApi.md#departmentsone) | **GET** /hris/departments/{id} | Get Department
[**DepartmentsUpdate**](HrisApi.md#departmentsupdate) | **PATCH** /hris/departments/{id} | Update Department
[**EmployeePayrollsAll**](HrisApi.md#employeepayrollsall) | **GET** /hris/payrolls/employees/{employee_id} | List Employee Payrolls
[**EmployeePayrollsOne**](HrisApi.md#employeepayrollsone) | **GET** /hris/payrolls/employees/{employee_id}/payrolls/{payroll_id} | Get Employee Payroll
[**EmployeeSchedulesAll**](HrisApi.md#employeeschedulesall) | **GET** /hris/schedules/employees/{employee_id} | List Employee Schedules
[**EmployeesAdd**](HrisApi.md#employeesadd) | **POST** /hris/employees | Create Employee
[**EmployeesAll**](HrisApi.md#employeesall) | **GET** /hris/employees | List Employees
[**EmployeesDelete**](HrisApi.md#employeesdelete) | **DELETE** /hris/employees/{id} | Delete Employee
[**EmployeesOne**](HrisApi.md#employeesone) | **GET** /hris/employees/{id} | Get Employee
[**EmployeesUpdate**](HrisApi.md#employeesupdate) | **PATCH** /hris/employees/{id} | Update Employee
[**JobsAll**](HrisApi.md#jobsall) | **GET** /hris/jobs/employees/{employee_id} | List Jobs
[**JobsOne**](HrisApi.md#jobsone) | **GET** /hris/jobs/employees/{employee_id}/jobs/{job_id} | One Job
[**PayrollsAll**](HrisApi.md#payrollsall) | **GET** /hris/payrolls | List Payroll
[**PayrollsOne**](HrisApi.md#payrollsone) | **GET** /hris/payrolls/{payroll_id} | Get Payroll


<a name="companiesadd"></a>
# **CompaniesAdd**
> CreateHrisCompanyResponse CompaniesAdd (HrisCompany hrisCompany, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create Company

Create Company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CompaniesAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var hrisCompany = new HrisCompany(); // HrisCompany | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create Company
                CreateHrisCompanyResponse result = apiInstance.CompaniesAdd(hrisCompany, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.CompaniesAdd: " + e.Message );
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
 **hrisCompany** | [**HrisCompany**](HrisCompany.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateHrisCompanyResponse**](CreateHrisCompanyResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Companies |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesall"></a>
# **CompaniesAll**
> GetHrisCompaniesResponse CompaniesAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null)

List Companies

List Companies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CompaniesAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)

            try
            {
                // List Companies
                GetHrisCompaniesResponse result = apiInstance.CompaniesAll(raw, consumerId, appId, serviceId, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.CompaniesAll: " + e.Message );
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

### Return type

[**GetHrisCompaniesResponse**](GetHrisCompaniesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Companies |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesdelete"></a>
# **CompaniesDelete**
> DeleteHrisCompanyResponse CompaniesDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Company

Delete Company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CompaniesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Company
                DeleteHrisCompanyResponse result = apiInstance.CompaniesDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.CompaniesDelete: " + e.Message );
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

[**DeleteHrisCompanyResponse**](DeleteHrisCompanyResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Companies |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesone"></a>
# **CompaniesOne**
> GetHrisCompanyResponse CompaniesOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Get Company

Get Company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CompaniesOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Get Company
                GetHrisCompanyResponse result = apiInstance.CompaniesOne(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.CompaniesOne: " + e.Message );
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

[**GetHrisCompanyResponse**](GetHrisCompanyResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Company |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesupdate"></a>
# **CompaniesUpdate**
> UpdateHrisCompanyResponse CompaniesUpdate (string id, HrisCompany hrisCompany, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update Company

Update Company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class CompaniesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var hrisCompany = new HrisCompany(); // HrisCompany | 
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update Company
                UpdateHrisCompanyResponse result = apiInstance.CompaniesUpdate(id, hrisCompany, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.CompaniesUpdate: " + e.Message );
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
 **hrisCompany** | [**HrisCompany**](HrisCompany.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateHrisCompanyResponse**](UpdateHrisCompanyResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Companies |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentsadd"></a>
# **DepartmentsAdd**
> CreateDepartmentResponse DepartmentsAdd (Department department, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create Department

Create Department

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DepartmentsAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var department = new Department(); // Department | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create Department
                CreateDepartmentResponse result = apiInstance.DepartmentsAdd(department, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.DepartmentsAdd: " + e.Message );
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
 **department** | [**Department**](Department.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateDepartmentResponse**](CreateDepartmentResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Departments |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentsall"></a>
# **DepartmentsAll**
> GetDepartmentsResponse DepartmentsAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null)

List Departments

List Departments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DepartmentsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)

            try
            {
                // List Departments
                GetDepartmentsResponse result = apiInstance.DepartmentsAll(raw, consumerId, appId, serviceId, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.DepartmentsAll: " + e.Message );
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

### Return type

[**GetDepartmentsResponse**](GetDepartmentsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Departments |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentsdelete"></a>
# **DepartmentsDelete**
> DeleteDepartmentResponse DepartmentsDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Department

Delete Department

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DepartmentsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Department
                DeleteDepartmentResponse result = apiInstance.DepartmentsDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.DepartmentsDelete: " + e.Message );
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

[**DeleteDepartmentResponse**](DeleteDepartmentResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Departments |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentsone"></a>
# **DepartmentsOne**
> GetDepartmentResponse DepartmentsOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Get Department

Get Department

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DepartmentsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Get Department
                GetDepartmentResponse result = apiInstance.DepartmentsOne(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.DepartmentsOne: " + e.Message );
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

[**GetDepartmentResponse**](GetDepartmentResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Departments |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentsupdate"></a>
# **DepartmentsUpdate**
> UpdateDepartmentResponse DepartmentsUpdate (string id, Department department, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update Department

Update Department

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class DepartmentsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var department = new Department(); // Department | 
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update Department
                UpdateDepartmentResponse result = apiInstance.DepartmentsUpdate(id, department, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.DepartmentsUpdate: " + e.Message );
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
 **department** | [**Department**](Department.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateDepartmentResponse**](UpdateDepartmentResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Departments |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeepayrollsall"></a>
# **EmployeePayrollsAll**
> GetEmployeePayrollsResponse EmployeePayrollsAll (string employeeId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, PayrollsFilter filter = null)

List Employee Payrolls

List payrolls for employee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EmployeePayrollsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var employeeId = "employeeId_example";  // string | ID of the employee you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var filter = new PayrollsFilter(); // PayrollsFilter | Apply filters (beta) (optional) 

            try
            {
                // List Employee Payrolls
                GetEmployeePayrollsResponse result = apiInstance.EmployeePayrollsAll(employeeId, raw, consumerId, appId, serviceId, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.EmployeePayrollsAll: " + e.Message );
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
 **employeeId** | **string**| ID of the employee you are acting upon. | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **filter** | [**PayrollsFilter**](PayrollsFilter.md)| Apply filters (beta) | [optional] 

### Return type

[**GetEmployeePayrollsResponse**](GetEmployeePayrollsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | EmployeePayrolls |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeepayrollsone"></a>
# **EmployeePayrollsOne**
> GetEmployeePayrollResponse EmployeePayrollsOne (string payrollId, string employeeId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Get Employee Payroll

Get payroll for employee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EmployeePayrollsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var payrollId = "payrollId_example";  // string | ID of the payroll you are acting upon.
            var employeeId = "employeeId_example";  // string | ID of the employee you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Get Employee Payroll
                GetEmployeePayrollResponse result = apiInstance.EmployeePayrollsOne(payrollId, employeeId, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.EmployeePayrollsOne: " + e.Message );
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
 **payrollId** | **string**| ID of the payroll you are acting upon. | 
 **employeeId** | **string**| ID of the employee you are acting upon. | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**GetEmployeePayrollResponse**](GetEmployeePayrollResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payrolls |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeeschedulesall"></a>
# **EmployeeSchedulesAll**
> GetEmployeeSchedulesResponse EmployeeSchedulesAll (string employeeId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

List Employee Schedules

List schedules for employee, a schedule is a work pattern, not the actual worked hours, for an employee.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EmployeeSchedulesAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var employeeId = "employeeId_example";  // string | ID of the employee you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // List Employee Schedules
                GetEmployeeSchedulesResponse result = apiInstance.EmployeeSchedulesAll(employeeId, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.EmployeeSchedulesAll: " + e.Message );
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
 **employeeId** | **string**| ID of the employee you are acting upon. | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**GetEmployeeSchedulesResponse**](GetEmployeeSchedulesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | EmployeeSchedules |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesadd"></a>
# **EmployeesAdd**
> CreateEmployeeResponse EmployeesAdd (Employee employee, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Create Employee

Create Employee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EmployeesAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var employee = new Employee(); // Employee | 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Create Employee
                CreateEmployeeResponse result = apiInstance.EmployeesAdd(employee, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.EmployeesAdd: " + e.Message );
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
 **employee** | [**Employee**](Employee.md)|  | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**CreateEmployeeResponse**](CreateEmployeeResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Employees |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesall"></a>
# **EmployeesAll**
> GetEmployeesResponse EmployeesAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, string cursor = null, int? limit = null, EmployeesFilter filter = null)

List Employees

List Employees

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EmployeesAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var cursor = "cursor_example";  // string | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. (optional) 
            var limit = 20;  // int? | Number of records to return (optional)  (default to 20)
            var filter = new EmployeesFilter(); // EmployeesFilter | Apply filters (beta) (optional) 

            try
            {
                // List Employees
                GetEmployeesResponse result = apiInstance.EmployeesAll(raw, consumerId, appId, serviceId, cursor, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.EmployeesAll: " + e.Message );
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
 **filter** | [**EmployeesFilter**](EmployeesFilter.md)| Apply filters (beta) | [optional] 

### Return type

[**GetEmployeesResponse**](GetEmployeesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Employees |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesdelete"></a>
# **EmployeesDelete**
> DeleteEmployeeResponse EmployeesDelete (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Delete Employee

Delete Employee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EmployeesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Delete Employee
                DeleteEmployeeResponse result = apiInstance.EmployeesDelete(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.EmployeesDelete: " + e.Message );
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

[**DeleteEmployeeResponse**](DeleteEmployeeResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Employees |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesone"></a>
# **EmployeesOne**
> GetEmployeeResponse EmployeesOne (string id, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Get Employee

Get Employee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EmployeesOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Get Employee
                GetEmployeeResponse result = apiInstance.EmployeesOne(id, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.EmployeesOne: " + e.Message );
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

[**GetEmployeeResponse**](GetEmployeeResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Employees |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesupdate"></a>
# **EmployeesUpdate**
> UpdateEmployeeResponse EmployeesUpdate (string id, Employee employee, string consumerId = null, string appId = null, string serviceId = null, bool? raw = null)

Update Employee

Update Employee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class EmployeesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var id = "id_example";  // string | ID of the record you are acting upon.
            var employee = new Employee(); // Employee | 
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)

            try
            {
                // Update Employee
                UpdateEmployeeResponse result = apiInstance.EmployeesUpdate(id, employee, consumerId, appId, serviceId, raw);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.EmployeesUpdate: " + e.Message );
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
 **employee** | [**Employee**](Employee.md)|  | 
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]

### Return type

[**UpdateEmployeeResponse**](UpdateEmployeeResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Employees |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobsall"></a>
# **JobsAll**
> GetHrisJobsResponse JobsAll (string employeeId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

List Jobs

List Jobs for employee.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class JobsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var employeeId = "employeeId_example";  // string | ID of the employee you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // List Jobs
                GetHrisJobsResponse result = apiInstance.JobsAll(employeeId, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.JobsAll: " + e.Message );
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
 **employeeId** | **string**| ID of the employee you are acting upon. | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**GetHrisJobsResponse**](GetHrisJobsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Jobs |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobsone"></a>
# **JobsOne**
> GetHrisJobResponse JobsOne (string jobId, string employeeId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

One Job

A Job for employee.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class JobsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var jobId = "jobId_example";  // string | ID of the job you are acting upon.
            var employeeId = "employeeId_example";  // string | ID of the employee you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // One Job
                GetHrisJobResponse result = apiInstance.JobsOne(jobId, employeeId, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.JobsOne: " + e.Message );
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
 **jobId** | **string**| ID of the job you are acting upon. | 
 **employeeId** | **string**| ID of the employee you are acting upon. | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**GetHrisJobResponse**](GetHrisJobResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Job |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payrollsall"></a>
# **PayrollsAll**
> GetPayrollsResponse PayrollsAll (bool? raw = null, string consumerId = null, string appId = null, string serviceId = null, PayrollsFilter filter = null)

List Payroll

List Payroll

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class PayrollsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 
            var filter = new PayrollsFilter(); // PayrollsFilter | Apply filters (beta) (optional) 

            try
            {
                // List Payroll
                GetPayrollsResponse result = apiInstance.PayrollsAll(raw, consumerId, appId, serviceId, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.PayrollsAll: " + e.Message );
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
 **filter** | [**PayrollsFilter**](PayrollsFilter.md)| Apply filters (beta) | [optional] 

### Return type

[**GetPayrollsResponse**](GetPayrollsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payrolls |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payrollsone"></a>
# **PayrollsOne**
> GetPayrollResponse PayrollsOne (string payrollId, bool? raw = null, string consumerId = null, string appId = null, string serviceId = null)

Get Payroll

Get Payroll

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example
{
    public class PayrollsOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://unify.apideck.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HrisApi(config);
            var payrollId = "payrollId_example";  // string | ID of the payroll you are acting upon.
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional) 
            var appId = "appId_example";  // string | The ID of your Unify application (optional) 
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. (optional) 

            try
            {
                // Get Payroll
                GetPayrollResponse result = apiInstance.PayrollsOne(payrollId, raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HrisApi.PayrollsOne: " + e.Message );
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
 **payrollId** | **string**| ID of the payroll you are acting upon. | 
 **raw** | **bool?**| Include raw response. Mostly used for debugging purposes | [optional] [default to false]
 **consumerId** | **string**| ID of the consumer which you want to get or push data from | [optional] 
 **appId** | **string**| The ID of your Unify application | [optional] 
 **serviceId** | **string**| Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API. | [optional] 

### Return type

[**GetPayrollResponse**](GetPayrollResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payrolls |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Payment Required |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | Unprocessable |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

