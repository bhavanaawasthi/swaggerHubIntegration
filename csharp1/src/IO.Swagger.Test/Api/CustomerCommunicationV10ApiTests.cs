/* 
 * Res.Grosvenor - Rank
 *
 * Rank Enterprise Services API is a collection of business services exposed over a RESTful inteface. This endpoint is specific to Grosvenor Casinos implementation.
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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CustomerCommunicationV10Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerCommunicationV10ApiTests
    {
        private CustomerCommunicationV10Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerCommunicationV10Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerCommunicationV10Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerCommunicationV10Api
            //Assert.IsInstanceOfType(typeof(CustomerCommunicationV10Api), instance, "instance is a CustomerCommunicationV10Api");
        }

        
        /// <summary>
        /// Test SendEmail
        /// </summary>
        [Test]
        public void SendEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? playerId = null;
            //SendemailRequest body = null;
            //instance.SendEmail(playerId, body);
            
        }
        
    }

}
