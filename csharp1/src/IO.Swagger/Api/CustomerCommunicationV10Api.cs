/* 
 * Res.Grosvenor - Rank
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICustomerCommunicationV10Api : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// SendEmail
        /// </summary>
        /// <remarks>
        /// | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void SendEmail (long? playerId, SendemailRequest body);

        /// <summary>
        /// SendEmail
        /// </summary>
        /// <remarks>
        /// | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendEmailWithHttpInfo (long? playerId, SendemailRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// SendEmail
        /// </summary>
        /// <remarks>
        /// | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SendEmailAsync (long? playerId, SendemailRequest body);

        /// <summary>
        /// SendEmail
        /// </summary>
        /// <remarks>
        /// | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SendEmailAsyncWithHttpInfo (long? playerId, SendemailRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CustomerCommunicationV10Api : ICustomerCommunicationV10Api
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCommunicationV10Api"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerCommunicationV10Api(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCommunicationV10Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomerCommunicationV10Api(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// SendEmail | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void SendEmail (long? playerId, SendemailRequest body)
        {
             SendEmailWithHttpInfo(playerId, body);
        }

        /// <summary>
        /// SendEmail | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendEmailWithHttpInfo (long? playerId, SendemailRequest body)
        {
            // verify the required parameter 'playerId' is set
            if (playerId == null)
                throw new ApiException(400, "Missing required parameter 'playerId' when calling CustomerCommunicationV10Api->SendEmail");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CustomerCommunicationV10Api->SendEmail");

            var localVarPath = "/communication/v1/digitalCustomer/{playerId}/email";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (playerId != null) localVarPathParams.Add("playerId", Configuration.ApiClient.ParameterToString(playerId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendEmail", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// SendEmail | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SendEmailAsync (long? playerId, SendemailRequest body)
        {
             await SendEmailAsyncWithHttpInfo(playerId, body);

        }

        /// <summary>
        /// SendEmail | Name          | Type      | Required  | Description                                       | Example           | |:- --           |:- --       |:- --       |:- --                                               |:- --               | |Type           |string     |yes        |Type of Email, possible values are: \&quot;WelcomeNonClub\&quot;, \&quot;WelcomeClub\&quot;, \&quot;ForgotUsername\&quot;, \&quot;ForgotPassword\&quot;|\&quot;ForgotUsername\&quot;          | |DynamicFields  |JSON       |no         |JSON Key-Value collection. used for providing dynamicfields that needs mapping in email templates. excludes any fields available on bede/spine profile,Eg: username and firstname will be extracted from SPINE using the PlayerID                         |\&quot;DynamicFields\&quot; : { \&quot;Password_URL\&quot; : \&quot;https://www.grosvenorcasinos.com/forgot?af34b28dea4\&quot; }      |
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SendEmailAsyncWithHttpInfo (long? playerId, SendemailRequest body)
        {
            // verify the required parameter 'playerId' is set
            if (playerId == null)
                throw new ApiException(400, "Missing required parameter 'playerId' when calling CustomerCommunicationV10Api->SendEmail");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CustomerCommunicationV10Api->SendEmail");

            var localVarPath = "/communication/v1/digitalCustomer/{playerId}/email";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (playerId != null) localVarPathParams.Add("playerId", Configuration.ApiClient.ParameterToString(playerId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendEmail", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
