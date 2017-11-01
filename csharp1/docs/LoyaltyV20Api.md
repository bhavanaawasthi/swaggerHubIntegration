# IO.Swagger.Api.LoyaltyV20Api

All URIs are relative to *https://dev01-res.grosvenorcasinos.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccrueLoyaltyPoints**](LoyaltyV20Api.md#accrueloyaltypoints) | **PUT** /loyalty/v2/points/ | Accrue loyalty points
[**CreateLoyaltyAccountForDigitalMembershipAccount**](LoyaltyV20Api.md#createloyaltyaccountfordigitalmembershipaccount) | **POST** /loyalty/v2/accounts/digital | Create Loyalty Account for Digital Membership Account
[**CreateLoyaltyAccountForRetailMembershipAccount**](LoyaltyV20Api.md#createloyaltyaccountforretailmembershipaccount) | **POST** /loyalty/v2/accounts/retail | Create Loyalty Account for Retail Membership Account
[**LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccount**](LoyaltyV20Api.md#linkexistingretailloyaltyaccounttonewdigitalmembershipaccount) | **PATCH** /loyalty/v2/accounts/retail | Link existing Retail Loyalty Account to new Digital Membership Account
[**MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2**](LoyaltyV20Api.md#mergeexistingdigitalandretailloyaltyaccountsflavour2) | **POST** /loyalty/v2/accounts/merge | Merge existing Digital and Retail Loyalty Accounts - flavour 2
[**RedeemLoyaltyPoints**](LoyaltyV20Api.md#redeemloyaltypoints) | **DELETE** /loyalty/v2/points/ | Redeem loyalty points
[**RetrieveAllAccountsSummaryByGrade**](LoyaltyV20Api.md#retrieveallaccountssummarybygrade) | **GET** /loyalty/v2/accounts/summary | Retrieve all Accounts Summary by Grade
[**RetrievePointsBalance1**](LoyaltyV20Api.md#retrievepointsbalance1) | **GET** /loyalty/v2/points/ | Retrieve Points balance
[**RetrievesCustomerDetailsByTheSpecifiedCardNumber_**](LoyaltyV20Api.md#retrievescustomerdetailsbythespecifiedcardnumber_) | **GET** /loyalty/v2/accounts/ | Retrieves  customer details by the specified card number.
[**UpdateLoyaltyAccountForRetailMembershipAccount**](LoyaltyV20Api.md#updateloyaltyaccountforretailmembershipaccount) | **PUT** /loyalty/v2/accounts/retail | Update Loyalty Account for Retail Membership Account


<a name="accrueloyaltypoints"></a>
# **AccrueLoyaltyPoints**
> void AccrueLoyaltyPoints (AccrueLoyaltyPointsRequest body)

Accrue loyalty points

Issue loyalty points to the specified account. | Name              | Type      | Required                             | Description                                   | Example           | |:- --               |:- --       |:- --                                  |:- --                                           |:- --               | |CardNo             |int        |yes                                   |Number on the back of the membership card      |570515106          | |LocationId         |string     |yes                                   |Casion locationId                              |005Bar,FOOD        | |Points             |int        |yes                                   |points that needs adjusting                    |100                    | |TransactionDateTime |DateTime   |yes                                  |Transaction Date and time .                    |2015-04-28T10:10:25Z   |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccrueLoyaltyPointsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var body = new AccrueLoyaltyPointsRequest(); // AccrueLoyaltyPointsRequest | 

            try
            {
                // Accrue loyalty points
                apiInstance.AccrueLoyaltyPoints(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.AccrueLoyaltyPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccrueLoyaltyPointsRequest**](AccrueLoyaltyPointsRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createloyaltyaccountfordigitalmembershipaccount"></a>
# **CreateLoyaltyAccountForDigitalMembershipAccount**
> void CreateLoyaltyAccountForDigitalMembershipAccount (CreateLoyaltyAccountForDigitalMembershipAccountRequest body)

Create Loyalty Account for Digital Membership Account

Managing actions for digital and retail loyalty accounts. Registers a digital customer in the loyalty system. | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |PlayerId       |long       |yes        |Customer identifier from the digital platform.     |570515106383925248 | |Forename       |string     |yes        |first name of the customer                         |\"Bob\"              | |Surname        |string     |yes        |Last name of the customer                          |\"Marley\"           | |DateOfBirth    |Date       |yes        |Date of birth of the customer.                     |1982-04-28         |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLoyaltyAccountForDigitalMembershipAccountExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var body = new CreateLoyaltyAccountForDigitalMembershipAccountRequest(); // CreateLoyaltyAccountForDigitalMembershipAccountRequest | 

            try
            {
                // Create Loyalty Account for Digital Membership Account
                apiInstance.CreateLoyaltyAccountForDigitalMembershipAccount(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.CreateLoyaltyAccountForDigitalMembershipAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateLoyaltyAccountForDigitalMembershipAccountRequest**](CreateLoyaltyAccountForDigitalMembershipAccountRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createloyaltyaccountforretailmembershipaccount"></a>
# **CreateLoyaltyAccountForRetailMembershipAccount**
> void CreateLoyaltyAccountForRetailMembershipAccount (CreateLoyaltyAccountForRetailMembershipAccountRequest body)

Create Loyalty Account for Retail Membership Account

Registers a retail customer in the loyalty system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLoyaltyAccountForRetailMembershipAccountExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var body = new CreateLoyaltyAccountForRetailMembershipAccountRequest(); // CreateLoyaltyAccountForRetailMembershipAccountRequest | 

            try
            {
                // Create Loyalty Account for Retail Membership Account
                apiInstance.CreateLoyaltyAccountForRetailMembershipAccount(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.CreateLoyaltyAccountForRetailMembershipAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateLoyaltyAccountForRetailMembershipAccountRequest**](CreateLoyaltyAccountForRetailMembershipAccountRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkexistingretailloyaltyaccounttonewdigitalmembershipaccount"></a>
# **LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccount**
> LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccount (LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest body)

Link existing Retail Loyalty Account to new Digital Membership Account

Adding newly created digital account to the existing retail loyalty account and returns the points balance. Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:- --               |:- --       |:- --       |:- --                                           |:- --               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |MembershipNo       |string     |Yes        |Retail Casino membership number.               |123456789         |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var body = new LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest(); // LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest | 

            try
            {
                // Link existing Retail Loyalty Account to new Digital Membership Account
                LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse result = apiInstance.LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccount(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest**](LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest.md)|  | 

### Return type

[**LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse**](LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergeexistingdigitalandretailloyaltyaccountsflavour2"></a>
# **MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2**
> MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2 (MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2Request body)

Merge existing Digital and Retail Loyalty Accounts - flavour 2

This method is a varient of the above method, which links the existing digital and retail loyalty accounts and merges the points earned. Returns the combined points balance. This can be used when retail membership number is not available to the client. Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:- --               |:- --       |:- --       |:- --                                           |:- --               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |CardNo             |long       |Yes        |Player loyalty Card number                     |1460040108         | |DateofBirth        |Date       |yes        |Date of birth of the customer.                 |1982-04-28         |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2Example
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var body = new MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2Request(); // MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2Request | 

            try
            {
                // Merge existing Digital and Retail Loyalty Accounts - flavour 2
                MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response result = apiInstance.MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2Request**](MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2Request.md)|  | 

### Return type

[**MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response**](MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redeemloyaltypoints"></a>
# **RedeemLoyaltyPoints**
> void RedeemLoyaltyPoints (RedeemLoyaltyPointsRequest body)

Redeem loyalty points

Redeem loyalty points from the specified account. | Name              | Type      | Required                                  | Description                                   | Example           | |:- --               |:- --       |:- --                                       |:- --                                           |:- --               | |CardNo             |int        |optional (Required only for Retail)        |Number on the back of the membership card      |570515106          | |LocationId         |string     |optional (Required only for Retail)        |Casion locationId                              |005Bar,FOOD        | |PlayerId           |long       |optional (Required only for digital)       |Customer identifier from the digital platform. |570515106383925248     | |Points             |int        |Required                                   |points that needs adjusting                    |100                    | |RedeemDateTime     |DateTime   |yes                                        |Date and time of the redemption call.          |2015-04-28T10:10:25Z   |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RedeemLoyaltyPointsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var body = new RedeemLoyaltyPointsRequest(); // RedeemLoyaltyPointsRequest | 

            try
            {
                // Redeem loyalty points
                apiInstance.RedeemLoyaltyPoints(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.RedeemLoyaltyPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RedeemLoyaltyPointsRequest**](RedeemLoyaltyPointsRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveallaccountssummarybygrade"></a>
# **RetrieveAllAccountsSummaryByGrade**
> RetrieveAllAccountsSummaryByGradeResponse RetrieveAllAccountsSummaryByGrade (string grade)

Retrieve all Accounts Summary by Grade

Retrieves a summary information about each customer, who belongs to the specified grade. The below parameter is required.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveAllAccountsSummaryByGradeExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var grade = grade_example;  // string | A grouping of customers by certain properties. Possible values: MEMBER, GOLD, BLACK.

            try
            {
                // Retrieve all Accounts Summary by Grade
                RetrieveAllAccountsSummaryByGradeResponse result = apiInstance.RetrieveAllAccountsSummaryByGrade(grade);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.RetrieveAllAccountsSummaryByGrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grade** | **string**| A grouping of customers by certain properties. Possible values: MEMBER, GOLD, BLACK. | 

### Return type

[**RetrieveAllAccountsSummaryByGradeResponse**](RetrieveAllAccountsSummaryByGradeResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievepointsbalance1"></a>
# **RetrievePointsBalance1**
> RetrievePointsBalanceResponse17 RetrievePointsBalance1 (long? playerId = null, int? cardNo = null, string membershipNo = null)

Retrieve Points balance

Retrieves loyalty points balance for the customer, any one of the below parameters is required. | Name          | Type  | Description                                       | Example           | |:- --           |:- --   |:- --                                               |:- --               | |playerId       |long   |Customer identifier from the digital platform.     |570515106383925248 | |cardNo         |int    |Number on the back of the membership card.(retail) |16227376           | |membershipNo   |string |Retail Casino membership number.                   |1850034070         |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrievePointsBalance1Example
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var playerId = 789;  // long? | Customer identifier from the digital platform (optional) 
            var cardNo = 56;  // int? | Number on the back of the membership card. If specified, then Grade will be returned. (optional) 
            var membershipNo = membershipNo_example;  // string | Retail Casino membership number. (optional) 

            try
            {
                // Retrieve Points balance
                RetrievePointsBalanceResponse17 result = apiInstance.RetrievePointsBalance1(playerId, cardNo, membershipNo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.RetrievePointsBalance1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playerId** | **long?**| Customer identifier from the digital platform | [optional] 
 **cardNo** | **int?**| Number on the back of the membership card. If specified, then Grade will be returned. | [optional] 
 **membershipNo** | **string**| Retail Casino membership number. | [optional] 

### Return type

[**RetrievePointsBalanceResponse17**](RetrievePointsBalanceResponse17.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievescustomerdetailsbythespecifiedcardnumber_"></a>
# **RetrievesCustomerDetailsByTheSpecifiedCardNumber_**
> RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse RetrievesCustomerDetailsByTheSpecifiedCardNumber_ (int? cardNo)

Retrieves  customer details by the specified card number.

Retrieves customer profile information by cardNo. | Name          | Type  | Required                                              | Description                                       | Example           | |:- --           |:- --   |:- --                                                   |:- --                                               |:- --               | CardNo          |int    | Yes                                                   |Number on the back of the membership card.(retail) |16227376           |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrievesCustomerDetailsByTheSpecifiedCardNumber_Example
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var cardNo = 56;  // int? | Number on the back of the membership card for retail

            try
            {
                // Retrieves  customer details by the specified card number.
                RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse result = apiInstance.RetrievesCustomerDetailsByTheSpecifiedCardNumber_(cardNo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.RetrievesCustomerDetailsByTheSpecifiedCardNumber_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cardNo** | **int?**| Number on the back of the membership card for retail | 

### Return type

[**RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse**](RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateloyaltyaccountforretailmembershipaccount"></a>
# **UpdateLoyaltyAccountForRetailMembershipAccount**
> void UpdateLoyaltyAccountForRetailMembershipAccount (UpdateLoyaltyAccountForRetailMembershipAccountRequest body)

Update Loyalty Account for Retail Membership Account

Updates the existing retail loyalty account with specified values.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLoyaltyAccountForRetailMembershipAccountExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoyaltyV20Api();
            var body = new UpdateLoyaltyAccountForRetailMembershipAccountRequest(); // UpdateLoyaltyAccountForRetailMembershipAccountRequest | 

            try
            {
                // Update Loyalty Account for Retail Membership Account
                apiInstance.UpdateLoyaltyAccountForRetailMembershipAccount(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyV20Api.UpdateLoyaltyAccountForRetailMembershipAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateLoyaltyAccountForRetailMembershipAccountRequest**](UpdateLoyaltyAccountForRetailMembershipAccountRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

