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
    ///  Class for testing SessionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SessionApiTests
    {
        private SessionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SessionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SessionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SessionApi
            //Assert.IsInstanceOfType(typeof(SessionApi), instance, "instance is a SessionApi");
        }

        
        /// <summary>
        /// Test CreateSession
        /// </summary>
        [Test]
        public void CreateSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //long? boatId = null;
            //long? tripId = null;
            //var response = instance.CreateSession(start, boatId, tripId);
            //Assert.IsInstanceOf<InlineResponse20043> (response, "response is InlineResponse20043");
        }
        
        /// <summary>
        /// Test DeleteSession
        /// </summary>
        [Test]
        public void DeleteSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.DeleteSession(id);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test EditSession
        /// </summary>
        [Test]
        public void EditSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //DateTime? start = null;
            //long? boatId = null;
            //var response = instance.EditSession(id, start, boatId);
            //Assert.IsInstanceOf<InlineResponse20044> (response, "response is InlineResponse20044");
        }
        
        /// <summary>
        /// Test FilterSessions
        /// </summary>
        [Test]
        public void FilterSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? after = null;
            //DateTime? before = null;
            //long? tripId = null;
            //long? ticketId = null;
            //long? packageId = null;
            //long? courseId = null;
            //var response = instance.FilterSessions(after, before, tripId, ticketId, packageId, courseId);
            //Assert.IsInstanceOf<InlineResponse20045> (response, "response is InlineResponse20045");
        }
        
        /// <summary>
        /// Test GetAllSessions
        /// </summary>
        [Test]
        public void GetAllSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllSessions();
            //Assert.IsInstanceOf<List<Session>> (response, "response is List<Session>");
        }
        
        /// <summary>
        /// Test GetAllWithTrashedSessions
        /// </summary>
        [Test]
        public void GetAllWithTrashedSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllWithTrashedSessions();
            //Assert.IsInstanceOf<List<Session>> (response, "response is List<Session>");
        }
        
        /// <summary>
        /// Test GetManifest
        /// </summary>
        [Test]
        public void GetManifestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetManifest(id);
            //Assert.IsInstanceOf<InlineResponse20043> (response, "response is InlineResponse20043");
        }
        
        /// <summary>
        /// Test GetSession
        /// </summary>
        [Test]
        public void GetSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetSession(id);
            //Assert.IsInstanceOf<InlineResponse20043> (response, "response is InlineResponse20043");
        }
        
        /// <summary>
        /// Test GetTodaySessions
        /// </summary>
        [Test]
        public void GetTodaySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTodaySessions();
            //Assert.IsInstanceOf<InlineResponse20045> (response, "response is InlineResponse20045");
        }
        
        /// <summary>
        /// Test GetTommorowSessions
        /// </summary>
        [Test]
        public void GetTommorowSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTommorowSessions();
            //Assert.IsInstanceOf<InlineResponse20045> (response, "response is InlineResponse20045");
        }
        
    }

}
