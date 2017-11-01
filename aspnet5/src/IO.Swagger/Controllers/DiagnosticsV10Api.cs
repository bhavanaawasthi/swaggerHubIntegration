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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class DiagnosticsV10ApiController : Controller
    { 

        /// <summary>
        /// Diagnose
        /// </summary>
        /// <remarks>The method allows to retrieve results of 3rd-aprty API or DB connectivity  diagnostics for specific service. Note, if service diagnostics is not configured  the response is internal server error 500 with a reason string. Possible diagnostic statuses are: OK, Failed, TimedOut, NotConfigured, FailedToCheck (usually a sign of misconfiguration).</remarks>
        /// <response code="200"></response>
        /// <response code="0">Unexpected error in API call. See HTTP response body for details.</response>
        [HttpGet]
        [Route("//retailmembership/v1/diagnose")]
        [SwaggerOperation("Diagnose")]
        [SwaggerResponse(200, type: typeof(DiagnoseResponse))]
        public virtual IActionResult Diagnose()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DiagnoseResponse>(exampleJson)
            : default(DiagnoseResponse);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Ping
        /// </summary>
        /// <remarks>The method is a basic ping which returns HTTP response with status code 200  if service is available at the endpoint.</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("//retailmembership/v1/ping")]
        [SwaggerOperation("Ping")]
        [SwaggerResponse(200, type: typeof(Object))]
        public virtual IActionResult Ping()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            return new ObjectResult(example);
        }
    }
}
