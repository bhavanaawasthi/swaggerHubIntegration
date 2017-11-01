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
    /// RedeemPointsRequest
    /// </summary>
    [DataContract]
    public partial class RedeemPointsRequest :  IEquatable<RedeemPointsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemPointsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RedeemPointsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemPointsRequest" /> class.
        /// </summary>
        /// <param name="PlayerId"> (required).</param>
        /// <param name="Points"> (required).</param>
        /// <param name="RedeemDateTime"> (required).</param>
        public RedeemPointsRequest(int? PlayerId = null, int? Points = null, string RedeemDateTime = null)
        {
            // to ensure "PlayerId" is required (not null)
            if (PlayerId == null)
            {
                throw new InvalidDataException("PlayerId is a required property for RedeemPointsRequest and cannot be null");
            }
            else
            {
                this.PlayerId = PlayerId;
            }
            // to ensure "Points" is required (not null)
            if (Points == null)
            {
                throw new InvalidDataException("Points is a required property for RedeemPointsRequest and cannot be null");
            }
            else
            {
                this.Points = Points;
            }
            // to ensure "RedeemDateTime" is required (not null)
            if (RedeemDateTime == null)
            {
                throw new InvalidDataException("RedeemDateTime is a required property for RedeemPointsRequest and cannot be null");
            }
            else
            {
                this.RedeemDateTime = RedeemDateTime;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="PlayerId", EmitDefaultValue=false)]
        public int? PlayerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Points", EmitDefaultValue=false)]
        public int? Points { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="RedeemDateTime", EmitDefaultValue=false)]
        public string RedeemDateTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedeemPointsRequest {\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  RedeemDateTime: ").Append(RedeemDateTime).Append("\n");
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
            return this.Equals(obj as RedeemPointsRequest);
        }

        /// <summary>
        /// Returns true if RedeemPointsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RedeemPointsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedeemPointsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlayerId == other.PlayerId ||
                    this.PlayerId != null &&
                    this.PlayerId.Equals(other.PlayerId)
                ) && 
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
                ) && 
                (
                    this.RedeemDateTime == other.RedeemDateTime ||
                    this.RedeemDateTime != null &&
                    this.RedeemDateTime.Equals(other.RedeemDateTime)
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
                if (this.PlayerId != null)
                    hash = hash * 59 + this.PlayerId.GetHashCode();
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                if (this.RedeemDateTime != null)
                    hash = hash * 59 + this.RedeemDateTime.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
