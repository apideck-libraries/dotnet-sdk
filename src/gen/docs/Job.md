# Apideck.Model.Job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**Slug** | **string** |  | [optional] 
**Title** | **string** |  | [optional] 
**Sequence** | **int** | Sequence in relation to other jobs. | [optional] 
**Visibility** | **List&lt;string&gt;** |  | [optional] 
**Status** | **JobStatus** |  | [optional] 
**Code** | **string** | The code of the job. | [optional] 
**Language** | **string** | language code according to ISO 639-1. For the United States - EN | [optional] 
**EmploymentTerms** | **string** |  | [optional] 
**Experience** | **string** | Level of experience required for the job role. | [optional] 
**Remote** | **bool?** | Specifies whether the posting is for a remote job. | [optional] 
**RequisitionId** | **string** | A job&#39;s Requisition ID (Req ID) allows your organization to identify and track a job based on alphanumeric naming conventions unique to your company&#39;s internal processes. | [optional] 
**Department** | [**Department**](Department.md) |  | [optional] 
**Branch** | [**Branch**](Branch.md) |  | [optional] 
**Recruiters** | **List&lt;string&gt;** | The recruiter is generally someone who is tasked to help the hiring manager find and screen qualified applicant | [optional] 
**HiringManagers** | **List&lt;Object&gt;** |  | [optional] 
**Followers** | **List&lt;string&gt;** |  | [optional] 
**Description** | **string** |  | [optional] 
**DescriptionHtml** | **string** | The job description in HTML format | [optional] 
**Blocks** | **List&lt;Object&gt;** |  | [optional] 
**Closing** | **string** |  | [optional] 
**ClosingHtml** | **string** | The closing section of the job description in HTML format | [optional] 
**ClosingDate** | **DateTime?** |  | [optional] 
**Salary** | [**JobSalary**](JobSalary.md) |  | [optional] 
**Url** | **string** | URL of the job description | [optional] 
**JobPortalUrl** | **string** | URL of the job portal | [optional] 
**Confidential** | **bool** |  | [optional] 
**AvailableToEmployees** | **bool** | Specifies whether an employee of the organization can apply for the job. | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**RecordUrl** | **string** |  | [optional] 
**Deleted** | **bool?** |  | [optional] 
**OwnerId** | **string** |  | [optional] 
**PublishedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedBy** | **string** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

