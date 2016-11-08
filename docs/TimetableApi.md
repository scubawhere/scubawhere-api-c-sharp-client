# IO.Swagger.Api.TimetableApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTimetable**](TimetableApi.md#addtimetable) | **GET** /timetable/add | Create a new timetable for sessions
[**GetAllTimetables**](TimetableApi.md#getalltimetables) | **GET** /timetable/all | Retrieve all of the timetables for sessions
[**GetTimetable**](TimetableApi.md#gettimetable) | **GET** /timetable | Retrieve a timetable by ID


<a name="addtimetable"></a>
# **AddTimetable**
> InlineResponse2015 AddTimetable (string schedule, long? sessionId, DateTime? until = null)

Create a new timetable for sessions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddTimetableExample
    {
        public void main()
        {
            
            var apiInstance = new TimetableApi();
            var schedule = schedule_example;  // string | 
            var sessionId = 789;  // long? | 
            var until = 2013-10-20;  // DateTime? |  (optional) 

            try
            {
                // Create a new timetable for sessions
                InlineResponse2015 result = apiInstance.AddTimetable(schedule, sessionId, until);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimetableApi.AddTimetable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schedule** | **string**|  | 
 **sessionId** | **long?**|  | 
 **until** | **DateTime?**|  | [optional] 

### Return type

[**InlineResponse2015**](InlineResponse2015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltimetables"></a>
# **GetAllTimetables**
> List<Timetable> GetAllTimetables ()

Retrieve all of the timetables for sessions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllTimetablesExample
    {
        public void main()
        {
            
            var apiInstance = new TimetableApi();

            try
            {
                // Retrieve all of the timetables for sessions
                List&lt;Timetable&gt; result = apiInstance.GetAllTimetables();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimetableApi.GetAllTimetables: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Timetable>**](Timetable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimetable"></a>
# **GetTimetable**
> Timetable GetTimetable (long? id)

Retrieve a timetable by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTimetableExample
    {
        public void main()
        {
            
            var apiInstance = new TimetableApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a timetable by ID
                Timetable result = apiInstance.GetTimetable(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimetableApi.GetTimetable: " + e.Message );
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

[**Timetable**](Timetable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

