# Apideck .NET SDK

[![Build](https://github.com/apideck-libraries/dotnet-sdk/actions/workflows/test.yml/badge.svg)](https://github.com/apideck-libraries/dotnet-sdk/actions/workflows/test.yml)
[![NuGet](https://badge.fury.io/nu/Apideck.svg)](https://badge.fury.io/nu/Apideck)
[![Apache-2 license](https://img.shields.io/badge/license-Apache2-brightgreen.svg)](https://www.apache.org/licenses/LICENSE-2.0)

## Table of Contents

- [Table of Contents](#table-of-contents)
- [Installation](#installation)
- [Getting started](#getting-started)
- [Example](#example)
- [Support](#support)
- [License](#license)

## Installation

### Requirements

Use of the Apideck .NET SDK requires:

* NET Standard 2.0 or higher


### NuGet

Install using the dotnet CLI.

```console
$ dotnet add package Apideck
```

Install with NuGet.exe.

```console
$ nuget install Apideck
```

- Use the Package Manager console for Visual Studio on Windows. In Visual Studio, right-click the project and choose Add NuGet Package. Search for the Square package and install it.

- Use the Manage NuGet UI in Visual Studio on a Mac. In Visual Studio, right-click the project Dependencies and choose Manage NuGet Packages. Search for the Square package and install it.

- In Visual Studio, right-click the project and choose Add NuGet Package. Search for the Square package and install it.


## Getting started

The module supports all Apideck API endpoints. For complete information about the API, head
to the [docs][2].


## Example

Retrieving a list of all companies.

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
            // Configure API key authorization: apiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CrmApi(config);
            var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
            var consumerId = "consumerId_example";  // string | ID of the consumer which you want to get or push data from (optional)
            var appId = "appId_example";  // string | The ID of your Unify application (optional)
            var serviceId = "serviceId_example";  // string | Provide the service id you want to call (e.g., pipedrive). [See the full list in the connector section.](#section/Connectors) Only needed when a consumer has activated multiple integrations for a Unified API. (optional)

            try
            {
                // List companies
                GetCompaniesResponse result = apiInstance.CompaniesAll(raw, consumerId, appId, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CrmApi.CompaniesAll: " + e.Message );
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print("Detail: " + e.ErrorContent);
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Apideck Unified Apis

The following Apis are currently available:

### AccountingApi

Read the full documentation of the AccountingApi [here](./src/gen/docs/AccountingApi.md).

### AtsApi

Read the full documentation of the AtsApi [here](./src/gen/docs/AtsApi.md).

### ConnectorApi

Read the full documentation of the ConnectorApi [here](./src/gen/docs/ConnectorApi.md).

### CrmApi

Read the full documentation of the CrmApi [here](./src/gen/docs/CrmApi.md).

### CustomerSupportApi

Read the full documentation of the CustomerSupportApi [here](./src/gen/docs/CustomerSupportApi.md).

### FileStorageApi

Read the full documentation of the FileStorageApi [here](./src/gen/docs/FileStorageApi.md).

### HrisApi

Read the full documentation of the HrisApi [here](./src/gen/docs/HrisApi.md).

### LeadApi

Read the full documentation of the LeadApi [here](./src/gen/docs/LeadApi.md).

### PosApi

Read the full documentation of the PosApi [here](./src/gen/docs/PosApi.md).

### SmsApi

Read the full documentation of the SmsApi [here](./src/gen/docs/SmsApi.md).

### VaultApi

Read the full documentation of the VaultApi [here](./src/gen/docs/VaultApi.md).

### WebhookApi

Read the full documentation of the WebhookApi [here](./src/gen/docs/WebhookApi.md).


## Support

Open an [issue][3]!

## License

[Apache-2.0][4]

[1]: https://apideck.com
[2]: https://developers.apideck.com/
[3]: https://github.com/apideck-libraries/dotnet-sdk/issues/new
[4]: https://github.com/apideck-libraries/dotnet-sdk/blob/master/LICENSE
