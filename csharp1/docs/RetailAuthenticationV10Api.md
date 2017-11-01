# IO.Swagger.Api.RetailAuthenticationV10Api

All URIs are relative to *https://dev01-res.grosvenorcasinos.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Lookup**](RetailAuthenticationV10Api.md#lookup) | **GET** /retailauthentication/v1/lookup | Lookup


<a name="lookup"></a>
# **Lookup**
> LookupResponse Lookup (double? cardNo)

Lookup

Returns BEDE player id from the persistance storage for the cardNo provided. If no record found, the response would be 404 (not found)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LookupExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RetailAuthenticationV10Api();
            var cardNo = 1.2;  // double? | card no issued to the retail customer

            try
            {
                // Lookup
                LookupResponse result = apiInstance.Lookup(cardNo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RetailAuthenticationV10Api.Lookup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cardNo** | **double?**| card no issued to the retail customer | 

### Return type

[**LookupResponse**](LookupResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

