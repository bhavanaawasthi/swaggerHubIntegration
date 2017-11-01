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
    public interface IRetailAuthenticationV10Api
    {
        /// <summary>
        /// Lookup Returns BEDE player id from the persistance storage for the cardNo provided. If no record found, the response would be 404 (not found)
        /// </summary>
        /// <param name="cardNo">card no issued to the retail customer</param>
        /// <returns>LookupResponse</returns>
        LookupResponse Lookup (double? cardNo);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RetailAuthenticationV10Api : IRetailAuthenticationV10Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetailAuthenticationV10Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RetailAuthenticationV10Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RetailAuthenticationV10Api"/> class.
        /// </summary>
        /// <returns></returns>
        public RetailAuthenticationV10Api(String basePath)
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
        /// Lookup Returns BEDE player id from the persistance storage for the cardNo provided. If no record found, the response would be 404 (not found)
        /// </summary>
        /// <param name="cardNo">card no issued to the retail customer</param> 
        /// <returns>LookupResponse</returns>            
        public LookupResponse Lookup (double? cardNo)
        {
            
            // verify the required parameter 'cardNo' is set
            if (cardNo == null) throw new ApiException(400, "Missing required parameter 'cardNo' when calling Lookup");
            
    
            var path = "/retailauthentication/v1/lookup";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cardNo != null) queryParams.Add("cardNo", ApiClient.ParameterToString(cardNo)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Lookup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Lookup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LookupResponse) ApiClient.Deserialize(response.Content, typeof(LookupResponse), response.Headers);
        }
    
    }
}
