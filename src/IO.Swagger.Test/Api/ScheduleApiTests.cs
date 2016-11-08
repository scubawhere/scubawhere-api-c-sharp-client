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
    ///  Class for testing ScheduleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ScheduleApiTests
    {
        private ScheduleApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ScheduleApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScheduleApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ScheduleApi
            //Assert.IsInstanceOfType(typeof(ScheduleApi), instance, "instance is a ScheduleApi");
        }

        
        /// <summary>
        /// Test AddSchedule
        /// </summary>
        [Test]
        public void AddScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schedule = null;
            //long? trainingSessionId = null;
            //DateTime? until = null;
            //var response = instance.AddSchedule(schedule, trainingSessionId, until);
            //Assert.IsInstanceOf<InlineResponse2013> (response, "response is InlineResponse2013");
        }
        
        /// <summary>
        /// Test GetAllSchedules
        /// </summary>
        [Test]
        public void GetAllSchedulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllSchedules();
            //Assert.IsInstanceOf<List<Schedule>> (response, "response is List<Schedule>");
        }
        
        /// <summary>
        /// Test GetSchedule
        /// </summary>
        [Test]
        public void GetScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetSchedule(id);
            //Assert.IsInstanceOf<Schedule> (response, "response is Schedule");
        }
        
    }

}
