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
    ///  Class for testing BusinessApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BusinessApiTests : IDisposable
    {
        private BusinessApi instance;

        public BusinessApiTests()
        {
            instance = new BusinessApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BusinessApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BusinessApi
            //Assert.IsType<BusinessApi>(instance);
        }

        /// <summary>
        /// Test GetBusiness
        /// </summary>
        [Fact]
        public void GetBusinessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string code = null;
            //string name = null;
            //string email = null;
            //string? phone = null;
            //string? industry = null;
            //string? timezone = null;
            //string? privacyUrl = null;
            //string? termsUrl = null;
            //var response = instance.GetBusiness(code, name, email, phone, industry, timezone, privacyUrl, termsUrl);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test UpdateBusiness
        /// </summary>
        [Fact]
        public void UpdateBusinessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string businessName = null;
            //string primaryEmail = null;
            //string? primaryPhone = null;
            //string? industryKey = null;
            //string? timezoneId = null;
            //string? privacyUrl = null;
            //string? termsUrl = null;
            //string? isShowKindeBranding = null;
            //bool? isClickWrap = null;
            //string? partnerCode = null;
            //var response = instance.UpdateBusiness(businessName, primaryEmail, primaryPhone, industryKey, timezoneId, privacyUrl, termsUrl, isShowKindeBranding, isClickWrap, partnerCode);
            //Assert.IsType<SuccessResponse>(response);
        }
    }
}
