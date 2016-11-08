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
    ///  Class for testing ClassApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ClassApiTests
    {
        private ClassApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ClassApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ClassApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ClassApi
            //Assert.IsInstanceOfType(typeof(ClassApi), instance, "instance is a ClassApi");
        }

        
        /// <summary>
        /// Test ClassGet
        /// </summary>
        [Test]
        public void ClassGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.ClassGet(id);
            //Assert.IsInstanceOf<Training> (response, "response is Training");
        }
        
        /// <summary>
        /// Test CreateClass
        /// </summary>
        [Test]
        public void CreateClassTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //float? duration = null;
            //string description = null;
            //var response = instance.CreateClass(name, duration, description);
            //Assert.IsInstanceOf<InlineResponse20021> (response, "response is InlineResponse20021");
        }
        
        /// <summary>
        /// Test DeleteClass
        /// </summary>
        [Test]
        public void DeleteClassTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.DeleteClass(id);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test EditClass
        /// </summary>
        [Test]
        public void EditClassTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string name = null;
            //float? duration = null;
            //string description = null;
            //var response = instance.EditClass(id, name, duration, description);
            //Assert.IsInstanceOf<InlineResponse20022> (response, "response is InlineResponse20022");
        }
        
        /// <summary>
        /// Test GetAllClass
        /// </summary>
        [Test]
        public void GetAllClassTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllClass();
            //Assert.IsInstanceOf<List<Training>> (response, "response is List<Training>");
        }
        
        /// <summary>
        /// Test GetAllWithTrashedClass
        /// </summary>
        [Test]
        public void GetAllWithTrashedClassTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllWithTrashedClass();
            //Assert.IsInstanceOf<List<Training>> (response, "response is List<Training>");
        }
        
    }

}
