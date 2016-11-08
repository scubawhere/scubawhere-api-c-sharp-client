# IO.Swagger.Api.ClassApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClassGet**](ClassApi.md#classget) | **GET** /class | Retrieve a class by ID
[**CreateClass**](ClassApi.md#createclass) | **POST** /class/add | Create a new class
[**DeleteClass**](ClassApi.md#deleteclass) | **DELETE** /class/delete | Delete a class by ID
[**EditClass**](ClassApi.md#editclass) | **POST** /class/edit | Update a class by ID
[**GetAllClass**](ClassApi.md#getallclass) | **GET** /class/all | Retrieve all classes including any deleted models
[**GetAllWithTrashedClass**](ClassApi.md#getallwithtrashedclass) | **GET** /class/all-with-trashed | Retrieve all classes including any deleted models


<a name="classget"></a>
# **ClassGet**
> Training ClassGet (long? id)

Retrieve a class by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClassGetExample
    {
        public void main()
        {
            
            var apiInstance = new ClassApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a class by ID
                Training result = apiInstance.ClassGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassApi.ClassGet: " + e.Message );
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

[**Training**](Training.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createclass"></a>
# **CreateClass**
> InlineResponse20021 CreateClass (string name, float? duration, string description = null)

Create a new class

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateClassExample
    {
        public void main()
        {
            
            var apiInstance = new ClassApi();
            var name = name_example;  // string | 
            var duration = 3.4;  // float? | 
            var description = description_example;  // string |  (optional) 

            try
            {
                // Create a new class
                InlineResponse20021 result = apiInstance.CreateClass(name, duration, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassApi.CreateClass: " + e.Message );
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
 **description** | **string**|  | [optional] 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclass"></a>
# **DeleteClass**
> InlineResponse2003 DeleteClass (long? id)

Delete a class by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClassExample
    {
        public void main()
        {
            
            var apiInstance = new ClassApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a class by ID
                InlineResponse2003 result = apiInstance.DeleteClass(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassApi.DeleteClass: " + e.Message );
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

<a name="editclass"></a>
# **EditClass**
> InlineResponse20022 EditClass (int? id, string name, float? duration, string description = null)

Update a class by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditClassExample
    {
        public void main()
        {
            
            var apiInstance = new ClassApi();
            var id = 56;  // int? | 
            var name = name_example;  // string | 
            var duration = 3.4;  // float? | 
            var description = description_example;  // string |  (optional) 

            try
            {
                // Update a class by ID
                InlineResponse20022 result = apiInstance.EditClass(id, name, duration, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassApi.EditClass: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **name** | **string**|  | 
 **duration** | **float?**|  | 
 **description** | **string**|  | [optional] 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallclass"></a>
# **GetAllClass**
> List<Training> GetAllClass ()

Retrieve all classes including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllClassExample
    {
        public void main()
        {
            
            var apiInstance = new ClassApi();

            try
            {
                // Retrieve all classes including any deleted models
                List&lt;Training&gt; result = apiInstance.GetAllClass();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassApi.GetAllClass: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Training>**](Training.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedclass"></a>
# **GetAllWithTrashedClass**
> List<Training> GetAllWithTrashedClass ()

Retrieve all classes including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedClassExample
    {
        public void main()
        {
            
            var apiInstance = new ClassApi();

            try
            {
                // Retrieve all classes including any deleted models
                List&lt;Training&gt; result = apiInstance.GetAllWithTrashedClass();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassApi.GetAllWithTrashedClass: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Training>**](Training.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

