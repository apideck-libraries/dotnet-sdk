/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 10.0.0
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
    ///  Class for testing FileStorageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FileStorageApiTests : IDisposable
    {
        private FileStorageApi instance;

        public FileStorageApiTests()
        {
            instance = new FileStorageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileStorageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FileStorageApi
            //Assert.IsType<FileStorageApi>(instance);
        }

        /// <summary>
        /// Test DriveGroupsAdd
        /// </summary>
        [Fact]
        public void DriveGroupsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DriveGroup driveGroup = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.DriveGroupsAdd(driveGroup, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateDriveGroupResponse>(response);
        }

        /// <summary>
        /// Test DriveGroupsAll
        /// </summary>
        [Fact]
        public void DriveGroupsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //DriveGroupsFilter filter = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.DriveGroupsAll(raw, consumerId, appId, serviceId, cursor, limit, filter, passThrough, fields);
            //Assert.IsType<GetDriveGroupsResponse>(response);
        }

        /// <summary>
        /// Test DriveGroupsDelete
        /// </summary>
        [Fact]
        public void DriveGroupsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.DriveGroupsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteDriveGroupResponse>(response);
        }

        /// <summary>
        /// Test DriveGroupsOne
        /// </summary>
        [Fact]
        public void DriveGroupsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.DriveGroupsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetDriveGroupResponse>(response);
        }

        /// <summary>
        /// Test DriveGroupsUpdate
        /// </summary>
        [Fact]
        public void DriveGroupsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DriveGroup driveGroup = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.DriveGroupsUpdate(id, driveGroup, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateDriveGroupResponse>(response);
        }

        /// <summary>
        /// Test DrivesAdd
        /// </summary>
        [Fact]
        public void DrivesAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Drive drive = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.DrivesAdd(drive, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateDriveResponse>(response);
        }

        /// <summary>
        /// Test DrivesAll
        /// </summary>
        [Fact]
        public void DrivesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //DrivesFilter filter = null;
            //string fields = null;
            //var response = instance.DrivesAll(raw, consumerId, appId, serviceId, cursor, limit, filter, fields);
            //Assert.IsType<GetDrivesResponse>(response);
        }

        /// <summary>
        /// Test DrivesDelete
        /// </summary>
        [Fact]
        public void DrivesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.DrivesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteDriveResponse>(response);
        }

        /// <summary>
        /// Test DrivesOne
        /// </summary>
        [Fact]
        public void DrivesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.DrivesOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetDriveResponse>(response);
        }

        /// <summary>
        /// Test DrivesUpdate
        /// </summary>
        [Fact]
        public void DrivesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Drive drive = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.DrivesUpdate(id, drive, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateDriveResponse>(response);
        }

        /// <summary>
        /// Test FilesAll
        /// </summary>
        [Fact]
        public void FilesAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string cursor = null;
            //int? limit = null;
            //FilesFilter filter = null;
            //FilesSort sort = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //var response = instance.FilesAll(raw, consumerId, appId, serviceId, cursor, limit, filter, sort, passThrough, fields);
            //Assert.IsType<GetFilesResponse>(response);
        }

        /// <summary>
        /// Test FilesDelete
        /// </summary>
        [Fact]
        public void FilesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.FilesDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteFileResponse>(response);
        }

        /// <summary>
        /// Test FilesDownload
        /// </summary>
        [Fact]
        public void FilesDownloadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string fields = null;
            //var response = instance.FilesDownload(id, consumerId, appId, serviceId, fields);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test FilesExport
        /// </summary>
        [Fact]
        public void FilesExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string format = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string fields = null;
            //var response = instance.FilesExport(id, format, consumerId, appId, serviceId, fields);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test FilesOne
        /// </summary>
        [Fact]
        public void FilesOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.FilesOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetFileResponse>(response);
        }

        /// <summary>
        /// Test FilesSearch
        /// </summary>
        [Fact]
        public void FilesSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FilesSearch filesSearch = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //PassThroughQuery passThrough = null;
            //string fields = null;
            //string cursor = null;
            //int? limit = null;
            //var response = instance.FilesSearch(filesSearch, consumerId, appId, serviceId, passThrough, fields, cursor, limit);
            //Assert.IsType<GetFilesResponse>(response);
        }

        /// <summary>
        /// Test FilesUpdate
        /// </summary>
        [Fact]
        public void FilesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UpdateFileRequest updateFileRequest = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.FilesUpdate(id, updateFileRequest, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateFileResponse>(response);
        }

        /// <summary>
        /// Test FoldersAdd
        /// </summary>
        [Fact]
        public void FoldersAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFolderRequest createFolderRequest = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string fields = null;
            //var response = instance.FoldersAdd(createFolderRequest, raw, consumerId, appId, serviceId, fields);
            //Assert.IsType<CreateFolderResponse>(response);
        }

        /// <summary>
        /// Test FoldersCopy
        /// </summary>
        [Fact]
        public void FoldersCopyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CopyFolderRequest copyFolderRequest = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.FoldersCopy(id, copyFolderRequest, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<UpdateFolderResponse>(response);
        }

        /// <summary>
        /// Test FoldersDelete
        /// </summary>
        [Fact]
        public void FoldersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.FoldersDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteFolderResponse>(response);
        }

        /// <summary>
        /// Test FoldersOne
        /// </summary>
        [Fact]
        public void FoldersOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.FoldersOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetFolderResponse>(response);
        }

        /// <summary>
        /// Test FoldersUpdate
        /// </summary>
        [Fact]
        public void FoldersUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UpdateFolderRequest updateFolderRequest = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.FoldersUpdate(id, updateFolderRequest, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateFolderResponse>(response);
        }

        /// <summary>
        /// Test SharedLinksAdd
        /// </summary>
        [Fact]
        public void SharedLinksAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SharedLink sharedLink = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.SharedLinksAdd(sharedLink, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateSharedLinkResponse>(response);
        }

        /// <summary>
        /// Test SharedLinksAll
        /// </summary>
        [Fact]
        public void SharedLinksAllTest()
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
            //var response = instance.SharedLinksAll(raw, consumerId, appId, serviceId, cursor, limit, passThrough, fields);
            //Assert.IsType<GetSharedLinksResponse>(response);
        }

        /// <summary>
        /// Test SharedLinksDelete
        /// </summary>
        [Fact]
        public void SharedLinksDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.SharedLinksDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteSharedLinkResponse>(response);
        }

        /// <summary>
        /// Test SharedLinksOne
        /// </summary>
        [Fact]
        public void SharedLinksOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.SharedLinksOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetSharedLinkResponse>(response);
        }

        /// <summary>
        /// Test SharedLinksUpdate
        /// </summary>
        [Fact]
        public void SharedLinksUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //SharedLink sharedLink = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.SharedLinksUpdate(id, sharedLink, consumerId, appId, serviceId, raw);
            //Assert.IsType<UpdateSharedLinkResponse>(response);
        }

        /// <summary>
        /// Test UploadSessionsAdd
        /// </summary>
        [Fact]
        public void UploadSessionsAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUploadSessionRequest createUploadSessionRequest = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //var response = instance.UploadSessionsAdd(createUploadSessionRequest, raw, consumerId, appId, serviceId);
            //Assert.IsType<CreateUploadSessionResponse>(response);
        }

        /// <summary>
        /// Test UploadSessionsDelete
        /// </summary>
        [Fact]
        public void UploadSessionsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //var response = instance.UploadSessionsDelete(id, consumerId, appId, serviceId, raw);
            //Assert.IsType<DeleteUploadSessionResponse>(response);
        }

        /// <summary>
        /// Test UploadSessionsFinish
        /// </summary>
        [Fact]
        public void UploadSessionsFinishTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? raw = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //string digest = null;
            //Object body = null;
            //var response = instance.UploadSessionsFinish(id, raw, consumerId, appId, serviceId, digest, body);
            //Assert.IsType<GetFileResponse>(response);
        }

        /// <summary>
        /// Test UploadSessionsOne
        /// </summary>
        [Fact]
        public void UploadSessionsOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string consumerId = null;
            //string appId = null;
            //string serviceId = null;
            //bool? raw = null;
            //string fields = null;
            //var response = instance.UploadSessionsOne(id, consumerId, appId, serviceId, raw, fields);
            //Assert.IsType<GetUploadSessionResponse>(response);
        }
    }
}
