# IO.Swagger.Api.LocationsApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLocation**](LocationsApi.md#getlocation) | **GET** /location | Retrieve a location by its ID


<a name="getlocation"></a>
# **GetLocation**
> InlineResponse20031 GetLocation (long? id)

Retrieve a location by its ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a location by its ID
                InlineResponse20031 result = apiInstance.GetLocation(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocation: " + e.Message );
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

[**InlineResponse20031**](InlineResponse20031.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

