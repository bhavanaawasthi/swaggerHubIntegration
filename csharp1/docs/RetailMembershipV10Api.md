# IO.Swagger.Api.RetailMembershipV10Api

All URIs are relative to *https://dev01-res.grosvenorcasinos.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLookupValues**](RetailMembershipV10Api.md#getlookupvalues) | **GET** /retailmembership/v1/lookups | Get lookup values
[**Lookup1**](RetailMembershipV10Api.md#lookup1) | **GET** /retailmembership/v1/customers/{membershipNo} | Lookup
[**RegisterThisOperationIsDisabled**](RetailMembershipV10Api.md#registerthisoperationisdisabled) | **POST** /retailmembership/v1/customers | Register - This operation is disabled


<a name="getlookupvalues"></a>
# **GetLookupValues**
> GetLookupValuesResponse GetLookupValues (bool? includeNationalities = null, bool? includeCountries = null, bool? incldueCasinos = null, bool? includeTitles = null)

Get lookup values

All lookup valus are provided through this single endpoint. The consuming application can request which lookup value list to be included in the response. if any of the parameter ommitted from the questring parameter or supplied value `false`, the response will not include the key and value (list) for category. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLookupValuesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RetailMembershipV10Api();
            var includeNationalities = true;  // bool? | include nationality look up values in the response (optional) 
            var includeCountries = true;  // bool? | include country look up values in the response (optional) 
            var incldueCasinos = true;  // bool? | include casino look up values in the response (optional) 
            var includeTitles = true;  // bool? | include title look up values in the response (optional) 

            try
            {
                // Get lookup values
                GetLookupValuesResponse result = apiInstance.GetLookupValues(includeNationalities, includeCountries, incldueCasinos, includeTitles);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RetailMembershipV10Api.GetLookupValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeNationalities** | **bool?**| include nationality look up values in the response | [optional] 
 **includeCountries** | **bool?**| include country look up values in the response | [optional] 
 **incldueCasinos** | **bool?**| include casino look up values in the response | [optional] 
 **includeTitles** | **bool?**| include title look up values in the response | [optional] 

### Return type

[**GetLookupValuesResponse**](GetLookupValuesResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lookup1"></a>
# **Lookup1**
> LookupResponse2 Lookup1 (double? membershipNo, DateTime? dateOfBirth, bool? checkAlreadyUsed = null)

Lookup

Model for the resource if defined below: ```             {                 \"Name\" : {                     \"Title\" : \"Mr\",                     \"Forename\" : \"John\",                     \"Surname\" : \"Jackson\",                     \"OtherName\" : \"William\"                 },                 \"Address\" : {                     \"Address1\" : \"10\",                     \"Address2\" : \"Downing Street\",                     \"Town\" : \"London\",                     \"Postcode\" : \"WC2B 4AA\",                     \"County\" : \"Greater London\",                     \"Country\"  : \"UK\"                 },                 \"Nationality\" : \"British\",                 \"TelephoneNumber\" : \"01234567890\",                 \"MobileNumber\" : \"01234567890\",                 \"DateOfBirth\" : \"1955-01-30\",                 \"EmailAddress\" : \"jack@rank.com\",                 \"Club\" : {                     \"ClubNumber\" : \"45611\",                     \"ClubName\" : \"Grosvenor casino\"                 },                 \"Contactable\" : true,                 \"ContactChannel\" : \"PEST\",                 \"AgeVerified\" : true,                 \"AffId\" : \"2728\",                 \"MembershipNo\" : \"12345\",                 \"CardNo\" : 67890             } ``` | Name          | Type      | Required                                          | Description                                                                       | Example   | |:- --           |:- --       |:- --                                               |:- --                                                                               |:- --       | |AffId          |string     |**yes** for Lookup Response, **no** for others     |When it's presented in a model the value should be 2728.                           |2728       | |Contactable    |bool       |**yes** for Register Request, **no** for others    |Shows whether customer is happy to receive the latest offers and information.      |True       | |ContactChannel |string     |**yes** for Register Request, **no** for others    |Shows prefered way of communication. P - Post, E - Email, S - SMS, T - Telephone.  |\"PEST\"     | For registration following input validation in place **Following fields must exists/must be non-null** - Name.Forename - Name.Surname - Address.Postcode - Club.ClubNumber **Following fields must follow a valid format** - Email address - valid email format - MobileNumber & TelephoneNumber - starts with 0 or +44, followed by 9/10 digits, it allows optional spacing between digits to conform the popular/acceptable format (i.e. 078 8602 8945, +44 78 8602 9845, etc) - Address.Postcode - valid UK postcode - DateOfBirth - must be of legal age (18) - Club.ClubNumber - Club number must be a valid Grsovenor casino. Use Venue details service to validate the detail before testing.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Lookup1Example
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RetailMembershipV10Api();
            var membershipNo = 1.2;  // double? | Card number (Number found on the back of the card) of the Customer in form of an integer
            var dateOfBirth = 2013-10-20T19:20:30+01:00;  // DateTime? | Date of birth of the Customer
            var checkAlreadyUsed = true;  // bool? | Enables Customer Spine registration check. The flag modifies response entity according to the following rules: - customer registered on Spine, adds _IsAlreadyUsedOnDigital_ property with value _true_ - customer not registered - adds _IsAlreadyUsedOnDigital_ property with value _false_ - Spine check failed - no changes to response (optional) 

            try
            {
                // Lookup
                LookupResponse2 result = apiInstance.Lookup1(membershipNo, dateOfBirth, checkAlreadyUsed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RetailMembershipV10Api.Lookup1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **membershipNo** | **double?**| Card number (Number found on the back of the card) of the Customer in form of an integer | 
 **dateOfBirth** | **DateTime?**| Date of birth of the Customer | 
 **checkAlreadyUsed** | **bool?**| Enables Customer Spine registration check. The flag modifies response entity according to the following rules: - customer registered on Spine, adds _IsAlreadyUsedOnDigital_ property with value _true_ - customer not registered - adds _IsAlreadyUsedOnDigital_ property with value _false_ - Spine check failed - no changes to response | [optional] 

### Return type

[**LookupResponse2**](LookupResponse2.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerthisoperationisdisabled"></a>
# **RegisterThisOperationIsDisabled**
> void RegisterThisOperationIsDisabled (RegisterThisOperationIsDisabledRequest body)

Register - This operation is disabled

Model for the resource if defined below: ```             {                 \"Name\" : {                     \"Title\" : \"Mr\",                     \"Forename\" : \"John\",                     \"Surname\" : \"Jackson\",                     \"OtherName\" : \"William\"                 },                 \"Address\" : {                     \"Address1\" : \"10\",                     \"Address2\" : \"Downing Street\",                     \"Town\" : \"London\",                     \"Postcode\" : \"WC2B 4AA\",                     \"County\" : \"Greater London\",                     \"Country\"  : \"UK\"                 },                 \"Nationality\" : \"British\",                 \"TelephoneNumber\" : \"01234567890\",                 \"MobileNumber\" : \"01234567890\",                 \"DateOfBirth\" : \"1955-01-30\",                 \"EmailAddress\" : \"jack@rank.com\",                 \"Club\" : {                     \"ClubNumber\" : \"45611\",                     \"ClubName\" : \"Grosvenor casino\"                 },                 \"Contactable\" : true,                 \"ContactChannel\" : \"PEST\",                 \"AgeVerified\" : true,                 \"AffId\" : \"2728\",                 \"MembershipNo\" : \"12345\",                 \"CardNo\" : 67890             } ``` | Name          | Type      | Required                                          | Description                                                                       | Example   | |:- --           |:- --       |:- --                                               |:- --                                                                               |:- --       | |AffId          |string     |**yes** for Lookup Response, **no** for others     |When it's presented in a model the value should be 2728.                           |2728       | |Contactable    |bool       |**yes** for Register Request, **no** for others    |Shows whether customer is happy to receive the latest offers and information.      |True       | |ContactChannel |string     |**yes** for Register Request, **no** for others    |Shows prefered way of communication. P - Post, E - Email, S - SMS, T - Telephone.  |\"PEST\"     | For registration following input validation in place **Following fields must exists/must be non-null** - Name.Forename - Name.Surname - Address.Postcode - Club.ClubNumber **Following fields must follow a valid format** - Email address - valid email format - MobileNumber & TelephoneNumber - starts with 0 or +44, followed by 9/10 digits, it allows optional spacing between digits to conform the popular/acceptable format (i.e. 078 8602 8945, +44 78 8602 9845, etc) - Address.Postcode - valid UK postcode - DateOfBirth - must be of legal age (18) - Club.ClubNumber - Club number must be a valid Grsovenor casino. Use Venue details service to validate the detail before testing.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterThisOperationIsDisabledExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RetailMembershipV10Api();
            var body = new RegisterThisOperationIsDisabledRequest(); // RegisterThisOperationIsDisabledRequest | 

            try
            {
                // Register - This operation is disabled
                apiInstance.RegisterThisOperationIsDisabled(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RetailMembershipV10Api.RegisterThisOperationIsDisabled: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegisterThisOperationIsDisabledRequest**](RegisterThisOperationIsDisabledRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

