# IO.Swagger.Api.DiagnosticsV10Api

All URIs are relative to *https://dev01-res.grosvenorcasinos.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Diagnose**](DiagnosticsV10Api.md#diagnose) | **GET** /retailmembership/v1/diagnose | Diagnose
[**Ping**](DiagnosticsV10Api.md#ping) | **GET** /retailmembership/v1/ping | Ping


<a name="diagnose"></a>
# **Diagnose**
> DiagnoseResponse Diagnose ()

Diagnose

The method allows to retrieve results of 3rd-aprty API or DB connectivity  diagnostics for specific service. Note, if service diagnostics is not configured  the response is internal server error 500 with a reason string. Possible diagnostic statuses are: OK, Failed, TimedOut, NotConfigured, FailedToCheck (usually a sign of misconfiguration).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DiagnoseExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DiagnosticsV10Api();

            try
            {
                // Diagnose
                DiagnoseResponse result = apiInstance.Diagnose();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsV10Api.Diagnose: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DiagnoseResponse**](DiagnoseResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ping"></a>
# **Ping**
> Object Ping ()

Ping

The method is a basic ping which returns HTTP response with status code 200  if service is available at the endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PingExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DiagnosticsV10Api();

            try
            {
                // Ping
                Object result = apiInstance.Ping();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsV10Api.Ping: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

