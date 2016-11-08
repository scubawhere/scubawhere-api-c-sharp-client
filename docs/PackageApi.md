# IO.Swagger.Api.PackageApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePackage**](PackageApi.md#createpackage) | **POST** /package/add | Create a new package
[**DeletePackage**](PackageApi.md#deletepackage) | **DELETE** /package/delete | Delete a package by ID
[**EditPackage**](PackageApi.md#editpackage) | **POST** /package/edit | Update a package by ID
[**GetAllPackages**](PackageApi.md#getallpackages) | **GET** /package/all | Retrieve all packages including any deleted models
[**GetAllWithTrashedPackages**](PackageApi.md#getallwithtrashedpackages) | **GET** /package/all-with-trashed | Retrieve all packages including any deleted models
[**GetPackage**](PackageApi.md#getpackage) | **GET** /package | Retrieve a package by ID


<a name="createpackage"></a>
# **CreatePackage**
> InlineResponse20032 CreatePackage (string name, string description = null, DateTime? availableFrom = null, DateTime? availableUntil = null, List<long?> tickets = null, List<long?> courses = null, List<long?> accommodations = null, List<long?> addons = null, List<long?> prices = null)

Create a new package

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePackageExample
    {
        public void main()
        {
            
            var apiInstance = new PackageApi();
            var name = name_example;  // string | 
            var description = description_example;  // string |  (optional) 
            var availableFrom = 2013-10-20;  // DateTime? |  (optional) 
            var availableUntil = 2013-10-20;  // DateTime? |  (optional) 
            var tickets = new List<long?>(); // List<long?> |  (optional) 
            var courses = new List<long?>(); // List<long?> |  (optional) 
            var accommodations = new List<long?>(); // List<long?> |  (optional) 
            var addons = new List<long?>(); // List<long?> |  (optional) 
            var prices = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Create a new package
                InlineResponse20032 result = apiInstance.CreatePackage(name, description, availableFrom, availableUntil, tickets, courses, accommodations, addons, prices);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.CreatePackage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **description** | **string**|  | [optional] 
 **availableFrom** | **DateTime?**|  | [optional] 
 **availableUntil** | **DateTime?**|  | [optional] 
 **tickets** | [**List<long?>**](long?.md)|  | [optional] 
 **courses** | [**List<long?>**](long?.md)|  | [optional] 
 **accommodations** | [**List<long?>**](long?.md)|  | [optional] 
 **addons** | [**List<long?>**](long?.md)|  | [optional] 
 **prices** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse20032**](InlineResponse20032.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepackage"></a>
# **DeletePackage**
> InlineResponse2003 DeletePackage (long? id)

Delete a package by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePackageExample
    {
        public void main()
        {
            
            var apiInstance = new PackageApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a package by ID
                InlineResponse2003 result = apiInstance.DeletePackage(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.DeletePackage: " + e.Message );
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

<a name="editpackage"></a>
# **EditPackage**
> InlineResponse20033 EditPackage (long? id, string name, string description = null, DateTime? availableFrom = null, DateTime? availableUntil = null, List<long?> tickets = null, List<long?> courses = null, List<long?> accommodations = null, List<long?> addons = null, List<long?> prices = null)

Update a package by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditPackageExample
    {
        public void main()
        {
            
            var apiInstance = new PackageApi();
            var id = 789;  // long? | 
            var name = name_example;  // string | 
            var description = description_example;  // string |  (optional) 
            var availableFrom = 2013-10-20;  // DateTime? |  (optional) 
            var availableUntil = 2013-10-20;  // DateTime? |  (optional) 
            var tickets = new List<long?>(); // List<long?> |  (optional) 
            var courses = new List<long?>(); // List<long?> |  (optional) 
            var accommodations = new List<long?>(); // List<long?> |  (optional) 
            var addons = new List<long?>(); // List<long?> |  (optional) 
            var prices = new List<long?>(); // List<long?> |  (optional) 

            try
            {
                // Update a package by ID
                InlineResponse20033 result = apiInstance.EditPackage(id, name, description, availableFrom, availableUntil, tickets, courses, accommodations, addons, prices);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.EditPackage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **name** | **string**|  | 
 **description** | **string**|  | [optional] 
 **availableFrom** | **DateTime?**|  | [optional] 
 **availableUntil** | **DateTime?**|  | [optional] 
 **tickets** | [**List<long?>**](long?.md)|  | [optional] 
 **courses** | [**List<long?>**](long?.md)|  | [optional] 
 **accommodations** | [**List<long?>**](long?.md)|  | [optional] 
 **addons** | [**List<long?>**](long?.md)|  | [optional] 
 **prices** | [**List<long?>**](long?.md)|  | [optional] 

### Return type

[**InlineResponse20033**](InlineResponse20033.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallpackages"></a>
# **GetAllPackages**
> List<Package> GetAllPackages ()

Retrieve all packages including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllPackagesExample
    {
        public void main()
        {
            
            var apiInstance = new PackageApi();

            try
            {
                // Retrieve all packages including any deleted models
                List&lt;Package&gt; result = apiInstance.GetAllPackages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.GetAllPackages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Package>**](Package.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedpackages"></a>
# **GetAllWithTrashedPackages**
> List<Package> GetAllWithTrashedPackages ()

Retrieve all packages including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedPackagesExample
    {
        public void main()
        {
            
            var apiInstance = new PackageApi();

            try
            {
                // Retrieve all packages including any deleted models
                List&lt;Package&gt; result = apiInstance.GetAllWithTrashedPackages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.GetAllWithTrashedPackages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Package>**](Package.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackage"></a>
# **GetPackage**
> InlineResponse20032 GetPackage (long? id = null)

Retrieve a package by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPackageExample
    {
        public void main()
        {
            
            var apiInstance = new PackageApi();
            var id = 789;  // long? |  (optional) 

            try
            {
                // Retrieve a package by ID
                InlineResponse20032 result = apiInstance.GetPackage(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.GetPackage: " + e.Message );
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

[**InlineResponse20032**](InlineResponse20032.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

