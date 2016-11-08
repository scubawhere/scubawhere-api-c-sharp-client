# IO.Swagger.Api.AccommodationApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAccommodation**](AccommodationApi.md#addaccommodation) | **POST** /accommodation/add | 
[**DeleteAccommodation**](AccommodationApi.md#deleteaccommodation) | **DELETE** /accommodation/delete | Delete an accommodation by ID
[**EditAgent**](AccommodationApi.md#editagent) | **POST** /agent/edit | Create a new agent
[**FilterAccommodation**](AccommodationApi.md#filteraccommodation) | **GET** /accommodation/filter | Get all the accommodations matching a filter
[**FindAccommodation**](AccommodationApi.md#findaccommodation) | **GET** /accommodation | 
[**GetAllAccommodations**](AccommodationApi.md#getallaccommodations) | **GET** /accommodations/all | 
[**GetAllWithTrashedAccommodations**](AccommodationApi.md#getallwithtrashedaccommodations) | **GET** /accommodations/all-with-trashed | Retrieve all accommodation including any deleted models
[**UpdateAccommodation**](AccommodationApi.md#updateaccommodation) | **PUT** /accommodation/edit | Update an Accommodation


<a name="addaccommodation"></a>
# **AddAccommodation**
> InlineResponse200 AddAccommodation (string name, long? capacity, int? basePrices, string description = null)



Create an accommodation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAccommodationExample
    {
        public void main()
        {
            
            var apiInstance = new AccommodationApi();
            var name = name_example;  // string | Name of the type of accommodation
            var capacity = 789;  // long? | Number of beds in the accommodation
            var basePrices = 56;  // int? | Price of the accommodation and the dates of when the price is applicable
            var description = description_example;  // string | Description of the accommodation (optional) 

            try
            {
                InlineResponse200 result = apiInstance.AddAccommodation(name, capacity, basePrices, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccommodationApi.AddAccommodation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the type of accommodation | 
 **capacity** | **long?**| Number of beds in the accommodation | 
 **basePrices** | **int?**| Price of the accommodation and the dates of when the price is applicable | 
 **description** | **string**| Description of the accommodation | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccommodation"></a>
# **DeleteAccommodation**
> InlineResponse200 DeleteAccommodation (long? body)

Delete an accommodation by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccommodationExample
    {
        public void main()
        {
            
            var apiInstance = new AccommodationApi();
            var body = 789;  // long? | ID of the accommodation

            try
            {
                // Delete an accommodation by ID
                InlineResponse200 result = apiInstance.DeleteAccommodation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccommodationApi.DeleteAccommodation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **long?**| ID of the accommodation | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editagent"></a>
# **EditAgent**
> InlineResponse2004 EditAgent (long? id, long? name, string branchName, string branchAddress, string branchPhone, string branchEmail, float? commission, string terms, string website = null, string billingAddress = null, string billingPhone = null, string billingEmail = null)

Create a new agent

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditAgentExample
    {
        public void main()
        {
            
            var apiInstance = new AccommodationApi();
            var id = 789;  // long? | 
            var name = 789;  // long? | 
            var branchName = branchName_example;  // string | 
            var branchAddress = branchAddress_example;  // string | 
            var branchPhone = branchPhone_example;  // string | 
            var branchEmail = branchEmail_example;  // string | 
            var commission = 3.4;  // float? | 
            var terms = terms_example;  // string | 
            var website = website_example;  // string |  (optional) 
            var billingAddress = billingAddress_example;  // string |  (optional) 
            var billingPhone = billingPhone_example;  // string |  (optional) 
            var billingEmail = billingEmail_example;  // string |  (optional) 

            try
            {
                // Create a new agent
                InlineResponse2004 result = apiInstance.EditAgent(id, name, branchName, branchAddress, branchPhone, branchEmail, commission, terms, website, billingAddress, billingPhone, billingEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccommodationApi.EditAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **name** | **long?**|  | 
 **branchName** | **string**|  | 
 **branchAddress** | **string**|  | 
 **branchPhone** | **string**|  | 
 **branchEmail** | **string**|  | 
 **commission** | **float?**|  | 
 **terms** | **string**|  | 
 **website** | **string**|  | [optional] 
 **billingAddress** | **string**|  | [optional] 
 **billingPhone** | **string**|  | [optional] 
 **billingEmail** | **string**|  | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filteraccommodation"></a>
# **FilterAccommodation**
> InlineResponse200 FilterAccommodation (DateTime? before = null, DateTime? after = null, long? accommodationId = null)

Get all the accommodations matching a filter

Get all the accommodations and their bookings between certain dates and / or an accommodation id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FilterAccommodationExample
    {
        public void main()
        {
            
            var apiInstance = new AccommodationApi();
            var before = 2013-10-20;  // DateTime? | The date for the upper boundary of the dates (optional) 
            var after = 2013-10-20;  // DateTime? | The date for the lower boundary of the dates (optional) 
            var accommodationId = 789;  // long? | ID Accommodation to filter by (optional) 

            try
            {
                // Get all the accommodations matching a filter
                InlineResponse200 result = apiInstance.FilterAccommodation(before, after, accommodationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccommodationApi.FilterAccommodation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **before** | **DateTime?**| The date for the upper boundary of the dates | [optional] 
 **after** | **DateTime?**| The date for the lower boundary of the dates | [optional] 
 **accommodationId** | **long?**| ID Accommodation to filter by | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findaccommodation"></a>
# **FindAccommodation**
> InlineResponse200 FindAccommodation (List<long?> id)



Retrieve an accommodation by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindAccommodationExample
    {
        public void main()
        {
            
            var apiInstance = new AccommodationApi();
            var id = new List<long?>(); // List<long?> | ID of the accommodation to be retrieved

            try
            {
                InlineResponse200 result = apiInstance.FindAccommodation(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccommodationApi.FindAccommodation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<long?>**](long?.md)| ID of the accommodation to be retrieved | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallaccommodations"></a>
# **GetAllAccommodations**
> List<Accommodation> GetAllAccommodations ()



Retrieve all accommodation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAccommodationsExample
    {
        public void main()
        {
            
            var apiInstance = new AccommodationApi();

            try
            {
                List&lt;Accommodation&gt; result = apiInstance.GetAllAccommodations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccommodationApi.GetAllAccommodations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Accommodation>**](Accommodation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedaccommodations"></a>
# **GetAllWithTrashedAccommodations**
> List<Accommodation> GetAllWithTrashedAccommodations ()

Retrieve all accommodation including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedAccommodationsExample
    {
        public void main()
        {
            
            var apiInstance = new AccommodationApi();

            try
            {
                // Retrieve all accommodation including any deleted models
                List&lt;Accommodation&gt; result = apiInstance.GetAllWithTrashedAccommodations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccommodationApi.GetAllWithTrashedAccommodations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Accommodation>**](Accommodation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccommodation"></a>
# **UpdateAccommodation**
> InlineResponse200 UpdateAccommodation (long? id, string name = null, long? capacity = null)

Update an Accommodation

Updates the accommodation by id using the specified fields

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAccommodationExample
    {
        public void main()
        {
            
            var apiInstance = new AccommodationApi();
            var id = 789;  // long? | ID of the Accommodation to be updated
            var name = name_example;  // string | Name of the Accommodation (optional) 
            var capacity = 789;  // long? | Number of rooms the accommodation holds (optional) 

            try
            {
                // Update an Accommodation
                InlineResponse200 result = apiInstance.UpdateAccommodation(id, name, capacity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccommodationApi.UpdateAccommodation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of the Accommodation to be updated | 
 **name** | **string**| Name of the Accommodation | [optional] 
 **capacity** | **long?**| Number of rooms the accommodation holds | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

