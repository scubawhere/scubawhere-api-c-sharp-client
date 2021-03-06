/* 
 * Scubawhere API Documentation
 *
 * This is the documentation for scubawhere's RMS API. This API is only to be used by authorized parties with valid auth tokens.  [Learn about scubawhere](http://www.scubawhere.com) to become an authorized consumer of our API 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: bryan@scubawhere.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CompanyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CompanyApiTests
    {
        private CompanyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CompanyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompanyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CompanyApi
            //Assert.IsInstanceOfType(typeof(CompanyApi), instance, "instance is a CompanyApi");
        }

        
        /// <summary>
        /// Test AttachLocations
        /// </summary>
        [Test]
        public void AttachLocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string description = null;
            //float? latitude = null;
            //float? longitude = null;
            //var response = instance.AttachLocations(name, description, latitude, longitude);
            //Assert.IsInstanceOf<InlineResponse20023> (response, "response is InlineResponse20023");
        }
        
        /// <summary>
        /// Test GetLocations
        /// </summary>
        [Test]
        public void GetLocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string latitude = null;
            //string longitude = null;
            //int? limit = null;
            //var response = instance.GetLocations(latitude, longitude, limit);
            //Assert.IsInstanceOf<InlineResponse20024> (response, "response is InlineResponse20024");
        }
        
        /// <summary>
        /// Test GetPickupSchedule
        /// </summary>
        [Test]
        public void GetPickupScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string date = null;
            //var response = instance.GetPickupSchedule(date);
            //Assert.IsInstanceOf<InlineResponse20025> (response, "response is InlineResponse20025");
        }
        
        /// <summary>
        /// Test UpdateCompany
        /// </summary>
        [Test]
        public void UpdateCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string contact = null;
            //string description = null;
            //string name = null;
            //string address1 = null;
            //string address2 = null;
            //string city = null;
            //string county = null;
            //string postcode = null;
            //long? countryId = null;
            //long? currencyId = null;
            //string businessPhone = null;
            //string businessEmail = null;
            //string vatNumber = null;
            //string registrationNumber = null;
            //string website = null;
            //var response = instance.UpdateCompany(id, contact, description, name, address1, address2, city, county, postcode, countryId, currencyId, businessPhone, businessEmail, vatNumber, registrationNumber, website);
            //Assert.IsInstanceOf<InlineResponse20026> (response, "response is InlineResponse20026");
        }
        
    }

}
