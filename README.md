# Apideck .NET SDK

> ⚠️ **DEPRECATION NOTICE**: This SDK is deprecated and will be archived on May 31, 2025. Please transition to the [new SDK](https://github.com/apideck-libraries/sdk-csharp) before this date. After May 31, 2025, this repository will be archived and will no longer receive any updates. To support you during this transition please refer to our [migration guide](https://developers.apideck.com/guides/sdk-migration).


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

- Use the Package Manager console for Visual Studio on Windows. In Visual Studio, right-click the project and choose Add NuGet Package. Search for the Apideck package and install it.

- Use the Manage NuGet UI in Visual Studio on a Mac. In Visual Studio, right-click the project Dependencies and choose Manage NuGet Packages. Search for the Apideck package and install it.

- In Visual Studio, right-click the project and choose Add NuGet Package. Search for the Apideck package and install it.


## Getting started

The module supports all Apideck API endpoints. For complete information about the API, head
to the [docs][2].

### Create new project

1. Open your preferred integrated development environment (IDE), such as Visual Studio or Visual Studio Code.

2. Create a new .NET project:

- In Visual Studio: Go to "File" -> "New" -> "Project". Select the appropriate project template (e.g., Console App, Web App, etc.), provide a name for your project, and click "Create".
- In Visual Studio Code: Open a terminal and navigate to the desired directory where you want to create your project. Use the following command: `dotnet new console -n YourProjectName`, replacing "YourProjectName" with the desired name for your project.

3. Once the project is created, you need to add the required NuGet packages. You can do this using the NuGet Package Manager in Visual Studio or by running the following commands in the terminal (in the project directory):

```bash
dotnet add package Apideck
```

or install with Nuget

```bash
nuget install Apideck
```

4. After adding the packages, you can replace the default code in the automatically generated Program.cs file with the desired code:

Example:
Retrieving a list of all companies.

### Example
```csharp
using Apideck.Api;
using Apideck.Client;
using Apideck.Model;

namespace Example {
  public class CompaniesAllExample   {
    public static void Main()   {
      Configuration config = new Configuration();
      // Configure API key authorization: apiKey
      config.AddApiKey("Authorization", "API_KEY");
      config.AddApiKeyPrefix("Authorization", "Bearer");

      var apiInstance = new CrmApi(config);
      var raw = false;  // bool? | Include raw response. Mostly used for debugging purposes (optional)  (default to false)
      var consumerId = "CONSUMER_ID";  // string | ID of the consumer which you want to get or push data from (optional)
      var appId = "APP_ID";  // string | The ID of your Unify application (optional)
      var serviceId = "salesforce";  // string | Provide the service id you want to call (e.g., pipedrive). [See the full list in the connector section.](#section/Connectors) Only needed when a consumer has activated multiple integrations for a Unified API. (optional)

      try {
        Console.WriteLine("Calling Apideck");
        // List companies
        GetCompaniesResponse result = apiInstance.CompaniesAll(raw, consumerId, appId, serviceId);
        Console.WriteLine("Success", result);
      }
      catch (ApiException e) {
        Console.WriteLine("Exception when calling CrmApi.CompaniesAll: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine("Detail: " + e.ErrorContent);
      }
    }
  }
}
```

- In Visual Studio: Open the Program.cs file in the Solution Explorer and replace its content with the code you provided.
- In Visual Studio Code: Open the Program.cs file and replace its content with the code you provided.

5. Make sure to replace "API_KEY", "CONSUMER_ID", "APP_ID", and "salesforce" with the actual values provided by Apideck.
The API key represents your authentication credentials, while the other variables provide additional context for the API calls.

6. Once you've updated the code, you can build and run your project. In Visual Studio, you can simply press F5 or click the "Start" button. In Visual Studio Code, use the following command in the terminal: dotnet run.

7. The application will execute, and the output will be displayed in the console window. If successful, you should see the message "Calling Apideck" and, upon completion, a success message or an exception message if an error occurs.


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

### EcommerceApi

Read the full documentation of the EcommerceApi [here](./src/gen/docs/EcommerceApi.md).

### FileStorageApi

Read the full documentation of the FileStorageApi [here](./src/gen/docs/FileStorageApi.md).

### HrisApi

Read the full documentation of the HrisApi [here](./src/gen/docs/HrisApi.md).

### IssueTrackingApi

Read the full documentation of the IssueTrackingApi [here](./src/gen/docs/IssueTrackingApi.md).

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
[4]: https://github.com/apideck-libraries/dotnet-sdk/blob/main/LICENSE
