# IO.Swagger.Api.AgentApi

All URIs are relative to *https://dev.scubawhere.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAgent**](AgentApi.md#createagent) | **POST** /agent/add | Create a new agent
[**DeleteAgent**](AgentApi.md#deleteagent) | **DELETE** /agent/delete | Delete an agent by ID
[**GetAgent**](AgentApi.md#getagent) | **GET** /agent | Retrieve an agent by ID
[**GetAllAgents**](AgentApi.md#getallagents) | **GET** /agent/all | Retrieve all agents
[**GetAllWithTrashedAgents**](AgentApi.md#getallwithtrashedagents) | **GET** /agent/all-with-trashed | Retrieve all agents including any deleted models


<a name="createagent"></a>
# **CreateAgent**
> InlineResponse2004 CreateAgent (long? name, string branchName, string branchAddress, string branchPhone, string branchEmail, float? commission, string terms, string website = null, string billingAddress = null, string billingPhone = null, string billingEmail = null)

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
    public class CreateAgentExample
    {
        public void main()
        {
            
            var apiInstance = new AgentApi();
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
                InlineResponse2004 result = apiInstance.CreateAgent(name, branchName, branchAddress, branchPhone, branchEmail, commission, terms, website, billingAddress, billingPhone, billingEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.CreateAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="deleteagent"></a>
# **DeleteAgent**
> InlineResponse2003 DeleteAgent (long? id)

Delete an agent by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAgentExample
    {
        public void main()
        {
            
            var apiInstance = new AgentApi();
            var id = 789;  // long? | ID of the Agent

            try
            {
                // Delete an agent by ID
                InlineResponse2003 result = apiInstance.DeleteAgent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.DeleteAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of the Agent | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagent"></a>
# **GetAgent**
> InlineResponse2004 GetAgent (long? id)

Retrieve an agent by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAgentExample
    {
        public void main()
        {
            
            var apiInstance = new AgentApi();
            var id = 789;  // long? | ID of the agent to be retrieved

            try
            {
                // Retrieve an agent by ID
                InlineResponse2004 result = apiInstance.GetAgent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GetAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of the agent to be retrieved | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallagents"></a>
# **GetAllAgents**
> List<Agent> GetAllAgents ()

Retrieve all agents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAgentsExample
    {
        public void main()
        {
            
            var apiInstance = new AgentApi();

            try
            {
                // Retrieve all agents
                List&lt;Agent&gt; result = apiInstance.GetAllAgents();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GetAllAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Agent>**](Agent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithtrashedagents"></a>
# **GetAllWithTrashedAgents**
> List<Agent> GetAllWithTrashedAgents ()

Retrieve all agents including any deleted models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithTrashedAgentsExample
    {
        public void main()
        {
            
            var apiInstance = new AgentApi();

            try
            {
                // Retrieve all agents including any deleted models
                List&lt;Agent&gt; result = apiInstance.GetAllWithTrashedAgents();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GetAllWithTrashedAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Agent>**](Agent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

