# IO.Swagger.Api.BoatroomApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBoatroom**](BoatroomApi.md#createboatroom) | **POST** /boatroom/add | Create a new boatroom
[**DeleteBoatroom**](BoatroomApi.md#deleteboatroom) | **DELETE** /boatroom/delete | Delete a boatroom by ID
[**EditBoatroom**](BoatroomApi.md#editboatroom) | **POST** /boatroom/edit | Update a boatroom by ID
[**GetAllBoatrooms**](BoatroomApi.md#getallboatrooms) | **GET** /boatroom/all | Retrieve all boatrooms
[**GetAllWithTrashedBoatrooms**](BoatroomApi.md#getallwithtrashedboatrooms) | **GET** /boatroom/all-with-trashed | Retrieve all boatrooms including any deleted models
[**GetBoatroom**](BoatroomApi.md#getboatroom) | **GET** /boatroom | Retrieve a boatroom by ID


<a name="createboatroom"></a>
# **CreateBoatroom**
> InlineResponse2006 CreateBoatroom (string name, string description = null)

Create a new boatroom

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBoatroomExample
    {
        public void main()
        {
            
            var apiInstance = new BoatroomApi();
            var name = name_example;  // string | 
            var description = description_example;  // string |  (optional) 

            try
            {
                // Create a new boatroom
                InlineResponse2006 result = apiInstance.CreateBoatroom(name, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatroomApi.CreateBoatroom: " + e.Message );
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

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteboatroom"></a>
# **DeleteBoatroom**
> InlineResponse2003 DeleteBoatroom (long? id)

Delete a boatroom by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBoatroomExample
    {
        public void main()
        {
            
            var apiInstance = new BoatroomApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a boatroom by ID
                InlineResponse2003 result = apiInstance.DeleteBoatroom(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatroomApi.DeleteBoatroom: " + e.Message );
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

<a name="editboatroom"></a>
# **EditBoatroom**
> InlineResponse2006 EditBoatroom (long? id, string name, string description = null)

Update a boatroom by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditBoatroomExample
    {
        public void main()
        {
            
            var apiInstance = new BoatroomApi();
            var id = 789;  // long? | 
            var name = name_example;  // string | 
            var description = description_example;  // string |  (optional) 

            try
            {
                // Update a boatroom by ID
                InlineResponse2006 result = apiInstance.EditBoatroom(id, name, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatroomApi.EditBoatroom: " + e.Message );
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
 **description** | **string**|  | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallboatrooms"></a>
# **GetAllBoatrooms**
> List<Boatroom> GetAllBoatrooms ()

Retrieve all boatrooms

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllBoatroomsExample
    {
        public void main()
        {
            
            var apiInstance = new BoatroomApi();

            try
            {
                // Retrieve all boatrooms
                List&lt;Boatroom&gt; result = apiInstance.GetAllBoatrooms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatroomApi.GetAllBoatrooms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Boatroom>**](Boatroom.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedboatrooms"></a>
# **GetAllWithTrashedBoatrooms**
> List<Boatroom> GetAllWithTrashedBoatrooms ()

Retrieve all boatrooms including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedBoatroomsExample
    {
        public void main()
        {
            
            var apiInstance = new BoatroomApi();

            try
            {
                // Retrieve all boatrooms including any deleted models
                List&lt;Boatroom&gt; result = apiInstance.GetAllWithTrashedBoatrooms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatroomApi.GetAllWithTrashedBoatrooms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Boatroom>**](Boatroom.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getboatroom"></a>
# **GetBoatroom**
> InlineResponse2006 GetBoatroom (long? id)

Retrieve a boatroom by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBoatroomExample
    {
        public void main()
        {
            
            var apiInstance = new BoatroomApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a boatroom by ID
                InlineResponse2006 result = apiInstance.GetBoatroom(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BoatroomApi.GetBoatroom: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

