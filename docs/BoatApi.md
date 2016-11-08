# IO.Swagger.Api.BoatApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBoat**](BoatApi.md#createboat) | **POST** /boat/add | Create a new boat
[**DeleteBoat**](BoatApi.md#deleteboat) | **DELETE** /boat/delete | Delete a boat by ID
[**EditBoat**](BoatApi.md#editboat) | **POST** /boat/edit | Update a boat by ID
[**GetAllBoats**](BoatApi.md#getallboats) | **GET** /boat/all | Retrieve all boats
[**GetAllWithTrashedBoats**](BoatApi.md#getallwithtrashedboats) | **GET** /boat/all-with-trashed | Retrieve all agents including any deleted models
[**GetBoat**](BoatApi.md#getboat) | **GET** /boat | Retrieve a boat by ID


<a name="createboat"></a>
# **CreateBoat**
> InlineResponse2005 CreateBoat (string name, long? capacity, string description = null, List<long?> boatrooms = null)

Create a new boat

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBoatExample
    {
        public void main()
        {
            
            var apiInstance = new BoatApi();
            var name = name_example;  // string | 
            var capacity = 789;  // long? | 
            var description = description_example;  // string |  (optional) 
            var boatrooms = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Create a new boat
                InlineResponse2005 result = apiInstance.CreateBoat(name, capacity, description, boatrooms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatApi.CreateBoat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **capacity** | **long?**|  | 
 **description** | **string**|  | [optional] 
 **boatrooms** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteboat"></a>
# **DeleteBoat**
> InlineResponse2003 DeleteBoat (long? id)

Delete a boat by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBoatExample
    {
        public void main()
        {
            
            var apiInstance = new BoatApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a boat by ID
                InlineResponse2003 result = apiInstance.DeleteBoat(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatApi.DeleteBoat: " + e.Message );
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

<a name="editboat"></a>
# **EditBoat**
> InlineResponse2004 EditBoat (string name, long? capacity, string description = null, List<long?> boatrooms = null)

Update a boat by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditBoatExample
    {
        public void main()
        {
            
            var apiInstance = new BoatApi();
            var name = name_example;  // string | 
            var capacity = 789;  // long? | 
            var description = description_example;  // string |  (optional) 
            var boatrooms = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Update a boat by ID
                InlineResponse2004 result = apiInstance.EditBoat(name, capacity, description, boatrooms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatApi.EditBoat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **capacity** | **long?**|  | 
 **description** | **string**|  | [optional] 
 **boatrooms** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallboats"></a>
# **GetAllBoats**
> List<Boat> GetAllBoats ()

Retrieve all boats

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllBoatsExample
    {
        public void main()
        {
            
            var apiInstance = new BoatApi();

            try
            {
                // Retrieve all boats
                List&lt;Boat&gt; result = apiInstance.GetAllBoats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatApi.GetAllBoats: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Boat>**](Boat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedboats"></a>
# **GetAllWithTrashedBoats**
> List<Boat> GetAllWithTrashedBoats ()

Retrieve all agents including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedBoatsExample
    {
        public void main()
        {
            
            var apiInstance = new BoatApi();

            try
            {
                // Retrieve all agents including any deleted models
                List&lt;Boat&gt; result = apiInstance.GetAllWithTrashedBoats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatApi.GetAllWithTrashedBoats: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Boat>**](Boat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getboat"></a>
# **GetBoat**
> InlineResponse2005 GetBoat (long? id)

Retrieve a boat by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBoatExample
    {
        public void main()
        {
            
            var apiInstance = new BoatApi();
            var id = 789;  // long? | ID of the boat to be retrieved

            try
            {
                // Retrieve a boat by ID
                InlineResponse2005 result = apiInstance.GetBoat(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatApi.GetBoat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of the boat to be retrieved | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

