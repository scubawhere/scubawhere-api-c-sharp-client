# IO.Swagger.Api.ClasssessionApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClassSessionGet**](ClasssessionApi.md#classsessionget) | **GET** /class-session | Retrieve a class session by ID
[**CreateClassSession**](ClasssessionApi.md#createclasssession) | **POST** /class-session/add | Create a new class session
[**DeleteClasssession**](ClasssessionApi.md#deleteclasssession) | **DELETE** /class-session/delete | Delete a class session by ID
[**EditClassSession**](ClasssessionApi.md#editclasssession) | **POST** /class-session/edit | Update a class session by ID
[**FilterClassSession**](ClasssessionApi.md#filterclasssession) | **GET** /class-session/filter | Retrieve all class sessions that match a filter
[**GetAllClassSessions**](ClasssessionApi.md#getallclasssessions) | **GET** /class-session/all | Retrieve all class sessions including any deleted models
[**GetAllWithTrashedClassSessions**](ClasssessionApi.md#getallwithtrashedclasssessions) | **GET** /class-session/all-with-trashed | Retrieve all class sessions including any deleted models
[**GetClassSessionManifest**](ClasssessionApi.md#getclasssessionmanifest) | **GET** /class-session/manifest | Retrieve the customer manifest for a class session
[**GetTodaysClassSession**](ClasssessionApi.md#gettodaysclasssession) | **GET** /class-session/today | Retrieve all class sessions that start today
[**GetTommorowsClassSession**](ClasssessionApi.md#gettommorowsclasssession) | **GET** /class-session/tommorow | Retrieve all class sessions that start tommorow


<a name="classsessionget"></a>
# **ClassSessionGet**
> TrainingSession ClassSessionGet (long? id)

Retrieve a class session by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClassSessionGetExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a class session by ID
                TrainingSession result = apiInstance.ClassSessionGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.ClassSessionGet: " + e.Message );
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

[**TrainingSession**](TrainingSession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createclasssession"></a>
# **CreateClassSession**
> InlineResponse20019 CreateClassSession (DateTime? start, long? trainingId)

Create a new class session

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateClassSessionExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();
            var start = 2013-10-20;  // DateTime? | 
            var trainingId = 789;  // long? | 

            try
            {
                // Create a new class session
                InlineResponse20019 result = apiInstance.CreateClassSession(start, trainingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.CreateClassSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**|  | 
 **trainingId** | **long?**|  | 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclasssession"></a>
# **DeleteClasssession**
> InlineResponse2003 DeleteClasssession (long? id)

Delete a class session by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClasssessionExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a class session by ID
                InlineResponse2003 result = apiInstance.DeleteClasssession(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.DeleteClasssession: " + e.Message );
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

<a name="editclasssession"></a>
# **EditClassSession**
> InlineResponse20020 EditClassSession (int? id, DateTime? start)

Update a class session by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditClassSessionExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();
            var id = 56;  // int? | 
            var start = 2013-10-20;  // DateTime? | 

            try
            {
                // Update a class session by ID
                InlineResponse20020 result = apiInstance.EditClassSession(id, start);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.EditClassSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **start** | **DateTime?**|  | 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filterclasssession"></a>
# **FilterClassSession**
> List<TrainingSession> FilterClassSession ()

Retrieve all class sessions that match a filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FilterClassSessionExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();

            try
            {
                // Retrieve all class sessions that match a filter
                List&lt;TrainingSession&gt; result = apiInstance.FilterClassSession();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.FilterClassSession: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TrainingSession>**](TrainingSession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallclasssessions"></a>
# **GetAllClassSessions**
> List<TrainingSession> GetAllClassSessions ()

Retrieve all class sessions including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllClassSessionsExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();

            try
            {
                // Retrieve all class sessions including any deleted models
                List&lt;TrainingSession&gt; result = apiInstance.GetAllClassSessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.GetAllClassSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TrainingSession>**](TrainingSession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedclasssessions"></a>
# **GetAllWithTrashedClassSessions**
> List<TrainingSession> GetAllWithTrashedClassSessions ()

Retrieve all class sessions including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedClassSessionsExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();

            try
            {
                // Retrieve all class sessions including any deleted models
                List&lt;TrainingSession&gt; result = apiInstance.GetAllWithTrashedClassSessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.GetAllWithTrashedClassSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TrainingSession>**](TrainingSession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclasssessionmanifest"></a>
# **GetClassSessionManifest**
> TrainingSessionManifest GetClassSessionManifest (long? id)

Retrieve the customer manifest for a class session

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClassSessionManifestExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve the customer manifest for a class session
                TrainingSessionManifest result = apiInstance.GetClassSessionManifest(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.GetClassSessionManifest: " + e.Message );
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

[**TrainingSessionManifest**](TrainingSessionManifest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettodaysclasssession"></a>
# **GetTodaysClassSession**
> List<TrainingSession> GetTodaysClassSession ()

Retrieve all class sessions that start today

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTodaysClassSessionExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();

            try
            {
                // Retrieve all class sessions that start today
                List&lt;TrainingSession&gt; result = apiInstance.GetTodaysClassSession();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.GetTodaysClassSession: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TrainingSession>**](TrainingSession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettommorowsclasssession"></a>
# **GetTommorowsClassSession**
> List<TrainingSession> GetTommorowsClassSession ()

Retrieve all class sessions that start tommorow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTommorowsClassSessionExample
    {
        public void main()
        {
            
            var apiInstance = new ClasssessionApi();

            try
            {
                // Retrieve all class sessions that start tommorow
                List&lt;TrainingSession&gt; result = apiInstance.GetTommorowsClassSession();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClasssessionApi.GetTommorowsClassSession: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TrainingSession>**](TrainingSession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

