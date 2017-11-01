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
    public interface ILoyaltyV10Api
    {
        /// <summary>
        /// Add digital Account Adding the newly created digital account to the retail loyalty account and returns the points balance, Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:---               |:---       |:---       |:---                                           |:---               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |MembershipNo       |string     |Yes        |Retail Casino membership number.               |123456789         |
        /// </summary>
        /// <param name="body"></param>
        /// <returns>AddDigitalAccountResponse</returns>
        AddDigitalAccountResponse Add digital Account (AddDigitalAccountRequest body);
        /// <summary>
        /// Create customers playpoints account | Name          | Type      | Required  | Description                                       | Example           | |:---           |:---       |:---       |:---                                               |:---               | |PlayerId       |long       |yes        |Customer identifier from the digital platform.     |570515106383925248 | |Forename       |string     |yes        |first name of the customer                         |\&quot;Bob\&quot;              | |Surname        |string     |yes        |Last name of the customer                          |\&quot;Marley\&quot;           | |DateOfBirth    |Date       |yes        |Date of birth of the customer.                     |1982-04-28         |
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Create customers playpoints account (CreateCustomersPlaypointsAccountRequest body);
        /// <summary>
        /// Merge Digital and Retail Accounts - flavour 2 This method is a varient of the above method which links the digital and retail loyalty accounts and merges the points earned. This can be used when retail membership number is not available to the client. Returns the combined points balance, Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:---               |:---       |:---       |:---                                           |:---               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |CardNo             |int        |Yes        |Player loyalty Card number                     |1460040108         | |DateofBirth        |Date       |yes        |Date of birth of the customer.                 |1982-04-28         |
        /// </summary>
        /// <param name="body"></param>
        /// <returns>MergeDigitalAndRetailAccountsFlavour1Response</returns>
        MergeDigitalAndRetailAccountsFlavour1Response Merge Digital and Retail Accounts  flavour 2 (MergeDigitalAndRetailAccountsFlavour2Request body);
        /// <summary>
        /// Redeem points Redeem the playpoints balance, Request body fields: | Name              | Type      | Required  | Description                                       | Example               | |:---               |:---       |:---       |:---                                               |:---                   | |PlayerId           |long       |yes        |Customer identifier from the digital platform.     |570515106383925248     | |Points             |int        |yes        |amount that needs adjusting                        |100                    | |RedeemDateTime     |DateTime   |yes        |Date and time of the redemption call.              |2015-04-28T10:10:25Z   | Response would be * OK (HTTP 200) - when redemption is successful * Bad Request (400) -       * the request parameters are not valid or      * the player hasn&#39;t got enough funds or      * the player has exceeded the daily redemption limit (Message: \&quot;Sorry, you can only redeem a maximum of 50000 PLAY Points in a day\&quot;) * Error (500) - when there is an error redeeming the points. Most likely cause would be ability to connect to other systems.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Redeem points (RedeemPointsRequest body);
        /// <summary>
        /// Retrieve Points balance Retrieves play points balance for the customer, any one of the below parameters is required. | Name          | Type  | Description                                       | Example           | |:---           |:---   |:---                                               |:---               | |playerId       |long   |Customer identifier from the digital platform.     |570515106383925248 | |cardNo         |number |Number on the back of the membership card.         |16227376           | |membershipNo   |string |Retail Casino membership number.                   |1850034070         |
        /// </summary>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="cardNo">Number on the back of the membership card. If specified, then Grade will be returned.</param>
        /// <param name="membershipNo">Retail Casino membership number.</param>
        /// <returns>RetrievePointsBalanceResponse</returns>
        RetrievePointsBalanceResponse Retrieve Points balance (long? playerId, double? cardNo, string membershipNo);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LoyaltyV10Api : ILoyaltyV10Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyV10Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LoyaltyV10Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyV10Api"/> class.
        /// </summary>
        /// <returns></returns>
        public LoyaltyV10Api(String basePath)
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
        /// Add digital Account Adding the newly created digital account to the retail loyalty account and returns the points balance, Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:---               |:---       |:---       |:---                                           |:---               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |MembershipNo       |string     |Yes        |Retail Casino membership number.               |123456789         |
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>AddDigitalAccountResponse</returns>            
        public AddDigitalAccountResponse Add digital Account (AddDigitalAccountRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Add digital Account");
            
    
            var path = "/loyalty/v1/accounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Add digital Account: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Add digital Account: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AddDigitalAccountResponse) ApiClient.Deserialize(response.Content, typeof(AddDigitalAccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Create customers playpoints account | Name          | Type      | Required  | Description                                       | Example           | |:---           |:---       |:---       |:---                                               |:---               | |PlayerId       |long       |yes        |Customer identifier from the digital platform.     |570515106383925248 | |Forename       |string     |yes        |first name of the customer                         |\&quot;Bob\&quot;              | |Surname        |string     |yes        |Last name of the customer                          |\&quot;Marley\&quot;           | |DateOfBirth    |Date       |yes        |Date of birth of the customer.                     |1982-04-28         |
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void Create customers playpoints account (CreateCustomersPlaypointsAccountRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Create customers playpoints account");
            
    
            var path = "/loyalty/v1/customers/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create customers playpoints account: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create customers playpoints account: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Merge Digital and Retail Accounts - flavour 2 This method is a varient of the above method which links the digital and retail loyalty accounts and merges the points earned. This can be used when retail membership number is not available to the client. Returns the combined points balance, Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:---               |:---       |:---       |:---                                           |:---               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |CardNo             |int        |Yes        |Player loyalty Card number                     |1460040108         | |DateofBirth        |Date       |yes        |Date of birth of the customer.                 |1982-04-28         |
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>MergeDigitalAndRetailAccountsFlavour1Response</returns>            
        public MergeDigitalAndRetailAccountsFlavour1Response Merge Digital and Retail Accounts  flavour 2 (MergeDigitalAndRetailAccountsFlavour2Request body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Merge Digital and Retail Accounts  flavour 2");
            
    
            var path = "/loyalty/v1/accounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Merge Digital and Retail Accounts  flavour 2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Merge Digital and Retail Accounts  flavour 2: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MergeDigitalAndRetailAccountsFlavour1Response) ApiClient.Deserialize(response.Content, typeof(MergeDigitalAndRetailAccountsFlavour1Response), response.Headers);
        }
    
        /// <summary>
        /// Redeem points Redeem the playpoints balance, Request body fields: | Name              | Type      | Required  | Description                                       | Example               | |:---               |:---       |:---       |:---                                               |:---                   | |PlayerId           |long       |yes        |Customer identifier from the digital platform.     |570515106383925248     | |Points             |int        |yes        |amount that needs adjusting                        |100                    | |RedeemDateTime     |DateTime   |yes        |Date and time of the redemption call.              |2015-04-28T10:10:25Z   | Response would be * OK (HTTP 200) - when redemption is successful * Bad Request (400) -       * the request parameters are not valid or      * the player hasn&#39;t got enough funds or      * the player has exceeded the daily redemption limit (Message: \&quot;Sorry, you can only redeem a maximum of 50000 PLAY Points in a day\&quot;) * Error (500) - when there is an error redeeming the points. Most likely cause would be ability to connect to other systems.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void Redeem points (RedeemPointsRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Redeem points");
            
    
            var path = "/loyalty/v1/points";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Redeem points: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Redeem points: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieve Points balance Retrieves play points balance for the customer, any one of the below parameters is required. | Name          | Type  | Description                                       | Example           | |:---           |:---   |:---                                               |:---               | |playerId       |long   |Customer identifier from the digital platform.     |570515106383925248 | |cardNo         |number |Number on the back of the membership card.         |16227376           | |membershipNo   |string |Retail Casino membership number.                   |1850034070         |
        /// </summary>
        /// <param name="playerId">Customer identifier from the digital platform</param> 
        /// <param name="cardNo">Number on the back of the membership card. If specified, then Grade will be returned.</param> 
        /// <param name="membershipNo">Retail Casino membership number.</param> 
        /// <returns>RetrievePointsBalanceResponse</returns>            
        public RetrievePointsBalanceResponse Retrieve Points balance (long? playerId, double? cardNo, string membershipNo)
        {
            
    
            var path = "/loyalty/v1/points/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (playerId != null) queryParams.Add("playerId", ApiClient.ParameterToString(playerId)); // query parameter
 if (cardNo != null) queryParams.Add("cardNo", ApiClient.ParameterToString(cardNo)); // query parameter
 if (membershipNo != null) queryParams.Add("membershipNo", ApiClient.ParameterToString(membershipNo)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve Points balance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve Points balance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RetrievePointsBalanceResponse) ApiClient.Deserialize(response.Content, typeof(RetrievePointsBalanceResponse), response.Headers);
        }
    
    }
}
