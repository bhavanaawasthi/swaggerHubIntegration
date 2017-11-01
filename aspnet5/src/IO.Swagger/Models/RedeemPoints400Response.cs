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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RedeemPoints400Response :  IEquatable<RedeemPoints400Response>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemPoints400Response" /> class.
        /// </summary>
        /// <param name="Reason"> (required).</param>
        public RedeemPoints400Response(string Reason = null)
        {
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for RedeemPoints400Response and cannot be null");
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
        [DataMember(Name="Reason")]
        public string Reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedeemPoints400Response {\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((RedeemPoints400Response)obj);
        }

        /// <summary>
        /// Returns true if RedeemPoints400Response instances are equal
        /// </summary>
        /// <param name="other">Instance of RedeemPoints400Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedeemPoints400Response other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

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

        #region Operators

        public static bool operator ==(RedeemPoints400Response left, RedeemPoints400Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RedeemPoints400Response left, RedeemPoints400Response right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
