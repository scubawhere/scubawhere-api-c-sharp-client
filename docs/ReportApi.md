# IO.Swagger.Api.ReportApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRevenueStreamReport**](ReportApi.md#getrevenuestreamreport) | **GET** /report/revenue-streams | Get a report containing the distribution of revenue made from all the tickets, packages, courses, addons, accommodations
[**GetSourcesReport**](ReportApi.md#getsourcesreport) | **GET** /report/sources | Get a report about the distribution of revenue between the diffrent source of bookings
[**GetTrainingUtilisationReport**](ReportApi.md#gettrainingutilisationreport) | **GET** /report/training-utilisation | Get a report containing the utilisation of all classes between the specified dates
[**GetUtilisationReport**](ReportApi.md#getutilisationreport) | **GET** /report/utilisation | Get a report containing the utilisation of all trips between the specified dates


<a name="getrevenuestreamreport"></a>
# **GetRevenueStreamReport**
> InlineResponse20040 GetRevenueStreamReport (DateTime? after, DateTime? before)

Get a report containing the distribution of revenue made from all the tickets, packages, courses, addons, accommodations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRevenueStreamReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportApi();
            var after = 2013-10-20;  // DateTime? | 
            var before = 2013-10-20;  // DateTime? | 

            try
            {
                // Get a report containing the distribution of revenue made from all the tickets, packages, courses, addons, accommodations
                InlineResponse20040 result = apiInstance.GetRevenueStreamReport(after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.GetRevenueStreamReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **DateTime?**|  | 
 **before** | **DateTime?**|  | 

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsourcesreport"></a>
# **GetSourcesReport**
> InlineResponse20041 GetSourcesReport (DateTime? after, DateTime? before)

Get a report about the distribution of revenue between the diffrent source of bookings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSourcesReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportApi();
            var after = 2013-10-20;  // DateTime? | 
            var before = 2013-10-20;  // DateTime? | 

            try
            {
                // Get a report about the distribution of revenue between the diffrent source of bookings
                InlineResponse20041 result = apiInstance.GetSourcesReport(after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.GetSourcesReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **DateTime?**|  | 
 **before** | **DateTime?**|  | 

### Return type

[**InlineResponse20041**](InlineResponse20041.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrainingutilisationreport"></a>
# **GetTrainingUtilisationReport**
> InlineResponse20042 GetTrainingUtilisationReport (DateTime? after, DateTime? before)

Get a report containing the utilisation of all classes between the specified dates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTrainingUtilisationReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportApi();
            var after = 2013-10-20;  // DateTime? | 
            var before = 2013-10-20;  // DateTime? | 

            try
            {
                // Get a report containing the utilisation of all classes between the specified dates
                InlineResponse20042 result = apiInstance.GetTrainingUtilisationReport(after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.GetTrainingUtilisationReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **DateTime?**|  | 
 **before** | **DateTime?**|  | 

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getutilisationreport"></a>
# **GetUtilisationReport**
> InlineResponse20042 GetUtilisationReport (DateTime? after, DateTime? before)

Get a report containing the utilisation of all trips between the specified dates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUtilisationReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportApi();
            var after = 2013-10-20;  // DateTime? | 
            var before = 2013-10-20;  // DateTime? | 

            try
            {
                // Get a report containing the utilisation of all trips between the specified dates
                InlineResponse20042 result = apiInstance.GetUtilisationReport(after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.GetUtilisationReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **DateTime?**|  | 
 **before** | **DateTime?**|  | 

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

