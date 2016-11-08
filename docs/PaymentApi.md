# IO.Swagger.Api.PaymentApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPayment**](PaymentApi.md#addpayment) | **POST** /payment/add | Create a new payment
[**FilterPayments**](PaymentApi.md#filterpayments) | **GET** /payment/filter | Retrieve all payments that match a filter
[**GetAllPayments**](PaymentApi.md#getallpayments) | **GET** /payment/all | Retrieve all payments made
[**GetPayment**](PaymentApi.md#getpayment) | **GET** /payment | Retrieve a payment by ID
[**GetPaymentGateways**](PaymentApi.md#getpaymentgateways) | **GET** /payment/paymentgateways | Retrieve all the payment gateways


<a name="addpayment"></a>
# **AddPayment**
> InlineResponse2011 AddPayment (long? bookingId, long? paymentgatewayId, float? amount)

Create a new payment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddPaymentExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var bookingId = 789;  // long? | 
            var paymentgatewayId = 789;  // long? | 
            var amount = 3.4;  // float? | 

            try
            {
                // Create a new payment
                InlineResponse2011 result = apiInstance.AddPayment(bookingId, paymentgatewayId, amount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.AddPayment: " + e.Message );
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

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filterpayments"></a>
# **FilterPayments**
> InlineResponse20035 FilterPayments (DateTime? after = null, DateTime? before = null)

Retrieve all payments that match a filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FilterPaymentsExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var after = 2013-10-20;  // DateTime? | Date of the earliest payment (optional) 
            var before = 2013-10-20;  // DateTime? | Date of the latest payment to be retrieved (optional) 

            try
            {
                // Retrieve all payments that match a filter
                InlineResponse20035 result = apiInstance.FilterPayments(after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.FilterPayments: " + e.Message );
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

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallpayments"></a>
# **GetAllPayments**
> List<Payment> GetAllPayments ()

Retrieve all payments made

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllPaymentsExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();

            try
            {
                // Retrieve all payments made
                List&lt;Payment&gt; result = apiInstance.GetAllPayments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.GetAllPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Payment>**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayment"></a>
# **GetPayment**
> InlineResponse20034 GetPayment (long? id)

Retrieve a payment by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var id = 789;  // long? | 

            try
            {
                // Retrieve a payment by ID
                InlineResponse20034 result = apiInstance.GetPayment(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.GetPayment: " + e.Message );
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

[**InlineResponse20034**](InlineResponse20034.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentgateways"></a>
# **GetPaymentGateways**
> InlineResponse20036 GetPaymentGateways ()

Retrieve all the payment gateways

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentGatewaysExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();

            try
            {
                // Retrieve all the payment gateways
                InlineResponse20036 result = apiInstance.GetPaymentGateways();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.GetPaymentGateways: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

