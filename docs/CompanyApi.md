# IO.Swagger.Api.CompanyApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachLocations**](CompanyApi.md#attachlocations) | **POST** /company/add-location | Attach a location to a company
[**GetLocations**](CompanyApi.md#getlocations) | **GET** /company/locations | Retrieve the locations this Dive Centre uses
[**GetPickupSchedule**](CompanyApi.md#getpickupschedule) | **GET** /company/pick-up-schedule | Retrieve the pick up schedule for a date
[**UpdateCompany**](CompanyApi.md#updatecompany) | **POST** /company/update | Update the companies information


<a name="attachlocations"></a>
# **AttachLocations**
> InlineResponse20023 AttachLocations (string name = null, string description = null, float? latitude = null, float? longitude = null)

Attach a location to a company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachLocationsExample
    {
        public void main()
        {
            
            var apiInstance = new CompanyApi();
            var name = name_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var latitude = 3.4;  // float? |  (optional) 
            var longitude = 3.4;  // float? |  (optional) 

            try
            {
                // Attach a location to a company
                InlineResponse20023 result = apiInstance.AttachLocations(name, description, latitude, longitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.AttachLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **latitude** | **float?**|  | [optional] 
 **longitude** | **float?**|  | [optional] 

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocations"></a>
# **GetLocations**
> InlineResponse20024 GetLocations (string latitude, string longitude, int? limit = null)

Retrieve the locations this Dive Centre uses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocationsExample
    {
        public void main()
        {
            
            var apiInstance = new CompanyApi();
            var latitude = latitude_example;  // string | 
            var longitude = longitude_example;  // string | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Retrieve the locations this Dive Centre uses
                InlineResponse20024 result = apiInstance.GetLocations(latitude, longitude, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latitude** | **string**|  | 
 **longitude** | **string**|  | 
 **limit** | **int?**|  | [optional] 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpickupschedule"></a>
# **GetPickupSchedule**
> InlineResponse20025 GetPickupSchedule (string date)

Retrieve the pick up schedule for a date

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPickupScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new CompanyApi();
            var date = date_example;  // string | 

            try
            {
                // Retrieve the pick up schedule for a date
                InlineResponse20025 result = apiInstance.GetPickupSchedule(date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetPickupSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**|  | 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecompany"></a>
# **UpdateCompany**
> InlineResponse20026 UpdateCompany (long? id, string contact = null, string description = null, string name = null, string address1 = null, string address2 = null, string city = null, string county = null, string postcode = null, long? countryId = null, long? currencyId = null, string businessPhone = null, string businessEmail = null, string vatNumber = null, string registrationNumber = null, string website = null)

Update the companies information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCompanyExample
    {
        public void main()
        {
            
            var apiInstance = new CompanyApi();
            var id = 789;  // long? | 
            var contact = contact_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var address1 = address1_example;  // string |  (optional) 
            var address2 = address2_example;  // string |  (optional) 
            var city = city_example;  // string |  (optional) 
            var county = county_example;  // string |  (optional) 
            var postcode = postcode_example;  // string |  (optional) 
            var countryId = 789;  // long? |  (optional) 
            var currencyId = 789;  // long? |  (optional) 
            var businessPhone = businessPhone_example;  // string |  (optional) 
            var businessEmail = businessEmail_example;  // string |  (optional) 
            var vatNumber = vatNumber_example;  // string |  (optional) 
            var registrationNumber = registrationNumber_example;  // string |  (optional) 
            var website = website_example;  // string |  (optional) 

            try
            {
                // Update the companies information
                InlineResponse20026 result = apiInstance.UpdateCompany(id, contact, description, name, address1, address2, city, county, postcode, countryId, currencyId, businessPhone, businessEmail, vatNumber, registrationNumber, website);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.UpdateCompany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **contact** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **address1** | **string**|  | [optional] 
 **address2** | **string**|  | [optional] 
 **city** | **string**|  | [optional] 
 **county** | **string**|  | [optional] 
 **postcode** | **string**|  | [optional] 
 **countryId** | **long?**|  | [optional] 
 **currencyId** | **long?**|  | [optional] 
 **businessPhone** | **string**|  | [optional] 
 **businessEmail** | **string**|  | [optional] 
 **vatNumber** | **string**|  | [optional] 
 **registrationNumber** | **string**|  | [optional] 
 **website** | **string**|  | [optional] 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

