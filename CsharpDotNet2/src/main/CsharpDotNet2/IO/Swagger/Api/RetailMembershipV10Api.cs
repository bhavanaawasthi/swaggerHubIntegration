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
    public interface IRetailMembershipV10Api
    {
        /// <summary>
        /// Get lookup values All lookup valus are provided through this single endpoint. The consuming application can request which lookup value list to be included in the response. if any of the parameter ommitted from the questring parameter or supplied value &#x60;false&#x60;, the response will not include the key and value (list) for category.
        /// </summary>
        /// <param name="includeNationalities">include nationality look up values in the response</param>
        /// <param name="includeCountries">include country look up values in the response</param>
        /// <param name="incldueCasinos">include casino look up values in the response</param>
        /// <param name="includeTitles">include title look up values in the response</param>
        /// <returns>GetLookupValuesResponse</returns>
        GetLookupValuesResponse Get lookup values (bool? includeNationalities, bool? includeCountries, bool? incldueCasinos, bool? includeTitles);
        /// <summary>
        /// Lookup Model for the resource if defined below: &#x60;&#x60;&#x60;             {                 \&quot;Name\&quot; : {                     \&quot;Title\&quot; : \&quot;Mr\&quot;,                     \&quot;Forename\&quot; : \&quot;John\&quot;,                     \&quot;Surname\&quot; : \&quot;Jackson\&quot;,                     \&quot;OtherName\&quot; : \&quot;William\&quot;                 },                 \&quot;Address\&quot; : {                     \&quot;Address1\&quot; : \&quot;10\&quot;,                     \&quot;Address2\&quot; : \&quot;Downing Street\&quot;,                     \&quot;Town\&quot; : \&quot;London\&quot;,                     \&quot;Postcode\&quot; : \&quot;WC2B 4AA\&quot;,                     \&quot;County\&quot; : \&quot;Greater London\&quot;,                     \&quot;Country\&quot;  : \&quot;UK\&quot;                 },                 \&quot;Nationality\&quot; : \&quot;British\&quot;,                 \&quot;TelephoneNumber\&quot; : \&quot;01234567890\&quot;,                 \&quot;MobileNumber\&quot; : \&quot;01234567890\&quot;,                 \&quot;DateOfBirth\&quot; : \&quot;1955-01-30\&quot;,                 \&quot;EmailAddress\&quot; : \&quot;jack@rank.com\&quot;,                 \&quot;Club\&quot; : {                     \&quot;ClubNumber\&quot; : \&quot;45611\&quot;,                     \&quot;ClubName\&quot; : \&quot;Grosvenor casino\&quot;                 },                 \&quot;Contactable\&quot; : true,                 \&quot;ContactChannel\&quot; : \&quot;PEST\&quot;,                 \&quot;AgeVerified\&quot; : true,                 \&quot;AffId\&quot; : \&quot;2728\&quot;,                 \&quot;MembershipNo\&quot; : \&quot;12345\&quot;,                 \&quot;CardNo\&quot; : 67890             } &#x60;&#x60;&#x60; | Name          | Type      | Required                                          | Description                                                                       | Example   | |:---           |:---       |:---                                               |:---                                                                               |:---       | |AffId          |string     |**yes** for Lookup Response, **no** for others     |When it&#39;s presented in a model the value should be 2728.                           |2728       | |Contactable    |bool       |**yes** for Register Request, **no** for others    |Shows whether customer is happy to receive the latest offers and information.      |True       | |ContactChannel |string     |**yes** for Register Request, **no** for others    |Shows prefered way of communication. P - Post, E - Email, S - SMS, T - Telephone.  |\&quot;PEST\&quot;     | For registration following input validation in place **Following fields must exists/must be non-null** - Name.Forename - Name.Surname - Address.Postcode - Club.ClubNumber **Following fields must follow a valid format** - Email address - valid email format - MobileNumber &amp; TelephoneNumber - starts with 0 or +44, followed by 9/10 digits, it allows optional spacing between digits to conform the popular/acceptable format (i.e. 078 8602 8945, +44 78 8602 9845, etc) - Address.Postcode - valid UK postcode - DateOfBirth - must be of legal age (18) - Club.ClubNumber - Club number must be a valid Grsovenor casino. Use Venue details service to validate the detail before testing.
        /// </summary>
        /// <param name="membershipNo">Card number (Number found on the back of the card) of the Customer in form of an integer</param>
        /// <param name="dateOfBirth">Date of birth of the Customer</param>
        /// <param name="checkAlreadyUsed">Enables Customer Spine registration check. The flag modifies response entity according to the following rules: - customer registered on Spine, adds _IsAlreadyUsedOnDigital_ property with value _true_ - customer not registered - adds _IsAlreadyUsedOnDigital_ property with value _false_ - Spine check failed - no changes to response</param>
        /// <returns>LookupResponse2</returns>
        LookupResponse2 Lookup1 (double? membershipNo, DateTime? dateOfBirth, bool? checkAlreadyUsed);
        /// <summary>
        /// Register - This operation is disabled Model for the resource if defined below: &#x60;&#x60;&#x60;             {                 \&quot;Name\&quot; : {                     \&quot;Title\&quot; : \&quot;Mr\&quot;,                     \&quot;Forename\&quot; : \&quot;John\&quot;,                     \&quot;Surname\&quot; : \&quot;Jackson\&quot;,                     \&quot;OtherName\&quot; : \&quot;William\&quot;                 },                 \&quot;Address\&quot; : {                     \&quot;Address1\&quot; : \&quot;10\&quot;,                     \&quot;Address2\&quot; : \&quot;Downing Street\&quot;,                     \&quot;Town\&quot; : \&quot;London\&quot;,                     \&quot;Postcode\&quot; : \&quot;WC2B 4AA\&quot;,                     \&quot;County\&quot; : \&quot;Greater London\&quot;,                     \&quot;Country\&quot;  : \&quot;UK\&quot;                 },                 \&quot;Nationality\&quot; : \&quot;British\&quot;,                 \&quot;TelephoneNumber\&quot; : \&quot;01234567890\&quot;,                 \&quot;MobileNumber\&quot; : \&quot;01234567890\&quot;,                 \&quot;DateOfBirth\&quot; : \&quot;1955-01-30\&quot;,                 \&quot;EmailAddress\&quot; : \&quot;jack@rank.com\&quot;,                 \&quot;Club\&quot; : {                     \&quot;ClubNumber\&quot; : \&quot;45611\&quot;,                     \&quot;ClubName\&quot; : \&quot;Grosvenor casino\&quot;                 },                 \&quot;Contactable\&quot; : true,                 \&quot;ContactChannel\&quot; : \&quot;PEST\&quot;,                 \&quot;AgeVerified\&quot; : true,                 \&quot;AffId\&quot; : \&quot;2728\&quot;,                 \&quot;MembershipNo\&quot; : \&quot;12345\&quot;,                 \&quot;CardNo\&quot; : 67890             } &#x60;&#x60;&#x60; | Name          | Type      | Required                                          | Description                                                                       | Example   | |:---           |:---       |:---                                               |:---                                                                               |:---       | |AffId          |string     |**yes** for Lookup Response, **no** for others     |When it&#39;s presented in a model the value should be 2728.                           |2728       | |Contactable    |bool       |**yes** for Register Request, **no** for others    |Shows whether customer is happy to receive the latest offers and information.      |True       | |ContactChannel |string     |**yes** for Register Request, **no** for others    |Shows prefered way of communication. P - Post, E - Email, S - SMS, T - Telephone.  |\&quot;PEST\&quot;     | For registration following input validation in place **Following fields must exists/must be non-null** - Name.Forename - Name.Surname - Address.Postcode - Club.ClubNumber **Following fields must follow a valid format** - Email address - valid email format - MobileNumber &amp; TelephoneNumber - starts with 0 or +44, followed by 9/10 digits, it allows optional spacing between digits to conform the popular/acceptable format (i.e. 078 8602 8945, +44 78 8602 9845, etc) - Address.Postcode - valid UK postcode - DateOfBirth - must be of legal age (18) - Club.ClubNumber - Club number must be a valid Grsovenor casino. Use Venue details service to validate the detail before testing.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Register  This operation is disabled (RegisterThisOperationIsDisabledRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RetailMembershipV10Api : IRetailMembershipV10Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetailMembershipV10Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RetailMembershipV10Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RetailMembershipV10Api"/> class.
        /// </summary>
        /// <returns></returns>
        public RetailMembershipV10Api(String basePath)
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
        /// Get lookup values All lookup valus are provided through this single endpoint. The consuming application can request which lookup value list to be included in the response. if any of the parameter ommitted from the questring parameter or supplied value &#x60;false&#x60;, the response will not include the key and value (list) for category.
        /// </summary>
        /// <param name="includeNationalities">include nationality look up values in the response</param> 
        /// <param name="includeCountries">include country look up values in the response</param> 
        /// <param name="incldueCasinos">include casino look up values in the response</param> 
        /// <param name="includeTitles">include title look up values in the response</param> 
        /// <returns>GetLookupValuesResponse</returns>            
        public GetLookupValuesResponse Get lookup values (bool? includeNationalities, bool? includeCountries, bool? incldueCasinos, bool? includeTitles)
        {
            
    
            var path = "/retailmembership/v1/lookups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeNationalities != null) queryParams.Add("includeNationalities", ApiClient.ParameterToString(includeNationalities)); // query parameter
 if (includeCountries != null) queryParams.Add("includeCountries", ApiClient.ParameterToString(includeCountries)); // query parameter
 if (incldueCasinos != null) queryParams.Add("incldueCasinos", ApiClient.ParameterToString(incldueCasinos)); // query parameter
 if (includeTitles != null) queryParams.Add("includeTitles", ApiClient.ParameterToString(includeTitles)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get lookup values: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Get lookup values: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetLookupValuesResponse) ApiClient.Deserialize(response.Content, typeof(GetLookupValuesResponse), response.Headers);
        }
    
        /// <summary>
        /// Lookup Model for the resource if defined below: &#x60;&#x60;&#x60;             {                 \&quot;Name\&quot; : {                     \&quot;Title\&quot; : \&quot;Mr\&quot;,                     \&quot;Forename\&quot; : \&quot;John\&quot;,                     \&quot;Surname\&quot; : \&quot;Jackson\&quot;,                     \&quot;OtherName\&quot; : \&quot;William\&quot;                 },                 \&quot;Address\&quot; : {                     \&quot;Address1\&quot; : \&quot;10\&quot;,                     \&quot;Address2\&quot; : \&quot;Downing Street\&quot;,                     \&quot;Town\&quot; : \&quot;London\&quot;,                     \&quot;Postcode\&quot; : \&quot;WC2B 4AA\&quot;,                     \&quot;County\&quot; : \&quot;Greater London\&quot;,                     \&quot;Country\&quot;  : \&quot;UK\&quot;                 },                 \&quot;Nationality\&quot; : \&quot;British\&quot;,                 \&quot;TelephoneNumber\&quot; : \&quot;01234567890\&quot;,                 \&quot;MobileNumber\&quot; : \&quot;01234567890\&quot;,                 \&quot;DateOfBirth\&quot; : \&quot;1955-01-30\&quot;,                 \&quot;EmailAddress\&quot; : \&quot;jack@rank.com\&quot;,                 \&quot;Club\&quot; : {                     \&quot;ClubNumber\&quot; : \&quot;45611\&quot;,                     \&quot;ClubName\&quot; : \&quot;Grosvenor casino\&quot;                 },                 \&quot;Contactable\&quot; : true,                 \&quot;ContactChannel\&quot; : \&quot;PEST\&quot;,                 \&quot;AgeVerified\&quot; : true,                 \&quot;AffId\&quot; : \&quot;2728\&quot;,                 \&quot;MembershipNo\&quot; : \&quot;12345\&quot;,                 \&quot;CardNo\&quot; : 67890             } &#x60;&#x60;&#x60; | Name          | Type      | Required                                          | Description                                                                       | Example   | |:---           |:---       |:---                                               |:---                                                                               |:---       | |AffId          |string     |**yes** for Lookup Response, **no** for others     |When it&#39;s presented in a model the value should be 2728.                           |2728       | |Contactable    |bool       |**yes** for Register Request, **no** for others    |Shows whether customer is happy to receive the latest offers and information.      |True       | |ContactChannel |string     |**yes** for Register Request, **no** for others    |Shows prefered way of communication. P - Post, E - Email, S - SMS, T - Telephone.  |\&quot;PEST\&quot;     | For registration following input validation in place **Following fields must exists/must be non-null** - Name.Forename - Name.Surname - Address.Postcode - Club.ClubNumber **Following fields must follow a valid format** - Email address - valid email format - MobileNumber &amp; TelephoneNumber - starts with 0 or +44, followed by 9/10 digits, it allows optional spacing between digits to conform the popular/acceptable format (i.e. 078 8602 8945, +44 78 8602 9845, etc) - Address.Postcode - valid UK postcode - DateOfBirth - must be of legal age (18) - Club.ClubNumber - Club number must be a valid Grsovenor casino. Use Venue details service to validate the detail before testing.
        /// </summary>
        /// <param name="membershipNo">Card number (Number found on the back of the card) of the Customer in form of an integer</param> 
        /// <param name="dateOfBirth">Date of birth of the Customer</param> 
        /// <param name="checkAlreadyUsed">Enables Customer Spine registration check. The flag modifies response entity according to the following rules: - customer registered on Spine, adds _IsAlreadyUsedOnDigital_ property with value _true_ - customer not registered - adds _IsAlreadyUsedOnDigital_ property with value _false_ - Spine check failed - no changes to response</param> 
        /// <returns>LookupResponse2</returns>            
        public LookupResponse2 Lookup1 (double? membershipNo, DateTime? dateOfBirth, bool? checkAlreadyUsed)
        {
            
            // verify the required parameter 'membershipNo' is set
            if (membershipNo == null) throw new ApiException(400, "Missing required parameter 'membershipNo' when calling Lookup1");
            
            // verify the required parameter 'dateOfBirth' is set
            if (dateOfBirth == null) throw new ApiException(400, "Missing required parameter 'dateOfBirth' when calling Lookup1");
            
    
            var path = "/retailmembership/v1/customers/{membershipNo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "membershipNo" + "}", ApiClient.ParameterToString(membershipNo));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (dateOfBirth != null) queryParams.Add("dateOfBirth", ApiClient.ParameterToString(dateOfBirth)); // query parameter
 if (checkAlreadyUsed != null) queryParams.Add("checkAlreadyUsed", ApiClient.ParameterToString(checkAlreadyUsed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Lookup1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Lookup1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LookupResponse2) ApiClient.Deserialize(response.Content, typeof(LookupResponse2), response.Headers);
        }
    
        /// <summary>
        /// Register - This operation is disabled Model for the resource if defined below: &#x60;&#x60;&#x60;             {                 \&quot;Name\&quot; : {                     \&quot;Title\&quot; : \&quot;Mr\&quot;,                     \&quot;Forename\&quot; : \&quot;John\&quot;,                     \&quot;Surname\&quot; : \&quot;Jackson\&quot;,                     \&quot;OtherName\&quot; : \&quot;William\&quot;                 },                 \&quot;Address\&quot; : {                     \&quot;Address1\&quot; : \&quot;10\&quot;,                     \&quot;Address2\&quot; : \&quot;Downing Street\&quot;,                     \&quot;Town\&quot; : \&quot;London\&quot;,                     \&quot;Postcode\&quot; : \&quot;WC2B 4AA\&quot;,                     \&quot;County\&quot; : \&quot;Greater London\&quot;,                     \&quot;Country\&quot;  : \&quot;UK\&quot;                 },                 \&quot;Nationality\&quot; : \&quot;British\&quot;,                 \&quot;TelephoneNumber\&quot; : \&quot;01234567890\&quot;,                 \&quot;MobileNumber\&quot; : \&quot;01234567890\&quot;,                 \&quot;DateOfBirth\&quot; : \&quot;1955-01-30\&quot;,                 \&quot;EmailAddress\&quot; : \&quot;jack@rank.com\&quot;,                 \&quot;Club\&quot; : {                     \&quot;ClubNumber\&quot; : \&quot;45611\&quot;,                     \&quot;ClubName\&quot; : \&quot;Grosvenor casino\&quot;                 },                 \&quot;Contactable\&quot; : true,                 \&quot;ContactChannel\&quot; : \&quot;PEST\&quot;,                 \&quot;AgeVerified\&quot; : true,                 \&quot;AffId\&quot; : \&quot;2728\&quot;,                 \&quot;MembershipNo\&quot; : \&quot;12345\&quot;,                 \&quot;CardNo\&quot; : 67890             } &#x60;&#x60;&#x60; | Name          | Type      | Required                                          | Description                                                                       | Example   | |:---           |:---       |:---                                               |:---                                                                               |:---       | |AffId          |string     |**yes** for Lookup Response, **no** for others     |When it&#39;s presented in a model the value should be 2728.                           |2728       | |Contactable    |bool       |**yes** for Register Request, **no** for others    |Shows whether customer is happy to receive the latest offers and information.      |True       | |ContactChannel |string     |**yes** for Register Request, **no** for others    |Shows prefered way of communication. P - Post, E - Email, S - SMS, T - Telephone.  |\&quot;PEST\&quot;     | For registration following input validation in place **Following fields must exists/must be non-null** - Name.Forename - Name.Surname - Address.Postcode - Club.ClubNumber **Following fields must follow a valid format** - Email address - valid email format - MobileNumber &amp; TelephoneNumber - starts with 0 or +44, followed by 9/10 digits, it allows optional spacing between digits to conform the popular/acceptable format (i.e. 078 8602 8945, +44 78 8602 9845, etc) - Address.Postcode - valid UK postcode - DateOfBirth - must be of legal age (18) - Club.ClubNumber - Club number must be a valid Grsovenor casino. Use Venue details service to validate the detail before testing.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void Register  This operation is disabled (RegisterThisOperationIsDisabledRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Register  This operation is disabled");
            
    
            var path = "/retailmembership/v1/customers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Register  This operation is disabled: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Register  This operation is disabled: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
