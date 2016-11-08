# IO.Swagger.Api.AddonApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAddon**](AddonApi.md#addaddon) | **POST** /addon/add | Create a new addon
[**DeleteAddon**](AddonApi.md#deleteaddon) | **DELETE** /addon/delete | Delete an addon by ID
[**GetAddon**](AddonApi.md#getaddon) | **GET** /addon | Retrieve an addon by ID
[**GetAllAddons**](AddonApi.md#getalladdons) | **GET** /addon/all | Retrieve all addons
[**GetAllWithTrashedAddons**](AddonApi.md#getallwithtrashedaddons) | **GET** /addon/all-with-trashed | Retrieve all addons including any deleted models
[**UpdateAddon**](AddonApi.md#updateaddon) | **PUT** /addon/edit | Update an Addon


<a name="addaddon"></a>
# **AddAddon**
> InlineResponse2002 AddAddon (string name, long? basePrices, string description = null)

Create a new addon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAddonExample
    {
        public void main()
        {
            
            var apiInstance = new AddonApi();
            var name = name_example;  // string | Name of the type of addon
            var basePrices = 789;  // long? | Prices for addon
            var description = description_example;  // string | Description of the addon (optional) 

            try
            {
                // Create a new addon
                InlineResponse2002 result = apiInstance.AddAddon(name, basePrices, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddAddon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the type of addon | 
 **basePrices** | **long?**| Prices for addon | 
 **description** | **string**| Description of the addon | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaddon"></a>
# **DeleteAddon**
> InlineResponse2003 DeleteAddon (long? body = null)

Delete an addon by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAddonExample
    {
        public void main()
        {
            
            var apiInstance = new AddonApi();
            var body = 789;  // long? | ID of the Addon (optional) 

            try
            {
                // Delete an addon by ID
                InlineResponse2003 result = apiInstance.DeleteAddon(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.DeleteAddon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **long?**| ID of the Addon | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddon"></a>
# **GetAddon**
> InlineResponse2001 GetAddon (long? id)

Retrieve an addon by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAddonExample
    {
        public void main()
        {
            
            var apiInstance = new AddonApi();
            var id = 789;  // long? | ID of the addon to be retrieved

            try
            {
                // Retrieve an addon by ID
                InlineResponse2001 result = apiInstance.GetAddon(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.GetAddon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of the addon to be retrieved | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalladdons"></a>
# **GetAllAddons**
> List<Addon> GetAllAddons ()

Retrieve all addons

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAddonsExample
    {
        public void main()
        {
            
            var apiInstance = new AddonApi();

            try
            {
                // Retrieve all addons
                List&lt;Addon&gt; result = apiInstance.GetAllAddons();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.GetAllAddons: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Addon>**](Addon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedaddons"></a>
# **GetAllWithTrashedAddons**
> List<Addon> GetAllWithTrashedAddons ()

Retrieve all addons including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedAddonsExample
    {
        public void main()
        {
            
            var apiInstance = new AddonApi();

            try
            {
                // Retrieve all addons including any deleted models
                List&lt;Addon&gt; result = apiInstance.GetAllWithTrashedAddons();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.GetAllWithTrashedAddons: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Addon>**](Addon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaddon"></a>
# **UpdateAddon**
> InlineResponse2002 UpdateAddon (long? id, string name = null, string description = null)

Update an Addon

Updates the addon by id using the specified fields

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAddonExample
    {
        public void main()
        {
            
            var apiInstance = new AddonApi();
            var id = 789;  // long? | ID of the Addon to be updated
            var name = name_example;  // string | Name of the Addon (optional) 
            var description = description_example;  // string | Description of the Addon (optional) 

            try
            {
                // Update an Addon
                InlineResponse2002 result = apiInstance.UpdateAddon(id, name, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.UpdateAddon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of the Addon to be updated | 
 **name** | **string**| Name of the Addon | [optional] 
 **description** | **string**| Description of the Addon | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

