using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVenueServiceV10Api
    {
        /// <summary>
        /// All Casinos Returns collection of all casinos
        /// </summary>
        /// <returns>List&lt;AllCasinosResponse&gt;</returns>
        List<AllCasinosResponse> All Casinos ();
        /// <summary>
        /// Casino Details Returns casino specific details when the casino number is provided
        /// </summary>
        /// <param name="number">Casino number in form of an integer</param>
        /// <returns>CasinoDetailsResponse</returns>
        CasinoDetailsResponse Casino Details (double? number);
        /// <summary>
        /// Casino Events Returns a collection of events when casino number is provided
        /// </summary>
        /// <param name="number">Casino number in form of an integer</param>
        /// <returns>List&lt;CasinoEventsResponse&gt;</returns>
        List<CasinoEventsResponse> Casino Events (double? number);
        /// <summary>
        /// Casino Poker Cash Games This resource returns the collection of poker cash games schedules for a specific casino, a cash game schedule is represented as below, &#x60;&#x60;&#x60;         {             \&quot;CasinoNumber\&quot;:5204,             \&quot;Day\&quot;:\&quot;Every Day\&quot;,             \&quot;Start\&quot;:\&quot;Select\&quot;,             \&quot;End\&quot;:\&quot;Select\&quot;,             \&quot;NumberOfGames\&quot;:5,             \&quot;StakeFrom\&quot;:\&quot;5\&quot;,             \&quot;StakeTo\&quot;:\&quot;250\&quot;,             \&quot;BlindsFrom\&quot;:\&quot;.25\&quot;,             \&quot;BlindsTo\&quot;:\&quot;10\&quot;,             \&quot;SessionOrRake\&quot;:\&quot;Rake\&quot;         } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="number">Casino number in form of an integer</param>
        /// <returns>List&lt;CasinoPokerCashGamesResponse&gt;</returns>
        List<CasinoPokerCashGamesResponse> Casino Poker Cash Games (double? number);
        /// <summary>
        /// Casino Poker Schedules This resource returns the collection of poker tournament schedules for a specific casino, a schedule is represented as below, &#x60;&#x60;&#x60;         {             \&quot;CasinoNumber\&quot;: 5005,             \&quot;Day\&quot;: \&quot;Every Tuesday \&quot;,             \&quot;StartDate\&quot;: \&quot;2015-06-08 00:00:00\&quot;,             \&quot;EndDate\&quot;: \&quot;2015-09-27 00:00:00\&quot;,             \&quot;Game\&quot;: \&quot;&amp;pound;5: &amp;pound;500 Gtd With &amp;pound;5 R/b And &amp;pound;10 A/o\&quot;,             \&quot;GameType\&quot;: \&quot;Re-Buy \&quot;,             \&quot;Stake\&quot;: 5,             \&quot;StartingStake\&quot;: \&quot;5,000\&quot;,             \&quot;RegFee\&quot;: 5,             \&quot;StartTime\&quot;: \&quot;20:00\&quot;         } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="number">Casino number in form of an integer</param>
        /// <returns>List&lt;CasinoPokerSchedulesResponse&gt;</returns>
        List<CasinoPokerSchedulesResponse> Casino Poker Schedules (double? number);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VenueServiceV10Api : IVenueServiceV10Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenueServiceV10Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VenueServiceV10Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VenueServiceV10Api"/> class.
        /// </summary>
        /// <returns></returns>
        public VenueServiceV10Api(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// All Casinos Returns collection of all casinos
        /// </summary>
        /// <returns>List&lt;AllCasinosResponse&gt;</returns>            
        public List<AllCasinosResponse> All Casinos ()
        {
            
    
            var path = "/venue/v1/casinos";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling All Casinos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling All Casinos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AllCasinosResponse>) ApiClient.Deserialize(response.Content, typeof(List<AllCasinosResponse>), response.Headers);
        }
    
        /// <summary>
        /// Casino Details Returns casino specific details when the casino number is provided
        /// </summary>
        /// <param name="number">Casino number in form of an integer</param> 
        /// <returns>CasinoDetailsResponse</returns>            
        public CasinoDetailsResponse Casino Details (double? number)
        {
            
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling Casino Details");
            
    
            var path = "/venue/v1/casinos/{number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "number" + "}", ApiClient.ParameterToString(number));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Casino Details: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Casino Details: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CasinoDetailsResponse) ApiClient.Deserialize(response.Content, typeof(CasinoDetailsResponse), response.Headers);
        }
    
        /// <summary>
        /// Casino Events Returns a collection of events when casino number is provided
        /// </summary>
        /// <param name="number">Casino number in form of an integer</param> 
        /// <returns>List&lt;CasinoEventsResponse&gt;</returns>            
        public List<CasinoEventsResponse> Casino Events (double? number)
        {
            
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling Casino Events");
            
    
            var path = "/venue/v1/casinos/{number}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "number" + "}", ApiClient.ParameterToString(number));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Casino Events: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Casino Events: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CasinoEventsResponse>) ApiClient.Deserialize(response.Content, typeof(List<CasinoEventsResponse>), response.Headers);
        }
    
        /// <summary>
        /// Casino Poker Cash Games This resource returns the collection of poker cash games schedules for a specific casino, a cash game schedule is represented as below, &#x60;&#x60;&#x60;         {             \&quot;CasinoNumber\&quot;:5204,             \&quot;Day\&quot;:\&quot;Every Day\&quot;,             \&quot;Start\&quot;:\&quot;Select\&quot;,             \&quot;End\&quot;:\&quot;Select\&quot;,             \&quot;NumberOfGames\&quot;:5,             \&quot;StakeFrom\&quot;:\&quot;5\&quot;,             \&quot;StakeTo\&quot;:\&quot;250\&quot;,             \&quot;BlindsFrom\&quot;:\&quot;.25\&quot;,             \&quot;BlindsTo\&quot;:\&quot;10\&quot;,             \&quot;SessionOrRake\&quot;:\&quot;Rake\&quot;         } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="number">Casino number in form of an integer</param> 
        /// <returns>List&lt;CasinoPokerCashGamesResponse&gt;</returns>            
        public List<CasinoPokerCashGamesResponse> Casino Poker Cash Games (double? number)
        {
            
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling Casino Poker Cash Games");
            
    
            var path = "/venue/v1/casinos/{number}/poker-cash-games";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "number" + "}", ApiClient.ParameterToString(number));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Casino Poker Cash Games: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Casino Poker Cash Games: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CasinoPokerCashGamesResponse>) ApiClient.Deserialize(response.Content, typeof(List<CasinoPokerCashGamesResponse>), response.Headers);
        }
    
        /// <summary>
        /// Casino Poker Schedules This resource returns the collection of poker tournament schedules for a specific casino, a schedule is represented as below, &#x60;&#x60;&#x60;         {             \&quot;CasinoNumber\&quot;: 5005,             \&quot;Day\&quot;: \&quot;Every Tuesday \&quot;,             \&quot;StartDate\&quot;: \&quot;2015-06-08 00:00:00\&quot;,             \&quot;EndDate\&quot;: \&quot;2015-09-27 00:00:00\&quot;,             \&quot;Game\&quot;: \&quot;&amp;pound;5: &amp;pound;500 Gtd With &amp;pound;5 R/b And &amp;pound;10 A/o\&quot;,             \&quot;GameType\&quot;: \&quot;Re-Buy \&quot;,             \&quot;Stake\&quot;: 5,             \&quot;StartingStake\&quot;: \&quot;5,000\&quot;,             \&quot;RegFee\&quot;: 5,             \&quot;StartTime\&quot;: \&quot;20:00\&quot;         } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="number">Casino number in form of an integer</param> 
        /// <returns>List&lt;CasinoPokerSchedulesResponse&gt;</returns>            
        public List<CasinoPokerSchedulesResponse> Casino Poker Schedules (double? number)
        {
            
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling Casino Poker Schedules");
            
    
            var path = "/venue/v1/casinos/{number}/poker-schedules";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "number" + "}", ApiClient.ParameterToString(number));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Casino Poker Schedules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Casino Poker Schedules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CasinoPokerSchedulesResponse>) ApiClient.Deserialize(response.Content, typeof(List<CasinoPokerSchedulesResponse>), response.Headers);
        }
    
    }
}
