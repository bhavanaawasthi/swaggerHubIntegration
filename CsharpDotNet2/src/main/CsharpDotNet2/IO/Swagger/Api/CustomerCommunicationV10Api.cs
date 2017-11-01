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
    public interface ICustomerCommunicationV10Api
    {
        /// <summary>
        /// SendEmail | Name          | Type      | Required  | Description                                       | Example           | |:---           |:---       |:---       |:---                                               |:---               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </summary>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void SendEmail (long? playerId, SendemailRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomerCommunicationV10Api : ICustomerCommunicationV10Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCommunicationV10Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomerCommunicationV10Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCommunicationV10Api"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerCommunicationV10Api(String basePath)
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
        /// SendEmail | Name          | Type      | Required  | Description                                       | Example           | |:---           |:---       |:---       |:---                                               |:---               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </summary>
        /// <param name="playerId">Customer identifier from the digital platform</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void SendEmail (long? playerId, SendemailRequest body)
        {
            
            // verify the required parameter 'playerId' is set
            if (playerId == null) throw new ApiException(400, "Missing required parameter 'playerId' when calling SendEmail");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SendEmail");
            
    
            var path = "/communication/v1/digitalCustomer/{playerId}/email";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "playerId" + "}", ApiClient.ParameterToString(playerId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SendEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
