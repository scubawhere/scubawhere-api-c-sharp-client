# IO.Swagger.Api.RefundApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRefund**](RefundApi.md#addrefund) | **POST** /refund/add | Create a new refund
[**FilterRefunds**](RefundApi.md#filterrefunds) | **GET** /refund/filter | Retrieve all refunds that match a filter
[**GetAllRefunds**](RefundApi.md#getallrefunds) | **GET** /refund/all | Retrieve all refunds made
[**GetRefund**](RefundApi.md#getrefund) | **GET** /refund | Retrieve a refund by ID


<a name="addrefund"></a>
# **AddRefund**
> InlineResponse2012 AddRefund (long? bookingId, long? paymentgatewayId, float? amount)

Create a new refund

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddRefundExample
    {
        public void main()
        {
            
            var apiInstance = new RefundApi();
            var bookingId = 789;  // long? | 
            var paymentgatewayId = 789;  // long? | 
            var amount = 3.4;  // float? | 

            try
            {
                // Create a new refund
                InlineResponse2012 result = apiInstance.AddRefund(bookingId, paymentgatewayId, amount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundApi.AddRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **long?**|  | 
 **paymentgatewayId** | **long?**|  | 
 **amount** | **float?**|  | 

### Return type

[**InlineResponse2012**](InlineResponse2012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filterrefunds"></a>
# **FilterRefunds**
> InlineResponse20039 FilterRefunds (DateTime? after = null, DateTime? before = null)

Retrieve all refunds that match a filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FilterRefundsExample
    {
        public void main()
        {
            
            var apiInstance = new RefundApi();
            var after = 2013-10-20;  // DateTime? | Date of the earliest payment (optional) 
            var before = 2013-10-20;  // DateTime? | Date of the latest payment to be retrieved (optional) 

            try
            {
                // Retrieve all refunds that match a filter
                InlineResponse20039 result = apiInstance.FilterRefunds(after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundApi.FilterRefunds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **DateTime?**| Date of the earliest payment | [optional] 
 **before** | **DateTime?**| Date of the latest payment to be retrieved | [optional] 

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallrefunds"></a>
# **GetAllRefunds**
> InlineResponse20038 GetAllRefunds ()

Retrieve all refunds made

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllRefundsExample
    {
        public void main()
        {
            
            var apiInstance = new RefundApi();

            try
            {
                // Retrieve all refunds made
                InlineResponse20038 result = apiInstance.GetAllRefunds();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundApi.GetAllRefunds: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrefund"></a>
# **GetRefund**
> InlineResponse20037 GetRefund (long? id)

Retrieve a refund by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRefundExample
    {
        public void main()
        {
            
            var apiInstance = new RefundApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a refund by ID
                InlineResponse20037 result = apiInstance.GetRefund(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundApi.GetRefund: " + e.Message );
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

[**InlineResponse20037**](InlineResponse20037.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

