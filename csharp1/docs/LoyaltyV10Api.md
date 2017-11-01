# IO.Swagger.Api.LoyaltyV10Api

All URIs are relative to *https://dev01-res.grosvenorcasinos.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDigitalAccount**](LoyaltyV10Api.md#adddigitalaccount) | **POST** /loyalty/v1/accounts | Add digital Account
[**CreateCustomersPlaypointsAccount**](LoyaltyV10Api.md#createcustomersplaypointsaccount) | **POST** /loyalty/v1/customers/ | Create customers playpoints account
[**MergeDigitalAndRetailAccountsFlavour2**](LoyaltyV10Api.md#mergedigitalandretailaccountsflavour2) | **PUT** /loyalty/v1/accounts | Merge Digital and Retail Accounts - flavour 2
[**RedeemPoints**](LoyaltyV10Api.md#redeempoints) | **DELETE** /loyalty/v1/points | Redeem points
[**RetrievePointsBalance**](LoyaltyV10Api.md#retrievepointsbalance) | **GET** /loyalty/v1/points/ | Retrieve Points balance


<a name="adddigitalaccount"></a>
# **AddDigitalAccount**
> AddDigitalAccountResponse AddDigitalAccount (AddDigitalAccountRequest body)

Add digital Account

Adding the newly created digital account to the retail loyalty account and returns the points balance, Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:- --               |:- --       |:- --       |:- --                                           |:- --               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |MembershipNo       |string     |Yes        |Retail Casino membership number.               |123456789         |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddDigitalAccountExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV10Api();
            var body = new AddDigitalAccountRequest(); // AddDigitalAccountRequest | 

            try
            {
                // Add digital Account
                AddDigitalAccountResponse result = apiInstance.AddDigitalAccount(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV10Api.AddDigitalAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddDigitalAccountRequest**](AddDigitalAccountRequest.md)|  | 

### Return type

[**AddDigitalAccountResponse**](AddDigitalAccountResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomersplaypointsaccount"></a>
# **CreateCustomersPlaypointsAccount**
> void CreateCustomersPlaypointsAccount (CreateCustomersPlaypointsAccountRequest body)

Create customers playpoints account

| Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |PlayerId       |long       |yes        |Customer identifier from the digital platform.     |570515106383925248 | |Forename       |string     |yes        |first name of the customer                         |\"Bob\"              | |Surname        |string     |yes        |Last name of the customer                          |\"Marley\"           | |DateOfBirth    |Date       |yes        |Date of birth of the customer.                     |1982-04-28         |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomersPlaypointsAccountExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV10Api();
            var body = new CreateCustomersPlaypointsAccountRequest(); // CreateCustomersPlaypointsAccountRequest | 

            try
            {
                // Create customers playpoints account
                apiInstance.CreateCustomersPlaypointsAccount(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV10Api.CreateCustomersPlaypointsAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCustomersPlaypointsAccountRequest**](CreateCustomersPlaypointsAccountRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedigitalandretailaccountsflavour2"></a>
# **MergeDigitalAndRetailAccountsFlavour2**
> MergeDigitalAndRetailAccountsFlavour1Response MergeDigitalAndRetailAccountsFlavour2 (MergeDigitalAndRetailAccountsFlavour2Request body)

Merge Digital and Retail Accounts - flavour 2

This method is a varient of the above method which links the digital and retail loyalty accounts and merges the points earned. This can be used when retail membership number is not available to the client. Returns the combined points balance, Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:- --               |:- --       |:- --       |:- --                                           |:- --               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |CardNo             |int        |Yes        |Player loyalty Card number                     |1460040108         | |DateofBirth        |Date       |yes        |Date of birth of the customer.                 |1982-04-28         |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MergeDigitalAndRetailAccountsFlavour2Example
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV10Api();
            var body = new MergeDigitalAndRetailAccountsFlavour2Request(); // MergeDigitalAndRetailAccountsFlavour2Request | 

            try
            {
                // Merge Digital and Retail Accounts - flavour 2
                MergeDigitalAndRetailAccountsFlavour1Response result = apiInstance.MergeDigitalAndRetailAccountsFlavour2(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV10Api.MergeDigitalAndRetailAccountsFlavour2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MergeDigitalAndRetailAccountsFlavour2Request**](MergeDigitalAndRetailAccountsFlavour2Request.md)|  | 

### Return type

[**MergeDigitalAndRetailAccountsFlavour1Response**](MergeDigitalAndRetailAccountsFlavour1Response.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redeempoints"></a>
# **RedeemPoints**
> void RedeemPoints (RedeemPointsRequest body)

Redeem points

Redeem the playpoints balance, Request body fields: | Name              | Type      | Required  | Description                                       | Example               | |:- --               |:- --       |:- --       |:- --                                               |:- --                   | |PlayerId           |long       |yes        |Customer identifier from the digital platform.     |570515106383925248     | |Points             |int        |yes        |amount that needs adjusting                        |100                    | |RedeemDateTime     |DateTime   |yes        |Date and time of the redemption call.              |2015-04-28T10:10:25Z   | Response would be * OK (HTTP 200) - when redemption is successful * Bad Request (400) -       * the request parameters are not valid or      * the player hasn't got enough funds or      * the player has exceeded the daily redemption limit (Message: \"Sorry, you can only redeem a maximum of 50000 PLAY Points in a day\") * Error (500) - when there is an error redeeming the points. Most likely cause would be ability to connect to other systems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RedeemPointsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV10Api();
            var body = new RedeemPointsRequest(); // RedeemPointsRequest | 

            try
            {
                // Redeem points
                apiInstance.RedeemPoints(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV10Api.RedeemPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RedeemPointsRequest**](RedeemPointsRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievepointsbalance"></a>
# **RetrievePointsBalance**
> RetrievePointsBalanceResponse RetrievePointsBalance (long? playerId = null, double? cardNo = null, string membershipNo = null, string testMembershipNo = null)

Retrieve Points balance

Retrieves play points balance for the customer, any one of the below parameters is required. | Name          | Type  | Description                                       | Example           | |:- --           |:- --   |:- --                                               |:- --               | |playerId       |long   |Customer identifier from the digital platform.     |570515106383925248 | |cardNo         |number |Number on the back of the membership card.         |16227376           | |membershipNo   |string |Retail Casino membership number.                   |1850034070         | |testId       |long   |Customer identifier from the digital platform.     |570515106383925248 |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrievePointsBalanceExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV10Api();
            var playerId = 789;  // long? | Customer identifier from the digital platform (optional) 
            var cardNo = 1.2;  // double? | Number on the back of the membership card. If specified, then Grade will be returned. (optional) 
            var membershipNo = membershipNo_example;  // string | Retail Casino membership number. (optional) 
            var testMembershipNo = testMembershipNo_example;  // string | Retail test Casino membership number. (optional) 

            try
            {
                // Retrieve Points balance
                RetrievePointsBalanceResponse result = apiInstance.RetrievePointsBalance(playerId, cardNo, membershipNo, testMembershipNo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV10Api.RetrievePointsBalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playerId** | **long?**| Customer identifier from the digital platform | [optional] 
 **cardNo** | **double?**| Number on the back of the membership card. If specified, then Grade will be returned. | [optional] 
 **membershipNo** | **string**| Retail Casino membership number. | [optional] 
 **testMembershipNo** | **string**| Retail test Casino membership number. | [optional] 

### Return type

[**RetrievePointsBalanceResponse**](RetrievePointsBalanceResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

