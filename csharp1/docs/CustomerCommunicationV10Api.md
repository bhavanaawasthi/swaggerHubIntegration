# IO.Swagger.Api.CustomerCommunicationV10Api

All URIs are relative to *https://dev01-res.grosvenorcasinos.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendEmail**](CustomerCommunicationV10Api.md#sendemail) | **POST** /communication/v1/digitalCustomer/{playerId}/email | SendEmail


<a name="sendemail"></a>
# **SendEmail**
> void SendEmail (long? playerId, SendemailRequest body)

SendEmail

| Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \"WelcomeNonClub\", \"WelcomeClub\", \"ForgotUsername\", \"ForgotPassword\"|\"ForgotUsername\"          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\"DynamicFields\" : { \"Password_URL\" : \"https://www.grosvenorcasinos.com/forgot?af34b28dea4\" }      |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendEmailExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomerCommunicationV10Api();
            var playerId = 789;  // long? | Customer identifier from the digital platform
            var body = new SendemailRequest(); // SendemailRequest | 

            try
            {
                // SendEmail
                apiInstance.SendEmail(playerId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerCommunicationV10Api.SendEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playerId** | **long?**| Customer identifier from the digital platform | 
 **body** | [**SendemailRequest**](SendemailRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

