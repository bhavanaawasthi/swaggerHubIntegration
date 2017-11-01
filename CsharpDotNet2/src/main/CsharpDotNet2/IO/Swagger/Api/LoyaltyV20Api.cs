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
    public interface ILoyaltyV20Api
    {
        /// <summary>
        /// Accrue loyalty points Issue loyalty points to the specified account. | Name              | Type      | Required                             | Description                                   | Example           | |:---               |:---       |:---                                  |:---                                           |:---               | |CardNo             |int        |yes                                   |Number on the back of the membership card      |570515106          | |LocationId         |string     |yes                                   |Casion locationId                              |005Bar,FOOD        | |Points             |int        |yes                                   |points that needs adjusting                    |100                    | |TransactionDateTime |DateTime   |yes                                  |Transaction Date and time .                    |2015-04-28T10:10:25Z   |
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Accrue loyalty points (AccrueLoyaltyPointsRequest body);
        /// <summary>
        /// Create Loyalty Account for Digital Membership Account Managing actions for digital and retail loyalty accounts. Registers a digital customer in the loyalty system. | Name          | Type      | Required  | Description                                       | Example           | |:---           |:---       |:---       |:---                                               |:---               | |PlayerId       |long       |yes        |Customer identifier from the digital platform.     |570515106383925248 | |Forename       |string     |yes        |first name of the customer                         |\&quot;Bob\&quot;              | |Surname        |string     |yes        |Last name of the customer                          |\&quot;Marley\&quot;           | |DateOfBirth    |Date       |yes        |Date of birth of the customer.                     |1982-04-28         |
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Create Loyalty Account for Digital Membership Account (CreateLoyaltyAccountForDigitalMembershipAccountRequest body);
        /// <summary>
        /// Create Loyalty Account for Retail Membership Account Registers a retail customer in the loyalty system.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Create Loyalty Account for Retail Membership Account (CreateLoyaltyAccountForRetailMembershipAccountRequest body);
        /// <summary>
        /// Link existing Retail Loyalty Account to new Digital Membership Account Adding newly created digital account to the existing retail loyalty account and returns the points balance. Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:---               |:---       |:---       |:---                                           |:---               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |MembershipNo       |string     |Yes        |Retail Casino membership number.               |123456789         |
        /// </summary>
        /// <param name="body"></param>
        /// <returns>LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse</returns>
        LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse Link existing Retail Loyalty Account to new Digital Membership Account (LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest body);
        /// <summary>
        /// Merge existing Digital and Retail Loyalty Accounts - flavour 2 This method is a varient of the above method, which links the existing digital and retail loyalty accounts and merges the points earned. Returns the combined points balance. This can be used when retail membership number is not available to the client. Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:---               |:---       |:---       |:---                                           |:---               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |CardNo             |long       |Yes        |Player loyalty Card number                     |1460040108         | |DateofBirth        |Date       |yes        |Date of birth of the customer.                 |1982-04-28         |
        /// </summary>
        /// <param name="body"></param>
        /// <returns>MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response</returns>
        MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response Merge existing Digital and Retail Loyalty Accounts  flavour 2 (MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2Request body);
        /// <summary>
        /// Redeem loyalty points Redeem loyalty points from the specified account. | Name              | Type      | Required                                  | Description                                   | Example           | |:---               |:---       |:---                                       |:---                                           |:---               | |CardNo             |int        |optional (Required only for Retail)        |Number on the back of the membership card      |570515106          | |LocationId         |string     |optional (Required only for Retail)        |Casion locationId                              |005Bar,FOOD        | |PlayerId           |long       |optional (Required only for digital)       |Customer identifier from the digital platform. |570515106383925248     | |Points             |int        |Required                                   |points that needs adjusting                    |100                    | |RedeemDateTime     |DateTime   |yes                                        |Date and time of the redemption call.          |2015-04-28T10:10:25Z   |
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Redeem loyalty points (RedeemLoyaltyPointsRequest body);
        /// <summary>
        /// Retrieve Points balance Retrieves loyalty points balance for the customer, any one of the below parameters is required. | Name          | Type  | Description                                       | Example           | |:---           |:---   |:---                                               |:---               | |playerId       |long   |Customer identifier from the digital platform.     |570515106383925248 | |cardNo         |int    |Number on the back of the membership card.(retail) |16227376           | |membershipNo   |string |Retail Casino membership number.                   |1850034070         |
        /// </summary>
        /// <param name="playerId">Customer identifier from the digital platform</param>
        /// <param name="cardNo">Number on the back of the membership card. If specified, then Grade will be returned.</param>
        /// <param name="membershipNo">Retail Casino membership number.</param>
        /// <returns>RetrievePointsBalanceResponse17</returns>
        RetrievePointsBalanceResponse17 Retrieve Points balance1 (long? playerId, int? cardNo, string membershipNo);
        /// <summary>
        /// Retrieve all Accounts Summary by Grade Retrieves a summary information about each customer, who belongs to the specified grade. The below parameter is required.
        /// </summary>
        /// <param name="grade">A grouping of customers by certain properties. Possible values: MEMBER, GOLD, BLACK.</param>
        /// <returns>RetrieveAllAccountsSummaryByGradeResponse</returns>
        RetrieveAllAccountsSummaryByGradeResponse Retrieve all Accounts Summary by Grade (string grade);
        /// <summary>
        /// Retrieves  customer details by the specified card number. Retrieves customer profile information by cardNo. | Name          | Type  | Required                                              | Description                                       | Example           | |:---           |:---   |:---                                                   |:---                                               |:---               | CardNo          |int    | Yes                                                   |Number on the back of the membership card.(retail) |16227376           |
        /// </summary>
        /// <param name="cardNo">Number on the back of the membership card for retail</param>
        /// <returns>RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse</returns>
        RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse Retrieves  customer details by the specified card number (int? cardNo);
        /// <summary>
        /// Update Loyalty Account for Retail Membership Account Updates the existing retail loyalty account with specified values.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Update Loyalty Account for Retail Membership Account (UpdateLoyaltyAccountForRetailMembershipAccountRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LoyaltyV20Api : ILoyaltyV20Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyV20Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LoyaltyV20Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyV20Api"/> class.
        /// </summary>
        /// <returns></returns>
        public LoyaltyV20Api(String basePath)
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
        /// Accrue loyalty points Issue loyalty points to the specified account. | Name              | Type      | Required                             | Description                                   | Example           | |:---               |:---       |:---                                  |:---                                           |:---               | |CardNo             |int        |yes                                   |Number on the back of the membership card      |570515106          | |LocationId         |string     |yes                                   |Casion locationId                              |005Bar,FOOD        | |Points             |int        |yes                                   |points that needs adjusting                    |100                    | |TransactionDateTime |DateTime   |yes                                  |Transaction Date and time .                    |2015-04-28T10:10:25Z   |
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void Accrue loyalty points (AccrueLoyaltyPointsRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Accrue loyalty points");
            
    
            var path = "/loyalty/v2/points/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Accrue loyalty points: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Accrue loyalty points: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create Loyalty Account for Digital Membership Account Managing actions for digital and retail loyalty accounts. Registers a digital customer in the loyalty system. | Name          | Type      | Required  | Description                                       | Example           | |:---           |:---       |:---       |:---                                               |:---               | |PlayerId       |long       |yes        |Customer identifier from the digital platform.     |570515106383925248 | |Forename       |string     |yes        |first name of the customer                         |\&quot;Bob\&quot;              | |Surname        |string     |yes        |Last name of the customer                          |\&quot;Marley\&quot;           | |DateOfBirth    |Date       |yes        |Date of birth of the customer.                     |1982-04-28         |
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void Create Loyalty Account for Digital Membership Account (CreateLoyaltyAccountForDigitalMembershipAccountRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Create Loyalty Account for Digital Membership Account");
            
    
            var path = "/loyalty/v2/accounts/digital";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Create Loyalty Account for Digital Membership Account: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create Loyalty Account for Digital Membership Account: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create Loyalty Account for Retail Membership Account Registers a retail customer in the loyalty system.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void Create Loyalty Account for Retail Membership Account (CreateLoyaltyAccountForRetailMembershipAccountRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Create Loyalty Account for Retail Membership Account");
            
    
            var path = "/loyalty/v2/accounts/retail";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Create Loyalty Account for Retail Membership Account: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create Loyalty Account for Retail Membership Account: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Link existing Retail Loyalty Account to new Digital Membership Account Adding newly created digital account to the existing retail loyalty account and returns the points balance. Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:---               |:---       |:---       |:---                                           |:---               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |MembershipNo       |string     |Yes        |Retail Casino membership number.               |123456789         |
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse</returns>            
        public LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse Link existing Retail Loyalty Account to new Digital Membership Account (LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Link existing Retail Loyalty Account to new Digital Membership Account");
            
    
            var path = "/loyalty/v2/accounts/retail";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Link existing Retail Loyalty Account to new Digital Membership Account: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Link existing Retail Loyalty Account to new Digital Membership Account: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse) ApiClient.Deserialize(response.Content, typeof(LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Merge existing Digital and Retail Loyalty Accounts - flavour 2 This method is a varient of the above method, which links the existing digital and retail loyalty accounts and merges the points earned. Returns the combined points balance. This can be used when retail membership number is not available to the client. Request body fields: | Name              | Type      | Required  | Description                                   | Example           | |:---               |:---       |:---       |:---                                           |:---               | |PlayerId           |long       |Yes        |Customer identifier from the digital platform. |570515106383925248 | |CardNo             |long       |Yes        |Player loyalty Card number                     |1460040108         | |DateofBirth        |Date       |yes        |Date of birth of the customer.                 |1982-04-28         |
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response</returns>            
        public MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response Merge existing Digital and Retail Loyalty Accounts  flavour 2 (MergeExistingDigitalAndRetailLoyaltyAccountsFlavour2Request body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Merge existing Digital and Retail Loyalty Accounts  flavour 2");
            
    
            var path = "/loyalty/v2/accounts/merge";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Merge existing Digital and Retail Loyalty Accounts  flavour 2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Merge existing Digital and Retail Loyalty Accounts  flavour 2: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response) ApiClient.Deserialize(response.Content, typeof(MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Response), response.Headers);
        }
    
        /// <summary>
        /// Redeem loyalty points Redeem loyalty points from the specified account. | Name              | Type      | Required                                  | Description                                   | Example           | |:---               |:---       |:---                                       |:---                                           |:---               | |CardNo             |int        |optional (Required only for Retail)        |Number on the back of the membership card      |570515106          | |LocationId         |string     |optional (Required only for Retail)        |Casion locationId                              |005Bar,FOOD        | |PlayerId           |long       |optional (Required only for digital)       |Customer identifier from the digital platform. |570515106383925248     | |Points             |int        |Required                                   |points that needs adjusting                    |100                    | |RedeemDateTime     |DateTime   |yes                                        |Date and time of the redemption call.          |2015-04-28T10:10:25Z   |
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void Redeem loyalty points (RedeemLoyaltyPointsRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Redeem loyalty points");
            
    
            var path = "/loyalty/v2/points/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Redeem loyalty points: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Redeem loyalty points: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieve Points balance Retrieves loyalty points balance for the customer, any one of the below parameters is required. | Name          | Type  | Description                                       | Example           | |:---           |:---   |:---                                               |:---               | |playerId       |long   |Customer identifier from the digital platform.     |570515106383925248 | |cardNo         |int    |Number on the back of the membership card.(retail) |16227376           | |membershipNo   |string |Retail Casino membership number.                   |1850034070         |
        /// </summary>
        /// <param name="playerId">Customer identifier from the digital platform</param> 
        /// <param name="cardNo">Number on the back of the membership card. If specified, then Grade will be returned.</param> 
        /// <param name="membershipNo">Retail Casino membership number.</param> 
        /// <returns>RetrievePointsBalanceResponse17</returns>            
        public RetrievePointsBalanceResponse17 Retrieve Points balance1 (long? playerId, int? cardNo, string membershipNo)
        {
            
    
            var path = "/loyalty/v2/points/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve Points balance1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve Points balance1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RetrievePointsBalanceResponse17) ApiClient.Deserialize(response.Content, typeof(RetrievePointsBalanceResponse17), response.Headers);
        }
    
        /// <summary>
        /// Retrieve all Accounts Summary by Grade Retrieves a summary information about each customer, who belongs to the specified grade. The below parameter is required.
        /// </summary>
        /// <param name="grade">A grouping of customers by certain properties. Possible values: MEMBER, GOLD, BLACK.</param> 
        /// <returns>RetrieveAllAccountsSummaryByGradeResponse</returns>            
        public RetrieveAllAccountsSummaryByGradeResponse Retrieve all Accounts Summary by Grade (string grade)
        {
            
            // verify the required parameter 'grade' is set
            if (grade == null) throw new ApiException(400, "Missing required parameter 'grade' when calling Retrieve all Accounts Summary by Grade");
            
    
            var path = "/loyalty/v2/accounts/summary";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (grade != null) queryParams.Add("grade", ApiClient.ParameterToString(grade)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve all Accounts Summary by Grade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve all Accounts Summary by Grade: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RetrieveAllAccountsSummaryByGradeResponse) ApiClient.Deserialize(response.Content, typeof(RetrieveAllAccountsSummaryByGradeResponse), response.Headers);
        }
    
        /// <summary>
        /// Retrieves  customer details by the specified card number. Retrieves customer profile information by cardNo. | Name          | Type  | Required                                              | Description                                       | Example           | |:---           |:---   |:---                                                   |:---                                               |:---               | CardNo          |int    | Yes                                                   |Number on the back of the membership card.(retail) |16227376           |
        /// </summary>
        /// <param name="cardNo">Number on the back of the membership card for retail</param> 
        /// <returns>RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse</returns>            
        public RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse Retrieves  customer details by the specified card number (int? cardNo)
        {
            
            // verify the required parameter 'cardNo' is set
            if (cardNo == null) throw new ApiException(400, "Missing required parameter 'cardNo' when calling Retrieves  customer details by the specified card number");
            
    
            var path = "/loyalty/v2/accounts/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieves  customer details by the specified card number: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieves  customer details by the specified card number: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse) ApiClient.Deserialize(response.Content, typeof(RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse), response.Headers);
        }
    
        /// <summary>
        /// Update Loyalty Account for Retail Membership Account Updates the existing retail loyalty account with specified values.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void Update Loyalty Account for Retail Membership Account (UpdateLoyaltyAccountForRetailMembershipAccountRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Update Loyalty Account for Retail Membership Account");
            
    
            var path = "/loyalty/v2/accounts/retail";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Update Loyalty Account for Retail Membership Account: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Update Loyalty Account for Retail Membership Account: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
