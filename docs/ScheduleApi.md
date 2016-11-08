# IO.Swagger.Api.ScheduleApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSchedule**](ScheduleApi.md#addschedule) | **GET** /schedule/add | Create a new schedule for classes
[**GetAllSchedules**](ScheduleApi.md#getallschedules) | **GET** /schedule/all | Retrieve all of the schedules for classes
[**GetSchedule**](ScheduleApi.md#getschedule) | **GET** /schedule | Retrieve a schedule by ID


<a name="addschedule"></a>
# **AddSchedule**
> InlineResponse2013 AddSchedule (string schedule, long? trainingSessionId, DateTime? until = null)

Create a new schedule for classes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new ScheduleApi();
            var schedule = schedule_example;  // string | 
            var trainingSessionId = 789;  // long? | 
            var until = 2013-10-20;  // DateTime? |  (optional) 

            try
            {
                // Create a new schedule for classes
                InlineResponse2013 result = apiInstance.AddSchedule(schedule, trainingSessionId, until);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.AddSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schedule** | **string**|  | 
 **trainingSessionId** | **long?**|  | 
 **until** | **DateTime?**|  | [optional] 

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallschedules"></a>
# **GetAllSchedules**
> List<Schedule> GetAllSchedules ()

Retrieve all of the schedules for classes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllSchedulesExample
    {
        public void main()
        {
            
            var apiInstance = new ScheduleApi();

            try
            {
                // Retrieve all of the schedules for classes
                List&lt;Schedule&gt; result = apiInstance.GetAllSchedules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.GetAllSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Schedule>**](Schedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschedule"></a>
# **GetSchedule**
> Schedule GetSchedule (long? id)

Retrieve a schedule by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new ScheduleApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a schedule by ID
                Schedule result = apiInstance.GetSchedule(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.GetSchedule: " + e.Message );
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

[**Schedule**](Schedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

