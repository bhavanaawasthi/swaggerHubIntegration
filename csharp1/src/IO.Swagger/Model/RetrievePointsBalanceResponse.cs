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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// RetrievePointsBalanceResponse
    /// </summary>
    [DataContract]
    public partial class RetrievePointsBalanceResponse :  IEquatable<RetrievePointsBalanceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievePointsBalanceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RetrievePointsBalanceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievePointsBalanceResponse" /> class.
        /// </summary>
        /// <param name="PointsBalance"> (required).</param>
        public RetrievePointsBalanceResponse(int? PointsBalance = null)
        {
            // to ensure "PointsBalance" is required (not null)
            if (PointsBalance == null)
            {
                throw new InvalidDataException("PointsBalance is a required property for RetrievePointsBalanceResponse and cannot be null");
            }
            else
            {
                this.PointsBalance = PointsBalance;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pointsBalance", EmitDefaultValue=false)]
        public int? PointsBalance { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrievePointsBalanceResponse {\n");
            sb.Append("  PointsBalance: ").Append(PointsBalance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RetrievePointsBalanceResponse);
        }

        /// <summary>
        /// Returns true if RetrievePointsBalanceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RetrievePointsBalanceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrievePointsBalanceResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PointsBalance == other.PointsBalance ||
                    this.PointsBalance != null &&
                    this.PointsBalance.Equals(other.PointsBalance)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.PointsBalance != null)
                    hash = hash * 59 + this.PointsBalance.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
