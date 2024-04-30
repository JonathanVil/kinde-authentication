/*
 * Kinde Management API
 *
 * Provides endpoints to manage your Kinde Businesses
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Kinde.Api.Client;
using Kinde.Api.Api;
// uncomment below to import models
//using Kinde.Api.Model;

namespace Kinde.Api.Test.Api
{
    /// <summary>
    ///  Class for testing PermissionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PermissionsApiTests : IDisposable
    {
        private PermissionsApi instance;

        public PermissionsApiTests()
        {
            instance = new PermissionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PermissionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PermissionsApi
            //Assert.IsType<PermissionsApi>(instance);
        }

        /// <summary>
        /// Test CreatePermission
        /// </summary>
        [Fact]
        public void CreatePermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreatePermissionRequest? createPermissionRequest = null;
            //var response = instance.CreatePermission(createPermissionRequest);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test DeletePermission
        /// </summary>
        [Fact]
        public void DeletePermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string permissionId = null;
            //var response = instance.DeletePermission(permissionId);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test GetPermissions
        /// </summary>
        [Fact]
        public void GetPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? sort = null;
            //int? pageSize = null;
            //string? nextToken = null;
            //var response = instance.GetPermissions(sort, pageSize, nextToken);
            //Assert.IsType<GetPermissionsResponse>(response);
        }

        /// <summary>
        /// Test UpdatePermissions
        /// </summary>
        [Fact]
        public void UpdatePermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int permissionId = null;
            //CreatePermissionRequest? createPermissionRequest = null;
            //var response = instance.UpdatePermissions(permissionId, createPermissionRequest);
            //Assert.IsType<SuccessResponse>(response);
        }
    }
}
