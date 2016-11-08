# IO.Swagger.Api.CustomersApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllWithTrashedCustomers**](CustomersApi.md#getallwithtrashedcustomers) | **GET** /customer/all-with-trashed | Retrieve all customer including any deleted models


<a name="getallwithtrashedcustomers"></a>
# **GetAllWithTrashedCustomers**
> List<Customer> GetAllWithTrashedCustomers ()

Retrieve all customer including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedCustomersExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();

            try
            {
                // Retrieve all customer including any deleted models
                List&lt;Customer&gt; result = apiInstance.GetAllWithTrashedCustomers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.GetAllWithTrashedCustomers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Customer>**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

