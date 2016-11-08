# IO.Swagger.Api.BookingApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBookingDetail**](BookingApi.md#addbookingdetail) | **POST** /booking/add-detail | Add a package / course / ticket with its session to the booking
[**AttachAccommodation**](BookingApi.md#attachaccommodation) | **POST** /booking/add-accommodation | Attach an accommodation booking to a booking
[**AttachAddon**](BookingApi.md#attachaddon) | **POST** /booking/add-addon | Attach an addon to a trip of a booking
[**AttachPickup**](BookingApi.md#attachpickup) | **POST** /booking/add-pickup | Attach a pickup location for a booking
[**CancelBooking**](BookingApi.md#cancelbooking) | **POST** /booking/cancel | Cancel a booking
[**ConfirmBooking**](BookingApi.md#confirmbooking) | **POST** /booking/confirm | Confirm a booking and all of its sessions and notify the lead customer
[**DeleteBooking**](BookingApi.md#deletebooking) | **DELETE** /booking/delete | Delete a booking by ID
[**DettachAccommodation**](BookingApi.md#dettachaccommodation) | **POST** /booking/remove-accommodation | Dettach an accommodation booking to a booking
[**DettachAddon**](BookingApi.md#dettachaddon) | **POST** /booking/remove-addon | Dettach an addon to a trip of a booking
[**DettachPickup**](BookingApi.md#dettachpickup) | **POST** /booking/remove-pickup | Dettach a pickup location for a booking
[**EditBookingInfo**](BookingApi.md#editbookinginfo) | **POST** /booking/edit-info | Edit the information related to a booking
[**FilterBookings**](BookingApi.md#filterbookings) | **GET** /booking/filter | Get all bookings matching a filter
[**GetAllBookings**](BookingApi.md#getallbookings) | **GET** /booking/all | Retrieve all bookings
[**GetAllWithTrashedBookings**](BookingApi.md#getallwithtrashedbookings) | **GET** /booking/all-with-trashed | Retrieve all bookings including any deleted models
[**GetBooking**](BookingApi.md#getbooking) | **GET** /booking | Retrieve a booking by ID
[**GetCustomerBookings**](BookingApi.md#getcustomerbookings) | **GET** /booking/customer | Get all bookings for a customer
[**GetPayments**](BookingApi.md#getpayments) | **GET** /booking/payments | Retrieve all payments made for a booking
[**GetRefunds**](BookingApi.md#getrefunds) | **GET** /booking/refunds | Retrieve all refunds for a booking
[**GetTodaysBookings**](BookingApi.md#gettodaysbookings) | **GET** /booking/today | Get all bookings made today
[**GetTommorowsBookings**](BookingApi.md#gettommorowsbookings) | **GET** /booking/tommorow | Get all bookings made today
[**InitBooking**](BookingApi.md#initbooking) | **POST** /booking/init | Create a new empty booking
[**RemoveBookingDetail**](BookingApi.md#removebookingdetail) | **POST** /booking/remove-detail | Remove a detail from a booking
[**ResendConfirmation**](BookingApi.md#resendconfirmation) | **POST** /booking/resend-confirmation | Resend the confirmation email to the lead customer
[**ReserveBooking**](BookingApi.md#reservebooking) | **POST** /booking/reserve | Reserve a booking and its sessions capcity until a set date
[**SaveBooking**](BookingApi.md#savebooking) | **POST** /booking/save | Save a booking as a quote and release all capacity of sessions
[**SetLeadCustomer**](BookingApi.md#setleadcustomer) | **POST** /booking/set-lead | Set the lead customer for a booking


<a name="addbookingdetail"></a>
# **AddBookingDetail**
> InlineResponse20010 AddBookingDetail (long? bookingId, long? customerId, long? ticketId = null, long? sessionId = null, long? boatroomId = null, long? trainingSessionId = null, bool? temporary = null, long? packageId = null, long? packagefacadeId = null, long? courseId = null)

Add a package / course / ticket with its session to the booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddBookingDetailExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var customerId = 789;  // long? | 
            var ticketId = 789;  // long? |  (optional) 
            var sessionId = 789;  // long? |  (optional) 
            var boatroomId = 789;  // long? |  (optional) 
            var trainingSessionId = 789;  // long? |  (optional) 
            var temporary = true;  // bool? |  (optional) 
            var packageId = 789;  // long? |  (optional) 
            var packagefacadeId = 789;  // long? |  (optional) 
            var courseId = 789;  // long? |  (optional) 

            try
            {
                // Add a package / course / ticket with its session to the booking
                InlineResponse20010 result = apiInstance.AddBookingDetail(bookingId, customerId, ticketId, sessionId, boatroomId, trainingSessionId, temporary, packageId, packagefacadeId, courseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.AddBookingDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **customerId** | **long?**|  | 
 **ticketId** | **long?**|  | [optional] 
 **sessionId** | **long?**|  | [optional] 
 **boatroomId** | **long?**|  | [optional] 
 **trainingSessionId** | **long?**|  | [optional] 
 **temporary** | **bool?**|  | [optional] 
 **packageId** | **long?**|  | [optional] 
 **packagefacadeId** | **long?**|  | [optional] 
 **courseId** | **long?**|  | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachaccommodation"></a>
# **AttachAccommodation**
> InlineResponse2008 AttachAccommodation (long? bookingId, long? accommodationId, long? customerId, DateTime? start = null, DateTime? end = null)

Attach an accommodation booking to a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachAccommodationExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var accommodationId = 789;  // long? | 
            var customerId = 789;  // long? | 
            var start = 2013-10-20;  // DateTime? |  (optional) 
            var end = 2013-10-20;  // DateTime? |  (optional) 

            try
            {
                // Attach an accommodation booking to a booking
                InlineResponse2008 result = apiInstance.AttachAccommodation(bookingId, accommodationId, customerId, start, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.AttachAccommodation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **accommodationId** | **long?**|  | 
 **customerId** | **long?**|  | 
 **start** | **DateTime?**|  | [optional] 
 **end** | **DateTime?**|  | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachaddon"></a>
# **AttachAddon**
> InlineResponse2009 AttachAddon (long? bookingId, long? bookingdetailId, long? addonId, long? quantity = null, long? packagefacadeId = null)

Attach an addon to a trip of a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachAddonExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var bookingdetailId = 789;  // long? | 
            var addonId = 789;  // long? | 
            var quantity = 789;  // long? |  (optional) 
            var packagefacadeId = 789;  // long? |  (optional) 

            try
            {
                // Attach an addon to a trip of a booking
                InlineResponse2009 result = apiInstance.AttachAddon(bookingId, bookingdetailId, addonId, quantity, packagefacadeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.AttachAddon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **bookingdetailId** | **long?**|  | 
 **addonId** | **long?**|  | 
 **quantity** | **long?**|  | [optional] 
 **packagefacadeId** | **long?**|  | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachpickup"></a>
# **AttachPickup**
> InlineResponse20011 AttachPickup (long? bookingId, string location, DateTime? date, string time)

Attach a pickup location for a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachPickupExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var location = location_example;  // string | 
            var date = 2013-10-20;  // DateTime? | 
            var time = time_example;  // string | 

            try
            {
                // Attach a pickup location for a booking
                InlineResponse20011 result = apiInstance.AttachPickup(bookingId, location, date, time);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.AttachPickup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **location** | **string**|  | 
 **date** | **DateTime?**|  | 
 **time** | **string**|  | 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelbooking"></a>
# **CancelBooking**
> InlineResponse2003 CancelBooking (long? bookingId)

Cancel a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelBookingExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 

            try
            {
                // Cancel a booking
                InlineResponse2003 result = apiInstance.CancelBooking(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.CancelBooking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmbooking"></a>
# **ConfirmBooking**
> InlineResponse20012 ConfirmBooking (long? bookingId)

Confirm a booking and all of its sessions and notify the lead customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfirmBookingExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 

            try
            {
                // Confirm a booking and all of its sessions and notify the lead customer
                InlineResponse20012 result = apiInstance.ConfirmBooking(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.ConfirmBooking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebooking"></a>
# **DeleteBooking**
> InlineResponse2003 DeleteBooking (long? id)

Delete a booking by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBookingExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a booking by ID
                InlineResponse2003 result = apiInstance.DeleteBooking(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.DeleteBooking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dettachaccommodation"></a>
# **DettachAccommodation**
> InlineResponse20017 DettachAccommodation (long? bookingId, long? accommodationId, long? customerId, DateTime? start = null)

Dettach an accommodation booking to a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DettachAccommodationExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var accommodationId = 789;  // long? | 
            var customerId = 789;  // long? | 
            var start = 2013-10-20;  // DateTime? |  (optional) 

            try
            {
                // Dettach an accommodation booking to a booking
                InlineResponse20017 result = apiInstance.DettachAccommodation(bookingId, accommodationId, customerId, start);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.DettachAccommodation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **accommodationId** | **long?**|  | 
 **customerId** | **long?**|  | 
 **start** | **DateTime?**|  | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dettachaddon"></a>
# **DettachAddon**
> InlineResponse20017 DettachAddon (long? bookingId, long? bookingdetailId, long? addonId, long? packagefacadeId = null)

Dettach an addon to a trip of a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DettachAddonExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var bookingdetailId = 789;  // long? | 
            var addonId = 789;  // long? | 
            var packagefacadeId = 789;  // long? |  (optional) 

            try
            {
                // Dettach an addon to a trip of a booking
                InlineResponse20017 result = apiInstance.DettachAddon(bookingId, bookingdetailId, addonId, packagefacadeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.DettachAddon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **bookingdetailId** | **long?**|  | 
 **addonId** | **long?**|  | 
 **packagefacadeId** | **long?**|  | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dettachpickup"></a>
# **DettachPickup**
> InlineResponse2003 DettachPickup (long? bookingId, long? id = null)

Dettach a pickup location for a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DettachPickupExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var id = 789;  // long? |  (optional) 

            try
            {
                // Dettach a pickup location for a booking
                InlineResponse2003 result = apiInstance.DettachPickup(bookingId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.DettachPickup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **id** | **long?**|  | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editbookinginfo"></a>
# **EditBookingInfo**
> InlineResponse20014 EditBookingInfo (long? bookingId = null, double? discount = null, string comment = null)

Edit the information related to a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditBookingInfoExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? |  (optional) 
            var discount = 1.2;  // double? |  (optional) 
            var comment = comment_example;  // string |  (optional) 

            try
            {
                // Edit the information related to a booking
                InlineResponse20014 result = apiInstance.EditBookingInfo(bookingId, discount, comment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.EditBookingInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | [optional] 
 **discount** | **double?**|  | [optional] 
 **comment** | **string**|  | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filterbookings"></a>
# **FilterBookings**
> InlineResponse20013 FilterBookings (string reference = null, DateTime? date = null, string lastname = null)

Get all bookings matching a filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FilterBookingsExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var reference = reference_example;  // string |  (optional) 
            var date = 2013-10-20;  // DateTime? |  (optional) 
            var lastname = lastname_example;  // string |  (optional) 

            try
            {
                // Get all bookings matching a filter
                InlineResponse20013 result = apiInstance.FilterBookings(reference, date, lastname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.FilterBookings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reference** | **string**|  | [optional] 
 **date** | **DateTime?**|  | [optional] 
 **lastname** | **string**|  | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallbookings"></a>
# **GetAllBookings**
> List<Booking> GetAllBookings ()

Retrieve all bookings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllBookingsExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();

            try
            {
                // Retrieve all bookings
                List&lt;Booking&gt; result = apiInstance.GetAllBookings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.GetAllBookings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Booking>**](Booking.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedbookings"></a>
# **GetAllWithTrashedBookings**
> List<Booking> GetAllWithTrashedBookings ()

Retrieve all bookings including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedBookingsExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();

            try
            {
                // Retrieve all bookings including any deleted models
                List&lt;Booking&gt; result = apiInstance.GetAllWithTrashedBookings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.GetAllWithTrashedBookings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Booking>**](Booking.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbooking"></a>
# **GetBooking**
> InlineResponse2007 GetBooking (long? id)

Retrieve a booking by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBookingExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a booking by ID
                InlineResponse2007 result = apiInstance.GetBooking(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.GetBooking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerbookings"></a>
# **GetCustomerBookings**
> InlineResponse20013 GetCustomerBookings (long? customerId)

Get all bookings for a customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomerBookingsExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var customerId = 789;  // long? | 

            try
            {
                // Get all bookings for a customer
                InlineResponse20013 result = apiInstance.GetCustomerBookings(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.GetCustomerBookings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **long?**|  | 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayments"></a>
# **GetPayments**
> InlineResponse20015 GetPayments (long? bookingId = null)

Retrieve all payments made for a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentsExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? |  (optional) 

            try
            {
                // Retrieve all payments made for a booking
                InlineResponse20015 result = apiInstance.GetPayments(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.GetPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrefunds"></a>
# **GetRefunds**
> InlineResponse20016 GetRefunds (long? bookingId = null)

Retrieve all refunds for a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRefundsExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? |  (optional) 

            try
            {
                // Retrieve all refunds for a booking
                InlineResponse20016 result = apiInstance.GetRefunds(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.GetRefunds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | [optional] 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettodaysbookings"></a>
# **GetTodaysBookings**
> InlineResponse20013 GetTodaysBookings ()

Get all bookings made today

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTodaysBookingsExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();

            try
            {
                // Get all bookings made today
                InlineResponse20013 result = apiInstance.GetTodaysBookings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.GetTodaysBookings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettommorowsbookings"></a>
# **GetTommorowsBookings**
> InlineResponse20013 GetTommorowsBookings ()

Get all bookings made today

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTommorowsBookingsExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();

            try
            {
                // Get all bookings made today
                InlineResponse20013 result = apiInstance.GetTommorowsBookings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.GetTommorowsBookings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initbooking"></a>
# **InitBooking**
> InlineResponse201 InitBooking (string source, long? agentId = null, string agentReference = null)

Create a new empty booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitBookingExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var source = source_example;  // string | 
            var agentId = 789;  // long? |  (optional) 
            var agentReference = agentReference_example;  // string |  (optional) 

            try
            {
                // Create a new empty booking
                InlineResponse201 result = apiInstance.InitBooking(source, agentId, agentReference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.InitBooking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**|  | 
 **agentId** | **long?**|  | [optional] 
 **agentReference** | **string**|  | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removebookingdetail"></a>
# **RemoveBookingDetail**
> InlineResponse20017 RemoveBookingDetail (long? bookingId, long? bookingdetailId)

Remove a detail from a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveBookingDetailExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var bookingdetailId = 789;  // long? | 

            try
            {
                // Remove a detail from a booking
                InlineResponse20017 result = apiInstance.RemoveBookingDetail(bookingId, bookingdetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.RemoveBookingDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **bookingdetailId** | **long?**|  | 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resendconfirmation"></a>
# **ResendConfirmation**
> InlineResponse2003 ResendConfirmation (long? bookingId)

Resend the confirmation email to the lead customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResendConfirmationExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 

            try
            {
                // Resend the confirmation email to the lead customer
                InlineResponse2003 result = apiInstance.ResendConfirmation(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.ResendConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reservebooking"></a>
# **ReserveBooking**
> InlineResponse20018 ReserveBooking (long? bookingId, DateTime? reservedUntil = null)

Reserve a booking and its sessions capcity until a set date

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReserveBookingExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var reservedUntil = 2013-10-20;  // DateTime? |  (optional) 

            try
            {
                // Reserve a booking and its sessions capcity until a set date
                InlineResponse20018 result = apiInstance.ReserveBooking(bookingId, reservedUntil);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.ReserveBooking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **reservedUntil** | **DateTime?**|  | [optional] 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savebooking"></a>
# **SaveBooking**
> InlineResponse2003 SaveBooking (long? bookingId)

Save a booking as a quote and release all capacity of sessions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveBookingExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 

            try
            {
                // Save a booking as a quote and release all capacity of sessions
                InlineResponse2003 result = apiInstance.SaveBooking(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.SaveBooking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setleadcustomer"></a>
# **SetLeadCustomer**
> InlineResponse2003 SetLeadCustomer (long? bookingId, long? customerId)

Set the lead customer for a booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetLeadCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new BookingApi();
            var bookingId = 789;  // long? | 
            var customerId = 789;  // long? | 

            try
            {
                // Set the lead customer for a booking
                InlineResponse2003 result = apiInstance.SetLeadCustomer(bookingId, customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BookingApi.SetLeadCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **customerId** | **long?**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

