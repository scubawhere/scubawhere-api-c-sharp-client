# IO.Swagger.Api.TicketApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTicket**](TicketApi.md#addticket) | **POST** /ticket/add | Create a new ticket
[**DeleteTicket**](TicketApi.md#deleteticket) | **DELETE** /ticket/delete | Delete a ticket
[**EditTicket**](TicketApi.md#editticket) | **PUT** /ticket/edit | Update an existing ticket
[**GetAllAvailableTickets**](TicketApi.md#getallavailabletickets) | **GET** /ticket/only-available | Retrieve all tickets that are available to booked today
[**GetAllTickets**](TicketApi.md#getalltickets) | **GET** /ticket/all | Retrieve all tickets
[**GetAllWithTrashedTickets**](TicketApi.md#getallwithtrashedtickets) | **GET** /ticket/all-with-trashed | Retrieve all tickets
[**GetTicket**](TicketApi.md#getticket) | **GET** /ticket | Retrieve a ticket by ID


<a name="addticket"></a>
# **AddTicket**
> InlineResponse2014 AddTicket (string name, List<long?> trips, BasePrice prices, string description = null, DateTime? availableFrom = null, DateTime? availableUntil = null, bool? onlyPackaged = null, List<long?> boats = null, List<long?> boatrooms = null)

Create a new ticket

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddTicketExample
    {
        public void main()
        {
            
            var apiInstance = new TicketApi();
            var name = name_example;  // string | 
            var trips = new List<long?>(); // List<long?> | 
            var prices = new BasePrice(); // BasePrice | 
            var description = description_example;  // string |  (optional) 
            var availableFrom = 2013-10-20;  // DateTime? |  (optional) 
            var availableUntil = 2013-10-20;  // DateTime? |  (optional) 
            var onlyPackaged = true;  // bool? |  (optional) 
            var boats = new List<long?>(); // List<long?> |  (optional) 
            var boatrooms = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Create a new ticket
                InlineResponse2014 result = apiInstance.AddTicket(name, trips, prices, description, availableFrom, availableUntil, onlyPackaged, boats, boatrooms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketApi.AddTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **trips** | [**List<long?>**](long?.md)|  | 
 **prices** | [**BasePrice**](BasePrice.md)|  | 
 **description** | **string**|  | [optional] 
 **availableFrom** | **DateTime?**|  | [optional] 
 **availableUntil** | **DateTime?**|  | [optional] 
 **onlyPackaged** | **bool?**|  | [optional] 
 **boats** | [**List<long?>**](long?.md)|  | [optional] 
 **boatrooms** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteticket"></a>
# **DeleteTicket**
> InlineResponse2014 DeleteTicket (string name)

Delete a ticket

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTicketExample
    {
        public void main()
        {
            
            var apiInstance = new TicketApi();
            var name = name_example;  // string | 

            try
            {
                // Delete a ticket
                InlineResponse2014 result = apiInstance.DeleteTicket(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketApi.DeleteTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editticket"></a>
# **EditTicket**
> InlineResponse2014 EditTicket (long? id, string name, List<long?> trips, BasePrice prices, string description = null, DateTime? availableFrom = null, DateTime? availableUntil = null, bool? onlyPackaged = null, List<long?> boats = null, List<long?> boatrooms = null)

Update an existing ticket

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditTicketExample
    {
        public void main()
        {
            
            var apiInstance = new TicketApi();
            var id = 789;  // long? | 
            var name = name_example;  // string | 
            var trips = new List<long?>(); // List<long?> | 
            var prices = new BasePrice(); // BasePrice | 
            var description = description_example;  // string |  (optional) 
            var availableFrom = 2013-10-20;  // DateTime? |  (optional) 
            var availableUntil = 2013-10-20;  // DateTime? |  (optional) 
            var onlyPackaged = true;  // bool? |  (optional) 
            var boats = new List<long?>(); // List<long?> |  (optional) 
            var boatrooms = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Update an existing ticket
                InlineResponse2014 result = apiInstance.EditTicket(id, name, trips, prices, description, availableFrom, availableUntil, onlyPackaged, boats, boatrooms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketApi.EditTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **name** | **string**|  | 
 **trips** | [**List<long?>**](long?.md)|  | 
 **prices** | [**BasePrice**](BasePrice.md)|  | 
 **description** | **string**|  | [optional] 
 **availableFrom** | **DateTime?**|  | [optional] 
 **availableUntil** | **DateTime?**|  | [optional] 
 **onlyPackaged** | **bool?**|  | [optional] 
 **boats** | [**List<long?>**](long?.md)|  | [optional] 
 **boatrooms** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallavailabletickets"></a>
# **GetAllAvailableTickets**
> List<Ticket> GetAllAvailableTickets ()

Retrieve all tickets that are available to booked today

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAvailableTicketsExample
    {
        public void main()
        {
            
            var apiInstance = new TicketApi();

            try
            {
                // Retrieve all tickets that are available to booked today
                List&lt;Ticket&gt; result = apiInstance.GetAllAvailableTickets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketApi.GetAllAvailableTickets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Ticket>**](Ticket.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltickets"></a>
# **GetAllTickets**
> List<Ticket> GetAllTickets ()

Retrieve all tickets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllTicketsExample
    {
        public void main()
        {
            
            var apiInstance = new TicketApi();

            try
            {
                // Retrieve all tickets
                List&lt;Ticket&gt; result = apiInstance.GetAllTickets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketApi.GetAllTickets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Ticket>**](Ticket.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedtickets"></a>
# **GetAllWithTrashedTickets**
> List<Ticket> GetAllWithTrashedTickets ()

Retrieve all tickets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedTicketsExample
    {
        public void main()
        {
            
            var apiInstance = new TicketApi();

            try
            {
                // Retrieve all tickets
                List&lt;Ticket&gt; result = apiInstance.GetAllWithTrashedTickets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketApi.GetAllWithTrashedTickets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Ticket>**](Ticket.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getticket"></a>
# **GetTicket**
> Ticket GetTicket (long? id)

Retrieve a ticket by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTicketExample
    {
        public void main()
        {
            
            var apiInstance = new TicketApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a ticket by ID
                Ticket result = apiInstance.GetTicket(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketApi.GetTicket: " + e.Message );
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

[**Ticket**](Ticket.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

