# IO.Swagger.Api.VenueServiceV10Api

All URIs are relative to *https://dev01-res.grosvenorcasinos.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AllCasinos**](VenueServiceV10Api.md#allcasinos) | **GET** /venue/v1/casinos | All Casinos
[**CasinoDetails**](VenueServiceV10Api.md#casinodetails) | **GET** /venue/v1/casinos/{number} | Casino Details
[**CasinoEvents**](VenueServiceV10Api.md#casinoevents) | **GET** /venue/v1/casinos/{number}/events | Casino Events
[**CasinoPokerCashGames**](VenueServiceV10Api.md#casinopokercashgames) | **GET** /venue/v1/casinos/{number}/poker-cash-games | Casino Poker Cash Games
[**CasinoPokerSchedules**](VenueServiceV10Api.md#casinopokerschedules) | **GET** /venue/v1/casinos/{number}/poker-schedules | Casino Poker Schedules


<a name="allcasinos"></a>
# **AllCasinos**
> List<AllCasinosResponse> AllCasinos ()

All Casinos

Returns collection of all casinos

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AllCasinosExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VenueServiceV10Api();

            try
            {
                // All Casinos
                List&lt;AllCasinosResponse&gt; result = apiInstance.AllCasinos();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VenueServiceV10Api.AllCasinos: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AllCasinosResponse>**](AllCasinosResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casinodetails"></a>
# **CasinoDetails**
> CasinoDetailsResponse CasinoDetails (double? number)

Casino Details

Returns casino specific details when the casino number is provided

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CasinoDetailsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VenueServiceV10Api();
            var number = 1.2;  // double? | Casino number in form of an integer

            try
            {
                // Casino Details
                CasinoDetailsResponse result = apiInstance.CasinoDetails(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VenueServiceV10Api.CasinoDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **double?**| Casino number in form of an integer | 

### Return type

[**CasinoDetailsResponse**](CasinoDetailsResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casinoevents"></a>
# **CasinoEvents**
> List<CasinoEventsResponse> CasinoEvents (double? number)

Casino Events

Returns a collection of events when casino number is provided

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CasinoEventsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VenueServiceV10Api();
            var number = 1.2;  // double? | Casino number in form of an integer

            try
            {
                // Casino Events
                List&lt;CasinoEventsResponse&gt; result = apiInstance.CasinoEvents(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VenueServiceV10Api.CasinoEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **double?**| Casino number in form of an integer | 

### Return type

[**List<CasinoEventsResponse>**](CasinoEventsResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casinopokercashgames"></a>
# **CasinoPokerCashGames**
> List<CasinoPokerCashGamesResponse> CasinoPokerCashGames (double? number)

Casino Poker Cash Games

This resource returns the collection of poker cash games schedules for a specific casino, a cash game schedule is represented as below, ```         {             \"CasinoNumber\":5204,             \"Day\":\"Every Day\",             \"Start\":\"Select\",             \"End\":\"Select\",             \"NumberOfGames\":5,             \"StakeFrom\":\"5\",             \"StakeTo\":\"250\",             \"BlindsFrom\":\".25\",             \"BlindsTo\":\"10\",             \"SessionOrRake\":\"Rake\"         } ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CasinoPokerCashGamesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VenueServiceV10Api();
            var number = 1.2;  // double? | Casino number in form of an integer

            try
            {
                // Casino Poker Cash Games
                List&lt;CasinoPokerCashGamesResponse&gt; result = apiInstance.CasinoPokerCashGames(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VenueServiceV10Api.CasinoPokerCashGames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **double?**| Casino number in form of an integer | 

### Return type

[**List<CasinoPokerCashGamesResponse>**](CasinoPokerCashGamesResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casinopokerschedules"></a>
# **CasinoPokerSchedules**
> List<CasinoPokerSchedulesResponse> CasinoPokerSchedules (double? number)

Casino Poker Schedules

This resource returns the collection of poker tournament schedules for a specific casino, a schedule is represented as below, ```         {             \"CasinoNumber\": 5005,             \"Day\": \"Every Tuesday \",             \"StartDate\": \"2015-06-08 00:00:00\",             \"EndDate\": \"2015-09-27 00:00:00\",             \"Game\": \"&pound;5: &pound;500 Gtd With &pound;5 R/b And &pound;10 A/o\",             \"GameType\": \"Re-Buy \",             \"Stake\": 5,             \"StartingStake\": \"5,000\",             \"RegFee\": 5,             \"StartTime\": \"20:00\"         } ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CasinoPokerSchedulesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VenueServiceV10Api();
            var number = 1.2;  // double? | Casino number in form of an integer

            try
            {
                // Casino Poker Schedules
                List&lt;CasinoPokerSchedulesResponse&gt; result = apiInstance.CasinoPokerSchedules(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VenueServiceV10Api.CasinoPokerSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **double?**| Casino number in form of an integer | 

### Return type

[**List<CasinoPokerSchedulesResponse>**](CasinoPokerSchedulesResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

