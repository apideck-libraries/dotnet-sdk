/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Apideck.Client;
using Apideck.Api;
// uncomment below to import models
//using Apideck.Model;

namespace Apideck.Test.Api
{
    /// <summary>
    ///  Class for testing HrisApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HrisApiTests : IDisposable
    {
        private HrisApi instance;

        public HrisApiTests()
        {
            instance = new HrisApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HrisApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' HrisApi
            //Assert.IsType<HrisApi>(instance);
        }

        /// <summary>
        /// Test CompaniesAdd
        /// </summary>
        [Fact]
        public void CompaniesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //HrisCompany hrisCompany = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.CompaniesAdd(hrisCompany, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateHrisCompanyResponse>(response);
        }

        /// <summary>
        /// Test CompaniesAll
        /// </summary>
        [Fact]
        public void CompaniesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.CompaniesAll(raw, consumerId, appId, serviceId, cursor, limit, passThrough, fields);
            //Assert.IsType<GetHrisCompaniesResponse>(response);
        }

        /// <summary>
        /// Test CompaniesDelete
        /// </summary>
        [Fact]
        public void CompaniesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CompaniesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteHrisCompanyResponse>(response);
        }

        /// <summary>
        /// Test CompaniesOne
        /// </summary>
        [Fact]
        public void CompaniesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.CompaniesOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetHrisCompanyResponse>(response);
        }

        /// <summary>
        /// Test CompaniesUpdate
        /// </summary>
        [Fact]
        public void CompaniesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //HrisCompany hrisCompany = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.CompaniesUpdate(id, hrisCompany, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateHrisCompanyResponse>(response);
        }

        /// <summary>
        /// Test DepartmentsAdd
        /// </summary>
        [Fact]
        public void DepartmentsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Department department = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.DepartmentsAdd(department, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateDepartmentResponse>(response);
        }

        /// <summary>
        /// Test DepartmentsAll
        /// </summary>
        [Fact]
        public void DepartmentsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.DepartmentsAll(raw, consumerId, appId, serviceId, cursor, limit, passThrough, fields);
            //Assert.IsType<GetDepartmentsResponse>(response);
        }

        /// <summary>
        /// Test DepartmentsDelete
        /// </summary>
        [Fact]
        public void DepartmentsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.DepartmentsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteDepartmentResponse>(response);
        }

        /// <summary>
        /// Test DepartmentsOne
        /// </summary>
        [Fact]
        public void DepartmentsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.DepartmentsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetDepartmentResponse>(response);
        }

        /// <summary>
        /// Test DepartmentsUpdate
        /// </summary>
        [Fact]
        public void DepartmentsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Department department = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.DepartmentsUpdate(id, department, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateDepartmentResponse>(response);
        }

        /// <summary>
        /// Test EmployeePayrollsAll
        /// </summary>
        [Fact]
        public void EmployeePayrollsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string employeeId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //PayrollsFilter filter = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.EmployeePayrollsAll(employeeId, raw, consumerId, appId, serviceId, filter, passThrough, fields);
            //Assert.IsType<GetEmployeePayrollsResponse>(response);
        }

        /// <summary>
        /// Test EmployeePayrollsOne
        /// </summary>
        [Fact]
        public void EmployeePayrollsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string payrollId = null;
            //string employeeId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string fields = null;
            //var response = instance.EmployeePayrollsOne(payrollId, employeeId, raw, consumerId, appId, serviceId, fields);
            //Assert.IsType<GetEmployeePayrollResponse>(response);
        }

        /// <summary>
        /// Test EmployeeSchedulesAll
        /// </summary>
        [Fact]
        public void EmployeeSchedulesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string employeeId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.EmployeeSchedulesAll(employeeId, raw, consumerId, appId, serviceId, passThrough, fields);
            //Assert.IsType<GetEmployeeSchedulesResponse>(response);
        }

        /// <summary>
        /// Test EmployeesAdd
        /// </summary>
        [Fact]
        public void EmployeesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Employee employee = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.EmployeesAdd(employee, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateEmployeeResponse>(response);
        }

        /// <summary>
        /// Test EmployeesAll
        /// </summary>
        [Fact]
        public void EmployeesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //EmployeesFilter filter = null;
            //EmployeesSort sort = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.EmployeesAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort, passThrough, fields);
            //Assert.IsType<GetEmployeesResponse>(response);
        }

        /// <summary>
        /// Test EmployeesDelete
        /// </summary>
        [Fact]
        public void EmployeesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.EmployeesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteEmployeeResponse>(response);
        }

        /// <summary>
        /// Test EmployeesOne
        /// </summary>
        [Fact]
        public void EmployeesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.EmployeesOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetEmployeeResponse>(response);
        }

        /// <summary>
        /// Test EmployeesUpdate
        /// </summary>
        [Fact]
        public void EmployeesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Employee employee = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.EmployeesUpdate(id, employee, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateEmployeeResponse>(response);
        }

        /// <summary>
        /// Test PayrollsAll
        /// </summary>
        [Fact]
        public void PayrollsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //PayrollsFilter filter = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.PayrollsAll(raw, consumerId, appId, serviceId, filter, passThrough, fields);
            //Assert.IsType<GetPayrollsResponse>(response);
        }

        /// <summary>
        /// Test PayrollsOne
        /// </summary>
        [Fact]
        public void PayrollsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string payrollId = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string fields = null;
            //var response = instance.PayrollsOne(payrollId, raw, consumerId, appId, serviceId, fields);
            //Assert.IsType<GetPayrollResponse>(response);
        }

        /// <summary>
        /// Test TimeOffRequestsAdd
        /// </summary>
        [Fact]
        public void TimeOffRequestsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TimeOffRequest timeOffRequest = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.TimeOffRequestsAdd(timeOffRequest, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateTimeOffRequestResponse>(response);
        }

        /// <summary>
        /// Test TimeOffRequestsAll
        /// </summary>
        [Fact]
        public void TimeOffRequestsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //TimeOffRequestsFilter filter = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.TimeOffRequestsAll(raw, consumerId, appId, serviceId, cursor, limit, filter, passThrough, fields);
            //Assert.IsType<GetTimeOffRequestsResponse>(response);
        }

        /// <summary>
        /// Test TimeOffRequestsDelete
        /// </summary>
        [Fact]
        public void TimeOffRequestsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.TimeOffRequestsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteTimeOffRequestResponse>(response);
        }

        /// <summary>
        /// Test TimeOffRequestsOne
        /// </summary>
        [Fact]
        public void TimeOffRequestsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.TimeOffRequestsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetTimeOffRequestResponse>(response);
        }

        /// <summary>
        /// Test TimeOffRequestsUpdate
        /// </summary>
        [Fact]
        public void TimeOffRequestsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TimeOffRequest timeOffRequest = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.TimeOffRequestsUpdate(id, timeOffRequest, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateTimeOffRequestResponse>(response);
        }
    }
}
