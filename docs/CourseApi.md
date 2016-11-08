# IO.Swagger.Api.CourseApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCourse**](CourseApi.md#createcourse) | **POST** /course/add | Create a new course
[**DeleteCourse**](CourseApi.md#deletecourse) | **DELETE** /course/delete | Delete a course by ID
[**EditCourse**](CourseApi.md#editcourse) | **POST** /course/edit | Update a course by ID
[**GetAllCourses**](CourseApi.md#getallcourses) | **GET** /course/all | Retrieve all courses including any deleted models
[**GetAllWithTrashedCourses**](CourseApi.md#getallwithtrashedcourses) | **GET** /course/all-with-trashed | Retrieve all courses including any deleted models
[**GetCourse**](CourseApi.md#getcourse) | **GET** /course | Retrieve a course by ID


<a name="createcourse"></a>
# **CreateCourse**
> InlineResponse20027 CreateCourse (string name, string description, int? capacity, List<double?> prices, int? certificateId = null, List<long?> tickets = null, List<long?> trainings = null)

Create a new course

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCourseExample
    {
        public void main()
        {
            
            var apiInstance = new CourseApi();
            var name = name_example;  // string | 
            var description = description_example;  // string | 
            var capacity = 56;  // int? | 
            var prices = new List<double?>(); // List<double?> | 
            var certificateId = 56;  // int? |  (optional) 
            var tickets = new List<long?>(); // List<long?> |  (optional) 
            var trainings = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Create a new course
                InlineResponse20027 result = apiInstance.CreateCourse(name, description, capacity, prices, certificateId, tickets, trainings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.CreateCourse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **description** | **string**|  | 
 **capacity** | **int?**|  | 
 **prices** | [**List<double?>**](double?.md)|  | 
 **certificateId** | **int?**|  | [optional] 
 **tickets** | [**List<long?>**](long?.md)|  | [optional] 
 **trainings** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecourse"></a>
# **DeleteCourse**
> InlineResponse2003 DeleteCourse (long? id)

Delete a course by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCourseExample
    {
        public void main()
        {
            
            var apiInstance = new CourseApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a course by ID
                InlineResponse2003 result = apiInstance.DeleteCourse(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.DeleteCourse: " + e.Message );
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

<a name="editcourse"></a>
# **EditCourse**
> InlineResponse20028 EditCourse (long? id, string name, string description, int? capacity, int? certificateId = null, List<long?> tickets = null, List<long?> trainings = null)

Update a course by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditCourseExample
    {
        public void main()
        {
            
            var apiInstance = new CourseApi();
            var id = 789;  // long? | 
            var name = name_example;  // string | 
            var description = description_example;  // string | 
            var capacity = 56;  // int? | 
            var certificateId = 56;  // int? |  (optional) 
            var tickets = new List<long?>(); // List<long?> |  (optional) 
            var trainings = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Update a course by ID
                InlineResponse20028 result = apiInstance.EditCourse(id, name, description, capacity, certificateId, tickets, trainings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.EditCourse: " + e.Message );
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
 **description** | **string**|  | 
 **capacity** | **int?**|  | 
 **certificateId** | **int?**|  | [optional] 
 **tickets** | [**List<long?>**](long?.md)|  | [optional] 
 **trainings** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcourses"></a>
# **GetAllCourses**
> List<Course> GetAllCourses ()

Retrieve all courses including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllCoursesExample
    {
        public void main()
        {
            
            var apiInstance = new CourseApi();

            try
            {
                // Retrieve all courses including any deleted models
                List&lt;Course&gt; result = apiInstance.GetAllCourses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetAllCourses: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Course>**](Course.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedcourses"></a>
# **GetAllWithTrashedCourses**
> List<Course> GetAllWithTrashedCourses ()

Retrieve all courses including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedCoursesExample
    {
        public void main()
        {
            
            var apiInstance = new CourseApi();

            try
            {
                // Retrieve all courses including any deleted models
                List&lt;Course&gt; result = apiInstance.GetAllWithTrashedCourses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetAllWithTrashedCourses: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Course>**](Course.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourse"></a>
# **GetCourse**
> InlineResponse20027 GetCourse (long? id = null)

Retrieve a course by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCourseExample
    {
        public void main()
        {
            
            var apiInstance = new CourseApi();
            var id = 789;  // long? |  (optional) 

            try
            {
                // Retrieve a course by ID
                InlineResponse20027 result = apiInstance.GetCourse(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | [optional] 

### Return type

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

