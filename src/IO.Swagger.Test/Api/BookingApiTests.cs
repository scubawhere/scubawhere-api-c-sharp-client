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
    ///  Class for testing BookingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BookingApiTests
    {
        private BookingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BookingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BookingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BookingApi
            //Assert.IsInstanceOfType(typeof(BookingApi), instance, "instance is a BookingApi");
        }

        
        /// <summary>
        /// Test AddBookingDetail
        /// </summary>
        [Test]
        public void AddBookingDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //long? customerId = null;
            //long? ticketId = null;
            //long? sessionId = null;
            //long? boatroomId = null;
            //long? trainingSessionId = null;
            //bool? temporary = null;
            //long? packageId = null;
            //long? packagefacadeId = null;
            //long? courseId = null;
            //var response = instance.AddBookingDetail(bookingId, customerId, ticketId, sessionId, boatroomId, trainingSessionId, temporary, packageId, packagefacadeId, courseId);
            //Assert.IsInstanceOf<InlineResponse20010> (response, "response is InlineResponse20010");
        }
        
        /// <summary>
        /// Test AttachAccommodation
        /// </summary>
        [Test]
        public void AttachAccommodationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //long? accommodationId = null;
            //long? customerId = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //var response = instance.AttachAccommodation(bookingId, accommodationId, customerId, start, end);
            //Assert.IsInstanceOf<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test AttachAddon
        /// </summary>
        [Test]
        public void AttachAddonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //long? bookingdetailId = null;
            //long? addonId = null;
            //long? quantity = null;
            //long? packagefacadeId = null;
            //var response = instance.AttachAddon(bookingId, bookingdetailId, addonId, quantity, packagefacadeId);
            //Assert.IsInstanceOf<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test AttachPickup
        /// </summary>
        [Test]
        public void AttachPickupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //string location = null;
            //DateTime? date = null;
            //string time = null;
            //var response = instance.AttachPickup(bookingId, location, date, time);
            //Assert.IsInstanceOf<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test CancelBooking
        /// </summary>
        [Test]
        public void CancelBookingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //var response = instance.CancelBooking(bookingId);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test ConfirmBooking
        /// </summary>
        [Test]
        public void ConfirmBookingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //var response = instance.ConfirmBooking(bookingId);
            //Assert.IsInstanceOf<InlineResponse20012> (response, "response is InlineResponse20012");
        }
        
        /// <summary>
        /// Test DeleteBooking
        /// </summary>
        [Test]
        public void DeleteBookingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.DeleteBooking(id);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test DettachAccommodation
        /// </summary>
        [Test]
        public void DettachAccommodationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //long? accommodationId = null;
            //long? customerId = null;
            //DateTime? start = null;
            //var response = instance.DettachAccommodation(bookingId, accommodationId, customerId, start);
            //Assert.IsInstanceOf<InlineResponse20017> (response, "response is InlineResponse20017");
        }
        
        /// <summary>
        /// Test DettachAddon
        /// </summary>
        [Test]
        public void DettachAddonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //long? bookingdetailId = null;
            //long? addonId = null;
            //long? packagefacadeId = null;
            //var response = instance.DettachAddon(bookingId, bookingdetailId, addonId, packagefacadeId);
            //Assert.IsInstanceOf<InlineResponse20017> (response, "response is InlineResponse20017");
        }
        
        /// <summary>
        /// Test DettachPickup
        /// </summary>
        [Test]
        public void DettachPickupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //long? id = null;
            //var response = instance.DettachPickup(bookingId, id);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test EditBookingInfo
        /// </summary>
        [Test]
        public void EditBookingInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //double? discount = null;
            //string comment = null;
            //var response = instance.EditBookingInfo(bookingId, discount, comment);
            //Assert.IsInstanceOf<InlineResponse20014> (response, "response is InlineResponse20014");
        }
        
        /// <summary>
        /// Test FilterBookings
        /// </summary>
        [Test]
        public void FilterBookingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reference = null;
            //DateTime? date = null;
            //string lastname = null;
            //var response = instance.FilterBookings(reference, date, lastname);
            //Assert.IsInstanceOf<InlineResponse20013> (response, "response is InlineResponse20013");
        }
        
        /// <summary>
        /// Test GetAllBookings
        /// </summary>
        [Test]
        public void GetAllBookingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllBookings();
            //Assert.IsInstanceOf<List<Booking>> (response, "response is List<Booking>");
        }
        
        /// <summary>
        /// Test GetAllWithTrashedBookings
        /// </summary>
        [Test]
        public void GetAllWithTrashedBookingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllWithTrashedBookings();
            //Assert.IsInstanceOf<List<Booking>> (response, "response is List<Booking>");
        }
        
        /// <summary>
        /// Test GetBooking
        /// </summary>
        [Test]
        public void GetBookingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetBooking(id);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test GetCustomerBookings
        /// </summary>
        [Test]
        public void GetCustomerBookingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? customerId = null;
            //var response = instance.GetCustomerBookings(customerId);
            //Assert.IsInstanceOf<InlineResponse20013> (response, "response is InlineResponse20013");
        }
        
        /// <summary>
        /// Test GetPayments
        /// </summary>
        [Test]
        public void GetPaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //var response = instance.GetPayments(bookingId);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GetRefunds
        /// </summary>
        [Test]
        public void GetRefundsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //var response = instance.GetRefunds(bookingId);
            //Assert.IsInstanceOf<InlineResponse20016> (response, "response is InlineResponse20016");
        }
        
        /// <summary>
        /// Test GetTodaysBookings
        /// </summary>
        [Test]
        public void GetTodaysBookingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTodaysBookings();
            //Assert.IsInstanceOf<InlineResponse20013> (response, "response is InlineResponse20013");
        }
        
        /// <summary>
        /// Test GetTommorowsBookings
        /// </summary>
        [Test]
        public void GetTommorowsBookingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTommorowsBookings();
            //Assert.IsInstanceOf<InlineResponse20013> (response, "response is InlineResponse20013");
        }
        
        /// <summary>
        /// Test InitBooking
        /// </summary>
        [Test]
        public void InitBookingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string source = null;
            //long? agentId = null;
            //string agentReference = null;
            //var response = instance.InitBooking(source, agentId, agentReference);
            //Assert.IsInstanceOf<InlineResponse201> (response, "response is InlineResponse201");
        }
        
        /// <summary>
        /// Test RemoveBookingDetail
        /// </summary>
        [Test]
        public void RemoveBookingDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //long? bookingdetailId = null;
            //var response = instance.RemoveBookingDetail(bookingId, bookingdetailId);
            //Assert.IsInstanceOf<InlineResponse20017> (response, "response is InlineResponse20017");
        }
        
        /// <summary>
        /// Test ResendConfirmation
        /// </summary>
        [Test]
        public void ResendConfirmationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //var response = instance.ResendConfirmation(bookingId);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test ReserveBooking
        /// </summary>
        [Test]
        public void ReserveBookingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //DateTime? reservedUntil = null;
            //var response = instance.ReserveBooking(bookingId, reservedUntil);
            //Assert.IsInstanceOf<InlineResponse20018> (response, "response is InlineResponse20018");
        }
        
        /// <summary>
        /// Test SaveBooking
        /// </summary>
        [Test]
        public void SaveBookingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //var response = instance.SaveBooking(bookingId);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test SetLeadCustomer
        /// </summary>
        [Test]
        public void SetLeadCustomerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? bookingId = null;
            //long? customerId = null;
            //var response = instance.SetLeadCustomer(bookingId, customerId);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
    }

}
