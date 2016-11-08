# IO.Swagger.Api.TripApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTrip**](TripApi.md#createtrip) | **POST** /trip/add | Create a new trip
[**DeleteTrip**](TripApi.md#deletetrip) | **DELETE** /trip/delete | Delete a trip by ID
[**EditTrip**](TripApi.md#edittrip) | **POST** /trip/edit | Update a trip by ID
[**GetAllTrips**](TripApi.md#getalltrips) | **GET** /trip/all | Retrieve all trips including any deleted models
[**GetAllWithTrashedTrips**](TripApi.md#getallwithtrashedtrips) | **GET** /trip/all-with-trashed | Retrieve all trips including any deleted models
[**TripGet**](TripApi.md#tripget) | **GET** /trip | Retrieve a trip by ID


<a name="createtrip"></a>
# **CreateTrip**
> InlineResponse20046 CreateTrip (string name, float? duration, List<long?> locations, List<long?> tags, string description = null, bool? boatRequired = null)

Create a new trip

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTripExample
    {
        public void main()
        {
            
            var apiInstance = new TripApi();
            var name = name_example;  // string | 
            var duration = 3.4;  // float? | 
            var locations = new List<long?>(); // List<long?> | 
            var tags = new List<long?>(); // List<long?> | 
            var description = description_example;  // string |  (optional) 
            var boatRequired = true;  // bool? |  (optional) 

            try
            {
                // Create a new trip
                InlineResponse20046 result = apiInstance.CreateTrip(name, duration, locations, tags, description, boatRequired);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripApi.CreateTrip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **duration** | **float?**|  | 
 **locations** | [**List<long?>**](long?.md)|  | 
 **tags** | [**List<long?>**](long?.md)|  | 
 **description** | **string**|  | [optional] 
 **boatRequired** | **bool?**|  | [optional] 

### Return type

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetrip"></a>
# **DeleteTrip**
> InlineResponse2003 DeleteTrip (long? id)

Delete a trip by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTripExample
    {
        public void main()
        {
            
            var apiInstance = new TripApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a trip by ID
                InlineResponse2003 result = apiInstance.DeleteTrip(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripApi.DeleteTrip: " + e.Message );
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

<a name="edittrip"></a>
# **EditTrip**
> InlineResponse20047 EditTrip (long? id, string name, float? duration, List<long?> locations, List<long?> tags, string description = null, bool? boatRequired = null)

Update a trip by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditTripExample
    {
        public void main()
        {
            
            var apiInstance = new TripApi();
            var id = 789;  // long? | 
            var name = name_example;  // string | 
            var duration = 3.4;  // float? | 
            var locations = new List<long?>(); // List<long?> | 
            var tags = new List<long?>(); // List<long?> | 
            var description = description_example;  // string |  (optional) 
            var boatRequired = true;  // bool? |  (optional) 

            try
            {
                // Update a trip by ID
                InlineResponse20047 result = apiInstance.EditTrip(id, name, duration, locations, tags, description, boatRequired);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripApi.EditTrip: " + e.Message );
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
 **duration** | **float?**|  | 
 **locations** | [**List<long?>**](long?.md)|  | 
 **tags** | [**List<long?>**](long?.md)|  | 
 **description** | **string**|  | [optional] 
 **boatRequired** | **bool?**|  | [optional] 

### Return type

[**InlineResponse20047**](InlineResponse20047.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltrips"></a>
# **GetAllTrips**
> List<Trip> GetAllTrips ()

Retrieve all trips including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllTripsExample
    {
        public void main()
        {
            
            var apiInstance = new TripApi();

            try
            {
                // Retrieve all trips including any deleted models
                List&lt;Trip&gt; result = apiInstance.GetAllTrips();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripApi.GetAllTrips: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Trip>**](Trip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedtrips"></a>
# **GetAllWithTrashedTrips**
> List<Trip> GetAllWithTrashedTrips ()

Retrieve all trips including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedTripsExample
    {
        public void main()
        {
            
            var apiInstance = new TripApi();

            try
            {
                // Retrieve all trips including any deleted models
                List&lt;Trip&gt; result = apiInstance.GetAllWithTrashedTrips();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripApi.GetAllWithTrashedTrips: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Trip>**](Trip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tripget"></a>
# **TripGet**
> Trip TripGet (long? id)

Retrieve a trip by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TripGetExample
    {
        public void main()
        {
            
            var apiInstance = new TripApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a trip by ID
                Trip result = apiInstance.TripGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripApi.TripGet: " + e.Message );
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

[**Trip**](Trip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

