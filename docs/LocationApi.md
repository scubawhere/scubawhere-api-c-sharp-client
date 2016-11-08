# IO.Swagger.Api.LocationApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachLocation**](LocationApi.md#attachlocation) | **POST** /location/attach | Attach a location to a company
[**CreateLocation**](LocationApi.md#createlocation) | **POST** /location/add | Create a location
[**DettachLocation**](LocationApi.md#dettachlocation) | **POST** /location/dettach | Dettach a location to a company
[**GetAllLocations**](LocationApi.md#getalllocations) | **GET** /location/all | Retrieve all locations associated with the company
[**GetLocationTags**](LocationApi.md#getlocationtags) | **GET** /location/tags | Retrieve all tags associated to all locations
[**UpdateLocation**](LocationApi.md#updatelocation) | **PUT** /location/edit | Update a location


<a name="attachlocation"></a>
# **AttachLocation**
> InlineResponse2003 AttachLocation (long? locationId)

Attach a location to a company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationApi();
            var locationId = 789;  // long? | 

            try
            {
                // Attach a location to a company
                InlineResponse2003 result = apiInstance.AttachLocation(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.AttachLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **long?**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlocation"></a>
# **CreateLocation**
> InlineResponse2003 CreateLocation (string name, string description = null, float? latitude = null, float? longitude = null, List<long?> tags = null)

Create a location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationApi();
            var name = name_example;  // string | 
            var description = description_example;  // string |  (optional) 
            var latitude = 3.4;  // float? |  (optional) 
            var longitude = 3.4;  // float? |  (optional) 
            var tags = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Create a location
                InlineResponse2003 result = apiInstance.CreateLocation(name, description, latitude, longitude, tags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.CreateLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **description** | **string**|  | [optional] 
 **latitude** | **float?**|  | [optional] 
 **longitude** | **float?**|  | [optional] 
 **tags** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dettachlocation"></a>
# **DettachLocation**
> InlineResponse2003 DettachLocation (long? locationId)

Dettach a location to a company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DettachLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationApi();
            var locationId = 789;  // long? | 

            try
            {
                // Dettach a location to a company
                InlineResponse2003 result = apiInstance.DettachLocation(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.DettachLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **long?**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalllocations"></a>
# **GetAllLocations**
> InlineResponse2003 GetAllLocations ()

Retrieve all locations associated with the company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllLocationsExample
    {
        public void main()
        {
            
            var apiInstance = new LocationApi();

            try
            {
                // Retrieve all locations associated with the company
                InlineResponse2003 result = apiInstance.GetAllLocations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetAllLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationtags"></a>
# **GetLocationTags**
> InlineResponse2003 GetLocationTags ()

Retrieve all tags associated to all locations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocationTagsExample
    {
        public void main()
        {
            
            var apiInstance = new LocationApi();

            try
            {
                // Retrieve all tags associated to all locations
                InlineResponse2003 result = apiInstance.GetLocationTags();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetLocationTags: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocation"></a>
# **UpdateLocation**
> InlineResponse2003 UpdateLocation (long? locationId, long? description)

Update a location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationApi();
            var locationId = 789;  // long? | 
            var description = 789;  // long? | 

            try
            {
                // Update a location
                InlineResponse2003 result = apiInstance.UpdateLocation(locationId, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.UpdateLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **long?**|  | 
 **description** | **long?**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

