# IO.Swagger.Api.SessionApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSession**](SessionApi.md#createsession) | **POST** /session/add | Create a new session
[**DeleteSession**](SessionApi.md#deletesession) | **DELETE** /session/delete | Delete a session by ID
[**EditSession**](SessionApi.md#editsession) | **POST** /session/edit | Update a session by ID
[**FilterSessions**](SessionApi.md#filtersessions) | **GET** /session/filter | Retrieve all of tsessions that match a filter
[**GetAllSessions**](SessionApi.md#getallsessions) | **GET** /session/all | Retrieve all sessions including any deleted models
[**GetAllWithTrashedSessions**](SessionApi.md#getallwithtrashedsessions) | **GET** /session/all-with-trashed | Retrieve all sessions including any deleted models
[**GetManifest**](SessionApi.md#getmanifest) | **GET** /session/manifest | Retrieve the customer manifest for this session
[**GetSession**](SessionApi.md#getsession) | **GET** /session | Retrieve a session by ID
[**GetTodaySessions**](SessionApi.md#gettodaysessions) | **GET** /session/today | Retrieve all of todays sessions
[**GetTommorowSessions**](SessionApi.md#gettommorowsessions) | **GET** /session/tommorow | Retrieve all of tommorows sessions


<a name="createsession"></a>
# **CreateSession**
> InlineResponse20043 CreateSession (DateTime? start, long? boatId = null, long? tripId = null)

Create a new session

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();
            var start = 2013-10-20;  // DateTime? | 
            var boatId = 789;  // long? |  (optional) 
            var tripId = 789;  // long? |  (optional) 

            try
            {
                // Create a new session
                InlineResponse20043 result = apiInstance.CreateSession(start, boatId, tripId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.CreateSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**|  | 
 **boatId** | **long?**|  | [optional] 
 **tripId** | **long?**|  | [optional] 

### Return type

[**InlineResponse20043**](InlineResponse20043.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesession"></a>
# **DeleteSession**
> InlineResponse2003 DeleteSession (long? id)

Delete a session by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSessionExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a session by ID
                InlineResponse2003 result = apiInstance.DeleteSession(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.DeleteSession: " + e.Message );
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

<a name="editsession"></a>
# **EditSession**
> InlineResponse20044 EditSession (long? id, DateTime? start, long? boatId = null)

Update a session by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditSessionExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();
            var id = 789;  // long? | 
            var start = 2013-10-20;  // DateTime? | 
            var boatId = 789;  // long? |  (optional) 

            try
            {
                // Update a session by ID
                InlineResponse20044 result = apiInstance.EditSession(id, start, boatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.EditSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **start** | **DateTime?**|  | 
 **boatId** | **long?**|  | [optional] 

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtersessions"></a>
# **FilterSessions**
> InlineResponse20045 FilterSessions (DateTime? after = null, DateTime? before = null, long? tripId = null, long? ticketId = null, long? packageId = null, long? courseId = null)

Retrieve all of tsessions that match a filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FilterSessionsExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();
            var after = 2013-10-20;  // DateTime? |  (optional) 
            var before = 2013-10-20;  // DateTime? |  (optional) 
            var tripId = 789;  // long? |  (optional) 
            var ticketId = 789;  // long? |  (optional) 
            var packageId = 789;  // long? |  (optional) 
            var courseId = 789;  // long? |  (optional) 

            try
            {
                // Retrieve all of tsessions that match a filter
                InlineResponse20045 result = apiInstance.FilterSessions(after, before, tripId, ticketId, packageId, courseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.FilterSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **DateTime?**|  | [optional] 
 **before** | **DateTime?**|  | [optional] 
 **tripId** | **long?**|  | [optional] 
 **ticketId** | **long?**|  | [optional] 
 **packageId** | **long?**|  | [optional] 
 **courseId** | **long?**|  | [optional] 

### Return type

[**InlineResponse20045**](InlineResponse20045.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallsessions"></a>
# **GetAllSessions**
> List<Session> GetAllSessions ()

Retrieve all sessions including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllSessionsExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();

            try
            {
                // Retrieve all sessions including any deleted models
                List&lt;Session&gt; result = apiInstance.GetAllSessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetAllSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Session>**](Session.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedsessions"></a>
# **GetAllWithTrashedSessions**
> List<Session> GetAllWithTrashedSessions ()

Retrieve all sessions including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedSessionsExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();

            try
            {
                // Retrieve all sessions including any deleted models
                List&lt;Session&gt; result = apiInstance.GetAllWithTrashedSessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetAllWithTrashedSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Session>**](Session.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanifest"></a>
# **GetManifest**
> InlineResponse20043 GetManifest (long? id)

Retrieve the customer manifest for this session

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetManifestExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve the customer manifest for this session
                InlineResponse20043 result = apiInstance.GetManifest(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetManifest: " + e.Message );
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

[**InlineResponse20043**](InlineResponse20043.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsession"></a>
# **GetSession**
> InlineResponse20043 GetSession (long? id = null)

Retrieve a session by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSessionExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();
            var id = 789;  // long? |  (optional) 

            try
            {
                // Retrieve a session by ID
                InlineResponse20043 result = apiInstance.GetSession(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetSession: " + e.Message );
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

[**InlineResponse20043**](InlineResponse20043.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettodaysessions"></a>
# **GetTodaySessions**
> InlineResponse20045 GetTodaySessions ()

Retrieve all of todays sessions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTodaySessionsExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();

            try
            {
                // Retrieve all of todays sessions
                InlineResponse20045 result = apiInstance.GetTodaySessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetTodaySessions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20045**](InlineResponse20045.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettommorowsessions"></a>
# **GetTommorowSessions**
> InlineResponse20045 GetTommorowSessions ()

Retrieve all of tommorows sessions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTommorowSessionsExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();

            try
            {
                // Retrieve all of tommorows sessions
                InlineResponse20045 result = apiInstance.GetTommorowSessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetTommorowSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20045**](InlineResponse20045.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

