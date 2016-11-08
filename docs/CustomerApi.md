# IO.Swagger.Api.CustomerApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomer**](CustomerApi.md#createcustomer) | **POST** /customer/add | Create a new customer
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /customer/delete | Delete a customer by ID
[**EditCustomer**](CustomerApi.md#editcustomer) | **POST** /customer/edit | Update a customer by ID
[**GetAllCustomers**](CustomerApi.md#getallcustomers) | **GET** /customer/all | Retrieve all customers
[**GetCustomer**](CustomerApi.md#getcustomer) | **GET** /customer | Retrieve a customer by ID


<a name="createcustomer"></a>
# **CreateCustomer**
> InlineResponse20029 CreateCustomer (string email, string firstname, string lastname, DateTime? birthday = null, int? gender = null, string address1 = null, string address2 = null, string city = null, string county = null, string postcode = null, long? countryId = null, string phone = null, DateTime? lastDive = null, int? numberOfDives = null, string chestSize = null, string showSize = null, string height = null, List<long?> certificates = null)

Create a new customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var email = email_example;  // string | 
            var firstname = firstname_example;  // string | 
            var lastname = lastname_example;  // string | 
            var birthday = 2013-10-20;  // DateTime? |  (optional) 
            var gender = 56;  // int? |  (optional) 
            var address1 = address1_example;  // string |  (optional) 
            var address2 = address2_example;  // string |  (optional) 
            var city = city_example;  // string |  (optional) 
            var county = county_example;  // string |  (optional) 
            var postcode = postcode_example;  // string |  (optional) 
            var countryId = 789;  // long? |  (optional) 
            var phone = phone_example;  // string |  (optional) 
            var lastDive = 2013-10-20;  // DateTime? |  (optional) 
            var numberOfDives = 56;  // int? |  (optional) 
            var chestSize = chestSize_example;  // string |  (optional) 
            var showSize = showSize_example;  // string |  (optional) 
            var height = height_example;  // string |  (optional) 
            var certificates = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Create a new customer
                InlineResponse20029 result = apiInstance.CreateCustomer(email, firstname, lastname, birthday, gender, address1, address2, city, county, postcode, countryId, phone, lastDive, numberOfDives, chestSize, showSize, height, certificates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CreateCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  | 
 **firstname** | **string**|  | 
 **lastname** | **string**|  | 
 **birthday** | **DateTime?**|  | [optional] 
 **gender** | **int?**|  | [optional] 
 **address1** | **string**|  | [optional] 
 **address2** | **string**|  | [optional] 
 **city** | **string**|  | [optional] 
 **county** | **string**|  | [optional] 
 **postcode** | **string**|  | [optional] 
 **countryId** | **long?**|  | [optional] 
 **phone** | **string**|  | [optional] 
 **lastDive** | **DateTime?**|  | [optional] 
 **numberOfDives** | **int?**|  | [optional] 
 **chestSize** | **string**|  | [optional] 
 **showSize** | **string**|  | [optional] 
 **height** | **string**|  | [optional] 
 **certificates** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomer"></a>
# **DeleteCustomer**
> InlineResponse2003 DeleteCustomer (long? id)

Delete a customer by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a customer by ID
                InlineResponse2003 result = apiInstance.DeleteCustomer(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.DeleteCustomer: " + e.Message );
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

<a name="editcustomer"></a>
# **EditCustomer**
> InlineResponse20030 EditCustomer (long? id, string email = null, string firstname = null, string lastname = null, DateTime? birthday = null, int? gender = null, string address1 = null, string address2 = null, string city = null, string county = null, string postcode = null, long? countryId = null, string phone = null, DateTime? lastDive = null, int? numberOfDives = null, string chestSize = null, string showSize = null, string height = null, List<long?> certificates = null)

Update a customer by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var id = 789;  // long? | 
            var email = email_example;  // string |  (optional) 
            var firstname = firstname_example;  // string |  (optional) 
            var lastname = lastname_example;  // string |  (optional) 
            var birthday = 2013-10-20;  // DateTime? |  (optional) 
            var gender = 56;  // int? |  (optional) 
            var address1 = address1_example;  // string |  (optional) 
            var address2 = address2_example;  // string |  (optional) 
            var city = city_example;  // string |  (optional) 
            var county = county_example;  // string |  (optional) 
            var postcode = postcode_example;  // string |  (optional) 
            var countryId = 789;  // long? |  (optional) 
            var phone = phone_example;  // string |  (optional) 
            var lastDive = 2013-10-20;  // DateTime? |  (optional) 
            var numberOfDives = 56;  // int? |  (optional) 
            var chestSize = chestSize_example;  // string |  (optional) 
            var showSize = showSize_example;  // string |  (optional) 
            var height = height_example;  // string |  (optional) 
            var certificates = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Update a customer by ID
                InlineResponse20030 result = apiInstance.EditCustomer(id, email, firstname, lastname, birthday, gender, address1, address2, city, county, postcode, countryId, phone, lastDive, numberOfDives, chestSize, showSize, height, certificates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.EditCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **email** | **string**|  | [optional] 
 **firstname** | **string**|  | [optional] 
 **lastname** | **string**|  | [optional] 
 **birthday** | **DateTime?**|  | [optional] 
 **gender** | **int?**|  | [optional] 
 **address1** | **string**|  | [optional] 
 **address2** | **string**|  | [optional] 
 **city** | **string**|  | [optional] 
 **county** | **string**|  | [optional] 
 **postcode** | **string**|  | [optional] 
 **countryId** | **long?**|  | [optional] 
 **phone** | **string**|  | [optional] 
 **lastDive** | **DateTime?**|  | [optional] 
 **numberOfDives** | **int?**|  | [optional] 
 **chestSize** | **string**|  | [optional] 
 **showSize** | **string**|  | [optional] 
 **height** | **string**|  | [optional] 
 **certificates** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcustomers"></a>
# **GetAllCustomers**
> List<Customer> GetAllCustomers ()

Retrieve all customers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllCustomersExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();

            try
            {
                // Retrieve all customers
                List&lt;Customer&gt; result = apiInstance.GetAllCustomers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetAllCustomers: " + e.Message );
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

<a name="getcustomer"></a>
# **GetCustomer**
> InlineResponse20029 GetCustomer (long? id = null)

Retrieve a customer by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var id = 789;  // long? |  (optional) 

            try
            {
                // Retrieve a customer by ID
                InlineResponse20029 result = apiInstance.GetCustomer(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomer: " + e.Message );
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

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

