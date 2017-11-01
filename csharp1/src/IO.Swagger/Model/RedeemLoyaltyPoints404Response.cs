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
    /// RedeemLoyaltyPoints404Response
    /// </summary>
    [DataContract]
    public partial class RedeemLoyaltyPoints404Response :  IEquatable<RedeemLoyaltyPoints404Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemLoyaltyPoints404Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RedeemLoyaltyPoints404Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemLoyaltyPoints404Response" /> class.
        /// </summary>
        /// <param name="Reason"> (required).</param>
        public RedeemLoyaltyPoints404Response(string Reason = null)
        {
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for RedeemLoyaltyPoints404Response and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedeemLoyaltyPoints404Response {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as RedeemLoyaltyPoints404Response);
        }

        /// <summary>
        /// Returns true if RedeemLoyaltyPoints404Response instances are equal
        /// </summary>
        /// <param name="other">Instance of RedeemLoyaltyPoints404Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedeemLoyaltyPoints404Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
