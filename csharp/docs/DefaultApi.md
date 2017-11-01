# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://virtserver.swaggerhub.com/Rank5/HelloWorld/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExampleGet**](DefaultApi.md#exampleget) | **GET** /example | Server example operation
[**PingGet**](DefaultApi.md#pingget) | **GET** /ping | Server heartbeat operation


<a name="exampleget"></a>
# **ExampleGet**
> void ExampleGet ()

Server example operation

This is an example opeartion to show how security is applied to the call.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExampleGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: accessCode
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                // Server example operation
                apiInstance.ExampleGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ExampleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[accessCode](../README.md#accessCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pingget"></a>
# **PingGet**
> void PingGet ()

Server heartbeat operation

This operation shows how to override the global security defined above, as we want to open it up for all users.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PingGetExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();

            try
            {
                // Server heartbeat operation
                apiInstance.PingGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

